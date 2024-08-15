Imports MySql.Data.MySqlClient


Public Class frmOwner
    Dim connection As MySqlConnection
    Public command As MySqlCommand
    Dim dbDataset1 As New DataTable
    Dim user_id As New ArrayList




    Private Sub frmOwner_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        connection = New MySqlConnection
        connection.ConnectionString = My.Settings.conPathDb
        Dim reader As MySqlDataReader

        Try
            user_id.Add("All")
            cboViewOwnerAss.Items.Add("ALL")
            connection.Open()
            Dim query As String = "SELECT concat(user.fName, ' ', user.lName) as fullName, login.User_Id FROM g3subvb.user LEFT JOIN g3subvb.login ON g3subvb.user.User_Id = g3subvb.login.User_Id WHERE g3subvb.login.User_role = 'Agent';"
            command = New MySqlCommand(query, connection)
            reader = command.ExecuteReader
            While reader.Read
                Dim agent = reader.GetString("fullName")
                cboViewOwnerAss.Items.Add(agent)
                user_id.Add(reader.GetString("User_Id"))
            End While
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Dispose()
        End Try
        cboViewOwnerAss.SelectedIndex = 0


        loadData(dgvOwnership)
    End Sub


    Private Sub loadData(ByVal dataGridView As DataGridView)
        Dim SDA As New MySqlDataAdapter
        Dim bsource As New BindingSource
        Dim dbDataset As New DataTable


        connection = New MySqlConnection(My.Settings.conPathDb)

        Try
            connection.Open()

            Dim query As String = "SELECT o.Customer_id, CASE WHEN c.mName IS null or ' ' THEN concat(c.fName, ' ', c.lName) ELSE concat(c.fName, ' ',c.mName, ' ',c.lName) end as Customer_Name, GROUP_CONCAT(p.Property_name) as Property_Name, GROUP_CONCAT(p.Property_location) as Property_Location, COUNT(o.Property_Id) as No_Of_Housing, o.User_Id FROM ownership as o LEFT JOIN property as p ON o.Property_Id = p.Property_Id LEFT JOIN customer as c ON o.Customer_id = c.Customer_Id GROUP BY o.Customer_id;"
            Using command = New MySqlCommand(query, connection)
                SDA.SelectCommand = command
                SDA.Fill(dbDataset)
                bsource.DataSource = dbDataset
                dataGridView.DataSource = bsource
                SDA.Update(dbDataset)
            End Using


            If dataGridView.Columns.Count > 0 Then
                dataGridView.Columns(0).Width = 100
                dataGridView.Columns(1).Width = 160
                dataGridView.Columns(2).Width = 350
                dataGridView.Columns(3).Width = 350
                dataGridView.Columns(4).Width = 130
            End If

            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        dbDataset1 = dbDataset

    End Sub

    Private Sub cboViewOwnerAss_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboViewOwnerAss.SelectedIndexChanged
        Dim DV As New DataView(dbDataset1)
        Dim selectView As Integer = 0
        If cboViewOwnerAss.SelectedIndex >= 1 Then
            selectView = CInt(user_id(cboViewOwnerAss.SelectedIndex))
            DV.RowFilter = $"User_Id = {selectView}"
            dgvOwnership.DataSource = DV
        Else
            loadData(dgvOwnership)
        End If

    End Sub

    Private Sub dgvOwnership_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOwnership.CellClick
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.dgvOwnership.Rows(e.RowIndex)

            txtOwnerName.Text = row.Cells("Customer_Name").Value.ToString
            nudNumberHouse.Value = CInt(row.Cells("No_Of_Housing").Value)
            rtbPropertyName.Text = row.Cells("Property_Name").Value.ToString
            rtbPropertyLocation.Text = row.Cells("Property_Location").Value.ToString

        End If
    End Sub
End Class