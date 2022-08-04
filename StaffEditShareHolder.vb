Public Class StaffEditShareHolder
    Private Sub StaffEditShareHolder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShareHolderModule.GetShareHolderById(Form1.StaffPage.SelectedShareHolderId)

        NameInput.Text = ShareHolderModule.SelectedShareHolder.Name
        AgeInput.Value = ShareHolderModule.SelectedShareHolder.Age
        GenderInput.Text = ShareHolderModule.SelectedShareHolder.Gender
        PhoneInput.Text = ShareHolderModule.SelectedShareHolder.Phone
        AadhaarInput.Text = ShareHolderModule.SelectedShareHolder.Aadhaar
        Addr1Input.Text = ShareHolderModule.SelectedShareHolder.Addr1
        Addr2Input.Text = ShareHolderModule.SelectedShareHolder.Addr2
        Addr3Input.Text = ShareHolderModule.SelectedShareHolder.Addr3
        PINInput.Text = ShareHolderModule.SelectedShareHolder.PIN
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

        EditShareHolder()
    End Sub

    Private Sub EditShareHolder()
        Dim ShareHolder = New ShareHolderModel With {
            .Id = Form1.StaffPage.SelectedShareHolderId,
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

        ShareHolderModule.UpdateShareHolder(ShareHolder)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.StaffPage.LoadShareHolderAccountPage()
    End Sub
End Class
