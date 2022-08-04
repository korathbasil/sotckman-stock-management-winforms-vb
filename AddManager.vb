Public Class AddManager
    Private Sub CreateManagerButton_Click(sender As Object, e As EventArgs) Handles CreateManagerButton.Click
        Dim Name = NameInput.Text
        Dim Username = UsernameInput.Text
        Dim Password = PasswordInput.Text

        ManagerModule.AddManager(Name, Username, Password)
    End Sub
End Class