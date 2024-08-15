Imports MySql.Data.MySqlClient


Public Class frmSale
    Dim connection As MySqlConnection
    Public command As MySqlCommand
    Dim dbDataset1 As New DataTable
    Dim Action As Boolean = False
    Dim user_id As New ArrayList
    Dim user As Integer = 0

    Private Sub frmSale_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

        loadData(dgvSale)
    End Sub

    Private Sub loadData(ByVal dataGridView As DataGridView)
        Dim SDA As New MySqlDataAdapter
        Dim bsource As New BindingSource
        Dim dbDataset As New DataTable


        connection = New MySqlConnection(My.Settings.conPathDb)

        Try
            connection.Open()

            Dim query As String = "SELECT sale.Sale_Id, sale.User_Id, property.Property_name, property.Property_sale_rent as `Sale or Rent`, sale.Sale_Amount, property.Property_Price, sale.Payment_Mode, sale.Sale_Status, sale.Sale_Date, sale.Closing_Date FROM g3subvb.sale LEFT JOIN g3subvb.property on sale.Property_Id = property.Property_Id;"
            command = New MySqlCommand(query, connection)
            SDA.SelectCommand = command
            SDA.Fill(dbDataset)
            bsource.DataSource = dbDataset
            dataGridView.DataSource = bsource
            SDA.Update(dbDataset)

            If dataGridView.Columns.Count > 0 Then
                dataGridView.Columns(2).Width = 200
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

    Private Sub dgvSale_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSale.CellClick
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Action = True
            Dim row As DataGridViewRow
            row = Me.dgvSale.Rows(e.RowIndex)

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
            txtSaleAmount.Text = row.Cells("Sale_Amount").Value.ToString
            txtPropertyPrice.Text = row.Cells("Property_Price").Value.ToString
            txtPaymentMode.Text = row.Cells("Payment_Mode").Value.ToString
            txtSaleStatus.Text = row.Cells("Sale_Status").Value.ToString
            txtSaleDate.Text = row.Cells("Sale_Date").Value.ToString
            txtClosedDate.Text = row.Cells("Closing_Date").Value.ToString
        End If
    End Sub

    Private Sub cboViewPropertyAss_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboViewPropertyAss.SelectedIndexChanged
        Dim DV As New DataView(dbDataset1)
        Dim selectView As Integer = 0
        If cboViewPropertyAss.SelectedIndex >= 1 Then
            selectView = CInt(user_id(cboViewPropertyAss.SelectedIndex))
            DV.RowFilter = $"User_Id = {selectView}"
            dgvSale.DataSource = DV
        Else
            loadData(dgvSale)
        End If
    End Sub
End Class