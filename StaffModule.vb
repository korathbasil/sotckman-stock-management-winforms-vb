
Imports MySql.Data.MySqlClient
Module StaffModule
    Sub StaffLogin(Username As String, password As String)
        Dim Sql = "select name, username, password, is_manager from users where username=@Username"
        Try
            Form1.DbConnection.Open()
            Dim Cmd = New MySqlCommand(Sql, Form1.DbConnection)
            Cmd.Parameters.AddWithValue("@Username", Username)

            Dim Reader = Cmd.ExecuteReader

            If Reader.Read() = True Then
                If Reader("is_manager") = False Then
                    If Reader("password") = password Then
                        Dim Name = Reader("name")
                        Form1.LoggedInUserName = Name

                        Form1.DbConnection.Close()
                        Form1.LoadStaffPage()
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
