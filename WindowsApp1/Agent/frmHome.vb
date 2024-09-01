Imports MySql.Data.MySqlClient
Imports Guna.UI2.WinForms
Imports Guna.UI.WinForms
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
    Shared histroySaleTop As Integer = 10
    Shared histroyTransactionTop As Integer = 10
    Dim drSale As MySqlDataReader
    Dim drTransaction As MySqlDataReader


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
        histroySaleTop = 10
        histroyTransactionTop = 10
        Histroy()
        Try

            pLeft = 20
            mLeft = 0
            mRight = 0
            count = 0

            Using con As New MySqlConnection(My.Settings.conPathDb)
                con.Open()
                Dim query As String = "SELECT `property_image`.`Property_Id`, `property`.`Property_Price`, `property`.`created`, `property`.`updated`, `property_image`.`First_image` FROM `property` JOIN `property_image` on `property`.`Property_Id` = `property_image`.`Property_Id` WHERE `property`.`User_Id` = " & Mode.UserId & " ORDER by timediff(updated, created);"
                Using com As New MySqlCommand(query, con)
                    dr = com.ExecuteReader
                    While dr.Read
                        viwe()
                    End While
                    dr.Close()
                End Using

                Dim NotAvailableProperty = 0
                Dim totalProperty = 0
                Dim saleQuery As String = "SELECT COUNT(*) as sale FROM `transaction` JOIN	`property` on `property`.`Property_Id` = `transaction`.`Property_Id` WHERE `transaction`.`Transaction_type` = 'SALE' AND property.Property_availability = 'not Available' and `transaction`.`User_Id` = " & Mode.UserId & ";"
                Dim TotalQuery As String = "SELECT COUNT(*) as Total FROM `property` WHERE `property`.`User_Id` =" & Mode.UserId & ";"
                Using command As New MySqlCommand(saleQuery, con)
                    Dim reader As MySqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        NotAvailableProperty = Convert.ToInt64(reader("sale"))
                    End If
                    reader.Close()
                End Using
                Using command As New MySqlCommand(TotalQuery, con)
                    Dim reader As Object = command.ExecuteReader()
                    If reader.Read() Then
                        totalProperty = Convert.ToInt64(reader("Total"))
                    End If
                    reader.Close()
                End Using

                chaTotalSale.Series.Clear()
                chaTotalSale.Series.Add("sale")
                chaTotalSale.Series("sale").Points.AddY(NotAvailableProperty)
                chaTotalSale.Series("sale").Points.AddY(totalProperty - NotAvailableProperty)
                chaTotalSale.Series("sale").ChartType = DataVisualization.Charting.SeriesChartType.Doughnut
                chaTotalSale.Series("sale").Points(0).Label = "SALE"
                chaTotalSale.Series("sale").Points(1).Label = "NOT SALE"

                Dim totalRenu As String = "Select SUM(Transaction_amount) as total FROM `transaction` JOIN	`property` on `property`.`Property_Id` = `transaction`.`Property_Id` WHERE `transaction`.`Transaction_type` = 'SALE' AND property.Property_availability = 'not Available' and `transaction`.`User_Id` = " & Mode.UserId & ";"
                Using command As New MySqlCommand(totalRenu, con)
                    Dim reader As MySqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        lblTotalSale.Text = "GHC " & Convert.ToDecimal(reader("total"))
                    End If
                    reader.Close()
                End Using

            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
        check = True
    End Sub

    Private Sub histroyTransition()

        Dim panel As New Panel With {
        .Width = Me.palTransactionHistroy.Width - 50,
        .Height = 70,
        .BackColor = Color.Transparent,
        .Top = histroyTransactionTop,
        .Left = 20
        }

        Dim img As Image = Nothing
        If (drTransaction("First_image") IsNot Nothing) Then
            Dim imageData() As Byte = DirectCast(drTransaction("First_image"), Byte())
            Using ms As New MemoryStream(imageData)
                img = Image.FromStream(ms)
            End Using
        End If
        Dim picture As New GunaCirclePictureBox With {
            .Width = 50,
            .Height = 50,
            .Image = img,
            .Top = 10,
            .Left = 5,
            .BackColor = Color.Transparent
        }
        panel.Controls.Add(picture)

        Dim Name As New Label With {
        .Text = drTransaction("Property_name"),
        .Font = New Font("Arial", 12, FontStyle.Bold),
        .Width = panel.Width - 100,
        .Left = picture.Width + 10,
        .ForeColor = Color.White,
        .Top = 10,
            .BackColor = Color.Transparent
        }
        panel.Controls.Add(Name)

        Dim saleRent As New Label With {
        .Text = drTransaction("Property_sale_rent"),
        .Font = New Font("Arial", 9),
        .Width = 40,
        .Height = 20,
        .ForeColor = Color.White,
        .Left = picture.Width + 10,
        .Top = Name.Top + Name.Height,
            .BackColor = Color.Transparent
        }
        panel.Controls.Add(saleRent)

        Dim type As New Label With {
        .Text = drTransaction("Property_type"),
        .Font = New Font("Arial", 9),
        .Left = saleRent.Width + saleRent.Left,
        .ForeColor = Color.White,
        .Top = saleRent.Top,
        .Height = 20,
            .BackColor = Color.Transparent
        }
        panel.Controls.Add(type)

        Dim Amount As New Label With {
        .Text = "Ghc " & drTransaction("Transaction_amount"),
        .Font = New Font("Arial", 9),
        .Left = saleRent.Left,
        .ForeColor = Color.White,
        .Top = type.Top + type.Height - 1,
            .BackColor = Color.Transparent
        }
        panel.Controls.Add(Amount)

        Dim Status As New Label With {
        .Text = drTransaction("Transaction_status"),
        .Font = New Font("Arial", 9),
        .Left = Amount.Left + Amount.Width,
        .ForeColor = Color.White,
        .Top = type.Top + type.Height - 1,
            .BackColor = Color.Transparent
        }
        panel.Controls.Add(Status)

        histroyTransactionTop += panel.Height + 10

        Me.palTransactionHistroy.Controls.Add(panel)
    End Sub

    Private Sub histroySale()

        Dim panel As New Panel With {
        .Width = Me.palSaleHistory.Width - 50,
        .Height = 70,
        .BackColor = Color.Transparent,
        .Top = histroySaleTop,
        .Left = 20
        }

        Dim img As Image = Nothing
        If (drSale("First_image") IsNot Nothing) Then
            Dim imageData() As Byte = DirectCast(drSale("First_image"), Byte())
            Using ms As New MemoryStream(imageData)
                img = Image.FromStream(ms)
            End Using
        End If
        Dim picture As New GunaCirclePictureBox With {
            .Width = 50,
            .Height = 50,
            .Image = img,
            .Top = 10,
            .Left = 5,
            .BackColor = Color.Transparent
        }
        panel.Controls.Add(picture)

        Dim Name As New Label With {
        .Text = drSale("Property_name"),
        .Font = New Font("Arial", 12, FontStyle.Bold),
        .ForeColor = Color.White,
        .Width = panel.Width - 100,
        .Left = picture.Width + 10,
        .Top = 10,
            .BackColor = Color.Transparent
        }
        panel.Controls.Add(Name)

        Dim saleRent As New Label With {
        .Text = drSale("Property_sale_rent"),
        .Font = New Font("Arial", 9),
        .ForeColor = Color.White,
        .Width = 40,
        .Height = 20,
        .Left = picture.Width + 10,
        .Top = Name.Top + Name.Height,
            .BackColor = Color.Transparent
        }
        panel.Controls.Add(saleRent)

        Dim type As New Label With {
        .Text = drSale("Property_type"),
        .Font = New Font("Arial", 9),
        .Left = saleRent.Width + saleRent.Left,
        .ForeColor = Color.White,
        .Top = saleRent.Top,
        .Height = 20,
            .BackColor = Color.Transparent
        }
        panel.Controls.Add(type)

        Dim Amount As New Label With {
        .Text = "Ghc " & drSale("Sale_Amount"),
        .Font = New Font("Arial", 9),
        .Left = saleRent.Left,
        .ForeColor = Color.White,
        .Top = type.Top + type.Height - 1,
            .BackColor = Color.Transparent
        }
        panel.Controls.Add(Amount)

        Dim Status As New Label With {
        .Text = drSale("Sale_Status"),
        .Font = New Font("Arial", 9),
        .ForeColor = Color.White,
        .Left = Amount.Left + Amount.Width,
        .Top = type.Top + type.Height - 1,
            .BackColor = Color.Transparent
        }
        panel.Controls.Add(Status)

        histroySaleTop += panel.Height + 10

        Me.palSaleHistory.Controls.Add(panel)
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

    Private Sub Histroy()
        Try
            Using connection As New MySqlConnection(My.Settings.conPathDb)
                connection.Open()
                Dim Transactionquery = "SELECT `property`.`Property_name`, `property`.`Property_type`, `property`.`Property_sale_rent`, `transaction`.`Transaction_amount`, `transaction`.`Transaction_status`, `property_image`.`First_image` FROM `property` JOIN `transaction` on `property`.`Property_Id` = `transaction`.`Property_Id` JOIN `property_image` on `property_image`.`Property_Id` = `property`.`Property_Id` where `property`.`User_Id` =" & Mode.UserId & " ORDER by `transaction`.`Transaction_Date`;"
                Using command As New MySqlCommand(Transactionquery, connection)
                    drTransaction = command.ExecuteReader
                    While drTransaction.Read
                        histroyTransition()
                    End While
                    drTransaction.Close()
                End Using

                Dim Salequery = "SELECT `property`.`Property_name`, `property`.`Property_type`, `property`.`Property_sale_rent`, `sale`.`Sale_Amount`, `sale`.`Sale_Status`, `property_image`.`First_image` FROM `property` JOIN `sale` on `property`.`Property_Id` = `sale`.`Property_Id` JOIN `property_image` on `property_image`.`Property_Id` = `property`.`Property_Id` where `property`.`User_Id` =" & Mode.UserId & " ORDER by `sale`.`Sale_Date`;"
                Using command As New MySqlCommand(Salequery, connection)
                    drSale = command.ExecuteReader
                    While drSale.Read
                        histroySale()
                    End While
                    drSale.Close()
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Dim check = False

    Private Sub txtTransactionHistroy_TextChanged(sender As Object, e As EventArgs) Handles txtTransactionHistroy.TextChanged
        If check Then
            Me.palTransactionHistroy.Controls.Clear()
            histroyTransactionTop = 10
            Try
                Using connection As New MySqlConnection(My.Settings.conPathDb)
                    connection.Open()

                    ' Use a parameterized query to prevent SQL injection and correctly handle wildcards
                    Dim Transactionquery = "SELECT `property`.`Property_name`, `property`.`Property_type`, `property`.`Property_sale_rent`, `transaction`.`Transaction_amount`, `transaction`.`Transaction_status`, `property_image`.`First_image` FROM `property` JOIN `transaction` ON `property`.`Property_Id` = `transaction`.`Property_Id` JOIN `property_image` ON `property_image`.`Property_Id` = `property`.`Property_Id` WHERE `property`.`User_Id` = @UserId AND `property`.`Property_name` LIKE @PropertyName ORDER BY `transaction`.`Transaction_Date`;"

                    Using command As New MySqlCommand(Transactionquery, connection)
                        ' Add parameters to the command
                        command.Parameters.AddWithValue("@UserId", Mode.UserId)
                        command.Parameters.AddWithValue("@PropertyName", "%" & txtTransactionHistroy.Text & "%") ' Add wildcards for partial matching

                        drTransaction = command.ExecuteReader()
                        While drTransaction.Read()
                            histroyTransition() ' Ensure this method is properly handling data
                        End While
                        drTransaction.Close()
                    End Using
                End Using

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub txtSaleHistory_TextChanged(sender As Object, e As EventArgs) Handles txtSaleHistory.TextChanged
        If check Then
            Me.palSaleHistory.Controls.Clear()
            histroySaleTop = 10
            Try
                Using connection As New MySqlConnection(My.Settings.conPathDb)
                    connection.Open()

                    ' Use a parameterized query to prevent SQL injection and correctly handle wildcards
                    Dim Salequery = "SELECT `property`.`Property_name`, `property`.`Property_type`, `property`.`Property_sale_rent`, `sale`.`Sale_Amount`, `sale`.`Sale_Status`, `property_image`.`First_image` FROM `property` JOIN `sale` ON `property`.`Property_Id` = `sale`.`Property_Id` JOIN `property_image` ON `property_image`.`Property_Id` = `property`.`Property_Id` WHERE `property`.`User_Id` = @UserId AND `property`.`Property_name` LIKE @PropertyName ORDER BY `sale`.`Sale_Date`;"

                    Using command As New MySqlCommand(Salequery, connection)
                        ' Add parameters to the command
                        command.Parameters.AddWithValue("@UserId", Mode.UserId)
                        command.Parameters.AddWithValue("@PropertyName", "%" & txtSaleHistory.Text & "%") ' Add wildcards for partial matching

                        drSale = command.ExecuteReader()
                        While drSale.Read()
                            histroySale() ' Ensure this method is properly handling data
                        End While
                        drSale.Close()
                    End Using
                End Using

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

End Class
