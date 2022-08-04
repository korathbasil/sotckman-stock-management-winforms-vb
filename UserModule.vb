Imports MySql.Data.MySqlClient

Module UserModule
    Public UserExists = False
    Public Users As New List(Of UserModel)

    Sub IsUsersExists()
        Dim Cmd = New MySqlCommand("select * from users", Form1.DbConnection)

        Try
            Form1.DbConnection.Open()
            Dim Reader = Cmd.ExecuteReader()

            If Reader.HasRows() = True Then
                UserExists = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            Form1.DbConnection.Close()
        End Try
    End Sub

    Sub LoadUserData()
        Users.Clear()
        Dim Cmd = New MySqlCommand("select * from users", Form1.DbConnection)

        Try
            Form1.DbConnection.Open()
            Dim Reader = Cmd.ExecuteReader()

            If Reader.HasRows Then
                While Reader.Read()
                    Users.Add(New UserModel With {
                        .Id = Reader("id"),
                        .Name = Reader("name"),
                        .Username = Reader("username"),
                        .IsManager = Reader("is_manager")
                    })
                End While
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            Form1.DbConnection.Close()
        End Try
    End Sub

    Sub AddUser(Name As String, Username As String, Password As String, IsManager As Boolean)
        Dim Sql1 = "select name, username, password, is_manager from users where username=@Username"
        Dim Sql2 = "insert into users (name, username, password, is_manager) values (@Name, @Username, @Password, @IsManager)"



        Try
            Form1.DbConnection.Open()

            ' Check if the user already exists
            Dim CheckCmd = New MySqlCommand(Sql1, Form1.DbConnection)
            CheckCmd.Parameters.AddWithValue("@Username", Username)
            Dim Reader = CheckCmd.ExecuteReader

            If Reader.Read() = True Then
                MessageBox.Show("User laready exists")
                Return
            End If
            Form1.DbConnection.Close()

            ' Adding new user
            Form1.DbConnection.Open()
            Dim Cmd = New MySqlCommand(Sql2, Form1.DbConnection)
            Cmd.Parameters.AddWithValue("@Name", Name)
            Cmd.Parameters.AddWithValue("@Username", Username)
            Cmd.Parameters.AddWithValue("@Password", Password)
            Cmd.Parameters.AddWithValue("@IsManager", IsManager)
            Cmd.ExecuteScalar()

            Form1.DbConnection.Close()

            ' Navigate to user management page
            Form1.ManagerPage.LoadUsersPage()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            Form1.DbConnection.Dispose()
        End Try
    End Sub
End Module

Public Class UserModel
    Public Id As Integer
    Public Name As String
    Public Username As String
    Public IsManager As Boolean
End Class
