Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices

Public Class Pedidos
    Private Sub PedidosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PedidosBindingNavigatorSaveItem.Click, BindingNavigatorDeleteItem.Click
        Me.Validate()
        Me.PedidosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DB)

    End Sub

    Private Sub Pedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DB.Vendedores' Puede moverla o quitarla según sea necesario.
        Me.VendedoresTableAdapter.Fill(Me.DB.Vendedores)
        'TODO: esta línea de código carga datos en la tabla 'DB.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.DB.Clientes)
        'TODO: esta línea de código carga datos en la tabla 'DB.Detalle_Pedido' Puede moverla o quitarla según sea necesario.
        Me.Detalle_PedidoTableAdapter.Fill(Me.DB.Detalle_Pedido)
        'TODO: esta línea de código carga datos en la tabla 'DB.Pedidos' Puede moverla o quitarla según sea necesario.
        Me.PedidosTableAdapter.Fill(Me.DB.Pedidos)


    End Sub

    Private Sub EstadoTextBox_TextChanged(sender As Object, e As EventArgs) Handles EstadoTextBox.TextChanged
        If EstadoTextBox.Text = 1 Then
            BtnFacturar.Enabled = False
            PedidosBindingNavigator.DeleteItem.Enabled = False
            BtnFacturar.Enabled = False
        Else
            BtnFacturar.Enabled = True
            PedidosBindingNavigator.DeleteItem.Enabled = True
            BtnFacturar.Enabled = True
        End If
    End Sub

    Private Sub BtnImprimir_Click(sender As Object, e As EventArgs) Handles BtnImprimir.Click

        Dim facturaId As Integer = Convert.ToInt32(IdpedidoTextBox.Text.Trim)
        Dim rptpedido As New RptPedido
        rptpedido.pedido = facturaId
        rptpedido.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pedidosporfechas As New RptPedidosporRangodeFechas
        pedidosporfechas.fechainicio = DtFechaInicio.Value.Date
        pedidosporfechas.fechafin = DtFechaFin.Value.Date.AddDays(1).AddSeconds(-1)
        pedidosporfechas.Show()
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
                factura.nitodpi = cliente
                factura.factura = facturaId
                factura.Show()
                MessageBox.Show("Factura guardada correctamente. No. " & facturaId)
            End Using
        End Using

        ' MessageBox.Show("Factura guardada correctamente.")
        ' Actualizando los datos en el formulario después de guardar la factura correctamente. y Cambiando el estado del pedido a 1
        ' Cambiar el estado del pedido a 1 (facturado)
        Dim posicion As Integer = IdpedidoTextBox.Text

        If Not String.IsNullOrEmpty(IdpedidoTextBox.Text) Then
            Dim pedidoId As Integer = Convert.ToInt32(IdpedidoTextBox.Text)
            Using cn As New SqlConnection(My.Settings.negocioConnectionString)
                cn.Open()
                Using cmd As New SqlCommand("UPDATE Pedidos SET Estado = 1 WHERE IdPedido = @IdPedido", cn)
                    cmd.Parameters.AddWithValue("@IdPedido", pedidoId)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            ' Actualizar el estado en el formulario
            EstadoTextBox.Text = "1"
        End If
        Me.PedidosTableAdapter.Fill(Me.DB.Pedidos)
        Me.Detalle_PedidoTableAdapter.Fill(Me.DB.Detalle_Pedido)
        Me.ClientesTableAdapter.Fill(Me.DB.Clientes)
        Me.VendedoresTableAdapter.Fill(Me.DB.Vendedores)
        ' Limpiar los campos de entrada
        AdelantoTextBox.Clear()
        TotalTextBox.Clear()
        CmbTipoPago.SelectedIndex = -1
        ClientesComboBox.SelectedIndex = -1
        ' Deshabilitar el botón de facturar después de guardar la factura
        BtnFacturar.Enabled = False
        PedidosBindingNavigator.DeleteItem.Enabled = False
        BtnFacturar.Enabled = False
        ' mover el bindingnavigator hasta el id del pedido que fue facturado
        If Not String.IsNullOrEmpty(posicion) Then
            Dim bindingSource As BindingSource = Me.PedidosBindingSource
            Dim position As Integer = bindingSource.Find("IdPedido", posicion)
            If position >= 0 Then
                bindingSource.Position = position
            End If
        End If




    End Sub

    Private Sub BtnFacturar_Click(sender As Object, e As EventArgs) Handles BtnFacturar.Click
        Dim pagado As Decimal
        Dim tipopago As String = CmbTipoPago.SelectedItem.ToString().Trim()
        MessageBox.Show("Tipo de pago: " & tipopago)
        If String.IsNullOrEmpty(AdelantoTextBox.Text) Then
            pagado = 0
        Else
            pagado = Convert.ToDecimal(AdelantoTextBox.Text)
        End If
        If String.IsNullOrEmpty(tipopago) Then
            MessageBox.Show("Debe seleccionar un tipo de pago.")
            Return
        End If
        ' Si el monto de adelanto es mayor a 0 entonces mostrará un mensaje indicando que solo debe pagar lo restante
        If pagado > 0 Then
            Dim total As Decimal = Convert.ToDecimal(TotalTextBox.Text)
            Dim restante As Decimal = total - pagado
            If restante > 0 Then
                MessageBox.Show("Debe pagar solamente el restante de Q" & restante.ToString("F2") & ".")
            End If
        End If

        GuardarFacturaDesdeXSD(DataGridView1, TotalTextBox.Text, pagado, tipopago, ClientesComboBox.SelectedValue, Sesion.VendedorDpiActual)

    End Sub
End Class