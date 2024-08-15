Imports MySql.Data.MySqlClient
Imports Guna.UI2.WinForms
Imports System.IO

Public Class frmHome
    Private dr As MySqlDataReader
    Private Shared pLeft As Integer = 20
    Private Shared mLeft As Integer = 0
    Private Shared mRight As Integer = 0
    Private Shared count As Integer = 0
    Private moveAmount As Integer = 0
    Private moveDirection As Integer = 0
    Private WithEvents moveTimer As New Timer With {.Interval = 10}

    Private Sub viwe()
        Dim panel As New Guna2Panel With {
            .BackColor = Color.Transparent,
            .FillColor = Color.Transparent,
            .BorderStyle = Drawing2D.DashStyle.Solid,
            .BackgroundImageLayout = ImageLayout.Stretch,
            .Dock = DockStyle.None,
            .Height = Me.palView.Height,
            .Width = 150,
            .Top = 0,
            .Left = pLeft,
            .Cursor = Cursors.Hand
        }

        Dim img As Image = Nothing
        If (dr("First_image") IsNot Nothing) Then
            Dim imageData() As Byte = DirectCast(dr("First_image"), Byte())
            Using ms As New MemoryStream(imageData)
                img = Image.FromStream(ms)
            End Using
        End If
        Dim pic As New Guna2PictureBox With {
            .Image = img,
            .BorderRadius = 10,
            .Dock = DockStyle.Fill,
            .Height = panel.Height,
            .SizeMode = PictureBoxSizeMode.StretchImage,
            .Tag = dr("property_Id")
        }
        panel.Controls.Add(pic)

        Dim price As New Label With {
            .Text = dr("Property_Price"),
            .AutoSize = True,
            .AutoEllipsis = True,
            .BackColor = Color.Transparent,
            .Font = New Font("Arial", 12, FontStyle.Bold),
            .ForeColor = Color.Black
        }

        Dim palPrice As New Guna2Panel With {
            .BackColor = Color.Transparent,
            .FillColor = Color.Transparent,
            .BorderStyle = Drawing2D.DashStyle.Solid,
            .BackgroundImageLayout = ImageLayout.Stretch,
            .BorderRadius = 10,
            .BackgroundImage = Nothing,
            .Dock = DockStyle.None,
            .Height = 30,
            .Width = panel.Width,
            .Top = panel.Height - 30,
            .Left = 0
        }
        panel.Controls.Add(palPrice)
        palPrice.Controls.Add(price)

        palPrice.BringToFront()
        price.Top = (palPrice.Height - palPrice.Height) / 2
        price.Left = (panel.Width - price.Width) / 2

        pLeft += panel.Width + 20
        mRight += 1
        Me.palView.Controls.Add(panel)
        Me.palView.Width += pLeft

        AddHandler pic.Click, AddressOf Picture_Click
    End Sub

    Private Sub Picture_Click(sender As Object, e As EventArgs)
        Try
            Using con As New MySqlConnection(My.Settings.conPathDb)
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
            End Using
            frmPictureView.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub frmHome_Load(sender As Object, e As EventArgs) Handles Me.Load
        pLeft = 20
        mLeft = 0
        mRight = 0
        count = 0

        Using con As New MySqlConnection(My.Settings.conPathDb)
            con.Open()
            Dim query As String = "SELECT `property_image`.`Property_Id`, `property`.`Property_Price`, `property`.`created`, `property`.`updated`, `property_image`.`First_image` FROM `property` JOIN `property_image` on `property`.`Property_Id` = `property_image`.`Property_Id` ORDER by timediff(updated, created);"
            Using com As New MySqlCommand(query, con)
                dr = com.ExecuteReader
                While dr.Read
                    viwe()
                End While
            End Using
        End Using

    End Sub

    Private Sub btnLeft_Click(sender As Object, e As EventArgs) Handles btnLeft.Click
        If mRight = 2 Then
            moveAmount = 60
            moveDirection = 1
            moveTimer.Start()
            mRight += 1
            mLeft -= 1
        ElseIf mLeft <> 0 Then
            moveAmount = 170
            moveDirection = 1
            moveTimer.Start()
            mRight += 1
            mLeft -= 1
        End If
    End Sub

    Private Sub btnRight_Click(sender As Object, e As EventArgs) Handles btnRight.Click
        If (mRight - 2) = 1 Then
            moveAmount = 60
            moveDirection = -1
            moveTimer.Start()
            mRight -= 1
            mLeft += 1
        ElseIf (mRight - 2) > 0 Then
            moveAmount = 170
            moveDirection = -1
            moveTimer.Start()
            mRight -= 1
            mLeft += 1
        End If
    End Sub

    Private Sub moveTimer_Tick(sender As Object, e As EventArgs) Handles moveTimer.Tick
        palView.Left += moveDirection * 10
        moveAmount -= 10

        If moveAmount <= 0 Then
            moveTimer.Stop()
        End If
    End Sub
End Class
