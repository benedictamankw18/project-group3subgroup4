Imports WindowsApp1.Mode
Imports MySql.Data.MySqlClient
Imports System.IO


Public Class frmRent
    Dim connection As MySqlConnection
    Public command As MySqlCommand
    Dim dbDataset1 As New DataTable
    Dim user_id As New ArrayList

    Private Sub frmRent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection = New MySqlConnection
        connection.ConnectionString = My.Settings.conPathDb

        Try
            user_id.Add("All")
            connection.Open()
            Dim query As String = "SELECT concat(user.fName, ' ', user.lName) as fullName, login.User_Id FROM g3subvb.user LEFT JOIN g3subvb.login ON g3subvb.user.User_Id = g3subvb.login.User_Id WHERE g3subvb.login.User_role = 'Agent';"
            Using command = New MySqlCommand(query, connection)
                Dim reader As MySqlDataReader = command.ExecuteReader
                While reader.Read
                    Dim agent = reader.GetString("fullName")
                    cboPropertyAssTo.Items.Add(agent)
                    user_id.Add(reader.GetString("User_Id"))
                End While
                reader.Close()
            End Using

            query = "SELECT property.Property_type FROM `property`; "
            Using command = New MySqlCommand(query, connection)
                Dim reader As MySqlDataReader = command.ExecuteReader
                While reader.Read
                    Dim Property_type = reader.GetString("Property_type")
                    cboPropertyType.Items.Add(Property_type)
                End While
                reader.Close()
            End Using

            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Dispose()
        End Try
        loadData(dgvRentalManagement)
    End Sub


    Private Sub loadData(ByVal dataGridView As DataGridView)
        Dim SDA As New MySqlDataAdapter
        Dim bsource As New BindingSource
        Dim dbDataset As New DataTable


        connection = New MySqlConnection(My.Settings.conPathDb)

        Try
            connection.Open()

            Dim query As String = "SELECT property.Property_Id, property.User_Id, property.Property_name, property.Property_location, property.No_of_Bathroom, property.No_of_Bedroom, property.Property_type, property.Property_Price, property.Property_availability, property_image.First_image, property_image.Second_image, property_image.Third_image, property_image.Fourth_image FROM g3subvb.property LEFT JOIN g3subvb.property_image on property.Property_Id = property_image.Property_Id  WHERE property.Property_sale_rent = 'Rent'; "
            command = New MySqlCommand(query, connection)
            SDA.SelectCommand = command
            SDA.Fill(dbDataset)
            bsource.DataSource = dbDataset
            dataGridView.DataSource = bsource
            SDA.Update(dbDataset)

            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        dbDataset1 = dbDataset

    End Sub

    Private Sub dgvRentalManagement_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRentalManagement.CellClick
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.dgvRentalManagement.Rows(e.RowIndex)

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
            txtPropertyLocation.Text = row.Cells("Property_location").Value.ToString
            nudNumberOfBathroom.Value = row.Cells("No_of_Bathroom").Value.ToString
            nudNumberOfBedroom.Value = row.Cells("No_of_Bedroom").Value.ToString
            cboPropertyType.SelectedItem = row.Cells("Property_type").Value.ToString
            txtAvailability.Text = row.Cells("Property_availability").Value.ToString
            txtPropertyPrice.Text = row.Cells("Property_Price").Value.ToString

            If Not (row.Cells("First_image").Value Is DBNull.Value) Then
                Dim imageData() As Byte = DirectCast(row.Cells("First_image").Value, Byte())

                Using ms As New MemoryStream(imageData)
                    pboImageProperty1.Image = Image.FromStream(ms)
                End Using
            Else
                pboImageProperty1.Image = Nothing
            End If

            If Not (row.Cells("Second_image").Value Is DBNull.Value) Then
                Dim imageData() As Byte = DirectCast(row.Cells("Second_image").Value, Byte())

                Using ms As New MemoryStream(imageData)
                    pboImageProperty2.Image = Image.FromStream(ms)
                End Using
            Else
                pboImageProperty2.Image = Nothing
            End If

            If Not (row.Cells("Third_image").Value Is DBNull.Value) Then
                Dim imageData() As Byte = DirectCast(row.Cells("Third_image").Value, Byte())

                Using ms As New MemoryStream(imageData)
                    pboImageProperty3.Image = Image.FromStream(ms)
                End Using
            Else
                pboImageProperty3.Image = Nothing
            End If
            If Not (row.Cells("Fourth_image").Value Is DBNull.Value) Then
                Dim imageData() As Byte = DirectCast(row.Cells("Fourth_image").Value, Byte())

                Using ms As New MemoryStream(imageData)
                    pboImageProperty4.Image = Image.FromStream(ms)
                End Using
            Else
                pboImageProperty4.Image = Nothing
            End If

        End If
    End Sub
End Class