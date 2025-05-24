Module MainModule
    Sub Main()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)


        Dim loginForm As New Loguin()
        If loginForm.ShowDialog() = DialogResult.OK Then
            Application.Run(New Form1())
        End If
    End Sub
End Module