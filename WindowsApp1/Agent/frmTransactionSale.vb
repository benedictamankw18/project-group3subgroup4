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
        dtpDate.MinDate = Now.AddMonths(-3)
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
        query = "SELECT s.sale_Id, p.Property_name, CASE WHEN c.mName IS NULL OR c.mName = '' THEN CONCAT(c.fName, ' ', c.lName) ELSE CONCAT(c.fName, ' ', c.mName, ' ', c.lName) END AS Customer_Name,  p.Property_sale_rent AS 'Sale Or Rent', s.Sale_Amount, p.Property_Price, s.Payment_Mode, s.Sale_Status, s.sale_Date, s.Payment_reference FROM g3subvb.sale AS s LEFT JOIN g3subvb.property AS p ON s.Property_Id = p.Property_Id LEFT JOIN g3subvb.customer AS c ON s.Customer_id = c.Customer_id;"
        loadData(query)
        saleOrTrans = 2
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
        txtSearch.Text = ""
        dtpClosedDate.Value = Now
        dtpDate.Value = dtpDate.MaxDate
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clear()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If saleOrTrans = 1 Then
            MsgBox("Transaction")
        ElseIf saleOrTrans = 2 Then
            MsgBox("Sale")
        Else
            MsgBox("Error")
        End If
        clear()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If saleOrTrans = 1 Then
            MsgBox("Transaction")
        ElseIf saleOrTrans = 2 Then
            MsgBox("Sale")
        Else
            MsgBox("Error")
        End If
        clear()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If saleOrTrans = 1 Then
            MsgBox("Transaction")
        ElseIf saleOrTrans = 2 Then
            MsgBox("Sale")
        Else
            MsgBox("Error")
        End If
            clear()
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
End Class