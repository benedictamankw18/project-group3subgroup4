Imports MySql.Data.MySqlClient

Public Class frmTransaction
    Dim connection As MySqlConnection
    Public command As MySqlCommand
    Dim dbDataset1 As New DataTable
    Dim Action As Boolean = False
    Dim user_id As New ArrayList
    Dim user As Integer = 0


    Private Sub frmTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        connection = New MySqlConnection
        connection.ConnectionString = My.Settings.conPathDb
        Dim reader As MySqlDataReader

        Try
            user_id.Add("All")
            cboViewPropertyAss.Items.Add("ALL")
            connection.Open()
            Dim query As String = "SELECT concat(user.fName, ' ', user.lName) as fullName, login.User_Id FROM g3subvb.user LEFT JOIN g3subvb.login ON g3subvb.user.User_Id = g3subvb.login.User_Id WHERE g3subvb.login.User_role = 'Agent';"
            command = New MySqlCommand(query, connection)
            reader = command.ExecuteReader
            While reader.Read
                Dim agent = reader.GetString("fullName")
                cboViewPropertyAss.Items.Add(agent)
                cboPropertyAssTo.Items.Add(agent)
                user_id.Add(reader.GetString("User_Id"))
            End While
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Dispose()
        End Try
        cboViewPropertyAss.SelectedIndex = 0

        loadData(dgvTransaction)
    End Sub


    Private Sub loadData(ByVal dataGridView As DataGridView)
        Dim SDA As New MySqlDataAdapter
        Dim bsource As New BindingSource
        Dim dbDataset As New DataTable


        connection = New MySqlConnection(My.Settings.conPathDb)

        Try
            connection.Open()

            Dim query As String = "SELECT t.Transaction_Id, t.User_Id, p.Property_name, CASE WHEN c.mName IS NULL OR c.mName = '' THEN CONCAT(c.fName, ' ', c.lName) ELSE CONCAT(c.fName, ' ', c.mName, ' ', c.lName) END AS Customer_Name,  p.Property_sale_rent AS 'Sale Or Rent', t.Transaction_Amount, p.Property_Price, t.Payment_Mode, t.Transaction_Status, t.Transaction_Date, t.Transaction_type FROM g3subvb.transaction AS t LEFT JOIN g3subvb.property AS p ON t.Property_Id = p.Property_Id LEFT JOIN g3subvb.customer AS c ON t.Customer_id = c.Customer_id;"

            command = New MySqlCommand(query, connection)
            SDA.SelectCommand = command
            SDA.Fill(dbDataset)
            bsource.DataSource = dbDataset
            dataGridView.DataSource = bsource
            SDA.Update(dbDataset)

            If dataGridView.Columns.Count > 0 Then
                dataGridView.Columns(1).Width = 70
                dataGridView.Columns(2).Width = 150
                dataGridView.Columns(3).Width = 150
                dataGridView.Columns(4).Width = 120
                dataGridView.Columns(5).Width = 120
                dataGridView.Columns(6).Width = 140
                dataGridView.Columns(7).Width = 120
            End If

            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        dbDataset1 = dbDataset

    End Sub

    Private Sub dgvTransaction_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTransaction.CellClick
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Action = True
            Dim row As DataGridViewRow
            row = Me.dgvTransaction.Rows(e.RowIndex)

            Dim Id As Integer = CInt(row.Cells("User_id").Value)
            Dim i, c, a As Integer
            Dim listUser As New ArrayList

            For a = 1 To user_id.Count - 1
                listUser.Add(user_id(a))
            Next

            c = 0

            For Each i In listUser
                If i = Id Then
                    Exit For
                End If
                c += 1
            Next

            cboPropertyAssTo.SelectedIndex = c
            txtPropertyName.Text = row.Cells("Property_name").Value.ToString
            txtSaleRent.Text = row.Cells("Sale or Rent").Value.ToString
            txtTransactionAmount.Text = row.Cells("Transaction_Amount").Value.ToString
            txtPropertyPrice.Text = row.Cells("Property_Price").Value.ToString
            txtPaymentMode.Text = row.Cells("Payment_Mode").Value.ToString
            txtTransactionStatus.Text = row.Cells("Transaction_Status").Value.ToString
            txtTransactionDate.Text = row.Cells("Transaction_Date").Value.ToString
            txtCustomerName.Text = row.Cells("Customer_Name").Value.ToString
        End If
    End Sub

    Private Sub cboViewPropertyAss_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboViewPropertyAss.SelectedIndexChanged
        Dim DV As New DataView(dbDataset1)
        Dim selectView As Integer = 0
        If cboViewPropertyAss.SelectedIndex >= 1 Then
            selectView = CInt(user_id(cboViewPropertyAss.SelectedIndex))
            DV.RowFilter = $"User_Id = {selectView}"
            dgvTransaction.DataSource = DV
        Else
            loadData(dgvTransaction)
        End If
    End Sub
End Class