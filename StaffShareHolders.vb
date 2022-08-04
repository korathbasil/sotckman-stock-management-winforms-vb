Public Class StaffShareHolders
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.StaffPage.LoadAddShareHolderPage()
    End Sub

    Private Sub StaffShareHolders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShareHolderModule.LoadShareHoldersData()

        Dim CurrentItem = 0
        For Each SH As ShareHolderModel In ShareHolderModule.ShareHolders
            ShareHoldersList.Items.Add(SH.Name)
            ShareHoldersList.Items(CurrentItem).SubItems.Add(SH.Id)
            CurrentItem += 1
        Next

        CurrentItem = 0
        For Each SH As ShareHolderModel In ShareHolderModule.ShareHolders
            ShareHoldersList.Items(CurrentItem).SubItems.Add(SH.Phone)
            CurrentItem += 1
        Next
    End Sub

    Private Sub ShareHoldersList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ShareHoldersList.SelectedIndexChanged
        If (ShareHoldersList.SelectedItems.Count > 0) Then
            Form1.StaffPage.SelectedShareHolderId = ShareHoldersList.SelectedItems(0).SubItems(1).Text

            ShareHolderModule.GetShareHolderById(Form1.StaffPage.SelectedShareHolderId)

            If (ShareHolderExists) Then
                Form1.StaffPage.LoadShareHolderAccountPage()
            Else
                MessageBox.Show("Invalid Id")
            End If
        End If
    End Sub
End Class
