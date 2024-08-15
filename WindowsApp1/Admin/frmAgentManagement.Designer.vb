<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAgentManagement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgentManagement))
        Me.tpcAgentManagement = New System.Windows.Forms.TabControl()
        Me.tbpAdd = New System.Windows.Forms.TabPage()
        Me.lblLastname = New Guna.UI.WinForms.GunaLabel()
        Me.lblMiddlename = New Guna.UI.WinForms.GunaLabel()
        Me.lblCountry = New Guna.UI.WinForms.GunaLabel()
        Me.cboCountry = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblSecondMobileNumber = New Guna.UI.WinForms.GunaLabel()
        Me.txtSecondMobileNumber = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblMobileNumber = New Guna.UI.WinForms.GunaLabel()
        Me.lblSecondEmail = New Guna.UI.WinForms.GunaLabel()
        Me.lblEmail = New Guna.UI.WinForms.GunaLabel()
        Me.txtMobileNumber = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtSecondEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblDob = New Guna.UI.WinForms.GunaLabel()
        Me.lblSecondAddress = New Guna.UI.WinForms.GunaLabel()
        Me.txtSecondAddress = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblAddress = New Guna.UI.WinForms.GunaLabel()
        Me.rdoFemale = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.rdoMale = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.lblGender = New Guna.UI.WinForms.GunaLabel()
        Me.dtpDOB = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.lblFirstname = New Guna.UI.WinForms.GunaLabel()
        Me.txtAddress = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtLname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtMname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtFname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnClear = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnSave = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbpDelete = New System.Windows.Forms.TabPage()
        Me.dgvDelete = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnDeleteAll = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnDelete = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.cboCountryUpdate = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblSecPhoneNumber = New Guna.UI.WinForms.GunaLabel()
        Me.txtSecPhoneNoUpdate = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblPhoneNumUpdate = New Guna.UI.WinForms.GunaLabel()
        Me.lblSecEmail = New Guna.UI.WinForms.GunaLabel()
        Me.lblemailUpdate = New Guna.UI.WinForms.GunaLabel()
        Me.txtPhoneNoUpdate = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtSecEmailUpdate = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtEmailUpdate = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.lblSecAddress = New Guna.UI.WinForms.GunaLabel()
        Me.txtSecAddressUpdate = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblAddressUpdate = New Guna.UI.WinForms.GunaLabel()
        Me.rboFemaleUpdate = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.rboMaleUpdate = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.GunaLabel9 = New Guna.UI.WinForms.GunaLabel()
        Me.dtpDOBUpdate = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.lblLNameUpdate = New Guna.UI.WinForms.GunaLabel()
        Me.lblMNameUpdate = New Guna.UI.WinForms.GunaLabel()
        Me.lblFnameUpdate = New Guna.UI.WinForms.GunaLabel()
        Me.txtAddressUpdate = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtLNameUpdate = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtMnameUpdate = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtFNameUpdate = New Guna.UI2.WinForms.Guna2TextBox()
        Me.dgvUpdate = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnUpdate = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.tpcAgentManagement.SuspendLayout()
        Me.tbpAdd.SuspendLayout()
        Me.tbpDelete.SuspendLayout()
        CType(Me.dgvDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgvUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tpcAgentManagement
        '
        Me.tpcAgentManagement.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.tpcAgentManagement.Controls.Add(Me.tbpAdd)
        Me.tpcAgentManagement.Controls.Add(Me.tbpDelete)
        Me.tpcAgentManagement.Controls.Add(Me.TabPage3)
        Me.tpcAgentManagement.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tpcAgentManagement.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tpcAgentManagement.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tpcAgentManagement.Location = New System.Drawing.Point(0, 0)
        Me.tpcAgentManagement.Multiline = True
        Me.tpcAgentManagement.Name = "tpcAgentManagement"
        Me.tpcAgentManagement.SelectedIndex = 0
        Me.tpcAgentManagement.Size = New System.Drawing.Size(1104, 788)
        Me.tpcAgentManagement.TabIndex = 4
        '
        'tbpAdd
        '
        Me.tbpAdd.BackColor = System.Drawing.Color.Transparent
        Me.tbpAdd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tbpAdd.Controls.Add(Me.lblLastname)
        Me.tbpAdd.Controls.Add(Me.lblMiddlename)
        Me.tbpAdd.Controls.Add(Me.lblCountry)
        Me.tbpAdd.Controls.Add(Me.cboCountry)
        Me.tbpAdd.Controls.Add(Me.lblSecondMobileNumber)
        Me.tbpAdd.Controls.Add(Me.txtSecondMobileNumber)
        Me.tbpAdd.Controls.Add(Me.lblMobileNumber)
        Me.tbpAdd.Controls.Add(Me.lblSecondEmail)
        Me.tbpAdd.Controls.Add(Me.lblEmail)
        Me.tbpAdd.Controls.Add(Me.txtMobileNumber)
        Me.tbpAdd.Controls.Add(Me.txtSecondEmail)
        Me.tbpAdd.Controls.Add(Me.txtEmail)
        Me.tbpAdd.Controls.Add(Me.lblDob)
        Me.tbpAdd.Controls.Add(Me.lblSecondAddress)
        Me.tbpAdd.Controls.Add(Me.txtSecondAddress)
        Me.tbpAdd.Controls.Add(Me.lblAddress)
        Me.tbpAdd.Controls.Add(Me.rdoFemale)
        Me.tbpAdd.Controls.Add(Me.rdoMale)
        Me.tbpAdd.Controls.Add(Me.lblGender)
        Me.tbpAdd.Controls.Add(Me.dtpDOB)
        Me.tbpAdd.Controls.Add(Me.lblFirstname)
        Me.tbpAdd.Controls.Add(Me.txtAddress)
        Me.tbpAdd.Controls.Add(Me.txtLname)
        Me.tbpAdd.Controls.Add(Me.txtMname)
        Me.tbpAdd.Controls.Add(Me.txtFname)
        Me.tbpAdd.Controls.Add(Me.btnClear)
        Me.tbpAdd.Controls.Add(Me.btnSave)
        Me.tbpAdd.Controls.Add(Me.Label1)
        Me.tbpAdd.Location = New System.Drawing.Point(4, 30)
        Me.tbpAdd.Name = "tbpAdd"
        Me.tbpAdd.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpAdd.Size = New System.Drawing.Size(1096, 754)
        Me.tbpAdd.TabIndex = 0
        Me.tbpAdd.Text = "ADD"
        '
        'lblLastname
        '
        Me.lblLastname.AutoSize = True
        Me.lblLastname.BackColor = System.Drawing.Color.Transparent
        Me.lblLastname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblLastname.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLastname.Location = New System.Drawing.Point(300, 64)
        Me.lblLastname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLastname.Name = "lblLastname"
        Me.lblLastname.Size = New System.Drawing.Size(75, 15)
        Me.lblLastname.TabIndex = 44
        Me.lblLastname.Text = "LASTNAME *"
        '
        'lblMiddlename
        '
        Me.lblMiddlename.AutoSize = True
        Me.lblMiddlename.BackColor = System.Drawing.Color.Transparent
        Me.lblMiddlename.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblMiddlename.Location = New System.Drawing.Point(545, 62)
        Me.lblMiddlename.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMiddlename.Name = "lblMiddlename"
        Me.lblMiddlename.Size = New System.Drawing.Size(86, 15)
        Me.lblMiddlename.TabIndex = 43
        Me.lblMiddlename.Text = "MIDDLE NAME"
        '
        'lblCountry
        '
        Me.lblCountry.AutoSize = True
        Me.lblCountry.BackColor = System.Drawing.Color.Transparent
        Me.lblCountry.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblCountry.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCountry.Location = New System.Drawing.Point(51, 267)
        Me.lblCountry.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(88, 15)
        Me.lblCountry.TabIndex = 66
        Me.lblCountry.Text = "NATIONALITY *"
        '
        'cboCountry
        '
        Me.cboCountry.Animated = True
        Me.cboCountry.AutoRoundedCorners = True
        Me.cboCountry.BackColor = System.Drawing.Color.Transparent
        Me.cboCountry.BorderRadius = 22
        Me.cboCountry.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboCountry.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cboCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCountry.FocusedColor = System.Drawing.Color.Blue
        Me.cboCountry.FocusedState.BorderColor = System.Drawing.Color.Blue
        Me.cboCountry.FocusedState.Parent = Me.cboCountry
        Me.cboCountry.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCountry.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboCountry.FormattingEnabled = True
        Me.cboCountry.HoverState.Parent = Me.cboCountry
        Me.cboCountry.ItemHeight = 40
        Me.cboCountry.Items.AddRange(New Object() {"Algerian", "Angolan", "Beninese", "Botswanan", "Burkinabe", "Burundian", "Cameroonian", "Cape Verdean", "Central African", "Chadian", "Comorian", "Congolese (Congo-Brazzaville)", "Congolese (Congo-Kinshasa)", "Djiboutian", "Egyptian", "Equatorial Guinean", "Eritrean", "Eswatini", "Ethiopian", "Gabonese", "Gambian", "Ghanaian", "Guinean", "Guinean-Bissauan", "Ivorian", "Kenyan", "Lesotho", "Liberian", "Libyan", "Madagascan", "Malawian", "Malian", "Mauritanian", "Mauritian", "Moroccan", "Mozambican", "Namibian", "Nigerian", "Nigerien", "Rwandan", "São Toméan", "Senegalese", "Seychellois", "Sierra Leonean", "Somali", "South African", "South Sudanese", "Sudanese", "Tanzanian", "Togolese", "Tunisian", "Ugandan", "Zambian", "Zimbabwean"})
        Me.cboCountry.ItemsAppearance.Parent = Me.cboCountry
        Me.cboCountry.Location = New System.Drawing.Point(27, 277)
        Me.cboCountry.Margin = New System.Windows.Forms.Padding(10)
        Me.cboCountry.Name = "cboCountry"
        Me.cboCountry.ShadowDecoration.Parent = Me.cboCountry
        Me.cboCountry.Size = New System.Drawing.Size(235, 46)
        Me.cboCountry.Sorted = True
        Me.cboCountry.TabIndex = 72
        '
        'lblSecondMobileNumber
        '
        Me.lblSecondMobileNumber.AutoSize = True
        Me.lblSecondMobileNumber.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblSecondMobileNumber.Location = New System.Drawing.Point(545, 269)
        Me.lblSecondMobileNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSecondMobileNumber.Name = "lblSecondMobileNumber"
        Me.lblSecondMobileNumber.Size = New System.Drawing.Size(149, 15)
        Me.lblSecondMobileNumber.TabIndex = 71
        Me.lblSecondMobileNumber.Text = "SECOND MOBILE NUMBER"
        '
        'txtSecondMobileNumber
        '
        Me.txtSecondMobileNumber.BackColor = System.Drawing.Color.Transparent
        Me.txtSecondMobileNumber.BorderRadius = 20
        Me.txtSecondMobileNumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSecondMobileNumber.DefaultText = ""
        Me.txtSecondMobileNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSecondMobileNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSecondMobileNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSecondMobileNumber.DisabledState.Parent = Me.txtSecondMobileNumber
        Me.txtSecondMobileNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSecondMobileNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSecondMobileNumber.FocusedState.Parent = Me.txtSecondMobileNumber
        Me.txtSecondMobileNumber.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSecondMobileNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSecondMobileNumber.HoverState.Parent = Me.txtSecondMobileNumber
        Me.txtSecondMobileNumber.Location = New System.Drawing.Point(521, 278)
        Me.txtSecondMobileNumber.Margin = New System.Windows.Forms.Padding(5)
        Me.txtSecondMobileNumber.Name = "txtSecondMobileNumber"
        Me.txtSecondMobileNumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSecondMobileNumber.PlaceholderText = "SECOND MOBILE NUMBER"
        Me.txtSecondMobileNumber.SelectedText = ""
        Me.txtSecondMobileNumber.ShadowDecoration.Parent = Me.txtSecondMobileNumber
        Me.txtSecondMobileNumber.Size = New System.Drawing.Size(235, 45)
        Me.txtSecondMobileNumber.TabIndex = 69
        '
        'lblMobileNumber
        '
        Me.lblMobileNumber.AutoSize = True
        Me.lblMobileNumber.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblMobileNumber.Location = New System.Drawing.Point(300, 269)
        Me.lblMobileNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMobileNumber.Name = "lblMobileNumber"
        Me.lblMobileNumber.Size = New System.Drawing.Size(108, 15)
        Me.lblMobileNumber.TabIndex = 67
        Me.lblMobileNumber.Text = "MOBILE NUMBER *"
        '
        'lblSecondEmail
        '
        Me.lblSecondEmail.AutoSize = True
        Me.lblSecondEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblSecondEmail.Location = New System.Drawing.Point(545, 128)
        Me.lblSecondEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSecondEmail.Name = "lblSecondEmail"
        Me.lblSecondEmail.Size = New System.Drawing.Size(90, 15)
        Me.lblSecondEmail.TabIndex = 65
        Me.lblSecondEmail.Text = "SECOND EMAIL"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblEmail.Location = New System.Drawing.Point(300, 130)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(49, 15)
        Me.lblEmail.TabIndex = 64
        Me.lblEmail.Text = "EMAIL *"
        '
        'txtMobileNumber
        '
        Me.txtMobileNumber.BackColor = System.Drawing.Color.Transparent
        Me.txtMobileNumber.BorderRadius = 20
        Me.txtMobileNumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMobileNumber.DefaultText = ""
        Me.txtMobileNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtMobileNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtMobileNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMobileNumber.DisabledState.Parent = Me.txtMobileNumber
        Me.txtMobileNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMobileNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMobileNumber.FocusedState.Parent = Me.txtMobileNumber
        Me.txtMobileNumber.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobileNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMobileNumber.HoverState.Parent = Me.txtMobileNumber
        Me.txtMobileNumber.Location = New System.Drawing.Point(276, 278)
        Me.txtMobileNumber.Margin = New System.Windows.Forms.Padding(5)
        Me.txtMobileNumber.Name = "txtMobileNumber"
        Me.txtMobileNumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMobileNumber.PlaceholderText = "MOBILE NUMBER *"
        Me.txtMobileNumber.SelectedText = ""
        Me.txtMobileNumber.ShadowDecoration.Parent = Me.txtMobileNumber
        Me.txtMobileNumber.Size = New System.Drawing.Size(235, 45)
        Me.txtMobileNumber.TabIndex = 62
        '
        'txtSecondEmail
        '
        Me.txtSecondEmail.BackColor = System.Drawing.Color.Transparent
        Me.txtSecondEmail.BorderRadius = 20
        Me.txtSecondEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSecondEmail.DefaultText = ""
        Me.txtSecondEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSecondEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSecondEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSecondEmail.DisabledState.Parent = Me.txtSecondEmail
        Me.txtSecondEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSecondEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSecondEmail.FocusedState.Parent = Me.txtSecondEmail
        Me.txtSecondEmail.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSecondEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSecondEmail.HoverState.Parent = Me.txtSecondEmail
        Me.txtSecondEmail.Location = New System.Drawing.Point(521, 139)
        Me.txtSecondEmail.Margin = New System.Windows.Forms.Padding(5)
        Me.txtSecondEmail.Name = "txtSecondEmail"
        Me.txtSecondEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSecondEmail.PlaceholderText = "SECOND EMAIL"
        Me.txtSecondEmail.SelectedText = ""
        Me.txtSecondEmail.ShadowDecoration.Parent = Me.txtSecondEmail
        Me.txtSecondEmail.Size = New System.Drawing.Size(235, 45)
        Me.txtSecondEmail.TabIndex = 61
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.Transparent
        Me.txtEmail.BorderRadius = 20
        Me.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmail.DefaultText = ""
        Me.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.DisabledState.Parent = Me.txtEmail
        Me.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.FocusedState.Parent = Me.txtEmail
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.HoverState.Parent = Me.txtEmail
        Me.txtEmail.Location = New System.Drawing.Point(276, 139)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(5)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmail.PlaceholderText = "EMAIL *"
        Me.txtEmail.SelectedText = ""
        Me.txtEmail.ShadowDecoration.Parent = Me.txtEmail
        Me.txtEmail.Size = New System.Drawing.Size(235, 45)
        Me.txtEmail.TabIndex = 60
        '
        'lblDob
        '
        Me.lblDob.AutoSize = True
        Me.lblDob.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblDob.Location = New System.Drawing.Point(51, 128)
        Me.lblDob.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDob.Name = "lblDob"
        Me.lblDob.Size = New System.Drawing.Size(94, 15)
        Me.lblDob.TabIndex = 52
        Me.lblDob.Text = "DATE OF BIRTH *"
        '
        'lblSecondAddress
        '
        Me.lblSecondAddress.AutoSize = True
        Me.lblSecondAddress.BackColor = System.Drawing.Color.Transparent
        Me.lblSecondAddress.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblSecondAddress.Location = New System.Drawing.Point(545, 205)
        Me.lblSecondAddress.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSecondAddress.Name = "lblSecondAddress"
        Me.lblSecondAddress.Size = New System.Drawing.Size(105, 15)
        Me.lblSecondAddress.TabIndex = 51
        Me.lblSecondAddress.Text = "SECOND ADDRESS"
        '
        'txtSecondAddress
        '
        Me.txtSecondAddress.BackColor = System.Drawing.Color.Transparent
        Me.txtSecondAddress.BorderRadius = 20
        Me.txtSecondAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSecondAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSecondAddress.DefaultText = ""
        Me.txtSecondAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSecondAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSecondAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSecondAddress.DisabledState.Parent = Me.txtSecondAddress
        Me.txtSecondAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSecondAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSecondAddress.FocusedState.Parent = Me.txtSecondAddress
        Me.txtSecondAddress.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSecondAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSecondAddress.HoverState.Parent = Me.txtSecondAddress
        Me.txtSecondAddress.Location = New System.Drawing.Point(521, 214)
        Me.txtSecondAddress.Margin = New System.Windows.Forms.Padding(5)
        Me.txtSecondAddress.Name = "txtSecondAddress"
        Me.txtSecondAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSecondAddress.PlaceholderText = "SECOND ADDRESS"
        Me.txtSecondAddress.SelectedText = ""
        Me.txtSecondAddress.ShadowDecoration.Parent = Me.txtSecondAddress
        Me.txtSecondAddress.Size = New System.Drawing.Size(235, 45)
        Me.txtSecondAddress.TabIndex = 50
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.BackColor = System.Drawing.Color.Transparent
        Me.lblAddress.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblAddress.Location = New System.Drawing.Point(300, 205)
        Me.lblAddress.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(64, 15)
        Me.lblAddress.TabIndex = 49
        Me.lblAddress.Text = "ADDRESS *"
        '
        'rdoFemale
        '
        Me.rdoFemale.AutoSize = True
        Me.rdoFemale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdoFemale.CheckedState.BorderThickness = 0
        Me.rdoFemale.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdoFemale.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rdoFemale.CheckedState.InnerOffset = -4
        Me.rdoFemale.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoFemale.Location = New System.Drawing.Point(146, 238)
        Me.rdoFemale.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoFemale.Name = "rdoFemale"
        Me.rdoFemale.Size = New System.Drawing.Size(80, 21)
        Me.rdoFemale.TabIndex = 48
        Me.rdoFemale.TabStop = True
        Me.rdoFemale.Text = "FEMALE"
        Me.rdoFemale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rdoFemale.UncheckedState.BorderThickness = 2
        Me.rdoFemale.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rdoFemale.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.rdoFemale.UseVisualStyleBackColor = True
        '
        'rdoMale
        '
        Me.rdoMale.AutoSize = True
        Me.rdoMale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdoMale.CheckedState.BorderThickness = 0
        Me.rdoMale.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdoMale.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rdoMale.CheckedState.InnerOffset = -4
        Me.rdoMale.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoMale.Location = New System.Drawing.Point(55, 238)
        Me.rdoMale.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoMale.Name = "rdoMale"
        Me.rdoMale.Size = New System.Drawing.Size(63, 21)
        Me.rdoMale.TabIndex = 47
        Me.rdoMale.TabStop = True
        Me.rdoMale.Text = "MALE"
        Me.rdoMale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rdoMale.UncheckedState.BorderThickness = 2
        Me.rdoMale.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rdoMale.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.rdoMale.UseVisualStyleBackColor = True
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblGender.Location = New System.Drawing.Point(57, 202)
        Me.lblGender.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(59, 15)
        Me.lblGender.TabIndex = 46
        Me.lblGender.Text = "GENDER *"
        '
        'dtpDOB
        '
        Me.dtpDOB.BackColor = System.Drawing.Color.Transparent
        Me.dtpDOB.BaseColor = System.Drawing.Color.White
        Me.dtpDOB.BorderColor = System.Drawing.Color.Silver
        Me.dtpDOB.BorderSize = 0
        Me.dtpDOB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpDOB.CustomFormat = Nothing
        Me.dtpDOB.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpDOB.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpDOB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDOB.ForeColor = System.Drawing.Color.Black
        Me.dtpDOB.Location = New System.Drawing.Point(27, 139)
        Me.dtpDOB.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpDOB.MaxDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dtpDOB.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.OnHoverBaseColor = System.Drawing.Color.White
        Me.dtpDOB.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpDOB.OnHoverForeColor = System.Drawing.Color.Black
        Me.dtpDOB.OnPressedColor = System.Drawing.Color.Black
        Me.dtpDOB.Radius = 20
        Me.dtpDOB.Size = New System.Drawing.Size(235, 45)
        Me.dtpDOB.TabIndex = 45
        Me.dtpDOB.Text = "01 November 1999"
        Me.dtpDOB.Value = New Date(1999, 11, 1, 0, 0, 0, 0)
        '
        'lblFirstname
        '
        Me.lblFirstname.AutoSize = True
        Me.lblFirstname.BackColor = System.Drawing.Color.Transparent
        Me.lblFirstname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblFirstname.Location = New System.Drawing.Point(51, 64)
        Me.lblFirstname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFirstname.Name = "lblFirstname"
        Me.lblFirstname.Size = New System.Drawing.Size(77, 15)
        Me.lblFirstname.TabIndex = 42
        Me.lblFirstname.Text = "FIRSTNAME *"
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.Color.Transparent
        Me.txtAddress.BorderRadius = 20
        Me.txtAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAddress.DefaultText = ""
        Me.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAddress.DisabledState.Parent = Me.txtAddress
        Me.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAddress.FocusedState.Parent = Me.txtAddress
        Me.txtAddress.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAddress.HoverState.Parent = Me.txtAddress
        Me.txtAddress.Location = New System.Drawing.Point(276, 214)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(5)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAddress.PlaceholderText = "ADDRESS *"
        Me.txtAddress.SelectedText = ""
        Me.txtAddress.ShadowDecoration.Parent = Me.txtAddress
        Me.txtAddress.Size = New System.Drawing.Size(235, 45)
        Me.txtAddress.TabIndex = 41
        '
        'txtLname
        '
        Me.txtLname.BackColor = System.Drawing.Color.Transparent
        Me.txtLname.BorderRadius = 20
        Me.txtLname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLname.DefaultText = ""
        Me.txtLname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtLname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtLname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLname.DisabledState.Parent = Me.txtLname
        Me.txtLname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLname.FocusedState.Parent = Me.txtLname
        Me.txtLname.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLname.HoverState.Parent = Me.txtLname
        Me.txtLname.Location = New System.Drawing.Point(276, 73)
        Me.txtLname.Margin = New System.Windows.Forms.Padding(5)
        Me.txtLname.Name = "txtLname"
        Me.txtLname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLname.PlaceholderText = "LASTNAME *"
        Me.txtLname.SelectedText = ""
        Me.txtLname.ShadowDecoration.Parent = Me.txtLname
        Me.txtLname.Size = New System.Drawing.Size(235, 45)
        Me.txtLname.TabIndex = 40
        '
        'txtMname
        '
        Me.txtMname.BackColor = System.Drawing.Color.Transparent
        Me.txtMname.BorderRadius = 20
        Me.txtMname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMname.DefaultText = ""
        Me.txtMname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtMname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtMname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMname.DisabledState.Parent = Me.txtMname
        Me.txtMname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMname.FocusedState.Parent = Me.txtMname
        Me.txtMname.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMname.HoverState.Parent = Me.txtMname
        Me.txtMname.Location = New System.Drawing.Point(521, 73)
        Me.txtMname.Margin = New System.Windows.Forms.Padding(5)
        Me.txtMname.Name = "txtMname"
        Me.txtMname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMname.PlaceholderText = "MIDDLE NAME"
        Me.txtMname.SelectedText = ""
        Me.txtMname.ShadowDecoration.Parent = Me.txtMname
        Me.txtMname.Size = New System.Drawing.Size(235, 45)
        Me.txtMname.TabIndex = 39
        '
        'txtFname
        '
        Me.txtFname.BackColor = System.Drawing.Color.Transparent
        Me.txtFname.BorderRadius = 20
        Me.txtFname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFname.DefaultText = ""
        Me.txtFname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFname.DisabledState.Parent = Me.txtFname
        Me.txtFname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFname.FocusedState.Parent = Me.txtFname
        Me.txtFname.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFname.HoverState.Parent = Me.txtFname
        Me.txtFname.Location = New System.Drawing.Point(27, 73)
        Me.txtFname.Margin = New System.Windows.Forms.Padding(5)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFname.PlaceholderText = "FIRSTNAME *"
        Me.txtFname.SelectedText = ""
        Me.txtFname.ShadowDecoration.Parent = Me.txtFname
        Me.txtFname.Size = New System.Drawing.Size(235, 45)
        Me.txtFname.TabIndex = 38
        '
        'btnClear
        '
        Me.btnClear.AnimationHoverSpeed = 0.07!
        Me.btnClear.AnimationSpeed = 0.03!
        Me.btnClear.BaseColor = System.Drawing.Color.Red
        Me.btnClear.BorderColor = System.Drawing.Color.Black
        Me.btnClear.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnClear.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnClear.CheckedForeColor = System.Drawing.Color.White
        Me.btnClear.CheckedImage = CType(resources.GetObject("btnClear.CheckedImage"), System.Drawing.Image)
        Me.btnClear.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnClear.FocusedColor = System.Drawing.Color.Empty
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Image = Global.WindowsApp1.My.Resources.Resources._006_clean
        Me.btnClear.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnClear.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnClear.LineBottom = 2
        Me.btnClear.LineColor = System.Drawing.Color.Maroon
        Me.btnClear.Location = New System.Drawing.Point(317, 421)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClear.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnClear.OnHoverForeColor = System.Drawing.Color.White
        Me.btnClear.OnHoverImage = Nothing
        Me.btnClear.OnHoverLineColor = System.Drawing.Color.Maroon
        Me.btnClear.OnPressedColor = System.Drawing.Color.Black
        Me.btnClear.Size = New System.Drawing.Size(143, 42)
        Me.btnClear.TabIndex = 25
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSave
        '
        Me.btnSave.AnimationHoverSpeed = 0.07!
        Me.btnSave.AnimationSpeed = 0.03!
        Me.btnSave.BaseColor = System.Drawing.Color.Lime
        Me.btnSave.BorderColor = System.Drawing.Color.Black
        Me.btnSave.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnSave.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnSave.CheckedForeColor = System.Drawing.Color.White
        Me.btnSave.CheckedImage = Global.WindowsApp1.My.Resources.Resources._003_save
        Me.btnSave.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnSave.FocusedColor = System.Drawing.Color.Empty
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Image = Global.WindowsApp1.My.Resources.Resources._003_save
        Me.btnSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnSave.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnSave.LineBottom = 2
        Me.btnSave.LineColor = System.Drawing.Color.Green
        Me.btnSave.Location = New System.Drawing.Point(50, 421)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSave.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnSave.OnHoverForeColor = System.Drawing.Color.White
        Me.btnSave.OnHoverImage = Nothing
        Me.btnSave.OnHoverLineColor = System.Drawing.Color.Green
        Me.btnSave.OnPressedColor = System.Drawing.Color.Black
        Me.btnSave.Size = New System.Drawing.Size(143, 42)
        Me.btnSave.TabIndex = 24
        Me.btnSave.Text = "SAVE"
        Me.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(44, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ADD AGENT"
        '
        'tbpDelete
        '
        Me.tbpDelete.BackColor = System.Drawing.Color.Transparent
        Me.tbpDelete.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tbpDelete.Controls.Add(Me.dgvDelete)
        Me.tbpDelete.Controls.Add(Me.Label2)
        Me.tbpDelete.Controls.Add(Me.btnDeleteAll)
        Me.tbpDelete.Controls.Add(Me.btnDelete)
        Me.tbpDelete.Location = New System.Drawing.Point(4, 30)
        Me.tbpDelete.Name = "tbpDelete"
        Me.tbpDelete.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpDelete.Size = New System.Drawing.Size(1096, 754)
        Me.tbpDelete.TabIndex = 1
        Me.tbpDelete.Text = "DELETE"
        '
        'dgvDelete
        '
        Me.dgvDelete.AllowUserToAddRows = False
        Me.dgvDelete.AllowUserToDeleteRows = False
        Me.dgvDelete.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvDelete.Location = New System.Drawing.Point(42, 137)
        Me.dgvDelete.Name = "dgvDelete"
        Me.dgvDelete.ReadOnly = True
        Me.dgvDelete.Size = New System.Drawing.Size(1001, 589)
        Me.dgvDelete.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(44, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(237, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "DELETE AGENT"
        '
        'btnDeleteAll
        '
        Me.btnDeleteAll.AnimationHoverSpeed = 0.07!
        Me.btnDeleteAll.AnimationSpeed = 0.03!
        Me.btnDeleteAll.BaseColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnDeleteAll.BorderColor = System.Drawing.Color.Black
        Me.btnDeleteAll.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnDeleteAll.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnDeleteAll.CheckedForeColor = System.Drawing.Color.White
        Me.btnDeleteAll.CheckedImage = CType(resources.GetObject("btnDeleteAll.CheckedImage"), System.Drawing.Image)
        Me.btnDeleteAll.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnDeleteAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeleteAll.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnDeleteAll.FocusedColor = System.Drawing.Color.Empty
        Me.btnDeleteAll.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnDeleteAll.ForeColor = System.Drawing.Color.White
        Me.btnDeleteAll.Image = Global.WindowsApp1.My.Resources.Resources._023_delete_7
        Me.btnDeleteAll.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnDeleteAll.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnDeleteAll.LineBottom = 2
        Me.btnDeleteAll.LineColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnDeleteAll.Location = New System.Drawing.Point(217, 68)
        Me.btnDeleteAll.Name = "btnDeleteAll"
        Me.btnDeleteAll.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDeleteAll.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnDeleteAll.OnHoverForeColor = System.Drawing.Color.White
        Me.btnDeleteAll.OnHoverImage = Nothing
        Me.btnDeleteAll.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnDeleteAll.OnPressedColor = System.Drawing.Color.Black
        Me.btnDeleteAll.Size = New System.Drawing.Size(123, 42)
        Me.btnDeleteAll.TabIndex = 27
        Me.btnDeleteAll.Text = "DELETE ALL"
        Me.btnDeleteAll.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnDelete
        '
        Me.btnDelete.AnimationHoverSpeed = 0.07!
        Me.btnDelete.AnimationSpeed = 0.03!
        Me.btnDelete.BaseColor = System.Drawing.Color.Red
        Me.btnDelete.BorderColor = System.Drawing.Color.Black
        Me.btnDelete.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnDelete.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnDelete.CheckedForeColor = System.Drawing.Color.White
        Me.btnDelete.CheckedImage = CType(resources.GetObject("btnDelete.CheckedImage"), System.Drawing.Image)
        Me.btnDelete.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnDelete.FocusedColor = System.Drawing.Color.Empty
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Image = Global.WindowsApp1.My.Resources.Resources._007_bin
        Me.btnDelete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnDelete.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnDelete.LineBottom = 2
        Me.btnDelete.LineColor = System.Drawing.Color.Maroon
        Me.btnDelete.Location = New System.Drawing.Point(42, 68)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDelete.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnDelete.OnHoverForeColor = System.Drawing.Color.White
        Me.btnDelete.OnHoverImage = Nothing
        Me.btnDelete.OnHoverLineColor = System.Drawing.Color.Maroon
        Me.btnDelete.OnPressedColor = System.Drawing.Color.Black
        Me.btnDelete.Size = New System.Drawing.Size(131, 42)
        Me.btnDelete.TabIndex = 26
        Me.btnDelete.Text = "DELETE "
        Me.btnDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.Transparent
        Me.TabPage3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage3.Controls.Add(Me.GunaLabel1)
        Me.TabPage3.Controls.Add(Me.cboCountryUpdate)
        Me.TabPage3.Controls.Add(Me.lblSecPhoneNumber)
        Me.TabPage3.Controls.Add(Me.txtSecPhoneNoUpdate)
        Me.TabPage3.Controls.Add(Me.lblPhoneNumUpdate)
        Me.TabPage3.Controls.Add(Me.lblSecEmail)
        Me.TabPage3.Controls.Add(Me.lblemailUpdate)
        Me.TabPage3.Controls.Add(Me.txtPhoneNoUpdate)
        Me.TabPage3.Controls.Add(Me.txtSecEmailUpdate)
        Me.TabPage3.Controls.Add(Me.txtEmailUpdate)
        Me.TabPage3.Controls.Add(Me.GunaLabel6)
        Me.TabPage3.Controls.Add(Me.lblSecAddress)
        Me.TabPage3.Controls.Add(Me.txtSecAddressUpdate)
        Me.TabPage3.Controls.Add(Me.lblAddressUpdate)
        Me.TabPage3.Controls.Add(Me.rboFemaleUpdate)
        Me.TabPage3.Controls.Add(Me.rboMaleUpdate)
        Me.TabPage3.Controls.Add(Me.GunaLabel9)
        Me.TabPage3.Controls.Add(Me.dtpDOBUpdate)
        Me.TabPage3.Controls.Add(Me.lblLNameUpdate)
        Me.TabPage3.Controls.Add(Me.lblMNameUpdate)
        Me.TabPage3.Controls.Add(Me.lblFnameUpdate)
        Me.TabPage3.Controls.Add(Me.txtAddressUpdate)
        Me.TabPage3.Controls.Add(Me.txtLNameUpdate)
        Me.TabPage3.Controls.Add(Me.txtMnameUpdate)
        Me.TabPage3.Controls.Add(Me.txtFNameUpdate)
        Me.TabPage3.Controls.Add(Me.dgvUpdate)
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Controls.Add(Me.btnUpdate)
        Me.TabPage3.Location = New System.Drawing.Point(4, 30)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1096, 754)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "UPDATE"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GunaLabel1.Location = New System.Drawing.Point(83, 498)
        Me.GunaLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(88, 15)
        Me.GunaLabel1.TabIndex = 124
        Me.GunaLabel1.Text = "NATIONALITY *"
        '
        'cboCountryUpdate
        '
        Me.cboCountryUpdate.Animated = True
        Me.cboCountryUpdate.AutoRoundedCorners = True
        Me.cboCountryUpdate.BackColor = System.Drawing.Color.Transparent
        Me.cboCountryUpdate.BorderRadius = 22
        Me.cboCountryUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboCountryUpdate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cboCountryUpdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCountryUpdate.FocusedColor = System.Drawing.Color.Blue
        Me.cboCountryUpdate.FocusedState.BorderColor = System.Drawing.Color.Blue
        Me.cboCountryUpdate.FocusedState.Parent = Me.cboCountryUpdate
        Me.cboCountryUpdate.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCountryUpdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboCountryUpdate.FormattingEnabled = True
        Me.cboCountryUpdate.HoverState.Parent = Me.cboCountryUpdate
        Me.cboCountryUpdate.ItemHeight = 40
        Me.cboCountryUpdate.Items.AddRange(New Object() {"Algerian", "Angolan", "Beninese", "Botswanan", "Burkinabe", "Burundian", "Cameroonian", "Cape Verdean", "Central African", "Chadian", "Comorian", "Congolese (Congo-Brazzaville)", "Congolese (Congo-Kinshasa)", "Djiboutian", "Egyptian", "Equatorial Guinean", "Eritrean", "Eswatini", "Ethiopian", "Gabonese", "Gambian", "Ghanaian", "Guinean", "Guinean-Bissauan", "Ivorian", "Kenyan", "Lesotho", "Liberian", "Libyan", "Madagascan", "Malawian", "Malian", "Mauritanian", "Mauritian", "Moroccan", "Mozambican", "Namibian", "Nigerian", "Nigerien", "Rwandan", "São Toméan", "Senegalese", "Seychellois", "Sierra Leonean", "Somali", "South African", "South Sudanese", "Sudanese", "Tanzanian", "Togolese", "Tunisian", "Ugandan", "Zambian", "Zimbabwean"})
        Me.cboCountryUpdate.ItemsAppearance.Parent = Me.cboCountryUpdate
        Me.cboCountryUpdate.Location = New System.Drawing.Point(59, 508)
        Me.cboCountryUpdate.Margin = New System.Windows.Forms.Padding(10)
        Me.cboCountryUpdate.Name = "cboCountryUpdate"
        Me.cboCountryUpdate.ShadowDecoration.Parent = Me.cboCountryUpdate
        Me.cboCountryUpdate.Size = New System.Drawing.Size(235, 46)
        Me.cboCountryUpdate.Sorted = True
        Me.cboCountryUpdate.TabIndex = 128
        '
        'lblSecPhoneNumber
        '
        Me.lblSecPhoneNumber.AutoSize = True
        Me.lblSecPhoneNumber.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblSecPhoneNumber.Location = New System.Drawing.Point(577, 500)
        Me.lblSecPhoneNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSecPhoneNumber.Name = "lblSecPhoneNumber"
        Me.lblSecPhoneNumber.Size = New System.Drawing.Size(149, 15)
        Me.lblSecPhoneNumber.TabIndex = 127
        Me.lblSecPhoneNumber.Text = "SECOND MOBILE NUMBER"
        Me.lblSecPhoneNumber.Visible = False
        '
        'txtSecPhoneNoUpdate
        '
        Me.txtSecPhoneNoUpdate.BackColor = System.Drawing.Color.Transparent
        Me.txtSecPhoneNoUpdate.BorderRadius = 20
        Me.txtSecPhoneNoUpdate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSecPhoneNoUpdate.DefaultText = ""
        Me.txtSecPhoneNoUpdate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSecPhoneNoUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSecPhoneNoUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSecPhoneNoUpdate.DisabledState.Parent = Me.txtSecPhoneNoUpdate
        Me.txtSecPhoneNoUpdate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSecPhoneNoUpdate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSecPhoneNoUpdate.FocusedState.Parent = Me.txtSecPhoneNoUpdate
        Me.txtSecPhoneNoUpdate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSecPhoneNoUpdate.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSecPhoneNoUpdate.HoverState.Parent = Me.txtSecPhoneNoUpdate
        Me.txtSecPhoneNoUpdate.Location = New System.Drawing.Point(553, 509)
        Me.txtSecPhoneNoUpdate.Margin = New System.Windows.Forms.Padding(5)
        Me.txtSecPhoneNoUpdate.Name = "txtSecPhoneNoUpdate"
        Me.txtSecPhoneNoUpdate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSecPhoneNoUpdate.PlaceholderText = "SECOND MOBILE NUMBER"
        Me.txtSecPhoneNoUpdate.SelectedText = ""
        Me.txtSecPhoneNoUpdate.ShadowDecoration.Parent = Me.txtSecPhoneNoUpdate
        Me.txtSecPhoneNoUpdate.Size = New System.Drawing.Size(235, 45)
        Me.txtSecPhoneNoUpdate.TabIndex = 126
        '
        'lblPhoneNumUpdate
        '
        Me.lblPhoneNumUpdate.AutoSize = True
        Me.lblPhoneNumUpdate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblPhoneNumUpdate.Location = New System.Drawing.Point(332, 500)
        Me.lblPhoneNumUpdate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPhoneNumUpdate.Name = "lblPhoneNumUpdate"
        Me.lblPhoneNumUpdate.Size = New System.Drawing.Size(108, 15)
        Me.lblPhoneNumUpdate.TabIndex = 125
        Me.lblPhoneNumUpdate.Text = "MOBILE NUMBER *"
        Me.lblPhoneNumUpdate.Visible = False
        '
        'lblSecEmail
        '
        Me.lblSecEmail.AutoSize = True
        Me.lblSecEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblSecEmail.Location = New System.Drawing.Point(577, 359)
        Me.lblSecEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSecEmail.Name = "lblSecEmail"
        Me.lblSecEmail.Size = New System.Drawing.Size(90, 15)
        Me.lblSecEmail.TabIndex = 123
        Me.lblSecEmail.Text = "SECOND EMAIL"
        Me.lblSecEmail.Visible = False
        '
        'lblemailUpdate
        '
        Me.lblemailUpdate.AutoSize = True
        Me.lblemailUpdate.BackColor = System.Drawing.Color.Transparent
        Me.lblemailUpdate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblemailUpdate.Location = New System.Drawing.Point(332, 361)
        Me.lblemailUpdate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblemailUpdate.Name = "lblemailUpdate"
        Me.lblemailUpdate.Size = New System.Drawing.Size(49, 15)
        Me.lblemailUpdate.TabIndex = 122
        Me.lblemailUpdate.Text = "EMAIL *"
        Me.lblemailUpdate.Visible = False
        '
        'txtPhoneNoUpdate
        '
        Me.txtPhoneNoUpdate.BackColor = System.Drawing.Color.Transparent
        Me.txtPhoneNoUpdate.BorderRadius = 20
        Me.txtPhoneNoUpdate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPhoneNoUpdate.DefaultText = ""
        Me.txtPhoneNoUpdate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPhoneNoUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPhoneNoUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPhoneNoUpdate.DisabledState.Parent = Me.txtPhoneNoUpdate
        Me.txtPhoneNoUpdate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPhoneNoUpdate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPhoneNoUpdate.FocusedState.Parent = Me.txtPhoneNoUpdate
        Me.txtPhoneNoUpdate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneNoUpdate.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPhoneNoUpdate.HoverState.Parent = Me.txtPhoneNoUpdate
        Me.txtPhoneNoUpdate.Location = New System.Drawing.Point(308, 509)
        Me.txtPhoneNoUpdate.Margin = New System.Windows.Forms.Padding(5)
        Me.txtPhoneNoUpdate.Name = "txtPhoneNoUpdate"
        Me.txtPhoneNoUpdate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPhoneNoUpdate.PlaceholderText = "MOBILE NUMBER *"
        Me.txtPhoneNoUpdate.SelectedText = ""
        Me.txtPhoneNoUpdate.ShadowDecoration.Parent = Me.txtPhoneNoUpdate
        Me.txtPhoneNoUpdate.Size = New System.Drawing.Size(235, 45)
        Me.txtPhoneNoUpdate.TabIndex = 121
        '
        'txtSecEmailUpdate
        '
        Me.txtSecEmailUpdate.BackColor = System.Drawing.Color.Transparent
        Me.txtSecEmailUpdate.BorderRadius = 20
        Me.txtSecEmailUpdate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSecEmailUpdate.DefaultText = ""
        Me.txtSecEmailUpdate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSecEmailUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSecEmailUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSecEmailUpdate.DisabledState.Parent = Me.txtSecEmailUpdate
        Me.txtSecEmailUpdate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSecEmailUpdate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSecEmailUpdate.FocusedState.Parent = Me.txtSecEmailUpdate
        Me.txtSecEmailUpdate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSecEmailUpdate.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSecEmailUpdate.HoverState.Parent = Me.txtSecEmailUpdate
        Me.txtSecEmailUpdate.Location = New System.Drawing.Point(553, 370)
        Me.txtSecEmailUpdate.Margin = New System.Windows.Forms.Padding(5)
        Me.txtSecEmailUpdate.Name = "txtSecEmailUpdate"
        Me.txtSecEmailUpdate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSecEmailUpdate.PlaceholderText = "SECOND EMAIL"
        Me.txtSecEmailUpdate.SelectedText = ""
        Me.txtSecEmailUpdate.ShadowDecoration.Parent = Me.txtSecEmailUpdate
        Me.txtSecEmailUpdate.Size = New System.Drawing.Size(235, 45)
        Me.txtSecEmailUpdate.TabIndex = 120
        '
        'txtEmailUpdate
        '
        Me.txtEmailUpdate.BackColor = System.Drawing.Color.Transparent
        Me.txtEmailUpdate.BorderRadius = 20
        Me.txtEmailUpdate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmailUpdate.DefaultText = ""
        Me.txtEmailUpdate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEmailUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEmailUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmailUpdate.DisabledState.Parent = Me.txtEmailUpdate
        Me.txtEmailUpdate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmailUpdate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmailUpdate.FocusedState.Parent = Me.txtEmailUpdate
        Me.txtEmailUpdate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailUpdate.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmailUpdate.HoverState.Parent = Me.txtEmailUpdate
        Me.txtEmailUpdate.Location = New System.Drawing.Point(308, 370)
        Me.txtEmailUpdate.Margin = New System.Windows.Forms.Padding(5)
        Me.txtEmailUpdate.Name = "txtEmailUpdate"
        Me.txtEmailUpdate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmailUpdate.PlaceholderText = "EMAIL *"
        Me.txtEmailUpdate.SelectedText = ""
        Me.txtEmailUpdate.ShadowDecoration.Parent = Me.txtEmailUpdate
        Me.txtEmailUpdate.Size = New System.Drawing.Size(235, 45)
        Me.txtEmailUpdate.TabIndex = 119
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel6.Location = New System.Drawing.Point(83, 359)
        Me.GunaLabel6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(94, 15)
        Me.GunaLabel6.TabIndex = 118
        Me.GunaLabel6.Text = "DATE OF BIRTH *"
        '
        'lblSecAddress
        '
        Me.lblSecAddress.AutoSize = True
        Me.lblSecAddress.BackColor = System.Drawing.Color.Transparent
        Me.lblSecAddress.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblSecAddress.Location = New System.Drawing.Point(577, 436)
        Me.lblSecAddress.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSecAddress.Name = "lblSecAddress"
        Me.lblSecAddress.Size = New System.Drawing.Size(105, 15)
        Me.lblSecAddress.TabIndex = 117
        Me.lblSecAddress.Text = "SECOND ADDRESS"
        Me.lblSecAddress.Visible = False
        '
        'txtSecAddressUpdate
        '
        Me.txtSecAddressUpdate.BackColor = System.Drawing.Color.Transparent
        Me.txtSecAddressUpdate.BorderRadius = 20
        Me.txtSecAddressUpdate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSecAddressUpdate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSecAddressUpdate.DefaultText = ""
        Me.txtSecAddressUpdate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSecAddressUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSecAddressUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSecAddressUpdate.DisabledState.Parent = Me.txtSecAddressUpdate
        Me.txtSecAddressUpdate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSecAddressUpdate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSecAddressUpdate.FocusedState.Parent = Me.txtSecAddressUpdate
        Me.txtSecAddressUpdate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSecAddressUpdate.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSecAddressUpdate.HoverState.Parent = Me.txtSecAddressUpdate
        Me.txtSecAddressUpdate.Location = New System.Drawing.Point(553, 445)
        Me.txtSecAddressUpdate.Margin = New System.Windows.Forms.Padding(5)
        Me.txtSecAddressUpdate.Name = "txtSecAddressUpdate"
        Me.txtSecAddressUpdate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSecAddressUpdate.PlaceholderText = "SECOND ADDRESS"
        Me.txtSecAddressUpdate.SelectedText = ""
        Me.txtSecAddressUpdate.ShadowDecoration.Parent = Me.txtSecAddressUpdate
        Me.txtSecAddressUpdate.Size = New System.Drawing.Size(235, 45)
        Me.txtSecAddressUpdate.TabIndex = 116
        '
        'lblAddressUpdate
        '
        Me.lblAddressUpdate.AutoSize = True
        Me.lblAddressUpdate.BackColor = System.Drawing.Color.Transparent
        Me.lblAddressUpdate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblAddressUpdate.Location = New System.Drawing.Point(332, 436)
        Me.lblAddressUpdate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAddressUpdate.Name = "lblAddressUpdate"
        Me.lblAddressUpdate.Size = New System.Drawing.Size(64, 15)
        Me.lblAddressUpdate.TabIndex = 115
        Me.lblAddressUpdate.Text = "ADDRESS *"
        Me.lblAddressUpdate.Visible = False
        '
        'rboFemaleUpdate
        '
        Me.rboFemaleUpdate.AutoSize = True
        Me.rboFemaleUpdate.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rboFemaleUpdate.CheckedState.BorderThickness = 0
        Me.rboFemaleUpdate.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rboFemaleUpdate.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rboFemaleUpdate.CheckedState.InnerOffset = -4
        Me.rboFemaleUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rboFemaleUpdate.Location = New System.Drawing.Point(162, 457)
        Me.rboFemaleUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.rboFemaleUpdate.Name = "rboFemaleUpdate"
        Me.rboFemaleUpdate.Size = New System.Drawing.Size(80, 21)
        Me.rboFemaleUpdate.TabIndex = 114
        Me.rboFemaleUpdate.TabStop = True
        Me.rboFemaleUpdate.Text = "FEMALE"
        Me.rboFemaleUpdate.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rboFemaleUpdate.UncheckedState.BorderThickness = 2
        Me.rboFemaleUpdate.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rboFemaleUpdate.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.rboFemaleUpdate.UseVisualStyleBackColor = True
        '
        'rboMaleUpdate
        '
        Me.rboMaleUpdate.AutoSize = True
        Me.rboMaleUpdate.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rboMaleUpdate.CheckedState.BorderThickness = 0
        Me.rboMaleUpdate.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rboMaleUpdate.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rboMaleUpdate.CheckedState.InnerOffset = -4
        Me.rboMaleUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rboMaleUpdate.Location = New System.Drawing.Point(71, 457)
        Me.rboMaleUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.rboMaleUpdate.Name = "rboMaleUpdate"
        Me.rboMaleUpdate.Size = New System.Drawing.Size(63, 21)
        Me.rboMaleUpdate.TabIndex = 113
        Me.rboMaleUpdate.TabStop = True
        Me.rboMaleUpdate.Text = "MALE"
        Me.rboMaleUpdate.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rboMaleUpdate.UncheckedState.BorderThickness = 2
        Me.rboMaleUpdate.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rboMaleUpdate.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.rboMaleUpdate.UseVisualStyleBackColor = True
        '
        'GunaLabel9
        '
        Me.GunaLabel9.AutoSize = True
        Me.GunaLabel9.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel9.Location = New System.Drawing.Point(89, 433)
        Me.GunaLabel9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GunaLabel9.Name = "GunaLabel9"
        Me.GunaLabel9.Size = New System.Drawing.Size(59, 15)
        Me.GunaLabel9.TabIndex = 112
        Me.GunaLabel9.Text = "GENDER *"
        '
        'dtpDOBUpdate
        '
        Me.dtpDOBUpdate.BackColor = System.Drawing.Color.Transparent
        Me.dtpDOBUpdate.BaseColor = System.Drawing.Color.White
        Me.dtpDOBUpdate.BorderColor = System.Drawing.Color.Silver
        Me.dtpDOBUpdate.BorderSize = 0
        Me.dtpDOBUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpDOBUpdate.CustomFormat = Nothing
        Me.dtpDOBUpdate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpDOBUpdate.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpDOBUpdate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDOBUpdate.ForeColor = System.Drawing.Color.Black
        Me.dtpDOBUpdate.Location = New System.Drawing.Point(59, 370)
        Me.dtpDOBUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpDOBUpdate.MaxDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dtpDOBUpdate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpDOBUpdate.Name = "dtpDOBUpdate"
        Me.dtpDOBUpdate.OnHoverBaseColor = System.Drawing.Color.White
        Me.dtpDOBUpdate.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpDOBUpdate.OnHoverForeColor = System.Drawing.Color.Black
        Me.dtpDOBUpdate.OnPressedColor = System.Drawing.Color.Black
        Me.dtpDOBUpdate.Radius = 20
        Me.dtpDOBUpdate.Size = New System.Drawing.Size(235, 45)
        Me.dtpDOBUpdate.TabIndex = 111
        Me.dtpDOBUpdate.Text = "01 November 1999"
        Me.dtpDOBUpdate.Value = New Date(1999, 11, 1, 0, 0, 0, 0)
        '
        'lblLNameUpdate
        '
        Me.lblLNameUpdate.AutoSize = True
        Me.lblLNameUpdate.BackColor = System.Drawing.Color.Transparent
        Me.lblLNameUpdate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblLNameUpdate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLNameUpdate.Location = New System.Drawing.Point(332, 295)
        Me.lblLNameUpdate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLNameUpdate.Name = "lblLNameUpdate"
        Me.lblLNameUpdate.Size = New System.Drawing.Size(75, 15)
        Me.lblLNameUpdate.TabIndex = 110
        Me.lblLNameUpdate.Text = "LASTNAME *"
        Me.lblLNameUpdate.Visible = False
        '
        'lblMNameUpdate
        '
        Me.lblMNameUpdate.AutoSize = True
        Me.lblMNameUpdate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblMNameUpdate.Location = New System.Drawing.Point(577, 293)
        Me.lblMNameUpdate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMNameUpdate.Name = "lblMNameUpdate"
        Me.lblMNameUpdate.Size = New System.Drawing.Size(86, 15)
        Me.lblMNameUpdate.TabIndex = 109
        Me.lblMNameUpdate.Text = "MIDDLE NAME"
        Me.lblMNameUpdate.Visible = False
        '
        'lblFnameUpdate
        '
        Me.lblFnameUpdate.AutoSize = True
        Me.lblFnameUpdate.BackColor = System.Drawing.Color.Transparent
        Me.lblFnameUpdate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblFnameUpdate.Location = New System.Drawing.Point(83, 295)
        Me.lblFnameUpdate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFnameUpdate.Name = "lblFnameUpdate"
        Me.lblFnameUpdate.Size = New System.Drawing.Size(77, 15)
        Me.lblFnameUpdate.TabIndex = 108
        Me.lblFnameUpdate.Text = "FIRSTNAME *"
        Me.lblFnameUpdate.Visible = False
        '
        'txtAddressUpdate
        '
        Me.txtAddressUpdate.BackColor = System.Drawing.Color.Transparent
        Me.txtAddressUpdate.BorderRadius = 20
        Me.txtAddressUpdate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAddressUpdate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAddressUpdate.DefaultText = ""
        Me.txtAddressUpdate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAddressUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAddressUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAddressUpdate.DisabledState.Parent = Me.txtAddressUpdate
        Me.txtAddressUpdate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAddressUpdate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAddressUpdate.FocusedState.Parent = Me.txtAddressUpdate
        Me.txtAddressUpdate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddressUpdate.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAddressUpdate.HoverState.Parent = Me.txtAddressUpdate
        Me.txtAddressUpdate.Location = New System.Drawing.Point(308, 445)
        Me.txtAddressUpdate.Margin = New System.Windows.Forms.Padding(5)
        Me.txtAddressUpdate.Name = "txtAddressUpdate"
        Me.txtAddressUpdate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAddressUpdate.PlaceholderText = "ADDRESS *"
        Me.txtAddressUpdate.SelectedText = ""
        Me.txtAddressUpdate.ShadowDecoration.Parent = Me.txtAddressUpdate
        Me.txtAddressUpdate.Size = New System.Drawing.Size(235, 45)
        Me.txtAddressUpdate.TabIndex = 107
        '
        'txtLNameUpdate
        '
        Me.txtLNameUpdate.BackColor = System.Drawing.Color.Transparent
        Me.txtLNameUpdate.BorderRadius = 20
        Me.txtLNameUpdate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLNameUpdate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLNameUpdate.DefaultText = ""
        Me.txtLNameUpdate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtLNameUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtLNameUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLNameUpdate.DisabledState.Parent = Me.txtLNameUpdate
        Me.txtLNameUpdate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLNameUpdate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLNameUpdate.FocusedState.Parent = Me.txtLNameUpdate
        Me.txtLNameUpdate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLNameUpdate.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLNameUpdate.HoverState.Parent = Me.txtLNameUpdate
        Me.txtLNameUpdate.Location = New System.Drawing.Point(308, 304)
        Me.txtLNameUpdate.Margin = New System.Windows.Forms.Padding(5)
        Me.txtLNameUpdate.Name = "txtLNameUpdate"
        Me.txtLNameUpdate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLNameUpdate.PlaceholderText = "LASTNAME *"
        Me.txtLNameUpdate.SelectedText = ""
        Me.txtLNameUpdate.ShadowDecoration.Parent = Me.txtLNameUpdate
        Me.txtLNameUpdate.Size = New System.Drawing.Size(235, 45)
        Me.txtLNameUpdate.TabIndex = 106
        '
        'txtMnameUpdate
        '
        Me.txtMnameUpdate.BackColor = System.Drawing.Color.Transparent
        Me.txtMnameUpdate.BorderRadius = 20
        Me.txtMnameUpdate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMnameUpdate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMnameUpdate.DefaultText = ""
        Me.txtMnameUpdate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtMnameUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtMnameUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMnameUpdate.DisabledState.Parent = Me.txtMnameUpdate
        Me.txtMnameUpdate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMnameUpdate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMnameUpdate.FocusedState.Parent = Me.txtMnameUpdate
        Me.txtMnameUpdate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMnameUpdate.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMnameUpdate.HoverState.Parent = Me.txtMnameUpdate
        Me.txtMnameUpdate.Location = New System.Drawing.Point(553, 304)
        Me.txtMnameUpdate.Margin = New System.Windows.Forms.Padding(5)
        Me.txtMnameUpdate.Name = "txtMnameUpdate"
        Me.txtMnameUpdate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMnameUpdate.PlaceholderText = "MIDDLE NAME"
        Me.txtMnameUpdate.SelectedText = ""
        Me.txtMnameUpdate.ShadowDecoration.Parent = Me.txtMnameUpdate
        Me.txtMnameUpdate.Size = New System.Drawing.Size(235, 45)
        Me.txtMnameUpdate.TabIndex = 105
        '
        'txtFNameUpdate
        '
        Me.txtFNameUpdate.BackColor = System.Drawing.Color.Transparent
        Me.txtFNameUpdate.BorderRadius = 20
        Me.txtFNameUpdate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFNameUpdate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFNameUpdate.DefaultText = ""
        Me.txtFNameUpdate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFNameUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFNameUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFNameUpdate.DisabledState.Parent = Me.txtFNameUpdate
        Me.txtFNameUpdate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFNameUpdate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFNameUpdate.FocusedState.Parent = Me.txtFNameUpdate
        Me.txtFNameUpdate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFNameUpdate.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFNameUpdate.HoverState.Parent = Me.txtFNameUpdate
        Me.txtFNameUpdate.Location = New System.Drawing.Point(59, 304)
        Me.txtFNameUpdate.Margin = New System.Windows.Forms.Padding(5)
        Me.txtFNameUpdate.Name = "txtFNameUpdate"
        Me.txtFNameUpdate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFNameUpdate.PlaceholderText = "FIRSTNAME *"
        Me.txtFNameUpdate.SelectedText = ""
        Me.txtFNameUpdate.ShadowDecoration.Parent = Me.txtFNameUpdate
        Me.txtFNameUpdate.Size = New System.Drawing.Size(235, 45)
        Me.txtFNameUpdate.TabIndex = 104
        '
        'dgvUpdate
        '
        Me.dgvUpdate.AllowUserToAddRows = False
        Me.dgvUpdate.AllowUserToDeleteRows = False
        Me.dgvUpdate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvUpdate.Location = New System.Drawing.Point(40, 74)
        Me.dgvUpdate.Name = "dgvUpdate"
        Me.dgvUpdate.ReadOnly = True
        Me.dgvUpdate.Size = New System.Drawing.Size(1007, 187)
        Me.dgvUpdate.TabIndex = 38
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(43, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(247, 32)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "UPDATE AGENT"
        '
        'btnUpdate
        '
        Me.btnUpdate.AnimationHoverSpeed = 0.07!
        Me.btnUpdate.AnimationSpeed = 0.03!
        Me.btnUpdate.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUpdate.BorderColor = System.Drawing.Color.Black
        Me.btnUpdate.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnUpdate.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnUpdate.CheckedForeColor = System.Drawing.Color.White
        Me.btnUpdate.CheckedImage = CType(resources.GetObject("btnUpdate.CheckedImage"), System.Drawing.Image)
        Me.btnUpdate.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnUpdate.FocusedColor = System.Drawing.Color.Empty
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Image = Global.WindowsApp1.My.Resources.Resources._030_changes
        Me.btnUpdate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnUpdate.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnUpdate.LineBottom = 2
        Me.btnUpdate.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnUpdate.Location = New System.Drawing.Point(400, 18)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUpdate.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnUpdate.OnHoverForeColor = System.Drawing.Color.White
        Me.btnUpdate.OnHoverImage = Nothing
        Me.btnUpdate.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnUpdate.OnPressedColor = System.Drawing.Color.Black
        Me.btnUpdate.Size = New System.Drawing.Size(143, 42)
        Me.btnUpdate.TabIndex = 39
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmAgentManagement
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoScroll = True
        Me.AutoScrollMargin = New System.Drawing.Size(20, 20)
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1104, 788)
        Me.Controls.Add(Me.tpcAgentManagement)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAgentManagement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Insight"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tpcAgentManagement.ResumeLayout(False)
        Me.tbpAdd.ResumeLayout(False)
        Me.tbpAdd.PerformLayout()
        Me.tbpDelete.ResumeLayout(False)
        Me.tbpDelete.PerformLayout()
        CType(Me.dgvDelete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.dgvUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tpcAgentManagement As TabControl
    Friend WithEvents tbpAdd As TabPage
    Friend WithEvents btnClear As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnSave As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Label1 As Label
    Friend WithEvents tbpDelete As TabPage
    Friend WithEvents dgvDelete As DataGridView
    Friend WithEvents btnDeleteAll As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnDelete As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Label2 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents btnUpdate As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents dgvUpdate As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents lblDob As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblSecondAddress As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtSecondAddress As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblAddress As Guna.UI.WinForms.GunaLabel
    Friend WithEvents rdoFemale As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents rdoMale As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents lblGender As Guna.UI.WinForms.GunaLabel
    Friend WithEvents dtpDOB As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents lblLastname As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblMiddlename As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblFirstname As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtAddress As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtLname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtMname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtFname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblCountry As Guna.UI.WinForms.GunaLabel
    Friend WithEvents cboCountry As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblSecondMobileNumber As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtSecondMobileNumber As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblMobileNumber As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblSecondEmail As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblEmail As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtMobileNumber As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtSecondEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents cboCountryUpdate As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblSecPhoneNumber As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtSecPhoneNoUpdate As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblPhoneNumUpdate As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblSecEmail As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblemailUpdate As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtPhoneNoUpdate As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtSecEmailUpdate As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtEmailUpdate As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblSecAddress As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtSecAddressUpdate As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblAddressUpdate As Guna.UI.WinForms.GunaLabel
    Friend WithEvents rboFemaleUpdate As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents rboMaleUpdate As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents GunaLabel9 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents dtpDOBUpdate As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents lblLNameUpdate As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblMNameUpdate As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblFnameUpdate As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtAddressUpdate As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtLNameUpdate As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtMnameUpdate As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtFNameUpdate As Guna.UI2.WinForms.Guna2TextBox
End Class
