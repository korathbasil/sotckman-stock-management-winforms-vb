Public Class Manager
    Dim EquityPage As ManagerEquity
    Dim IssueSharePage As ManagerIssueShare

    Dim UsersPage As ManagerUsers
    Dim AddUserPage As ManagerAddUser
    Private Sub Manager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEquityPage()
    End Sub

    Private Sub LoadDashboardPage()

    End Sub

    Public Sub LoadEquityPage()
        EquityPage = New ManagerEquity

        ManagerAppPanel.Controls.Clear()
        ManagerAppPanel.Controls.Add(EquityPage)
    End Sub

    Public Sub LoadIssueSharePage()
        IssueSharePage = New ManagerIssueShare

        ManagerAppPanel.Controls.Clear()
        ManagerAppPanel.Controls.Add(IssueSharePage)
    End Sub

    Public Sub LoadUsersPage()
        UsersPage = New ManagerUsers

        ManagerAppPanel.Controls.Clear()
        ManagerAppPanel.Controls.Add(UsersPage)
    End Sub

    Public Sub LoadAddUserPage()
        AddUserPage = New ManagerAddUser

        ManagerAppPanel.Controls.Clear()
        ManagerAppPanel.Controls.Add(AddUserPage)
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Form1.ManagerPage.LoadEquityPage()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Form1.ManagerPage.LoadUsersPage()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.LoggedInUserName = ""
        Form1.LoadLoginPage()
    End Sub
End Class