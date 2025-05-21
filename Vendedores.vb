Public Class Vendedores
    Private Sub VendedoresBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles VendedoresBindingNavigatorSaveItem.Click, BindingNavigatorDeleteItem.Click
        Me.Validate()
        Me.VendedoresBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DB)

    End Sub

    Private Sub Vendedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DB.Vendedores' Puede moverla o quitarla según sea necesario.
        Me.VendedoresTableAdapter.Fill(Me.DB.Vendedores)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim reporteVendedores As New RptVendedores
        reporteVendedores.Show()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        Dim texto As String = TxtBuscar.Text.Trim()

        If texto = "" Then
            VendedoresBindingSource.RemoveFilter()
        Else
            ' Escapamos comillas simples en el texto para evitar errores de sintaxis
            Dim textoEscapado As String = texto.Replace("'", "''")

            ' Filtro que busca coincidencias en múltiples campos
            Dim filtro As String =
            "nombres LIKE '%" & textoEscapado & "%' OR " &
            "apellidos LIKE '%" & textoEscapado & "%' OR " &
            "dpi LIKE '%" & textoEscapado & "%'"

            VendedoresBindingSource.Filter = filtro
        End If
    End Sub
End Class