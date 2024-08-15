<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHome
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.GunaElipsePanel1 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.palLastest = New Guna.UI.WinForms.GunaElipsePanel()
        Me.palView = New Guna.UI.WinForms.GunaElipsePanel()
        Me.btnLeft = New Guna.UI.WinForms.GunaImageButton()
        Me.btnRight = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaElipsePanel2 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.GunaElipsePanel4 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.txtSaleHistory = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.palSaleHistory = New Guna.UI.WinForms.GunaElipsePanel()
        Me.GunaElipsePanel3 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.txtTransactionHistroy = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.palTransactionHistroy = New Guna.UI.WinForms.GunaElipsePanel()
        Me.GunaElipsePanel8 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.lblTotalSale = New System.Windows.Forms.Label()
        Me.chaTotalSale = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GunaElipsePanel1.SuspendLayout()
        Me.palLastest.SuspendLayout()
        Me.GunaElipsePanel2.SuspendLayout()
        Me.GunaElipsePanel4.SuspendLayout()
        Me.GunaElipsePanel3.SuspendLayout()
        Me.GunaElipsePanel8.SuspendLayout()
        CType(Me.chaTotalSale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaElipsePanel1
        '
        Me.GunaElipsePanel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaElipsePanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel1.BaseColor = System.Drawing.SystemColors.ControlLight
        Me.GunaElipsePanel1.Controls.Add(Me.Label1)
        Me.GunaElipsePanel1.Controls.Add(Me.palLastest)
        Me.GunaElipsePanel1.Controls.Add(Me.btnLeft)
        Me.GunaElipsePanel1.Controls.Add(Me.btnRight)
        Me.GunaElipsePanel1.Location = New System.Drawing.Point(52, 26)
        Me.GunaElipsePanel1.Name = "GunaElipsePanel1"
        Me.GunaElipsePanel1.Radius = 10
        Me.GunaElipsePanel1.Size = New System.Drawing.Size(504, 267)
        Me.GunaElipsePanel1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Lastest"
        '
        'palLastest
        '
        Me.palLastest.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.palLastest.BackColor = System.Drawing.Color.Transparent
        Me.palLastest.BaseColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.palLastest.Controls.Add(Me.palView)
        Me.palLastest.Location = New System.Drawing.Point(14, 40)
        Me.palLastest.Name = "palLastest"
        Me.palLastest.Radius = 10
        Me.palLastest.Size = New System.Drawing.Size(477, 215)
        Me.palLastest.TabIndex = 4
        '
        'palView
        '
        Me.palView.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.palView.BackColor = System.Drawing.Color.Transparent
        Me.palView.BaseColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.palView.Location = New System.Drawing.Point(2, 12)
        Me.palView.Name = "palView"
        Me.palView.Radius = 10
        Me.palView.Size = New System.Drawing.Size(150, 192)
        Me.palView.TabIndex = 5
        '
        'btnLeft
        '
        Me.btnLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLeft.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLeft.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnLeft.Image = Global.WindowsApp1.My.Resources.Resources._004_playwhiteLeft
        Me.btnLeft.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnLeft.Location = New System.Drawing.Point(404, 6)
        Me.btnLeft.Name = "btnLeft"
        Me.btnLeft.OnHoverImage = Nothing
        Me.btnLeft.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.btnLeft.Size = New System.Drawing.Size(30, 30)
        Me.btnLeft.TabIndex = 1
        '
        'btnRight
        '
        Me.btnRight.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnRight.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRight.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnRight.Image = Global.WindowsApp1.My.Resources.Resources._004_playwhiteRight
        Me.btnRight.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnRight.Location = New System.Drawing.Point(440, 6)
        Me.btnRight.Name = "btnRight"
        Me.btnRight.OnHoverImage = Nothing
        Me.btnRight.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.btnRight.Size = New System.Drawing.Size(30, 30)
        Me.btnRight.TabIndex = 0
        '
        'GunaElipsePanel2
        '
        Me.GunaElipsePanel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaElipsePanel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel2.BaseColor = System.Drawing.SystemColors.ControlLight
        Me.GunaElipsePanel2.Controls.Add(Me.GunaElipsePanel4)
        Me.GunaElipsePanel2.Controls.Add(Me.GunaElipsePanel3)
        Me.GunaElipsePanel2.Location = New System.Drawing.Point(34, 317)
        Me.GunaElipsePanel2.Name = "GunaElipsePanel2"
        Me.GunaElipsePanel2.Radius = 10
        Me.GunaElipsePanel2.Size = New System.Drawing.Size(1064, 273)
        Me.GunaElipsePanel2.TabIndex = 4
        '
        'GunaElipsePanel4
        '
        Me.GunaElipsePanel4.AutoScroll = True
        Me.GunaElipsePanel4.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel4.BaseColor = System.Drawing.Color.DarkGray
        Me.GunaElipsePanel4.Controls.Add(Me.txtSaleHistory)
        Me.GunaElipsePanel4.Controls.Add(Me.Label3)
        Me.GunaElipsePanel4.Controls.Add(Me.palSaleHistory)
        Me.GunaElipsePanel4.Location = New System.Drawing.Point(542, 5)
        Me.GunaElipsePanel4.Name = "GunaElipsePanel4"
        Me.GunaElipsePanel4.Radius = 10
        Me.GunaElipsePanel4.Size = New System.Drawing.Size(504, 262)
        Me.GunaElipsePanel4.TabIndex = 6
        '
        'txtSaleHistory
        '
        Me.txtSaleHistory.BorderRadius = 5
        Me.txtSaleHistory.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSaleHistory.DefaultText = ""
        Me.txtSaleHistory.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSaleHistory.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSaleHistory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSaleHistory.DisabledState.Parent = Me.txtSaleHistory
        Me.txtSaleHistory.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSaleHistory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSaleHistory.FocusedState.Parent = Me.txtSaleHistory
        Me.txtSaleHistory.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSaleHistory.HoverState.Parent = Me.txtSaleHistory
        Me.txtSaleHistory.IconLeft = Global.WindowsApp1.My.Resources.Resources.magnifier
        Me.txtSaleHistory.Location = New System.Drawing.Point(281, 7)
        Me.txtSaleHistory.Name = "txtSaleHistory"
        Me.txtSaleHistory.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSaleHistory.PlaceholderText = "Search..."
        Me.txtSaleHistory.SelectedText = ""
        Me.txtSaleHistory.ShadowDecoration.Parent = Me.txtSaleHistory
        Me.txtSaleHistory.Size = New System.Drawing.Size(199, 27)
        Me.txtSaleHistory.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 25)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Sale History"
        '
        'palSaleHistory
        '
        Me.palSaleHistory.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.palSaleHistory.BackColor = System.Drawing.Color.Transparent
        Me.palSaleHistory.BaseColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.palSaleHistory.Location = New System.Drawing.Point(13, 40)
        Me.palSaleHistory.Name = "palSaleHistory"
        Me.palSaleHistory.Radius = 10
        Me.palSaleHistory.Size = New System.Drawing.Size(477, 215)
        Me.palSaleHistory.TabIndex = 11
        '
        'GunaElipsePanel3
        '
        Me.GunaElipsePanel3.AutoScroll = True
        Me.GunaElipsePanel3.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel3.BaseColor = System.Drawing.Color.DarkGray
        Me.GunaElipsePanel3.Controls.Add(Me.txtTransactionHistroy)
        Me.GunaElipsePanel3.Controls.Add(Me.Label2)
        Me.GunaElipsePanel3.Controls.Add(Me.palTransactionHistroy)
        Me.GunaElipsePanel3.Location = New System.Drawing.Point(18, 5)
        Me.GunaElipsePanel3.Name = "GunaElipsePanel3"
        Me.GunaElipsePanel3.Radius = 10
        Me.GunaElipsePanel3.Size = New System.Drawing.Size(504, 262)
        Me.GunaElipsePanel3.TabIndex = 5
        '
        'txtTransactionHistroy
        '
        Me.txtTransactionHistroy.BorderRadius = 5
        Me.txtTransactionHistroy.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTransactionHistroy.DefaultText = ""
        Me.txtTransactionHistroy.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtTransactionHistroy.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtTransactionHistroy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTransactionHistroy.DisabledState.Parent = Me.txtTransactionHistroy
        Me.txtTransactionHistroy.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTransactionHistroy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTransactionHistroy.FocusedState.Parent = Me.txtTransactionHistroy
        Me.txtTransactionHistroy.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTransactionHistroy.HoverState.Parent = Me.txtTransactionHistroy
        Me.txtTransactionHistroy.IconLeft = Global.WindowsApp1.My.Resources.Resources.magnifier
        Me.txtTransactionHistroy.Location = New System.Drawing.Point(283, 7)
        Me.txtTransactionHistroy.Name = "txtTransactionHistroy"
        Me.txtTransactionHistroy.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTransactionHistroy.PlaceholderText = "Search..."
        Me.txtTransactionHistroy.SelectedText = ""
        Me.txtTransactionHistroy.ShadowDecoration.Parent = Me.txtTransactionHistroy
        Me.txtTransactionHistroy.Size = New System.Drawing.Size(199, 27)
        Me.txtTransactionHistroy.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(196, 25)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Transaction History"
        '
        'palTransactionHistroy
        '
        Me.palTransactionHistroy.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.palTransactionHistroy.BackColor = System.Drawing.Color.Transparent
        Me.palTransactionHistroy.BaseColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.palTransactionHistroy.Location = New System.Drawing.Point(14, 40)
        Me.palTransactionHistroy.Name = "palTransactionHistroy"
        Me.palTransactionHistroy.Radius = 10
        Me.palTransactionHistroy.Size = New System.Drawing.Size(477, 215)
        Me.palTransactionHistroy.TabIndex = 8
        '
        'GunaElipsePanel8
        '
        Me.GunaElipsePanel8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaElipsePanel8.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel8.BaseColor = System.Drawing.SystemColors.ControlLight
        Me.GunaElipsePanel8.Controls.Add(Me.lblTotalSale)
        Me.GunaElipsePanel8.Controls.Add(Me.chaTotalSale)
        Me.GunaElipsePanel8.Controls.Add(Me.Label4)
        Me.GunaElipsePanel8.Location = New System.Drawing.Point(576, 26)
        Me.GunaElipsePanel8.Name = "GunaElipsePanel8"
        Me.GunaElipsePanel8.Radius = 10
        Me.GunaElipsePanel8.Size = New System.Drawing.Size(504, 267)
        Me.GunaElipsePanel8.TabIndex = 5
        '
        'lblTotalSale
        '
        Me.lblTotalSale.AutoSize = True
        Me.lblTotalSale.Font = New System.Drawing.Font("Segoe UI Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalSale.Location = New System.Drawing.Point(314, 9)
        Me.lblTotalSale.Name = "lblTotalSale"
        Me.lblTotalSale.Size = New System.Drawing.Size(23, 25)
        Me.lblTotalSale.TabIndex = 7
        Me.lblTotalSale.Text = "0"
        '
        'chaTotalSale
        '
        Me.chaTotalSale.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        ChartArea1.Area3DStyle.Enable3D = True
        ChartArea1.BackColor = System.Drawing.Color.Transparent
        ChartArea1.Name = "ChartArea1"
        Me.chaTotalSale.ChartAreas.Add(ChartArea1)
        Legend1.Alignment = System.Drawing.StringAlignment.Center
        Legend1.BackColor = System.Drawing.Color.Transparent
        Legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom
        Legend1.Name = "Legend1"
        Me.chaTotalSale.Legends.Add(Legend1)
        Me.chaTotalSale.Location = New System.Drawing.Point(13, 40)
        Me.chaTotalSale.Name = "chaTotalSale"
        Series1.BackSecondaryColor = System.Drawing.Color.Transparent
        Series1.BorderColor = System.Drawing.Color.Transparent
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
        Series1.Color = System.Drawing.Color.Transparent
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chaTotalSale.Series.Add(Series1)
        Me.chaTotalSale.Size = New System.Drawing.Size(477, 215)
        Me.chaTotalSale.TabIndex = 6
        Me.chaTotalSale.Text = "Chart2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 25)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Total Sale:"
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoScrollMargin = New System.Drawing.Size(20, 20)
        Me.AutoScrollMinSize = New System.Drawing.Size(20, 20)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1132, 603)
        Me.Controls.Add(Me.GunaElipsePanel8)
        Me.Controls.Add(Me.GunaElipsePanel2)
        Me.Controls.Add(Me.GunaElipsePanel1)
        Me.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "frmHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SIGN UP"
        Me.GunaElipsePanel1.ResumeLayout(False)
        Me.GunaElipsePanel1.PerformLayout()
        Me.palLastest.ResumeLayout(False)
        Me.GunaElipsePanel2.ResumeLayout(False)
        Me.GunaElipsePanel4.ResumeLayout(False)
        Me.GunaElipsePanel4.PerformLayout()
        Me.GunaElipsePanel3.ResumeLayout(False)
        Me.GunaElipsePanel3.PerformLayout()
        Me.GunaElipsePanel8.ResumeLayout(False)
        Me.GunaElipsePanel8.PerformLayout()
        CType(Me.chaTotalSale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GunaElipsePanel1 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents GunaElipsePanel2 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents GunaElipsePanel4 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents GunaElipsePanel3 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents Label1 As Label
    Friend WithEvents palLastest As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents btnLeft As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents btnRight As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents txtSaleHistory As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents palSaleHistory As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents txtTransactionHistroy As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents palTransactionHistroy As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents GunaElipsePanel8 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents lblTotalSale As Label
    Friend WithEvents chaTotalSale As DataVisualization.Charting.Chart
    Friend WithEvents Label4 As Label
    Friend WithEvents palView As Guna.UI.WinForms.GunaElipsePanel
End Class
