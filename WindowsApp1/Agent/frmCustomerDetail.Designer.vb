<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerDetail
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dgvCustomerDetail = New System.Windows.Forms.DataGridView()
        Me.btnClear = New Guna.UI2.WinForms.Guna2Button()
        Me.btnUpdate = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDelete = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboNationality = New Guna.UI.WinForms.GunaComboBox()
        Me.GunaLabel11 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel10 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel9 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.rdoFemale = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.rdoMale = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.lblGender = New Guna.UI.WinForms.GunaLabel()
        Me.txtFEmail = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtFPhoneNumber = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtMName = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtFAddress = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtSAddress = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtLName = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtSPhoneNumber = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtSEmail = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtFName = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cboSortByCountry = New Guna.UI.WinForms.GunaComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnOwner = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAll = New Guna.UI2.WinForms.Guna2Button()
        Me.btnTrenant = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvCustomerDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1040, 589)
        Me.Panel1.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.dgvCustomerDetail)
        Me.Panel3.Controls.Add(Me.btnClear)
        Me.Panel3.Controls.Add(Me.btnUpdate)
        Me.Panel3.Controls.Add(Me.btnDelete)
        Me.Panel3.Controls.Add(Me.btnSave)
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 128)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1040, 461)
        Me.Panel3.TabIndex = 4
        '
        'dgvCustomerDetail
        '
        Me.dgvCustomerDetail.AllowUserToAddRows = False
        Me.dgvCustomerDetail.AllowUserToDeleteRows = False
        Me.dgvCustomerDetail.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvCustomerDetail.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvCustomerDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomerDetail.Location = New System.Drawing.Point(34, 11)
        Me.dgvCustomerDetail.Name = "dgvCustomerDetail"
        Me.dgvCustomerDetail.ReadOnly = True
        Me.dgvCustomerDetail.Size = New System.Drawing.Size(960, 203)
        Me.dgvCustomerDetail.TabIndex = 23
        '
        'btnClear
        '
        Me.btnClear.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnClear.Animated = True
        Me.btnClear.BorderRadius = 7
        Me.btnClear.CheckedState.Parent = Me.btnClear
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.CustomImages.Parent = Me.btnClear
        Me.btnClear.FillColor = System.Drawing.Color.Gray
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.HoverState.Parent = Me.btnClear
        Me.btnClear.Location = New System.Drawing.Point(837, 401)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.ShadowDecoration.Parent = Me.btnClear
        Me.btnClear.Size = New System.Drawing.Size(157, 34)
        Me.btnClear.TabIndex = 22
        Me.btnClear.Text = "CLEAR"
        '
        'btnUpdate
        '
        Me.btnUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnUpdate.Animated = True
        Me.btnUpdate.BorderRadius = 7
        Me.btnUpdate.CheckedState.Parent = Me.btnUpdate
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.CustomImages.Parent = Me.btnUpdate
        Me.btnUpdate.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.HoverState.Parent = Me.btnUpdate
        Me.btnUpdate.Location = New System.Drawing.Point(837, 307)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.ShadowDecoration.Parent = Me.btnUpdate
        Me.btnUpdate.Size = New System.Drawing.Size(157, 34)
        Me.btnUpdate.TabIndex = 21
        Me.btnUpdate.Text = "UPDATE"
        '
        'btnDelete
        '
        Me.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDelete.Animated = True
        Me.btnDelete.BorderRadius = 7
        Me.btnDelete.CheckedState.Parent = Me.btnDelete
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.CustomImages.Parent = Me.btnDelete
        Me.btnDelete.FillColor = System.Drawing.Color.Red
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.HoverState.Parent = Me.btnDelete
        Me.btnDelete.Location = New System.Drawing.Point(837, 354)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.ShadowDecoration.Parent = Me.btnDelete
        Me.btnDelete.Size = New System.Drawing.Size(157, 34)
        Me.btnDelete.TabIndex = 20
        Me.btnDelete.Text = "DELETE"
        '
        'btnSave
        '
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSave.Animated = True
        Me.btnSave.BorderRadius = 7
        Me.btnSave.CheckedState.Parent = Me.btnSave
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.CustomImages.Parent = Me.btnSave
        Me.btnSave.FillColor = System.Drawing.Color.Lime
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.HoverState.Parent = Me.btnSave
        Me.btnSave.Location = New System.Drawing.Point(837, 260)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.ShadowDecoration.Parent = Me.btnSave
        Me.btnSave.Size = New System.Drawing.Size(157, 34)
        Me.btnSave.TabIndex = 19
        Me.btnSave.Text = "SAVE"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.Controls.Add(Me.cboNationality)
        Me.GroupBox1.Controls.Add(Me.GunaLabel11)
        Me.GroupBox1.Controls.Add(Me.GunaLabel10)
        Me.GroupBox1.Controls.Add(Me.GunaLabel9)
        Me.GroupBox1.Controls.Add(Me.GunaLabel8)
        Me.GroupBox1.Controls.Add(Me.GunaLabel7)
        Me.GroupBox1.Controls.Add(Me.GunaLabel6)
        Me.GroupBox1.Controls.Add(Me.GunaLabel5)
        Me.GroupBox1.Controls.Add(Me.GunaLabel4)
        Me.GroupBox1.Controls.Add(Me.GunaLabel2)
        Me.GroupBox1.Controls.Add(Me.GunaLabel1)
        Me.GroupBox1.Controls.Add(Me.rdoFemale)
        Me.GroupBox1.Controls.Add(Me.rdoMale)
        Me.GroupBox1.Controls.Add(Me.lblGender)
        Me.GroupBox1.Controls.Add(Me.txtFEmail)
        Me.GroupBox1.Controls.Add(Me.txtFPhoneNumber)
        Me.GroupBox1.Controls.Add(Me.txtMName)
        Me.GroupBox1.Controls.Add(Me.txtFAddress)
        Me.GroupBox1.Controls.Add(Me.txtSAddress)
        Me.GroupBox1.Controls.Add(Me.txtLName)
        Me.GroupBox1.Controls.Add(Me.txtSPhoneNumber)
        Me.GroupBox1.Controls.Add(Me.txtSEmail)
        Me.GroupBox1.Controls.Add(Me.txtFName)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 226)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(795, 228)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CUSTOMER'S DETAIL"
        '
        'cboNationality
        '
        Me.cboNationality.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboNationality.BackColor = System.Drawing.Color.Transparent
        Me.cboNationality.BaseColor = System.Drawing.Color.White
        Me.cboNationality.BorderColor = System.Drawing.Color.Silver
        Me.cboNationality.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboNationality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNationality.FocusedColor = System.Drawing.Color.Empty
        Me.cboNationality.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNationality.ForeColor = System.Drawing.Color.Black
        Me.cboNationality.FormattingEnabled = True
        Me.cboNationality.Items.AddRange(New Object() {"Algerian", "Angolan", "Beninese", "Botswanan", "Burkinabe", "Burundian", "Cameroonian", "Cape Verdean", "Central African", "Chadian", "Comorian", "Congolese (Congo-Brazzaville)", "Congolese (Congo-Kinshasa)", "Djiboutian", "Egyptian", "Equatorial Guinean", "Eritrean", "Eswatini", "Ethiopian", "Gabonese", "Gambian", "Ghanaian", "Guinean", "Guinean-Bissauan", "Ivorian", "Kenyan", "Lesotho", "Liberian", "Libyan", "Madagascan", "Malawian", "Malian", "Mauritanian", "Mauritian", "Moroccan", "Mozambican", "Namibian", "Nigerian", "Nigerien", "Rwandan", "São Toméan", "Senegalese", "Seychellois", "Sierra Leonean", "Somali", "South African", "South Sudanese", "Sudanese", "Tanzanian", "Togolese", "Tunisian", "Ugandan", "Zambian", "Zimbabwean"})
        Me.cboNationality.Location = New System.Drawing.Point(281, 84)
        Me.cboNationality.Name = "cboNationality"
        Me.cboNationality.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboNationality.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cboNationality.Radius = 5
        Me.cboNationality.Size = New System.Drawing.Size(223, 27)
        Me.cboNationality.TabIndex = 1
        '
        'GunaLabel11
        '
        Me.GunaLabel11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaLabel11.AutoSize = True
        Me.GunaLabel11.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel11.Location = New System.Drawing.Point(284, 71)
        Me.GunaLabel11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GunaLabel11.Name = "GunaLabel11"
        Me.GunaLabel11.Size = New System.Drawing.Size(88, 15)
        Me.GunaLabel11.TabIndex = 62
        Me.GunaLabel11.Text = "NATIONALITY *"
        '
        'GunaLabel10
        '
        Me.GunaLabel10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaLabel10.AutoSize = True
        Me.GunaLabel10.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel10.Location = New System.Drawing.Point(545, 24)
        Me.GunaLabel10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GunaLabel10.Name = "GunaLabel10"
        Me.GunaLabel10.Size = New System.Drawing.Size(86, 15)
        Me.GunaLabel10.TabIndex = 61
        Me.GunaLabel10.Text = "MIDDLE NAME"
        '
        'GunaLabel9
        '
        Me.GunaLabel9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaLabel9.AutoSize = True
        Me.GunaLabel9.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel9.Location = New System.Drawing.Point(24, 114)
        Me.GunaLabel9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GunaLabel9.Name = "GunaLabel9"
        Me.GunaLabel9.Size = New System.Drawing.Size(80, 15)
        Me.GunaLabel9.TabIndex = 60
        Me.GunaLabel9.Text = "FIRST EMAIL *"
        '
        'GunaLabel8
        '
        Me.GunaLabel8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaLabel8.AutoSize = True
        Me.GunaLabel8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel8.Location = New System.Drawing.Point(24, 161)
        Me.GunaLabel8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(137, 15)
        Me.GunaLabel8.TabIndex = 59
        Me.GunaLabel8.Text = "FIRST PHONE NUMBER *"
        '
        'GunaLabel7
        '
        Me.GunaLabel7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel7.Location = New System.Drawing.Point(284, 158)
        Me.GunaLabel7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(147, 15)
        Me.GunaLabel7.TabIndex = 58
        Me.GunaLabel7.Text = "SECOND PHONE NUMBER"
        '
        'GunaLabel6
        '
        Me.GunaLabel6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel6.Location = New System.Drawing.Point(284, 111)
        Me.GunaLabel6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(90, 15)
        Me.GunaLabel6.TabIndex = 57
        Me.GunaLabel6.Text = "SECOND EMAIL"
        '
        'GunaLabel5
        '
        Me.GunaLabel5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel5.Location = New System.Drawing.Point(545, 114)
        Me.GunaLabel5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(95, 15)
        Me.GunaLabel5.TabIndex = 56
        Me.GunaLabel5.Text = "FIRST ADDRESS *"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel4.Location = New System.Drawing.Point(545, 161)
        Me.GunaLabel4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(105, 15)
        Me.GunaLabel4.TabIndex = 55
        Me.GunaLabel4.Text = "SECOND ADDRESS"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel2.Location = New System.Drawing.Point(284, 20)
        Me.GunaLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(78, 15)
        Me.GunaLabel2.TabIndex = 53
        Me.GunaLabel2.Text = "LAST NAME *"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel1.Location = New System.Drawing.Point(24, 23)
        Me.GunaLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(80, 15)
        Me.GunaLabel1.TabIndex = 52
        Me.GunaLabel1.Text = "FIRST NAME *"
        '
        'rdoFemale
        '
        Me.rdoFemale.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.rdoFemale.AutoSize = True
        Me.rdoFemale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdoFemale.CheckedState.BorderThickness = 0
        Me.rdoFemale.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdoFemale.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rdoFemale.CheckedState.InnerOffset = -4
        Me.rdoFemale.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoFemale.Location = New System.Drawing.Point(120, 87)
        Me.rdoFemale.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoFemale.Name = "rdoFemale"
        Me.rdoFemale.Size = New System.Drawing.Size(80, 21)
        Me.rdoFemale.TabIndex = 51
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
        Me.rdoMale.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.rdoMale.AutoSize = True
        Me.rdoMale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdoMale.CheckedState.BorderThickness = 0
        Me.rdoMale.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdoMale.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rdoMale.CheckedState.InnerOffset = -4
        Me.rdoMale.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoMale.Location = New System.Drawing.Point(29, 87)
        Me.rdoMale.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoMale.Name = "rdoMale"
        Me.rdoMale.Size = New System.Drawing.Size(63, 21)
        Me.rdoMale.TabIndex = 50
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
        Me.lblGender.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblGender.Location = New System.Drawing.Point(24, 71)
        Me.lblGender.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(59, 15)
        Me.lblGender.TabIndex = 49
        Me.lblGender.Text = "GENDER *"
        '
        'txtFEmail
        '
        Me.txtFEmail.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtFEmail.BackColor = System.Drawing.Color.White
        Me.txtFEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFEmail.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.txtFEmail.LineColor = System.Drawing.Color.Gainsboro
        Me.txtFEmail.Location = New System.Drawing.Point(22, 130)
        Me.txtFEmail.Name = "txtFEmail"
        Me.txtFEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFEmail.SelectedText = ""
        Me.txtFEmail.Size = New System.Drawing.Size(223, 30)
        Me.txtFEmail.TabIndex = 9
        '
        'txtFPhoneNumber
        '
        Me.txtFPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtFPhoneNumber.BackColor = System.Drawing.Color.White
        Me.txtFPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFPhoneNumber.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFPhoneNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.txtFPhoneNumber.LineColor = System.Drawing.Color.Gainsboro
        Me.txtFPhoneNumber.Location = New System.Drawing.Point(22, 179)
        Me.txtFPhoneNumber.Name = "txtFPhoneNumber"
        Me.txtFPhoneNumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFPhoneNumber.SelectedText = ""
        Me.txtFPhoneNumber.Size = New System.Drawing.Size(223, 30)
        Me.txtFPhoneNumber.TabIndex = 8
        '
        'txtMName
        '
        Me.txtMName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtMName.BackColor = System.Drawing.Color.White
        Me.txtMName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMName.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.txtMName.LineColor = System.Drawing.Color.Gainsboro
        Me.txtMName.Location = New System.Drawing.Point(540, 39)
        Me.txtMName.Name = "txtMName"
        Me.txtMName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMName.SelectedText = ""
        Me.txtMName.Size = New System.Drawing.Size(223, 30)
        Me.txtMName.TabIndex = 7
        '
        'txtFAddress
        '
        Me.txtFAddress.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtFAddress.BackColor = System.Drawing.Color.White
        Me.txtFAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFAddress.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.txtFAddress.LineColor = System.Drawing.Color.Gainsboro
        Me.txtFAddress.Location = New System.Drawing.Point(540, 130)
        Me.txtFAddress.Name = "txtFAddress"
        Me.txtFAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFAddress.SelectedText = ""
        Me.txtFAddress.Size = New System.Drawing.Size(223, 30)
        Me.txtFAddress.TabIndex = 6
        '
        'txtSAddress
        '
        Me.txtSAddress.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtSAddress.BackColor = System.Drawing.Color.White
        Me.txtSAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSAddress.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.txtSAddress.LineColor = System.Drawing.Color.Gainsboro
        Me.txtSAddress.Location = New System.Drawing.Point(540, 179)
        Me.txtSAddress.Name = "txtSAddress"
        Me.txtSAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSAddress.SelectedText = ""
        Me.txtSAddress.Size = New System.Drawing.Size(223, 30)
        Me.txtSAddress.TabIndex = 5
        '
        'txtLName
        '
        Me.txtLName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtLName.BackColor = System.Drawing.Color.White
        Me.txtLName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLName.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.txtLName.LineColor = System.Drawing.Color.Gainsboro
        Me.txtLName.Location = New System.Drawing.Point(281, 39)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLName.SelectedText = ""
        Me.txtLName.Size = New System.Drawing.Size(223, 30)
        Me.txtLName.TabIndex = 4
        '
        'txtSPhoneNumber
        '
        Me.txtSPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtSPhoneNumber.BackColor = System.Drawing.Color.White
        Me.txtSPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSPhoneNumber.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSPhoneNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.txtSPhoneNumber.LineColor = System.Drawing.Color.Gainsboro
        Me.txtSPhoneNumber.Location = New System.Drawing.Point(281, 179)
        Me.txtSPhoneNumber.Name = "txtSPhoneNumber"
        Me.txtSPhoneNumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSPhoneNumber.SelectedText = ""
        Me.txtSPhoneNumber.Size = New System.Drawing.Size(223, 30)
        Me.txtSPhoneNumber.TabIndex = 3
        '
        'txtSEmail
        '
        Me.txtSEmail.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtSEmail.BackColor = System.Drawing.Color.White
        Me.txtSEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSEmail.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.txtSEmail.LineColor = System.Drawing.Color.Gainsboro
        Me.txtSEmail.Location = New System.Drawing.Point(281, 130)
        Me.txtSEmail.Name = "txtSEmail"
        Me.txtSEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSEmail.SelectedText = ""
        Me.txtSEmail.Size = New System.Drawing.Size(223, 30)
        Me.txtSEmail.TabIndex = 1
        '
        'txtFName
        '
        Me.txtFName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtFName.BackColor = System.Drawing.Color.White
        Me.txtFName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFName.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.txtFName.LineColor = System.Drawing.Color.Gainsboro
        Me.txtFName.Location = New System.Drawing.Point(22, 39)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFName.SelectedText = ""
        Me.txtFName.Size = New System.Drawing.Size(223, 30)
        Me.txtFName.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.txtSearch)
        Me.Panel4.Controls.Add(Me.cboSortByCountry)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 70)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1040, 58)
        Me.Panel4.TabIndex = 3
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtSearch.BorderRadius = 5
        Me.txtSearch.BorderThickness = 3
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearch.DefaultText = ""
        Me.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.DisabledState.Parent = Me.txtSearch
        Me.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.FocusedState.Parent = Me.txtSearch
        Me.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.HoverState.Parent = Me.txtSearch
        Me.txtSearch.IconLeft = Global.WindowsApp1.My.Resources.Resources.magnifier
        Me.txtSearch.Location = New System.Drawing.Point(715, 11)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.PlaceholderText = "Search..."
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.ShadowDecoration.Parent = Me.txtSearch
        Me.txtSearch.Size = New System.Drawing.Size(297, 34)
        Me.txtSearch.TabIndex = 18
        '
        'cboSortByCountry
        '
        Me.cboSortByCountry.BackColor = System.Drawing.Color.Transparent
        Me.cboSortByCountry.BaseColor = System.Drawing.Color.White
        Me.cboSortByCountry.BorderColor = System.Drawing.Color.Silver
        Me.cboSortByCountry.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboSortByCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSortByCountry.FocusedColor = System.Drawing.Color.Empty
        Me.cboSortByCountry.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSortByCountry.ForeColor = System.Drawing.Color.Black
        Me.cboSortByCountry.FormattingEnabled = True
        Me.cboSortByCountry.Items.AddRange(New Object() {"--COUNTRY--"})
        Me.cboSortByCountry.Location = New System.Drawing.Point(115, 15)
        Me.cboSortByCountry.Name = "cboSortByCountry"
        Me.cboSortByCountry.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboSortByCountry.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cboSortByCountry.Radius = 5
        Me.cboSortByCountry.Size = New System.Drawing.Size(303, 30)
        Me.cboSortByCountry.Sorted = True
        Me.cboSortByCountry.StartIndex = 0
        Me.cboSortByCountry.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.btnOwner)
        Me.Panel2.Controls.Add(Me.btnAll)
        Me.Panel2.Controls.Add(Me.btnTrenant)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1040, 70)
        Me.Panel2.TabIndex = 0
        '
        'btnOwner
        '
        Me.btnOwner.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.btnOwner.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnOwner.Animated = True
        Me.btnOwner.BorderRadius = 7
        Me.btnOwner.CheckedState.Parent = Me.btnOwner
        Me.btnOwner.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOwner.CustomImages.Parent = Me.btnOwner
        Me.btnOwner.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOwner.ForeColor = System.Drawing.Color.White
        Me.btnOwner.HoverState.Parent = Me.btnOwner
        Me.btnOwner.Location = New System.Drawing.Point(391, 23)
        Me.btnOwner.Name = "btnOwner"
        Me.btnOwner.ShadowDecoration.Parent = Me.btnOwner
        Me.btnOwner.Size = New System.Drawing.Size(115, 34)
        Me.btnOwner.TabIndex = 17
        Me.btnOwner.Text = "OWNER"
        '
        'btnAll
        '
        Me.btnAll.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAll.Animated = True
        Me.btnAll.BorderRadius = 7
        Me.btnAll.CheckedState.Parent = Me.btnAll
        Me.btnAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAll.CustomImages.Parent = Me.btnAll
        Me.btnAll.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAll.ForeColor = System.Drawing.Color.White
        Me.btnAll.HoverState.Parent = Me.btnAll
        Me.btnAll.Location = New System.Drawing.Point(75, 23)
        Me.btnAll.Name = "btnAll"
        Me.btnAll.ShadowDecoration.Parent = Me.btnAll
        Me.btnAll.Size = New System.Drawing.Size(115, 34)
        Me.btnAll.TabIndex = 15
        Me.btnAll.Text = "ALL"
        '
        'btnTrenant
        '
        Me.btnTrenant.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnTrenant.Animated = True
        Me.btnTrenant.BorderRadius = 7
        Me.btnTrenant.CheckedState.Parent = Me.btnTrenant
        Me.btnTrenant.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTrenant.CustomImages.Parent = Me.btnTrenant
        Me.btnTrenant.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTrenant.ForeColor = System.Drawing.Color.White
        Me.btnTrenant.HoverState.Parent = Me.btnTrenant
        Me.btnTrenant.Location = New System.Drawing.Point(233, 23)
        Me.btnTrenant.Name = "btnTrenant"
        Me.btnTrenant.ShadowDecoration.Parent = Me.btnTrenant
        Me.btnTrenant.Size = New System.Drawing.Size(115, 34)
        Me.btnTrenant.TabIndex = 16
        Me.btnTrenant.Text = "TRENANT"
        '
        'frmCustomerDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1040, 589)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCustomerDetail"
        Me.Text = "frmCustomerDetail"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgvCustomerDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnOwner As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAll As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnTrenant As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents cboSortByCountry As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtFEmail As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtFPhoneNumber As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtMName As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtFAddress As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtSAddress As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtLName As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtSPhoneNumber As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtSEmail As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtFName As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLabel11 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel10 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel9 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents rdoFemale As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents rdoMale As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents lblGender As Guna.UI.WinForms.GunaLabel
    Friend WithEvents cboNationality As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents btnClear As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnUpdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dgvCustomerDetail As DataGridView
End Class
