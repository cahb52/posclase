Public Class Facturas
    Private Sub FacturasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles FacturasBindingNavigatorSaveItem.Click, BindingNavigatorDeleteItem.Click
        Me.Validate()
        Me.FacturasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DB)

    End Sub

    Private Sub Facturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DB.Detalle_Ventas' Puede moverla o quitarla según sea necesario.
        Me.Detalle_VentasTableAdapter.Fill(Me.DB.Detalle_Ventas)
        'TODO: esta línea de código carga datos en la tabla 'DB.Vendedores' Puede moverla o quitarla según sea necesario.
        Me.VendedoresTableAdapter.Fill(Me.DB.Vendedores)
        'TODO: esta línea de código carga datos en la tabla 'DB.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.DB.Clientes)
        'TODO: esta línea de código carga datos en la tabla 'DB.Facturas' Puede moverla o quitarla según sea necesario.
        Me.FacturasTableAdapter.Fill(Me.DB.Facturas)

    End Sub

    Private Sub BtnImprimir_Click(sender As Object, e As EventArgs) Handles BtnImprimir.Click
        Dim facturasconnombres As New RptFacturasConNombres
        facturasconnombres.fechainicio = DtFechaInicio.Value.Date
        facturasconnombres.fechafin = DtFechaFin.Value.Date.AddDays(1).AddSeconds(-1)
        facturasconnombres.Show()
    End Sub
End Class