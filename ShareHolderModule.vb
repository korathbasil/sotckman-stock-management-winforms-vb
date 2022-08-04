Imports MySql.Data.MySqlClient

Module ShareHolderModule
    Public ShareHolders As New List(Of ShareHolderModel)
    Public ShareHolderExists As Boolean
    Public SelectedShareHolder As ShareHolderModel
    Public ShareHolderShares As New List(Of ShareHolderShareModel)

    Sub AddNewShareHolder(SH As ShareHolderModel)
        Dim Sql = "insert into share_holders (name, age, gender, phone, aadhaar, addr1, addr2, addr3, pin) values(@Name, @Age, @Gender, @Phone, @Aadhaar, @Addr1, @Addr2, @Addr3, @PIN )"
        Dim Cmd = New MySqlCommand(Sql, Form1.DbConnection)
        Cmd.Parameters.AddWithValue("@Name", SH.Name)
        Cmd.Parameters.AddWithValue("@Age", SH.Age)
        Cmd.Parameters.AddWithValue("@Gender", SH.Gender)
        Cmd.Parameters.AddWithValue("@Phone", SH.Phone)
        Cmd.Parameters.AddWithValue("@Aadhaar", SH.Aadhaar)
        Cmd.Parameters.AddWithValue("@Addr1", SH.Addr1)
        Cmd.Parameters.AddWithValue("@Addr2", SH.Addr2)
        Cmd.Parameters.AddWithValue("@Addr3", SH.Addr3)
        Cmd.Parameters.AddWithValue("@PIN", SH.PIN)

        Try
            Form1.DbConnection.Open()
            Cmd.ExecuteNonQuery()

            Form1.DbConnection.Close()
            Form1.StaffPage.LoadShareHoldersPage()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Form1.DbConnection.Close()
        End Try
    End Sub

    Sub UpdateShareHolder(SH As ShareHolderModel)
        Dim Sql = "update share_holders set name = @Name, age = @Age, gender = @Gender, phone = @Phone, aadhaar = @Aadhaar, addr1 = @Addr1, addr2 = @Addr2, addr3 = @Addr3, pin = @PIN where id = @Id"
        Dim Cmd = New MySqlCommand(Sql, Form1.DbConnection)
        Cmd.Parameters.AddWithValue("Id", SH.Id)
        Cmd.Parameters.AddWithValue("@Name", SH.Name)
        Cmd.Parameters.AddWithValue("@Age", SH.Age)
        Cmd.Parameters.AddWithValue("@Gender", SH.Gender)
        Cmd.Parameters.AddWithValue("@Phone", SH.Phone)
        Cmd.Parameters.AddWithValue("@Aadhaar", SH.Aadhaar)
        Cmd.Parameters.AddWithValue("@Addr1", SH.Addr1)
        Cmd.Parameters.AddWithValue("@Addr2", SH.Addr2)
        Cmd.Parameters.AddWithValue("@Addr3", SH.Addr3)
        Cmd.Parameters.AddWithValue("@PIN", SH.PIN)

        Try
            Form1.DbConnection.Open()
            Cmd.ExecuteNonQuery()

            Form1.DbConnection.Close()
            Form1.StaffPage.LoadShareHoldersPage()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Form1.DbConnection.Close()
        End Try
    End Sub
    Sub GetShareHolderById(Id As Integer)
        Dim Sql = "select * from share_holders where id = @Id"

        Dim Cmd = New MySqlCommand(Sql, Form1.DbConnection)
        Cmd.Parameters.AddWithValue("@Id", Id)

        Try
            Form1.DbConnection.Open()
            Dim Reader = Cmd.ExecuteReader

            Reader.Read()
            If (Reader.HasRows()) Then
                ShareHolderExists = True
                SelectedShareHolder = New ShareHolderModel With {
                    .Id = Reader("id"),
                    .Name = Reader("name"),
                    .Age = Reader("age"),
                    .Gender = Reader("gender"),
                    .Phone = Reader("phone"),
                    .Aadhaar = Reader("aadhaar"),
                    .Addr1 = Reader("addr1"),
                    .Addr2 = Reader("addr2"),
                    .Addr3 = Reader("addr3"),
                    .PIN = Reader("pin")
                }
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Form1.DbConnection.Close()
        End Try
    End Sub

    Sub LoadShareHoldersData()
        ShareHolders.Clear()

        Dim Sql = "select * from share_holders"
        Dim Cmd = New MySqlCommand(Sql, Form1.DbConnection)

        Try
            Form1.DbConnection.Open()
            Dim Reader = Cmd.ExecuteReader()

            If (Reader.HasRows()) Then
                While Reader.Read()
                    Dim SH = New ShareHolderModel With {
                        .Id = Reader("id"),
                        .Name = Reader("name"),
                        .Phone = Reader("phone")
                    }

                    ShareHolders.Add(SH)
                End While
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Form1.DbConnection.Close()
        End Try

    End Sub

    Sub BuyShares(ShareIssueId As Integer, ShareHolderId As Integer, Quantity As Integer)
        Dim Sql1 = "select * from share_holder_shares where share_holder_id = @ShareHolderId and share_issue_id = @ShareIssueId"
        Dim Sql2 = "insert into share_holder_shares (quantity, share_holder_id, share_issue_id) values (@Quantity, @ShareHolderId, @ShareIssueId)"
        Dim Sql3 = "update share_holder_shares set quantity = (@Quantity + quantity) where share_holder_id = @ShareHolderId and share_issue_id = @ShareIssueId"
        Dim Sql4 = "update share_issues set unsold_quantity = (unsold_quantity - @Quantity) where id = @Id"

        Dim Cmd1 = New MySqlCommand(Sql1, Form1.DbConnection)
        Cmd1.Parameters.AddWithValue("@ShareHolderId", ShareHolderId)
        Cmd1.Parameters.AddWithValue("@ShareIssueId", ShareIssueId)

        Try
            Form1.DbConnection.Open()
            Dim R = Cmd1.ExecuteReader()

            R.Read()

            If (R.HasRows()) Then
                Dim Cmd3 = New MySqlCommand(Sql3, Form1.DbConnection)
                Cmd3.Parameters.AddWithValue("@Quantity", Quantity)
                Cmd3.Parameters.AddWithValue("@ShareHolderId", ShareHolderId)
                Cmd3.Parameters.AddWithValue("@ShareIssueId", ShareIssueId)

                R.Close()
                Cmd3.ExecuteNonQuery()

                Dim Cmd4 = New MySqlCommand(Sql4, Form1.DbConnection)
                Cmd4.Parameters.AddWithValue("Quantity", Quantity)
                Cmd4.Parameters.AddWithValue("@id", ShareIssueId)

                Cmd4.ExecuteNonQuery()

                Form1.DbConnection.Close()
                Form1.StaffPage.LoadShareHolderAccountPage()
            Else
                Dim Cmd2 = New MySqlCommand(Sql2, Form1.DbConnection)
                Cmd2.Parameters.AddWithValue("@Quantity", Quantity)
                Cmd2.Parameters.AddWithValue("@ShareHolderId", ShareHolderId)
                Cmd2.Parameters.AddWithValue("@ShareIssueId", ShareIssueId)

                R.Close()
                Cmd2.ExecuteNonQuery()

                Dim Cmd4 = New MySqlCommand(Sql4, Form1.DbConnection)
                Cmd4.Parameters.AddWithValue("Quantity", Quantity)
                Cmd4.Parameters.AddWithValue("@id", ShareIssueId)

                Cmd4.ExecuteNonQuery()

                Form1.DbConnection.Close()
                Form1.StaffPage.LoadShareHolderAccountPage()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Form1.DbConnection.Close()
        End Try
    End Sub

    Sub SellShares(ShareHolderShareId As Integer, ShareIssueId As Integer, Quantity As Integer, DeleteRequired As Boolean)
        If (DeleteRequired) Then
            Dim Sql1 = "delete from share_holder_shares where id = @Id"
            Dim Cmd1 = New MySqlCommand(Sql1, Form1.DbConnection)
            Cmd1.Parameters.AddWithValue("@Id", ShareHolderShareId)

            Dim Sql2 = "update share_issues set unsold_quantity = (unsold_quantity + @Qty) where id = @ShareIssueId"
            Dim Cmd2 = New MySqlCommand(Sql2, Form1.DbConnection)
            Cmd2.Parameters.AddWithValue("@Qty", Quantity)
            Cmd2.Parameters.AddWithValue("@ShareIssueId", ShareIssueId)

            Try
                Form1.DbConnection.Open()
                Cmd1.ExecuteNonQuery()
                Cmd2.ExecuteNonQuery()

                Form1.DbConnection.Close()
                Form1.StaffPage.LoadShareHolderAccountPage()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                Form1.DbConnection.Close()
            End Try
        Else
            Dim Sql1 = "update share_holder_shares set quantity = (quantity - @Qty) where id = @Id"
            Dim Cmd1 = New MySqlCommand(Sql1, Form1.DbConnection)
            Cmd1.Parameters.AddWithValue("@Qty", Quantity)
            Cmd1.Parameters.AddWithValue("@Id", ShareHolderShareId)

            Dim Sql2 = "update share_issues set unsold_quantity = (unsold_quantity + @Qty) where id = @ShareIssueId"
            Dim Cmd2 = New MySqlCommand(Sql2, Form1.DbConnection)
            Cmd2.Parameters.AddWithValue("@Qty", Quantity)
            Cmd2.Parameters.AddWithValue("@ShareIssueId", ShareIssueId)

            Try
                Form1.DbConnection.Open()
                Cmd1.ExecuteNonQuery()
                Cmd2.ExecuteNonQuery()

                Form1.DbConnection.Close()
                Form1.StaffPage.LoadShareHolderAccountPage()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                Form1.DbConnection.Close()
            End Try
        End If
    End Sub

    Sub TransferShares(ShareHolderShareId As Integer, ShareIssueId As Integer, TargetShareHolderId As Integer, Quantity As Integer, DeleteRequired As Boolean)
        If (DeleteRequired) Then
            Dim Sql1 = "delete from share_holder_shares where id = @Id"
            Dim Cmd1 = New MySqlCommand(Sql1, Form1.DbConnection)
            Cmd1.Parameters.AddWithValue("@Id", ShareHolderShareId)

            Dim Sql2 = "select * from share_holder_shares where share_holder_id = @TargetShareHolderId and share_issue_id = @ShareIssueId"
            Dim Cmd2 = New MySqlCommand(Sql2, Form1.DbConnection)
            Cmd2.Parameters.AddWithValue("@TargetShareHolderId", TargetShareHolderId)
            Cmd2.Parameters.AddWithValue("@ShareIssueId", ShareIssueId)

            Dim Sql3 = "update share_holder_shares set quantity = (quantity + @Qty) where share_holder_id = @TargetShareHolderId and share_issue_id = @ShareIssueId"
            Dim Cmd3 = New MySqlCommand(Sql3, Form1.DbConnection)
            Cmd3.Parameters.AddWithValue("@Qty", Quantity)
            Cmd3.Parameters.AddWithValue("@TargetShareHolderId", TargetShareHolderId)
            Cmd3.Parameters.AddWithValue("@ShareIssueId", ShareIssueId)

            Dim Sql4 = "insert into share_holder_shares (quantity, share_holder_id, share_issue_id) values (@Quantity, @TargetShareHolderId, @ShareIssueId)"
            Dim Cmd4 = New MySqlCommand(Sql4, Form1.DbConnection)
            Cmd4.Parameters.AddWithValue("@Quantity", Quantity)
            Cmd4.Parameters.AddWithValue("@TargetShareHolderId", TargetShareHolderId)
            Cmd4.Parameters.AddWithValue("@ShareIssueId", ShareIssueId)

            Try
                Form1.DbConnection.Open()
                Cmd1.ExecuteNonQuery()

                Dim R1 = Cmd2.ExecuteReader()

                If (R1.HasRows()) Then
                    R1.Close()
                    Cmd3.ExecuteNonQuery()
                Else
                    R1.Close()
                    Cmd4.ExecuteNonQuery()
                End If

                Form1.DbConnection.Close()
                Form1.StaffPage.LoadShareHolderAccountPage()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                Form1.DbConnection.Close()
            End Try
        Else
            Dim Sql1 = "update share_holder_shares set quantity = (quantity - @Qty) where id = @Id"
            Dim Cmd1 = New MySqlCommand(Sql1, Form1.DbConnection)
            Cmd1.Parameters.AddWithValue("@Qty", Quantity)
            Cmd1.Parameters.AddWithValue("@Id", ShareHolderShareId)

            Dim Sql2 = "select * from share_holder_shares where share_holder_id = @TargetShareHolderId and share_issue_id = @ShareIssueId"
            Dim Cmd2 = New MySqlCommand(Sql2, Form1.DbConnection)
            Cmd2.Parameters.AddWithValue("@TargetShareHolderId", TargetShareHolderId)
            Cmd2.Parameters.AddWithValue("@ShareIssueId", ShareIssueId)

            Dim Sql3 = "update share_holder_shares set quantity = (quantity + @Qty) where share_holder_id = @TargetShareHolderId and share_issue_id = @ShareIssueId"
            Dim Cmd3 = New MySqlCommand(Sql3, Form1.DbConnection)
            Cmd3.Parameters.AddWithValue("@Qty", Quantity)
            Cmd3.Parameters.AddWithValue("@TargetShareHolderId", TargetShareHolderId)
            Cmd3.Parameters.AddWithValue("@ShareIssueId", ShareIssueId)

            Dim Sql4 = "insert into share_holder_shares (quantity, share_holder_id, share_issue_id) values (@Quantity, @TargetShareHolderId, @ShareIssueId)"
            Dim Cmd4 = New MySqlCommand(Sql4, Form1.DbConnection)
            Cmd4.Parameters.AddWithValue("@Quantity", Quantity)
            Cmd4.Parameters.AddWithValue("@TargetShareHolderId", TargetShareHolderId)
            Cmd4.Parameters.AddWithValue("@ShareIssueId", ShareIssueId)

            Try
                Form1.DbConnection.Open()
                Cmd1.ExecuteNonQuery()

                Dim R1 = Cmd2.ExecuteReader()
                If (R1.HasRows()) Then
                    R1.Close()
                    Cmd3.ExecuteNonQuery()
                Else
                    R1.Close()
                    Cmd4.ExecuteNonQuery()
                End If

                Form1.DbConnection.Close()
                Form1.StaffPage.LoadShareHolderAccountPage()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                Form1.DbConnection.Close()
            End Try
        End If
    End Sub

    Sub LoadShareHolderShares(ShareHolderId As Integer)
        ShareHolderShares.Clear()

        Dim Sql = "select * from share_holder_shares where share_holder_id = @ShareHolderId"
        Dim Cmd = New MySqlCommand(Sql, Form1.DbConnection)
        Cmd.Parameters.AddWithValue("@ShareHolderId", ShareHolderId)

        Dim Sql2 = "select * from share_issues where id = @Id"

        Try
            Form1.DbConnection.Open()
            Dim R = Cmd.ExecuteReader()
            If R.HasRows() Then
                While R.Read()
                    Dim Share = New ShareHolderShareModel With {
                        .Id = R("id"),
                        .Qty = R("quantity"),
                        .ShareIssueId = R("share_issue_id")
                    }
                    ShareHolderShares.Add(Share)
                End While
            End If

            R.Close()
            For Each Share As ShareHolderShareModel In ShareHolderShares
                Dim Cmd2 = New MySqlCommand(Sql2, Form1.DbConnection)
                Cmd2.Parameters.AddWithValue("@Id", Share.ShareIssueId)

                Dim R2 = Cmd2.ExecuteReader()

                R2.Read()
                Share.ShareIssuedPrice = R2("price")
                R2.Close()
            Next


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Form1.DbConnection.Close()
        End Try
    End Sub

End Module

Class ShareHolderModel
    Public Id As Integer
    Public Name As String
    Public Age As Integer
    Public Gender As String
    Public Phone As String
    Public Aadhaar As String
    Public Addr1 As String
    Public Addr2 As String
    Public Addr3 As String
    Public PIN As String
End Class

Class ShareHolderShareModel
    Public Id As Integer
    Public Qty As Integer
    Public ShareHolderId As Integer
    Public ShareIssueId As Integer
    Public ShareIssuedPrice As Integer
End Class