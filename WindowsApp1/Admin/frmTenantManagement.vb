Imports MySql.Data.MySqlClient


Public Class frmTenantManagement
    Dim connection As MySqlConnection
    Public command As MySqlCommand
    Dim user_id As New ArrayList
    Dim dbDataset1 As New DataTable

    Private Sub frmTenantManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        connection = New MySqlConnection
        connection.ConnectionString = My.Settings.conPathDb
        Dim reader As MySqlDataReader

        Try
            user_id.Add("All")
            cboViewPropertyAS.Items.Add("ALL")
            connection.Open()
            Dim query As String = "SELECT concat(user.fName, ' ', user.lName) as fullName, login.User_Id FROM g3subvb.user LEFT JOIN g3subvb.login ON g3subvb.user.User_Id = g3subvb.login.User_Id WHERE g3subvb.login.User_role = 'Agent';"
            command = New MySqlCommand(query, connection)
            reader = command.ExecuteReader
            While reader.Read
                Dim agent = reader.GetString("fullName")
                cboPropertyAss.Items.Add(agent)
                cboViewPropertyAS.Items.Add(agent)
                user_id.Add(reader.GetString("User_Id"))
            End While
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Dispose()
        End Try
        cboViewPropertyAS.SelectedIndex = 0
        loadData(dgvTenant)

    End Sub


    Private Sub loadData(ByVal dataGridView As DataGridView)
        Dim SDA As New MySqlDataAdapter
        Dim bsource As New BindingSource
        Dim dbDataset As New DataTable


        connection = New MySqlConnection(My.Settings.conPathDb)

        Try
            connection.Open()

            Dim query As String = "SELECT CASE WHEN customer.mName IS NULL OR customer.mName = '' THEN CONCAT(customer.fName, ' ', customer.lName) ELSE CONCAT(customer.fName, ' ', customer.mName, ' ', customer.lName) END AS Tenant_Name,  property.Property_name, property.Property_Price, property.Property_location, property.No_of_Bathroom, property.No_of_Bedroom, property.Property_type, DATEDIFF(tenant.Lease_End_Date, tenant.Lease_Start_Date) AS Tenant_Duration, property.User_Id FROM g3subvb.property RIGHT JOIN g3subvb.tenant on property.Property_Id = tenant.Property_Id RIGHT JOIN g3subvb.customer on customer.Customer_Id = tenant.Customer_id;"
            command = New MySqlCommand(query, connection)
            SDA.SelectCommand = command
            SDA.Fill(dbDataset)
            bsource.DataSource = dbDataset
            dataGridView.DataSource = bsource
            SDA.Update(dbDataset)
            dbDataset1 = dbDataset

            If dataGridView.Columns.Count > 0 Then
                dataGridView.Columns(1).Width = 160
                dataGridView.Columns(2).Width = 160
                dataGridView.Columns(3).Width = 160
                dataGridView.Columns(6).Width = 160
                dataGridView.Columns(0).Width = 160
            End If
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cboViewPropertyAS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboViewPropertyAS.SelectedIndexChanged
        Dim DV As New DataView(dbDataset1)
        Dim selectView As Integer = 0
        If cboViewPropertyAS.SelectedIndex >= 1 Then
            selectView = CInt(user_id(cboViewPropertyAS.SelectedIndex))
            DV.RowFilter = $"User_Id = {selectView}"
            dgvTenant.DataSource = DV
        Else
            loadData(dgvTenant)
        End If

    End Sub

    Private Sub dgvTenant_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTenant.CellClick
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.dgvTenant.Rows(e.RowIndex)

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

            cboPropertyAss.SelectedIndex = c
            txtTenantName.Text = row.Cells("Tenant_Name").Value.ToString
            txtPropertyName.Text = row.Cells("Property_name").Value.ToString
            txtPropertyLocation.Text = row.Cells("Property_location").Value.ToString
            nudNumberBathroom.Value = row.Cells("No_of_Bathroom").Value.ToString
            nudNumberBedroom.Value = row.Cells("No_of_Bedroom").Value.ToString
            cboPropertyType.Text = row.Cells("Property_type").Value.ToString
            txtPropertyPrice.Text = row.Cells("Property_Price").Value.ToString
            txtTenantDuration.Text = row.Cells("Tenant_Duration").Value.ToString

        End If
    End Sub
End Class