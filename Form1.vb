Imports MySql.Data.MySqlClient

Public Class Form1
    Public DbConnection As MySqlConnection

    Public LoggedInUserName As String

    Dim FormLogin As LoginForm
    Public StaffPage As Staff

    Dim UserPage As User

    Dim AddManagerPage As AddManager
    Dim ManagerLoginPage As ManagerLogin
    Public ManagerPage As Manager

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitDbConnection()
        LoadInitailPage()
    End Sub

    Private Sub InitDbConnection()
        Dim ConnectionString = "server=127.0.0.1;uid=root;pwd=admin;database=stockman"
        DbConnection = New MySqlConnection With {
            .ConnectionString = ConnectionString
        }

        ' Create tables
        DbHelper.CreateTables()
    End Sub

    Private Sub LoadInitailPage()
        UserModule.IsUsersExists()
        If UserModule.UserExists = True Then
            LoadLoginPage()
        Else
            LoadAddManagerPage()
        End If
    End Sub

    Public Sub LoadLoginPage()
        FormLogin = New LoginForm
        FormLogin.FormBorderStyle = BorderStyle.None
        FormLogin.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        FormLogin.TopLevel = False
        Panel1.Controls.Clear()
        Panel1.Controls.Add(FormLogin)
        FormLogin.Show()
    End Sub

    Public Sub LoadStaffPage()
        StaffPage = New Staff With {
            .TopLevel = False,
            .FormBorderStyle = FormBorderStyle.None
        }

        Panel1.Controls.Clear()
        Panel1.Controls.Add(StaffPage)
        StaffPage.Show()
    End Sub


    Public Sub LoadUserPage()
        UserPage = New User With {
            .TopLevel = False,
            .FormBorderStyle = FormBorderStyle.None
        }

        Panel1.Controls.Clear()
        Panel1.Controls.Add(UserPage)
        UserPage.Show()
    End Sub

    Public Sub LoadAddManagerPage()
        AddManagerPage = New AddManager With {
            .TopLevel = False,
            .FormBorderStyle = FormBorderStyle.None
        }

        Panel1.Controls.Clear()
        Panel1.Controls.Add(AddManagerPage)
        AddManagerPage.Show()
    End Sub

    Public Sub LoadManagerLoginPage()
        ManagerLoginPage = New ManagerLogin With {
            .TopLevel = False,
            .FormBorderStyle = FormBorderStyle.None
        }

        Panel1.Controls.Clear()
        Panel1.Controls.Add(ManagerLoginPage)
        ManagerLoginPage.Show()
    End Sub

    Public Sub LoadManagerPage()
        ManagerPage = New Manager With {
            .TopLevel = False,
            .FormBorderStyle = FormBorderStyle.None
        }

        Panel1.Controls.Clear()
        Panel1.Controls.Add(ManagerPage)
        ManagerPage.Show()
    End Sub

End Class
