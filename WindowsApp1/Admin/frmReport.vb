Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Imports System.Drawing
Imports System.IO

Public Class frmReport
    Dim connection As MySqlConnection
    Public command As MySqlCommand
    Dim dgvTop As Integer = 205
    Dim btnTop As Integer = 560
    Dim PropertyLeft As Integer = 323
    Dim query As String = ""
    Dim dbDataset1 As New DataTable
    Private currentRow As Integer = 0
    Dim topic As String = ""

    Private Sub frmReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If frmDashboard.nav Then
            frmDashboard.ChangePanelControlsColor(Me)
        End If
        If lblshow.Text.Equals(frmSetting.lilblClient.Text) Then
            lblAgent.Visible = False
            lblPropertyName.Visible = False
            lblStartDuration.Visible = False
            lblEndDuration.Visible = False
            cboAgent.Visible = False
            cboPropertyName.Visible = False
            dtpEndDuration.Visible = False
            dtpStartDuration.Visible = False
            dgvView.Top = lblAgent.Top
            dgvView.Height += lblAgent.Top - 90
            btnPrint.Top -= 30
            lblPropertyName.Left = PropertyLeft
            cboPropertyName.Left = PropertyLeft
            query = "Select * from client"
            loadData(dgvView, query)
            topic = "Client Report"
        ElseIf lblshow.Text.Equals(frmSetting.lilblOwner.Text) Then
            lblAgent.Visible = True
            lblPropertyName.Visible = True
            lblStartDuration.Visible = False
            lblEndDuration.Visible = False
            cboAgent.Visible = True
            cboPropertyName.Visible = True
            dtpEndDuration.Visible = False
            dtpStartDuration.Visible = False
            dgvView.Top = dgvTop
            dgvView.Height = 349
            btnPrint.Top = btnTop
            lblPropertyName.Left = PropertyLeft
            cboPropertyName.Left = PropertyLeft
            query = "SELECT ownership.Owner_Id, property.Property_name, property.Property_location, property.Property_type, property.Property_Price, case when customer.mName is null or customer.mName = '' THEN concat(customer.fName, ' ', customer.lName) ELSE concat(customer.fName, ' ', customer.mName, ' ', customer.lName) END as customer_Name, case when user.mName is null or user.mName = '' THEN concat(user.fName, ' ', user.lName) ELSE concat(user.fName, ' ', user.mName, ' ', user.lName) END as Agent_Name FROM ownership LEFT JOIN property on ownership.Property_Id = property.Property_Id LEFT JOIN customer on ownership.Customer_id = customer.Customer_Id LEFT JOIN user on customer.User_Id = user.User_Id;"
            loadData(dgvView, query)
            topic = "Ownership Report"
        ElseIf lblshow.Text.Equals(frmSetting.lilblSale.Text) Then
            lblAgent.Visible = True
            lblPropertyName.Visible = True
            lblStartDuration.Visible = True
            lblEndDuration.Visible = True
            cboAgent.Visible = True
            cboPropertyName.Visible = True
            dtpEndDuration.Visible = True
            dtpStartDuration.Visible = True
            dgvView.Top = dgvTop
            dgvView.Height = 349
            btnPrint.Top = btnTop
            lblPropertyName.Left = PropertyLeft
            cboPropertyName.Left = PropertyLeft
            query = "SELECT sale.Sale_Id, case when user.mName IS null or user.mName = '' THEN concat(user.fName, ' ', user.lName) ELSE concat(user.fName, ' ', user.mName, ' ', user.lName) end as Agent_Name, property.Property_name, property.Property_Price, case when customer.mName IS null or customer.mName = '' THEN concat(customer.fName, ' ', customer.lName) ELSE concat(customer.fName, ' ', customer.mName, ' ', customer.lName) end as customer_name, sale.Sale_Date, sale.Sale_Amount, sale.Sale_Status, sale.Closing_Date, sale.Payment_Mode, sale.Payment_Reference FROM sale LEFT JOIN user ON sale.User_Id = user.User_Id LEFT JOIN property ON property.User_Id = user.User_Id LEFT JOIN customer on customer.User_Id = user.User_Id;"
            loadData(dgvView, query)
            topic = "Sale Report"
        ElseIf lblshow.Text.Equals(frmSetting.lilblTransaction.Text) Then
            lblAgent.Visible = True
            lblPropertyName.Visible = True
            lblStartDuration.Visible = True
            lblEndDuration.Visible = True
            cboAgent.Visible = True
            cboPropertyName.Visible = True
            dtpEndDuration.Visible = True
            dtpStartDuration.Visible = True
            dgvView.Top = dgvTop
            dgvView.Height = 349
            btnPrint.Top = btnTop
            lblPropertyName.Left = PropertyLeft
            cboPropertyName.Left = PropertyLeft
            query = "SELECT `transaction`.`Transaction_Id`, case when user.mName IS null or user.mName = '' THEN concat(user.fName, ' ', user.lName) ELSE concat(user.fName, ' ', user.mName, ' ', user.lName) end as Agent_Name, property.Property_name, property.Property_Price, case when customer.mName IS null or customer.mName = '' THEN concat(customer.fName, ' ', customer.lName) ELSE concat(customer.fName, ' ', customer.mName, ' ', customer.lName) end as customer_name, transaction.Transaction_Date, transaction.Transaction_amount, transaction.Transaction_status, transaction.Payment_mode, transaction.Transaction_type, transaction.Payment_reference FROM transaction LEFT JOIN user ON transaction.User_Id = user.User_Id LEFT JOIN property ON property.User_Id = user.User_Id LEFT JOIN customer on customer.User_Id = user.User_Id;"
            loadData(dgvView, query)
            topic = "Transaction Report"
        ElseIf lblshow.Text.Equals(frmSetting.lilblRent.Text) Then
            lblAgent.Visible = True
            lblPropertyName.Visible = True
            lblStartDuration.Visible = False
            lblEndDuration.Visible = False
            cboAgent.Visible = True
            cboPropertyName.Visible = True
            dtpEndDuration.Visible = False
            dtpStartDuration.Visible = False
            dgvView.Top = dgvTop
            dgvView.Height = 349
            btnPrint.Top = btnTop
            lblPropertyName.Left = PropertyLeft
            cboPropertyName.Left = PropertyLeft
            query = "SELECT property.Property_Id,  CASE when user.mName is null or user.mName ='' then concat(user.fName, ' ', user.lName) ELSE concat(user.fName, ' ', user.mName, ' ', user.lName) end as Agent_Name, property.Property_name, property.Property_location, property.No_of_Bathroom, property.No_of_Bedroom, property.Property_type, property.Property_sale_rent, property.Property_Price, property.Property_description, property.Property_availability FROM property LEFT JOIN user on user.User_Id = property.User_Id WHERE Property_sale_rent = 'Rent';"
            loadData(dgvView, query)
            topic = "Rent Report"
        ElseIf lblshow.Text.Equals(frmSetting.lilblHousing.Text) Then
            lblAgent.Visible = True
            lblPropertyName.Visible = True
            lblStartDuration.Visible = False
            lblEndDuration.Visible = False
            cboAgent.Visible = True
            cboPropertyName.Visible = True
            dtpEndDuration.Visible = False
            dtpStartDuration.Visible = False
            dgvView.Top = dgvTop
            dgvView.Height = 349
            btnPrint.Top = btnTop
            lblPropertyName.Left = PropertyLeft
            cboPropertyName.Left = PropertyLeft
            query = "SELECT property.Property_Id,  CASE when user.mName is null or user.mName ='' then concat(user.fName, ' ', user.lName) ELSE concat(user.fName, ' ', user.mName, ' ', user.lName) end as Agent_Name, property.Property_name, property.Property_location, property.No_of_Bathroom, property.No_of_Bedroom, property.Property_type, property.Property_sale_rent, property.Property_Price, property.Property_description, property.Property_availability FROM property LEFT JOIN user on user.User_Id = property.User_Id WHERE Property_sale_rent = 'Sale';"
            loadData(dgvView, query)
            topic = "Housing Report"
        ElseIf lblshow.Text.Equals(frmSetting.lilblAgent.Text) Then
            lblAgent.Visible = False
            lblPropertyName.Visible = True
            lblPropertyName.Left = lblAgent.Left
            lblStartDuration.Visible = False
            lblEndDuration.Visible = False
            cboAgent.Visible = False
            cboPropertyName.Visible = True
            cboPropertyName.Left = cboAgent.Left
            dtpEndDuration.Visible = False
            dtpStartDuration.Visible = False
            dgvView.Top = dgvTop
            dgvView.Height = 349
            btnPrint.Top = btnTop
            query = "SELECT user.User_Id, case WHEN user.mName is null or user.mName = '' THEN concat(user.fName, ' ', user.lName) ELSE concat(user.fName, ' ', user.mName, ' ', user.lName) end AS Agent_Name, property.Property_name, property.Property_location, property.Property_Price, property.Property_availability FROM user LEFT JOIN property on user.User_Id = property.User_Id;"
            loadData(dgvView, query)
            topic = "Agent Report"
        Else
            Exit Sub
        End If
        cboAgent.Items.Clear()
        cboPropertyName.Items.Clear()
        loadComboData()
    End Sub


    Private Sub loadComboData()
        connection = New MySqlConnection
        connection.ConnectionString = My.Settings.conPathDb
        Dim reader As MySqlDataReader

        Try
            cboPropertyName.Items.Add("ALL")
            cboAgent.Items.Add("ALL")
            connection.Open()
            Dim query As String = "SELECT  property.Property_name as propertyName FROM g3subvb.property;"
            command = New MySqlCommand(query, connection)
            reader = Command.ExecuteReader
            While reader.Read
                Dim propertyName = reader.GetString("propertyName")
                cboPropertyName.Items.Add(propertyName)
            End While
            reader.Close()
            query = "SELECT case when user.mName IS null or user.mName = '' THEN concat(user.fName, ' ', user.lName) ELSE concat(user.fName, ' ', user.mName, ' ', user.lName) end as fullName, login.User_Id FROM g3subvb.user LEFT JOIN g3subvb.login ON g3subvb.user.User_Id = g3subvb.login.User_Id WHERE g3subvb.login.User_role = 'Agent';"
            command = New MySqlCommand(query, connection)
            reader = command.ExecuteReader
            While reader.Read
                Dim agent = reader.GetString("fullName")
                cboAgent.Items.Add(agent)
            End While
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Dispose()
        End Try
        cboAgent.SelectedIndex = 0
        cboPropertyName.SelectedIndex = 0
    End Sub

    Private Sub loadData(ByVal dataGridView As DataGridView, ByVal q As String)
        Dim SDA As New MySqlDataAdapter
        Dim bsource As New BindingSource
        Dim dbDataset As New DataTable


        connection = New MySqlConnection(My.Settings.conPathDb)

        Try
            connection.Open()

            Dim query As String = q
            command = New MySqlCommand(query, connection)
            SDA.SelectCommand = command
            SDA.Fill(dbDataset)
            bsource.DataSource = dbDataset
            dataGridView.DataSource = bsource
            SDA.Update(dbDataset)
            dbDataset1 = dbDataset

            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbNewLine & q, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub cboPropertyName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPropertyName.SelectedIndexChanged
        Dim DV As New DataView(dbDataset1)

        If cboPropertyName.SelectedIndex >= 1 Then
            cboAgent.SelectedIndex = 0
            DV.RowFilter = String.Format("Property_name like '%{0}%'", cboPropertyName.Text)
            dgvView.DataSource = DV
        Else
            loadData(dgvView, query)
        End If
    End Sub

    Private Sub cboAgent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAgent.SelectedIndexChanged
        Dim DV As New DataView(dbDataset1)

        If cboAgent.SelectedIndex >= 1 Then
            cboPropertyName.SelectedIndex = 0
            DV.RowFilter = String.Format("Agent_Name like '%{0}%'", cboAgent.Text)
            dgvView.DataSource = DV
        Else
            loadData(dgvView, query)
        End If

    End Sub

    Private Sub dtpStartDuration_ValueChanged(sender As Object, e As EventArgs) Handles dtpStartDuration.ValueChanged
        Dim DV As New DataView(dbDataset1)

        If lblshow.Text.Equals(frmSetting.lilblTransaction.Text) Then

            Dim startDateString As String = dtpStartDuration.Value.ToString("yyyy-MM-dd")
            Dim endDateString As String = dtpEndDuration.Value.ToString("yyyy-MM-dd")

            DV.RowFilter = String.Format("Transaction_Date >= '{0}' AND Transaction_Date <= '{1}'", startDateString, endDateString)
            dgvView.DataSource = DV

        ElseIf lblshow.Text.Equals(frmSetting.lilblSale.Text) Then

            Dim startDateString As String = dtpStartDuration.Value.ToString("yyyy-MM-dd")
            Dim endDateString As String = dtpEndDuration.Value.ToString("yyyy-MM-dd")

            DV.RowFilter = String.Format("Sale_Date >= '{0}' AND Sale_Date <= '{1}'", startDateString, endDateString)
            dgvView.DataSource = DV

        Else
            'loadData(dgvView, query)
        End If

    End Sub

    Private Sub dtpEndDuration_ValueChanged(sender As Object, e As EventArgs) Handles dtpEndDuration.ValueChanged
        Dim DV As New DataView(dbDataset1)

        If lblshow.Text.Equals(frmSetting.lilblTransaction.Text) Then

            Dim startDateString As String = dtpStartDuration.Value.ToString("yyyy-MM-dd")
            Dim endDateString As String = dtpEndDuration.Value.ToString("yyyy-MM-dd")

            DV.RowFilter = String.Format("Transaction_Date >= '{0}' AND Transaction_Date <= '{1}'", startDateString, endDateString)
            dgvView.DataSource = DV

        ElseIf lblshow.Text.Equals(frmSetting.lilblSale.Text) Then

            Dim startDateString As String = dtpStartDuration.Value.ToString("yyyy-MM-dd")
            Dim endDateString As String = dtpEndDuration.Value.ToString("yyyy-MM-dd")

            DV.RowFilter = String.Format("Sale_Date >= '{0}' AND Sale_Date <= '{1}'", startDateString, endDateString)
            dgvView.DataSource = DV

        Else
            ' loadData(dgvView, query)
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintDocument1.DefaultPageSettings.Landscape = True
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.WindowState = FormWindowState.Maximized
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Dim f28 As New Font("Times New Roman", 28, FontStyle.Regular)
        Dim f28B As New Font("Times New Roman", 28, FontStyle.Bold)

        Dim f16 As New Font("Times New Roman", 16, FontStyle.Regular)
        Dim f16B As New Font("Times New Roman", 16, FontStyle.Bold)

        Dim f14 As New Font("Times New Roman", 14, FontStyle.Regular)
        Dim f14B As New Font("Times New Roman", 14, FontStyle.Bold)

        Dim f12 As New Font("Times New Roman", 12, FontStyle.Regular)
        Dim f12B As New Font("Times New Roman", 12, FontStyle.Bold)

        Dim f8 As New Font("Times New Roman", 8, FontStyle.Regular)
        Dim f8B As New Font("Times New Roman", 8, FontStyle.Bold)

        Dim left As New StringFormat
        Dim right As New StringFormat
        Dim center As New StringFormat

        left.Alignment = StringAlignment.Near
        center.Alignment = StringAlignment.Center
        right.Alignment = StringAlignment.Far

        Dim header As New Rectangle(10, 10, e.PageBounds.Width - 20, 70)

        Dim logo As New Rectangle(10, 5, 100, 70)
        e.Graphics.DrawImage(My.Resources.LOGOCOLOR, logo)

        Dim companyName As New Rectangle(10, 20, e.PageBounds.Width - 20, 50)
        e.Graphics.DrawString("LEGACY HOME", f28B, Brushes.Black, companyName, center)

        Dim slogan As New Rectangle(10, header.Height, e.PageBounds.Width - 20, 70)
        e.Graphics.DrawString("Affordable Home", f14, Brushes.Black, slogan, center)

        Dim address As New Rectangle(10, slogan.Y + 20, e.PageBounds.Width - 20, 70)
        e.Graphics.DrawString("TEMA COMMUNITY 25, ZINO STREET", f14, Brushes.Black, address, center)

        Dim postOffice As New Rectangle(10, address.Y + 20, e.PageBounds.Width - 20, 70)
        e.Graphics.DrawString("POST OFFICE BOX 224", f14, Brushes.Black, postOffice, center)

        Dim contact As New Rectangle(10, postOffice.Y + 20, e.PageBounds.Width - 20, 70)
        e.Graphics.DrawString("+233-534673884 / +233-534623454", f14, Brushes.Black, contact, center)

        Dim user As New Rectangle(10, contact.Y + 30, e.PageBounds.Width / 3, 70)
        e.Graphics.DrawString("USERNAME: " & Mode.username.ToString, f12, Brushes.Black, user, center)

        Dim role As New Rectangle(user.Width + 20, contact.Y + 30, e.PageBounds.Width / 3, 70)
        e.Graphics.DrawString("ROLE: " & Mode.user_role.ToString, f12, Brushes.Black, role, center)

        Dim time As New Rectangle(role.Width + role.X - 10, contact.Y + 30, e.PageBounds.Width / 3, 70)
        e.Graphics.DrawString("Date: " & Date.Now.ToString, f12, Brushes.Black, time, center)

        Dim title As New Rectangle(10, time.Y + 30, e.PageBounds.Width, 70)
        e.Graphics.DrawString(topic.ToUpper.ToString, f14B, Brushes.Black, title, center)

        Dim space As New Rectangle(10, title.Y + 30, e.PageBounds.Width, 70)
        e.Graphics.DrawString("", f12, Brushes.Black, space, center)

        ' DataGridView header
        Dim yPos As Integer = space.Y + 30

        Dim totalWidth As Integer = dgvView.Columns.Cast(Of DataGridViewColumn)().Sum(Function(c) c.Width)
        Dim scaleFactor As Single = e.PageBounds.Width / totalWidth
        Dim rowHeight As Integer = 90

        ' Center alignment for cell content
        Dim cellFormat As New StringFormat
        cellFormat.Alignment = StringAlignment.Center
        cellFormat.LineAlignment = StringAlignment.Center
        Dim x As Integer = 10

        ' Print DataGridView headers
        For Each head As DataGridViewColumn In dgvView.Columns
            Dim cellWidth As Integer = CInt(head.Width * scaleFactor)

            Dim cellRect As New Rectangle(x, yPos, cellWidth, rowHeight)
            e.Graphics.DrawRectangle(Pens.Black, cellRect)
            e.Graphics.DrawString(If(head.HeaderText IsNot Nothing, head.HeaderText.ToString(), String.Empty), f12B, Brushes.Black, cellRect, cellFormat)
            x += cellWidth
        Next
        yPos += rowHeight
        ' DataGridView content
        While currentRow < dgvView.Rows.Count
            Dim row As DataGridViewRow = dgvView.Rows(currentRow)
            Dim xPos As Integer = 10

            For Each cell As DataGridViewCell In row.Cells
                Dim cellWidth As Integer = CInt(cell.Size.Width * scaleFactor)
                Dim cellRect As New Rectangle(xPos, yPos, cellWidth, rowHeight)
                Dim cellText As String = If(cell.Value IsNot Nothing, cell.Value.ToString(), String.Empty)
                Dim textSize As SizeF = e.Graphics.MeasureString(cellText, f12, cellWidth)
                '' Adjust row height based on the cell content
                'If textSize.Height > rowHeight Then
                '    rowHeight = CInt(textSize.Height)
                'End If
                e.Graphics.DrawRectangle(Pens.Black, cellRect)
                e.Graphics.DrawString(cellText, f12, Brushes.Black, cellRect, cellFormat)
                xPos += cellWidth
            Next

            yPos += rowHeight
            currentRow += 1

            ' Check if we need to continue on the next page
            If yPos + rowHeight > e.MarginBounds.Bottom Then
                e.HasMorePages = True
                Return
            End If
        End While

        ' Reset for next print job
        e.HasMorePages = False
        currentRow = 0
    End Sub
End Class