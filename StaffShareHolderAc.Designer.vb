<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StaffShareHolderAc
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ShareHolderSharesList = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(14, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Share Holder Account"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.TotalLabel)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.ShareHolderSharesList)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(600, 450)
        Me.Panel1.TabIndex = 1
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(276, 364)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(305, 42)
        Me.Button5.TabIndex = 9
        Me.Button5.Text = "Transfer Shares"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(276, 306)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(305, 42)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "Sell Shares"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(347, 19)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(102, 25)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Edit Profile"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TotalLabel
        '
        Me.TotalLabel.AutoSize = True
        Me.TotalLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TotalLabel.Location = New System.Drawing.Point(434, 207)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(15, 17)
        Me.TotalLabel.TabIndex = 6
        Me.TotalLabel.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(301, 205)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Total Worth (Rs.) :"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(276, 248)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(305, 42)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Buy Shares"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ShareHolderSharesList
        '
        Me.ShareHolderSharesList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ShareHolderSharesList.Location = New System.Drawing.Point(16, 55)
        Me.ShareHolderSharesList.Name = "ShareHolderSharesList"
        Me.ShareHolderSharesList.Size = New System.Drawing.Size(244, 378)
        Me.ShareHolderSharesList.TabIndex = 2
        Me.ShareHolderSharesList.UseCompatibleStateImageBehavior = False
        Me.ShareHolderSharesList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Quantity"
        Me.ColumnHeader1.Width = 120
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Price"
        Me.ColumnHeader2.Width = 120
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(458, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 25)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Go Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'StaffShareHolderAc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "StaffShareHolderAc"
        Me.Size = New System.Drawing.Size(600, 450)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents ShareHolderSharesList As ListView
    Friend WithEvents Button1 As Button
    Friend WithEvents TotalLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents Button3 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
End Class
