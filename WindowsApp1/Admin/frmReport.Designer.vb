<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReport
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReport))
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GunaControlBox3 = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaControlBox2 = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaControlBox1 = New Guna.UI.WinForms.GunaControlBox()
        Me.Guna2CirclePictureBox2 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.lblshow = New System.Windows.Forms.Label()
        Me.dtpEndDuration = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.cboAgent = New Guna.UI.WinForms.GunaComboBox()
        Me.cboPropertyName = New Guna.UI.WinForms.GunaComboBox()
        Me.dtpStartDuration = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.lblAgent = New System.Windows.Forms.Label()
        Me.lblEndDuration = New System.Windows.Forms.Label()
        Me.lblStartDuration = New System.Windows.Forms.Label()
        Me.lblPropertyName = New System.Windows.Forms.Label()
        Me.dgvView = New System.Windows.Forms.DataGridView()
        Me.btnPrint = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.Guna2CirclePictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PageSetupDialog1
        '
        Me.PageSetupDialog1.Document = Me.PrintDocument1
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.ShowIcon = False
        Me.PrintPreviewDialog1.Visible = False
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.TargetControl = Me.Panel2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Guna2CirclePictureBox2)
        Me.Panel2.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1001, 35)
        Me.Panel2.TabIndex = 16
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(Me.GunaControlBox3)
        Me.Panel3.Controls.Add(Me.GunaControlBox2)
        Me.Panel3.Controls.Add(Me.GunaControlBox1)
        Me.Panel3.Location = New System.Drawing.Point(857, -1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(143, 36)
        Me.Panel3.TabIndex = 10
        '
        'GunaControlBox3
        '
        Me.GunaControlBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox3.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox3.AnimationSpeed = 0.03!
        Me.GunaControlBox3.BackColor = System.Drawing.Color.Transparent
        Me.GunaControlBox3.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox
        Me.GunaControlBox3.IconColor = System.Drawing.Color.White
        Me.GunaControlBox3.IconSize = 15.0!
        Me.GunaControlBox3.Location = New System.Drawing.Point(6, 1)
        Me.GunaControlBox3.Name = "GunaControlBox3"
        Me.GunaControlBox3.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.GunaControlBox3.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox3.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox3.Size = New System.Drawing.Size(45, 35)
        Me.GunaControlBox3.TabIndex = 20
        '
        'GunaControlBox2
        '
        Me.GunaControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox2.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox2.AnimationSpeed = 0.03!
        Me.GunaControlBox2.BackColor = System.Drawing.Color.Transparent
        Me.GunaControlBox2.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MaximizeBox
        Me.GunaControlBox2.IconColor = System.Drawing.Color.White
        Me.GunaControlBox2.IconSize = 15.0!
        Me.GunaControlBox2.Location = New System.Drawing.Point(54, 1)
        Me.GunaControlBox2.Name = "GunaControlBox2"
        Me.GunaControlBox2.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.GunaControlBox2.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox2.Size = New System.Drawing.Size(45, 35)
        Me.GunaControlBox2.TabIndex = 19
        '
        'GunaControlBox1
        '
        Me.GunaControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox1.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox1.AnimationSpeed = 0.03!
        Me.GunaControlBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaControlBox1.IconColor = System.Drawing.Color.White
        Me.GunaControlBox1.IconSize = 15.0!
        Me.GunaControlBox1.Location = New System.Drawing.Point(98, 1)
        Me.GunaControlBox1.Name = "GunaControlBox1"
        Me.GunaControlBox1.OnHoverBackColor = System.Drawing.Color.Red
        Me.GunaControlBox1.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox1.Size = New System.Drawing.Size(45, 35)
        Me.GunaControlBox1.TabIndex = 18
        '
        'Guna2CirclePictureBox2
        '
        Me.Guna2CirclePictureBox2.Image = Global.WindowsApp1.My.Resources.Resources.LOGOCOLOR
        Me.Guna2CirclePictureBox2.Location = New System.Drawing.Point(4, 3)
        Me.Guna2CirclePictureBox2.Name = "Guna2CirclePictureBox2"
        Me.Guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox2.ShadowDecoration.Parent = Me.Guna2CirclePictureBox2
        Me.Guna2CirclePictureBox2.Size = New System.Drawing.Size(35, 29)
        Me.Guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2CirclePictureBox2.TabIndex = 9
        Me.Guna2CirclePictureBox2.TabStop = False
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Enabled = False
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(43, 7)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(114, 22)
        Me.Guna2HtmlLabel1.TabIndex = 11
        Me.Guna2HtmlLabel1.Text = "LEGACY HOME"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.Document = Me.PrintDocument1
        Me.PrintDialog1.UseEXDialog = True
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'lblshow
        '
        Me.lblshow.AutoSize = True
        Me.lblshow.Font = New System.Drawing.Font("Verdana", 21.75!, System.Drawing.FontStyle.Bold)
        Me.lblshow.Location = New System.Drawing.Point(12, 69)
        Me.lblshow.Name = "lblshow"
        Me.lblshow.Size = New System.Drawing.Size(122, 35)
        Me.lblshow.TabIndex = 17
        Me.lblshow.Text = "Label1"
        '
        'dtpEndDuration
        '
        Me.dtpEndDuration.BaseColor = System.Drawing.Color.White
        Me.dtpEndDuration.BorderColor = System.Drawing.Color.Silver
        Me.dtpEndDuration.CustomFormat = Nothing
        Me.dtpEndDuration.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpEndDuration.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpEndDuration.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpEndDuration.ForeColor = System.Drawing.Color.Black
        Me.dtpEndDuration.Location = New System.Drawing.Point(779, 151)
        Me.dtpEndDuration.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpEndDuration.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpEndDuration.Name = "dtpEndDuration"
        Me.dtpEndDuration.OnHoverBaseColor = System.Drawing.Color.White
        Me.dtpEndDuration.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpEndDuration.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpEndDuration.OnPressedColor = System.Drawing.Color.Black
        Me.dtpEndDuration.Size = New System.Drawing.Size(142, 30)
        Me.dtpEndDuration.TabIndex = 18
        Me.dtpEndDuration.Text = "30 July 2024"
        Me.dtpEndDuration.Value = New Date(2024, 7, 30, 0, 48, 55, 793)
        '
        'cboAgent
        '
        Me.cboAgent.BackColor = System.Drawing.Color.Transparent
        Me.cboAgent.BaseColor = System.Drawing.Color.White
        Me.cboAgent.BorderColor = System.Drawing.Color.Silver
        Me.cboAgent.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboAgent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAgent.FocusedColor = System.Drawing.Color.Empty
        Me.cboAgent.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAgent.ForeColor = System.Drawing.Color.Black
        Me.cboAgent.FormattingEnabled = True
        Me.cboAgent.Location = New System.Drawing.Point(55, 151)
        Me.cboAgent.Name = "cboAgent"
        Me.cboAgent.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboAgent.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cboAgent.Size = New System.Drawing.Size(222, 30)
        Me.cboAgent.TabIndex = 19
        '
        'cboPropertyName
        '
        Me.cboPropertyName.BackColor = System.Drawing.Color.Transparent
        Me.cboPropertyName.BaseColor = System.Drawing.Color.White
        Me.cboPropertyName.BorderColor = System.Drawing.Color.Silver
        Me.cboPropertyName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboPropertyName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPropertyName.FocusedColor = System.Drawing.Color.Empty
        Me.cboPropertyName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPropertyName.ForeColor = System.Drawing.Color.Black
        Me.cboPropertyName.FormattingEnabled = True
        Me.cboPropertyName.Location = New System.Drawing.Point(323, 151)
        Me.cboPropertyName.Name = "cboPropertyName"
        Me.cboPropertyName.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboPropertyName.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cboPropertyName.Size = New System.Drawing.Size(222, 30)
        Me.cboPropertyName.TabIndex = 21
        '
        'dtpStartDuration
        '
        Me.dtpStartDuration.BaseColor = System.Drawing.Color.White
        Me.dtpStartDuration.BorderColor = System.Drawing.Color.Silver
        Me.dtpStartDuration.CustomFormat = Nothing
        Me.dtpStartDuration.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpStartDuration.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpStartDuration.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpStartDuration.ForeColor = System.Drawing.Color.Black
        Me.dtpStartDuration.Location = New System.Drawing.Point(591, 151)
        Me.dtpStartDuration.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpStartDuration.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpStartDuration.Name = "dtpStartDuration"
        Me.dtpStartDuration.OnHoverBaseColor = System.Drawing.Color.White
        Me.dtpStartDuration.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpStartDuration.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpStartDuration.OnPressedColor = System.Drawing.Color.Black
        Me.dtpStartDuration.Size = New System.Drawing.Size(142, 30)
        Me.dtpStartDuration.TabIndex = 20
        Me.dtpStartDuration.Text = "30 July 2024"
        Me.dtpStartDuration.Value = New Date(2024, 7, 30, 0, 48, 55, 793)
        '
        'lblAgent
        '
        Me.lblAgent.AutoSize = True
        Me.lblAgent.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgent.Location = New System.Drawing.Point(55, 132)
        Me.lblAgent.Name = "lblAgent"
        Me.lblAgent.Size = New System.Drawing.Size(52, 16)
        Me.lblAgent.TabIndex = 22
        Me.lblAgent.Text = "AGENT"
        '
        'lblEndDuration
        '
        Me.lblEndDuration.AutoSize = True
        Me.lblEndDuration.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndDuration.Location = New System.Drawing.Point(779, 132)
        Me.lblEndDuration.Name = "lblEndDuration"
        Me.lblEndDuration.Size = New System.Drawing.Size(106, 16)
        Me.lblEndDuration.TabIndex = 23
        Me.lblEndDuration.Text = "END DURATION"
        '
        'lblStartDuration
        '
        Me.lblStartDuration.AutoSize = True
        Me.lblStartDuration.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartDuration.Location = New System.Drawing.Point(591, 132)
        Me.lblStartDuration.Name = "lblStartDuration"
        Me.lblStartDuration.Size = New System.Drawing.Size(123, 16)
        Me.lblStartDuration.TabIndex = 24
        Me.lblStartDuration.Text = "START DURATION"
        '
        'lblPropertyName
        '
        Me.lblPropertyName.AutoSize = True
        Me.lblPropertyName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPropertyName.Location = New System.Drawing.Point(323, 132)
        Me.lblPropertyName.Name = "lblPropertyName"
        Me.lblPropertyName.Size = New System.Drawing.Size(118, 16)
        Me.lblPropertyName.TabIndex = 25
        Me.lblPropertyName.Text = "PROPERTY NAME"
        '
        'dgvView
        '
        Me.dgvView.AllowUserToAddRows = False
        Me.dgvView.AllowUserToDeleteRows = False
        Me.dgvView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.dgvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvView.Location = New System.Drawing.Point(18, 205)
        Me.dgvView.Name = "dgvView"
        Me.dgvView.ReadOnly = True
        Me.dgvView.Size = New System.Drawing.Size(960, 349)
        Me.dgvView.TabIndex = 26
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrint.CheckedState.Parent = Me.btnPrint
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.CustomImages.Parent = Me.btnPrint
        Me.btnPrint.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnPrint.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.HoverState.Parent = Me.btnPrint
        Me.btnPrint.Location = New System.Drawing.Point(837, 560)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.ShadowDecoration.Parent = Me.btnPrint
        Me.btnPrint.Size = New System.Drawing.Size(141, 45)
        Me.btnPrint.TabIndex = 27
        Me.btnPrint.Text = "Print"
        '
        'frmReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1001, 646)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.dgvView)
        Me.Controls.Add(Me.lblPropertyName)
        Me.Controls.Add(Me.lblStartDuration)
        Me.Controls.Add(Me.lblEndDuration)
        Me.Controls.Add(Me.lblAgent)
        Me.Controls.Add(Me.cboPropertyName)
        Me.Controls.Add(Me.dtpStartDuration)
        Me.Controls.Add(Me.cboAgent)
        Me.Controls.Add(Me.dtpEndDuration)
        Me.Controls.Add(Me.lblshow)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "frmReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SIGN UP"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.Guna2CirclePictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PageSetupDialog1 As PageSetupDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GunaControlBox3 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaControlBox2 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaControlBox1 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents Guna2CirclePictureBox2 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents lblshow As Label
    Friend WithEvents cboAgent As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents dtpEndDuration As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents lblPropertyName As Label
    Friend WithEvents lblStartDuration As Label
    Friend WithEvents lblEndDuration As Label
    Friend WithEvents lblAgent As Label
    Friend WithEvents cboPropertyName As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents dtpStartDuration As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents dgvView As DataGridView
    Friend WithEvents btnPrint As Guna.UI2.WinForms.Guna2Button
End Class
