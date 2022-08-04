Public Class ManagerAddUser
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.ManagerPage.LoadUsersPage()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Name = NameInput.Text
        Dim Username = UsernameInput.Text
        Dim Password = PasswordInput.Text

        Dim IsManager As Boolean

        If (IsManagerInput.Text = "Manager") Then
            IsManager = True
        Else
            IsManager = False
        End If

        UserModule.AddUser(Name, Username, Password, IsManager)
    End Sub
End Class
