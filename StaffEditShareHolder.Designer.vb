<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffEditShareHolder
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
        Me.GenderInput = New System.Windows.Forms.ComboBox()
        Me.AgeInput = New System.Windows.Forms.NumericUpDown()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PINInput = New System.Windows.Forms.TextBox()
        Me.Addr3Input = New System.Windows.Forms.TextBox()
        Me.Addr2Input = New System.Windows.Forms.TextBox()
        Me.Addr1Input = New System.Windows.Forms.TextBox()
        Me.AadhaarInput = New System.Windows.Forms.TextBox()
        Me.PhoneInput = New System.Windows.Forms.TextBox()
        Me.NameInput = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Aadhaartext = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.AgeInput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GenderInput
        '
        Me.GenderInput.FormattingEnabled = True
        Me.GenderInput.Items.AddRange(New Object() {"Male", "Female"})
        Me.GenderInput.Location = New System.Drawing.Point(244, 129)
        Me.GenderInput.Name = "GenderInput"
        Me.GenderInput.Size = New System.Drawing.Size(188, 23)
        Me.GenderInput.TabIndex = 22
        '
        'AgeInput
        '
        Me.AgeInput.Location = New System.Drawing.Point(244, 92)
        Me.AgeInput.Name = "AgeInput"
        Me.AgeInput.Size = New System.Drawing.Size(186, 23)
        Me.AgeInput.TabIndex = 21
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(443, 394)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(127, 34)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PINInput
        '
        Me.PINInput.Location = New System.Drawing.Point(244, 372)
        Me.PINInput.Name = "PINInput"
        Me.PINInput.Size = New System.Drawing.Size(187, 23)
        Me.PINInput.TabIndex = 19
        '
        'Addr3Input
        '
        Me.Addr3Input.Location = New System.Drawing.Point(246, 329)
        Me.Addr3Input.Name = "Addr3Input"
        Me.Addr3Input.Size = New System.Drawing.Size(187, 23)
        Me.Addr3Input.TabIndex = 18
        '
        'Addr2Input
        '
        Me.Addr2Input.Location = New System.Drawing.Point(246, 291)
        Me.Addr2Input.Name = "Addr2Input"
        Me.Addr2Input.Size = New System.Drawing.Size(187, 23)
        Me.Addr2Input.TabIndex = 17
        '
        'Addr1Input
        '
        Me.Addr1Input.Location = New System.Drawing.Point(246, 252)
        Me.Addr1Input.Name = "Addr1Input"
        Me.Addr1Input.Size = New System.Drawing.Size(187, 23)
        Me.Addr1Input.TabIndex = 16
        '
        'AadhaarInput
        '
        Me.AadhaarInput.Location = New System.Drawing.Point(246, 208)
        Me.AadhaarInput.Name = "AadhaarInput"
        Me.AadhaarInput.Size = New System.Drawing.Size(187, 23)
        Me.AadhaarInput.TabIndex = 15
        '
        'PhoneInput
        '
        Me.PhoneInput.Location = New System.Drawing.Point(246, 168)
        Me.PhoneInput.Name = "PhoneInput"
        Me.PhoneInput.Size = New System.Drawing.Size(187, 23)
        Me.PhoneInput.TabIndex = 14
        '
        'NameInput
        '
        Me.NameInput.Location = New System.Drawing.Point(244, 55)
        Me.NameInput.Name = "NameInput"
        Me.NameInput.Size = New System.Drawing.Size(187, 23)
        Me.NameInput.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(165, 373)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 17)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "PIN"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(133, 253)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 17)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Address 1"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(131, 292)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 17)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Address 2"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(131, 330)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 17)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Address3"
        '
        'Aadhaartext
        '
        Me.Aadhaartext.AutoSize = True
        Me.Aadhaartext.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Aadhaartext.Location = New System.Drawing.Point(111, 209)
        Me.Aadhaartext.Name = "Aadhaartext"
        Me.Aadhaartext.Size = New System.Drawing.Size(84, 17)
        Me.Aadhaartext.TabIndex = 6
        Me.Aadhaartext.Text = "Aadhaar No."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(152, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Phone"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(145, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Gender"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(165, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Age"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(153, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(14, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Edit Share Holder"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.GenderInput)
        Me.Panel1.Controls.Add(Me.AgeInput)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.PINInput)
        Me.Panel1.Controls.Add(Me.Addr3Input)
        Me.Panel1.Controls.Add(Me.Addr2Input)
        Me.Panel1.Controls.Add(Me.Addr1Input)
        Me.Panel1.Controls.Add(Me.AadhaarInput)
        Me.Panel1.Controls.Add(Me.PhoneInput)
        Me.Panel1.Controls.Add(Me.NameInput)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Aadhaartext)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(600, 450)
        Me.Panel1.TabIndex = 1
        '
        'StaffEditShareHolder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "StaffEditShareHolder"
        Me.Size = New System.Drawing.Size(600, 450)
        CType(Me.AgeInput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GenderInput As ComboBox
    Friend WithEvents AgeInput As NumericUpDown
    Friend WithEvents Button2 As Button
    Friend WithEvents PINInput As TextBox
    Friend WithEvents Addr3Input As TextBox
    Friend WithEvents Addr2Input As TextBox
    Friend WithEvents Addr1Input As TextBox
    Friend WithEvents AadhaarInput As TextBox
    Friend WithEvents PhoneInput As TextBox
    Friend WithEvents NameInput As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Aadhaartext As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
End Class
