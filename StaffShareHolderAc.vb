Public Class StaffShareHolderAc
    Private Sub StaffShareHolderAc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShareHolderModule.LoadShareHolderShares(Form1.StaffPage.SelectedShareHolderId)

        Dim CurrentCount = 0
        Dim Total = 0
        For Each Share As ShareHolderShareModel In ShareHolderModule.ShareHolderShares
            ShareHolderSharesList.Items.Add(Share.Qty)
            ShareHolderSharesList.Items(CurrentCount).SubItems.Add(Share.ShareIssuedPrice)
            Total = Total + (Share.Qty * Share.ShareIssuedPrice)
            CurrentCount += 1
        Next
        TotalLabel.Text = Total
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.StaffPage.LoadBuySharePage()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.StaffPage.LoadShareHoldersPage()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.StaffPage.LoadEditShareHolderPage()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.StaffPage.LoadSellSharesPage()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form1.StaffPage.LoadTransferSharesPage()
    End Sub
End Class
