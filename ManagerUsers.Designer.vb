<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManagerUsers
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.UsersListView = New System.Windows.Forms.ListView()
        Me.IdColumn = New System.Windows.Forms.ColumnHeader()
        Me.NameColumn = New System.Windows.Forms.ColumnHeader()
        Me.UsernameColumn = New System.Windows.Forms.ColumnHeader()
        Me.UserTypeColumn = New System.Windows.Forms.ColumnHeader()
        Me.GoToAddUserPageButton = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.UsersListView)
        Me.Panel1.Controls.Add(Me.GoToAddUserPageButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(600, 450)
        Me.Panel1.TabIndex = 1
        '
        'UsersListView
        '
        Me.UsersListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.IdColumn, Me.NameColumn, Me.UsernameColumn, Me.UserTypeColumn})
        Me.UsersListView.Location = New System.Drawing.Point(8, 42)
        Me.UsersListView.Name = "UsersListView"
        Me.UsersListView.Size = New System.Drawing.Size(585, 402)
        Me.UsersListView.TabIndex = 1
        Me.UsersListView.UseCompatibleStateImageBehavior = False
        Me.UsersListView.View = System.Windows.Forms.View.Details
        '
        'IdColumn
        '
        Me.IdColumn.Text = "Id"
        '
        'NameColumn
        '
        Me.NameColumn.Text = "Name"
        Me.NameColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NameColumn.Width = 200
        '
        'UsernameColumn
        '
        Me.UsernameColumn.Text = "Username"
        Me.UsernameColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UsernameColumn.Width = 180
        '
        'UserTypeColumn
        '
        Me.UserTypeColumn.Text = "User Type"
        Me.UserTypeColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UserTypeColumn.Width = 140
        '
        'GoToAddUserPageButton
        '
        Me.GoToAddUserPageButton.Location = New System.Drawing.Point(506, 8)
        Me.GoToAddUserPageButton.Name = "GoToAddUserPageButton"
        Me.GoToAddUserPageButton.Size = New System.Drawing.Size(87, 28)
        Me.GoToAddUserPageButton.TabIndex = 0
        Me.GoToAddUserPageButton.Text = "Add User"
        Me.GoToAddUserPageButton.UseVisualStyleBackColor = True
        '
        'ManagerUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ManagerUsers"
        Me.Size = New System.Drawing.Size(600, 450)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents UsersListView As ListView
    Friend WithEvents IdColumn As ColumnHeader
    Friend WithEvents NameColumn As ColumnHeader
    Friend WithEvents UsernameColumn As ColumnHeader
    Friend WithEvents UserTypeColumn As ColumnHeader
    Friend WithEvents GoToAddUserPageButton As Button
End Class
