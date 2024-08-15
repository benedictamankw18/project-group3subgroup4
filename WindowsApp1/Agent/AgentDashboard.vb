Imports WindowsApp1.Mode
Imports Guna.UI.WinForms
Imports Guna.UI2.WinForms


Public Class frmAgentDashboard
    Public f As Form

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

        'If Mode.checkMood Then
        '    For Each control As Control In f.Controls
        '        If TypeOf control Is Label Then
        '            DirectCast(control, Label).ForeColor = Color.White
        '        End If
        '        If TypeOf control Is TabControl Then
        '            Dim tabControl As TabControl = DirectCast(control, TabControl)
        '            tabControl.BackColor = Color.FromArgb(64, 64, 64)
        '            For Each tabPage As TabPage In tabControl.TabPages
        '                tabPage.BackColor = Color.FromArgb(64, 64, 64)
        '                tabPage.ForeColor = Color.White
        '                For Each tabControlLabel As Control In tabPage.Controls
        '                    If TypeOf tabControlLabel Is GunaLineTextBox Then
        '                        DirectCast(tabControlLabel, GunaLineTextBox).ForeColor = Color.Black
        '                    End If
        '                    If TypeOf tabControlLabel Is GunaLabel Then
        '                        DirectCast(tabControlLabel, GunaLabel).ForeColor = Color.White
        '                    End If
        '                    If TypeOf tabControlLabel Is Guna2HtmlLabel Then
        '                        DirectCast(tabControlLabel, Guna2HtmlLabel).ForeColor = Color.White
        '                    End If

        '                    If TypeOf tabControlLabel Is DataGridView Then
        '                        Dim dataGridView As DataGridView = DirectCast(tabControlLabel, DataGridView)
        '                        dataGridView.ForeColor = Color.White
        '                        dataGridView.BackgroundColor = Color.FromArgb(64, 64, 64)
        '                        dataGridView.DefaultCellStyle.BackColor = Color.FromArgb(64, 64, 64)
        '                        dataGridView.DefaultCellStyle.ForeColor = Color.White
        '                    End If
        '                    If TypeOf tabControlLabel Is DataGridTextBox Then
        '                        DirectCast(tabControlLabel, DataGridTextBox).ForeColor = Color.White
        '                    End If

        '                Next
        '            Next
        '        End If
        '        If TypeOf control Is DataGridView Then
        '            Dim dataGridView As DataGridView = DirectCast(control, DataGridView)
        '            dataGridView.ForeColor = Color.White
        '            dataGridView.BackgroundColor = Color.FromArgb(64, 64, 64)
        '            dataGridView.DefaultCellStyle.BackColor = Color.FromArgb(64, 64, 64)
        '            dataGridView.DefaultCellStyle.ForeColor = Color.White
        '        End If
        '        If TypeOf control Is DataGridTextBox Then
        '            DirectCast(control, DataGridTextBox).ForeColor = Color.White
        '        End If
        '    Next
        '    f.BackColor = Color.FromArgb(64, 64, 64)
        'Else
        '    For Each control As Control In f.Controls
        '        If TypeOf control Is Label Then
        '            DirectCast(control, Label).ForeColor = Color.Black
        '        End If
        '        If TypeOf control Is TabControl Then
        '            Dim tabControl As TabControl = DirectCast(control, TabControl)
        '            tabControl.BackColor = Color.FromKnownColor(KnownColor.Control)
        '            For Each tabPage As TabPage In tabControl.TabPages
        '                tabPage.BackColor = Color.FromKnownColor(KnownColor.Control)
        '                tabPage.ForeColor = Color.Black
        '                For Each tabControlLabel As Control In tabPage.Controls
        '                    If TypeOf tabControlLabel Is GunaLineTextBox Then
        '                        DirectCast(tabControlLabel, GunaLineTextBox).ForeColor = Color.Black
        '                    End If
        '                    If TypeOf tabControlLabel Is GunaLabel Then
        '                        DirectCast(tabControlLabel, GunaLabel).ForeColor = Color.Black
        '                    End If
        '                    If TypeOf tabControlLabel Is Guna2HtmlLabel Then
        '                        DirectCast(tabControlLabel, Guna2HtmlLabel).ForeColor = Color.Black
        '                    End If

        '                    If TypeOf tabControlLabel Is DataGridView Then
        '                        Dim dataGridView As DataGridView = DirectCast(tabControlLabel, DataGridView)
        '                        dataGridView.ForeColor = Color.Black
        '                        dataGridView.BackgroundColor = Color.FromKnownColor(KnownColor.Control)
        '                        dataGridView.DefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.Control)
        '                        dataGridView.DefaultCellStyle.ForeColor = Color.Black
        '                    End If
        '                    If TypeOf tabControlLabel Is DataGridTextBox Then
        '                        DirectCast(tabControlLabel, DataGridTextBox).ForeColor = Color.Black
        '                    End If


        '                Next
        '            Next
        '        End If

        '        If TypeOf control Is DataGridView Then
        '            Dim dataGridView As DataGridView = DirectCast(control, DataGridView)
        '            dataGridView.ForeColor = Color.Black
        '            dataGridView.BackgroundColor = Color.FromKnownColor(KnownColor.Control)
        '            dataGridView.DefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.Control)
        '            dataGridView.DefaultCellStyle.ForeColor = Color.Black
        '        End If
        '        If TypeOf control Is DataGridTextBox Then
        '            DirectCast(control, DataGridTextBox).ForeColor = Color.Black
        '        End If

        '    Next
        '    f.BackColor = Color.FromKnownColor(KnownColor.Control)
        'End If

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
        LoadForm(frmHome)
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
End Class