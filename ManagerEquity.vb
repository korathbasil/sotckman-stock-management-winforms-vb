Public Class ManagerEquity
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.ManagerPage.LoadIssueSharePage()
    End Sub

    Private Sub ManagerEquity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EquityModule.LoadEquityData()
        Dim CurrentItem = 0
        For Each Issue As ShareIssueModel In EquityModule.IssuedShareList
            ShareIssueList.Items.Add(Issue.IssuedDate.ToString("dd-MM-yyyy"))
            ShareIssueList.Items(CurrentItem).SubItems.Add(Issue.IssuedQty)
            CurrentItem += 1
        Next

        CurrentItem = 0
        For Each Issue As ShareIssueModel In EquityModule.IssuedShareList
            ShareIssueList.Items(CurrentItem).SubItems.Add(Issue.Price)
            CurrentItem += 1
        Next

        CurrentItem = 0
        For Each Issue As ShareIssueModel In EquityModule.IssuedShareList
            ShareIssueList.Items(CurrentItem).SubItems.Add(Issue.UnsoldQty)
            CurrentItem += 1
        Next

        CurrentItem = 0
        For Each Issue As ShareIssueModel In EquityModule.IssuedShareList
            Dim Sum = (Issue.IssuedQty - Issue.UnsoldQty) * Issue.Price
            ShareIssueList.Items(CurrentItem).SubItems.Add(Sum)
            CurrentItem += 1
        Next
    End Sub
End Class
