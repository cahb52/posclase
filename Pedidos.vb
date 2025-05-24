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
End Class