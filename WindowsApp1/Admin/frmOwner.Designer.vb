<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOwner
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtOwnerName = New Guna.UI.WinForms.GunaLineTextBox()
        Me.rtbPropertyLocation = New System.Windows.Forms.RichTextBox()
        Me.rtbPropertyName = New System.Windows.Forms.RichTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cboViewOwnerAss = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.dgvOwnership = New System.Windows.Forms.DataGridView()
        Me.nudNumberHouse = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgvOwnership, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudNumberHouse, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtOwnerName
        '
        Me.txtOwnerName.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtOwnerName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOwnerName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOwnerName.Enabled = False
        Me.txtOwnerName.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtOwnerName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOwnerName.LineColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtOwnerName.Location = New System.Drawing.Point(72, 350)
        Me.txtOwnerName.Name = "txtOwnerName"
        Me.txtOwnerName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtOwnerName.SelectedText = ""
        Me.txtOwnerName.Size = New System.Drawing.Size(445, 32)
        Me.txtOwnerName.TabIndex = 147
        '
        'rtbPropertyLocation
        '
        Me.rtbPropertyLocation.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.rtbPropertyLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rtbPropertyLocation.Enabled = False
        Me.rtbPropertyLocation.Location = New System.Drawing.Point(656, 426)
        Me.rtbPropertyLocation.Name = "rtbPropertyLocation"
        Me.rtbPropertyLocation.Size = New System.Drawing.Size(491, 144)
        Me.rtbPropertyLocation.TabIndex = 146
        Me.rtbPropertyLocation.Text = ""
        '
        'rtbPropertyName
        '
        Me.rtbPropertyName.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.rtbPropertyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rtbPropertyName.Enabled = False
        Me.rtbPropertyName.Location = New System.Drawing.Point(72, 426)
        Me.rtbPropertyName.Name = "rtbPropertyName"
        Me.rtbPropertyName.Size = New System.Drawing.Size(491, 144)
        Me.rtbPropertyName.TabIndex = 145
        Me.rtbPropertyName.Text = ""
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(764, 33)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(262, 18)
        Me.Label13.TabIndex = 144
        Me.Label13.Text = "VIEW OWNER'S ASSIGNED TO:"
        '
        'cboViewOwnerAss
        '
        Me.cboViewOwnerAss.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboViewOwnerAss.BackColor = System.Drawing.Color.Transparent
        Me.cboViewOwnerAss.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboViewOwnerAss.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboViewOwnerAss.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboViewOwnerAss.FocusedColor = System.Drawing.Color.Empty
        Me.cboViewOwnerAss.FocusedState.Parent = Me.cboViewOwnerAss
        Me.cboViewOwnerAss.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboViewOwnerAss.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboViewOwnerAss.FormattingEnabled = True
        Me.cboViewOwnerAss.HoverState.Parent = Me.cboViewOwnerAss
        Me.cboViewOwnerAss.ItemHeight = 30
        Me.cboViewOwnerAss.ItemsAppearance.Parent = Me.cboViewOwnerAss
        Me.cboViewOwnerAss.Location = New System.Drawing.Point(1032, 24)
        Me.cboViewOwnerAss.Name = "cboViewOwnerAss"
        Me.cboViewOwnerAss.ShadowDecoration.Parent = Me.cboViewOwnerAss
        Me.cboViewOwnerAss.Size = New System.Drawing.Size(276, 36)
        Me.cboViewOwnerAss.TabIndex = 143
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(81, 329)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(137, 18)
        Me.Label26.TabIndex = 142
        Me.Label26.Text = "OWNER'S NAME"
        '
        'dgvOwnership
        '
        Me.dgvOwnership.AllowUserToAddRows = False
        Me.dgvOwnership.AllowUserToDeleteRows = False
        Me.dgvOwnership.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvOwnership.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOwnership.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvOwnership.Location = New System.Drawing.Point(42, 80)
        Me.dgvOwnership.Name = "dgvOwnership"
        Me.dgvOwnership.ReadOnly = True
        Me.dgvOwnership.Size = New System.Drawing.Size(1281, 239)
        Me.dgvOwnership.TabIndex = 141
        '
        'nudNumberHouse
        '
        Me.nudNumberHouse.BackColor = System.Drawing.Color.Transparent
        Me.nudNumberHouse.BorderRadius = 4
        Me.nudNumberHouse.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.nudNumberHouse.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.nudNumberHouse.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.nudNumberHouse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.nudNumberHouse.DisabledState.Parent = Me.nudNumberHouse
        Me.nudNumberHouse.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.nudNumberHouse.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.nudNumberHouse.Enabled = False
        Me.nudNumberHouse.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.nudNumberHouse.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.nudNumberHouse.FocusedState.Parent = Me.nudNumberHouse
        Me.nudNumberHouse.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudNumberHouse.ForeColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.nudNumberHouse.Location = New System.Drawing.Point(653, 350)
        Me.nudNumberHouse.Name = "nudNumberHouse"
        Me.nudNumberHouse.ShadowDecoration.Parent = Me.nudNumberHouse
        Me.nudNumberHouse.Size = New System.Drawing.Size(276, 36)
        Me.nudNumberHouse.TabIndex = 140
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(653, 329)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(178, 18)
        Me.Label18.TabIndex = 139
        Me.Label18.Text = "NUMBER OF HOUSES"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(653, 406)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(185, 18)
        Me.Label20.TabIndex = 138
        Me.Label20.Text = "PROPERTY LOCATION"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(72, 404)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(146, 18)
        Me.Label21.TabIndex = 137
        Me.Label21.Text = "PROPERTY NAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(36, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(432, 32)
        Me.Label3.TabIndex = 136
        Me.Label3.Text = "OWNERSHIP MANAGEMENT"
        '
        'frmOwner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.txtOwnerName)
        Me.Controls.Add(Me.rtbPropertyLocation)
        Me.Controls.Add(Me.rtbPropertyName)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cboViewOwnerAss)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.dgvOwnership)
        Me.Controls.Add(Me.nudNumberHouse)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmOwner"
        Me.Text = "frmOwner"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvOwnership, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudNumberHouse, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtOwnerName As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents rtbPropertyLocation As RichTextBox
    Friend WithEvents rtbPropertyName As RichTextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents cboViewOwnerAss As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label26 As Label
    Friend WithEvents dgvOwnership As DataGridView
    Friend WithEvents nudNumberHouse As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents Label18 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label3 As Label
End Class
