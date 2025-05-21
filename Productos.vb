Public Class Productos
    Private Sub ProductosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProductosBindingNavigatorSaveItem.Click, BindingNavigatorDeleteItem.Click

        Me.Validate()
        Me.ProductosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DB)

    End Sub

    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DB.Categorias' Puede moverla o quitarla según sea necesario.
        Me.CategoriasTableAdapter.Fill(Me.DB.Categorias)

        'TODO: esta línea de código carga datos en la tabla 'DB.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.DB.Productos)

    End Sub
End Class