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
            Dim anticipo As Decimal = Convert.ToDecimal(TxtAnticipo.Text)
            GuardarPedidoDesdeXSD(DetalleVenta, TotalFacturaQ, nitodpi, Sesion.VendedorDpiActual, DtFechaEntrega.Value.Date, anticipo)
        Else
            Dim pagado As Decimal = Convert.ToDecimal(TxtPagado.Text)
            Dim tipopago As String = CmbTipoPago.SelectedText
            GuardarFacturaDesdeXSD(DetalleVenta, TotalFacturaQ, pagado, tipopago, nitodpi, Sesion.VendedorDpiActual)
        End If

    End Sub



    Public Sub GuardarFacturaDesdeXSD(dgvDetalle As DataGridView, total As Decimal, pagado As Decimal, tipopago As String, cliente As String, vendedor As String)
        Using cn As New SqlConnection(My.Settings.negocioConnectionString) ' Reemplaza con tu cadena o Settings
            cn.Open()

            Using cmd As New SqlCommand("sp_GuardarFactura", cn)
                cmd.CommandType = CommandType.StoredProcedure

                ' Parámetros de la factura
                cmd.Parameters.AddWithValue("@fecha", DateTime.Now)
                cmd.Parameters.AddWithValue("@total", total)
                cmd.Parameters.AddWithValue("@pagado", pagado)
                cmd.Parameters.AddWithValue("@tipopago", tipopago)
                cmd.Parameters.AddWithValue("@cliente", cliente)
                cmd.Parameters.AddWithValue("@vendedor", vendedor)


                ' Agregar parámetro de salida
                Dim facturaIdParam As New SqlParameter("@idfactura", SqlDbType.Int)
                facturaIdParam.Direction = ParameterDirection.Output
                cmd.Parameters.Add(facturaIdParam)

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
                ' Obtener resultados
                Dim facturaId As Integer = Convert.ToInt32(facturaIdParam.Value)
                Dim factura As New Factura
                factura.nitodpi = nitodpi
                factura.factura = facturaId
                factura.Show()
                MessageBox.Show("Factura guardada correctamente. No. " & facturaId)
            End Using
        End Using

        ' MessageBox.Show("Factura guardada correctamente.")
        LimpiarTodo()
    End Sub


    'aqui voy a generar el pedido

    Public Sub GuardarPedidoDesdeXSD(dgvDetalle As DataGridView, total As Decimal, cliente As String, vendedor As String, fechaentrega As Date, adelanto As Decimal)
        Using cn As New SqlConnection(My.Settings.negocioConnectionString) ' Reemplaza con tu cadena o Settings
            cn.Open()

            Using cmd As New SqlCommand("sp_GuardarPedido", cn)
                cmd.CommandType = CommandType.StoredProcedure

                ' Parámetros de la factura
                cmd.Parameters.AddWithValue("@fecha", DateTime.Now)
                cmd.Parameters.AddWithValue("@total", total)
                cmd.Parameters.AddWithValue("@adelanto", adelanto)
                cmd.Parameters.AddWithValue("@cliente", cliente)
                cmd.Parameters.AddWithValue("@vendedor", vendedor)
                cmd.Parameters.AddWithValue("@fechaentrega", fechaentrega)


                ' Agregar parámetro de salida
                Dim pedidoIdParam As New SqlParameter("@idpedido", SqlDbType.Int)
                pedidoIdParam.Direction = ParameterDirection.Output
                cmd.Parameters.Add(pedidoIdParam)



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
                ' Obtener resultado
                Dim pedidoId As Integer = Convert.ToInt32(pedidoIdParam.Value)
                Dim rptpedido As New RptPedido

                rptpedido.pedido = pedidoId
                rptpedido.Show()
                MessageBox.Show("Pedido guardado correctamente. No. " & pedidoId)
            End Using
        End Using

        ' MessageBox.Show("Pedido guardado correctamente.")
        LimpiarTodo()
    End Sub

    Private Sub ChkPedido_CheckedChanged(sender As Object, e As EventArgs) Handles ChkPedido.CheckedChanged
        If ChkPedido.Checked Then
            DtFechaEntrega.Enabled = True
            FacturaPedido = 1
            TxtAnticipo.ReadOnly = False
            TxtAnticipo.Text = 0
            CmbTipoPago.SelectedIndex = -1
            TxtPagado.Text = 0
            TxtPagado.ReadOnly = True
            TxtVuelto.Text = 0
            TxtVuelto.ReadOnly = True
            CmbTipoPago.Enabled = False
        Else
            DtFechaEntrega.Enabled = False
            FacturaPedido = 0
            TxtAnticipo.ReadOnly = True
            TxtAnticipo.Text = 0
            TxtRestante.Text = TotalFacturaQ.ToString("C2")
            CmbTipoPago.SelectedIndex = -1
            TxtPagado.Text = 0
            TxtPagado.ReadOnly = False
            TxtVuelto.Text = 0
            TxtVuelto.ReadOnly = False
            CmbTipoPago.Enabled = True
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

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim factura As New Factura
        factura.factura = 1
        factura.nitodpi = nitodpi
        factura.Show()

    End Sub

    Private Sub TxtAnticipo_TextChanged(sender As Object, e As EventArgs) Handles TxtAnticipo.TextChanged
        Dim anticipo As Decimal = 0
        If Decimal.TryParse(TxtAnticipo.Text, anticipo) Then
            Dim total As Decimal = TotalFacturaQ - anticipo
            TxtRestante.Text = total.ToString("C2")
        Else
            TxtRestante.Text = TotalFacturaQ.ToString("C2")
        End If

    End Sub

    Private Sub TxtPagado_TextChanged(sender As Object, e As EventArgs) Handles TxtPagado.TextChanged
        Dim vuelto As Decimal = 0
        Dim anticipoo As Decimal = 0

        If String.IsNullOrEmpty(TxtAnticipo.Text) Then
            anticipoo = 0
        Else
            Decimal.TryParse(TxtAnticipo.Text, anticipoo)
        End If


        vuelto = TotalFacturaQ - anticipoo
        TxtVuelto.Text = vuelto.ToString("C2")
    End Sub
End Class