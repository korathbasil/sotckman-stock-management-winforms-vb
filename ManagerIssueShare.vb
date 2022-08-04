Public Class ManagerIssueShare
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.ManagerPage.LoadEquityPage()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Qty = QtyInput.Value
        Dim Price = PriceInput.Value

        If (Qty < 1) Then
            MessageBox.Show("Invalid Quantity")
        ElseIf (Price < 1) Then
            MessageBox.Show("Invalid Price")
        Else
            EquityModule.IssueShares(Qty, Price)
        End If
    End Sub
End Class
