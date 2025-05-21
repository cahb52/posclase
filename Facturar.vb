Imports System.Data.SqlClient
Imports posclase.DBTableAdapters

Public Class Facturar
    Public nitodpi As String = ""
    Private TotalFacturaQ As Decimal
    Private FacturaPedido As Int32 = 0
    Private Sub LimpiarCamposCliente()
        ' Limpia los campos si no hay coincidencia
        nitodpi = ""
        TxtNombres.Clear()
        TxtApellidos.Clear()
        TxtDireccion.Clear()
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If String.IsNullOrWhiteSpace(TextBox1.Text) Then
            LimpiarCamposCliente()
            Exit Sub
        End If
        Dim cliente As New ClientesTableAdapter()
        Dim filaCliente As DataTable = cliente.GetDataByBusquedaCliente(TextBox1.Text)

        If filaCliente.Rows.Count > 0 Then
            Dim fila As DataRow = filaCliente.Rows(0)

            ' Asumiendo que tienes estos TextBox en tu formulario:
            nitodpi = fila("nit").ToString()
            TxtNombres.Text = fila("nombres").ToString()
            TxtApellidos.Text = fila("apellidos").ToString()
            TxtDireccion.Text = fila("direccion").ToString()

        Else
            LimpiarCamposCliente()

        End If

    End Sub

    Private Sub TxtCodigo_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtCodigo.KeyDown
        If String.IsNullOrWhiteSpace(TextBox1.Text) Then
            Exit Sub
        Else
            If e.KeyCode = Keys.Enter Then
                Dim productos As New ProductosTableAdapter
                Dim productoObtenido As DataTable = productos.GetDataByCodigo(TxtCodigo.Text)
                If productoObtenido.Rows.Count > 0 Then
                    Dim fila As DataRow = productoObtenido.Rows(0)
                    Dim precioUnitario As Decimal
                    Dim precioCosto As Decimal = Convert.ToDecimal(fila("precio_costo").ToString())
                    If ChkPorcentaje.Checked Then
                        precioUnitario = Convert.ToDecimal(fila("precio_venta")) - (Convert.ToDecimal(fila("precio_venta")) * (Convert.ToDecimal(TxtDescuento.Text) / 100))
                    Else
                        precioUnitario = Convert.ToDecimal(fila("precio_venta")) - (Convert.ToDecimal(TxtDescuento.Text))
                        If precioUnitario <= precioCosto Then
                            MessageBox.Show("El precio final no debe ser menor al precio costo")
                            Exit Sub

                        End If
                    End If

                    Dim subTotal As Decimal = Convert.ToDecimal(TxtCantidad.Text) * precioUnitario
                    TotalFacturaQ += subTotal
                    TxtTotalFactura.Text = TotalFacturaQ.ToString("C2")
                    DetalleVenta.Rows.Add(
                        fila("codigo").ToString(),
                        fila("nombre").ToString(),
                        TxtCantidad.Text,
                        precioUnitario,
                        precioCosto,
                        subTotal)
                End If
            End If
        End If

    End Sub

    Private Sub DetalleVenta_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles DetalleVenta.UserDeletingRow
        Dim subtotal As Decimal = 0

        ' Asegurarse que la celda no sea nula y se pueda convertir
        If e.Row.Cells(5).Value IsNot Nothing AndAlso Decimal.TryParse(e.Row.Cells(5).Value.ToString(), subtotal) Then
            TotalFacturaQ -= subtotal
            TxtTotalFactura.Text = TotalFacturaQ.ToString("C2")

        End If
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If FacturaPedido = 1 Then
            GuardarPedidoDesdeXSD(DetalleVenta, TotalFacturaQ, nitodpi, "1311283", DtFechaEntrega.Value.Date)
        Else
            GuardarFacturaDesdeXSD(DetalleVenta, TotalFacturaQ, nitodpi, "1311283")
        End If

    End Sub



    Public Sub GuardarFacturaDesdeXSD(dgvDetalle As DataGridView, total As Decimal, cliente As String, vendedor As String)
        Using cn As New SqlConnection(My.Settings.negocioConnectionString) ' Reemplaza con tu cadena o Settings
            cn.Open()

            Using cmd As New SqlCommand("sp_GuardarFactura", cn)
                cmd.CommandType = CommandType.StoredProcedure

                ' Parámetros de la factura
                cmd.Parameters.AddWithValue("@fecha", DateTime.Now)
                cmd.Parameters.AddWithValue("@total", total)
                cmd.Parameters.AddWithValue("@cliente", cliente)
                cmd.Parameters.AddWithValue("@vendedor", vendedor)

                ' Crear tabla para los detalles
                Dim detalleTable As New DataTable()
                detalleTable.Columns.Add("codigo", GetType(String))
                detalleTable.Columns.Add("nombre", GetType(String))
                detalleTable.Columns.Add("cantidad", GetType(Decimal))
                detalleTable.Columns.Add("precio_unitario", GetType(Decimal))
                detalleTable.Columns.Add("precio_costo", GetType(Decimal))
                detalleTable.Columns.Add("subtotal", GetType(Decimal))

                ' Cargar datos desde DataGridView
                For Each row As DataGridViewRow In dgvDetalle.Rows
                    If Not row.IsNewRow Then
                        detalleTable.Rows.Add(
                        row.Cells("codigo").Value,
                        row.Cells("nombre").Value,
                        row.Cells("cantidad").Value,
                        row.Cells("precio_unitario").Value,
                        row.Cells("precio_costo").Value,
                        row.Cells("subtotal").Value
                    )
                    End If
                Next

                ' Parámetro tipo tabla
                Dim detalleParam As New SqlParameter("@detalle", SqlDbType.Structured)
                detalleParam.TypeName = "DetalleVentaTipo"
                detalleParam.Value = detalleTable
                cmd.Parameters.Add(detalleParam)

                ' Ejecutar
                cmd.ExecuteNonQuery()
            End Using
        End Using

        MessageBox.Show("Factura guardada correctamente.")
        LimpiarTodo()
    End Sub


    'aqui voy a generar el pedido

    Public Sub GuardarPedidoDesdeXSD(dgvDetalle As DataGridView, total As Decimal, cliente As String, vendedor As String, fechaentrega As Date)
        Using cn As New SqlConnection(My.Settings.negocioConnectionString) ' Reemplaza con tu cadena o Settings
            cn.Open()

            Using cmd As New SqlCommand("sp_GuardarPedido", cn)
                cmd.CommandType = CommandType.StoredProcedure

                ' Parámetros de la factura
                cmd.Parameters.AddWithValue("@fecha", DateTime.Now)
                cmd.Parameters.AddWithValue("@total", total)
                cmd.Parameters.AddWithValue("@cliente", cliente)
                cmd.Parameters.AddWithValue("@vendedor", vendedor)
                cmd.Parameters.AddWithValue("@fechaentrega", fechaentrega)

                ' Crear tabla para los detalles
                Dim detalleTable As New DataTable()
                detalleTable.Columns.Add("codigo", GetType(String))
                detalleTable.Columns.Add("nombre", GetType(String))
                detalleTable.Columns.Add("cantidad", GetType(Decimal))
                detalleTable.Columns.Add("precio_unitario", GetType(Decimal))
                detalleTable.Columns.Add("precio_costo", GetType(Decimal))
                detalleTable.Columns.Add("subtotal", GetType(Decimal))

                ' Cargar datos desde DataGridView
                For Each row As DataGridViewRow In dgvDetalle.Rows
                    If Not row.IsNewRow Then
                        detalleTable.Rows.Add(
                        row.Cells("codigo").Value,
                        row.Cells("nombre").Value,
                        row.Cells("cantidad").Value,
                        row.Cells("precio_unitario").Value,
                        row.Cells("precio_costo").Value,
                        row.Cells("subtotal").Value
                    )
                    End If
                Next

                ' Parámetro tipo tabla
                Dim detalleParam As New SqlParameter("@detalle", SqlDbType.Structured)
                detalleParam.TypeName = "DetalleVentaTipo"
                detalleParam.Value = detalleTable
                cmd.Parameters.Add(detalleParam)

                ' Ejecutar
                cmd.ExecuteNonQuery()
            End Using
        End Using

        MessageBox.Show("Pedido guardado correctamente.")
        LimpiarTodo()
    End Sub

    Private Sub ChkPedido_CheckedChanged(sender As Object, e As EventArgs) Handles ChkPedido.CheckedChanged
        If ChkPedido.Checked Then
            DtFechaEntrega.Enabled = True
            FacturaPedido = 1
        Else
            DtFechaEntrega.Enabled = False
            FacturaPedido = 0
        End If
    End Sub
    Private Sub LimpiarTodo()
        TxtApellidos.Text = String.Empty
        TxtCantidad.Text = 1
        TxtDescuento.Text = 0
        ChkPedido.Checked = False
        TxtCodigo.Text = String.Empty
        TxtDireccion.Text = String.Empty
        TxtNombres.Text = String.Empty
        DetalleVenta.Rows.Clear()
        TotalFacturaQ = 0
        TxtTotalFactura.Text = 0
        TextBox1.Text = String.Empty
        DtFechaEntrega.Value = DateTime.Now
        ChkPorcentaje.Checked = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim factura As New Factura
        factura.factura = 1
        factura.nitodpi = nitodpi
        factura.Show()

    End Sub
End Class