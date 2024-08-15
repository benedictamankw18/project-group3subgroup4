<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTenantManagement
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
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtPropertyPrice = New Guna.UI.WinForms.GunaLineTextBox()
        Me.dgvTenant = New System.Windows.Forms.DataGridView()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cboPropertyAss = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.nudNumberBathroom = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.nudNumberBedroom = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtPropertyLocation = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtPropertyName = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cboViewPropertyAS = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTenantDuration = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtTenantName = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.cboPropertyType = New Guna.UI2.WinForms.Guna2ComboBox()
        CType(Me.dgvTenant, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudNumberBathroom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudNumberBedroom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(397, 325)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(149, 18)
        Me.Label25.TabIndex = 68
        Me.Label25.Text = "PROPERTY PRICE"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(79, 325)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(139, 18)
        Me.Label26.TabIndex = 67
        Me.Label26.Text = "TENANT'S NAME"
        '
        'txtPropertyPrice
        '
        Me.txtPropertyPrice.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtPropertyPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPropertyPrice.Enabled = False
        Me.txtPropertyPrice.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPropertyPrice.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPropertyPrice.LineColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtPropertyPrice.Location = New System.Drawing.Point(442, 346)
        Me.txtPropertyPrice.Name = "txtPropertyPrice"
        Me.txtPropertyPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPropertyPrice.SelectedText = ""
        Me.txtPropertyPrice.Size = New System.Drawing.Size(231, 32)
        Me.txtPropertyPrice.TabIndex = 66
        '
        'dgvTenant
        '
        Me.dgvTenant.AllowUserToAddRows = False
        Me.dgvTenant.AllowUserToDeleteRows = False
        Me.dgvTenant.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvTenant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTenant.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvTenant.Location = New System.Drawing.Point(26, 95)
        Me.dgvTenant.Name = "dgvTenant"
        Me.dgvTenant.ReadOnly = True
        Me.dgvTenant.Size = New System.Drawing.Size(1296, 215)
        Me.dgvTenant.TabIndex = 61
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(727, 325)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(220, 18)
        Me.Label14.TabIndex = 60
        Me.Label14.Text = "PROPERTY ASSIGNED TO:"
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
        Me.cboPropertyAss.Location = New System.Drawing.Point(727, 346)
        Me.cboPropertyAss.Name = "cboPropertyAss"
        Me.cboPropertyAss.ShadowDecoration.Parent = Me.cboPropertyAss
        Me.cboPropertyAss.Size = New System.Drawing.Size(276, 36)
        Me.cboPropertyAss.TabIndex = 59
        '
        'nudNumberBathroom
        '
        Me.nudNumberBathroom.BackColor = System.Drawing.Color.Transparent
        Me.nudNumberBathroom.BorderRadius = 4
        Me.nudNumberBathroom.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.nudNumberBathroom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.nudNumberBathroom.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.nudNumberBathroom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.nudNumberBathroom.DisabledState.Parent = Me.nudNumberBathroom
        Me.nudNumberBathroom.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.nudNumberBathroom.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.nudNumberBathroom.Enabled = False
        Me.nudNumberBathroom.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.nudNumberBathroom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.nudNumberBathroom.FocusedState.Parent = Me.nudNumberBathroom
        Me.nudNumberBathroom.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudNumberBathroom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.nudNumberBathroom.Location = New System.Drawing.Point(397, 475)
        Me.nudNumberBathroom.Name = "nudNumberBathroom"
        Me.nudNumberBathroom.ShadowDecoration.Parent = Me.nudNumberBathroom
        Me.nudNumberBathroom.Size = New System.Drawing.Size(276, 36)
        Me.nudNumberBathroom.TabIndex = 56
        '
        'nudNumberBedroom
        '
        Me.nudNumberBedroom.BackColor = System.Drawing.Color.Transparent
        Me.nudNumberBedroom.BorderRadius = 4
        Me.nudNumberBedroom.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.nudNumberBedroom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.nudNumberBedroom.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.nudNumberBedroom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.nudNumberBedroom.DisabledState.Parent = Me.nudNumberBedroom
        Me.nudNumberBedroom.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.nudNumberBedroom.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.nudNumberBedroom.Enabled = False
        Me.nudNumberBedroom.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.nudNumberBedroom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.nudNumberBedroom.FocusedState.Parent = Me.nudNumberBedroom
        Me.nudNumberBedroom.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudNumberBedroom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.nudNumberBedroom.Location = New System.Drawing.Point(79, 475)
        Me.nudNumberBedroom.Name = "nudNumberBedroom"
        Me.nudNumberBedroom.ShadowDecoration.Parent = Me.nudNumberBedroom
        Me.nudNumberBedroom.Size = New System.Drawing.Size(276, 36)
        Me.nudNumberBedroom.TabIndex = 55
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(394, 454)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(204, 18)
        Me.Label17.TabIndex = 54
        Me.Label17.Text = "NUMBER OF BATHROOM"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(76, 454)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(194, 18)
        Me.Label18.TabIndex = 53
        Me.Label18.Text = "NUMBER OF BEDROOM"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(727, 389)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(141, 18)
        Me.Label19.TabIndex = 52
        Me.Label19.Text = "PROPERTY TYPE"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(397, 389)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(185, 18)
        Me.Label20.TabIndex = 50
        Me.Label20.Text = "PROPERTY LOCATION"
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
        Me.txtPropertyLocation.Location = New System.Drawing.Point(397, 411)
        Me.txtPropertyLocation.Name = "txtPropertyLocation"
        Me.txtPropertyLocation.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPropertyLocation.SelectedText = ""
        Me.txtPropertyLocation.Size = New System.Drawing.Size(276, 32)
        Me.txtPropertyLocation.TabIndex = 49
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(79, 389)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(146, 18)
        Me.Label21.TabIndex = 48
        Me.Label21.Text = "PROPERTY NAME"
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
        Me.txtPropertyName.Location = New System.Drawing.Point(79, 411)
        Me.txtPropertyName.Name = "txtPropertyName"
        Me.txtPropertyName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPropertyName.SelectedText = ""
        Me.txtPropertyName.Size = New System.Drawing.Size(276, 32)
        Me.txtPropertyName.TabIndex = 47
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(361, 32)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "TENANT MANAGEMENT"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(453, 48)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(271, 18)
        Me.Label13.TabIndex = 70
        Me.Label13.Text = "VIEW PROPERTY ASSIGNED TO:"
        '
        'cboViewPropertyAS
        '
        Me.cboViewPropertyAS.BackColor = System.Drawing.Color.Transparent
        Me.cboViewPropertyAS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboViewPropertyAS.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboViewPropertyAS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboViewPropertyAS.FocusedColor = System.Drawing.Color.Empty
        Me.cboViewPropertyAS.FocusedState.Parent = Me.cboViewPropertyAS
        Me.cboViewPropertyAS.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboViewPropertyAS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboViewPropertyAS.FormattingEnabled = True
        Me.cboViewPropertyAS.HoverState.Parent = Me.cboViewPropertyAS
        Me.cboViewPropertyAS.ItemHeight = 30
        Me.cboViewPropertyAS.ItemsAppearance.Parent = Me.cboViewPropertyAS
        Me.cboViewPropertyAS.Location = New System.Drawing.Point(730, 41)
        Me.cboViewPropertyAS.Name = "cboViewPropertyAS"
        Me.cboViewPropertyAS.ShadowDecoration.Parent = Me.cboViewPropertyAS
        Me.cboViewPropertyAS.Size = New System.Drawing.Size(276, 36)
        Me.cboViewPropertyAS.TabIndex = 69
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(727, 454)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 18)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "TENANT DURATION"
        '
        'txtTenantDuration
        '
        Me.txtTenantDuration.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtTenantDuration.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTenantDuration.Enabled = False
        Me.txtTenantDuration.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTenantDuration.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTenantDuration.LineColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtTenantDuration.Location = New System.Drawing.Point(727, 475)
        Me.txtTenantDuration.Name = "txtTenantDuration"
        Me.txtTenantDuration.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTenantDuration.SelectedText = ""
        Me.txtTenantDuration.Size = New System.Drawing.Size(276, 32)
        Me.txtTenantDuration.TabIndex = 72
        '
        'txtTenantName
        '
        Me.txtTenantName.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtTenantName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTenantName.Enabled = False
        Me.txtTenantName.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTenantName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTenantName.LineColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtTenantName.Location = New System.Drawing.Point(79, 346)
        Me.txtTenantName.Name = "txtTenantName"
        Me.txtTenantName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTenantName.SelectedText = ""
        Me.txtTenantName.Size = New System.Drawing.Size(276, 32)
        Me.txtTenantName.TabIndex = 74
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(404, 353)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(38, 18)
        Me.Label27.TabIndex = 75
        Me.Label27.Text = "Ghc"
        '
        'cboPropertyType
        '
        Me.cboPropertyType.AutoRoundedCorners = True
        Me.cboPropertyType.BackColor = System.Drawing.Color.Transparent
        Me.cboPropertyType.BorderRadius = 17
        Me.cboPropertyType.Cursor = System.Windows.Forms.Cursors.Hand
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
        Me.cboPropertyType.Items.AddRange(New Object() {"TOWNHOUSE", "RANCH-STYLE HOUSE", "BUNGALOW", "APARTMENT", "COLONIAL CRAFTSMAN", "MODULAR BUILDING", "CONDO", "CONTEMPORARY ARCHITECTURE", "CO-OPERATIVE HOUSING", "DUPLEX", "MID-CENTURY MODERN", "TINY HOME", "CAPE COD", "COTTAGE", "FARMHOUSE", "MEDITERRANEAN REVIVAL ARCHITECTURE", "TUDOR ARCHITECTURE", "VICTORIAN HOUSE", "FRENCH PROVINCIAL", "GREEK REVIVAL", "GEORGIAN ARCHITECTURE", "I-HOUSE", "CABIN"})
        Me.cboPropertyType.ItemsAppearance.Parent = Me.cboPropertyType
        Me.cboPropertyType.Location = New System.Drawing.Point(727, 407)
        Me.cboPropertyType.Name = "cboPropertyType"
        Me.cboPropertyType.ShadowDecoration.Parent = Me.cboPropertyType
        Me.cboPropertyType.Size = New System.Drawing.Size(276, 36)
        Me.cboPropertyType.TabIndex = 76
        '
        'frmTenantManagement
        '
        Me.AllowDrop = True
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.cboPropertyType)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.txtTenantName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTenantDuration)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cboViewPropertyAS)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.txtPropertyPrice)
        Me.Controls.Add(Me.dgvTenant)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cboPropertyAss)
        Me.Controls.Add(Me.nudNumberBathroom)
        Me.Controls.Add(Me.nudNumberBedroom)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txtPropertyLocation)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.txtPropertyName)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTenantManagement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmProduct"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvTenant, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudNumberBathroom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudNumberBedroom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents txtPropertyPrice As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents dgvTenant As DataGridView
    Friend WithEvents Label14 As Label
    Friend WithEvents cboPropertyAss As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents nudNumberBathroom As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents nudNumberBedroom As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents txtPropertyLocation As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txtPropertyName As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents cboViewPropertyAS As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTenantDuration As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtTenantName As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents cboPropertyType As Guna.UI2.WinForms.Guna2ComboBox
End Class
