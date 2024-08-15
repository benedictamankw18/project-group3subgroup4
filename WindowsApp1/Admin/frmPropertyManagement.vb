Imports WindowsApp1.databaseClass
Imports MySql.Data.MySqlClient
Imports System.IO
Imports Guna.UI2.WinForms
Imports Guna.UI.WinForms

Public Class frmPropertyManagement
    Dim connection As MySqlConnection
    Public command As MySqlCommand
    Dim dbDataset1 As New DataTable
    Dim updateAction As Boolean = False
    Dim deleteAction As Boolean = False
    Dim user_id As New ArrayList
    Dim user As Integer = 0
    Dim imageBytes1 As Byte()
    Dim imageBytes2 As Byte()
    Dim imageBytes3 As Byte()
    Dim imageBytes4 As Byte()
    Dim imageBytes1Update As Byte()
    Dim imageBytes2Update As Byte()
    Dim imageBytes3Update As Byte()
    Dim imageBytes4Update As Byte()
    Dim property_id As Integer = 0
    Dim picChange(5) As Boolean

    Private Sub pboPropertyImage1_Click(sender As Object, e As EventArgs) Handles pboPropertyImage1.Click
        openDialog1.Title = "PROPERTY PICTURE"
        openDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        If openDialog1.ShowDialog() = DialogResult.OK Then
            pboPropertyImage1.Image = Image.FromFile(openDialog1.FileName)
            imageBytes1 = File.ReadAllBytes(openDialog1.FileName)
        End If
    End Sub

    Private Sub pboPropertyImage2_Click(sender As Object, e As EventArgs) Handles pboPropertyImage2.Click
        openDialog2.Title = "PROPERTY PICTURE"
        openDialog2.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        If openDialog2.ShowDialog() = DialogResult.OK Then
            pboPropertyImage2.Image = Image.FromFile(openDialog2.FileName)
            imageBytes2 = File.ReadAllBytes(openDialog2.FileName)
        End If
    End Sub

    Private Sub pboPropertyImage3_Click(sender As Object, e As EventArgs) Handles pboPropertyImage3.Click
        openDialog3.Title = "PROPERTY PICTURE"
        openDialog3.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        If openDialog3.ShowDialog() = DialogResult.OK Then
            pboPropertyImage3.Image = Image.FromFile(openDialog3.FileName)
            imageBytes3 = File.ReadAllBytes(openDialog3.FileName)
        End If
    End Sub

    Private Sub pboPropertyImage4_Click(sender As Object, e As EventArgs) Handles pboPropertyImage4.Click
        openDialog4.Title = "PROPERTY PICTURE"
        openDialog4.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        If openDialog4.ShowDialog() = DialogResult.OK Then
            pboPropertyImage4.Image = Image.FromFile(openDialog4.FileName)
            imageBytes4 = File.ReadAllBytes(openDialog4.FileName)
        End If
    End Sub

    Private Sub pboProperty1Update_Click(sender As Object, e As EventArgs) Handles pboProperty1Update.Click
        openDialog1Update.Title = "PROPERTY PICTURE"
        openDialog1Update.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        If openDialog1Update.ShowDialog() = DialogResult.OK Then
            pboProperty1Update.Image = Image.FromFile(openDialog1Update.FileName)
            imageBytes1Update = File.ReadAllBytes(openDialog1Update.FileName)
            picChange(1) = True
        End If
    End Sub

    Private Sub pboProperty4Update_Click(sender As Object, e As EventArgs) Handles pboProperty4Update.Click
        openDialog4Update.Title = "PROPERTY PICTURE"
        openDialog4Update.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        If openDialog4Update.ShowDialog() = DialogResult.OK Then
            pboProperty4Update.Image = Image.FromFile(openDialog4Update.FileName)
            imageBytes4Update = File.ReadAllBytes(openDialog4Update.FileName)
            picChange(4) = True
        End If
    End Sub

    Private Sub pboProperty2Update_Click(sender As Object, e As EventArgs) Handles pboProperty2Update.Click
        openDialog2Update.Title = "PROPERTY PICTURE"
        openDialog2Update.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        If openDialog2Update.ShowDialog() = DialogResult.OK Then
            pboProperty2Update.Image = Image.FromFile(openDialog2Update.FileName)
            imageBytes2Update = File.ReadAllBytes(openDialog2Update.FileName)
            picChange(2) = True
        End If
    End Sub

    Private Sub pboProperty3Update_Click(sender As Object, e As EventArgs) Handles pboProperty3Update.Click
        openDialog3Update.Title = "PROPERTY PICTURE"
        openDialog3Update.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        If openDialog3Update.ShowDialog() = DialogResult.OK Then
            pboProperty3Update.Image = Image.FromFile(openDialog3Update.FileName)
            imageBytes3Update = File.ReadAllBytes(openDialog3Update.FileName)
            picChange(3) = True
        End If
    End Sub

    Private Sub GunaAdvenceButton2_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clear()
    End Sub

    Private Sub clear()
        txtPropertyName.Text = ""
        txtPropertyLocaton.Text = ""
        txtPropertyPrice.Text = ""
        cboPropertyAss.SelectedIndex = -1
        cboPropertyType.SelectedIndex = -1
        nudNumberBathroom.Value = 0
        nudNumberBedroom.Value = 0
        cboPropertySaleOrRent.SelectedIndex = -1
        rtbPropertyDescription.Text = ""
        pboPropertyImage1.Image = Nothing
        pboPropertyImage2.Image = Nothing
        pboPropertyImage3.Image = Nothing
        pboPropertyImage4.Image = Nothing

    End Sub


    Private Sub clearUpdate()
        txtPropertNameUpdate.Text = ""
        txtPropertyLocationUpdate.Text = ""
        txtPropertyPriceUpdate.Text = ""
        cboPropertyAssUpdate.SelectedIndex = -1
        cboPropertyTypeUpdate.SelectedIndex = -1
        nudNumberBathroomUpdate.Value = 0
        nudNumberBedroomUpdate.Value = 0
        cboPropertySaleRent.SelectedIndex = -1
        rtbPropertyDescriptionUpdate.Text = ""
        pboProperty1Update.Image = Nothing
        pboProperty2Update.Image = Nothing
        pboProperty3Update.Image = Nothing
        pboProperty4Update.Image = Nothing

    End Sub

    Private Sub txtPropertyPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPropertyPrice.KeyPress
        If Char.IsControl(e.KeyChar) Then
            Return
        End If

        If e.KeyChar = "."c AndAlso txtPropertyPrice.Text.Contains(".") Then
            e.Handled = True
            Return
        End If

        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "."c Then
            e.Handled = True
        End If

        If e.KeyChar = "."c Then
            Return
        End If

        Dim decimalIndex As Integer = txtPropertyPrice.Text.IndexOf("."c)
        If decimalIndex <> -1 Then
            Dim digitsAfterDecimal As String = txtPropertyPrice.Text.Substring(decimalIndex + 1)
            If digitsAfterDecimal.Length >= 2 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub txtPropertyPriceUpdate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPropertyPriceUpdate.KeyPress
        If Char.IsControl(e.KeyChar) Then
            Return
        End If

        If e.KeyChar = "."c AndAlso txtPropertyPriceUpdate.Text.Contains(".") Then
            e.Handled = True
            Return
        End If

        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "."c Then
            e.Handled = True
        End If

        If e.KeyChar = "."c Then
            Return
        End If

        Dim decimalIndex As Integer = txtPropertyPriceUpdate.Text.IndexOf("."c)
        If decimalIndex <> -1 Then
            Dim digitsAfterDecimal As String = txtPropertyPriceUpdate.Text.Substring(decimalIndex + 1)
            If digitsAfterDecimal.Length >= 2 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If True Then
            If txtPropertyName.Text.Length < 3 Then
                MessageBox.Show("Enter the Property Name ", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If txtPropertyLocaton.Text.Length < 3 Then
                MessageBox.Show("Enter the Property Location ", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If nudNumberBathroom.Value = 0 Then
                MessageBox.Show("Enter the number of Bathroom", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If nudNumberBedroom.Value = 0 Then
                MessageBox.Show("Enter the number of Bedroom", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If cboPropertyAss.SelectedIndex = -1 Then
                MessageBox.Show("Select the Agents to assign this property to!", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If cboPropertyType.SelectedIndex = -1 Then
                MessageBox.Show("Select the Property Type", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If cboPropertySaleOrRent.SelectedIndex = -1 Then
                MessageBox.Show("Select Sale Or Rent", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If txtPropertyPrice.Text = Nothing Then
                MessageBox.Show("Enter the Property Price ", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If rtbPropertyDescription.Text = Nothing Then
                MessageBox.Show("Enter the Property Description ", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If pboPropertyImage1.Image Is Nothing Then
                MessageBox.Show("Click on the first picture box to select an image for the property", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If pboPropertyImage2.Image Is Nothing Then
                MessageBox.Show("Click on the second picture box to select an image for the property", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If pboPropertyImage3.Image Is Nothing Then
                MessageBox.Show("Click on the third picture box to select an image for the property", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If pboPropertyImage4.Image Is Nothing Then
                MessageBox.Show("Click on the forth picture box to select an image for the property", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If

        Dim connection As New MySqlConnection(My.Settings.conPathDb)

        Try

            Using writer As New StreamWriter(splash_screen.log.ToString, True)
                If splash_screen.lines < 1 Then
                    writer.WriteLine("DATE TIME" & vbTab & vbTab & " ACTION" & vbTab & vbTab & vbTab & vbTab & " LOCATION")
                End If
                writer.WriteLine(Date.Now & vbTab & "Adding Property to the Database" & vbTab & Me.Text)
            End Using

            connection.Open()

            Dim insertPropertyQuery As String = "INSERT INTO g3subvb.property (User_Id, Property_name, Property_location, No_of_Bathroom, No_of_Bedroom, Property_type, Property_sale_rent, Property_Price, Property_description, Property_availability) " &
        "VALUES (@UserId, @PropertyName, @PropertyLocation, @NoOfBathroom, @NoOfBedroom, @PropertyType, @PropertySaleRent, @PropertyPrice, @PropertyDescription, 'Available')"

            Using insertPropertyCommand As New MySqlCommand(insertPropertyQuery, connection)

                insertPropertyCommand.Parameters.AddWithValue("@UserId", user)
                insertPropertyCommand.Parameters.AddWithValue("@PropertyName", txtPropertyName.Text)
                insertPropertyCommand.Parameters.AddWithValue("@PropertyLocation", txtPropertyLocaton.Text)
                insertPropertyCommand.Parameters.AddWithValue("@NoOfBathroom", nudNumberBathroom.Value)
                insertPropertyCommand.Parameters.AddWithValue("@NoOfBedroom", nudNumberBedroom.Value)
                insertPropertyCommand.Parameters.AddWithValue("@PropertyType", cboPropertyType.Text)
                insertPropertyCommand.Parameters.AddWithValue("@PropertySaleRent", cboPropertySaleOrRent.Text)
                insertPropertyCommand.Parameters.AddWithValue("@PropertyPrice", txtPropertyPrice.Text)
                insertPropertyCommand.Parameters.AddWithValue("@PropertyDescription", rtbPropertyDescription.Text)

                insertPropertyCommand.ExecuteNonQuery()
            End Using

            Dim getPropertyIdQuery As String = "SELECT LAST_INSERT_ID()"
            Using getPropertyIdCommand As New MySqlCommand(getPropertyIdQuery, connection)
                Dim propertyId As Integer = Convert.ToInt32(getPropertyIdCommand.ExecuteScalar())

                Dim insertImagesQuery As String = "INSERT INTO g3subvb.property_image (Property_Id, First_image, Second_image, Third_image, Fourth_image) " &
            "VALUES (@PropertyId, @FirstImage, @SecondImage, @ThirdImage, @FourthImage)"

                Using insertImagesCommand As New MySqlCommand(insertImagesQuery, connection)
                    insertImagesCommand.Parameters.AddWithValue("@PropertyId", propertyId)
                    insertImagesCommand.Parameters.AddWithValue("@FirstImage", imageBytes1)
                    insertImagesCommand.Parameters.AddWithValue("@SecondImage", imageBytes2)
                    insertImagesCommand.Parameters.AddWithValue("@ThirdImage", imageBytes3)
                    insertImagesCommand.Parameters.AddWithValue("@FourthImage", imageBytes4)

                    insertImagesCommand.ExecuteNonQuery()
                End Using
            End Using
            clear()
            MessageBox.Show("Information Saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            connection.Close()
            loadData(dgvDelete)
            loadData(dgvUpdate)
            cboVeiwUpdateAss.SelectedIndex = 0
            cboDeletePropertyAss.SelectedIndex = 0
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Dispose()
        End Try


    End Sub

    Private Sub frmPropertyManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection = New MySqlConnection
        connection.ConnectionString = My.Settings.conPathDb
        Dim reader As MySqlDataReader

        Try
            user_id.Add("All")
            cboVeiwUpdateAss.Items.Add("ALL")
            cboDeletePropertyAss.Items.Add("ALL")
            connection.Open()
            Dim query As String = "SELECT concat(user.fName, ' ', user.lName) as fullName, login.User_Id FROM g3subvb.user LEFT JOIN g3subvb.login ON g3subvb.user.User_Id = g3subvb.login.User_Id WHERE g3subvb.login.User_role = 'Agent';"
            command = New MySqlCommand(query, connection)
            reader = command.ExecuteReader
            While reader.Read
                Dim agent = reader.GetString("fullName")
                cboPropertyAss.Items.Add(agent)
                cboVeiwUpdateAss.Items.Add(agent)
                cboPropertyAssUpdate.Items.Add(agent)
                cboDeletePropertyAss.Items.Add(agent)
                user_id.Add(reader.GetString("User_Id"))
            End While
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Dispose()
        End Try
        cboVeiwUpdateAss.SelectedIndex = 0
        cboDeletePropertyAss.SelectedIndex = 0
        loadData(dgvDelete)
        loadData(dgvUpdate)
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If updateAction Then

            If txtPropertNameUpdate.Text.Length < 3 Then
                MessageBox.Show("Enter the Property Name ", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If txtPropertyLocationUpdate.Text.Length < 3 Then
                MessageBox.Show("Enter the Property Location ", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If cboPropertyTypeUpdate.SelectedIndex = -1 Then
                MessageBox.Show("Select the Property Type", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If cboPropertySaleRent.SelectedIndex = -1 Then
                MessageBox.Show("Select Sale Or Rent", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If txtPropertyPriceUpdate.Text = Nothing Then
                MessageBox.Show("Enter the Property Price ", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If rtbPropertyDescriptionUpdate.Text = Nothing Then
                MessageBox.Show("Enter the Property Description ", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If pboProperty1Update.Image Is Nothing Then
                MessageBox.Show("Click on the first picture box to select an image for the property", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If pboProperty2Update.Image Is Nothing Then
                MessageBox.Show("Click on the second picture box to select an image for the property", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If pboProperty3Update.Image Is Nothing Then
                MessageBox.Show("Click on the third picture box to select an image for the property", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If pboProperty4Update.Image Is Nothing Then
                MessageBox.Show("Click on the forth picture box to select an image for the property", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If nudNumberBathroomUpdate.Value = 0 Then
                MessageBox.Show("Enter the number of Bathroom", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If nudNumberBedroomUpdate.Value = 0 Then
                MessageBox.Show("Enter the number of Bedroom", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If cboPropertyAssUpdate.SelectedIndex = -1 Then
                MessageBox.Show("Select the Agents to assign this property to!", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                            writer.WriteLine(Date.Now & vbTab & "Upated a Property from the Database" & vbTab & Me.Text)
                        End Using

                        connection.Open()
                        Dim query As String = "UPDATE g3subvb.property SET User_Id = @UserId, Property_name = @PropertyName, Property_location = @PropertyLocation, No_of_Bathroom = @NoOfBathroom, No_of_Bedroom = @NoOfBedroom, Property_type = @PropertyType, Property_sale_rent = @PropertySaleRent, Property_Price = @PropertyPrice, Property_description = @PropertyDescription WHERE Property_Id = @PropertyId;"

                        Using updateCommand As New MySqlCommand(query, connection)
                            updateCommand.Parameters.AddWithValue("@UserId", user)
                            updateCommand.Parameters.AddWithValue("@PropertyName", txtPropertNameUpdate.Text)
                            updateCommand.Parameters.AddWithValue("@PropertyLocation", txtPropertyLocationUpdate.Text)
                            updateCommand.Parameters.AddWithValue("@NoOfBathroom", CInt(nudNumberBathroomUpdate.Value))
                            updateCommand.Parameters.AddWithValue("@NoOfBedroom", CInt(nudNumberBedroomUpdate.Value))
                            updateCommand.Parameters.AddWithValue("@PropertyType", cboPropertyTypeUpdate.Text)
                            updateCommand.Parameters.AddWithValue("@PropertySaleRent", cboPropertySaleRent.Text)
                            updateCommand.Parameters.AddWithValue("@PropertyPrice", CDec(txtPropertyPriceUpdate.Text))
                            updateCommand.Parameters.AddWithValue("@PropertyDescription", rtbPropertyDescriptionUpdate.Text)
                            updateCommand.Parameters.AddWithValue("@PropertyId", CInt(property_id))

                            updateCommand.ExecuteNonQuery()
                        End Using
                        Dim checkQuery As String = "select * from g3subvb.property_image where Property_Id = '" & property_id & "';"
                        Dim checkCommand As New MySqlCommand(checkQuery, connection)
                        Dim reader As MySqlDataReader = checkCommand.ExecuteReader
                        Dim count As Integer = 0
                        While reader.Read
                            count += 1
                        End While
                        reader.Close()

                        If count > 0 Then
                            Dim updateImageQuery As String = "UPDATE g3subvb.property_image SET {0} = @Image WHERE Property_Id = @PropertyId;"
                            If picChange(1) Then
                                Using updateImagesCommand As New MySqlCommand(String.Format(updateImageQuery, "First_image"), connection)
                                    updateImagesCommand.Parameters.AddWithValue("@PropertyId", CInt(property_id))
                                    updateImagesCommand.Parameters.AddWithValue("@Image", imageBytes1Update)
                                    updateImagesCommand.ExecuteNonQuery()
                                End Using
                            End If

                            If picChange(2) Then
                                Using updateImagesCommand As New MySqlCommand(String.Format(updateImageQuery, "Second_image"), connection)
                                    updateImagesCommand.Parameters.AddWithValue("@PropertyId", CInt(property_id))
                                    updateImagesCommand.Parameters.AddWithValue("@Image", imageBytes2Update)
                                    updateImagesCommand.ExecuteNonQuery()
                                End Using
                            End If

                            If picChange(3) Then
                                Using updateImagesCommand As New MySqlCommand(String.Format(updateImageQuery, "Third_image"), connection)
                                    updateImagesCommand.Parameters.AddWithValue("@PropertyId", CInt(property_id))
                                    updateImagesCommand.Parameters.AddWithValue("@Image", imageBytes3Update)
                                    updateImagesCommand.ExecuteNonQuery()
                                End Using
                            End If

                            If picChange(4) Then
                                Using updateImagesCommand As New MySqlCommand(String.Format(updateImageQuery, "Fourth_image"), connection)
                                    updateImagesCommand.Parameters.AddWithValue("@PropertyId", CInt(property_id))
                                    updateImagesCommand.Parameters.AddWithValue("@Image", imageBytes4Update)
                                    updateImagesCommand.ExecuteNonQuery()
                                End Using
                            End If
                        Else
                            If picChange(1) Or Not (imageBytes1Update Is Nothing) Then
                                If picChange(2) Or Not (imageBytes2Update Is Nothing) Then
                                    If picChange(3) Or Not (imageBytes3Update Is Nothing) Then
                                        If picChange(4) Or Not (imageBytes4Update Is Nothing) Then

                                            Dim insertImagesQuery As String = "INSERT INTO g3subvb.property_image (Property_Id, First_image, Second_image, Third_image, Fourth_image) " &
                                             "VALUES (@PropertyId, @FirstImage, @SecondImage, @ThirdImage, @FourthImage)"

                                            Using insertImagesCommand As New MySqlCommand(insertImagesQuery, connection)
                                                insertImagesCommand.Parameters.AddWithValue("@PropertyId", property_id)
                                                insertImagesCommand.Parameters.AddWithValue("@FirstImage", imageBytes1Update)
                                                insertImagesCommand.Parameters.AddWithValue("@SecondImage", imageBytes2Update)
                                                insertImagesCommand.Parameters.AddWithValue("@ThirdImage", imageBytes3Update)
                                                insertImagesCommand.Parameters.AddWithValue("@FourthImage", imageBytes4Update)

                                                insertImagesCommand.ExecuteNonQuery()
                                            End Using
                                        Else
                                            MessageBox.Show("Click on the Fourth Picturebox to select the Image", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                        End If
                                    Else
                                        MessageBox.Show("Click on the Third Picturebox to select the Image", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                    End If
                                Else
                                    MessageBox.Show("Click on the Second Picturebox to select the Image", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                End If
                            Else
                                MessageBox.Show("Click on the First Picturebox to select the Image", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            End If

                        End If

                        MessageBox.Show("Data is Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Finally
                        connection.Dispose()
                    End Try
                End Using
                clearUpdate()
                loadData(dgvDelete)
                loadData(dgvUpdate)
                cboVeiwUpdateAss.SelectedIndex = 0
                cboDeletePropertyAss.SelectedIndex = 0
            End If

        End If

    End Sub

    Private Sub dvgUpdate_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUpdate.CellClick
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            updateAction = True
            Dim row As DataGridViewRow
            row = Me.dgvUpdate.Rows(e.RowIndex)

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

            cboPropertyAssUpdate.SelectedIndex = c
            txtPropertNameUpdate.Text = row.Cells("Property_name").Value.ToString
            property_id = row.Cells("Property_Id").Value.ToString
            txtPropertyLocationUpdate.Text = row.Cells("Property_location").Value.ToString
            nudNumberBathroomUpdate.Value = row.Cells("No_of_Bathroom").Value.ToString
            nudNumberBedroomUpdate.Value = row.Cells("No_of_Bedroom").Value.ToString
            cboPropertyTypeUpdate.Text = row.Cells("Property_type").Value.ToString
            cboPropertySaleRent.Text = row.Cells("Property_sale_rent").Value.ToString
            txtPropertyPriceUpdate.Text = row.Cells("Property_Price").Value.ToString
            rtbPropertyDescriptionUpdate.Text = row.Cells("Property_description").Value.ToString

            If Not (row.Cells("First_image").Value Is DBNull.Value) Then
                Dim imageData() As Byte = DirectCast(row.Cells("First_image").Value, Byte())

                Using ms As New MemoryStream(imageData)
                    pboProperty1Update.Image = Image.FromStream(ms)
                End Using
            Else
                pboProperty1Update.Image = Nothing
            End If

            If Not (row.Cells("Second_image").Value Is DBNull.Value) Then
                Dim imageData() As Byte = DirectCast(row.Cells("Second_image").Value, Byte())

                Using ms As New MemoryStream(imageData)
                    pboProperty2Update.Image = Image.FromStream(ms)
                End Using
            Else
                pboProperty2Update.Image = Nothing
            End If

            If Not (row.Cells("Third_image").Value Is DBNull.Value) Then
                Dim imageData() As Byte = DirectCast(row.Cells("Third_image").Value, Byte())

                Using ms As New MemoryStream(imageData)
                    pboProperty3Update.Image = Image.FromStream(ms)
                End Using
            Else
                pboProperty3Update.Image = Nothing
            End If
            If Not (row.Cells("Fourth_image").Value Is DBNull.Value) Then
                Dim imageData() As Byte = DirectCast(row.Cells("Fourth_image").Value, Byte())

                Using ms As New MemoryStream(imageData)
                    pboProperty4Update.Image = Image.FromStream(ms)
                End Using
            Else
                pboProperty4Update.Image = Nothing
            End If

        End If
    End Sub

    Private Sub cboPropertyAss_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPropertyAss.SelectedIndexChanged
        If cboPropertyAss.SelectedIndex >= 0 Then
            user = CInt(user_id(cboPropertyAss.SelectedIndex + 1))
        End If
    End Sub

    Private Sub loadData(ByVal dataGridView As DataGridView)
        Dim SDA As New MySqlDataAdapter
        Dim bsource As New BindingSource
        Dim dbDataset As New DataTable


        connection = New MySqlConnection(My.Settings.conPathDb)

        Try
            connection.Open()

            Dim query As String = "SELECT property.Property_Id, property.User_Id, property.Property_name, property.Property_location, property.No_of_Bathroom, property.No_of_Bedroom, property.Property_type, property.Property_sale_rent, property.Property_Price, property.Property_description, property.Property_availability, property_image.First_image, property_image.Second_image, property_image.Third_image, property_image.Fourth_image FROM g3subvb.property LEFT JOIN g3subvb.property_image on property.Property_Id = property_image.Property_Id; "
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

    Private Sub btnDeleteAll_Click(sender As Object, e As EventArgs) Handles btnDeleteAll.Click
        Dim deleteMessage As DialogResult = MessageBox.Show("Are you sure you want to delete all the data", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)

        If deleteMessage = DialogResult.Yes Then
            connection = New MySqlConnection(My.Settings.conPathDb)
            Try

                Using writer As New StreamWriter(splash_screen.log.ToString, True)
                    If splash_screen.lines < 1 Then
                        writer.WriteLine("DATE TIME" & vbTab & vbTab & " ACTION" & vbTab & vbTab & vbTab & vbTab & " LOCATION")
                    End If
                    writer.WriteLine(Date.Now & vbTab & "Deleted All Property from the Database" & vbTab & Me.Text)
                End Using

                connection.Open()

                Dim query As String = "Delete from g3subvb.property;"
                Dim deleteAllCommand As New MySqlCommand(query, connection)
                Dim readerAll As MySqlDataReader = deleteAllCommand.ExecuteReader
                readerAll.Close()

                Dim queryImage As String = "Delete from g3subvb.property_image;"
                Dim deleteAllImageCommand As New MySqlCommand(queryImage, connection)
                Dim readerImageAll As MySqlDataReader = deleteAllImageCommand.ExecuteReader
                readerImageAll.Close()

                MessageBox.Show("All Data Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                connection.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                connection.Dispose()
            End Try

            loadData(dgvDelete)
            loadData(dgvUpdate)
            cboVeiwUpdateAss.SelectedIndex = 0
            cboDeletePropertyAss.SelectedIndex = 0
        End If


    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If deleteAction Then
            Dim deleteMessage As DialogResult = MessageBox.Show("Are you sure you want to delete the data", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)

            If deleteMessage = DialogResult.Yes Then
                connection = New MySqlConnection(My.Settings.conPathDb)


                Try

                    Using writer As New StreamWriter(splash_screen.log.ToString, True)
                        If splash_screen.lines < 1 Then
                            writer.WriteLine("DATE TIME" & vbTab & vbTab & " ACTION" & vbTab & vbTab & vbTab & vbTab & " LOCATION")
                        End If
                        writer.WriteLine(Date.Now & vbTab & "Deleted a Property from the Database" & vbTab & Me.Text)
                    End Using

                    connection.Open()

                    Dim query As String = "Delete from g3subvb.property where Property_Id = " & property_id & ";"
                    Dim deletePropertyCommand As New MySqlCommand(query, connection)
                    Dim readerProperty As MySqlDataReader = deletePropertyCommand.ExecuteReader
                    readerProperty.Close()

                    Dim deleteImagesQuery As String = "Delete from g3subvb.property_image where Property_Id = " & property_id
                    Dim deleteImagesCommand As New MySqlCommand(deleteImagesQuery, connection)
                    Dim readerImagedel As MySqlDataReader = deleteImagesCommand.ExecuteReader
                    readerImagedel.Close()

                    Dim transactionQuery As String = "Delete from g3subvb.transaction where Property_Id = " & property_id
                    Dim transactionCommand As New MySqlCommand(transactionQuery, connection)
                    Dim transactionReader As MySqlDataReader = transactionCommand.ExecuteReader
                    transactionReader.Close()

                    Dim saleQuery As String = "Delete from g3subvb.sale where Property_Id = " & property_id
                    Dim saleCommand As New MySqlCommand(saleQuery, connection)
                    Dim saleReader As MySqlDataReader = saleCommand.ExecuteReader
                    saleReader.Close()

                    Dim maintenanceQuery As String = "Delete from g3subvb.maintenance where Property_Id = " & property_id
                    Dim maintenanceCommand As New MySqlCommand(maintenanceQuery, connection)
                    Dim maintenanceReader As MySqlDataReader = maintenanceCommand.ExecuteReader
                    maintenanceReader.Close()

                    Dim ownerQuery As String = "Delete from g3subvb.ownership where Property_Id = " & property_id
                    Dim ownerCommand As New MySqlCommand(ownerQuery, connection)
                    Dim ownerReader As MySqlDataReader = ownerCommand.ExecuteReader
                    ownerReader.Close()

                    Dim tenantQuery As String = "Delete from g3subvb.tenant where Property_Id = " & property_id
                    Dim tenantCommand As New MySqlCommand(tenantQuery, connection)
                    Dim tenantReader As MySqlDataReader = tenantCommand.ExecuteReader
                    tenantReader.Close()

                    MessageBox.Show("Data Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    connection.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    connection.Dispose()
                End Try
                loadData(dgvDelete)
                loadData(dgvUpdate)
                cboVeiwUpdateAss.SelectedIndex = 0
                cboDeletePropertyAss.SelectedIndex = 0
            End If
        Else
            MessageBox.Show("Select the data you want to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub dgvDelete_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDelete.CellClick
        If e.RowIndex >= 0 Then
            deleteAction = True
            Dim row As New DataGridViewRow
            row = Me.dgvDelete.Rows(e.RowIndex)
            property_id = CInt(row.Cells("Property_Id").Value)
        End If
    End Sub

    Private Sub cboDeletePropertyAss_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDeletePropertyAss.SelectedIndexChanged
        Dim DV As New DataView(dbDataset1)
        Dim selectView As Integer = 0
        If cboDeletePropertyAss.SelectedIndex >= 1 Then
            selectView = CInt(user_id(cboDeletePropertyAss.SelectedIndex))
            DV.RowFilter = $"User_Id = {selectView}"
            dgvDelete.DataSource = DV
        Else
            loadData(dgvDelete)
        End If

    End Sub

    Private Sub cboVeiwUpdateAss_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboVeiwUpdateAss.SelectedIndexChanged
        Dim DV As New DataView(dbDataset1)
        Dim selectView As Integer = 0
        If cboVeiwUpdateAss.SelectedIndex >= 1 Then
            selectView = CInt(user_id(cboVeiwUpdateAss.SelectedIndex))
            DV.RowFilter = $"User_Id = {selectView}"
            dgvUpdate.DataSource = DV
        Else
            loadData(dgvUpdate)
        End If
    End Sub

    Private Sub cboPropertyAssUpdate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPropertyAssUpdate.SelectedIndexChanged
        If cboPropertyAssUpdate.SelectedIndex >= 0 Then
            user = CInt(user_id(cboPropertyAssUpdate.SelectedIndex + 1))
        End If
    End Sub
End Class