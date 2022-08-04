Public Class ManagerLogin
    Private Sub CreateManagerButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Dim Username = UsernameInput.Text
        Dim Password = PasswordInput.Text

        ManagerModule.ManagerLogin(Username, Password)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.LoadLoginPage()
    End Sub
End Class