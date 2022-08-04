Public Class Staff

    Public SelectedShareHolderId As Integer
    Dim ShareHoldersPage As StaffShareHolders
    Dim AddShareHolderPage As StaffAddShareHolder
    Dim ShareHolderAccountPage As StaffShareHolderAc
    Dim EditShareHolderPage As StaffEditShareHolder
    Dim BuySharePage As StaffBuyShare
    Dim SellSharesPage As StaffSellShares
    Dim TransferSharesPage As StaffTransferShares

    Private Sub Staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadShareHoldersPage()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.LoggedInUserName = ""
        Form1.LoadLoginPage()
    End Sub

    Public Sub LoadShareHoldersPage()
        ShareHoldersPage = New StaffShareHolders

        StaffAppPanel.Controls.Clear()
        StaffAppPanel.Controls.Add(ShareHoldersPage)
    End Sub

    Public Sub LoadAddShareHolderPage()
        AddShareHolderPage = New StaffAddShareHolder

        StaffAppPanel.Controls.Clear()
        StaffAppPanel.Controls.Add(AddShareHolderPage)
    End Sub

    Public Sub LoadShareHolderAccountPage()
        ShareHolderAccountPage = New StaffShareHolderAc

        StaffAppPanel.Controls.Clear()
        StaffAppPanel.Controls.Add(ShareHolderAccountPage)
    End Sub
    Public Sub LoadEditShareHolderPage()
        EditShareHolderPage = New StaffEditShareHolder

        StaffAppPanel.Controls.Clear()
        StaffAppPanel.Controls.Add(EditShareHolderPage)
    End Sub

    Public Sub LoadBuySharePage()
        BuySharePage = New StaffBuyShare

        StaffAppPanel.Controls.Clear()
        StaffAppPanel.Controls.Add(BuySharePage)
    End Sub
    Public Sub LoadSellSharesPage()
        SellSharesPage = New StaffSellShares

        StaffAppPanel.Controls.Clear()
        StaffAppPanel.Controls.Add(SellSharesPage)
    End Sub

    Public Sub LoadTransferSharesPage()
        TransferSharesPage = New StaffTransferShares

        StaffAppPanel.Controls.Clear()
        StaffAppPanel.Controls.Add(TransferSharesPage)
    End Sub


    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Form1.StaffPage.LoadShareHoldersPage()
    End Sub
End Class