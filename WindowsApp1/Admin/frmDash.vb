Imports WindowsApp1.Mode
Imports Guna.UI.WinForms
Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient

Public Class frmDash
    Dim closeMenu As Boolean = True
    Dim openPalSaleAndTransaction As Boolean = False
    Dim openPalPropertyTypesAndCategoriesMenu As Boolean = False
    Dim openPalClientAndOwner As Boolean = False
    Private checkMood As Boolean = Mode.checkMood
    Private mood As New Mode
    Public f As Form
    Dim nav As Boolean = False
    Dim connection As MySqlConnection
    Public command As MySqlCommand
    Dim totalProperty As Int64 = 0
    Dim NotAvailableProperty As Int64 = 0
    Dim sale As Int64 = 0
    Dim rent As Int64 = 0
    Dim notsale As Int64 = 0
    Dim notrent As Int64 = 0


    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Try
            Dim notAvailableQuery As String = "SELECT COUNT(*) as Not_Available FROM `property` WHERE property.Property_availability = 'Not Available';"
            Dim TotalQuery As String = "SELECT COUNT(*) as Total FROM `property`;"
            Using connection As New MySqlConnection(My.Settings.conPathDb)
                connection.Open()
                Using command As New MySqlCommand(notAvailableQuery, connection)
                    Dim reader As MySqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        NotAvailableProperty = Convert.ToInt64(reader("Not_Available"))
                    End If
                    reader.Close()
                End Using
                Using command As New MySqlCommand(TotalQuery, connection)
                    Dim reader As Object = command.ExecuteReader()
                    If reader.Read() Then
                        totalProperty = Convert.ToInt64(reader("Total"))
                    End If
                    reader.Close()
                End Using



                mtbTotalProperty.Value = mtbTotalProperty.Maximum - (mtbTotalProperty.Maximum * (NotAvailableProperty / totalProperty))
                cbtnTotalProperty.Text = mtbTotalProperty.Value & "%"
                lblTotalProperty.Text = totalProperty
                lblTarget.Text = NotAvailableProperty & " MORE TO BREAK LAST YEAR RECORD"



                Dim notSaleQuery As String = "SELECT COUNT(*) as sale FROM `property` WHERE property.Property_sale_rent = 'Sale' AND property.Property_availability = 'Not Available';"
                Dim notRentQuery As String = "SELECT COUNT(*) as rent FROM `property` WHERE property.Property_sale_rent = 'Rent' AND property.Property_availability = 'Not Available';"
                Using command As New MySqlCommand(notSaleQuery, connection)
                    Dim reader As MySqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        notsale = Convert.ToInt64(reader("sale"))
                    End If
                    reader.Close()
                End Using
                Using command As New MySqlCommand(notRentQuery, connection)
                    Dim reader As MySqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        notrent = Convert.ToInt64(reader("rent"))
                    End If
                    reader.Close()
                End Using


                Dim SaleQuery As String = "SELECT COUNT(*) as sale FROM `property` WHERE property.Property_sale_rent = 'Sale' AND property.Property_availability = 'Available';"
                Dim rentQuery As String = "SELECT COUNT(*) as rent FROM `property` WHERE property.Property_sale_rent = 'Rent' AND property.Property_availability = 'Available';"
                Using command As New MySqlCommand(SaleQuery, connection)
                    Dim reader As MySqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        sale = Convert.ToInt64(reader("sale"))
                    End If
                    reader.Close()
                End Using
                Using command As New MySqlCommand(rentQuery, connection)
                    Dim reader As MySqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        rent = Convert.ToInt64(reader("rent"))
                    End If
                    reader.Close()
                End Using

                lblTotalSale.Text = sale
                lblTotalRent.Text = rent
                cbtnTotalSale.Text = CInt(100 * (sale / (sale + notsale))) & "%"
                cbtnTotalRent.Text = CInt(100 * (rent / (rent + notrent))) & "%"

                lblTargetMonthSale.Text = "TARGET " & notsale + sale & " /MONTH"
                lblTargetMonthRent.Text = "TARGET " & notrent + rent & " /MONTH"
                lblTotalSaleOver.Text = sale + notsale
                lblTotalRentOver.Text = rent + notrent

                chaTotalSale.Series.Clear()
                chaTotalSale.Series.Add("sale")
                chaTotalSale.Series("sale").Points.AddY(sale)
                chaTotalSale.Series("sale").Points.AddY(notsale)
                chaTotalSale.Series("sale").ChartType = DataVisualization.Charting.SeriesChartType.Doughnut
                chaTotalSale.Series("sale").Points(0).Color = Color.Blue
                chaTotalSale.Series("sale").Points(1).Color = Color.Red

                chaTotalRent.Series.Clear()
                chaTotalRent.Series.Add("rent")
                chaTotalRent.Series("rent").Points.AddY(rent)
                chaTotalRent.Series("rent").Points.AddY(notrent)
                chaTotalRent.Series("rent").ChartType = DataVisualization.Charting.SeriesChartType.Doughnut
                chaTotalRent.Series("rent").Points(0).Color = Color.Blue
                chaTotalRent.Series("rent").Points(1).Color = Color.Red

                Dim totalRenu As String = "Select SUM(Transaction_amount) as total FROM `transaction`;"
                Using command As New MySqlCommand(totalRenu, connection)
                    Dim reader As MySqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        lblTotalRevenue.Text = "GHC " & Convert.ToDecimal(reader("total"))
                    End If
                    reader.Close()
                End Using

                Dim overviewSaleQuery As String = "SELECT monthname(t.Transaction_Date) as m, p.Property_sale_rent, sum(t.Transaction_amount) as s FROM transaction as t LEFT JOIN property as p on t.Property_Id = p.Property_Id WHERE p.Property_sale_rent = 'SALE' GROUP by m ORDER by m ;"
                Using command As New MySqlCommand(overviewSaleQuery, connection)
                    Dim reader As MySqlDataReader = command.ExecuteReader()

                    While reader.Read
                        chaOverview.Series("SALE").Points.AddXY(reader.GetString("m"), reader.GetDecimal("s"))
                    End While
                    reader.Close()
                End Using

                Dim overviewRentQuery As String = "SELECT monthname(t.Transaction_Date) as m, p.Property_sale_rent, sum(t.Transaction_amount) as s FROM transaction as t LEFT JOIN property as p on t.Property_Id = p.Property_Id WHERE p.Property_sale_rent = 'RENT' GROUP by m ORDER by m ;"
                Using command As New MySqlCommand(overviewRentQuery, connection)
                    Dim reader As MySqlDataReader = command.ExecuteReader()
                    While reader.Read
                        chaOverview.Series("RENT").Points.AddXY(reader.GetString("m"), reader.GetDecimal("s"))
                    End While
                    reader.Close()
                End Using

                Dim revenueQuery As String = "SELECT monthname(t.Transaction_Date) as m, p.Property_sale_rent, sum(t.Transaction_amount) as s FROM transaction as t LEFT JOIN property as p on t.Property_Id = p.Property_Id GROUP by m ORDER by m ;"
                Using command As New MySqlCommand(revenueQuery, connection)
                    Dim reader As MySqlDataReader = command.ExecuteReader()
                    While reader.Read
                        chaTotalRevenue.Series("REVENUE").Points.AddXY(reader.GetString("m"), reader.GetDecimal("s"))
                    End While
                    reader.Close()
                End Using

                Dim agentProSaleQuery As String = "SELECT user.lName, sum(transaction.Transaction_amount) as amount FROM `transaction` RIGHT JOIN user on user.User_Id = transaction.User_Id RIGHT JOIN property ON Property.Property_Id = transaction.Property_Id WHERE transaction.Transaction_status = 'Completed' AND property.Property_sale_rent ='SALE' GROUP by user.lName;"
                Using command As New MySqlCommand(agentProSaleQuery, connection)
                    Dim reader As MySqlDataReader = command.ExecuteReader()
                    chaAgentPerformRent.Series.Clear()
                    chaAgentPerformRent.Series.Add("rent")
                    While reader.Read
                        chaAgentPerformRent.Series("rent").Points.AddXY(reader.GetString("lName"), reader.GetDouble("amount"))
                    End While
                    chaAgentPerformRent.Series("rent").ChartType = DataVisualization.Charting.SeriesChartType.Pie
                    chaAgentPerformRent.Series(0).LabelFormat = "{#,##0}"
                    chaAgentPerformRent.Series(0).IsValueShownAsLabel = True
                    reader.Close()
                End Using

                Dim agentProRentQuery As String = "SELECT user.lName, sum(transaction.Transaction_amount) as amount FROM `transaction` RIGHT JOIN user on user.User_Id = transaction.User_Id RIGHT JOIN property ON Property.Property_Id = transaction.Property_Id WHERE transaction.Transaction_status = 'Completed' AND property.Property_sale_rent ='RENT' GROUP by user.lName;"
                Using command As New MySqlCommand(agentProRentQuery, connection)
                    Dim reader As MySqlDataReader = command.ExecuteReader()
                    chaAgentPerformSale.Series.Clear()
                    chaAgentPerformSale.Series.Add("sale")
                    While reader.Read
                        chaAgentPerformSale.Series("sale").Points.AddXY(reader.GetString("lName"), reader.GetDouble("amount"))
                    End While
                    chaAgentPerformSale.Series("sale").ChartType = DataVisualization.Charting.SeriesChartType.Pie
                    chaAgentPerformSale.Series(0).LabelFormat = "{#,##0}"
                    chaAgentPerformSale.Series(0).IsValueShownAsLabel = True
                    reader.Close()
                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try




    End Sub


End Class