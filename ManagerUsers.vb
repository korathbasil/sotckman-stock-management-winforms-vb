Public Class ManagerUsers
    Private Sub ManagerUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserModule.LoadUserData()
        Dim CurrentItem = 0
        For Each User As UserModel In UserModule.Users
            UsersListView.Items.Add(User.Id)
            UsersListView.Items(CurrentItem).SubItems.Add(User.Name)
            CurrentItem += 1
        Next

        CurrentItem = 0
        For Each User As UserModel In UserModule.Users
            UsersListView.Items(CurrentItem).SubItems.Add(User.Username)
            CurrentItem += 1
        Next

        CurrentItem = 0
        For Each User As UserModel In UserModule.Users
            If User.IsManager Then
                UsersListView.Items(CurrentItem).SubItems.Add("Manager")
            Else
                UsersListView.Items(CurrentItem).SubItems.Add("Staff")
            End If
            CurrentItem += 1
        Next
    End Sub

    Private Sub GoToAddUserPageButton_Click(sender As Object, e As EventArgs) Handles GoToAddUserPageButton.Click
        Form1.ManagerPage.LoadAddUserPage()
    End Sub
End Class
