Public Class Facturas
    Private Sub FacturasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles FacturasBindingNavigatorSaveItem.Click, BindingNavigatorDeleteItem.Click
        Me.Validate()
        Me.FacturasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DB)

    End Sub

    Private Sub Facturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DB.Facturas' Puede moverla o quitarla según sea necesario.
        Me.FacturasTableAdapter.Fill(Me.DB.Facturas)

    End Sub
End Class