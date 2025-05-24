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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If String.IsNullOrEmpty(DpiTextBox.Text) Then
            MessageBox.Show("No hay dpi a comparar")
        Else
            Dim fechainicio As DateTime = DateTimePicker1.Value.Date
            Dim fechafin As DateTime = DateTimePicker2.Value.Date.AddDays(1).AddSeconds(-1)
            Debug.WriteLine(fechainicio.ToString("yyyy-MM-dd HH:mm:ss"))
            Debug.WriteLine(fechafin.ToString("yyyy-MM-dd HH:mm:ss"))
            ' Pasa fechainicio y fechafin correctamente al reporte o consulta
            Dim ventasxvendedor As New RptVentasxVendedor
            ventasxvendedor.dpi = DpiTextBox.Text
            ventasxvendedor.fecha_inicio = fechainicio
            ventasxvendedor.fecha_fin = fechafin
            ventasxvendedor.Show()
        End If

    End Sub

    Private Sub BtnreportedePedidos_Click(sender As Object, e As EventArgs) Handles BtnreportedePedidos.Click
        If String.IsNullOrEmpty(DpiTextBox.Text) Then
            MessageBox.Show("No hay DPI a comparar")
        Else
            Dim fechainicio As DateTime = DateTimePicker1.Value.Date
            Dim fechafin As DateTime = DateTimePicker2.Value.Date.AddDays(1).AddSeconds(-1)
            Debug.WriteLine(fechainicio.ToString("yyyy-MM-dd HH:mm:ss"))
            Debug.WriteLine(fechafin.ToString("yyyy-MM-dd HH:mm:ss"))
            ' Pasa fechainicio y fechafin correctamente al reporte o consulta
            Dim pedidosxvendedor As New RptPedidosxVendedor
            pedidosxvendedor.dpi = DpiTextBox.Text
            pedidosxvendedor.fecha_inico = fechainicio
            pedidosxvendedor.fecha_fin = fechafin
            pedidosxvendedor.Show()
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If String.IsNullOrEmpty(DpiTextBox.Text) Then
            MessageBox.Show("No hay dpi a comparar")
        Else
            Dim fechainicio As DateTime = DateTimePicker1.Value.Date
            Dim fechafin As DateTime = DateTimePicker2.Value.Date.AddDays(1).AddSeconds(-1)
            Debug.WriteLine(fechainicio.ToString("yyyy-MM-dd HH:mm:ss"))
            Debug.WriteLine(fechafin.ToString("yyyy-MM-dd HH:mm:ss"))
            ' Pasa fechainicio y fechafin correctamente al reporte o consulta
            Dim ventasxvendedor As New RptVentasxVendedor
            ventasxvendedor.dpi = ""
            ventasxvendedor.fecha_inicio = fechainicio
            ventasxvendedor.fecha_fin = fechafin
            ventasxvendedor.Show()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If String.IsNullOrEmpty(DpiTextBox.Text) Then
            MessageBox.Show("No hay DPI a comparar")
        Else
            Dim fechainicio As DateTime = DateTimePicker1.Value.Date
            Dim fechafin As DateTime = DateTimePicker2.Value.Date.AddDays(1).AddSeconds(-1)
            Debug.WriteLine(fechainicio.ToString("yyyy-MM-dd HH:mm:ss"))
            Debug.WriteLine(fechafin.ToString("yyyy-MM-dd HH:mm:ss"))
            ' Pasa fechainicio y fechafin correctamente al reporte o consulta
            Dim pedidosxvendedor As New RptPedidosxVendedor
            pedidosxvendedor.dpi = ""
            pedidosxvendedor.fecha_inico = fechainicio
            pedidosxvendedor.fecha_fin = fechafin
            pedidosxvendedor.Show()
        End If
    End Sub
End Class