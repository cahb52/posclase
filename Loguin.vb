Imports posclase.DBTableAdapters

Public Class Loguin

    ' TODO: inserte el c�digo para realizar autenticaci�n personalizada usando el nombre de usuario y la contrase�a proporcionada 
    ' (Consulte https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuaci�n: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementaci�n de IPrincipal utilizada para realizar la autenticaci�n. 
    ' Posteriormente, My.User devolver� la informaci�n de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim adaptador As New LoginTableAdapter()
        Dim tabla As DB.LoginDataTable = adaptador.GetDataLogin(UsernameTextBox.Text.Trim, PasswordTextBox.Text.Trim)

        If tabla.Rows.Count > 0 Then
            Dim fila = tabla(0)
            Sesion.VendedorDpiActual = fila.dpi
            Me.DialogResult = DialogResult.OK
        Else
            MessageBox.Show("Usuario o contrase�a incorrectos.")
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
