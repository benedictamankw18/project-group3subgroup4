<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHouse
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
        Me.Label27 = New System.Windows.Forms.Label()
        Me.lblAvailability = New System.Windows.Forms.Label()
        Me.txtAvailability = New Guna.UI.WinForms.GunaLineTextBox()
        Me.dgvHouseManagement = New System.Windows.Forms.DataGridView()
        Me.nudNumberOfBathroom = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.nudNumberOfBedroom = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPropertyLocation = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPropertyName = New Guna.UI.WinForms.GunaLineTextBox()
        Me.cboPropertyType = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtPropertyPrice = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.pboPropertyImage3 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.pboPropertyImage2 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.pboPropertyImage4 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.pboPropertyImage1 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.cboPropertyAss = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgvHouseManagement, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudNumberOfBathroom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudNumberOfBedroom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboPropertyImage3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboPropertyImage2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboPropertyImage4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboPropertyImage1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.Label27.Location = New System.Drawing.Point(102, 601)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(38, 18)
        Me.Label27.TabIndex = 159
        Me.Label27.Text = "Ghc"
        '
        'lblAvailability
        '
        Me.lblAvailability.AutoSize = True
        Me.lblAvailability.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvailability.Location = New System.Drawing.Point(395, 573)
        Me.lblAvailability.Name = "lblAvailability"
        Me.lblAvailability.Size = New System.Drawing.Size(99, 18)
        Me.lblAvailability.TabIndex = 158
        Me.lblAvailability.Text = "Availability"
        '
        'txtAvailability
        '
        Me.txtAvailability.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtAvailability.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAvailability.Enabled = False
        Me.txtAvailability.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAvailability.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAvailability.LineColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtAvailability.Location = New System.Drawing.Point(392, 594)
        Me.txtAvailability.Name = "txtAvailability"
        Me.txtAvailability.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAvailability.SelectedText = ""
        Me.txtAvailability.Size = New System.Drawing.Size(276, 32)
        Me.txtAvailability.TabIndex = 157
        '
        'dgvHouseManagement
        '
        Me.dgvHouseManagement.AllowUserToAddRows = False
        Me.dgvHouseManagement.AllowUserToDeleteRows = False
        Me.dgvHouseManagement.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvHouseManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHouseManagement.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvHouseManagement.Location = New System.Drawing.Point(12, 69)
        Me.dgvHouseManagement.Name = "dgvHouseManagement"
        Me.dgvHouseManagement.ReadOnly = True
        Me.dgvHouseManagement.Size = New System.Drawing.Size(1241, 265)
        Me.dgvHouseManagement.TabIndex = 156
        '
        'nudNumberOfBathroom
        '
        Me.nudNumberOfBathroom.BackColor = System.Drawing.Color.Transparent
        Me.nudNumberOfBathroom.BorderRadius = 4
        Me.nudNumberOfBathroom.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.nudNumberOfBathroom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.nudNumberOfBathroom.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.nudNumberOfBathroom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.nudNumberOfBathroom.DisabledState.Parent = Me.nudNumberOfBathroom
        Me.nudNumberOfBathroom.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.nudNumberOfBathroom.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.nudNumberOfBathroom.Enabled = False
        Me.nudNumberOfBathroom.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.nudNumberOfBathroom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.nudNumberOfBathroom.FocusedState.Parent = Me.nudNumberOfBathroom
        Me.nudNumberOfBathroom.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudNumberOfBathroom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.nudNumberOfBathroom.Location = New System.Drawing.Point(392, 532)
        Me.nudNumberOfBathroom.Name = "nudNumberOfBathroom"
        Me.nudNumberOfBathroom.ShadowDecoration.Parent = Me.nudNumberOfBathroom
        Me.nudNumberOfBathroom.Size = New System.Drawing.Size(276, 32)
        Me.nudNumberOfBathroom.TabIndex = 148
        '
        'nudNumberOfBedroom
        '
        Me.nudNumberOfBedroom.BackColor = System.Drawing.Color.Transparent
        Me.nudNumberOfBedroom.BorderRadius = 4
        Me.nudNumberOfBedroom.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.nudNumberOfBedroom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.nudNumberOfBedroom.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.nudNumberOfBedroom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.nudNumberOfBedroom.DisabledState.Parent = Me.nudNumberOfBedroom
        Me.nudNumberOfBedroom.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.nudNumberOfBedroom.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.nudNumberOfBedroom.Enabled = False
        Me.nudNumberOfBedroom.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.nudNumberOfBedroom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.nudNumberOfBedroom.FocusedState.Parent = Me.nudNumberOfBedroom
        Me.nudNumberOfBedroom.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudNumberOfBedroom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.nudNumberOfBedroom.Location = New System.Drawing.Point(94, 534)
        Me.nudNumberOfBedroom.Name = "nudNumberOfBedroom"
        Me.nudNumberOfBedroom.ShadowDecoration.Parent = Me.nudNumberOfBedroom
        Me.nudNumberOfBedroom.Size = New System.Drawing.Size(276, 30)
        Me.nudNumberOfBedroom.TabIndex = 147
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(395, 511)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(204, 18)
        Me.Label8.TabIndex = 146
        Me.Label8.Text = "NUMBER OF BATHROOM"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(97, 511)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(194, 18)
        Me.Label7.TabIndex = 145
        Me.Label7.Text = "NUMBER OF BEDROOM"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(97, 381)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 18)
        Me.Label6.TabIndex = 144
        Me.Label6.Text = "PROPERTY TYPE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(395, 451)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(185, 18)
        Me.Label5.TabIndex = 143
        Me.Label5.Text = "PROPERTY LOCATION"
        '
        'txtPropertyLocation
        '
        Me.txtPropertyLocation.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtPropertyLocation.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPropertyLocation.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPropertyLocation.Enabled = False
        Me.txtPropertyLocation.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPropertyLocation.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPropertyLocation.LineColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtPropertyLocation.Location = New System.Drawing.Point(392, 472)
        Me.txtPropertyLocation.Name = "txtPropertyLocation"
        Me.txtPropertyLocation.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPropertyLocation.SelectedText = ""
        Me.txtPropertyLocation.Size = New System.Drawing.Size(276, 32)
        Me.txtPropertyLocation.TabIndex = 142
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(97, 451)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 18)
        Me.Label4.TabIndex = 141
        Me.Label4.Text = "PROPERTY NAME"
        '
        'txtPropertyName
        '
        Me.txtPropertyName.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtPropertyName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPropertyName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPropertyName.Enabled = False
        Me.txtPropertyName.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPropertyName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPropertyName.LineColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtPropertyName.Location = New System.Drawing.Point(94, 472)
        Me.txtPropertyName.Name = "txtPropertyName"
        Me.txtPropertyName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPropertyName.SelectedText = ""
        Me.txtPropertyName.Size = New System.Drawing.Size(276, 32)
        Me.txtPropertyName.TabIndex = 140
        '
        'cboPropertyType
        '
        Me.cboPropertyType.AutoRoundedCorners = True
        Me.cboPropertyType.BackColor = System.Drawing.Color.Transparent
        Me.cboPropertyType.BorderRadius = 17
        Me.cboPropertyType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboPropertyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPropertyType.Enabled = False
        Me.cboPropertyType.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cboPropertyType.FocusedColor = System.Drawing.Color.Empty
        Me.cboPropertyType.FocusedState.Parent = Me.cboPropertyType
        Me.cboPropertyType.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboPropertyType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboPropertyType.FormattingEnabled = True
        Me.cboPropertyType.HoverState.Parent = Me.cboPropertyType
        Me.cboPropertyType.ItemHeight = 30
        Me.cboPropertyType.ItemsAppearance.Parent = Me.cboPropertyType
        Me.cboPropertyType.Location = New System.Drawing.Point(94, 405)
        Me.cboPropertyType.Name = "cboPropertyType"
        Me.cboPropertyType.ShadowDecoration.Parent = Me.cboPropertyType
        Me.cboPropertyType.Size = New System.Drawing.Size(276, 36)
        Me.cboPropertyType.TabIndex = 155
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(97, 573)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(149, 18)
        Me.Label24.TabIndex = 154
        Me.Label24.Text = "PROPERTY PRICE"
        '
        'txtPropertyPrice
        '
        Me.txtPropertyPrice.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtPropertyPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPropertyPrice.Enabled = False
        Me.txtPropertyPrice.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPropertyPrice.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPropertyPrice.LineColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtPropertyPrice.Location = New System.Drawing.Point(145, 594)
        Me.txtPropertyPrice.Name = "txtPropertyPrice"
        Me.txtPropertyPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPropertyPrice.SelectedText = ""
        Me.txtPropertyPrice.Size = New System.Drawing.Size(225, 32)
        Me.txtPropertyPrice.TabIndex = 153
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(395, 381)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(220, 18)
        Me.Label11.TabIndex = 152
        Me.Label11.Text = "PROPERTY ASSIGNED TO:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(687, 381)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(191, 18)
        Me.Label9.TabIndex = 150
        Me.Label9.Text = "IMAGES OF PROPERTY"
        '
        'pboPropertyImage3
        '
        Me.pboPropertyImage3.BackColor = System.Drawing.Color.Transparent
        Me.pboPropertyImage3.BaseColor = System.Drawing.Color.Black
        Me.pboPropertyImage3.BaseDepth = 2
        Me.pboPropertyImage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pboPropertyImage3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pboPropertyImage3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pboPropertyImage3.Location = New System.Drawing.Point(3, 115)
        Me.pboPropertyImage3.Name = "pboPropertyImage3"
        Me.pboPropertyImage3.Size = New System.Drawing.Size(163, 106)
        Me.pboPropertyImage3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboPropertyImage3.TabIndex = 16
        Me.pboPropertyImage3.TabStop = False
        '
        'pboPropertyImage2
        '
        Me.pboPropertyImage2.BackColor = System.Drawing.Color.Transparent
        Me.pboPropertyImage2.BaseColor = System.Drawing.Color.Black
        Me.pboPropertyImage2.BaseDepth = 2
        Me.pboPropertyImage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pboPropertyImage2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pboPropertyImage2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pboPropertyImage2.Location = New System.Drawing.Point(172, 3)
        Me.pboPropertyImage2.Name = "pboPropertyImage2"
        Me.pboPropertyImage2.Size = New System.Drawing.Size(164, 106)
        Me.pboPropertyImage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboPropertyImage2.TabIndex = 17
        Me.pboPropertyImage2.TabStop = False
        '
        'pboPropertyImage4
        '
        Me.pboPropertyImage4.BackColor = System.Drawing.Color.Transparent
        Me.pboPropertyImage4.BaseColor = System.Drawing.Color.Black
        Me.pboPropertyImage4.BaseDepth = 2
        Me.pboPropertyImage4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pboPropertyImage4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pboPropertyImage4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pboPropertyImage4.Location = New System.Drawing.Point(172, 115)
        Me.pboPropertyImage4.Name = "pboPropertyImage4"
        Me.pboPropertyImage4.Size = New System.Drawing.Size(164, 106)
        Me.pboPropertyImage4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboPropertyImage4.TabIndex = 15
        Me.pboPropertyImage4.TabStop = False
        '
        'pboPropertyImage1
        '
        Me.pboPropertyImage1.BackColor = System.Drawing.Color.Transparent
        Me.pboPropertyImage1.BaseColor = System.Drawing.Color.Black
        Me.pboPropertyImage1.BaseDepth = 2
        Me.pboPropertyImage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pboPropertyImage1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pboPropertyImage1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pboPropertyImage1.Location = New System.Drawing.Point(3, 3)
        Me.pboPropertyImage1.Name = "pboPropertyImage1"
        Me.pboPropertyImage1.Size = New System.Drawing.Size(163, 106)
        Me.pboPropertyImage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboPropertyImage1.TabIndex = 14
        Me.pboPropertyImage1.TabStop = False
        '
        'cboPropertyAss
        '
        Me.cboPropertyAss.BackColor = System.Drawing.Color.Transparent
        Me.cboPropertyAss.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboPropertyAss.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboPropertyAss.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPropertyAss.Enabled = False
        Me.cboPropertyAss.FocusedColor = System.Drawing.Color.Empty
        Me.cboPropertyAss.FocusedState.Parent = Me.cboPropertyAss
        Me.cboPropertyAss.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboPropertyAss.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboPropertyAss.FormattingEnabled = True
        Me.cboPropertyAss.HoverState.Parent = Me.cboPropertyAss
        Me.cboPropertyAss.ItemHeight = 30
        Me.cboPropertyAss.ItemsAppearance.Parent = Me.cboPropertyAss
        Me.cboPropertyAss.Location = New System.Drawing.Point(392, 405)
        Me.cboPropertyAss.Name = "cboPropertyAss"
        Me.cboPropertyAss.ShadowDecoration.Parent = Me.cboPropertyAss
        Me.cboPropertyAss.Size = New System.Drawing.Size(276, 36)
        Me.cboPropertyAss.TabIndex = 151
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.pboPropertyImage3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.pboPropertyImage2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.pboPropertyImage4, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.pboPropertyImage1, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(690, 405)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(339, 224)
        Me.TableLayoutPanel1.TabIndex = 149
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(387, 32)
        Me.Label3.TabIndex = 139
        Me.Label3.Text = "HOUSING MANAGEMENT"
        '
        'frmHouse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.lblAvailability)
        Me.Controls.Add(Me.txtAvailability)
        Me.Controls.Add(Me.dgvHouseManagement)
        Me.Controls.Add(Me.nudNumberOfBathroom)
        Me.Controls.Add(Me.nudNumberOfBedroom)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPropertyLocation)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPropertyName)
        Me.Controls.Add(Me.cboPropertyType)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.txtPropertyPrice)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cboPropertyAss)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmHouse"
        Me.Text = "frmHouse"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvHouseManagement, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudNumberOfBathroom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudNumberOfBedroom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboPropertyImage3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboPropertyImage2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboPropertyImage4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboPropertyImage1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label27 As Label
    Friend WithEvents lblAvailability As Label
    Friend WithEvents txtAvailability As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents dgvHouseManagement As DataGridView
    Friend WithEvents nudNumberOfBathroom As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents nudNumberOfBedroom As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPropertyLocation As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPropertyName As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents cboPropertyType As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txtPropertyPrice As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents pboPropertyImage3 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents pboPropertyImage2 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents pboPropertyImage4 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents pboPropertyImage1 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents cboPropertyAss As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label3 As Label
End Class
