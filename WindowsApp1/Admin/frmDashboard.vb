Imports WindowsApp1.Mode
Imports Guna.UI.WinForms
Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient
Imports System.IO

Public Class frmDashboard
    Dim closeMenu As Boolean = False
    Dim openPalSaleAndTransaction As Boolean = False
    Dim openPalPropertyTypesAndCategoriesMenu As Boolean = False
    Dim openPalClientAndOwner As Boolean = False
    Private checkMood As Boolean = Mode.checkMood
    Private mood As New Mode
    Public f As Form
    Public nav As Boolean = False
    Dim connection As MySqlConnection
    Public command As MySqlCommand
    Dim totalProperty As Int64 = 0
    Dim NotAvailableProperty As Int64 = 0
    Dim sale As Int64 = 0
    Dim rent As Int64 = 0
    Dim notsale As Int64 = 0
    Dim notrent As Int64 = 0
    Private log As String = Application.CommonAppDataPath & "\ Log.txt"
    Private menuWidth As Integer = 207
    Private animationStep As Integer = 15
    Private WithEvents animationTimer As New Timer With {.Interval = 10}

    Private Sub btnInsight_Click(sender As Object, e As EventArgs) Handles btnSaleAndManagement.Click
        nav = True
        btnClient.FillColor = Color.Transparent
        btnClientAndOwner.FillColor = Color.Transparent
        btnDashboard.FillColor = Color.Transparent
        btnAgentManagement.FillColor = Color.Transparent
        btnHouse.FillColor = Color.Transparent
        btnMenu.FillColor = Color.Transparent
        btnOwner.FillColor = Color.Transparent
        btnPropertyManagement.FillColor = Color.Transparent
        btnRent.FillColor = Color.Transparent
        btnSaleAndManagement.FillColor = Color.FromArgb(94, 148, 255)
        btnSales.FillColor = Color.Transparent
        btnSetting.FillColor = Color.Transparent
        btnTenantManagement.FillColor = Color.Transparent
        btnTransaction.FillColor = Color.Transparent
        btnPropertyTypeAndCategories.FillColor = Color.Transparent
        btnMaintenanceManagement.FillColor = Color.Transparent

        btnMaintenanceManagement.ForeColor = Color.Black
        btnPropertyTypeAndCategories.ForeColor = Color.Black
        btnClient.ForeColor = Color.Black
        btnClientAndOwner.ForeColor = Color.Black
        btnDashboard.ForeColor = Color.Black
        btnAgentManagement.ForeColor = Color.Black
        btnHouse.ForeColor = Color.Black
        btnMenu.ForeColor = Color.Black
        btnOwner.ForeColor = Color.Black
        btnPropertyManagement.ForeColor = Color.Black
        btnRent.ForeColor = Color.Black
        btnSaleAndManagement.ForeColor = Color.White
        btnSales.ForeColor = Color.Black
        btnSetting.ForeColor = Color.Black
        btnTenantManagement.ForeColor = Color.Black
        btnTransaction.ForeColor = Color.Black


        If openPalSaleAndTransaction Then
            palSaleAndTransaction.Height = 54
            palPropertyTypesAndCategoriesMenu.Top -= 66
            palClientAndOwner.Top -= 66
            openPalSaleAndTransaction = False
        Else

            If closeMenu = False Then
                animationTimer.Start()
            End If
            If openPalPropertyTypesAndCategoriesMenu Then
                openPalPropertyTypesAndCategoriesMenu = False
            End If
            If openPalClientAndOwner Then
                palPropertyTypesAndCategoriesMenu.Top -= 66
                openPalClientAndOwner = False
            End If
            palClientAndOwner.Height = 54
            palPropertyTypesAndCategoriesMenu.Height = 54
            palSaleAndTransaction.Height = 120
            palPropertyTypesAndCategoriesMenu.Top += 66
            palClientAndOwner.Top += 66
            openPalSaleAndTransaction = True
        End If


        Using writer As New StreamWriter(splash_screen.log.ToString, True)
            If splash_screen.lines < 1 Then
                writer.WriteLine("DATE TIME" & vbTab & vbTab & " ACTION" & vbTab & vbTab & vbTab & vbTab & " LOCATION")
            End If
            writer.WriteLine(Date.Now & vbTab & " Click on " & btnSaleAndManagement.Text & vbTab & Me.Text)
        End Using

    End Sub

    Private Sub btnHouse_Click(sender As Object, e As EventArgs) Handles btnClientAndOwner.Click
        nav = True

        btnClient.FillColor = Color.Transparent
        btnClientAndOwner.FillColor = Color.FromArgb(94, 148, 255)
        btnDashboard.FillColor = Color.Transparent
        btnAgentManagement.FillColor = Color.Transparent
        btnHouse.FillColor = Color.Transparent
        btnMenu.FillColor = Color.Transparent
        btnOwner.FillColor = Color.Transparent
        btnPropertyManagement.FillColor = Color.Transparent
        btnRent.FillColor = Color.Transparent
        btnSaleAndManagement.FillColor = Color.Transparent
        btnSales.FillColor = Color.Transparent
        btnSetting.FillColor = Color.Transparent
        btnTenantManagement.FillColor = Color.Transparent
        btnTransaction.FillColor = Color.Transparent
        btnPropertyTypeAndCategories.FillColor = Color.Transparent
        btnMaintenanceManagement.FillColor = Color.Transparent

        btnMaintenanceManagement.ForeColor = Color.Black
        btnPropertyTypeAndCategories.ForeColor = Color.Black
        btnClient.ForeColor = Color.Black
        btnClientAndOwner.ForeColor = Color.White
        btnDashboard.ForeColor = Color.Black
        btnAgentManagement.ForeColor = Color.Black
        btnHouse.ForeColor = Color.Black
        btnMenu.ForeColor = Color.Black
        btnOwner.ForeColor = Color.Black
        btnPropertyManagement.ForeColor = Color.Black
        btnRent.ForeColor = Color.Black
        btnSaleAndManagement.ForeColor = Color.Black
        btnSales.ForeColor = Color.Black
        btnSetting.ForeColor = Color.Black
        btnTenantManagement.ForeColor = Color.Black
        btnTransaction.ForeColor = Color.Black


        If openPalClientAndOwner Then
            palClientAndOwner.Height = 54
            palPropertyTypesAndCategoriesMenu.Top -= 66
            openPalClientAndOwner = False
        Else
            If closeMenu = False Then
                animationTimer.Start()
            End If
            If openPalPropertyTypesAndCategoriesMenu Then
                openPalPropertyTypesAndCategoriesMenu = False
            End If
            If openPalSaleAndTransaction Then
                palClientAndOwner.Top -= 66
                palPropertyTypesAndCategoriesMenu.Top -= 66
                openPalSaleAndTransaction = False
            End If

            palSaleAndTransaction.Height = 54
            palPropertyTypesAndCategoriesMenu.Height = 54
            palClientAndOwner.Height = 120
            palPropertyTypesAndCategoriesMenu.Top += 66
            openPalClientAndOwner = True
        End If

        Using writer As New StreamWriter(splash_screen.log.ToString, True)
            If splash_screen.lines < 1 Then
                writer.WriteLine("DATE TIME" & vbTab & vbTab & " ACTION" & vbTab & vbTab & vbTab & vbTab & " LOCATION")
            End If
            writer.WriteLine(Date.Now & vbTab & " Click on " & btnClientAndOwner.Text & vbTab & Me.Text)
        End Using
    End Sub


    Private Sub btnRent_Click(sender As Object, e As EventArgs) Handles btnPropertyTypeAndCategories.Click
        nav = True

        btnClient.FillColor = Color.Transparent
        btnClientAndOwner.FillColor = Color.Transparent
        btnDashboard.FillColor = Color.Transparent
        btnAgentManagement.FillColor = Color.Transparent
        btnHouse.FillColor = Color.Transparent
        btnMenu.FillColor = Color.Transparent
        btnOwner.FillColor = Color.Transparent
        btnPropertyManagement.FillColor = Color.Transparent
        btnRent.FillColor = Color.Transparent
        btnSaleAndManagement.FillColor = Color.Transparent
        btnSales.FillColor = Color.Transparent
        btnSetting.FillColor = Color.Transparent
        btnTenantManagement.FillColor = Color.Transparent
        btnTransaction.FillColor = Color.Transparent
        btnPropertyTypeAndCategories.FillColor = Color.FromArgb(94, 148, 255)
        btnMaintenanceManagement.FillColor = Color.Transparent

        btnMaintenanceManagement.ForeColor = Color.Black
        btnPropertyTypeAndCategories.ForeColor = Color.White
        btnClient.ForeColor = Color.Black
        btnClientAndOwner.ForeColor = Color.Black
        btnDashboard.ForeColor = Color.Black
        btnAgentManagement.ForeColor = Color.Black
        btnHouse.ForeColor = Color.Black
        btnMenu.ForeColor = Color.Black
        btnOwner.ForeColor = Color.Black
        btnPropertyManagement.ForeColor = Color.Black
        btnRent.ForeColor = Color.Black
        btnSaleAndManagement.ForeColor = Color.Black
        btnSales.ForeColor = Color.Black
        btnSetting.ForeColor = Color.Black
        btnTenantManagement.ForeColor = Color.Black
        btnTransaction.ForeColor = Color.Black


        If openPalPropertyTypesAndCategoriesMenu Then
            palPropertyTypesAndCategoriesMenu.Height = 54
            openPalPropertyTypesAndCategoriesMenu = False
        Else
            If closeMenu = False Then
                animationTimer.Start()
            End If
            If openPalSaleAndTransaction Then
                palClientAndOwner.Top -= 66
                palPropertyTypesAndCategoriesMenu.Top -= 66
                openPalSaleAndTransaction = False
            End If
            If openPalClientAndOwner Then
                palPropertyTypesAndCategoriesMenu.Top -= 66
                openPalClientAndOwner = False
            End If

            palClientAndOwner.Height = 54
            palSaleAndTransaction.Height = 54
            palPropertyTypesAndCategoriesMenu.Height = 130
            openPalPropertyTypesAndCategoriesMenu = True
        End If

        Using writer As New StreamWriter(splash_screen.log.ToString, True)
            If splash_screen.lines < 1 Then
                writer.WriteLine("DATE TIME" & vbTab & vbTab & " ACTION" & vbTab & vbTab & vbTab & vbTab & " LOCATION")
            End If
            writer.WriteLine(Date.Now & vbTab & " Click on " & btnPropertyTypeAndCategories.Text & vbTab & Me.Text)
        End Using
    End Sub

    Private Sub btnLand_Click(sender As Object, e As EventArgs) Handles btnTenantManagement.Click

        Using writer As New StreamWriter(splash_screen.log.ToString, True)
            If splash_screen.lines < 1 Then
                writer.WriteLine("DATE TIME" & vbTab & vbTab & " ACTION" & vbTab & vbTab & vbTab & vbTab & " LOCATION")
            End If
            writer.WriteLine(Date.Now & vbTab & " Click on " & btnTenantManagement.Text & vbTab & Me.Text)
        End Using

        If closeMenu = False Then
            animationTimer.Start()
        End If

        nav = True

        btnClient.FillColor = Color.Transparent
        btnClientAndOwner.FillColor = Color.Transparent
        btnDashboard.FillColor = Color.Transparent
        btnAgentManagement.FillColor = Color.Transparent
        btnHouse.FillColor = Color.Transparent
        btnMenu.FillColor = Color.Transparent
        btnOwner.FillColor = Color.Transparent
        btnPropertyManagement.FillColor = Color.Transparent
        btnRent.FillColor = Color.Transparent
        btnSaleAndManagement.FillColor = Color.Transparent
        btnSales.FillColor = Color.Transparent
        btnSetting.FillColor = Color.Transparent
        btnTenantManagement.FillColor = Color.FromArgb(94, 148, 255)
        btnTransaction.FillColor = Color.Transparent
        btnPropertyTypeAndCategories.FillColor = Color.Transparent
        btnMaintenanceManagement.FillColor = Color.Transparent

        btnMaintenanceManagement.ForeColor = Color.Black
        btnPropertyTypeAndCategories.ForeColor = Color.Black
        btnClient.ForeColor = Color.Black
        btnClientAndOwner.ForeColor = Color.Black
        btnDashboard.ForeColor = Color.Black
        btnAgentManagement.ForeColor = Color.Black
        btnHouse.ForeColor = Color.Black
        btnMenu.ForeColor = Color.Black
        btnOwner.ForeColor = Color.Black
        btnPropertyManagement.ForeColor = Color.Black
        btnRent.ForeColor = Color.Black
        btnSaleAndManagement.ForeColor = Color.Black
        btnSales.ForeColor = Color.Black
        btnSetting.ForeColor = Color.Black
        btnTenantManagement.ForeColor = Color.White
        btnTransaction.ForeColor = Color.Black


        LoadForm(New frmTenantManagement)
    End Sub

    Private Sub btnProduct_Click(sender As Object, e As EventArgs) Handles btnMaintenanceManagement.Click

        Using writer As New StreamWriter(splash_screen.log.ToString, True)
            If splash_screen.lines < 1 Then
                writer.WriteLine("DATE TIME" & vbTab & vbTab & " ACTION" & vbTab & vbTab & vbTab & vbTab & " LOCATION")
            End If
            writer.WriteLine(Date.Now & vbTab & " Click on " & btnMaintenanceManagement.Text & vbTab & Me.Text)
        End Using


        nav = True

        btnClient.FillColor = Color.Transparent
        btnClientAndOwner.FillColor = Color.Transparent
        btnDashboard.FillColor = Color.Transparent
        btnAgentManagement.FillColor = Color.Transparent
        btnHouse.FillColor = Color.Transparent
        btnMenu.FillColor = Color.Transparent
        btnOwner.FillColor = Color.Transparent
        btnPropertyManagement.FillColor = Color.Transparent
        btnRent.FillColor = Color.Transparent
        btnSaleAndManagement.FillColor = Color.Transparent
        btnSales.FillColor = Color.Transparent
        btnSetting.FillColor = Color.Transparent
        btnTenantManagement.FillColor = Color.Transparent
        btnTransaction.FillColor = Color.Transparent
        btnPropertyTypeAndCategories.FillColor = Color.Transparent
        btnMaintenanceManagement.FillColor = Color.FromArgb(94, 148, 255)

        btnMaintenanceManagement.ForeColor = Color.White
        btnPropertyTypeAndCategories.ForeColor = Color.Black
        btnClient.ForeColor = Color.Black
        btnClientAndOwner.ForeColor = Color.Black
        btnDashboard.ForeColor = Color.Black
        btnAgentManagement.ForeColor = Color.Black
        btnHouse.ForeColor = Color.Black
        btnMenu.ForeColor = Color.Black
        btnOwner.ForeColor = Color.Black
        btnPropertyManagement.ForeColor = Color.Black
        btnRent.ForeColor = Color.Black
        btnSaleAndManagement.ForeColor = Color.Black
        btnSales.ForeColor = Color.Black
        btnSetting.ForeColor = Color.Black
        btnTenantManagement.ForeColor = Color.Black
        btnTransaction.ForeColor = Color.Black

        LoadForm(New frmAgentMaintenance)

        If closeMenu = False Then
            animationTimer.Start()
        End If

    End Sub

    Private Sub btnInbox_Click(sender As Object, e As EventArgs) Handles btnAgentManagement.Click
        Using writer As New StreamWriter(splash_screen.log.ToString, True)
            If splash_screen.lines < 1 Then
                writer.WriteLine("DATE TIME" & vbTab & vbTab & " ACTION" & vbTab & vbTab & vbTab & vbTab & " LOCATION")
            End If
            writer.WriteLine(Date.Now & vbTab & " Click on " & btnAgentManagement.Text & vbTab & Me.Text)
        End Using

        If closeMenu = False Then
            animationTimer.Start()
        End If

        nav = True

        btnClient.FillColor = Color.Transparent
        btnClientAndOwner.FillColor = Color.Transparent
        btnDashboard.FillColor = Color.Transparent
        btnAgentManagement.FillColor = Color.FromArgb(94, 148, 255)
        btnHouse.FillColor = Color.Transparent
        btnMenu.FillColor = Color.Transparent
        btnOwner.FillColor = Color.Transparent
        btnPropertyManagement.FillColor = Color.Transparent
        btnRent.FillColor = Color.Transparent
        btnSaleAndManagement.FillColor = Color.Transparent
        btnSales.FillColor = Color.Transparent
        btnSetting.FillColor = Color.Transparent
        btnTenantManagement.FillColor = Color.Transparent
        btnTransaction.FillColor = Color.Transparent
        btnPropertyTypeAndCategories.FillColor = Color.Transparent
        btnMaintenanceManagement.FillColor = Color.Transparent

        btnMaintenanceManagement.ForeColor = Color.Black
        btnPropertyTypeAndCategories.ForeColor = Color.Black
        btnClient.ForeColor = Color.Black
        btnClientAndOwner.ForeColor = Color.Black
        btnDashboard.ForeColor = Color.Black
        btnAgentManagement.ForeColor = Color.White
        btnHouse.ForeColor = Color.Black
        btnMenu.ForeColor = Color.Black
        btnOwner.ForeColor = Color.Black
        btnPropertyManagement.ForeColor = Color.Black
        btnRent.ForeColor = Color.Black
        btnSaleAndManagement.ForeColor = Color.Black
        btnSales.ForeColor = Color.Black
        btnSetting.ForeColor = Color.Black
        btnTenantManagement.ForeColor = Color.Black
        btnTransaction.ForeColor = Color.Black

        LoadForm(New frmAgentManagement)
    End Sub

    Private Sub btnSetting_Click(sender As Object, e As EventArgs) Handles btnSetting.Click
        Using writer As New StreamWriter(splash_screen.log.ToString, True)
            If splash_screen.lines < 1 Then
                writer.WriteLine("DATE TIME" & vbTab & vbTab & " ACTION" & vbTab & vbTab & vbTab & vbTab & " LOCATION")
            End If
            writer.WriteLine(Date.Now & vbTab & " Click on " & btnSetting.Text & vbTab & Me.Text)
        End Using

        If closeMenu = False Then
            animationTimer.Start()
        End If

        nav = True

        btnClient.FillColor = Color.Transparent
        btnClientAndOwner.FillColor = Color.Transparent
        btnDashboard.FillColor = Color.Transparent
        btnAgentManagement.FillColor = Color.Transparent
        btnHouse.FillColor = Color.Transparent
        btnMenu.FillColor = Color.Transparent
        btnOwner.FillColor = Color.Transparent
        btnPropertyManagement.FillColor = Color.Transparent
        btnRent.FillColor = Color.Transparent
        btnSaleAndManagement.FillColor = Color.Transparent
        btnSales.FillColor = Color.Transparent
        btnSetting.FillColor = Color.FromArgb(94, 148, 255)
        btnTenantManagement.FillColor = Color.Transparent
        btnTransaction.FillColor = Color.Transparent
        btnPropertyTypeAndCategories.FillColor = Color.Transparent
        btnMaintenanceManagement.FillColor = Color.Transparent

        btnMaintenanceManagement.ForeColor = Color.Black
        btnPropertyTypeAndCategories.ForeColor = Color.Black
        btnClient.ForeColor = Color.Black
        btnClientAndOwner.ForeColor = Color.Black
        btnDashboard.ForeColor = Color.Black
        btnAgentManagement.ForeColor = Color.Black
        btnHouse.ForeColor = Color.Black
        btnMenu.ForeColor = Color.Black
        btnOwner.ForeColor = Color.Black
        btnPropertyManagement.ForeColor = Color.Black
        btnRent.ForeColor = Color.Black
        btnSaleAndManagement.ForeColor = Color.Black
        btnSales.ForeColor = Color.Black
        btnSetting.ForeColor = Color.White
        btnTenantManagement.ForeColor = Color.Black
        btnTransaction.ForeColor = Color.Black

        LoadForm(New frmSetting)
    End Sub


    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Using writer As New StreamWriter(splash_screen.log.ToString, True)
            If splash_screen.lines < 1 Then
                writer.WriteLine("DATE TIME" & vbTab & vbTab & " ACTION" & vbTab & vbTab & vbTab & vbTab & " LOCATION")
            End If
            writer.WriteLine(Date.Now & vbTab & " Click on " & btnLogOut.Text & vbTab & Me.Text)
        End Using


        user_role = ""
        username = ""
        UserId = 0

        Me.Close()
        frmsignIn.Show()
    End Sub

    Private Sub btnMood_Click(sender As Object, e As EventArgs) Handles btnMode.Click
        Using writer As New StreamWriter(splash_screen.log.ToString, True)
            If splash_screen.lines < 1 Then
                writer.WriteLine("DATE TIME" & vbTab & vbTab & " ACTION" & vbTab & vbTab & vbTab & vbTab & " LOCATION")
            End If
            writer.WriteLine(Date.Now & vbTab & " Click on Mode button" & vbTab & Me.Text)
        End Using

        ModeChange()
        If nav Then
            ChangePanelControlsColor(f)
        End If
    End Sub

    Public Sub ModeChange()
        If Not Mode.checkMood Then
            Mode.checkMood = True
            palMainFrame.BackColor = Color.FromArgb(64, 64, 64)
            palHeader.BackColor = Color.FromArgb(64, 64, 64)
            lblUsername.ForeColor = Color.White
            btnMode.Image = My.Resources._045_sunny_3

            btnMode.HoverState.Image = My.Resources._045_sunny_3
            lblTitle.ForeColor = Color.White
            lblWelcome.ForeColor = Color.White


        Else
            Mode.checkMood = False
            palMainFrame.BackColor = Color.FromKnownColor(KnownColor.Control)
            palHeader.BackColor = Color.FromKnownColor(KnownColor.Control)
            lblUsername.ForeColor = Color.Black
            btnMode.Image = My.Resources.moon__1_

            btnMode.HoverState.Image = My.Resources.moon
            lblTitle.ForeColor = Color.Black
            lblWelcome.ForeColor = Color.Black

        End If
    End Sub


    Public Sub ChangePanelControlsColor(panel As Form)
        If Mode.checkMood Then
            For Each control As Control In panel.Controls
                If TypeOf control Is Label Then
                    DirectCast(control, Label).ForeColor = Color.White
                End If
                If TypeOf control Is TabControl Then
                    Dim tabControl As TabControl = DirectCast(control, TabControl)
                    tabControl.BackColor = Color.FromArgb(64, 64, 64)
                    For Each tabPage As TabPage In tabControl.TabPages
                        tabPage.BackColor = Color.FromArgb(64, 64, 64)
                        tabPage.ForeColor = Color.White
                        For Each tabControlLabel As Control In tabPage.Controls
                            If TypeOf tabControlLabel Is GunaLineTextBox Then
                                DirectCast(tabControlLabel, GunaLineTextBox).ForeColor = Color.Black
                            End If
                            If TypeOf tabControlLabel Is GunaLabel Then
                                DirectCast(tabControlLabel, GunaLabel).ForeColor = Color.White
                            End If
                            If TypeOf tabControlLabel Is Guna2HtmlLabel Then
                                DirectCast(tabControlLabel, Guna2HtmlLabel).ForeColor = Color.White
                            End If
                            If TypeOf tabControlLabel Is DataGridView Then
                                Dim dataGridView As DataGridView = DirectCast(tabControlLabel, DataGridView)
                                dataGridView.ForeColor = Color.White
                                dataGridView.BackgroundColor = Color.FromArgb(64, 64, 64)
                                dataGridView.DefaultCellStyle.BackColor = Color.FromArgb(64, 64, 64)
                                dataGridView.DefaultCellStyle.ForeColor = Color.White
                            End If
                            If TypeOf tabControlLabel Is DataGridTextBox Then
                                DirectCast(tabControlLabel, DataGridTextBox).ForeColor = Color.White
                            End If

                        Next
                    Next
                End If
                If TypeOf control Is RadioButton Then
                    DirectCast(control, RadioButton).ForeColor = Color.White
                End If
                If TypeOf control Is DataGridView Then
                    DirectCast(control, DataGridView).ForeColor = Color.White
                End If
                If TypeOf control Is DataGridView Then
                    DirectCast(control, DataGridView).BackgroundColor = Color.FromArgb(64, 64, 64)
                End If
                If TypeOf control Is GunaLineTextBox Then
                    DirectCast(control, GunaLineTextBox).ForeColor = Color.Black
                End If
                If TypeOf control Is TextBox Then
                    DirectCast(control, TextBox).ForeColor = Color.Black
                End If
                If TypeOf control Is DataGridView Then
                    Dim dataGridView As DataGridView = DirectCast(control, DataGridView)
                    dataGridView.ForeColor = Color.White
                    dataGridView.BackgroundColor = Color.FromArgb(64, 64, 64)
                    dataGridView.DefaultCellStyle.BackColor = Color.FromArgb(64, 64, 64)
                    dataGridView.DefaultCellStyle.ForeColor = Color.White
                End If
                If TypeOf control Is DataGridTextBox Then
                    DirectCast(control, DataGridTextBox).ForeColor = Color.White
                End If
            Next
            panel.BackColor = Color.FromArgb(64, 64, 64)
        Else
            For Each control As Control In panel.Controls
                If TypeOf control Is Label Then
                    DirectCast(control, Label).ForeColor = Color.Black
                End If
                If TypeOf control Is TabControl Then
                    Dim tabControl As TabControl = DirectCast(control, TabControl)
                    tabControl.BackColor = Color.FromKnownColor(KnownColor.Control)
                    For Each tabPage As TabPage In tabControl.TabPages
                        tabPage.BackColor = Color.FromKnownColor(KnownColor.Control)
                        tabPage.ForeColor = Color.Black
                        For Each tabControlLabel As Control In tabPage.Controls
                            If TypeOf tabControlLabel Is GunaLineTextBox Then
                                DirectCast(tabControlLabel, GunaLineTextBox).ForeColor = Color.Black
                            End If
                            If TypeOf tabControlLabel Is GunaLabel Then
                                DirectCast(tabControlLabel, GunaLabel).ForeColor = Color.Black
                            End If
                            If TypeOf tabControlLabel Is Guna2HtmlLabel Then
                                DirectCast(tabControlLabel, Guna2HtmlLabel).ForeColor = Color.Black
                            End If
                            If TypeOf tabControlLabel Is Guna2HtmlLabel Then
                                DirectCast(tabControlLabel, Guna2HtmlLabel).ForeColor = Color.Black
                            End If

                            If TypeOf tabControlLabel Is DataGridView Then
                                Dim dataGridView As DataGridView = DirectCast(tabControlLabel, DataGridView)
                                dataGridView.ForeColor = Color.Black
                                dataGridView.BackgroundColor = Color.FromKnownColor(KnownColor.Control)
                                dataGridView.DefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.Control)
                                dataGridView.DefaultCellStyle.ForeColor = Color.Black
                            End If
                            If TypeOf tabControlLabel Is DataGridTextBox Then
                                DirectCast(tabControlLabel, DataGridTextBox).ForeColor = Color.Black
                            End If

                        Next
                    Next
                End If
                If TypeOf control Is RadioButton Then
                    DirectCast(control, RadioButton).ForeColor = Color.Black
                End If
                If TypeOf control Is GunaLineTextBox Then
                    DirectCast(control, GunaLineTextBox).ForeColor = Color.Black
                End If
                If TypeOf control Is DataGridView Then
                    DirectCast(control, DataGridView).ForeColor = Color.Black
                End If
                If TypeOf control Is DataGridView Then
                    DirectCast(control, DataGridView).BackgroundColor = Color.FromKnownColor(KnownColor.Control)
                End If
                If TypeOf control Is TextBox Then
                    DirectCast(control, TextBox).ForeColor = Color.Black
                End If

                If TypeOf control Is DataGridView Then
                    Dim dataGridView As DataGridView = DirectCast(control, DataGridView)
                    dataGridView.ForeColor = Color.Black
                    dataGridView.BackgroundColor = Color.FromKnownColor(KnownColor.Control)
                    dataGridView.DefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.Control)
                    dataGridView.DefaultCellStyle.ForeColor = Color.Black
                End If
                If TypeOf control Is DataGridTextBox Then
                    DirectCast(control, DataGridTextBox).ForeColor = Color.Black
                End If

            Next
            panel.BackColor = Color.FromKnownColor(KnownColor.Control)
        End If
    End Sub

    Private Sub btnDropDown_Click(sender As Object, e As EventArgs) Handles btnDropDown.Click
        Using writer As New StreamWriter(splash_screen.log.ToString, True)
            If splash_screen.lines < 1 Then
                writer.WriteLine("DATE TIME" & vbTab & vbTab & " ACTION" & vbTab & vbTab & vbTab & vbTab & " LOCATION")
            End If
            writer.WriteLine(Date.Now & vbTab & " Click on Drop Down button " & vbTab & Me.Text)
        End Using
    End Sub

    Public Sub LoadForm(ByVal form As Object)
        For Each co In Me.palMainFrame.Controls
            If Me.palMainFrame.Controls.Count > 0 Then
                Me.palMainFrame.Controls.RemoveAt(0)
            End If
        Next
        f = TryCast(form, Form)
        f.TopLevel = False
        f.Dock = DockStyle.Fill
        f.Name = "palFrame"
        Me.palMainFrame.Controls.Add(f)

        If Mode.checkMood Then
            For Each control As Control In f.Controls
                If TypeOf control Is Label Then
                    DirectCast(control, Label).ForeColor = Color.White
                End If
                If TypeOf control Is TabControl Then
                    Dim tabControl As TabControl = DirectCast(control, TabControl)
                    tabControl.BackColor = Color.FromArgb(64, 64, 64)
                    For Each tabPage As TabPage In tabControl.TabPages
                        tabPage.BackColor = Color.FromArgb(64, 64, 64)
                        tabPage.ForeColor = Color.White
                        For Each tabControlLabel As Control In tabPage.Controls
                            If TypeOf tabControlLabel Is GunaLineTextBox Then
                                DirectCast(tabControlLabel, GunaLineTextBox).ForeColor = Color.Black
                            End If
                            If TypeOf tabControlLabel Is GunaLabel Then
                                DirectCast(tabControlLabel, GunaLabel).ForeColor = Color.White
                            End If
                            If TypeOf tabControlLabel Is Guna2HtmlLabel Then
                                DirectCast(tabControlLabel, Guna2HtmlLabel).ForeColor = Color.White
                            End If

                            If TypeOf tabControlLabel Is DataGridView Then
                                Dim dataGridView As DataGridView = DirectCast(tabControlLabel, DataGridView)
                                dataGridView.ForeColor = Color.White
                                dataGridView.BackgroundColor = Color.FromArgb(64, 64, 64)
                                dataGridView.DefaultCellStyle.BackColor = Color.FromArgb(64, 64, 64)
                                dataGridView.DefaultCellStyle.ForeColor = Color.White
                            End If
                            If TypeOf tabControlLabel Is DataGridTextBox Then
                                DirectCast(tabControlLabel, DataGridTextBox).ForeColor = Color.White
                            End If

                        Next
                    Next
                End If
                If TypeOf control Is DataGridView Then
                    Dim dataGridView As DataGridView = DirectCast(control, DataGridView)
                    dataGridView.ForeColor = Color.White
                    dataGridView.BackgroundColor = Color.FromArgb(64, 64, 64)
                    dataGridView.DefaultCellStyle.BackColor = Color.FromArgb(64, 64, 64)
                    dataGridView.DefaultCellStyle.ForeColor = Color.White
                End If
                If TypeOf control Is DataGridTextBox Then
                    DirectCast(control, DataGridTextBox).ForeColor = Color.White
                End If
            Next
            f.BackColor = Color.FromArgb(64, 64, 64)
        Else
            For Each control As Control In f.Controls
                If TypeOf control Is Label Then
                    DirectCast(control, Label).ForeColor = Color.Black
                End If
                If TypeOf control Is TabControl Then
                    Dim tabControl As TabControl = DirectCast(control, TabControl)
                    tabControl.BackColor = Color.FromKnownColor(KnownColor.Control)
                    For Each tabPage As TabPage In tabControl.TabPages
                        tabPage.BackColor = Color.FromKnownColor(KnownColor.Control)
                        tabPage.ForeColor = Color.Black
                        For Each tabControlLabel As Control In tabPage.Controls
                            If TypeOf tabControlLabel Is GunaLineTextBox Then
                                DirectCast(tabControlLabel, GunaLineTextBox).ForeColor = Color.Black
                            End If
                            If TypeOf tabControlLabel Is GunaLabel Then
                                DirectCast(tabControlLabel, GunaLabel).ForeColor = Color.Black
                            End If
                            If TypeOf tabControlLabel Is Guna2HtmlLabel Then
                                DirectCast(tabControlLabel, Guna2HtmlLabel).ForeColor = Color.Black
                            End If

                            If TypeOf tabControlLabel Is DataGridView Then
                                Dim dataGridView As DataGridView = DirectCast(tabControlLabel, DataGridView)
                                dataGridView.ForeColor = Color.Black
                                dataGridView.BackgroundColor = Color.FromKnownColor(KnownColor.Control)
                                dataGridView.DefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.Control)
                                dataGridView.DefaultCellStyle.ForeColor = Color.Black
                            End If
                            If TypeOf tabControlLabel Is DataGridTextBox Then
                                DirectCast(tabControlLabel, DataGridTextBox).ForeColor = Color.Black
                            End If


                        Next
                    Next
                End If

                If TypeOf control Is DataGridView Then
                    Dim dataGridView As DataGridView = DirectCast(control, DataGridView)
                    dataGridView.ForeColor = Color.Black
                    dataGridView.BackgroundColor = Color.FromKnownColor(KnownColor.Control)
                    dataGridView.DefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.Control)
                    dataGridView.DefaultCellStyle.ForeColor = Color.Black
                End If
                If TypeOf control Is DataGridTextBox Then
                    DirectCast(control, DataGridTextBox).ForeColor = Color.Black
                End If

            Next
            f.BackColor = Color.FromKnownColor(KnownColor.Control)
        End If

        Me.palMainFrame.Tag = f
        f.Show()
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Using writer As New StreamWriter(splash_screen.log.ToString, True)
            If splash_screen.lines < 1 Then
                writer.WriteLine("DATE TIME" & vbTab & vbTab & " ACTION" & vbTab & vbTab & vbTab & vbTab & " LOCATION")
            End If
            writer.WriteLine(Date.Now & vbTab & " Click on " & btnMenu.Text & vbTab & Me.Text)
        End Using

        animationTimer.Start()
        If openPalSaleAndTransaction Then
            palSaleAndTransaction.Height = 54
            palPropertyTypesAndCategoriesMenu.Top -= 66
            palClientAndOwner.Top -= 66
            openPalSaleAndTransaction = False
        End If
        If openPalClientAndOwner Then
            palClientAndOwner.Height = 54
            palPropertyTypesAndCategoriesMenu.Top -= 66
            openPalClientAndOwner = False
        End If
        If openPalPropertyTypesAndCategoriesMenu Then
            palPropertyTypesAndCategoriesMenu.Height = 54
            openPalPropertyTypesAndCategoriesMenu = False
        End If
    End Sub


    Private Sub animationTimer_Tick(sender As Object, e As EventArgs) Handles animationTimer.Tick
        If closeMenu Then
            ' Close the menu
            If palMenu.Width > 40 Then
                palMenu.Width -= animationStep
                If palMenu.Width <= 40 Then
                    palMenu.Width = 40
                    animationTimer.Stop()
                    closeMenu = False
                    btnMenu.Image = My.Resources._004_menu_2
                End If
            End If
        Else
            ' Open the menu
            If palMenu.Width < menuWidth Then
                palMenu.Width += animationStep
                If palMenu.Width >= menuWidth Then
                    palMenu.Width = menuWidth
                    animationTimer.Stop()
                    closeMenu = True
                    btnMenu.Image = My.Resources._018_close_4
                End If
            End If
        End If
    End Sub


    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Using writer As New StreamWriter(splash_screen.log.ToString, True)
            If splash_screen.lines < 1 Then
                writer.WriteLine("DATE TIME" & vbTab & vbTab & " ACTION" & vbTab & vbTab & vbTab & vbTab & " LOCATION")
            End If
            writer.WriteLine(Date.Now & vbTab & " Click on " & btnDashboard.Text & vbTab & Me.Text)
        End Using
        If closeMenu = False Then
            animationTimer.Start()
        End If
        nav = True

        btnClient.FillColor = Color.Transparent
        btnClientAndOwner.FillColor = Color.Transparent
        btnDashboard.FillColor = Color.FromArgb(94, 148, 255)
        btnAgentManagement.FillColor = Color.Transparent
        btnHouse.FillColor = Color.Transparent
        btnMenu.FillColor = Color.Transparent
        btnOwner.FillColor = Color.Transparent
        btnPropertyManagement.FillColor = Color.Transparent
        btnRent.FillColor = Color.Transparent
        btnSaleAndManagement.FillColor = Color.Transparent
        btnSales.FillColor = Color.Transparent
        btnSetting.FillColor = Color.Transparent
        btnTenantManagement.FillColor = Color.Transparent
        btnTransaction.FillColor = Color.Transparent
        btnPropertyTypeAndCategories.FillColor = Color.Transparent
        btnMaintenanceManagement.FillColor = Color.Transparent

        btnMaintenanceManagement.ForeColor = Color.Black
        btnPropertyTypeAndCategories.ForeColor = Color.Black
        btnClient.ForeColor = Color.Black
        btnClientAndOwner.ForeColor = Color.Black
        btnDashboard.ForeColor = Color.White
        btnAgentManagement.ForeColor = Color.Black
        btnHouse.ForeColor = Color.Black
        btnMenu.ForeColor = Color.Black
        btnOwner.ForeColor = Color.Black
        btnPropertyManagement.ForeColor = Color.Black
        btnRent.ForeColor = Color.Black
        btnSaleAndManagement.ForeColor = Color.Black
        btnSales.ForeColor = Color.Black
        btnSetting.ForeColor = Color.Black
        btnTenantManagement.ForeColor = Color.Black
        btnTransaction.ForeColor = Color.Black

        LoadForm(New frmDash)
    End Sub

    Private Sub btnPropertyManagement_Click(sender As Object, e As EventArgs) Handles btnPropertyManagement.Click

        Using writer As New StreamWriter(splash_screen.log.ToString, True)
            If splash_screen.lines < 1 Then
                writer.WriteLine("DATE TIME" & vbTab & vbTab & " ACTION" & vbTab & vbTab & vbTab & vbTab & " LOCATION")
            End If
            writer.WriteLine(Date.Now & vbTab & " Click on " & btnPropertyManagement.Text & vbTab & Me.Text)
        End Using

        If closeMenu = False Then
            animationTimer.Start()
        End If
        nav = True

        btnClient.FillColor = Color.Transparent
        btnClientAndOwner.FillColor = Color.Transparent
        btnDashboard.FillColor = Color.Transparent
        btnAgentManagement.FillColor = Color.Transparent
        btnHouse.FillColor = Color.Transparent
        btnMenu.FillColor = Color.Transparent
        btnOwner.FillColor = Color.Transparent
        btnPropertyManagement.FillColor = Color.FromArgb(94, 148, 255)
        btnRent.FillColor = Color.Transparent
        btnSaleAndManagement.FillColor = Color.Transparent
        btnSales.FillColor = Color.Transparent
        btnSetting.FillColor = Color.Transparent
        btnTenantManagement.FillColor = Color.Transparent
        btnTransaction.FillColor = Color.Transparent
        btnPropertyTypeAndCategories.FillColor = Color.Transparent
        btnMaintenanceManagement.FillColor = Color.Transparent

        btnMaintenanceManagement.ForeColor = Color.Black
        btnPropertyTypeAndCategories.ForeColor = Color.Black
        btnClient.ForeColor = Color.Black
        btnClientAndOwner.ForeColor = Color.Black
        btnDashboard.ForeColor = Color.Black
        btnAgentManagement.ForeColor = Color.Black
        btnHouse.ForeColor = Color.Black
        btnMenu.ForeColor = Color.Black
        btnOwner.ForeColor = Color.Black
        btnPropertyManagement.ForeColor = Color.White
        btnRent.ForeColor = Color.Black
        btnSaleAndManagement.ForeColor = Color.Black
        btnSales.ForeColor = Color.Black
        btnSetting.ForeColor = Color.Black
        btnTenantManagement.ForeColor = Color.Black
        btnTransaction.ForeColor = Color.Black

        LoadForm(New frmPropertyManagement)
    End Sub

    Private Sub btnRent_Click_1(sender As Object, e As EventArgs) Handles btnRent.Click

        Using writer As New StreamWriter(splash_screen.log.ToString, True)
            If splash_screen.lines < 1 Then
                writer.WriteLine("DATE TIME" & vbTab & vbTab & " ACTION" & vbTab & vbTab & vbTab & vbTab & " LOCATION")
            End If
            writer.WriteLine(Date.Now & vbTab & " Click on " & btnRent.Text & vbTab & Me.Text)
        End Using

        nav = True

        btnClient.FillColor = Color.Transparent
        btnClientAndOwner.FillColor = Color.Transparent
        btnDashboard.FillColor = Color.Transparent
        btnAgentManagement.FillColor = Color.Transparent
        btnHouse.FillColor = Color.Transparent
        btnMenu.FillColor = Color.Transparent
        btnOwner.FillColor = Color.Transparent
        btnPropertyManagement.FillColor = Color.Transparent
        btnRent.FillColor = Color.FromArgb(94, 148, 255)
        btnSaleAndManagement.FillColor = Color.Transparent
        btnSales.FillColor = Color.Transparent
        btnSetting.FillColor = Color.Transparent
        btnTenantManagement.FillColor = Color.Transparent
        btnTransaction.FillColor = Color.Transparent
        btnPropertyTypeAndCategories.FillColor = Color.FromArgb(94, 148, 255)
        btnMaintenanceManagement.FillColor = Color.Transparent

        btnMaintenanceManagement.ForeColor = Color.Black
        btnPropertyTypeAndCategories.ForeColor = Color.White
        btnClient.ForeColor = Color.Black
        btnClientAndOwner.ForeColor = Color.Black
        btnDashboard.ForeColor = Color.Black
        btnAgentManagement.ForeColor = Color.Black
        btnHouse.ForeColor = Color.Black
        btnMenu.ForeColor = Color.Black
        btnOwner.ForeColor = Color.Black
        btnPropertyManagement.ForeColor = Color.Black
        btnRent.ForeColor = Color.White
        btnSaleAndManagement.ForeColor = Color.Black
        btnSales.ForeColor = Color.Black
        btnSetting.ForeColor = Color.Black
        btnTenantManagement.ForeColor = Color.Black
        btnTransaction.ForeColor = Color.Black

        LoadForm(New frmRent)
    End Sub

    Private Sub btnHouse_Click_1(sender As Object, e As EventArgs) Handles btnHouse.Click
        Using writer As New StreamWriter(splash_screen.log.ToString, True)
            If splash_screen.lines < 1 Then
                writer.WriteLine("DATE TIME" & vbTab & vbTab & " ACTION" & vbTab & vbTab & vbTab & vbTab & " LOCATION")
            End If
            writer.WriteLine(Date.Now & vbTab & " Click on " & btnHouse.Text & vbTab & Me.Text)
        End Using

        nav = True

        btnClient.FillColor = Color.Transparent
        btnClientAndOwner.FillColor = Color.Transparent
        btnDashboard.FillColor = Color.Transparent
        btnAgentManagement.FillColor = Color.Transparent
        btnHouse.FillColor = Color.FromArgb(94, 148, 255)
        btnMenu.FillColor = Color.Transparent
        btnOwner.FillColor = Color.Transparent
        btnPropertyManagement.FillColor = Color.Transparent
        btnRent.FillColor = Color.Transparent
        btnSaleAndManagement.FillColor = Color.Transparent
        btnSales.FillColor = Color.Transparent
        btnSetting.FillColor = Color.Transparent
        btnTenantManagement.FillColor = Color.Transparent
        btnTransaction.FillColor = Color.Transparent
        btnPropertyTypeAndCategories.FillColor = Color.FromArgb(94, 148, 255)
        btnMaintenanceManagement.FillColor = Color.Transparent

        btnMaintenanceManagement.ForeColor = Color.Black
        btnPropertyTypeAndCategories.ForeColor = Color.White
        btnClient.ForeColor = Color.Black
        btnClientAndOwner.ForeColor = Color.Black
        btnDashboard.ForeColor = Color.Black
        btnAgentManagement.ForeColor = Color.Black
        btnHouse.ForeColor = Color.White
        btnMenu.ForeColor = Color.Black
        btnOwner.ForeColor = Color.Black
        btnPropertyManagement.ForeColor = Color.Black
        btnRent.ForeColor = Color.Black
        btnSaleAndManagement.ForeColor = Color.Black
        btnSales.ForeColor = Color.Black
        btnSetting.ForeColor = Color.Black
        btnTenantManagement.ForeColor = Color.Black
        btnTransaction.ForeColor = Color.Black

        LoadForm(New frmHouse)
    End Sub

    Private Sub btnClient_Click(sender As Object, e As EventArgs) Handles btnClient.Click
        Using writer As New StreamWriter(splash_screen.log.ToString, True)
            If splash_screen.lines < 1 Then
                writer.WriteLine("DATE TIME" & vbTab & vbTab & " ACTION" & vbTab & vbTab & vbTab & vbTab & " LOCATION")
            End If
            writer.WriteLine(Date.Now & vbTab & " Click on " & btnClient.Text & vbTab & Me.Text)
        End Using

        nav = True

        btnClient.FillColor = Color.FromArgb(94, 148, 255)
        btnClientAndOwner.FillColor = Color.FromArgb(94, 148, 255)
        btnDashboard.FillColor = Color.Transparent
        btnAgentManagement.FillColor = Color.Transparent
        btnHouse.FillColor = Color.Transparent
        btnMenu.FillColor = Color.Transparent
        btnOwner.FillColor = Color.Transparent
        btnPropertyManagement.FillColor = Color.Transparent
        btnRent.FillColor = Color.Transparent
        btnSaleAndManagement.FillColor = Color.Transparent
        btnSales.FillColor = Color.Transparent
        btnSetting.FillColor = Color.Transparent
        btnTenantManagement.FillColor = Color.Transparent
        btnTransaction.FillColor = Color.Transparent
        btnPropertyTypeAndCategories.FillColor = Color.Transparent
        btnMaintenanceManagement.FillColor = Color.Transparent

        btnMaintenanceManagement.ForeColor = Color.Black
        btnPropertyTypeAndCategories.ForeColor = Color.Black
        btnClient.ForeColor = Color.White
        btnClientAndOwner.ForeColor = Color.White
        btnDashboard.ForeColor = Color.Black
        btnAgentManagement.ForeColor = Color.Black
        btnHouse.ForeColor = Color.Black
        btnMenu.ForeColor = Color.Black
        btnOwner.ForeColor = Color.Black
        btnPropertyManagement.ForeColor = Color.Black
        btnRent.ForeColor = Color.Black
        btnSaleAndManagement.ForeColor = Color.Black
        btnSales.ForeColor = Color.Black
        btnSetting.ForeColor = Color.Black
        btnTenantManagement.ForeColor = Color.Black
        btnTransaction.ForeColor = Color.Black

        LoadForm(New frmClient)
    End Sub

    Private Sub btnOwner_Click(sender As Object, e As EventArgs) Handles btnOwner.Click

        Using writer As New StreamWriter(splash_screen.log.ToString, True)
            If splash_screen.lines < 1 Then
                writer.WriteLine("DATE TIME" & vbTab & vbTab & " ACTION" & vbTab & vbTab & vbTab & vbTab & " LOCATION")
            End If
            writer.WriteLine(Date.Now & vbTab & " Click on " & btnOwner.Text & vbTab & Me.Text)
        End Using

        nav = True

        btnClient.FillColor = Color.Transparent
        btnClientAndOwner.FillColor = Color.FromArgb(94, 148, 255)
        btnDashboard.FillColor = Color.Transparent
        btnAgentManagement.FillColor = Color.Transparent
        btnHouse.FillColor = Color.Transparent
        btnMenu.FillColor = Color.Transparent
        btnOwner.FillColor = Color.FromArgb(94, 148, 255)
        btnPropertyManagement.FillColor = Color.Transparent
        btnRent.FillColor = Color.Transparent
        btnSaleAndManagement.FillColor = Color.Transparent
        btnSales.FillColor = Color.Transparent
        btnSetting.FillColor = Color.Transparent
        btnTenantManagement.FillColor = Color.Transparent
        btnTransaction.FillColor = Color.Transparent
        btnPropertyTypeAndCategories.FillColor = Color.Transparent
        btnMaintenanceManagement.FillColor = Color.Transparent

        btnMaintenanceManagement.ForeColor = Color.Black
        btnPropertyTypeAndCategories.ForeColor = Color.Black
        btnClient.ForeColor = Color.Black
        btnClientAndOwner.ForeColor = Color.White
        btnDashboard.ForeColor = Color.Black
        btnAgentManagement.ForeColor = Color.Black
        btnHouse.ForeColor = Color.Black
        btnMenu.ForeColor = Color.Black
        btnOwner.ForeColor = Color.White
        btnPropertyManagement.ForeColor = Color.Black
        btnRent.ForeColor = Color.Black
        btnSaleAndManagement.ForeColor = Color.Black
        btnSales.ForeColor = Color.Black
        btnSetting.ForeColor = Color.Black
        btnTenantManagement.ForeColor = Color.Black
        btnTransaction.ForeColor = Color.Black


        LoadForm(New frmOwner)
    End Sub

    Private Sub btnSales_Click(sender As Object, e As EventArgs) Handles btnSales.Click
        Using writer As New StreamWriter(splash_screen.log.ToString, True)
            If splash_screen.lines < 1 Then
                writer.WriteLine("DATE TIME" & vbTab & vbTab & " ACTION" & vbTab & vbTab & vbTab & vbTab & " LOCATION")
            End If
            writer.WriteLine(Date.Now & vbTab & " Click on " & btnSales.Text & vbTab & Me.Text)
        End Using

        nav = True

        btnClient.FillColor = Color.Transparent
        btnClientAndOwner.FillColor = Color.Transparent
        btnDashboard.FillColor = Color.Transparent
        btnAgentManagement.FillColor = Color.Transparent
        btnHouse.FillColor = Color.Transparent
        btnMenu.FillColor = Color.Transparent
        btnOwner.FillColor = Color.Transparent
        btnPropertyManagement.FillColor = Color.Transparent
        btnRent.FillColor = Color.Transparent
        btnSaleAndManagement.FillColor = Color.FromArgb(94, 148, 255)
        btnSales.FillColor = Color.FromArgb(94, 148, 255)
        btnSetting.FillColor = Color.Transparent
        btnTenantManagement.FillColor = Color.Transparent
        btnTransaction.FillColor = Color.Transparent
        btnPropertyTypeAndCategories.FillColor = Color.Transparent
        btnMaintenanceManagement.FillColor = Color.Transparent

        btnMaintenanceManagement.ForeColor = Color.Black
        btnPropertyTypeAndCategories.ForeColor = Color.Black
        btnClient.ForeColor = Color.Black
        btnClientAndOwner.ForeColor = Color.Black
        btnDashboard.ForeColor = Color.Black
        btnAgentManagement.ForeColor = Color.Black
        btnHouse.ForeColor = Color.Black
        btnMenu.ForeColor = Color.Black
        btnOwner.ForeColor = Color.Black
        btnPropertyManagement.ForeColor = Color.Black
        btnRent.ForeColor = Color.Black
        btnSaleAndManagement.ForeColor = Color.White
        btnSales.ForeColor = Color.White
        btnSetting.ForeColor = Color.Black
        btnTenantManagement.ForeColor = Color.Black
        btnTransaction.ForeColor = Color.Black


        LoadForm(New frmSale)
    End Sub

    Private Sub btnTransaction_Click(sender As Object, e As EventArgs) Handles btnTransaction.Click
        Using writer As New StreamWriter(splash_screen.log.ToString, True)
            If splash_screen.lines < 1 Then
                writer.WriteLine("DATE TIME" & vbTab & vbTab & " ACTION" & vbTab & vbTab & vbTab & vbTab & " LOCATION")
            End If
            writer.WriteLine(Date.Now & vbTab & " Click on " & btnTransaction.Text & vbTab & Me.Text)
        End Using

        nav = True

        btnClient.FillColor = Color.Transparent
        btnClientAndOwner.FillColor = Color.Transparent
        btnDashboard.FillColor = Color.Transparent
        btnAgentManagement.FillColor = Color.Transparent
        btnHouse.FillColor = Color.Transparent
        btnMenu.FillColor = Color.Transparent
        btnOwner.FillColor = Color.Transparent
        btnPropertyManagement.FillColor = Color.Transparent
        btnRent.FillColor = Color.Transparent
        btnSaleAndManagement.FillColor = Color.FromArgb(94, 148, 255)
        btnSales.FillColor = Color.Transparent
        btnSetting.FillColor = Color.Transparent
        btnTenantManagement.FillColor = Color.Transparent
        btnTransaction.FillColor = Color.FromArgb(94, 148, 255)
        btnPropertyTypeAndCategories.FillColor = Color.Transparent
        btnMaintenanceManagement.FillColor = Color.Transparent

        btnMaintenanceManagement.ForeColor = Color.Black
        btnPropertyTypeAndCategories.ForeColor = Color.Black
        btnClient.ForeColor = Color.Black
        btnClientAndOwner.ForeColor = Color.Black
        btnDashboard.ForeColor = Color.Black
        btnAgentManagement.ForeColor = Color.Black
        btnHouse.ForeColor = Color.Black
        btnMenu.ForeColor = Color.Black
        btnOwner.ForeColor = Color.Black
        btnPropertyManagement.ForeColor = Color.Black
        btnRent.ForeColor = Color.Black
        btnSaleAndManagement.ForeColor = Color.White
        btnSales.ForeColor = Color.Black
        btnSetting.ForeColor = Color.Black
        btnTenantManagement.ForeColor = Color.Black
        btnTransaction.ForeColor = Color.White

        LoadForm(New frmTransaction)
    End Sub

    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using writer As New StreamWriter(splash_screen.log.ToString, True)
            If splash_screen.lines < 1 Then
                writer.WriteLine("DATE TIME" & vbTab & vbTab & " ACTION" & vbTab & vbTab & vbTab & vbTab & " LOCATION")
            End If
            writer.WriteLine(Date.Now & vbTab & " Connecting to the database " & vbTab & Me.Text)
        End Using

        lblUsername.Text = username

        Try
            Dim notAvailableQuery As String = "SELECT COUNT(*) as Not_Available FROM `property` WHERE property.Property_availability = 'Not Available';"
            Dim TotalQuery As String = "SELECT COUNT(*) as Total FROM `property`;"
            Using connection As New MySqlConnection("server=localhost; user=root; password=; database=g3subvb;")
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
                lblTotalProperty.Left -= (lblTotalProperty.Width - 30)
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
                    lblTotalRevenue.Left -= (lblTotalRevenue.Width - 30)
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

            Using writer As New StreamWriter(splash_screen.log.ToString, True)
                If splash_screen.lines < 1 Then
                    writer.WriteLine("DATE TIME" & vbTab & vbTab & " ACTION" & vbTab & vbTab & vbTab & vbTab & " LOCATION")
                End If
                writer.WriteLine(Date.Now & vbTab & ex.Message & vbTab & Me.Text)
            End Using

        End Try




    End Sub

    Private Sub btnUserIcon_Click(sender As Object, e As EventArgs) Handles btnUserIcon.Click
        Using writer As New StreamWriter(splash_screen.log.ToString, True)
            If splash_screen.lines < 1 Then
                writer.WriteLine("DATE TIME" & vbTab & vbTab & " ACTION" & vbTab & vbTab & vbTab & vbTab & " LOCATION")
            End If
            writer.WriteLine(Date.Now & vbTab & " Click on UserIcon button " & vbTab & Me.Text)
        End Using

        nav = True

        btnClient.FillColor = Color.Transparent
        btnClientAndOwner.FillColor = Color.Transparent
        btnDashboard.FillColor = Color.Transparent
        btnAgentManagement.FillColor = Color.Transparent
        btnHouse.FillColor = Color.Transparent
        btnMenu.FillColor = Color.Transparent
        btnOwner.FillColor = Color.Transparent
        btnPropertyManagement.FillColor = Color.Transparent
        btnRent.FillColor = Color.Transparent
        btnSaleAndManagement.FillColor = Color.Transparent
        btnSales.FillColor = Color.Transparent
        btnSetting.FillColor = Color.FromArgb(94, 148, 255)
        btnTenantManagement.FillColor = Color.Transparent
        btnTransaction.FillColor = Color.Transparent
        btnPropertyTypeAndCategories.FillColor = Color.Transparent
        btnMaintenanceManagement.FillColor = Color.Transparent

        btnMaintenanceManagement.ForeColor = Color.Black
        btnPropertyTypeAndCategories.ForeColor = Color.Black
        btnClient.ForeColor = Color.Black
        btnClientAndOwner.ForeColor = Color.Black
        btnDashboard.ForeColor = Color.Black
        btnAgentManagement.ForeColor = Color.Black
        btnHouse.ForeColor = Color.Black
        btnMenu.ForeColor = Color.Black
        btnOwner.ForeColor = Color.Black
        btnPropertyManagement.ForeColor = Color.Black
        btnRent.ForeColor = Color.Black
        btnSaleAndManagement.ForeColor = Color.Black
        btnSales.ForeColor = Color.Black
        btnSetting.ForeColor = Color.White
        btnTenantManagement.ForeColor = Color.Black
        btnTransaction.ForeColor = Color.Black

        LoadForm(New frmSetting)
    End Sub
End Class


