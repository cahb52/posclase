Public Class Clientes
    Private Sub ClientesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ClientesBindingNavigatorSaveItem.Click, BindingNavigatorDeleteItem.Click
        Me.Validate()
        Me.ClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DB)

    End Sub

    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DB.Detalle_Ventas' Puede moverla o quitarla según sea necesario.

        'TODO: esta línea de código carga datos en la tabla 'DB.Facturas' Puede moverla o quitarla según sea necesario.
        Me.FacturasTableAdapter.Fill(Me.DB.Facturas)
        'TODO: esta línea de código carga datos en la tabla 'DB.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.DB.Clientes)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        Dim texto As String = TxtBuscar.Text.Trim()

        If texto = "" Then
            ClientesBindingSource.RemoveFilter()
        Else
            ' Escapamos comillas simples en el texto para evitar errores de sintaxis
            Dim textoEscapado As String = texto.Replace("'", "''")

            ' Filtro que busca coincidencias en múltiples campos
            Dim filtro As String =
            "nombres LIKE '%" & textoEscapado & "%' OR " &
            "apellidos LIKE '%" & textoEscapado & "%' OR " &
            "nit LIKE '%" & textoEscapado & "%' OR " &
            "email LIKE '%" & textoEscapado & "%'"

            ClientesBindingSource.Filter = filtro
        End If
    End Sub

    Private Sub BtnReporteClientes_Click(sender As Object, e As EventArgs) Handles BtnReporteClientes.Click
        Dim reporteClientes As New RptClientes
        reporteClientes.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim reportecomprascliente As New ReporteComprasCliente
        reportecomprascliente.nit = NitTextBox.Text
        reportecomprascliente.fechainicio = DateFechaInicio.Value
        reportecomprascliente.fechafin = DateFechaFin.Value
        reportecomprascliente.Show()
    End Sub
End Class