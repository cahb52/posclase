Public Class Empresa
    Private Sub EmpresaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EmpresaBindingNavigatorSaveItem.Click, BindingNavigatorDeleteItem.Click
        Try
            Me.Validate()
            Me.EmpresaBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DB)
        Catch ex As Exception
            Debug.WriteLine("Este es el error")
            Debug.WriteLine(ex.Message)
        End Try


    End Sub

    Private Sub Empresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DB.Empresa' Puede moverla o quitarla según sea necesario.
        Me.EmpresaTableAdapter.Fill(Me.DB.Empresa)

    End Sub
End Class