Public Class StaffTransferShares
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.StaffPage.LoadShareHolderAccountPage()
    End Sub

    Private Sub StaffTransferShares_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShareHolderModule.LoadShareHolderShares(Form1.StaffPage.SelectedShareHolderId)

        For Each Share As ShareHolderShareModel In ShareHolderModule.ShareHolderShares
            ShareInput.Items.Add("Rs. " + Share.ShareIssuedPrice.ToString() + " - " + Share.Qty.ToString() + " No.")
        Next

        ShareHolderModule.LoadShareHoldersData()
        For Each SH As ShareHolderModel In ShareHolderModule.ShareHolders
            TargetShareHolderInput.Items.Add(SH.Id.ToString() + " - " + SH.Name.ToString())
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (ShareInput.SelectedIndex < 0) Then
            MessageBox.Show("Please select a share")
        ElseIf QtyInput.Value < 1 Then
            MessageBox.Show("Please enter a valid quantity")
        ElseIf QtyInput.Value > ShareHolderModule.ShareHolderShares.ElementAt(ShareInput.SelectedIndex).Qty Then
            MessageBox.Show("Only " + ShareHolderModule.ShareHolderShares.ElementAt(ShareInput.SelectedIndex).Qty.ToString() + " shares available")
        ElseIf (TargetShareHolderInput.SelectedIndex < 0) Then
            MessageBox.Show("Please select a share holder to transfer shares")
        Else
            TarnsferShares()
        End If
    End Sub

    Private Sub TarnsferShares()
        Dim ShareHolderShareId = ShareHolderModule.ShareHolderShares.ElementAt(ShareInput.SelectedIndex).Id
        Dim ShareIssueId = ShareHolderModule.ShareHolderShares.ElementAt(ShareInput.SelectedIndex).ShareIssueId
        Dim ShareHolderId = Form1.StaffPage.SelectedShareHolderId
        Dim Quantity = QtyInput.Value
        Dim DeleteRequired = False
        Dim TargetShareHolderId = ShareHolderModule.ShareHolders.ElementAt(TargetShareHolderInput.SelectedIndex).Id

        If (QtyInput.Value = ShareHolderModule.ShareHolderShares.ElementAt(ShareInput.SelectedIndex).Qty) Then
            DeleteRequired = True
        End If

        ShareHolderModule.TransferShares(ShareHolderShareId, ShareIssueId, TargetShareHolderId, Quantity, DeleteRequired)
    End Sub
End Class
