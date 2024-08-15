Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class frmCustomerDetail
    Dim con As MySqlConnection
    Dim com As MySqlCommand
    Dim dbDataset1 As New DataTable

    Dim checked As Boolean = False
    Dim Action As Boolean = False
    Dim query As String = "SELECT `Customer_Id`, `fName`, `lName`, `mName`, `Gender`, `First_email`, `Second_email`, `First_Phone_No`, `Second_Phone_No`, `First_Address`, `Second_Address`, `Nationality` FROM `customer`;"
    Dim isFemail As Boolean = False
    Dim isSemail As Boolean = True
    Dim customerId As Integer = 0

    Dim FEmailError As New ErrorProvider
    Dim SEmailError As New ErrorProvider
    Dim LNError As New ErrorProvider
    Dim FNError As New ErrorProvider
    Dim MNError As New ErrorProvider
    Dim SAError As New ErrorProvider
    Dim FAError As New ErrorProvider
    Dim SPError As New ErrorProvider
    Dim FPError As New ErrorProvider


    Private Sub frmCustomerDetail_Load(sender As Object, e As EventArgs) Handles Me.Load
        cboSortByCountry.SelectedIndex = 0
        Try
            con = New MySqlConnection(My.Settings.conPathDb)
            con.Open()

            Dim query As String = "SELECT DISTINCT `Nationality` FROM `customer`;"
            com = New MySqlCommand(query, con)
            Dim reader As MySqlDataReader = com.ExecuteReader

            While reader.Read
                cboSortByCountry.Items.Add(reader("Nationality"))
            End While
            reader.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        query = "SELECT `Customer_Id`, `fName`, `lName`, `mName`, `Gender`, `First_email`, `Second_email`, `First_Phone_No`, `Second_Phone_No`, `First_Address`, `Second_Address`, `Nationality` FROM `customer`;"
        loadData()
        checked = True
        clear()
    End Sub

    Private Sub loadData()
        Dim SDA As New MySqlDataAdapter
        Dim bsource As New BindingSource
        Dim dbDataset As New DataTable

        con = New MySqlConnection(My.Settings.conPathDb)

        Try
            con.Open()

            com = New MySqlCommand(query, con)
            SDA.SelectCommand = com
            SDA.Fill(dbDataset)
            bsource.DataSource = dbDataset
            dgvCustomerDetail.DataSource = bsource
            SDA.Update(dbDataset)
            dbDataset1 = dbDataset
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cboSortByCountry_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSortByCountry.SelectedIndexChanged
        Dim DV As New DataView(dbDataset1)
        If cboSortByCountry.SelectedIndex > 0 Then
            DV.RowFilter = String.Format("Nationality like '%{0}%'", cboSortByCountry.Text)
            dgvCustomerDetail.DataSource = DV
        Else
            loadData()
        End If

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If checked Then
            Dim DV As New DataView(dbDataset1)
            DV.RowFilter = String.Format("fName like '%{0}%' or lName like '%{0}%' or mName like '%{0}%'", txtSearch.Text)
            dgvCustomerDetail.DataSource = DV
        End If
    End Sub

    Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click
        query = "SELECT `Customer_Id`, `fName`, `lName`, `mName`, `Gender`, `First_email`, `Second_email`, `First_Phone_No`, `Second_Phone_No`, `First_Address`, `Second_Address`, `Nationality` FROM `customer`;"
        loadData()
        txtSearch.Text = ""
        cboSortByCountry.SelectedIndex = 0
    End Sub

    Private Sub btnOwner_Click(sender As Object, e As EventArgs) Handles btnOwner.Click
        query = "SELECT DISTINCT customer.`Customer_Id`, customer.`fName`, customer.`lName`, customer.`mName`, customer.`Gender`, customer.`First_email`, customer.`Second_email`, customer.`First_Phone_No`, customer.`Second_Phone_No`, customer.`First_Address`, customer.`Second_Address`, customer.`Nationality`, ownership.Owner_Id FROM `customer` RIGHT JOIN ownership on customer.Customer_Id = ownership.Customer_id;"
        loadData()
        txtSearch.Text = ""
        cboSortByCountry.SelectedIndex = 0
    End Sub

    Private Sub btnTrenant_Click(sender As Object, e As EventArgs) Handles btnTrenant.Click
        query = "SELECT DISTINCT customer.`Customer_Id`, customer.`fName`, customer.`lName`, customer.`mName`, customer.`Gender`, customer.`First_email`, customer.`Second_email`, customer.`First_Phone_No`, customer.`Second_Phone_No`, customer.`First_Address`, customer.`Second_Address`, customer.`Nationality`, tenant.Tenant_Id FROM `customer` RIGHT JOIN tenant on customer.Customer_Id = tenant.Customer_id;"
        loadData()
        txtSearch.Text = ""
        cboSortByCountry.SelectedIndex = 0
    End Sub

    Private Sub clear()
        cboSortByCountry.SelectedIndex = 0
        txtSearch.Text = ""
        txtFName.Text = ""
        txtLName.Text = ""
        txtMName.Text = ""
        rdoFemale.Checked = False
        rdoMale.Checked = False
        cboNationality.SelectedIndex = -1
        txtFEmail.Text = ""
        txtSEmail.Text = ""
        txtFAddress.Text = ""
        txtSAddress.Text = ""
        txtFPhoneNumber.Text = ""
        txtSPhoneNumber.Text = ""
        FEmailError.Clear()
        SEmailError.Clear()
        LNError.Clear()
        FNError.Clear()
        MNError.Clear()
        SAError.Clear()
        FAError.Clear()
        SPError.Clear()
        FPError.Clear()
    End Sub


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clear()
    End Sub

    Private Sub txtFPhoneNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFPhoneNumber.KeyPress
        If Asc(e.KeyChar) <> 8 AndAlso Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 AndAlso e.KeyChar <> vbBack Then
            e.Handled = True
        End If

        If txtFPhoneNumber.Text.Length = 10 AndAlso e.KeyChar <> vbBack Then
            e.Handled = True
        End If

    End Sub
    Private Sub txtSPhoneNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSPhoneNumber.KeyPress
        If Asc(e.KeyChar) <> 8 AndAlso Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 AndAlso e.KeyChar <> vbBack Then
            e.Handled = True
        End If

        If txtSPhoneNumber.Text.Length = 10 AndAlso e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtFName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMName.KeyPress, txtLName.KeyPress, txtFName.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> vbBack Then
            e.Handled = True
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

    Private Sub txtFEmail_TextChanged(sender As Object, e As EventArgs) Handles txtFEmail.TextChanged

        If txtFEmail.Text.Length > 0 Then
            isFemail = showMatch(txtFEmail.Text, "\b([a-z\d\.-]+)@([a-z\d-]+)\.([a-z]{2,8})(\.[a-z]{2,8})?\b")
            If Not isFemail Then
                FEmailError.SetError(txtFEmail, "Enter a correct email")
            Else
                FEmailError.Clear()
            End If
        End If
    End Sub

    Private Sub txtSEmail_TextChanged(sender As Object, e As EventArgs) Handles txtSEmail.TextChanged

        If txtSEmail.Text.Length > 0 Then
            isSemail = showMatch(txtSEmail.Text, "\b([a-z\d\.-]+)@([a-z\d-]+)\.([a-z]{2,8})(\.[a-z]{2,8})?\b")
            If Not isSemail Then
                SEmailError.SetError(txtSEmail, "Enter a correct email")
            Else
                SEmailError.Clear()
            End If
        Else
            isSemail = True
            SEmailError.Clear()
        End If
    End Sub

    Private Sub txtFAddress_TextChanged(sender As Object, e As EventArgs) Handles txtFAddress.TextChanged
        If txtFAddress.Text.Length < 3 Then
            FAError.SetError(txtFAddress, "Enter a correct Address")
        Else
            FAError.clear
        End If
    End Sub

    Private Sub txtLName_TextChanged(sender As Object, e As EventArgs) Handles txtLName.TextChanged
        If txtLName.Text.Length < 3 Then
            LNError.SetError(txtLName, "Enter the Last Name")
        Else
            LNError.clear
        End If
    End Sub

    Private Sub txtFName_TextChanged(sender As Object, e As EventArgs) Handles txtFName.TextChanged
        If txtFName.Text.Length < 3 Then
            FNError.SetError(txtFName, "Enter the First Name")
        Else
            FNError.clear
        End If
    End Sub

    Private Sub txtFPhoneNumber_TextChanged(sender As Object, e As EventArgs) Handles txtFPhoneNumber.TextChanged
        If Not txtFPhoneNumber.Text.Length = 10 Then
            FPError.setError(txtFPhoneNumber, "Enter a 10 Digit number")
        Else
            FPError.clear
        End If
    End Sub

    Private Sub txtSAddress_TextChanged(sender As Object, e As EventArgs) Handles txtSAddress.TextChanged
        If txtSAddress.Text.Length > 0 Then
            If txtSAddress.Text.Length < 3 Then
                SAError.SetError(txtSAddress, "Enter a correct Address")
            Else
                SAError.clear
            End If
        Else
            sAError.clear
        End If
    End Sub

    Private Sub txtSPhoneNumber_TextChanged(sender As Object, e As EventArgs) Handles txtSPhoneNumber.TextChanged
        If txtSPhoneNumber.Text.Length > 0 Then
            If Not txtSPhoneNumber.Text.Length = 10 Then
                sPError.setError(txtSPhoneNumber, "Enter a 10 Digit number")
            Else
                sPError.clear
            End If
        Else
            sPError.clear
        End If
    End Sub

    Private Sub txtMName_TextChanged(sender As Object, e As EventArgs) Handles txtMName.TextChanged
        If txtMName.Text.Length > 0 Then
            If txtMName.Text.Length < 3 Then
                MNError.SetError(txtMName, "Enter the Middle Name")
            Else
                MNError.clear
            End If
        Else
            mNError.clear
        End If
    End Sub

    Private Function valid() As Boolean
        If txtFName.Text.Length < 3 Then
            MessageBox.Show("Enter the First Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If txtLName.Text.Length < 3 Then
            MessageBox.Show("Enter the Last Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If txtMName.Text.Length > 0 Then
            If txtMName.Text.Length < 3 Then
                MessageBox.Show("Enter the Middle Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        End If

        If Not (rdoFemale.Checked Or rdoMale.Checked) Then
            MessageBox.Show("Select the Gender", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If cboNationality.SelectedIndex = -1 Then
            MessageBox.Show("Select the Gender", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If Not isFemail Then
            MessageBox.Show("Enter the First Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If Not isSemail Then
            MessageBox.Show("Enter the Second Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If txtFAddress.Text.Length < 3 Then
            MessageBox.Show("Enter the First Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If txtSAddress.Text.Length > 0 Then
            If txtSAddress.Text.Length < 3 Then
                MessageBox.Show("Enter the Second Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        End If

        If Not (txtFPhoneNumber.Text.Length = 10) Then
            MessageBox.Show("Enter the First Phone Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If txtSPhoneNumber.Text.Length > 0 Then
            If Not (txtSPhoneNumber.Text.Length = 10) Then
                MessageBox.Show("Enter the Second Phone Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        End If

        Return True
    End Function

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If Action Then
            If valid() Then
                Dim connection = New MySqlConnection(My.Settings.conPathDb)

                Try

                    connection.Open()
                    Dim query As String = "UPDATE g3subvb.customer SET fName = @fName, lName = @lName, Gender = @Gender, First_email = @First_email, First_Phone_No = @First_Phone_No, First_Address = @First_Address, Nationality = @Nationality, mName = @mName, Second_email = @Second_email, Second_Phone_No = @Second_Phone_No, Second_Address = @Second_Address WHERE Customer_Id = @CustomerId;"


                    Using command As New MySqlCommand(query, connection)
                        Dim gender As String = ""
                        If rdoFemale.Checked Then
                            gender = "Female"
                        ElseIf rdoMale.Checked Then
                            gender = "Male"
                        End If

                        command.Parameters.AddWithValue("@fName", txtFName.Text)
                        command.Parameters.AddWithValue("@lName", txtLName.Text)
                        command.Parameters.AddWithValue("@Gender", gender)
                        command.Parameters.AddWithValue("@First_email", txtFEmail.Text)
                        command.Parameters.AddWithValue("@First_Phone_No", "+233" & txtFPhoneNumber.Text.Substring(1))
                        command.Parameters.AddWithValue("@First_Address", txtFAddress.Text)
                        command.Parameters.AddWithValue("@Nationality", cboNationality.SelectedItem)


                        If Not String.IsNullOrEmpty(txtMName.Text) Then
                            command.Parameters.AddWithValue("@mName", txtMName.Text)
                        Else
                            command.Parameters.AddWithValue("@mName", DBNull.Value)
                        End If

                        If Not String.IsNullOrEmpty(txtSEmail.Text) Then
                            command.Parameters.AddWithValue("@Second_email", txtSEmail.Text)
                        Else
                            command.Parameters.AddWithValue("@Second_email", DBNull.Value)
                        End If

                        If Not String.IsNullOrEmpty(txtSPhoneNumber.Text) Then
                            command.Parameters.AddWithValue("@Second_Phone_No", "+233" & txtSPhoneNumber.Text.Substring(1))
                        Else
                            command.Parameters.AddWithValue("@Second_Phone_No", DBNull.Value)
                        End If

                        If Not String.IsNullOrEmpty(txtSAddress.Text) Then
                            command.Parameters.AddWithValue("@Second_Address", txtSAddress.Text)
                        Else
                            command.Parameters.AddWithValue("@Second_Address", DBNull.Value)
                        End If

                        command.Parameters.AddWithValue("@CustomerId", customerId)
                        command.ExecuteNonQuery()
                    End Using

                    MessageBox.Show("Information Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    connection.Close()
                    loadData()
                    clear()

                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    connection.Dispose()
                End Try

            End If
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If valid() Then

            Dim connection As New MySqlConnection(My.Settings.conPathDb)

            Try

                connection.Open()
                Dim query As String = "INSERT INTO g3subvb.customer (fName, lName, Gender, First_email, First_Phone_No, First_Address, Nationality, User_Id"
                Dim values As String = " VALUES (@fName, @lName, @Gender, @First_email, @First_Phone_No, @First_Address, @Nationality, @UserId"

                If Not String.IsNullOrEmpty(txtMName.Text) Then
                    query &= ", mName"
                    values &= ", @mName"
                End If

                If Not String.IsNullOrEmpty(txtSEmail.Text) Then
                    query &= ", Second_email"
                    values &= ", @Second_email"
                End If

                If Not String.IsNullOrEmpty(txtSPhoneNumber.Text) Then
                    query &= ", Second_Phone_No"
                    values &= ", @Second_Phone_No"
                End If

                If Not String.IsNullOrEmpty(txtSAddress.Text) Then
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

                    command.Parameters.AddWithValue("@fName", txtFName.Text)
                    command.Parameters.AddWithValue("@lName", txtLName.Text)
                    command.Parameters.AddWithValue("@Gender", gender)
                    command.Parameters.AddWithValue("@First_email", txtFEmail.Text)
                    command.Parameters.AddWithValue("@First_Phone_No", "+233" & txtFPhoneNumber.Text.Substring(1))
                    command.Parameters.AddWithValue("@First_Address", txtFAddress.Text)
                    command.Parameters.AddWithValue("@Nationality", cboNationality.SelectedItem)
                    command.Parameters.AddWithValue("@UserId", Mode.UserId)

                    If Not String.IsNullOrEmpty(txtMName.Text) Then
                        command.Parameters.AddWithValue("@mName", txtMName.Text)
                    End If

                    If Not String.IsNullOrEmpty(txtSEmail.Text) Then
                        command.Parameters.AddWithValue("@Second_email", txtSEmail.Text)
                    End If

                    If Not String.IsNullOrEmpty(txtSPhoneNumber.Text) Then
                        command.Parameters.AddWithValue("@Second_Phone_No", "+233" & txtSPhoneNumber.Text.Substring(1))
                    End If

                    If Not String.IsNullOrEmpty(txtSAddress.Text) Then
                        command.Parameters.AddWithValue("@Second_Address", txtSAddress.Text)
                    End If
                    command.ExecuteNonQuery()
                End Using

                clear()
                MessageBox.Show("Information Saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                connection.Close()
                loadData()

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                connection.Dispose()
            End Try
        End If
    End Sub

    Private Sub dgvCustomerDetail_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCustomerDetail.CellClick
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            clear()
            Action = True
            Dim row As New DataGridViewRow
            row = Me.dgvCustomerDetail.Rows(e.RowIndex)
            customerId = CInt(row.Cells("Customer_Id").Value)

            If row.Cells("Gender").Value.ToString = "Female" Then
                rdoFemale.Checked = True
            ElseIf row.Cells("Gender").Value.ToString = "Male" Then
                rdoMale.Checked = True
            End If

            txtFName.Text = row.Cells("fName").Value.ToString
            txtLName.Text = row.Cells("lName").Value.ToString
            txtMName.Text = row.Cells("mName").Value.ToString
            txtFEmail.Text = row.Cells("First_email").Value.ToString
            txtSEmail.Text = row.Cells("Second_email").Value.ToString
            If Not row.Cells("First_Phone_no").Value.ToString = "" Then
                txtFPhoneNumber.Text = "0" & row.Cells("First_Phone_no").Value.ToString.Substring(4)
            End If
            If Not row.Cells("Second_Phone_no").Value.ToString = "" Then
                txtSPhoneNumber.Text = "0" & row.Cells("Second_Phone_no").Value.ToString.Substring(4)
            End If
            txtFAddress.Text = row.Cells("First_Address").Value.ToString
            txtSAddress.Text = row.Cells("Second_Address").Value.ToString
            cboNationality.Text = row.Cells("Nationality").Value.ToString

        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If Action Then
            Dim deleteMessage As DialogResult = MessageBox.Show("Are you sure you want to delete the data", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)

            If deleteMessage = DialogResult.Yes Then
                Dim connection = New MySqlConnection(My.Settings.conPathDb)


                Try

                    connection.Open()

                    Dim query As String = "Delete from g3subvb.customer where Customer_Id = " & customerId & ";"
                    Dim Command As New MySqlCommand(query, connection)
                    Dim reader As MySqlDataReader = Command.ExecuteReader
                    reader.Close()

                    MessageBox.Show("Data Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    connection.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    connection.Dispose()
                End Try
                loadData()
                clear()
            End If
        Else
            MessageBox.Show("Select the data you want to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class