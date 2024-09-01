Imports WindowsApp1.Mode
Imports Guna.UI.WinForms
Imports Guna.UI2.WinForms


Public Class frmAgentDashboard
    Public f As Form
    Public nav As Boolean = False


    Private Sub frmAgentDashboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadForm(New frmHome)
    End Sub

    Public Sub LoadForm(ByVal form As Object)
        For Each co In Me.palMain.Controls
            If Me.palMain.Controls.Count > 0 Then
                Me.palMain.Controls.RemoveAt(0)
            End If
        Next
        f = TryCast(form, Form)
        f.TopLevel = False
        f.Dock = DockStyle.Fill
        f.Name = "palFrame"
        Me.palMain.Controls.Add(f)
        Me.palMain.AutoScroll = True
        Me.palMain.AutoScrollMargin = New Size(20, 20)

        If Mode.checkMood Then
            For Each control As Control In f.Controls
                If TypeOf control Is Label Then
                    DirectCast(control, Label).ForeColor = Color.White
                End If
                If TypeOf control Is Panel Then
                    Dim penel As Panel = DirectCast(control, Panel)
                    'Panel.BackColor = Color.FromArgb(64, 64, 64)
                    For Each con As Control In penel.Controls
                        If TypeOf control Is Label Then
                            DirectCast(control, Label).ForeColor = Color.White
                        End If
                    Next
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
                If TypeOf control Is Panel Then
                    Dim penel As Panel = DirectCast(control, Panel)
                    ' Panel.BackColor = Color.FromKnownColor(KnownColor.Control)
                    For Each con As Control In penel.Controls
                        If TypeOf control Is Label Then
                            DirectCast(control, Label).ForeColor = Color.Black
                        End If
                    Next
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

        Me.palMain.Tag = f
        f.Show()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        btnHome.BaseColor = Color.FromArgb(94, 148, 240)
        btnProperty.BaseColor = Color.Transparent
        btnTransactionSale.BaseColor = Color.Transparent
        btnMaintenance.BaseColor = Color.Transparent
        btnSetting.BaseColor = Color.Transparent
        btnCustomerDetail.BaseColor = Color.Transparent
        LoadForm(New frmHome)
    End Sub

    Private Sub btnProperty_Click(sender As Object, e As EventArgs) Handles btnProperty.Click
        btnHome.BaseColor = Color.Transparent
        btnProperty.BaseColor = Color.FromArgb(94, 148, 240)
        btnTransactionSale.BaseColor = Color.Transparent
        btnMaintenance.BaseColor = Color.Transparent
        btnSetting.BaseColor = Color.Transparent
        btnCustomerDetail.BaseColor = Color.Transparent
        LoadForm(New frmProperty)
    End Sub

    Private Sub btnTransactionSale_Click(sender As Object, e As EventArgs) Handles btnTransactionSale.Click
        btnHome.BaseColor = Color.Transparent
        btnProperty.BaseColor = Color.Transparent
        btnTransactionSale.BaseColor = Color.FromArgb(94, 148, 240)
        btnMaintenance.BaseColor = Color.Transparent
        btnSetting.BaseColor = Color.Transparent
        btnCustomerDetail.BaseColor = Color.Transparent
        LoadForm(New frmTransactionSale)
    End Sub

    Private Sub btnMaintenance_Click(sender As Object, e As EventArgs) Handles btnMaintenance.Click
        btnHome.BaseColor = Color.Transparent
        btnProperty.BaseColor = Color.Transparent
        btnTransactionSale.BaseColor = Color.Transparent
        btnMaintenance.BaseColor = Color.FromArgb(94, 148, 240)
        btnSetting.BaseColor = Color.Transparent
        btnCustomerDetail.BaseColor = Color.Transparent
        LoadForm(New frmAM)
    End Sub

    Private Sub btnCustomerDetail_Click(sender As Object, e As EventArgs) Handles btnCustomerDetail.Click
        btnHome.BaseColor = Color.Transparent
        btnProperty.BaseColor = Color.Transparent
        btnTransactionSale.BaseColor = Color.Transparent
        btnMaintenance.BaseColor = Color.Transparent
        btnSetting.BaseColor = Color.Transparent
        btnCustomerDetail.BaseColor = Color.FromArgb(94, 148, 240)
        LoadForm(New frmCustomerDetail)
    End Sub

    Private Sub btnSetting_Click(sender As Object, e As EventArgs) Handles btnSetting.Click
        btnHome.BaseColor = Color.Transparent
        btnProperty.BaseColor = Color.Transparent
        btnTransactionSale.BaseColor = Color.Transparent
        btnMaintenance.BaseColor = Color.Transparent
        btnSetting.BaseColor = Color.FromArgb(94, 148, 240)
        btnCustomerDetail.BaseColor = Color.Transparent
        LoadForm(New frmAgentSetting)
    End Sub

    Private Sub btnlogOut_Click(sender As Object, e As EventArgs) Handles btnlogOut.Click
        user_role = ""
        username = ""
        UserId = 0
        Me.Close()
        frmsignIn.Show()
    End Sub

    Private Sub btnMode_Click(sender As Object, e As EventArgs) Handles btnMode.Click

        ModeChange()
        ChangePanelControlsColor(f)
        If nav Then

        End If
    End Sub

    Public Sub ChangePanelControlsColor(panel As Form)
        If Mode.checkMood Then
            For Each control As Control In panel.Controls
                If TypeOf control Is Label Then
                    DirectCast(control, Label).ForeColor = Color.White
                End If
                If TypeOf control Is Panel Then
                    Dim penel As Panel = DirectCast(control, Panel)
                    panel.BackColor = Color.FromArgb(64, 64, 64)
                    For Each con As Control In penel.Controls
                        If TypeOf control Is Label Then
                            DirectCast(control, Label).ForeColor = Color.White
                        End If
                    Next
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
                If TypeOf control Is Panel Then
                    Dim penel As Panel = DirectCast(control, Panel)
                    panel.BackColor = Color.FromKnownColor(KnownColor.Control)
                    For Each con As Control In penel.Controls
                        If TypeOf control Is Label Then
                            DirectCast(control, Label).ForeColor = Color.Black
                        End If
                    Next
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

    Public Sub ModeChange()
        If Not Mode.checkMood Then
            Mode.checkMood = True
            palMainFrame.BackColor = Color.FromArgb(64, 64, 64)
            palHeader.BackColor = Color.FromArgb(64, 64, 64)
            lblUsername.ForeColor = Color.White
            btnMode.Image = My.Resources._045_sunny_3

            btnMode.HoverState.Image = My.Resources._045_sunny_3
            Panel4.ForeColor = Color.White
            'lblWelcome.ForeColor = Color.White
            btnCustomerDetail.ForeColor = Color.White
            btnHome.ForeColor = Color.White
            btnMaintenance.ForeColor = Color.White
            btnProperty.ForeColor = Color.White
            btnSetting.ForeColor = Color.White
            btnTransactionSale.ForeColor = Color.White

        Else
            Mode.checkMood = False
            palMainFrame.BackColor = Color.FromKnownColor(KnownColor.Control)
            palHeader.BackColor = Color.FromKnownColor(KnownColor.Control)
            lblUsername.ForeColor = Color.Black
            btnMode.Image = My.Resources.moon__1_

            btnMode.HoverState.Image = My.Resources.moon
            Panel4.ForeColor = Color.Black
            'lblWelcome.ForeColor = Color.Black
            btnCustomerDetail.ForeColor = Color.Black
            btnHome.ForeColor = Color.Black
            btnMaintenance.ForeColor = Color.Black
            btnProperty.ForeColor = Color.Black
            btnSetting.ForeColor = Color.Black
            btnTransactionSale.ForeColor = Color.Black

        End If
    End Sub

End Class