Imports MySql.Data.MySqlClient

Module EquityModule
    Public IssuedShareList As New List(Of ShareIssueModel)
    Sub IssueShares(Qty As Integer, Price As Integer)
        Dim Sql = "insert into share_issues (issued_quantity, unsold_quantity, price) values (@Qty, @Qty, @Price)"

        Dim Cmd = New MySqlCommand(Sql, Form1.DbConnection)
        Cmd.Parameters.AddWithValue("Qty", Qty)
        Cmd.Parameters.AddWithValue("Price", Price)

        Try
            Form1.DbConnection.Open()
            Cmd.ExecuteNonQuery()

            Form1.DbConnection.Close()
            Form1.ManagerPage.LoadEquityPage()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Form1.DbConnection.Close()
        End Try
    End Sub

    Sub LoadEquityData()
        IssuedShareList.Clear()
        Dim Sql = "select * from share_issues"
        Dim Cmd = New MySqlCommand(Sql, Form1.DbConnection)

        Try
            Form1.DbConnection.Open()
            Dim Reader = Cmd.ExecuteReader()

            If (Reader.HasRows()) Then
                While Reader.Read()
                    Dim ShareIssue = New ShareIssueModel With {
                        .Id = Reader("id"),
                        .IssuedDate = Reader("issued_date"),
                        .IssuedQty = Reader("issued_quantity"),
                        .UnsoldQty = Reader("unsold_quantity"),
                        .Price = Reader("price")
                    }

                    IssuedShareList.Add(ShareIssue)
                End While
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Form1.DbConnection.Close()
        End Try
    End Sub
End Module

Class ShareIssueModel
    Public Id As Integer
    Public IssuedDate As Date
    Public IssuedQty As Integer
    Public UnsoldQty As Integer
    Public Price As Integer
End Class