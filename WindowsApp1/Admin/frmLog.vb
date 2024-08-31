Imports System.Drawing.Printing
Imports System.Drawing
Imports iTextSharp.text.pdf
Imports System.IO
Imports System.Text

Public Class frmLog
    Private currentRow As Integer = 0
    Private currentLine As Integer = 0
    Private lines As String()

    Private Sub frmSignup2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using reader As New StreamReader(splash_screen.log.ToString)
            rtbLogs.Text = reader.ReadToEnd()
        End Using

    End Sub

    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        If rtbLogs.Text.Length > 0 Then
            Clipboard.SetText(rtbLogs.Text)
            MessageBox.Show("Copied to Clipboard", "Information")
        End If
    End Sub

    ' Your existing PrintDocument1_PrintPage method
    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        ' Fonts

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

        ' String formats
        Dim left As New StringFormat
        Dim right As New StringFormat
        Dim center As New StringFormat
        left.Alignment = StringAlignment.Near
        center.Alignment = StringAlignment.Center
        right.Alignment = StringAlignment.Far

        ' Header
        Dim header As New Rectangle(10, 10, e.PageBounds.Width - 20, 70)
        Dim logo As New Rectangle(10, 5, 100, 70)
        e.Graphics.DrawImage(My.Resources.LOGOCOLOR, logo)
        Dim companyName As New Rectangle(10, 20, 830, 50)
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
        e.Graphics.DrawString("LOG FILE", f14B, Brushes.Black, title, center)

        Dim space As New Rectangle(10, title.Y + 30, e.PageBounds.Width, 70)
        e.Graphics.DrawString("", f12, Brushes.Black, space, center)

        ' Log content
        Dim logFilePath As String = splash_screen.log
        If File.Exists(logFilePath) Then
            Dim logFileContent As String = File.ReadAllText(logFilePath)
            lines = logFileContent.Split(New String() {Environment.NewLine}, StringSplitOptions.None)

            Dim yPos As Integer = space.Y + 30
            Dim pageHeight As Single = e.MarginBounds.Height
            Dim lineHeight As Single = e.Graphics.MeasureString("A", f12).Height
            Dim linesPerPage As Integer = Math.Floor(pageHeight / lineHeight)

            While currentLine < lines.Length

                Dim pageContent As New StringBuilder()
                For i As Integer = 0 To linesPerPage - 1
                    If currentLine < lines.Length Then
                        pageContent.AppendLine(lines(currentLine))
                        currentLine += 1
                    Else
                        Exit For
                    End If
                Next

                e.Graphics.DrawString(pageContent.ToString(), f12, Brushes.Black, New Rectangle(10, yPos, e.PageBounds.Width - 20, e.PageBounds.Height - yPos), left)
                    yPos += CInt(lineHeight * linesPerPage)
                    If currentLine > 0 Then
                        e.HasMorePages = True
                        Return
                    End If
            End While

            ' Reset for next print job
            e.HasMorePages = False
            currentLine = 0
        Else
            MessageBox.Show("Log file not found: " & logFilePath)
        End If

    End Sub

    ' Print button click event
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        'PrintDocument1.DefaultPageSettings.Landscape = True
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.WindowState = FormWindowState.Maximized
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        rtbLogs.Clear()
    End Sub
End Class