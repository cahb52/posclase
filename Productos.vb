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

    Private Sub BtnProductosExistencias_Click(sender As Object, e As EventArgs) Handles BtnProductosExistencias.Click
        Dim productosyexistencias As New ProductoyExistencia
        productosyexistencias.Show()
    End Sub

    Private Sub BtnVentasXProducto_Click_1(sender As Object, e As EventArgs) Handles BtnVentasXProducto.Click
        Dim ventasxproducto As New ReporteVentasxProducto
        ventasxproducto.fechainicio = DateFechaInicio.Value
        ventasxproducto.fechafin = DateFechaFin.Value
        ventasxproducto.Show()
    End Sub
End Class