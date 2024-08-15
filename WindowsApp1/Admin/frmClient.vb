Imports MySql.Data.MySqlClient
Imports System.IO

Public Class frmClient
    Dim arrCheckValidation() As Boolean = {False, False, False, False, False, False}
    Dim Action As Boolean = False
    Dim connection As MySqlConnection
    Public command As MySqlCommand
    Dim dbDataset1 As New DataTable
    Dim client_id As Integer = 0
    Dim rowClicked As Boolean = False


    Private Sub txtClientName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtClientName.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> vbBack AndAlso e.KeyChar <> " "c Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtClientContact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtClientContact.KeyPress
        If Asc(e.KeyChar) <> 8 AndAlso Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If Not arrCheckValidation(0) Then
            MessageBox.Show("Enter the Client's name", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Not arrCheckValidation(1) Then
            MessageBox.Show("Enter the Client's type", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Not arrCheckValidation(2) Then
            MessageBox.Show("Enter the Client's contact", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Not arrCheckValidation(3) Then
            MessageBox.Show("Enter the Client's Agreement", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Not arrCheckValidation(4) Then
            MessageBox.Show("Enter the Client's Address", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Not arrCheckValidation(5) Then
            MessageBox.Show("Enter the Client's Notes", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim connection As New MySqlConnection(My.Settings.conPathDb)

        Try


            Using writer As New StreamWriter(splash_screen.log.ToString, True)
                If splash_screen.lines < 1 Then
                    writer.WriteLine("DATE TIME" & vbTab & vbTab & " ACTION" & vbTab & vbTab & vbTab & vbTab & " LOCATION")
                End If
                writer.WriteLine(Date.Now & vbTab & "Adding  a Client to the Database" & vbTab & Me.Text)
            End Using


            connection.Open()
            Dim query As String = "INSERT INTO `client` (`Client_Name`, `Client_Type`, `Client_Contact`, `Client_Address`, `Client_Agreement`, `Client_Notes`) VALUES (@Client_Name, @Client_Type, @Client_Contact, @Client_Address, @Client_Agreement, @Client_Notes);"

            Using command As New MySqlCommand(query, connection)

                command.Parameters.AddWithValue("@Client_Name", txtClientName.Text)
                command.Parameters.AddWithValue("@Client_Type", txtClientType.Text)
                command.Parameters.AddWithValue("@Client_Contact", "+233" & txtClientContact.Text.Substring(2))
                command.Parameters.AddWithValue("@Client_Address", txtClientAddress.Text)
                command.Parameters.AddWithValue("@Client_Agreement", txtClientAgreement.Text)
                command.Parameters.AddWithValue("@Client_Notes", rtbClientNote.Text)

                command.ExecuteNonQuery()
            End Using


            clear()
            MessageBox.Show("Information Saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            connection.Close()
            loadData(dgvClientManagement)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Dispose()
        End Try

    End Sub


    Private Sub loadData(ByVal dataGridView As DataGridView)
        Dim SDA As New MySqlDataAdapter
        Dim bsource As New BindingSource
        Dim dbDataset As New DataTable


        connection = New MySqlConnection(My.Settings.conPathDb)

        Try
            connection.Open()

            Dim query As String = "SELECT * FROM g3subvb.`client` "
            Using command = New MySqlCommand(query, connection)
                SDA.SelectCommand = command
                SDA.Fill(dbDataset)
                bsource.DataSource = dbDataset
                dataGridView.DataSource = bsource
                SDA.Update(dbDataset)
            End Using


            If dataGridView.Columns.Count > 0 Then
                dataGridView.Columns(1).Width = 160
                dataGridView.Columns(3).Width = 160
                dataGridView.Columns(4).Width = 160
                dataGridView.Columns(5).Width = 160
                dataGridView.Columns(6).Width = 200
            End If

            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        dbDataset1 = dbDataset

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If rowClicked Then

            If Not arrCheckValidation(0) Then
                MessageBox.Show("Enter the Client's name", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If Not arrCheckValidation(1) Then
                MessageBox.Show("Enter the Client's type", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If Not arrCheckValidation(2) Then
                MessageBox.Show("Enter the Client's contact", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If Not arrCheckValidation(3) Then
                MessageBox.Show("Enter the Client's Agreement", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If Not arrCheckValidation(4) Then
                MessageBox.Show("Enter the Client's Address", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If Not arrCheckValidation(5) Then
                MessageBox.Show("Enter the Client's Notes", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If


            Dim updateMessage As DialogResult = MessageBox.Show("Are you sure you want to update the data?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)

            If updateMessage = DialogResult.Yes Then
                Dim connectionString As String = My.Settings.conPathDb
                Using connection As New MySqlConnection(connectionString)
                    Try
                        Using writer As New StreamWriter(splash_screen.log.ToString, True)
                            If splash_screen.lines < 1 Then
                                writer.WriteLine("DATE TIME" & vbTab & vbTab & " ACTION" & vbTab & vbTab & vbTab & vbTab & " LOCATION")
                            End If
                            writer.WriteLine(Date.Now & vbTab & "Updated a Client from the Database" & vbTab & Me.Text)
                        End Using

                        connection.Open()

                        Dim query As String = "UPDATE g3subvb.client SET client.Client_Name = @Client_Name, client.Client_Type = @Client_Type, client.Client_Contact = @Client_Contact, client.Client_Address = @Client_Address, client.Client_Agreement = @Client_Agreement, client.Client_Notes = @Client_Notes WHERE Client_Id = @Client_Id;"

                        Using updateCommand As New MySqlCommand(query, connection)
                            updateCommand.Parameters.AddWithValue("@Client_Name", txtClientName.Text)
                            updateCommand.Parameters.AddWithValue("@Client_Type", txtClientType.Text)
                            updateCommand.Parameters.AddWithValue("@Client_Contact", "+233" & txtClientContact.Text.Substring(2))
                            updateCommand.Parameters.AddWithValue("@Client_Address", txtClientAddress.Text)
                            updateCommand.Parameters.AddWithValue("@Client_Agreement", txtClientAgreement.Text)
                            updateCommand.Parameters.AddWithValue("@Client_Notes", rtbClientNote.Text)
                            updateCommand.Parameters.AddWithValue("@Client_Id", client_id)
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
                loadData(dgvClientManagement)
            End If

        End If


    End Sub



    Private Sub txtClientName_TextChanged(sender As Object, e As EventArgs) Handles txtClientName.TextChanged
        If txtClientName.Text.Length >= 3 Then
            arrCheckValidation(0) = True
        Else
            arrCheckValidation(0) = False
        End If
    End Sub

    Private Sub txtClientType_TextChanged(sender As Object, e As EventArgs) Handles txtClientType.TextChanged
        If txtClientType.Text.Length >= 3 Then
            arrCheckValidation(1) = True
        Else
            arrCheckValidation(1) = False
        End If
    End Sub

    Private Sub txtClientContact_TextChanged(sender As Object, e As EventArgs) Handles txtClientContact.TextChanged
        If txtClientContact.Text.Length = 10 Then
            arrCheckValidation(2) = True
        Else
            arrCheckValidation(2) = False
        End If
    End Sub

    Private Sub txtClientAgreement_TextChanged(sender As Object, e As EventArgs) Handles txtClientAgreement.TextChanged
        If txtClientAgreement.Text.Length >= 3 Then
            arrCheckValidation(3) = True
        Else
            arrCheckValidation(3) = False
        End If
    End Sub

    Private Sub txtClientAddress_TextChanged(sender As Object, e As EventArgs) Handles txtClientAddress.TextChanged
        If txtClientAddress.Text.Length >= 3 Then
            arrCheckValidation(4) = True
        Else
            arrCheckValidation(4) = False
        End If
    End Sub

    Private Sub txtClientNote_TextChanged(sender As Object, e As EventArgs) Handles rtbClientNote.TextChanged
        If rtbClientNote.Text.Length >= 3 Then
            arrCheckValidation(5) = True
        Else
            arrCheckValidation(5) = False
        End If
    End Sub

    Private Sub frmClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData(dgvClientManagement)
    End Sub

    Private Sub clear()
        txtClientAddress.Clear()
        txtClientAgreement.Clear()
        txtClientContact.Clear()
        txtClientName.Clear()
        txtClientType.Clear()
        rtbClientNote.Clear()
        rowClicked = False
        client_id = 0
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clear()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If rowClicked Then
            Dim deleteMessage As DialogResult = MessageBox.Show("Are you sure you want to delete the data", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)

            If deleteMessage = DialogResult.Yes Then
                connection = New MySqlConnection(My.Settings.conPathDb)

                Try

                    Using writer As New StreamWriter(splash_screen.log.ToString, True)
                        If splash_screen.lines < 1 Then
                            writer.WriteLine("DATE TIME" & vbTab & vbTab & " ACTION" & vbTab & vbTab & vbTab & vbTab & " LOCATION")
                        End If
                        writer.WriteLine(Date.Now & vbTab & "Deleted a Client from the Database" & vbTab & Me.Text)
                    End Using

                    connection.Open()

                    Dim query As String = "Delete from g3subvb.client where Client_Id = " & client_id & ";"
                    Dim deleteClientCommand As New MySqlCommand(query, connection)
                    Dim reader As MySqlDataReader = deleteClientCommand.ExecuteReader
                    reader.Close()

                    MessageBox.Show("Data Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    connection.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    connection.Dispose()
                End Try
                loadData(dgvClientManagement)
                clear()
            End If
        Else
            MessageBox.Show("Select the data you want to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub



    Private Sub dgvClientManagement_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientManagement.CellClick
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.dgvClientManagement.Rows(e.RowIndex)

            client_id = CInt(row.Cells("Client_Id").Value)
            txtClientName.Text = row.Cells("Client_Name").Value.ToString
            txtClientAddress.Text = row.Cells("Client_Address").Value.ToString
            txtClientAgreement.Text = row.Cells("Client_Agreement").Value.ToString
            txtClientContact.Text = "0" & row.Cells("Client_Contact").Value.ToString.Substring(4)
            txtClientType.Text = row.Cells("Client_Type").Value.ToString
            rtbClientNote.Text = row.Cells("Client_Notes").Value.ToString
            rowClicked = True

        End If
    End Sub
End Class