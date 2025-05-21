Public Class Proveedores
    Private Sub ProveedoresBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProveedoresBindingNavigatorSaveItem.Click, BindingNavigatorDeleteItem.Click
        Me.Validate()
        Me.ProveedoresBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DB)

    End Sub

    Private Sub Proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DB.Proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.DB.Proveedores)

    End Sub
End Class