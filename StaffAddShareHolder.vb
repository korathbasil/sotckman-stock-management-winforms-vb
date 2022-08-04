Public Class StaffAddShareHolder
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.StaffPage.LoadShareHoldersPage()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Validation.IsValidName(NameInput.Text)
        If (Validation.IsNameInvalid) Then
            MessageBox.Show(Validation.ErrMessage)

            Exit Sub
        End If

        Validation.IsValidPhoneNumber(PhoneInput.Text)
        If (Validation.IsPhoneNumberInvalid) Then
            MessageBox.Show(Validation.ErrMessage)

            Exit Sub
        End If

        Validation.IsValidAadhaarNumber(AadhaarInput.Text)
        If (Validation.IsAadhaarNumberInvalid) Then
            MessageBox.Show(Validation.ErrMessage)

            Exit Sub
        End If

        Validation.IsValidPinNumber(PINInput.Text)
        If (Validation.IsPinNumberInvalid) Then
            MessageBox.Show(Validation.ErrMessage)

            Exit Sub
        End If

        AddNewShareHolder()
    End Sub

    Private Sub AddNewShareHolder()
        Dim ShareHolder = New ShareHolderModel With {
            .Name = NameInput.Text,
            .Age = AgeInput.Value,
            .Gender = GenderInput.Text,
            .Phone = PhoneInput.Text,
            .Aadhaar = AadhaarInput.Text,
            .Addr1 = Addr1Input.Text,
            .Addr2 = Addr2Input.Text,
            .Addr3 = Addr3Input.Text,
            .PIN = PINInput.Text
        }

        ShareHolderModule.AddNewShareHolder(ShareHolder)
    End Sub

    Private Sub GenderInput_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GenderInput.SelectedIndexChanged

    End Sub

    Private Sub AgeInput_ValueChanged(sender As Object, e As EventArgs) Handles AgeInput.ValueChanged

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub PINInput_TextChanged(sender As Object, e As EventArgs) Handles PINInput.TextChanged

    End Sub

    Private Sub Addr3Input_TextChanged(sender As Object, e As EventArgs) Handles Addr3Input.TextChanged

    End Sub

    Private Sub Addr2Input_TextChanged(sender As Object, e As EventArgs) Handles Addr2Input.TextChanged

    End Sub

    Private Sub Addr1Input_TextChanged(sender As Object, e As EventArgs) Handles Addr1Input.TextChanged

    End Sub

    Private Sub AadhaarInput_TextChanged(sender As Object, e As EventArgs) Handles AadhaarInput.TextChanged

    End Sub

    Private Sub PhoneInput_TextChanged(sender As Object, e As EventArgs) Handles PhoneInput.TextChanged

    End Sub

    Private Sub NameInput_TextChanged(sender As Object, e As EventArgs) Handles NameInput.TextChanged

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Aadhaartext_Click(sender As Object, e As EventArgs) Handles Aadhaartext.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
