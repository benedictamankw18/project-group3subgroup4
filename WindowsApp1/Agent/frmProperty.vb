Imports Guna.UI2.WinForms
Imports Guna.UI.WinForms
Imports MySql.Data.MySqlClient
Imports System.IO


Public Class frmProperty
    Public Shared position As Integer = 30
    Dim dr As MySqlDataReader
    Dim con As MySqlConnection
    Dim command As MySqlCommand

    Public Sub doy()
        Dim panel As New GunaPanel With {
            .BackColor = Color.Transparent,
            .Dock = DockStyle.None,
            .BorderStyle = BorderStyle.None,
            .Height = 150,
            .Width = 1132,
            .Top = position,
            .Left = 40
        }
        Dim img As Image = Nothing
        If (dr("First_image") IsNot Nothing) Then
            Dim imageData() As Byte = DirectCast(dr("First_image"), Byte())
            Using ms As New MemoryStream(imageData)
                img = Image.FromStream(ms)
            End Using
        End If
        Dim picture As New PictureBox With {
        .Width = 150,
        .Dock = DockStyle.Left,
        .Image = img,
        .SizeMode = PictureBoxSizeMode.StretchImage,
        .Cursor = Cursors.Hand,
        .Tag = dr("property_Id")
        }

        panel.Controls.Add(picture)

        Dim productName As New Label With {
            .ForeColor = Color.Black,
            .Text = dr("Property_name"),
            .Font = New Font("Arial", 15, FontStyle.Bold),
            .AutoSize = True,
           .Left = picture.Width + 20,
        .Cursor = Cursors.Hand,
           .Top = 10
        }
        panel.Controls.Add(productName)



        Dim bed As New Label With {
            .Text = dr("No_of_Bedroom") & "-Bedroom",
            .ForeColor = Color.White,
              .Font = New Font("Arial", 12, FontStyle.Bold),
        .Cursor = Cursors.Hand,
            .Top = 5,
            .Left = 10,
            .AutoSize = True
            }


        Dim bedback As New Guna2Panel With {
  .BorderStyle = BorderStyle.FixedSingle,
  .BorderColor = Color.Black,
  .AutoSize = True,
  .Left = productName.Left + productName.Width + 20,
  .Top = 5,
  .FillColor = Color.DeepSkyBlue,
  .ForeColor = Color.White,
        .Cursor = Cursors.Hand,
  .Visible = True,
  .BorderRadius = 10,
  .Width = bed.Width + 20,
  .Height = 30,
  .BorderThickness = 0
        }

        panel.Controls.Add(bedback)

        bedback.Controls.Add(bed)


        Dim bath As New Label With {
            .Text = dr("No_of_Bathroom") & "-Bathroom",
            .ForeColor = Color.White,
              .Font = New Font("Arial", 12, FontStyle.Bold),
        .Cursor = Cursors.Hand,
            .Top = 5,
            .Left = 10,
            .AutoSize = True
            }

        Dim bathback As New Guna2Panel With {
  .BorderStyle = BorderStyle.FixedSingle,
  .BorderColor = Color.Black,
  .AutoSize = True,
  .Left = bedback.Left + bedback.Width + 20,
  .Top = 5,
  .FillColor = Color.DeepSkyBlue,
  .ForeColor = Color.White,
        .Cursor = Cursors.Hand,
  .Visible = True,
  .BorderRadius = 10,
  .Width = bath.Width + 20,
  .Height = 30,
  .BorderThickness = 0
        }

        panel.Controls.Add(bathback)

        bathback.Controls.Add(bath)

        Dim price As New Label With {
        .Text = "Price: Ghc " & dr("Property_Price"),
        .ForeColor = Color.Black,
        .Font = New Font("Arial", 12, FontStyle.Bold),
        .Top = productName.Top + productName.Height + 17,
        .Cursor = Cursors.Hand,
        .Left = productName.Left + 10,
        .AutoSize = True
        }
        panel.Controls.Add(price)


        Dim saleRent As New Label With {
        .Text = dr("Property_sale_rent"),
        .ForeColor = Color.WhiteSmoke,
        .Font = New Font("Arial", 12, FontStyle.Bold),
        .Cursor = Cursors.Hand,
        .Top = 5,
        .Left = 10,
        .AutoSize = True
        }

        Dim saleRentback As New Guna2Panel With {
  .BorderStyle = BorderStyle.FixedSingle,
  .BorderColor = Color.Black,
  .AutoSize = True,
  .Left = price.Left + price.Width + 20,
        .Top = productName.Top + productName.Height + 10,
        .Cursor = Cursors.Hand,
  .FillColor = Color.DeepSkyBlue,
  .ForeColor = Color.White,
  .Visible = True,
  .BorderRadius = 10,
  .Width = saleRent.Width - 25,
  .Height = 30,
  .BorderThickness = 0
        }
        panel.Controls.Add(saleRentback)


        saleRentback.Controls.Add(saleRent)

        Dim location As New Label With {
        .Text = dr("Property_location"),
        .ForeColor = Color.WhiteSmoke,
        .Font = New Font("Arial", 12, FontStyle.Bold),
        .Top = 5,
        .Cursor = Cursors.Hand,
        .Left = 10,
        .AutoSize = True
        }

        Dim locationback As New Guna2Panel With {
  .BorderStyle = BorderStyle.FixedSingle,
  .BorderColor = Color.Black,
  .AutoSize = True,
  .Left = saleRentback.Left + saleRentback.Width + 20,
        .Top = productName.Top + productName.Height + 10,
  .FillColor = Color.DeepSkyBlue,
        .Cursor = Cursors.Hand,
  .ForeColor = Color.White,
  .Visible = True,
  .BorderRadius = 10,
  .Width = saleRent.Width - 25,
  .Height = 30,
  .BorderThickness = 0
        }
        panel.Controls.Add(locationback)

        locationback.Controls.Add(location)


        Dim propertyType As New Label With {
        .Text = dr("Property_type"),
        .ForeColor = Color.WhiteSmoke,
        .Font = New Font("Arial", 12, FontStyle.Bold),
        .Cursor = Cursors.Hand,
        .Top = 5,
        .Left = 10,
        .AutoSize = True
        }

        Dim propertyTypeback As New Guna2Panel With {
  .BorderStyle = BorderStyle.FixedSingle,
  .BorderColor = Color.Black,
  .AutoSize = True,
  .Left = locationback.Left + locationback.Width + 20,
        .Top = productName.Top + productName.Height + 10,
  .FillColor = Color.DeepSkyBlue,
        .Cursor = Cursors.Hand,
  .ForeColor = Color.White,
  .Visible = True,
  .BorderRadius = 10,
  .Width = saleRent.Width - 25,
  .Height = 30,
  .BorderThickness = 0
        }
        panel.Controls.Add(propertyTypeback)

        propertyTypeback.Controls.Add(propertyType)

        Dim description As New Label With {
  .AutoSize = True,
  .Left = productName.Left,
        .Font = New Font("Arial", 12, FontStyle.Bold),
        .Top = propertyTypeback.Top + propertyTypeback.Height + 20,
  .ForeColor = Color.Black,
        .Cursor = Cursors.Hand,
  .Visible = True,
  .Width = panel.Width - picture.Width - 100,
  .Height = panel.Height - 100,
  .Enabled = False,
  .BackColor = Color.FromKnownColor(KnownColor.Control),
  .AutoEllipsis = True,
  .Text = dr("Property_description")
        }

        panel.Controls.Add(description)

        Dim horizontal As New Guna2Separator With {
        .Width = panel.Width,
        .Top = panel.Top + panel.Height + 10,
        .Left = panel.Left
        }

        palMain.Controls.Add(horizontal)

        position = horizontal.Top + 30
        Me.palMain.Controls.Add(panel)

        AddHandler picture.Click, AddressOf Picture_Click
    End Sub

    Private Sub Picture_Click(sender As Object, e As EventArgs)
        Try
            con = New MySqlConnection(My.Settings.conPathDb)
            con.Open()
            Dim qurey As String = "SELECT property.Property_name, property_image.First_image, property_image.Second_image, property_image.Third_image, property_image.Fourth_image FROM `property_image`LEFT JOIN property ON property_image.Property_Id = property.Property_Id WHERE property_image.Property_Id = " & CInt(sender.tag) & ";"
            Using command As New MySqlCommand(qurey, con)
                dr = command.ExecuteReader()
                While dr.Read
                    frmPictureView.lblPropertyName.Text = dr("Property_name").ToString
                    If (dr("First_image") IsNot Nothing) Then
                        Dim imageData() As Byte = DirectCast(dr("First_image"), Byte())
                        Using ms As New MemoryStream(imageData)
                            frmPictureView.pboImage1.Image = Image.FromStream(ms)
                            frmPictureView.pboView.Image = Image.FromStream(ms)
                        End Using
                    End If
                    If (dr("Second_image") IsNot Nothing) Then
                        Dim imageData() As Byte = DirectCast(dr("Second_image"), Byte())
                        Using ms As New MemoryStream(imageData)
                            frmPictureView.pboImage2.Image = Image.FromStream(ms)
                        End Using
                    End If
                    If (dr("Third_image") IsNot Nothing) Then
                        Dim imageData() As Byte = DirectCast(dr("Third_image"), Byte())
                        Using ms As New MemoryStream(imageData)
                            frmPictureView.pboImage3.Image = Image.FromStream(ms)
                        End Using
                    End If
                    If (dr("Fourth_image") IsNot Nothing) Then
                        Dim imageData() As Byte = DirectCast(dr("Fourth_image"), Byte())
                        Using ms As New MemoryStream(imageData)
                            frmPictureView.pboImage4.Image = Image.FromStream(ms)
                        End Using
                    End If
                End While
            End Using
            con.Close()
            frmPictureView.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub frmProperty_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.palMain.Controls.Clear()
        position = 30
        Try
            con = New MySqlConnection(My.Settings.conPathDb)
            con.Open()
            Dim qurey As String = "SELECT property_image.property_Id, property.Property_name, property.No_of_Bedroom, property.No_of_Bathroom, property.Property_Price, property.Property_sale_rent, property.Property_location, property.Property_type, property.Property_description, property_image.First_image FROM property RIGHT JOIN property_image ON property.Property_Id = property_image.Property_Id WHERE property.User_Id = " & Mode.UserId & ";"
            Using command As New MySqlCommand(qurey, con)
                dr = command.ExecuteReader()
                While dr.Read
                    doy()
                End While
            End Using
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click
        Me.palMain.Controls.Clear()
        position = 30
        Try
            con = New MySqlConnection(My.Settings.conPathDb)
            con.Open()
            Dim qurey As String = "SELECT property_image.property_Id, property.Property_name, property.No_of_Bedroom, property.No_of_Bathroom, property.Property_Price, property.Property_sale_rent, property.Property_location, property.Property_type, property.Property_description, property_image.First_image FROM property RIGHT JOIN property_image ON property.Property_Id = property_image.Property_Id WHERE property.User_Id = " & Mode.UserId & ";"
            Using command As New MySqlCommand(qurey, con)
                dr = command.ExecuteReader()
                While dr.Read
                    doy()
                End While
            End Using
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnRent_Click(sender As Object, e As EventArgs) Handles btnRent.Click
        Me.palMain.Controls.Clear()
        position = 30

        Try
            con = New MySqlConnection(My.Settings.conPathDb)
            con.Open()
            Dim qurey As String = "SELECT property_image.property_Id, property.Property_name, property.No_of_Bedroom, property.No_of_Bathroom, property.Property_Price, property.Property_sale_rent, property.Property_location, property.Property_type, property.Property_description, property_image.First_image FROM property RIGHT JOIN property_image ON property.Property_Id = property_image.Property_Id where property.Property_sale_rent = 'Rent' and property.User_Id = " & Mode.UserId & ";"
            Using command As New MySqlCommand(qurey, con)
                dr = command.ExecuteReader()
                While dr.Read
                    doy()
                End While
            End Using
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnHousing_Click(sender As Object, e As EventArgs) Handles btnHousing.Click
        Me.palMain.Controls.Clear()
        position = 30

        Try
            con = New MySqlConnection(My.Settings.conPathDb)
            con.Open()
            Dim qurey As String = "SELECT property_image.property_Id, property.Property_name, property.No_of_Bedroom, property.No_of_Bathroom, property.Property_Price, property.Property_sale_rent, property.Property_location, property.Property_type, property.Property_description, property_image.First_image FROM property RIGHT JOIN property_image ON property.Property_Id = property_image.Property_Id where property.Property_sale_rent = 'Sale' and property.User_Id = " & Mode.UserId & ";"
            Using command As New MySqlCommand(qurey, con)
                dr = command.ExecuteReader()
                While dr.Read
                    doy()
                End While
            End Using
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Me.palMain.Controls.Clear()
        position = 30
        Try
            con = New MySqlConnection(My.Settings.conPathDb)
            con.Open()
            Dim qurey As String = "SELECT property_image.property_Id, property.Property_name, property.No_of_Bedroom, property.No_of_Bathroom, property.Property_Price, property.Property_sale_rent, property.Property_location, property.Property_type, property.Property_description, property_image.First_image FROM property RIGHT JOIN property_image ON property.Property_Id = property_image.Property_Id  where (property.Property_sale_rent like '%" & txtSearch.Text & "%' Or  property.Property_name like '%" & txtSearch.Text & "%' or property.Property_location like '%" & txtSearch.Text & "%' or property.Property_type like '%" & txtSearch.Text & "%') and property.User_Id = " & Mode.UserId & ";"
            Using command As New MySqlCommand(qurey, con)
                dr = command.ExecuteReader()
                While dr.Read
                    doy()
                End While
            End Using
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class