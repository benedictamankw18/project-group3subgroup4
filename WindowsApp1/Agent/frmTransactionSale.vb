Imports MySql.Data.MySqlClient

Public Class frmTransactionSale
    Dim con As MySqlConnection
    Dim com As MySqlCommand
    Dim saleType() As String = {"PENDING", "OFFER ACCEPTED", "CLOSED", "CANCELLED"}
    Dim transactionType() As String = {"COMPLETED", "PENDING", "PROCESSING"}
    Dim dbDataset1 As New DataTable
    Dim query As String
    Dim checked As Boolean = False
    Dim saleOrTrans As Integer = 0

    Private Sub frmTransactionSale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpDate.Value = Now
        dtpDate.MaxDate = Now

        dtpClosedDate.Value = Now.AddHours(-3)
        dtpClosedDate.MaxDate = Now

        transaction()
        Dim query As String
        Try
            con = New MySqlConnection(My.Settings.conPathDb)
            con.Open()
            query = "select Property_name from property;"
            Using com As New MySqlCommand(query, con)
                Dim dr As MySqlDataReader = com.ExecuteReader
                While dr.Read
                    cboPropertyName.Items.Add(dr("Property_name"))
                End While
                dr.Close()
            End Using

            query = "select case when mName Is NULL or mName = '' then concat(fName, ' ', lName) else concat(fName, ' ', mName, ' ', lName) end as Customer_name from customer;"
            Using com As New MySqlCommand(query, con)
                Dim dr As MySqlDataReader = com.ExecuteReader
                While dr.Read
                    cboCustomerName.Items.Add(dr("Customer_name"))
                End While
                dr.Close()
            End Using

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnTransaction_Click(sender As Object, e As EventArgs) Handles btnTransaction.Click
        transaction()
    End Sub

    Private Sub btnSale_Click(sender As Object, e As EventArgs) Handles btnSale.Click
        sale()
    End Sub

    Private Sub transaction()
        cboStatus.Items.Clear()
        cboStatus.Items.AddRange(transactionType)
        lblDate.Text = "TRANSACTION DATE"
        lblSaleNote.Visible = False
        lblStatus.Text = "TRANSACTION STATUS"
        lblTransactionType.Visible = True
        lblClosedDate.Visible = False
        dtpClosedDate.Visible = False
        txtSaleNote.Visible = False
        cboTransactionType.Visible = True
        query = "SELECT t.Transaction_Id, p.Property_name, CASE WHEN c.mName IS NULL OR c.mName = '' THEN CONCAT(c.fName, ' ', c.lName) ELSE CONCAT(c.fName, ' ', c.mName, ' ', c.lName) END AS Customer_Name,  p.Property_sale_rent AS 'Sale Or Rent', t.Transaction_Amount, p.Property_Price, t.Payment_Mode, t.Transaction_Status, t.Transaction_Date, t.Transaction_type, t.Payment_reference FROM g3subvb.transaction AS t LEFT JOIN g3subvb.property AS p ON t.Property_Id = p.Property_Id LEFT JOIN g3subvb.customer AS c ON t.Customer_id = c.Customer_id;"
        loadData(query)
        saleOrTrans = 1
        clear()
    End Sub

    Private Sub sale()
        cboStatus.Items.Clear()
        cboStatus.Items.AddRange(saleType)
        lblDate.Text = "SALE DATE"
        lblSaleNote.Visible = True
        lblStatus.Text = "SALE STATUS"
        lblTransactionType.Visible = False
        lblClosedDate.Visible = True
        dtpClosedDate.Visible = True
        txtSaleNote.Visible = True
        cboTransactionType.Visible = False
        txtSaleNote.Left = 282
        lblSaleNote.Left = 282
        dtpClosedDate.Left = cboTransactionType.Left
        lblClosedDate.Left = cboTransactionType.Left
        query = "SELECT s.sale_Id, p.Property_name, CASE WHEN c.mName IS NULL OR c.mName = '' THEN CONCAT(c.fName, ' ', c.lName) ELSE CONCAT(c.fName, ' ', c.mName, ' ', c.lName) END AS Customer_Name,  p.Property_sale_rent AS 'Sale Or Rent', s.Sale_Amount, p.Property_Price, s.Payment_Mode, s.Sale_Status, s.sale_Date, s.Closing_Date, s.Payment_reference, s.Sale_Notes FROM g3subvb.sale AS s  JOIN g3subvb.property AS p ON s.Property_Id = p.Property_Id  JOIN g3subvb.customer AS c ON s.Customer_id = c.Customer_id;"
        loadData(query)
        saleOrTrans = 2
        clear()
    End Sub

    Private Sub clear()
        cboCustomerName.SelectedIndex = -1
        cboPaymentMode.SelectedIndex = -1
        cboPropertyName.SelectedIndex = -1
        cboStatus.SelectedIndex = -1
        cboTransactionType.SelectedIndex = -1
        txtAmountPaid.Text = ""
        txtPaymentReference.Text = ""
        txtPropertyPrice.Text = ""
        txtPropertySaleRent.Text = ""
        txtSaleNote.Text = ""
        ' txtSearch.Text = ""
        dtpClosedDate.Value = Now.AddHours(-3)
        dtpDate.Value = dtpDate.MaxDate
        id = 0
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clear()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If saleOrTrans = 1 Then

            If cboPropertyName.SelectedIndex = -1 Or txtPropertyPrice.Text = "" Or txtPropertySaleRent.Text = "" Then
                MessageBox.Show("Select the Property Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If cboCustomerName.SelectedIndex = -1 Then
                MessageBox.Show("Make sure to fill in the Customer Details before progressing here" & vbNewLine & "Select the Customer Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If cboPaymentMode.SelectedIndex = -1 Then
                MessageBox.Show("Select the Mode Of Payment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If txtAmountPaid.Text.Trim.Length = 0 Then
                MessageBox.Show("Enter the Amount Paid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If cboStatus.SelectedIndex = -1 Then
                MessageBox.Show("Select the Status", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If txtPaymentReference.Text.Trim.Length = 0 Then
                MessageBox.Show("Enter payment refercene", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If cboTransactionType.SelectedIndex = -1 Then
                MessageBox.Show("Select the Transaction Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Dim propertyPrice As Decimal = Decimal.Parse(txtPropertyPrice.Text)
            Dim amountPaid As Decimal = Decimal.Parse(txtAmountPaid.Text)

            If propertyPrice < amountPaid Then
                MessageBox.Show("Your Enter more then Accepted Amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If cboTransactionType.SelectedIndex = 0 Then
                MessageBox.Show("Refund Must be 10% off", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If txtPropertyPrice.Text.Length > 0 Then
                    txtAmountPaid.Text = (CDec(txtPropertyPrice.Text) / 100) * 90
                Else
                    MessageBox.Show("Select the Property Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If

            If cboTransactionType.SelectedIndex = 1 AndAlso (amountPaid = propertyPrice) Then
                MessageBox.Show("Adjustment must not be paid fully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If cboTransactionType.SelectedIndex = 2 Then
                MessageBox.Show("Enter Transaction type 'Sale' at Sale Section", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If id <> 0 Then

                Using connection As New MySqlConnection(My.Settings.conPathDb)
                    connection.Open()
                    Try
                        ' Insert sale record
                        Dim query = "UPDATE `transaction` SET `Property_Id`=(SELECT property.Property_Id FROM property WHERE property.Property_name = @PropertyName and property.Property_sale_rent = @Sale and property.Property_Price = @Price),`Customer_id`=(SELECT customer.Customer_Id FROM customer WHERE CASE WHEN customer.mName IS null or customer.mName = '' THEN CONCAT(customer.fName, ' ', customer.lName) ELSE CONCAT(customer.fName, ' ', customer.mName, ' ', customer.lName) END = @CustomerName),`Transaction_Date`=@Transaction_Date,`Transaction_type`=@Transaction_type,`Payment_mode`=@Payment_mode,`Transaction_status`=@Transaction_status,`Payment_reference`=@Payment_reference,`Transaction_amount`=@Transaction_amount WHERE `Transaction_Id`=@id;"
                        Using command As New MySqlCommand(query, connection)
                            command.Parameters.AddWithValue("@id", id)
                            command.Parameters.AddWithValue("@PropertyName", cboPropertyName.Text)
                            command.Parameters.AddWithValue("@Sale", txtPropertySaleRent.Text)
                            command.Parameters.AddWithValue("@Price", CDec(txtPropertyPrice.Text))
                            command.Parameters.AddWithValue("@CustomerName", cboCustomerName.Text)
                            command.Parameters.AddWithValue("@Transaction_Date", dtpDate.Value)
                            command.Parameters.AddWithValue("@Transaction_amount", CDec(txtAmountPaid.Text))
                            command.Parameters.AddWithValue("@Transaction_status", cboStatus.Text)
                            command.Parameters.AddWithValue("@Payment_reference", txtPaymentReference.Text)
                            command.Parameters.AddWithValue("@Payment_mode", cboPaymentMode.Text)
                            command.Parameters.AddWithValue("@Transaction_type", cboTransactionType.Text)
                            command.ExecuteNonQuery()
                        End Using
                        query = "SELECT t.Transaction_Id, p.Property_name, CASE WHEN c.mName IS NULL OR c.mName = '' THEN CONCAT(c.fName, ' ', c.lName) ELSE CONCAT(c.fName, ' ', c.mName, ' ', c.lName) END AS Customer_Name,  p.Property_sale_rent AS 'Sale Or Rent', t.Transaction_Amount, p.Property_Price, t.Payment_Mode, t.Transaction_Status, t.Transaction_Date, t.Transaction_type, t.Payment_reference FROM g3subvb.transaction AS t LEFT JOIN g3subvb.property AS p ON t.Property_Id = p.Property_Id LEFT JOIN g3subvb.customer AS c ON t.Customer_id = c.Customer_id;"
                        loadData(query)
                        MessageBox.Show("Information Updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Catch ex As Exception
                        MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Using

            Else
                MessageBox.Show("Select from the table", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If


        ElseIf saleOrTrans = 2 Then
                If cboPropertyName.SelectedIndex = -1 Or txtPropertyPrice.Text = "" Or txtPropertySaleRent.Text = "" Then
                    MessageBox.Show("Select the Property Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                If cboCustomerName.SelectedIndex = -1 Then
                    MessageBox.Show("Make sure to fill in the Customer Details before progressing here" & vbNewLine & "Select the Customer Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                If cboPaymentMode.SelectedIndex = -1 Then
                    MessageBox.Show("Select the Mode Of Payment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                If txtAmountPaid.Text.Trim.Length = 0 Then
                    MessageBox.Show("Enter the Amount Paid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                If cboStatus.SelectedIndex = -1 Then
                    MessageBox.Show("Select the Status", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                If txtPaymentReference.Text.Trim.Length = 0 Then
                    MessageBox.Show("Enter payment refercene", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                If txtSaleNote.Text.Trim.Length = 0 Then
                    MessageBox.Show("Add Some Sale Note", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                Dim propertyPrice As Decimal = Decimal.Parse(txtPropertyPrice.Text)
                Dim amountPaid As Decimal = Decimal.Parse(txtAmountPaid.Text)

                If (propertyPrice = amountPaid) And (cboStatus.SelectedIndex <> 2 And cboStatus.SelectedIndex <> 3) Then
                    MessageBox.Show("Check the Amount and Status again, it's not matching", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                ElseIf cboStatus.SelectedIndex = 1 And amountPaid <> 0 Then
                    MessageBox.Show("Change the Amount to 0 if the Status is 'OFFER ACCEPTED'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                ElseIf cboStatus.SelectedIndex = 0 And amountPaid >= propertyPrice Then
                    MessageBox.Show("Amount is More than or Equal to the Property price and the Status is Pending " & vbNewLine & "Check and make the right Change", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                ElseIf cboStatus.SelectedIndex = 2 And Not (amountPaid >= propertyPrice) Then
                    MessageBox.Show("Amount is Not Equal to the Property price and the Status is Closed " & vbNewLine & "Check and make the right Change", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                ElseIf cboStatus.SelectedIndex = 0 And amountPaid = 0 Then
                    MessageBox.Show("Amount is 0 and the Status is Pending " & vbNewLine & "Check and make the right Change", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                If id <> 0 Then

                    Using connection As New MySqlConnection(My.Settings.conPathDb)
                        connection.Open()
                        Using transaction = connection.BeginTransaction()
                            Try

                                Dim query = "UPDATE `sale` SET `Property_Id`=(SELECT property.Property_Id FROM property WHERE property.Property_name = @PropertyName and property.Property_sale_rent = @Sale and property.Property_Price = @Price),`customer_Id`= (SELECT customer.Customer_Id FROM customer WHERE CASE WHEN customer.mName IS null or customer.mName = '' THEN CONCAT(customer.fName, ' ', customer.lName) ELSE CONCAT(customer.fName, ' ', customer.mName, ' ', customer.lName) END = @CustomerName),`Sale_Date`= @Date,`Sale_Amount`= @Amount,`Sale_Status`= @Status,`Closing_Date`=@CloseDate,`Payment_Mode`= @PaymentMode,`Payment_Reference`= @PaymentReference,`Sale_Notes`= @Note WHERE `Sale_Id`= @id;"
                                Using command As New MySqlCommand(query, connection, transaction)
                                    command.Parameters.AddWithValue("@id", id)
                                    command.Parameters.AddWithValue("@PropertyName", cboPropertyName.Text)
                                    command.Parameters.AddWithValue("@Sale", txtPropertySaleRent.Text)
                                    command.Parameters.AddWithValue("@Price", CDec(txtPropertyPrice.Text))
                                    command.Parameters.AddWithValue("@CustomerName", cboCustomerName.Text)
                                    command.Parameters.AddWithValue("@Date", dtpDate.Value)
                                    command.Parameters.AddWithValue("@Amount", CDec(txtAmountPaid.Text))
                                    command.Parameters.AddWithValue("@Status", cboStatus.Text)
                                    command.Parameters.AddWithValue("@Note", txtSaleNote.Text)
                                    command.Parameters.AddWithValue("@PaymentReference", txtPaymentReference.Text)
                                    command.Parameters.AddWithValue("@PaymentMode", cboPaymentMode.Text)
                                    If cboStatus.SelectedIndex = 2 Then
                                        command.Parameters.AddWithValue("@CloseDate", dtpClosedDate.Value)
                                    Else
                                        command.Parameters.AddWithValue("@CloseDate", DBNull.Value)
                                    End If
                                    command.ExecuteNonQuery()
                                End Using

                                Dim Available = If(cboStatus.SelectedIndex = 3, "Available", "Not Available")
                                Dim propertyQuery = "UPDATE `property` SET `Property_availability`= @Available WHERE `Property_Id`= (SELECT property.Property_Id FROM property WHERE property.Property_name = @PropertyName and property.Property_sale_rent = @Sale and property.Property_Price = @Price);"
                                Using propertyCommand As New MySqlCommand(propertyQuery, connection, transaction)
                                    propertyCommand.Parameters.AddWithValue("@Available", Available)
                                    propertyCommand.Parameters.AddWithValue("@PropertyName", cboPropertyName.Text)
                                    propertyCommand.Parameters.AddWithValue("@Sale", txtPropertySaleRent.Text)
                                    propertyCommand.Parameters.AddWithValue("@Price", CDec(txtPropertyPrice.Text))
                                    propertyCommand.ExecuteNonQuery()
                                End Using

                                ' Commit transaction
                                transaction.Commit()

                                MessageBox.Show("Information Updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                query = "SELECT s.sale_Id, p.Property_name, CASE WHEN c.mName IS NULL OR c.mName = '' THEN CONCAT(c.fName, ' ', c.lName) ELSE CONCAT(c.fName, ' ', c.mName, ' ', c.lName) END AS Customer_Name,  p.Property_sale_rent AS 'Sale Or Rent', s.Sale_Amount, p.Property_Price, s.Payment_Mode, s.Sale_Status, s.sale_Date, s.Closing_Date, s.Payment_reference, s.Sale_Notes FROM g3subvb.sale AS s  JOIN g3subvb.property AS p ON s.Property_Id = p.Property_Id  JOIN g3subvb.customer AS c ON s.Customer_id = c.Customer_id;"
                                loadData(query)
                            Catch ex As Exception
                                transaction.Rollback()
                                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End Try
                        End Using
                    End Using
                Else
                    MessageBox.Show("Select from the table", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MsgBox("Error")
        End If
        clear()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click


        If saleOrTrans = 1 Then
            Try
                If id <> 0 Then
                    If cboPropertyName.SelectedIndex = -1 Or txtPropertyPrice.Text = "" Or txtPropertySaleRent.Text = "" Then
                        MessageBox.Show("Select the Property Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If

                    Using connection As New MySqlConnection(My.Settings.conPathDb)
                        connection.Open()
                        Dim query = "DELETE FROM `transaction` WHERE Transaction_Id = @ID;"
                        Using command As New MySqlCommand(query, connection)
                            command.Parameters.AddWithValue("@ID", id)
                            command.ExecuteNonQuery()
                        End Using
                    End Using
                    query = "SELECT t.Transaction_Id, p.Property_name, CASE WHEN c.mName IS NULL OR c.mName = '' THEN CONCAT(c.fName, ' ', c.lName) ELSE CONCAT(c.fName, ' ', c.mName, ' ', c.lName) END AS Customer_Name,  p.Property_sale_rent AS 'Sale Or Rent', t.Transaction_Amount, p.Property_Price, t.Payment_Mode, t.Transaction_Status, t.Transaction_Date, t.Transaction_type, t.Payment_reference FROM g3subvb.transaction AS t LEFT JOIN g3subvb.property AS p ON t.Property_Id = p.Property_Id LEFT JOIN g3subvb.customer AS c ON t.Customer_id = c.Customer_id;"
                    loadData(query)
                    MessageBox.Show("Data Deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else
                    MessageBox.Show("Select from the table", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        ElseIf saleOrTrans = 2 Then
            Try
                If id <> 0 Then
                    If cboPropertyName.SelectedIndex = -1 Or txtPropertyPrice.Text = "" Or txtPropertySaleRent.Text = "" Then
                        MessageBox.Show("Select the Property Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If

                    Using connection As New MySqlConnection(My.Settings.conPathDb)
                        connection.Open()
                        Dim query = "DELETE FROM `sale` WHERE Sale_Id = @ID;"
                        Using command As New MySqlCommand(query, connection)
                            command.Parameters.AddWithValue("@ID", id)
                            command.ExecuteNonQuery()
                        End Using

                        Dim propertyQuery = "UPDATE `property` SET `Property_availability`= 'Available' WHERE `Property_Id`= (SELECT property.Property_Id FROM property WHERE property.Property_name = @PropertyName and property.Property_sale_rent = @Sale and property.Property_Price = @Price);"
                        Using propertyCommand As New MySqlCommand(propertyQuery, connection)
                            propertyCommand.Parameters.AddWithValue("@PropertyName", cboPropertyName.Text)
                            propertyCommand.Parameters.AddWithValue("@Sale", txtPropertySaleRent.Text)
                            propertyCommand.Parameters.AddWithValue("@Price", CDec(txtPropertyPrice.Text))
                            propertyCommand.ExecuteNonQuery()
                        End Using
                    End Using
                    MessageBox.Show("Data Deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    query = "SELECT s.sale_Id, p.Property_name, CASE WHEN c.mName IS NULL OR c.mName = '' THEN CONCAT(c.fName, ' ', c.lName) ELSE CONCAT(c.fName, ' ', c.mName, ' ', c.lName) END AS Customer_Name,  p.Property_sale_rent AS 'Sale Or Rent', s.Sale_Amount, p.Property_Price, s.Payment_Mode, s.Sale_Status, s.sale_Date, s.Closing_Date, s.Payment_reference, s.Sale_Notes FROM g3subvb.sale AS s  JOIN g3subvb.property AS p ON s.Property_Id = p.Property_Id  JOIN g3subvb.customer AS c ON s.Customer_id = c.Customer_id;"
                    loadData(query)

                Else
                    MessageBox.Show("Select from the table", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MsgBox("Error")
        End If
        clear()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Try
            If saleOrTrans = 2 Then
                If cboPropertyName.SelectedIndex = -1 Or txtPropertyPrice.Text = "" Or txtPropertySaleRent.Text = "" Then
                    MessageBox.Show("Select the Property Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                If cboCustomerName.SelectedIndex = -1 Then
                    MessageBox.Show("Make sure to fill in the Customer Details before progressing here" & vbNewLine & "Select the Customer Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                If cboPaymentMode.SelectedIndex = -1 Then
                    MessageBox.Show("Select the Mode Of Payment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                If txtAmountPaid.Text.Trim.Length = 0 Then
                    MessageBox.Show("Enter the Amount Paid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                If cboStatus.SelectedIndex = -1 Then
                    MessageBox.Show("Select the Status", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                If txtPaymentReference.Text.Trim.Length = 0 Then
                    MessageBox.Show("Enter payment refercene", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                If txtSaleNote.Text.Trim.Length = 0 Then
                    MessageBox.Show("Add Some Sale Note", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                Dim propertyPrice As Decimal = Decimal.Parse(txtPropertyPrice.Text)
                Dim amountPaid As Decimal = Decimal.Parse(txtAmountPaid.Text)

                If (propertyPrice = amountPaid) And (cboStatus.SelectedIndex <> 2 And cboStatus.SelectedIndex <> 3) Then
                    MessageBox.Show("Check the Amount and Status again, it's not matching", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                ElseIf cboStatus.SelectedIndex = 1 And amountPaid <> 0 Then
                    MessageBox.Show("Change the Amount to 0 if the Status is 'OFFER ACCEPTED'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                ElseIf cboStatus.SelectedIndex = 0 And amountPaid >= propertyPrice Then
                    MessageBox.Show("Amount is More than or Equal to the Property price and the Status is Pending " & vbNewLine & "Check and make the right Change", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                ElseIf cboStatus.SelectedIndex = 2 And Not (amountPaid >= propertyPrice) Then
                    MessageBox.Show("Amount is Not Equal to the Property price and the Status is Closed " & vbNewLine & "Check and make the right Change", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                ElseIf cboStatus.SelectedIndex = 0 And amountPaid = 0 Then
                    MessageBox.Show("Amount is 0 and the Status is Pending " & vbNewLine & "Check and make the right Change", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If


                Using connection As New MySqlConnection(My.Settings.conPathDb)
                    connection.Open()
                    Using transaction = connection.BeginTransaction()
                        Try
                            ' Insert sale record
                            Dim query = "INSERT INTO `sale` (`User_Id`, `Property_Id`, `customer_Id`, `Sale_Date`, `Sale_Amount`, `Sale_Status`, `Closing_Date`, `Payment_Mode`, `Payment_Reference`, `Sale_Notes`) VALUES (@UserID, (SELECT property.Property_Id FROM property WHERE property.Property_name = @PropertyName and property.Property_sale_rent = @Sale and property.Property_Price = @Price), (SELECT customer.Customer_Id FROM customer WHERE CASE WHEN customer.mName IS null or customer.mName = '' THEN CONCAT(customer.fName, ' ', customer.lName) ELSE CONCAT(customer.fName, ' ', customer.mName, ' ', customer.lName) END = @CustomerName), @Date, @Amount, @Status, @CloseDate, @PaymentMode, @PaymentReference, @Note)"
                            Using command As New MySqlCommand(query, connection, transaction)
                                command.Parameters.AddWithValue("@UserID", Mode.UserId)
                                command.Parameters.AddWithValue("@PropertyName", cboPropertyName.Text)
                                command.Parameters.AddWithValue("@Sale", txtPropertySaleRent.Text)
                                command.Parameters.AddWithValue("@Price", CDec(txtPropertyPrice.Text))
                                command.Parameters.AddWithValue("@CustomerName", cboCustomerName.Text)
                                command.Parameters.AddWithValue("@Date", dtpDate.Value)
                                command.Parameters.AddWithValue("@Amount", CDec(txtAmountPaid.Text))
                                command.Parameters.AddWithValue("@Status", cboStatus.Text)
                                command.Parameters.AddWithValue("@Note", txtSaleNote.Text)
                                command.Parameters.AddWithValue("@PaymentReference", txtPaymentReference.Text)
                                command.Parameters.AddWithValue("@PaymentMode", cboPaymentMode.Text)
                                If cboStatus.SelectedIndex = 2 Then
                                    command.Parameters.AddWithValue("@CloseDate", dtpClosedDate.Value)
                                Else
                                    command.Parameters.AddWithValue("@CloseDate", DBNull.Value)
                                End If
                                command.ExecuteNonQuery()
                            End Using

                            ' Add Transaction
                            If cboStatus.SelectedIndex = 2 Then
                                Dim getTransactionIdQuery As String = "SELECT LAST_INSERT_ID()"
                                Using getTransactionIdCommand As New MySqlCommand(getTransactionIdQuery, connection, transaction)
                                    Dim TransactionId As Integer = Convert.ToInt32(getTransactionIdCommand.ExecuteScalar())

                                    Dim TransactionQuery As String = "INSERT INTO `transaction`(`Property_Id`, `Sale_Id`, `Customer_id`, `User_Id`, `Transaction_Date`, `Transaction_type`, `Payment_mode`, `Transaction_status`, `Payment_reference`, `Transaction_amount`) VALUES ((SELECT property.Property_Id FROM property WHERE property.Property_name = @PropertyName AND property.Property_sale_rent = @Sale AND property.Property_Price = @Price LIMIT 1), @Sale_Id,(SELECT customer.Customer_Id FROM customer WHERE CASE WHEN customer.mName IS null OR customer.mName = '' THEN CONCAT(customer.fName, ' ', customer.lName) ELSE CONCAT(customer.fName, ' ', customer.mName, ' ', customer.lName) END = @CustomerName LIMIT 1), @UserID,@Transaction_Date,@Transaction_type,@Payment_mode,@Transaction_status,@Payment_reference,@Transaction_amount);"

                                    Using insertTransactionCommand As New MySqlCommand(TransactionQuery, connection, transaction)
                                        insertTransactionCommand.Parameters.AddWithValue("@UserID", Mode.UserId)
                                        insertTransactionCommand.Parameters.AddWithValue("@PropertyName", cboPropertyName.Text)
                                        insertTransactionCommand.Parameters.AddWithValue("@Sale", txtPropertySaleRent.Text)
                                        insertTransactionCommand.Parameters.AddWithValue("@Price", CDec(txtPropertyPrice.Text))
                                        insertTransactionCommand.Parameters.AddWithValue("@CustomerName", cboCustomerName.Text)
                                        insertTransactionCommand.Parameters.AddWithValue("@Sale_Id", TransactionId)
                                        insertTransactionCommand.Parameters.AddWithValue("@Transaction_Date", dtpDate.Value)
                                        insertTransactionCommand.Parameters.AddWithValue("@Transaction_status", "Completed")
                                        insertTransactionCommand.Parameters.AddWithValue("@Payment_reference", txtPaymentReference.Text)
                                        insertTransactionCommand.Parameters.AddWithValue("@Payment_mode", cboPaymentMode.Text)
                                        insertTransactionCommand.Parameters.AddWithValue("@Transaction_type", "Sale")
                                        insertTransactionCommand.Parameters.AddWithValue("@Transaction_amount", CDec(txtAmountPaid.Text))
                                        insertTransactionCommand.ExecuteNonQuery()
                                    End Using
                                End Using
                            End If

                            ' Update property availability
                            Dim Available = If(cboStatus.SelectedIndex = 3, "Available", "Not Available")
                            Dim propertyQuery = "UPDATE `property` SET `Property_availability`= @Available WHERE `Property_Id`= (SELECT property.Property_Id FROM property WHERE property.Property_name = @PropertyName and property.Property_sale_rent = @Sale and property.Property_Price = @Price);"
                            Using propertyCommand As New MySqlCommand(propertyQuery, connection, transaction)
                                propertyCommand.Parameters.AddWithValue("@Available", Available)
                                propertyCommand.Parameters.AddWithValue("@PropertyName", cboPropertyName.Text)
                                propertyCommand.Parameters.AddWithValue("@Sale", txtPropertySaleRent.Text)
                                propertyCommand.Parameters.AddWithValue("@Price", CDec(txtPropertyPrice.Text))
                                propertyCommand.ExecuteNonQuery()
                            End Using

                            ' Commit transaction
                            transaction.Commit()

                            MessageBox.Show("Information Saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            query = "SELECT s.sale_Id, p.Property_name, CASE WHEN c.mName IS NULL OR c.mName = '' THEN CONCAT(c.fName, ' ', c.lName) ELSE CONCAT(c.fName, ' ', c.mName, ' ', c.lName) END AS Customer_Name,  p.Property_sale_rent AS 'Sale Or Rent', s.Sale_Amount, p.Property_Price, s.Payment_Mode, s.Sale_Status, s.sale_Date, s.Closing_Date, s.Payment_reference, s.Sale_Notes FROM g3subvb.sale AS s  JOIN g3subvb.property AS p ON s.Property_Id = p.Property_Id  JOIN g3subvb.customer AS c ON s.Customer_id = c.Customer_id;"
                            loadData(query)

                        Catch ex As Exception
                            transaction.Rollback()
                            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try
                    End Using
                End Using


            ElseIf saleOrTrans = 1 Then



                If cboPropertyName.SelectedIndex = -1 Or txtPropertyPrice.Text = "" Or txtPropertySaleRent.Text = "" Then
                    MessageBox.Show("Select the Property Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                If cboCustomerName.SelectedIndex = -1 Then
                    MessageBox.Show("Make sure to fill in the Customer Details before progressing here" & vbNewLine & "Select the Customer Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                If cboPaymentMode.SelectedIndex = -1 Then
                    MessageBox.Show("Select the Mode Of Payment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                If txtAmountPaid.Text.Trim.Length = 0 Then
                    MessageBox.Show("Enter the Amount Paid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                If cboStatus.SelectedIndex = -1 Then
                    MessageBox.Show("Select the Status", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                If txtPaymentReference.Text.Trim.Length = 0 Then
                    MessageBox.Show("Enter payment refercene", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                If cboTransactionType.SelectedIndex = -1 Then
                    MessageBox.Show("Select the Transaction Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                Dim propertyPrice As Decimal = Decimal.Parse(txtPropertyPrice.Text)
                Dim amountPaid As Decimal = Decimal.Parse(txtAmountPaid.Text)

                If propertyPrice < amountPaid Then
                    MessageBox.Show("Your Enter more then Accepted Amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                If cboTransactionType.SelectedIndex = 0 Then
                    MessageBox.Show("Refund Must be 10% off", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    If txtPropertyPrice.Text.Length > 0 Then
                        txtAmountPaid.Text = (CDec(txtPropertyPrice.Text) / 100) * 90
                    Else
                        MessageBox.Show("Select the Property Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If

                If cboTransactionType.SelectedIndex = 1 AndAlso (amountPaid = propertyPrice) Then
                    MessageBox.Show("Adjustment must not be paid fully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                If cboTransactionType.SelectedIndex = 2 Then
                    MessageBox.Show("Enter Transaction type 'Sale' at Sale Section", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If


                Using connection As New MySqlConnection(My.Settings.conPathDb)
                        connection.Open()
                        Try
                            ' Insert sale record
                            Dim query = "INSERT INTO `transaction`(`Property_Id`, `Sale_Id`, `Customer_id`, `User_Id`, `Transaction_Date`, `Transaction_type`, `Payment_mode`, `Transaction_status`, `Payment_reference`, `Transaction_amount`) VALUES ((SELECT property.Property_Id FROM property WHERE property.Property_name = @PropertyName AND property.Property_sale_rent = @Sale AND property.Property_Price = @Price LIMIT 1), NULL,(SELECT customer.Customer_Id FROM customer WHERE CASE WHEN customer.mName IS null OR customer.mName = '' THEN CONCAT(customer.fName, ' ', customer.lName) ELSE CONCAT(customer.fName, ' ', customer.mName, ' ', customer.lName) END = @CustomerName LIMIT 1),@UserID,@Transaction_Date,@Transaction_type,@Payment_mode,@Transaction_status,@Payment_reference,@Transaction_amount);"
                            Using command As New MySqlCommand(query, connection)
                                command.Parameters.AddWithValue("@UserID", Mode.UserId)
                                command.Parameters.AddWithValue("@PropertyName", cboPropertyName.Text)
                                command.Parameters.AddWithValue("@Sale", txtPropertySaleRent.Text)
                                command.Parameters.AddWithValue("@Price", CDec(txtPropertyPrice.Text))
                                command.Parameters.AddWithValue("@CustomerName", cboCustomerName.Text)
                                command.Parameters.AddWithValue("@Transaction_Date", dtpDate.Value)
                                command.Parameters.AddWithValue("@Transaction_amount", CDec(txtAmountPaid.Text))
                                command.Parameters.AddWithValue("@Transaction_status", cboStatus.Text)
                                command.Parameters.AddWithValue("@Payment_reference", txtPaymentReference.Text)
                                command.Parameters.AddWithValue("@Payment_mode", cboPaymentMode.Text)
                                command.Parameters.AddWithValue("@Transaction_type", cboTransactionType.Text)
                            command.ExecuteNonQuery()
                        End Using
                        query = "SELECT t.Transaction_Id, p.Property_name, CASE WHEN c.mName IS NULL OR c.mName = '' THEN CONCAT(c.fName, ' ', c.lName) ELSE CONCAT(c.fName, ' ', c.mName, ' ', c.lName) END AS Customer_Name,  p.Property_sale_rent AS 'Sale Or Rent', t.Transaction_Amount, p.Property_Price, t.Payment_Mode, t.Transaction_Status, t.Transaction_Date, t.Transaction_type, t.Payment_reference FROM g3subvb.transaction AS t LEFT JOIN g3subvb.property AS p ON t.Property_Id = p.Property_Id LEFT JOIN g3subvb.customer AS c ON t.Customer_id = c.Customer_id;"
                        loadData(query)

                        MessageBox.Show("Information Saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Catch ex As Exception
                            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try
                    End Using

                Else
                    MsgBox("Error")
            End If
            clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cboPropertyName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPropertyName.SelectedIndexChanged
        Try
            con = New MySqlConnection(My.Settings.conPathDb)
            con.Open()
            Dim query As String = "select Property_sale_rent, Property_price from property where Property_name = '" & cboPropertyName.Text & "';"
            Using com As New MySqlCommand(query, con)
                Dim dr As MySqlDataReader = com.ExecuteReader
                While dr.Read
                    txtPropertySaleRent.Text = dr("Property_sale_rent")
                    txtPropertyPrice.Text = dr("Property_price")
                End While
                dr.Close()
            End Using
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtAmountPaid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAmountPaid.KeyPress
        If Char.IsControl(e.KeyChar) Then
            Return
        End If

        If e.KeyChar = "."c AndAlso txtAmountPaid.Text.Contains(".") Then
            e.Handled = True
            Return
        End If

        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "."c Then
            e.Handled = True
        End If

        If e.KeyChar = "."c Then
            Return
        End If

        Dim decimalIndex As Integer = txtAmountPaid.Text.IndexOf("."c)
        If decimalIndex <> -1 Then
            Dim digitsAfterDecimal As String = txtAmountPaid.Text.Substring(decimalIndex + 1)
            If digitsAfterDecimal.Length >= 2 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub loadData(ByVal query As String)
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
            dgvTransactionSale.DataSource = bsource
            SDA.Update(dbDataset)
            dbDataset1 = dbDataset
            checked = True
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If checked Then
            Dim DV As New DataView(dbDataset1)
            'DV.RowFilter = String.Format("fName like '%{0}%' or lName like '%{0}%' or mName like '%{0}%'", txtSearch.Text)
            DV.RowFilter = String.Format("Customer_Name like '%{0}%'", txtSearch.Text)
            dgvTransactionSale.DataSource = DV
        End If
    End Sub

    Private Sub cboStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStatus.SelectedIndexChanged
        If cboStatus.SelectedItem = "CLOSED" Then
            dtpClosedDate.Enabled = True
        Else
            dtpClosedDate.Enabled = False
        End If
    End Sub

    Private id As Integer = 0
    Private Sub dgvTransactionSale_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTransactionSale.CellClick
        clear()
        If saleOrTrans = 1 Then
            If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.dgvTransactionSale.Rows(e.RowIndex)

                id = CInt(row.Cells("Transaction_Id").Value)
                cboPropertyName.Text = row.Cells("Property_name").Value.ToString
                cboCustomerName.SelectedItem = row.Cells("Customer_Name").Value.ToString
                cboPaymentMode.SelectedItem = row.Cells("Payment_Mode").Value.ToString
                txtAmountPaid.Text = row.Cells("Transaction_Amount").Value.ToString
                cboStatus.SelectedItem = row.Cells("Transaction_Status").Value.ToString
                dtpDate.Value = row.Cells("Transaction_Date").Value.ToString
                txtPaymentReference.Text = row.Cells("Payment_reference").Value.ToString
                cboTransactionType.SelectedItem = row.Cells("Transaction_type").Value.ToString

            End If

        ElseIf saleOrTrans = 2 Then
            If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.dgvTransactionSale.Rows(e.RowIndex)

                id = CInt(row.Cells("sale_Id").Value)
                cboPropertyName.Text = row.Cells("Property_name").Value.ToString
                cboCustomerName.SelectedItem = row.Cells("Customer_Name").Value.ToString
                cboPaymentMode.SelectedItem = row.Cells("Payment_Mode").Value.ToString
                txtAmountPaid.Text = row.Cells("Sale_Amount").Value.ToString
                cboStatus.SelectedItem = row.Cells("Sale_Status").Value.ToString
                dtpDate.Value = row.Cells("sale_Date").Value.ToString
                txtPaymentReference.Text = row.Cells("Payment_reference").Value.ToString

                If row.Cells("Closing_Date").Value.ToString <> "" Then
                    dtpClosedDate.Value = row.Cells("Closing_Date").Value.ToString
                End If

                txtSaleNote.Text = row.Cells("Sale_Notes").Value.ToString
                End If
            Else
            MsgBox("Error")
        End If

    End Sub

    Private Sub txtAmountPaid_TextChanged(sender As Object, e As EventArgs) Handles txtAmountPaid.TextChanged
        If txtPropertyPrice.Text.Trim.Length > 0 Then
            If txtAmountPaid.Text.Trim.Length > 0 Then
                lblAmountMoreLess.Text = "Ghc " & Math.Round(CDec(txtPropertyPrice.Text.Trim) - CDec(txtAmountPaid.Text.Trim), 2)
            Else
                lblAmountMoreLess.Text = "Ghc -000.00"
            End If
        Else
            lblAmountMoreLess.Text = "Ghc -000.00"
        End If
        lblAmountMoreLess.Left = 694 - (lblAmountMoreLess.Width - 70)
    End Sub
End Class