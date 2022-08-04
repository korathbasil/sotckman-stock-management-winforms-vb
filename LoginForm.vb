Public Class LoginForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.LoadManagerLoginPage()
    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Dim Username = UsernameInput.Text
        Dim Password = PasswordInput.Text

        StaffModule.StaffLogin(Username, Password)
    End Sub
End Class