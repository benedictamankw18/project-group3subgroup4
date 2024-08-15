Imports System.Text.RegularExpressions
Imports System.IO
Imports MySql.Data.MySqlClient


Public Class frmAgentManagement
    Dim connection As MySqlConnection
    Public command As MySqlCommand
    Dim dbDataset1 As New DataTable

    Dim firstNameError As New ErrorProvider
    Dim lastNameError As New ErrorProvider
    Dim AddressError As New ErrorProvider
    Dim PhoneError As New ErrorProvider
    Dim emailError As New ErrorProvider
    Dim secondEmailError As New ErrorProvider

    Dim firstNameUpdateError As New ErrorProvider
    Dim lastNameUpdateError As New ErrorProvider
    Dim AddressUpdateError As New ErrorProvider
    Dim PhoneUpdateError As New ErrorProvider
    Dim emailUpdateError As New ErrorProvider
    Dim secondEmailUpdateError As New ErrorProvider

    Dim arrCheckValidation() As Boolean = {False, False, True, False, True, True, False, False, True, False, False, False}
    Dim arrCheckValidationUpdate() As Boolean = {False, False, True, False, True, True, False, False, True, False, False, False}
    Dim isCorrectEmail As Boolean = False
    Dim isCorrectEmailUpdate As Boolean = False
    Dim isCorrectSecondEmail As Boolean = False
    Dim isCorrectSecondEmailUpdate As Boolean = False

    Dim agentId As Integer = 0
    Dim deleteAction As Boolean = False
    Dim updateAction As Boolean = False


    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If rdoFemale.Checked Or rdoMale.Checked Then
            arrCheckValidation(10) = True
        Else
            arrCheckValidation(10) = False
        End If
        Beep()

        If Not arrCheckValidation(0) Then
            MessageBox.Show("Enter the First name", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Not arrCheckValidation(1) Then
            MessageBox.Show("Enter the Last name", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Not arrCheckValidation(2) Then
            MessageBox.Show("Enter the Middle name", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Not arrCheckValidation(3) Then
            MessageBox.Show("Enter a correct email at the First email textbox", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Not arrCheckValidation(4) Then
            MessageBox.Show("Enter a correct email at the second email textbox", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Not arrCheckValidation(5) Then
            MessageBox.Show("Enter a 10 digit number at the second mobile number textbox", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Not arrCheckValidation(6) Then
            MessageBox.Show("Enter a 10 digit number at the first mobile number textbox", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Not arrCheckValidation(7) Then
            MessageBox.Show("Enter the Address the first address textbox", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Not arrCheckValidation(8) Then
            MessageBox.Show("Enter the Address the second address textbox", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Not arrCheckValidation(9) Then
            MessageBox.Show("Select the Nationality", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Not arrCheckValidation(10) Then
            MessageBox.Show("Select the Gender", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Using writer As New StreamWriter(splash_screen.log.ToString, True)
            If splash_screen.lines < 1 Then
                writer.WriteLine("DATE TIME" & vbTab & vbTab & " ACTION" & vbTab & vbTab & vbTab & vbTab & " LOCATION")
            End If
            writer.WriteLine(Date.Now & vbTab & " Click on Drop Down button " & vbTab & Me.Text)
        End Using


        Dim connection As New MySqlConnection(My.Settings.conPathDb)

        Try

            Using writer As New StreamWriter(splash_screen.log.ToString, True)
                If splash_screen.lines < 1 Then
                    writer.WriteLine("DATE TIME" & vbTab & vbTab & " ACTION" & vbTab & vbTab & vbTab & vbTab & " LOCATION")
                End If
                writer.WriteLine(Date.Now & vbTab & " Adding an Agent to the Database " & vbTab & Me.Text)
            End Using

            connection.Open()
            Dim query As String = "INSERT INTO g3subvb.user (fName, lName, DOB, Gender, First_email, First_Phone_No, First_Address, Nationality, Profile_pic"
            Dim values As String = " VALUES (@fName, @lName, @DOB, @Gender, @First_email, @First_Phone_No, @First_Address, @Nationality, @Profile_pic "

            If Not String.IsNullOrEmpty(txtMname.Text) Then
                query &= ", mName"
                values &= ", @mName"
            End If

            If Not String.IsNullOrEmpty(txtSecondEmail.Text) Then
                query &= ", Second_email"
                values &= ", @Second_email"
            End If

            If Not String.IsNullOrEmpty(txtSecondMobileNumber.Text) Then
                query &= ", Second_Phone_No"
                values &= ", @Second_Phone_No"
            End If

            If Not String.IsNullOrEmpty(txtSecondAddress.Text) Then
                query &= ", Second_Address"
                values &= ", @Second_Address"
            End If

            query &= ")"
            values &= ")"

            query &= values
            Using command As New MySqlCommand(query, connection)
                Dim gender As String = ""
                If rdoFemale.Checked Then
                    gender = "Female"
                End If
                If rdoMale.Checked Then
                    gender = "Male"
                End If

                command.Parameters.AddWithValue("@fName", txtFname.Text)
                command.Parameters.AddWithValue("@lName", txtLname.Text)
                command.Parameters.AddWithValue("@DOB", dtpDOB.Value)
                command.Parameters.AddWithValue("@Gender", gender)
                command.Parameters.AddWithValue("@First_email", txtEmail.Text)
                command.Parameters.AddWithValue("@First_Phone_No", "+233" & txtMobileNumber.Text.Substring(2))
                command.Parameters.AddWithValue("@First_Address", txtAddress.Text)
                command.Parameters.AddWithValue("@Nationality", cboCountry.SelectedItem)

                Dim Profile_pic As Byte()
                Using ms As New MemoryStream()
                    My.Resources.LOGOCOLOR.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
                    Profile_pic = ms.ToArray()
                End Using
                command.Parameters.AddWithValue("@Profile_pic", Profile_pic)


                If Not String.IsNullOrEmpty(txtMname.Text) Then
                    command.Parameters.AddWithValue("@mName", txtMname.Text)
                End If

                If Not String.IsNullOrEmpty(txtSecondEmail.Text) Then
                    command.Parameters.AddWithValue("@Second_email", txtSecondEmail.Text)
                End If

                If Not String.IsNullOrEmpty(txtSecondMobileNumber.Text) Then
                    command.Parameters.AddWithValue("@Second_Phone_No", "+233" & txtSecondMobileNumber.Text.Substring(2))
                End If

                If Not String.IsNullOrEmpty(txtSecondAddress.Text) Then
                    command.Parameters.AddWithValue("@Second_Address", txtSecondAddress.Text)
                End If
                command.ExecuteNonQuery()
            End Using

            Dim getUserIdQuery As String = "SELECT LAST_INSERT_ID()"
            Using getUserIdCommand As New MySqlCommand(getUserIdQuery, connection)
                Dim userId As Integer = Convert.ToInt32(getUserIdCommand.ExecuteScalar())


                query = "INSERT INTO g3subvb.login (User_Id, Username, Password, User_role) VALUES(@UserId, @Username , '12345678', 'Agent')"
                Dim Username As String = txtFname.Text.ToLower & "." & txtLname.Text.ToLower
                Using command As New MySqlCommand(query, connection)

                    command.Parameters.AddWithValue("@UserId", userId)
                    command.Parameters.AddWithValue("@Username", Username)

                    command.ExecuteNonQuery()
                End Using
            End Using

            clear()
            MessageBox.Show("Information Saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            connection.Close()
            loadData(dgvDelete)
            loadData(dgvUpdate)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Dispose()
        End Try

    End Sub


    Private Sub txtFnameUpdate_TextChanged(sender As Object, e As EventArgs) Handles txtFNameUpdate.TextChanged

        If txtFNameUpdate.Text.Length > 0 Then
            lblFnameUpdate.Visible = True
        Else
            lblFnameUpdate.Visible = False
        End If

        If txtFNameUpdate.Text.Length >= 3 Then
            arrCheckValidationUpdate(0) = True
        Else
            arrCheckValidationUpdate(0) = False
        End If
    End Sub

    Private Sub txtFname_TextChanged(sender As Object, e As EventArgs) Handles txtFname.TextChanged
        If txtFname.Text.Length > 0 Then
            lblFirstname.Visible = True
        Else
            lblFirstname.Visible = False
        End If

        If txtFname.Text.Length >= 3 Then
            firstNameError.Clear()
            arrCheckValidation(0) = True
        Else
            arrCheckValidation(0) = False
        End If

    End Sub

    Private Sub txtSecondEmailupdate_TextChanged(sender As Object, e As EventArgs) Handles txtSecEmailUpdate.TextChanged

        If txtSecEmailUpdate.Text.Length > 0 Then
            lblSecEmail.Visible = True
        Else
            lblSecEmail.Visible = False
        End If

        isCorrectSecondEmailUpdate = showMatch(txtSecEmailUpdate.Text, "\b([a-z\d\.-]+)@([a-z\d-]+)\.([a-z]{2,8})(\.[a-z]{2,8})?\b")
        If txtSecEmailUpdate.Text.Length > 0 Then
            arrCheckValidationUpdate(4) = False
            If Not isCorrectSecondEmailUpdate Then
                secondEmailUpdateError.SetError(txtSecEmailUpdate, "Enter a correct email")
                arrCheckValidationUpdate(4) = False
            Else
                secondEmailUpdateError.Clear()
                arrCheckValidationUpdate(4) = True
            End If
        Else
            arrCheckValidationUpdate(4) = True
            secondEmailUpdateError.Clear()
        End If
    End Sub


    Private Sub txtSecondEmail_TextChanged(sender As Object, e As EventArgs) Handles txtSecondEmail.TextChanged
        If txtSecondEmail.Text.Length > 0 Then
            lblSecondEmail.Visible = True
        Else
            lblSecondEmail.Visible = False
        End If

        isCorrectSecondEmail = showMatch(txtSecondEmail.Text, "\b([a-z\d\.-]+)@([a-z\d-]+)\.([a-z]{2,8})(\.[a-z]{2,8})?\b")
        If txtSecondEmail.Text.Length > 0 Then
            arrCheckValidation(4) = False
            If Not isCorrectSecondEmail Then
                secondEmailError.SetError(txtSecondEmail, "Enter a correct email")
                arrCheckValidation(4) = False
            Else
                secondEmailError.Clear()
                arrCheckValidation(4) = True
            End If
        Else
            arrCheckValidation(4) = True
            secondEmailError.Clear()
        End If
    End Sub


    Function showMatch(ByVal text As String, ByVal expr As String) As Boolean
        Dim mc As MatchCollection = Regex.Matches(text, expr)
        Dim m As Match

        For Each m In mc
            Return True
        Next

        Return False
    End Function

    Private Sub cboCountryUpdate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCountryUpdate.SelectedIndexChanged

        If cboCountryUpdate.SelectedIndex > -1 Then
            arrCheckValidationUpdate(9) = True
        Else
            arrCheckValidationUpdate(9) = False
        End If
    End Sub

    Private Sub cboCountry_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCountry.SelectedIndexChanged
        If cboCountry.SelectedIndex > -1 Then
            arrCheckValidation(9) = True
        Else
            arrCheckValidation(9) = False
        End If

    End Sub

    Private Sub txtEmailUpdate_Leave(sender As Object, e As EventArgs) Handles txtEmailUpdate.Leave
        isCorrectEmailUpdate = showMatch(txtEmailUpdate.Text, "\b([a-z\d\.-]+)@([a-z\d-]+)\.([a-z]{2,8})(\.[a-z]{2,8})?\b")
        If txtEmailUpdate.Text.Length = 0 Then
            emailUpdateError.SetError(txtEmailUpdate, "Enter your email")
            arrCheckValidationUpdate(3) = False
        ElseIf Not isCorrectEmailUpdate Then
            emailUpdateError.SetError(txtEmailUpdate, "Enter a correct email")
            arrCheckValidationUpdate(3) = False
        End If
    End Sub

    Private Sub txtEmail_Leave(sender As Object, e As EventArgs) Handles txtEmail.Leave
        isCorrectEmail = showMatch(txtEmail.Text, "\b([a-z\d\.-]+)@([a-z\d-]+)\.([a-z]{2,8})(\.[a-z]{2,8})?\b")
        If txtEmail.Text.Length = 0 Then
            emailError.SetError(txtEmail, "Enter your email")
            arrCheckValidation(3) = False
        ElseIf Not isCorrectEmail Then
            emailError.SetError(txtEmail, "Enter a correct email")
            arrCheckValidation(3) = False
        End If

    End Sub

    Private Sub txtMobileNumberUpdate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPhoneNoUpdate.KeyPress
        If Asc(e.KeyChar) <> 8 AndAlso Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 AndAlso e.KeyChar <> vbBack Then
            e.Handled = True
        End If

        If txtPhoneNoUpdate.Text.Length = 10 AndAlso e.KeyChar <> vbBack Then
            e.Handled = True
        End If

    End Sub


    Private Sub txtMobileNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMobileNumber.KeyPress
        If Asc(e.KeyChar) <> 8 AndAlso Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 AndAlso e.KeyChar <> vbBack Then
            e.Handled = True
        End If

        If txtMobileNumber.Text.Length = 10 AndAlso e.KeyChar <> vbBack Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtSecondMobileNumberUpdate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSecPhoneNoUpdate.KeyPress

        If Asc(e.KeyChar) <> 8 AndAlso Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 AndAlso e.KeyChar <> vbBack Then
            e.Handled = True
        End If

        If txtSecPhoneNoUpdate.Text.Length = 10 AndAlso e.KeyChar <> vbBack Then
            e.Handled = True
        End If

    End Sub


    Private Sub txtSecondMobileNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSecondMobileNumber.KeyPress

        If Asc(e.KeyChar) <> 8 AndAlso Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 AndAlso e.KeyChar <> vbBack Then
            e.Handled = True
        End If

        If txtSecondMobileNumber.Text.Length = 10 AndAlso e.KeyChar <> vbBack Then
            e.Handled = True
        End If

    End Sub


    Private Sub txtMobileNumberUpdate_TextChanged(sender As Object, e As EventArgs) Handles txtPhoneNoUpdate.TextChanged

        If txtPhoneNoUpdate.Text.Length > 0 Then
            lblPhoneNumUpdate.Visible = True
        Else
            lblPhoneNumUpdate.Visible = False
        End If

        If txtPhoneNoUpdate.Text.Length = 10 Then
            arrCheckValidationUpdate(6) = True
            PhoneUpdateError.Clear()
        Else
            PhoneUpdateError.SetError(txtPhoneNoUpdate, "Enter your Phone number")
            arrCheckValidationUpdate(6) = False
        End If

    End Sub


    Private Sub txtMobileNumber_TextChanged(sender As Object, e As EventArgs) Handles txtMobileNumber.TextChanged
        If txtMobileNumber.Text.Length > 0 Then
            lblMobileNumber.Visible = True
        Else
            lblMobileNumber.Visible = False
        End If

        If txtMobileNumber.Text.Length = 10 Then
            arrCheckValidation(6) = True
            PhoneError.Clear()
        Else
            PhoneError.SetError(txtMobileNumber, "Enter your Phone number")
            arrCheckValidation(6) = False
        End If

    End Sub

    Private Sub txtSecondMobileNumberUpdate_TextChanged(sender As Object, e As EventArgs) Handles txtSecPhoneNoUpdate.TextChanged

        If txtSecPhoneNoUpdate.Text.Length > 0 Then
            lblSecPhoneNumber.Visible = True
        Else
            lblSecPhoneNumber.Visible = False
        End If

        If txtSecPhoneNoUpdate.Text.Length = 0 Or txtSecPhoneNoUpdate.Text.Length = 10 Then
            arrCheckValidationUpdate(5) = True
        Else
            arrCheckValidationUpdate(5) = False
        End If
    End Sub

    Private Sub txtSecondMobileNumber_TextChanged(sender As Object, e As EventArgs) Handles txtSecondMobileNumber.TextChanged
        If txtSecondMobileNumber.Text.Length > 0 Then
            lblSecondMobileNumber.Visible = True
        Else
            lblSecondMobileNumber.Visible = False
        End If

        If txtSecondMobileNumber.Text.Length = 0 Or txtSecondMobileNumber.Text.Length = 10 Then
            arrCheckValidation(5) = True
        Else
            arrCheckValidation(5) = False
        End If

    End Sub


    Private Sub txtLnameUpdate_TextChanged(sender As Object, e As EventArgs) Handles txtLNameUpdate.TextChanged

        If txtLNameUpdate.Text.Length > 0 Then
            lblLNameUpdate.Visible = True
        Else
            lblLNameUpdate.Visible = False
        End If

        If txtLNameUpdate.Text.Length >= 3 Then
            lastNameUpdateError.Clear()
            arrCheckValidationUpdate(1) = True
        Else
            arrCheckValidationUpdate(1) = False
        End If
    End Sub


    Private Sub txtLname_TextChanged(sender As Object, e As EventArgs) Handles txtLname.TextChanged
        If txtLname.Text.Length > 0 Then
            lblLastname.Visible = True
        Else
            lblLastname.Visible = False
        End If

        If txtLname.Text.Length >= 3 Then
            lastNameError.Clear()
            arrCheckValidation(1) = True
        Else
            arrCheckValidation(1) = False
        End If

    End Sub


    Private Sub txtMnameUpdate_TextChanged(sender As Object, e As EventArgs) Handles txtMnameUpdate.TextChanged

        If txtMnameUpdate.Text.Length > 0 Then
            lblMNameUpdate.Visible = True
        Else
            lblMNameUpdate.Visible = False
        End If

        If txtMnameUpdate.Text.Length = 0 Then
            arrCheckValidationUpdate(2) = True
        ElseIf txtMnameUpdate.Text.Length < 3 Then
            arrCheckValidationUpdate(2) = False
        Else
            arrCheckValidationUpdate(2) = True
        End If
    End Sub

    Private Sub txtMname_TextChanged(sender As Object, e As EventArgs) Handles txtMname.TextChanged
        If txtMname.Text.Length > 0 Then
            lblMiddlename.Visible = True
        Else
            lblMiddlename.Visible = False
        End If

        If txtMname.Text.Length = 0 Then
            arrCheckValidation(2) = True
        ElseIf txtMname.Text.Length < 3 Then
            arrCheckValidation(2) = False
        Else
            arrCheckValidation(2) = True
        End If

    End Sub


    Private Sub txtAddressUpdate_TextChanged(sender As Object, e As EventArgs) Handles txtAddressUpdate.TextChanged

        If txtAddressUpdate.Text.Length > 0 Then
            lblAddressUpdate.Visible = True
        Else
            lblAddressUpdate.Visible = False
        End If

        If txtAddressUpdate.Text.Length >= 3 Then
            AddressUpdateError.Clear()
            arrCheckValidationUpdate(7) = True
        Else
            arrCheckValidationUpdate(7) = False
        End If
    End Sub

    Private Sub txtAddress_TextChanged(sender As Object, e As EventArgs) Handles txtAddress.TextChanged
        If txtAddress.Text.Length > 0 Then
            lblAddress.Visible = True
        Else
            lblAddress.Visible = False
        End If

        If txtAddress.Text.Length >= 3 Then
            AddressError.Clear()
            arrCheckValidation(7) = True
        Else
            arrCheckValidation(7) = False
        End If

    End Sub

    Private Sub txtSecondAddressUpdate_TextChanged(sender As Object, e As EventArgs) Handles txtSecAddressUpdate.TextChanged

        If txtSecAddressUpdate.Text.Length > 0 Then
            lblSecAddress.Visible = True
        Else
            lblSecAddress.Visible = False
        End If

        If txtSecAddressUpdate.Text.Length = 0 Then
            arrCheckValidationUpdate(8) = True
        ElseIf txtSecAddressUpdate.Text.Length < 3 Then
            arrCheckValidationUpdate(8) = False
        Else
            arrCheckValidationUpdate(8) = True
        End If
    End Sub


    Private Sub txtSecondAddress_TextChanged(sender As Object, e As EventArgs) Handles txtSecondAddress.TextChanged
        If txtSecondAddress.Text.Length > 0 Then
            lblSecondAddress.Visible = True
        Else
            lblSecondAddress.Visible = False
        End If


        If txtSecondAddress.Text.Length = 0 Then
            arrCheckValidation(8) = True
        ElseIf txtSecondAddress.Text.Length < 3 Then
            arrCheckValidation(8) = False
        Else
            arrCheckValidation(8) = True
        End If


    End Sub

    Private Sub txtEmailUpdate_TextChanged(sender As Object, e As EventArgs) Handles txtEmailUpdate.TextChanged

        isCorrectEmailUpdate = showMatch(txtEmailUpdate.Text, "\b([a-z\d\.-]+)@([a-z\d-]+)\.([a-z]{2,8})(\.[a-z]{2,8})?\b")
        If txtEmailUpdate.Text.Length > 0 Then
            lblemailUpdate.Visible = True
        Else
            lblemailUpdate.Visible = False
        End If
        If isCorrectEmailUpdate Then
            emailUpdateError.Clear()
            arrCheckValidationUpdate(3) = True
        Else
            arrCheckValidationUpdate(3) = False
        End If
    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        isCorrectEmail = showMatch(txtEmail.Text, "\b([a-z\d\.-]+)@([a-z\d-]+)\.([a-z]{2,8})(\.[a-z]{2,8})?\b")
        If txtEmail.Text.Length > 0 Then
            lblEmail.Visible = True
        Else
            lblEmail.Visible = False
        End If
        If isCorrectEmail Then
            emailError.Clear()
            arrCheckValidation(3) = True
        Else
            arrCheckValidation(3) = False
        End If

    End Sub


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clear()
    End Sub

    Private Sub clear()
        txtFname.Clear()
        txtLname.Clear()
        txtMname.Clear()
        txtAddress.Clear()
        txtSecondAddress.Clear()
        dtpDOB.Value = #11/1/1999#
        rdoFemale.Checked = False
        rdoMale.Checked = False
        txtEmail.Clear()
        txtSecondEmail.Clear()
        txtMobileNumber.Clear()
        txtSecondMobileNumber.Clear()
        cboCountry.SelectedIndex = -1
        firstNameError.Clear()
        lastNameError.Clear()
        AddressError.Clear()
        emailError.Clear()
        secondEmailError.Clear()
        PhoneError.Clear()
    End Sub


    Private Sub clearUpdate()
        txtFNameUpdate.Clear()
        txtLNameUpdate.Clear()
        txtMnameUpdate.Clear()
        txtAddressUpdate.Clear()
        txtSecAddressUpdate.Clear()
        dtpDOBUpdate.Value = #11/1/1999#
        rboFemaleUpdate.Checked = False
        rboMaleUpdate.Checked = False
        txtEmailUpdate.Clear()
        txtSecEmailUpdate.Clear()
        txtPhoneNoUpdate.Clear()
        txtSecPhoneNoUpdate.Clear()
        cboCountryUpdate.SelectedIndex = -1
        firstNameUpdateError.Clear()
        lastNameUpdateError.Clear()
        AddressUpdateError.Clear()
        emailUpdateError.Clear()
        secondEmailUpdateError.Clear()
        PhoneUpdateError.Clear()
    End Sub


    Private Sub txtFnameUpdate_Leave(sender As Object, e As EventArgs) Handles txtFNameUpdate.Leave

        Try
            If txtFNameUpdate.Text.Length < 3 Then
                firstNameUpdateError.SetError(txtFNameUpdate, "First Name Should Be Above 2 Characters")
                arrCheckValidationUpdate(0) = False
            Else
                arrCheckValidationUpdate(0) = True
            End If
        Catch

        End Try
    End Sub

    Private Sub txtFname_Leave(sender As Object, e As EventArgs) Handles txtFname.Leave
        Try
            If txtFname.Text.Length < 3 Then
                firstNameError.SetError(txtFname, "First Name Should Be Above 2 Characters")
                arrCheckValidation(0) = False

            Else
                arrCheckValidation(0) = True
            End If
        Catch

        End Try

    End Sub

    Private Sub txtLnameUpdate_Leave(sender As Object, e As EventArgs) Handles txtLNameUpdate.Leave

        Try
            If txtLNameUpdate.Text.Length < 3 Then
                lastNameUpdateError.SetError(txtLNameUpdate, "Last Name Should Be Above 2 Characters")
                arrCheckValidationUpdate(1) = False
            Else
                arrCheckValidationUpdate(1) = True
            End If
        Catch

        End Try
    End Sub

    Private Sub txtLname_Leave(sender As Object, e As EventArgs) Handles txtLname.Leave
        Try
            If txtLname.Text.Length < 3 Then
                lastNameError.SetError(txtLname, "Last Name Should Be Above 2 Characters")
                arrCheckValidation(1) = False

            Else
                arrCheckValidation(1) = True
            End If
        Catch

        End Try

    End Sub

    Private Sub txtAddressUpdate_Leave(sender As Object, e As EventArgs) Handles txtAddressUpdate.Leave

        Try
            If txtAddressUpdate.Text.Length < 3 Then
                AddressUpdateError.SetError(txtAddressUpdate, "Address Should Be Above 2 Characters")
                arrCheckValidationUpdate(7) = False
            Else
                arrCheckValidationUpdate(7) = True
            End If
        Catch

        End Try
    End Sub

    Private Sub txtAddress_Leave(sender As Object, e As EventArgs) Handles txtAddress.Leave
        Try
            If txtAddress.Text.Length < 3 Then
                AddressError.SetError(txtAddress, "Address Should Be Above 2 Characters")
                arrCheckValidation(7) = False
            Else
                arrCheckValidation(7) = True
            End If
        Catch

        End Try

    End Sub

    Private Sub txtFnameUpdate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFNameUpdate.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtFname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFname.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtLnameUpdate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLNameUpdate.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtLname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLname.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtMnameUpdate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMnameUpdate.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtMname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMname.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtMobileNumberUpdate_Leave(sender As Object, e As EventArgs) Handles txtPhoneNoUpdate.Leave

        Try
            If txtPhoneNoUpdate.Text.Length <> 10 Then
                PhoneUpdateError.SetError(txtPhoneNoUpdate, "Enter your Phone number")
                arrCheckValidationUpdate(6) = False
            Else
                PhoneUpdateError.Clear()
                arrCheckValidationUpdate(6) = True
            End If
        Catch

        End Try
    End Sub

    Private Sub txtMobileNumber_Leave(sender As Object, e As EventArgs) Handles txtMobileNumber.Leave
        Try
            If txtMobileNumber.Text.Length <> 10 Then
                PhoneError.SetError(txtMobileNumber, "Enter your Phone number")
                arrCheckValidation(6) = False
            Else
                PhoneError.Clear()
                arrCheckValidation(6) = True
            End If
        Catch

        End Try

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If updateAction Then
            If rboFemaleUpdate.Checked Or rboMaleUpdate.Checked Then
                arrCheckValidationUpdate(10) = True
            Else
                arrCheckValidationUpdate(10) = False
            End If
            Beep()

            If Not arrCheckValidationUpdate(0) Then
                MessageBox.Show("Enter the First name", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If Not arrCheckValidationUpdate(1) Then
                MessageBox.Show("Enter the Last name", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If Not arrCheckValidationUpdate(2) Then
                MessageBox.Show("Enter the Middle name", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If Not arrCheckValidationUpdate(3) Then
                MessageBox.Show("Enter a correct email at the First email textbox", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If Not arrCheckValidationUpdate(4) Then
                MessageBox.Show("Enter a correct email at the second email textbox", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            'If Not arrCheckValidationUpdate(5) Then
            '    MessageBox.Show("Enter a 10 digit number at the second mobile number textbox", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    Exit Sub
            'End If

            'If Not arrCheckValidationUpdate(6) Then
            '    MessageBox.Show("Enter a 10 digit number at the first mobile number textbox", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    Exit Sub
            'End If

            If Not arrCheckValidationUpdate(7) Then
                MessageBox.Show("Enter the Address the first address textbox", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If Not arrCheckValidationUpdate(8) Then
                MessageBox.Show("Enter the Address the second address textbox", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If Not arrCheckValidationUpdate(9) Then
                MessageBox.Show("Select the Nationality", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If Not arrCheckValidationUpdate(10) Then
                MessageBox.Show("Select the Gender", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            connection = New MySqlConnection(My.Settings.conPathDb)

            Try

                Using writer As New StreamWriter(splash_screen.log.ToString, True)
                    If splash_screen.lines < 1 Then
                        writer.WriteLine("DATE TIME" & vbTab & vbTab & " ACTION" & vbTab & vbTab & vbTab & vbTab & " LOCATION")
                    End If
                    writer.WriteLine(Date.Now & vbTab & "Updated an Agent from the Database" & vbTab & Me.Text)
                End Using


                connection.Open()
                Dim query As String = "UPDATE g3subvb.user SET fName = @fName, lName = @lName, DOB = @DOB, Gender = @Gender, First_email = @First_email, First_Phone_No = @First_Phone_No, First_Address = @First_Address, Nationality = @Nationality, mName = @mName, Second_email = @Second_email, Second_Phone_No = @Second_Phone_No, Second_Address = @Second_Address WHERE User_Id = @UserId;"


                Using command As New MySqlCommand(query, connection)
                    Dim gender As String = ""
                    If rboFemaleUpdate.Checked Then
                        gender = "Female"
                    ElseIf rboMaleUpdate.Checked Then
                        gender = "Male"
                    End If

                    command.Parameters.AddWithValue("@fName", txtFNameUpdate.Text)
                    command.Parameters.AddWithValue("@lName", txtLNameUpdate.Text)
                    command.Parameters.AddWithValue("@DOB", dtpDOBUpdate.Value)
                    command.Parameters.AddWithValue("@Gender", gender)
                    command.Parameters.AddWithValue("@First_email", txtEmailUpdate.Text)
                    command.Parameters.AddWithValue("@First_Phone_No", "+233" & txtPhoneNoUpdate.Text.Substring(2))
                    command.Parameters.AddWithValue("@First_Address", txtAddressUpdate.Text)
                    command.Parameters.AddWithValue("@Nationality", cboCountryUpdate.SelectedItem)


                    If Not String.IsNullOrEmpty(txtMnameUpdate.Text) Then
                        command.Parameters.AddWithValue("@mName", txtMnameUpdate.Text)
                    Else
                        command.Parameters.AddWithValue("@mName", DBNull.Value)
                    End If

                    If Not String.IsNullOrEmpty(txtSecEmailUpdate.Text) Then
                        command.Parameters.AddWithValue("@Second_email", txtSecEmailUpdate.Text)
                    Else
                        command.Parameters.AddWithValue("@Second_email", DBNull.Value)
                    End If

                    If Not String.IsNullOrEmpty(txtSecPhoneNoUpdate.Text) Then
                        command.Parameters.AddWithValue("@Second_Phone_No", "+233" & txtSecPhoneNoUpdate.Text.Substring(2))
                    Else
                        command.Parameters.AddWithValue("@Second_Phone_No", DBNull.Value)
                    End If

                    If Not String.IsNullOrEmpty(txtSecAddressUpdate.Text) Then
                        command.Parameters.AddWithValue("@Second_Address", txtSecAddressUpdate.Text)
                    Else
                        command.Parameters.AddWithValue("@Second_Address", DBNull.Value)
                    End If

                    command.Parameters.AddWithValue("@UserId", agentId)

                    command.ExecuteNonQuery()
                End Using


                query = "UPDATE g3subvb.login SET Username = @Username where  User_Id = @UserId;"

                Dim Username As String = txtFname.Text.ToLower & "." & txtLname.Text.ToLower
                Using command As New MySqlCommand(query, connection)

                    command.Parameters.AddWithValue("@Username", Username)
                    command.Parameters.AddWithValue("@UserId", agentId)
                    command.ExecuteNonQuery()
                End Using

                clear()
                MessageBox.Show("Information Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                connection.Close()
                loadData(dgvDelete)
                loadData(dgvUpdate)


            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                connection.Dispose()
            End Try

        End If

    End Sub

    Private Sub frmAgentManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clear()
        clearUpdate()
        loadData(dgvDelete)
        loadData(dgvUpdate)

    End Sub

    Private Sub loadData(ByVal dataGridView As DataGridView)
        Dim SDA As New MySqlDataAdapter
        Dim bsource As New BindingSource
        Dim dbDataset As New DataTable


        connection = New MySqlConnection(My.Settings.conPathDb)

        Try
            connection.Open()

            Dim query As String = "SELECT User_Id,fName,lName,mName,DOB,Gender,First_email,Second_email,First_Phone_No,Second_Phone_No,First_Address,Second_Address,Nationality FROM g3subvb.user; "
            Using command = New MySqlCommand(query, connection)
                SDA.SelectCommand = command
                SDA.Fill(dbDataset)
                bsource.DataSource = dbDataset
                dataGridView.DataSource = bsource
                SDA.Update(dbDataset)
            End Using

            Dim queryNat As String = "SELECT DISTINCT Nationality FROM g3subvb.user ;"
            Using command = New MySqlCommand(queryNat, connection)
                Dim reader As MySqlDataReader = command.ExecuteReader
                While reader.Read
                    Dim nation = reader.GetString("Nationality")
                    cboCountryUpdate.Items.Add(nation)
                End While
            End Using
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        dbDataset1 = dbDataset

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If deleteAction Then
            Dim deleteMessage As DialogResult = MessageBox.Show("Are you sure you want to delete the data", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)

            If deleteMessage = DialogResult.Yes Then
                connection = New MySqlConnection(My.Settings.conPathDb)


                Try
                    Using writer As New StreamWriter(splash_screen.log.ToString, True)
                        If splash_screen.lines < 1 Then
                            writer.WriteLine("DATE TIME" & vbTab & vbTab & " ACTION" & vbTab & vbTab & vbTab & vbTab & " LOCATION")
                        End If
                        writer.WriteLine(Date.Now & vbTab & "Deleted an Agent from the Database" & vbTab & Me.Text)
                    End Using

                    connection.Open()

                    Dim query As String = "Delete from g3subvb.user where User_Id = " & agentId & ";"
                    Dim deleteUserCommand As New MySqlCommand(query, connection)
                    Dim reader As MySqlDataReader = deleteUserCommand.ExecuteReader
                    reader.Close()


                    Dim loginQuery As String = "Delete from g3subvb.login where User_Id = " & agentId & ";"
                    Dim deleteLoginCommand As New MySqlCommand(loginQuery, connection)
                    Dim readerLogin As MySqlDataReader = deleteLoginCommand.ExecuteReader
                    readerLogin.Close()

                    MessageBox.Show("Data Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    connection.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    connection.Dispose()
                End Try
                loadData(dgvDelete)
                loadData(dgvUpdate)

            End If
        Else
            MessageBox.Show("Select the data you want to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub dgvDelete_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDelete.CellClick
        If e.RowIndex >= 0 Then
            deleteAction = True
            Dim row As New DataGridViewRow
            row = Me.dgvDelete.Rows(e.RowIndex)
            agentId = CInt(row.Cells("User_Id").Value)
        End If
    End Sub

    Private Sub dgvUpdate_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUpdate.CellClick
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            clearUpdate()
            updateAction = True
            Dim row As New DataGridViewRow
            row = Me.dgvUpdate.Rows(e.RowIndex)
            agentId = CInt(row.Cells("User_Id").Value)



            If row.Cells("Gender").Value.ToString = "Female" Then
                rboFemaleUpdate.Checked = True
            ElseIf row.Cells("Gender").Value.ToString = "Male" Then
                rboMaleUpdate.Checked = True
            End If

            txtFNameUpdate.Text = row.Cells("fName").Value.ToString
            txtLNameUpdate.Text = row.Cells("lName").Value.ToString
            txtMnameUpdate.Text = row.Cells("mName").Value.ToString
            dtpDOBUpdate.Value = row.Cells("DOB").Value.ToString
            txtEmailUpdate.Text = row.Cells("First_email").Value.ToString
            txtSecEmailUpdate.Text = row.Cells("Second_email").Value.ToString
            If Not row.Cells("First_Phone_no").Value.ToString = "" Then
                txtPhoneNoUpdate.Text = "0" & row.Cells("First_Phone_no").Value.ToString.Substring(4)
            End If
            If Not row.Cells("Second_Phone_no").Value.ToString = "" Then
                txtSecPhoneNoUpdate.Text = "0" & row.Cells("Second_Phone_no").Value.ToString.Substring(4)
            End If
            txtAddressUpdate.Text = row.Cells("First_Address").Value.ToString
            txtSecAddressUpdate.Text = row.Cells("Second_Address").Value.ToString
            cboCountryUpdate.Text = row.Cells("Nationality").Value.ToString

        End If
    End Sub

    Private Sub btnDeleteAll_Click(sender As Object, e As EventArgs) Handles btnDeleteAll.Click
        Dim deleteMessage As DialogResult = MessageBox.Show("Are you sure you want to delete all the data", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)

        If deleteMessage = DialogResult.Yes Then
            connection = New MySqlConnection(My.Settings.conPathDb)
            Try
                Using writer As New StreamWriter(splash_screen.log.ToString, True)
                    If splash_screen.lines < 1 Then
                        writer.WriteLine("DATE TIME" & vbTab & vbTab & " ACTION" & vbTab & vbTab & vbTab & vbTab & " LOCATION")
                    End If
                    writer.WriteLine(Date.Now & vbTab & "Deleted All Agent from the Database" & vbTab & Me.Text)
                End Using

                connection.Open()

                Dim query As String = "Delete from g3subvb.user where user_id <> 1;"
                Dim deleteAllCommand As New MySqlCommand(query, connection)
                Dim readerAll As MySqlDataReader = deleteAllCommand.ExecuteReader
                readerAll.Close()

                Dim queryLogin As String = "Delete from g3subvb.login where user_id <> 1;"
                Dim deleteAllLoginCommand As New MySqlCommand(queryLogin, connection)
                Dim readerLoginAll As MySqlDataReader = deleteAllLoginCommand.ExecuteReader
                readerLoginAll.Close()

                MessageBox.Show("All Data Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                connection.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                connection.Dispose()
            End Try

            loadData(dgvDelete)
            loadData(dgvUpdate)
        End If

    End Sub
End Class