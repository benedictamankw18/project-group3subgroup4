Imports MySql.Data.MySqlClient

Public Class frmAM
    Dim con As MySqlConnection
    Dim com As MySqlCommand
    Dim dbDataset1 As New DataTable
    Dim mat_id As Integer = 0
    Dim rowClick As Boolean = False
    Dim checked As Boolean = False

    Private Sub frmAM_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            con = New MySqlConnection(My.Settings.conPathDb)
            con.Open()
            Dim query As String = "select Property_type, Property_name from property WHERE `User_Id` = " & Mode.UserId & ";"
            Using com As New MySqlCommand(query, con)
                Dim dr As MySqlDataReader = com.ExecuteReader
                While dr.Read
                    cboPropertyType.Items.Add(dr("Property_type"))
                    cboPropertyName.Items.Add(dr("Property_name"))
                End While
            End Using

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        loadData(dgvMat)
    End Sub

    Private Sub loadData(ByVal dataGridView As DataGridView)
        Dim SDA As New MySqlDataAdapter
        Dim bsource As New BindingSource
        Dim dbDataset As New DataTable


        con = New MySqlConnection(My.Settings.conPathDb)

        Try
            con.Open()

            Dim query As String = "SELECT maintenance.Mat_Id as Maintenance_ID, property.Property_name, property.Property_location, property.Property_type, maintenance.Problem_status, maintenance.Problem_Description FROM g3subvb.property RIGHT JOIN g3subvb.maintenance on property.Property_Id = maintenance.Property_Id WHERE property.`User_Id` = " & Mode.UserId & ";"
            com = New MySqlCommand(query, con)
            SDA.SelectCommand = com
            SDA.Fill(dbDataset)
            bsource.DataSource = dbDataset
            dataGridView.DataSource = bsource
            SDA.Update(dbDataset)
            dbDataset1 = dbDataset
            con.Close()

            If dataGridView.Columns.Count > 0 Then
                dataGridView.Columns(dataGridView.Columns.Count - 5).Width = 150
                dataGridView.Columns(dataGridView.Columns.Count - 4).Width = 200
                dataGridView.Columns(dataGridView.Columns.Count - 3).Width = 180
                dataGridView.Columns(dataGridView.Columns.Count - 2).Width = 150
                dataGridView.Columns(dataGridView.Columns.Count - 1).Width = 350
            End If
            checked = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvMat_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMat.CellClick
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.dgvMat.Rows(e.RowIndex)

            mat_id = CInt(row.Cells("Maintenance_ID").Value)
            cboPropertyName.Text = row.Cells("Property_name").Value.ToString
            txtPropertyLocation.Text = row.Cells("Property_location").Value.ToString
            txtPropertyType.Text = row.Cells("Property_type").Value.ToString
            cboProblemStatus.Text = row.Cells("Problem_status").Value.ToString
            rtbProblemDescription.Text = row.Cells("Problem_Description").Value.ToString
            rowClick = True

        End If
    End Sub

    Private Sub cboSProblemStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSProblemStatus.SelectedIndexChanged
        txtSearch.Text = ""
        Dim DV As New DataView(dbDataset1)
        If cboPropertyType.SelectedIndex > 0 And cboSProblemStatus.SelectedIndex > 0 Then
            DV.RowFilter = String.Format("Problem_status like '%{0}%' and Property_type like '%{1}%'", cboSProblemStatus.Text, cboPropertyType.Text)
            dgvMat.DataSource = DV
        ElseIf cboSProblemStatus.SelectedIndex > 0 Then
            DV.RowFilter = String.Format("Problem_status like '%{0}%'", cboSProblemStatus.Text)
            dgvMat.DataSource = DV
        ElseIf cboPropertyType.SelectedIndex > 0 Then
            DV.RowFilter = String.Format("Property_type like '%{0}%'", cboPropertyType.Text)
            dgvMat.DataSource = DV
        Else
            loadData(dgvMat)
        End If
    End Sub

    Private Sub cboPropertyType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPropertyType.SelectedIndexChanged
        txtSearch.Text = ""
        Dim DV As New DataView(dbDataset1)
        If cboPropertyType.SelectedIndex > 0 And cboSProblemStatus.SelectedIndex > 0 Then
            DV.RowFilter = String.Format("Problem_status like '%{0}%' and Property_type like '%{1}%'", cboSProblemStatus.Text, cboPropertyType.Text)
            dgvMat.DataSource = DV
        ElseIf cboPropertyType.SelectedIndex > 0 Then
            DV.RowFilter = String.Format("Property_type like '%{0}%'", cboPropertyType.Text)
            dgvMat.DataSource = DV
        ElseIf cboSProblemStatus.SelectedIndex > 0 Then
            DV.RowFilter = String.Format("Problem_status like '%{0}%'", cboSProblemStatus.Text)
            dgvMat.DataSource = DV
        Else
            loadData(dgvMat)
        End If
    End Sub

    Private Sub cboPropertyName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPropertyName.SelectedIndexChanged
        rtbProblemDescription.Text = ""
        cboProblemStatus.SelectedIndex = -1

        con = New MySqlConnection(My.Settings.conPathDb)

        Try
            con.Open()

            Dim query As String = "SELECT Property_location, Property_type  FROM g3subvb.property where Property_name = '" & cboPropertyName.Text & "' and  property.`User_Id` = " & Mode.UserId & ";"
            com = New MySqlCommand(query, con)
            Dim dr As MySqlDataReader = com.ExecuteReader
            While dr.Read
                txtPropertyLocation.Text = dr("Property_location").ToString
                txtPropertyType.Text = dr("Property_type").ToString
            End While
            dr.Close()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If True Then
            If cboPropertyName.SelectedIndex = -1 Then
                MessageBox.Show("Enter the Property Name ", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If txtPropertyLocation.Text.Length < 3 Then
                MessageBox.Show("Enter the Property Location ", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If txtPropertyType.Text = "" Then
                MessageBox.Show("Select the Property Type", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If cboProblemStatus.SelectedIndex = -1 Then
                MessageBox.Show("Select the Problem Status", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If rtbProblemDescription.Text = Nothing Then
                MessageBox.Show("Enter the Problem Description ", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If


        con = New MySqlConnection(My.Settings.conPathDb)

        Try
            con.Open()

            Dim searchQuery As String = "SELECT Property_Id FROM property WHERE Property_name = @PropertyName AND Property_location = @PropertyLocation AND Property_type = @PropertyType WHERE property.`User_Id` = " & Mode.UserId & ""

            Using searchCommand As New MySqlCommand(searchQuery, con)

                searchCommand.Parameters.AddWithValue("@PropertyName", cboPropertyName.Text)
                searchCommand.Parameters.AddWithValue("@PropertyLocation", txtPropertyLocation.Text)
                searchCommand.Parameters.AddWithValue("@PropertyType", txtPropertyType.Text)
                Dim reader As MySqlDataReader = searchCommand.ExecuteReader
                Dim count As Integer = 0

                While reader.Read
                    count += 1
                End While
                reader.Close()

                If count = 0 Then
                    MessageBox.Show("Check the Property Name, Location and Property type --Again" & vbNewLine & "They do exit in the database", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End Using


            Dim insertProblemQuery As String = "INSERT INTO g3subvb.maintenance ( maintenance.Property_Id, maintenance.User_Id, maintenance.Problem_status, maintenance.Problem_Description) VALUES ((SELECT Property_Id FROM property WHERE Property_name = @PropertyName AND Property_location = @PropertyLocation AND Property_type = @PropertyType), @User_Id ,@ProblemStatus, @ProblemDescription);"

            Using insertProblemCommand As New MySqlCommand(insertProblemQuery, con)

                insertProblemCommand.Parameters.AddWithValue("@PropertyName", cboPropertyName.Text)
                insertProblemCommand.Parameters.AddWithValue("@PropertyLocation", txtPropertyLocation.Text)
                insertProblemCommand.Parameters.AddWithValue("@PropertyType", txtPropertyType.Text)
                insertProblemCommand.Parameters.AddWithValue("@User_Id", Mode.UserId)
                insertProblemCommand.Parameters.AddWithValue("@ProblemStatus", cboProblemStatus.Text)
                insertProblemCommand.Parameters.AddWithValue("@ProblemDescription", rtbProblemDescription.Text)

                insertProblemCommand.ExecuteNonQuery()
            End Using

            clear()
            MessageBox.Show("Information Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            con.Close()
            loadData(dgvMat)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Dispose()
        End Try

    End Sub

    Private Sub clear()
        cboPropertyName.SelectedIndex = -1
        txtPropertyLocation.Text = ""
        txtPropertyType.Text = ""
        cboProblemStatus.SelectedIndex = -1
        rtbProblemDescription.Text = ""
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If rowClick Then
            Dim deleteMessage As DialogResult = MessageBox.Show("Are you sure you want to delete the data", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)

            If deleteMessage = DialogResult.Yes Then
                con = New MySqlConnection(My.Settings.conPathDb)

                Try

                    con.Open()

                    Dim query As String = "Delete from g3subvb.maintenance where Mat_Id = " & mat_id & ";"
                    Dim deleteMaintenanceCommand As New MySqlCommand(query, con)
                    Dim reader As MySqlDataReader = deleteMaintenanceCommand.ExecuteReader
                    reader.Close()

                    MessageBox.Show("Data Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    con.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    con.Dispose()
                End Try
                loadData(dgvMat)
                clear()
            End If
        Else
            MessageBox.Show("Select the data you want to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If rowClick Then

            If cboPropertyName.SelectedIndex = -1 Then
                MessageBox.Show("Enter the Property Name ", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If txtPropertyLocation.Text.Length < 3 Then
                MessageBox.Show("Enter the Property Location ", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If txtPropertyType.Text = "" Then
                MessageBox.Show("Type the Property Type", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If cboProblemStatus.SelectedIndex = -1 Then
                MessageBox.Show("Select the Problem Status", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If rtbProblemDescription.Text = Nothing Then
                MessageBox.Show("Enter the Problem Description ", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If


            Dim updateMessage As DialogResult = MessageBox.Show("Are you sure you want to update the data?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)

            If updateMessage = DialogResult.Yes Then
                Dim connectionString As String = My.Settings.conPathDb
                Using connection As New MySqlConnection(connectionString)
                    Try

                        connection.Open()

                        Dim searchQuery As String = "SELECT Property_Id FROM property WHERE Property_name = @PropertyName AND Property_location = @PropertyLocation AND Property_type = @PropertyType WHERE property.`User_Id` = " & Mode.UserId & ""

                        Using searchCommand As New MySqlCommand(searchQuery, connection)

                            searchCommand.Parameters.AddWithValue("@PropertyName", cboPropertyName.Text)
                            searchCommand.Parameters.AddWithValue("@PropertyLocation", txtPropertyLocation.Text)
                            searchCommand.Parameters.AddWithValue("@PropertyType", txtPropertyType.Text)
                            Dim reader As MySqlDataReader = searchCommand.ExecuteReader
                            Dim count As Integer = 0

                            While reader.Read
                                count += 1
                            End While
                            reader.Close()

                            If count = 0 Then
                                MessageBox.Show("Check the Property Name, Location and Property type --Again" & vbNewLine & "They do exit in the database", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Exit Sub
                            End If
                        End Using



                        Dim query As String = "UPDATE g3subvb.maintenance SET maintenance.Problem_status = @ProblemStatus, maintenance.Problem_Description = @ProblemDescription WHERE Mat_Id = @MatId;"

                        Using updateCommand As New MySqlCommand(query, connection)
                            updateCommand.Parameters.AddWithValue("@ProblemStatus", cboProblemStatus.Text)
                            updateCommand.Parameters.AddWithValue("@ProblemDescription", rtbProblemDescription.Text)
                            updateCommand.Parameters.AddWithValue("@MatId", CInt(mat_id))
                            updateCommand.ExecuteNonQuery()
                        End Using

                        MessageBox.Show("Data is Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Finally
                        connection.Dispose()
                    End Try
                End Using
                clear()
                loadData(dgvMat)
            End If

        End If

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If checked Then
            Dim DV As New DataView(dbDataset1)
            DV.RowFilter = String.Format("Property_name like '%{0}%' or Property_location like '%{0}%' or Property_type like '%{0}%' or Problem_status like '%{0}%' or Problem_Description like '%{0}%'", txtSearch.Text)
            dgvMat.DataSource = DV
        End If
    End Sub
End Class