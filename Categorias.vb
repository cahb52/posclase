Public Class Categorias
    Private Sub CategoriasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CategoriasBindingNavigatorSaveItem.Click, BindingNavigatorDeleteItem.Click
        Me.Validate()
        Me.CategoriasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DB)

    End Sub

    Private Sub Categorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DB.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.DB.Productos)
        'TODO: esta línea de código carga datos en la tabla 'DB.Categorias' Puede moverla o quitarla según sea necesario.
        Me.CategoriasTableAdapter.Fill(Me.DB.Categorias)

    End Sub
End Class