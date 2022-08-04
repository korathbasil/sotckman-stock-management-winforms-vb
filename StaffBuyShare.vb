Public Class StaffBuyShare
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.StaffPage.LoadShareHolderAccountPage()
    End Sub

    Private Sub StaffBuyShare_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EquityModule.LoadEquityData()

        For Each Share As ShareIssueModel In EquityModule.IssuedShareList
            ShareInput.Items.Add(Share.IssuedDate.ToString("dd-MM-yy") + " -  Rs." + Share.Price.ToString() + " - " + Share.UnsoldQty.ToString() + " nos.")
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (ShareInput.SelectedIndex < 0) Then
            MessageBox.Show("Please select a share")
        ElseIf QtyInput.Value < 1 Then
            MessageBox.Show("Please enter a valid quantity")
        ElseIf QtyInput.Value > EquityModule.IssuedShareList.ElementAt(ShareInput.SelectedIndex).UnsoldQty Then
            MessageBox.Show("Only " + EquityModule.IssuedShareList.ElementAt(ShareInput.SelectedIndex).UnsoldQty.ToString() + " shares available in this category")
        Else
            BuyShares()
        End If
    End Sub

    Private Sub BuyShares()
        Dim ShareIssueId = EquityModule.IssuedShareList.ElementAt(ShareInput.SelectedIndex).Id
        Dim ShareHolderId = Form1.StaffPage.SelectedShareHolderId
        Dim Quantity = QtyInput.Value

        ShareHolderModule.BuyShares(ShareIssueId, ShareHolderId, Quantity)
    End Sub
End Class
