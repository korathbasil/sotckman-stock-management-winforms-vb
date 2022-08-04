Imports MySql.Data.MySqlClient

Module ManagerModule
    Sub AddManager(Name As String, Username As String, Password As String)
        Dim Sql = "insert into users (name, username, password, is_manager) values(@Name, @Username, @Password, true)"
        Try
            Form1.DbConnection.Open()
            Dim Cmd = New MySqlCommand(Sql, Form1.DbConnection)

            Cmd.Parameters.AddWithValue("@Name", Name)
            Cmd.Parameters.AddWithValue("@Username", Username)
            Cmd.Parameters.AddWithValue("@Password", Password)

            Dim Res = Cmd.ExecuteScalar()

            Form1.DbConnection.Close()
            ' Navigate to admin page
            Form1.LoadManagerPage()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Form1.DbConnection.Close()
        End Try
    End Sub

    Sub ManagerLogin(Username As String, password As String)
        Dim Sql = "select name, username, password, is_manager from users where username=@Username"
        Try
            Form1.DbConnection.Open()
            Dim Cmd = New MySqlCommand(Sql, Form1.DbConnection)
            Cmd.Parameters.AddWithValue("@Username", Username)

            Dim Reader = Cmd.ExecuteReader

            If Reader.Read() = True Then
                If Reader("is_manager") = True Then
                    If Reader("password") = password Then
                        Dim Name = Reader("name")
                        Form1.LoggedInUserName = Name

                        Form1.DbConnection.Close()
                        Form1.LoadManagerPage()
                    Else
                        MessageBox.Show("Invalid password")
                    End If
                Else
                    MessageBox.Show("Invalid username")
                End If
            Else
                MessageBox.Show("Invalid username")
            End If



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Form1.DbConnection.Close()
        End Try
    End Sub

End Module
