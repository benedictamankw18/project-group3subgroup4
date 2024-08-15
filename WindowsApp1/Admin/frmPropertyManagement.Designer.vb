<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPropertyManagement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPropertyManagement))
        Me.cboDeletePropertyAss = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.cboPropertyTypeUpdate = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtPropertyPriceUpdate = New Guna.UI.WinForms.GunaLineTextBox()
        Me.cboPropertySaleRent = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cboVeiwUpdateAss = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btnUpdate = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.dgvUpdate = New System.Windows.Forms.DataGridView()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cboPropertyAssUpdate = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.rtbPropertyDescriptionUpdate = New System.Windows.Forms.RichTextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.pboProperty3Update = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.pboProperty1Update = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.pboProperty2Update = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.pboProperty4Update = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.nudNumberBathroomUpdate = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.nudNumberBedroomUpdate = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtPropertyLocationUpdate = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtPropertNameUpdate = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.dgvDelete = New System.Windows.Forms.DataGridView()
        Me.tbpAdd = New System.Windows.Forms.TabPage()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.cboPropertyType = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtPropertyPrice = New Guna.UI.WinForms.GunaLineTextBox()
        Me.cboPropertySaleOrRent = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btnClear = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnSave = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboPropertyAss = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.rtbPropertyDescription = New System.Windows.Forms.RichTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.pboPropertyImage3 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.pboPropertyImage2 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.pboPropertyImage4 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.pboPropertyImage1 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.nudNumberBathroom = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.nudNumberBedroom = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPropertyLocaton = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPropertyName = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDeleteAll = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnDelete = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbpDelete = New System.Windows.Forms.TabPage()
        Me.tpcPropertyManagement = New System.Windows.Forms.TabControl()
        Me.openDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.openDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.openDialog3 = New System.Windows.Forms.OpenFileDialog()
        Me.openDialog4 = New System.Windows.Forms.OpenFileDialog()
        Me.openDialog1Update = New System.Windows.Forms.OpenFileDialog()
        Me.openDialog2Update = New System.Windows.Forms.OpenFileDialog()
        Me.openDialog3Update = New System.Windows.Forms.OpenFileDialog()
        Me.openDialog4Update = New System.Windows.Forms.OpenFileDialog()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgvUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.pboProperty3Update, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboProperty1Update, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboProperty2Update, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboProperty4Update, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudNumberBathroomUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudNumberBedroomUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpAdd.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.pboPropertyImage3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboPropertyImage2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboPropertyImage4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboPropertyImage1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudNumberBathroom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudNumberBedroom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpDelete.SuspendLayout()
        Me.tpcPropertyManagement.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboDeletePropertyAss
        '
        Me.cboDeletePropertyAss.BackColor = System.Drawing.Color.Transparent
        Me.cboDeletePropertyAss.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboDeletePropertyAss.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboDeletePropertyAss.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDeletePropertyAss.FocusedColor = System.Drawing.Color.Empty
        Me.cboDeletePropertyAss.FocusedState.Parent = Me.cboDeletePropertyAss
        Me.cboDeletePropertyAss.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboDeletePropertyAss.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboDeletePropertyAss.FormattingEnabled = True
        Me.cboDeletePropertyAss.HoverState.Parent = Me.cboDeletePropertyAss
        Me.cboDeletePropertyAss.ItemHeight = 30
        Me.cboDeletePropertyAss.ItemsAppearance.Parent = Me.cboDeletePropertyAss
        Me.cboDeletePropertyAss.Location = New System.Drawing.Point(838, 74)
        Me.cboDeletePropertyAss.Name = "cboDeletePropertyAss"
        Me.cboDeletePropertyAss.ShadowDecoration.Parent = Me.cboDeletePropertyAss
        Me.cboDeletePropertyAss.Size = New System.Drawing.Size(276, 36)
        Me.cboDeletePropertyAss.TabIndex = 29
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.Transparent
        Me.TabPage3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage3.Controls.Add(Me.cboPropertyTypeUpdate)
        Me.TabPage3.Controls.Add(Me.Label28)
        Me.TabPage3.Controls.Add(Me.Label25)
        Me.TabPage3.Controls.Add(Me.Label26)
        Me.TabPage3.Controls.Add(Me.txtPropertyPriceUpdate)
        Me.TabPage3.Controls.Add(Me.cboPropertySaleRent)
        Me.TabPage3.Controls.Add(Me.Label22)
        Me.TabPage3.Controls.Add(Me.cboVeiwUpdateAss)
        Me.TabPage3.Controls.Add(Me.btnUpdate)
        Me.TabPage3.Controls.Add(Me.dgvUpdate)
        Me.TabPage3.Controls.Add(Me.Label14)
        Me.TabPage3.Controls.Add(Me.cboPropertyAssUpdate)
        Me.TabPage3.Controls.Add(Me.Label15)
        Me.TabPage3.Controls.Add(Me.rtbPropertyDescriptionUpdate)
        Me.TabPage3.Controls.Add(Me.Label16)
        Me.TabPage3.Controls.Add(Me.TableLayoutPanel2)
        Me.TabPage3.Controls.Add(Me.nudNumberBathroomUpdate)
        Me.TabPage3.Controls.Add(Me.nudNumberBedroomUpdate)
        Me.TabPage3.Controls.Add(Me.Label17)
        Me.TabPage3.Controls.Add(Me.Label18)
        Me.TabPage3.Controls.Add(Me.Label19)
        Me.TabPage3.Controls.Add(Me.Label20)
        Me.TabPage3.Controls.Add(Me.txtPropertyLocationUpdate)
        Me.TabPage3.Controls.Add(Me.Label21)
        Me.TabPage3.Controls.Add(Me.txtPropertNameUpdate)
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 30)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1362, 715)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "UPDATE"
        '
        'cboPropertyTypeUpdate
        '
        Me.cboPropertyTypeUpdate.AutoRoundedCorners = True
        Me.cboPropertyTypeUpdate.BackColor = System.Drawing.Color.Transparent
        Me.cboPropertyTypeUpdate.BorderRadius = 17
        Me.cboPropertyTypeUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboPropertyTypeUpdate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboPropertyTypeUpdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPropertyTypeUpdate.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cboPropertyTypeUpdate.FocusedColor = System.Drawing.Color.Empty
        Me.cboPropertyTypeUpdate.FocusedState.Parent = Me.cboPropertyTypeUpdate
        Me.cboPropertyTypeUpdate.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboPropertyTypeUpdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboPropertyTypeUpdate.FormattingEnabled = True
        Me.cboPropertyTypeUpdate.HoverState.Parent = Me.cboPropertyTypeUpdate
        Me.cboPropertyTypeUpdate.ItemHeight = 30
        Me.cboPropertyTypeUpdate.Items.AddRange(New Object() {"TOWNHOUSE", "RANCH-STYLE HOUSE", "BUNGALOW", "APARTMENT", "COLONIAL CRAFTSMAN", "MODULAR BUILDING", "CONDO", "CONTEMPORARY ARCHITECTURE", "CO-OPERATIVE HOUSING", "DUPLEX", "MID-CENTURY MODERN", "TINY HOME", "CAPE COD", "COTTAGE", "FARMHOUSE", "MEDITERRANEAN REVIVAL ARCHITECTURE", "TUDOR ARCHITECTURE", "VICTORIAN HOUSE", "FRENCH PROVINCIAL", "GREEK REVIVAL", "GEORGIAN ARCHITECTURE", "I-HOUSE", "CABIN"})
        Me.cboPropertyTypeUpdate.ItemsAppearance.Parent = Me.cboPropertyTypeUpdate
        Me.cboPropertyTypeUpdate.Location = New System.Drawing.Point(649, 352)
        Me.cboPropertyTypeUpdate.Name = "cboPropertyTypeUpdate"
        Me.cboPropertyTypeUpdate.ShadowDecoration.Parent = Me.cboPropertyTypeUpdate
        Me.cboPropertyTypeUpdate.Size = New System.Drawing.Size(276, 36)
        Me.cboPropertyTypeUpdate.TabIndex = 48
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(367, 287)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(38, 18)
        Me.Label28.TabIndex = 47
        Me.Label28.Text = "Ghc"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(364, 264)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(149, 18)
        Me.Label25.TabIndex = 45
        Me.Label25.Text = "PROPERTY PRICE"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(62, 264)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(190, 18)
        Me.Label26.TabIndex = 44
        Me.Label26.Text = "PROPERTY SALE/RENT"
        '
        'txtPropertyPriceUpdate
        '
        Me.txtPropertyPriceUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtPropertyPriceUpdate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPropertyPriceUpdate.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPropertyPriceUpdate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPropertyPriceUpdate.LineColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtPropertyPriceUpdate.Location = New System.Drawing.Point(414, 280)
        Me.txtPropertyPriceUpdate.Name = "txtPropertyPriceUpdate"
        Me.txtPropertyPriceUpdate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPropertyPriceUpdate.SelectedText = ""
        Me.txtPropertyPriceUpdate.Size = New System.Drawing.Size(219, 32)
        Me.txtPropertyPriceUpdate.TabIndex = 43
        '
        'cboPropertySaleRent
        '
        Me.cboPropertySaleRent.AutoRoundedCorners = True
        Me.cboPropertySaleRent.BackColor = System.Drawing.Color.Transparent
        Me.cboPropertySaleRent.BorderRadius = 17
        Me.cboPropertySaleRent.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboPropertySaleRent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPropertySaleRent.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cboPropertySaleRent.FocusedColor = System.Drawing.Color.Empty
        Me.cboPropertySaleRent.FocusedState.Parent = Me.cboPropertySaleRent
        Me.cboPropertySaleRent.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboPropertySaleRent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboPropertySaleRent.FormattingEnabled = True
        Me.cboPropertySaleRent.HoverState.Parent = Me.cboPropertySaleRent
        Me.cboPropertySaleRent.ItemHeight = 30
        Me.cboPropertySaleRent.Items.AddRange(New Object() {"SALE", "RENT"})
        Me.cboPropertySaleRent.ItemsAppearance.Parent = Me.cboPropertySaleRent
        Me.cboPropertySaleRent.Location = New System.Drawing.Point(61, 280)
        Me.cboPropertySaleRent.Name = "cboPropertySaleRent"
        Me.cboPropertySaleRent.ShadowDecoration.Parent = Me.cboPropertySaleRent
        Me.cboPropertySaleRent.Size = New System.Drawing.Size(276, 36)
        Me.cboPropertySaleRent.TabIndex = 42
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(586, 25)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(271, 18)
        Me.Label22.TabIndex = 41
        Me.Label22.Text = "VIEW PROPERTY ASSIGNED TO:"
        '
        'cboVeiwUpdateAss
        '
        Me.cboVeiwUpdateAss.BackColor = System.Drawing.Color.Transparent
        Me.cboVeiwUpdateAss.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboVeiwUpdateAss.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboVeiwUpdateAss.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboVeiwUpdateAss.FocusedColor = System.Drawing.Color.Empty
        Me.cboVeiwUpdateAss.FocusedState.Parent = Me.cboVeiwUpdateAss
        Me.cboVeiwUpdateAss.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboVeiwUpdateAss.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboVeiwUpdateAss.FormattingEnabled = True
        Me.cboVeiwUpdateAss.HoverState.Parent = Me.cboVeiwUpdateAss
        Me.cboVeiwUpdateAss.ItemHeight = 30
        Me.cboVeiwUpdateAss.ItemsAppearance.Parent = Me.cboVeiwUpdateAss
        Me.cboVeiwUpdateAss.Location = New System.Drawing.Point(863, 18)
        Me.cboVeiwUpdateAss.Name = "cboVeiwUpdateAss"
        Me.cboVeiwUpdateAss.ShadowDecoration.Parent = Me.cboVeiwUpdateAss
        Me.cboVeiwUpdateAss.Size = New System.Drawing.Size(246, 36)
        Me.cboVeiwUpdateAss.TabIndex = 40
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
        Me.btnUpdate.Image = Global.WindowsApp1.My.Resources.Resources._047_exchange
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
        Me.dgvUpdate.Size = New System.Drawing.Size(1273, 187)
        Me.dgvUpdate.TabIndex = 38
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(646, 264)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(220, 18)
        Me.Label14.TabIndex = 37
        Me.Label14.Text = "PROPERTY ASSIGNED TO:"
        '
        'cboPropertyAssUpdate
        '
        Me.cboPropertyAssUpdate.BackColor = System.Drawing.Color.Transparent
        Me.cboPropertyAssUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboPropertyAssUpdate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboPropertyAssUpdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPropertyAssUpdate.FocusedColor = System.Drawing.Color.Empty
        Me.cboPropertyAssUpdate.FocusedState.Parent = Me.cboPropertyAssUpdate
        Me.cboPropertyAssUpdate.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboPropertyAssUpdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboPropertyAssUpdate.FormattingEnabled = True
        Me.cboPropertyAssUpdate.HoverState.Parent = Me.cboPropertyAssUpdate
        Me.cboPropertyAssUpdate.ItemHeight = 30
        Me.cboPropertyAssUpdate.ItemsAppearance.Parent = Me.cboPropertyAssUpdate
        Me.cboPropertyAssUpdate.Location = New System.Drawing.Point(648, 280)
        Me.cboPropertyAssUpdate.Name = "cboPropertyAssUpdate"
        Me.cboPropertyAssUpdate.ShadowDecoration.Parent = Me.cboPropertyAssUpdate
        Me.cboPropertyAssUpdate.Size = New System.Drawing.Size(276, 36)
        Me.cboPropertyAssUpdate.TabIndex = 36
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(57, 465)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(213, 18)
        Me.Label15.TabIndex = 35
        Me.Label15.Text = "PROPERTY DESCRIPTION"
        '
        'rtbPropertyDescriptionUpdate
        '
        Me.rtbPropertyDescriptionUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.rtbPropertyDescriptionUpdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rtbPropertyDescriptionUpdate.Location = New System.Drawing.Point(57, 486)
        Me.rtbPropertyDescriptionUpdate.Name = "rtbPropertyDescriptionUpdate"
        Me.rtbPropertyDescriptionUpdate.Size = New System.Drawing.Size(617, 118)
        Me.rtbPropertyDescriptionUpdate.TabIndex = 34
        Me.rtbPropertyDescriptionUpdate.Text = ""
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(684, 396)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(191, 18)
        Me.Label16.TabIndex = 33
        Me.Label16.Text = "IMAGES OF PROPERTY"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.pboProperty3Update, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.pboProperty1Update, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.pboProperty2Update, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.pboProperty4Update, 1, 1)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(688, 420)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(264, 187)
        Me.TableLayoutPanel2.TabIndex = 32
        '
        'pboProperty3Update
        '
        Me.pboProperty3Update.BackColor = System.Drawing.Color.Transparent
        Me.pboProperty3Update.BaseColor = System.Drawing.Color.Black
        Me.pboProperty3Update.BaseDepth = 2
        Me.pboProperty3Update.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pboProperty3Update.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pboProperty3Update.Location = New System.Drawing.Point(3, 96)
        Me.pboProperty3Update.Name = "pboProperty3Update"
        Me.pboProperty3Update.Size = New System.Drawing.Size(126, 88)
        Me.pboProperty3Update.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboProperty3Update.TabIndex = 16
        Me.pboProperty3Update.TabStop = False
        '
        'pboProperty1Update
        '
        Me.pboProperty1Update.BackColor = System.Drawing.Color.Transparent
        Me.pboProperty1Update.BaseColor = System.Drawing.Color.Black
        Me.pboProperty1Update.BaseDepth = 2
        Me.pboProperty1Update.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pboProperty1Update.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pboProperty1Update.Location = New System.Drawing.Point(3, 3)
        Me.pboProperty1Update.Name = "pboProperty1Update"
        Me.pboProperty1Update.Size = New System.Drawing.Size(126, 87)
        Me.pboProperty1Update.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboProperty1Update.TabIndex = 14
        Me.pboProperty1Update.TabStop = False
        '
        'pboProperty2Update
        '
        Me.pboProperty2Update.BackColor = System.Drawing.Color.Transparent
        Me.pboProperty2Update.BaseColor = System.Drawing.Color.Black
        Me.pboProperty2Update.BaseDepth = 2
        Me.pboProperty2Update.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pboProperty2Update.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pboProperty2Update.Location = New System.Drawing.Point(135, 3)
        Me.pboProperty2Update.Name = "pboProperty2Update"
        Me.pboProperty2Update.Size = New System.Drawing.Size(126, 87)
        Me.pboProperty2Update.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboProperty2Update.TabIndex = 17
        Me.pboProperty2Update.TabStop = False
        '
        'pboProperty4Update
        '
        Me.pboProperty4Update.BackColor = System.Drawing.Color.Transparent
        Me.pboProperty4Update.BaseColor = System.Drawing.Color.Black
        Me.pboProperty4Update.BaseDepth = 2
        Me.pboProperty4Update.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pboProperty4Update.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pboProperty4Update.Location = New System.Drawing.Point(135, 96)
        Me.pboProperty4Update.Name = "pboProperty4Update"
        Me.pboProperty4Update.Size = New System.Drawing.Size(126, 88)
        Me.pboProperty4Update.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboProperty4Update.TabIndex = 15
        Me.pboProperty4Update.TabStop = False
        '
        'nudNumberBathroomUpdate
        '
        Me.nudNumberBathroomUpdate.BackColor = System.Drawing.Color.Transparent
        Me.nudNumberBathroomUpdate.BorderRadius = 4
        Me.nudNumberBathroomUpdate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.nudNumberBathroomUpdate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.nudNumberBathroomUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.nudNumberBathroomUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.nudNumberBathroomUpdate.DisabledState.Parent = Me.nudNumberBathroomUpdate
        Me.nudNumberBathroomUpdate.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.nudNumberBathroomUpdate.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.nudNumberBathroomUpdate.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.nudNumberBathroomUpdate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.nudNumberBathroomUpdate.FocusedState.Parent = Me.nudNumberBathroomUpdate
        Me.nudNumberBathroomUpdate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudNumberBathroomUpdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.nudNumberBathroomUpdate.Location = New System.Drawing.Point(351, 420)
        Me.nudNumberBathroomUpdate.Name = "nudNumberBathroomUpdate"
        Me.nudNumberBathroomUpdate.ShadowDecoration.Parent = Me.nudNumberBathroomUpdate
        Me.nudNumberBathroomUpdate.Size = New System.Drawing.Size(276, 36)
        Me.nudNumberBathroomUpdate.TabIndex = 31
        '
        'nudNumberBedroomUpdate
        '
        Me.nudNumberBedroomUpdate.BackColor = System.Drawing.Color.Transparent
        Me.nudNumberBedroomUpdate.BorderRadius = 4
        Me.nudNumberBedroomUpdate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.nudNumberBedroomUpdate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.nudNumberBedroomUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.nudNumberBedroomUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.nudNumberBedroomUpdate.DisabledState.Parent = Me.nudNumberBedroomUpdate
        Me.nudNumberBedroomUpdate.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.nudNumberBedroomUpdate.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.nudNumberBedroomUpdate.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.nudNumberBedroomUpdate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.nudNumberBedroomUpdate.FocusedState.Parent = Me.nudNumberBedroomUpdate
        Me.nudNumberBedroomUpdate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudNumberBedroomUpdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.nudNumberBedroomUpdate.Location = New System.Drawing.Point(57, 420)
        Me.nudNumberBedroomUpdate.Name = "nudNumberBedroomUpdate"
        Me.nudNumberBedroomUpdate.ShadowDecoration.Parent = Me.nudNumberBedroomUpdate
        Me.nudNumberBedroomUpdate.Size = New System.Drawing.Size(276, 36)
        Me.nudNumberBedroomUpdate.TabIndex = 30
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(351, 396)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(204, 18)
        Me.Label17.TabIndex = 29
        Me.Label17.Text = "NUMBER OF BATHROOM"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(57, 396)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(194, 18)
        Me.Label18.TabIndex = 28
        Me.Label18.Text = "NUMBER OF BEDROOM"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(648, 331)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(141, 18)
        Me.Label19.TabIndex = 27
        Me.Label19.Text = "PROPERTY TYPE"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(355, 331)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(185, 18)
        Me.Label20.TabIndex = 25
        Me.Label20.Text = "PROPERTY LOCATION"
        '
        'txtPropertyLocationUpdate
        '
        Me.txtPropertyLocationUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtPropertyLocationUpdate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPropertyLocationUpdate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPropertyLocationUpdate.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPropertyLocationUpdate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPropertyLocationUpdate.LineColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtPropertyLocationUpdate.Location = New System.Drawing.Point(355, 355)
        Me.txtPropertyLocationUpdate.Name = "txtPropertyLocationUpdate"
        Me.txtPropertyLocationUpdate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPropertyLocationUpdate.SelectedText = ""
        Me.txtPropertyLocationUpdate.Size = New System.Drawing.Size(276, 32)
        Me.txtPropertyLocationUpdate.TabIndex = 24
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(61, 331)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(146, 18)
        Me.Label21.TabIndex = 23
        Me.Label21.Text = "PROPERTY NAME"
        '
        'txtPropertNameUpdate
        '
        Me.txtPropertNameUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtPropertNameUpdate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPropertNameUpdate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPropertNameUpdate.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPropertNameUpdate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPropertNameUpdate.LineColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtPropertNameUpdate.Location = New System.Drawing.Point(61, 355)
        Me.txtPropertNameUpdate.Name = "txtPropertNameUpdate"
        Me.txtPropertNameUpdate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPropertNameUpdate.SelectedText = ""
        Me.txtPropertNameUpdate.Size = New System.Drawing.Size(276, 32)
        Me.txtPropertNameUpdate.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(43, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(338, 32)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "UPDATE PROPERTIES"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(561, 81)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(271, 18)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "VIEW PROPERTY ASSIGNED TO:"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
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
        Me.dgvDelete.Size = New System.Drawing.Size(1267, 550)
        Me.dgvDelete.TabIndex = 28
        '
        'tbpAdd
        '
        Me.tbpAdd.BackColor = System.Drawing.Color.Transparent
        Me.tbpAdd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tbpAdd.Controls.Add(Me.Label27)
        Me.tbpAdd.Controls.Add(Me.cboPropertyType)
        Me.tbpAdd.Controls.Add(Me.Label24)
        Me.tbpAdd.Controls.Add(Me.Label23)
        Me.tbpAdd.Controls.Add(Me.txtPropertyPrice)
        Me.tbpAdd.Controls.Add(Me.cboPropertySaleOrRent)
        Me.tbpAdd.Controls.Add(Me.btnClear)
        Me.tbpAdd.Controls.Add(Me.btnSave)
        Me.tbpAdd.Controls.Add(Me.Label12)
        Me.tbpAdd.Controls.Add(Me.Label11)
        Me.tbpAdd.Controls.Add(Me.cboPropertyAss)
        Me.tbpAdd.Controls.Add(Me.Label10)
        Me.tbpAdd.Controls.Add(Me.rtbPropertyDescription)
        Me.tbpAdd.Controls.Add(Me.Label9)
        Me.tbpAdd.Controls.Add(Me.TableLayoutPanel1)
        Me.tbpAdd.Controls.Add(Me.nudNumberBathroom)
        Me.tbpAdd.Controls.Add(Me.nudNumberBedroom)
        Me.tbpAdd.Controls.Add(Me.Label8)
        Me.tbpAdd.Controls.Add(Me.Label7)
        Me.tbpAdd.Controls.Add(Me.Label6)
        Me.tbpAdd.Controls.Add(Me.Label5)
        Me.tbpAdd.Controls.Add(Me.txtPropertyLocaton)
        Me.tbpAdd.Controls.Add(Me.Label4)
        Me.tbpAdd.Controls.Add(Me.txtPropertyName)
        Me.tbpAdd.Controls.Add(Me.Label1)
        Me.tbpAdd.Location = New System.Drawing.Point(4, 30)
        Me.tbpAdd.Name = "tbpAdd"
        Me.tbpAdd.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpAdd.Size = New System.Drawing.Size(1362, 715)
        Me.tbpAdd.TabIndex = 0
        Me.tbpAdd.Text = "ADD"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(339, 266)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(38, 18)
        Me.Label27.TabIndex = 44
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
        Me.cboPropertyType.Location = New System.Drawing.Point(626, 134)
        Me.cboPropertyType.Name = "cboPropertyType"
        Me.cboPropertyType.ShadowDecoration.Parent = Me.cboPropertyType
        Me.cboPropertyType.Size = New System.Drawing.Size(276, 36)
        Me.cboPropertyType.TabIndex = 43
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(328, 238)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(149, 18)
        Me.Label24.TabIndex = 29
        Me.Label24.Text = "PROPERTY PRICE"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(30, 238)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(190, 18)
        Me.Label23.TabIndex = 28
        Me.Label23.Text = "PROPERTY SALE/RENT"
        '
        'txtPropertyPrice
        '
        Me.txtPropertyPrice.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtPropertyPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPropertyPrice.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPropertyPrice.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPropertyPrice.LineColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtPropertyPrice.Location = New System.Drawing.Point(388, 259)
        Me.txtPropertyPrice.Name = "txtPropertyPrice"
        Me.txtPropertyPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPropertyPrice.SelectedText = ""
        Me.txtPropertyPrice.Size = New System.Drawing.Size(219, 32)
        Me.txtPropertyPrice.TabIndex = 27
        '
        'cboPropertySaleOrRent
        '
        Me.cboPropertySaleOrRent.AutoRoundedCorners = True
        Me.cboPropertySaleOrRent.BackColor = System.Drawing.Color.Transparent
        Me.cboPropertySaleOrRent.BorderRadius = 17
        Me.cboPropertySaleOrRent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboPropertySaleOrRent.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboPropertySaleOrRent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPropertySaleOrRent.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cboPropertySaleOrRent.FocusedColor = System.Drawing.Color.Empty
        Me.cboPropertySaleOrRent.FocusedState.Parent = Me.cboPropertySaleOrRent
        Me.cboPropertySaleOrRent.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboPropertySaleOrRent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboPropertySaleOrRent.FormattingEnabled = True
        Me.cboPropertySaleOrRent.HoverState.Parent = Me.cboPropertySaleOrRent
        Me.cboPropertySaleOrRent.ItemHeight = 30
        Me.cboPropertySaleOrRent.Items.AddRange(New Object() {"RENT", "SALE"})
        Me.cboPropertySaleOrRent.ItemsAppearance.Parent = Me.cboPropertySaleOrRent
        Me.cboPropertySaleOrRent.Location = New System.Drawing.Point(33, 259)
        Me.cboPropertySaleOrRent.Name = "cboPropertySaleOrRent"
        Me.cboPropertySaleOrRent.ShadowDecoration.Parent = Me.cboPropertySaleOrRent
        Me.cboPropertySaleOrRent.Size = New System.Drawing.Size(276, 36)
        Me.cboPropertySaleOrRent.TabIndex = 26
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
        Me.btnClear.Location = New System.Drawing.Point(314, 543)
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
        Me.btnSave.CheckedImage = CType(resources.GetObject("btnSave.CheckedImage"), System.Drawing.Image)
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
        Me.btnSave.Location = New System.Drawing.Point(47, 543)
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
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(656, 474)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(277, 13)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "CLICK ON THE CELL POSITION TO ADD IMAGE"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(452, 27)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(220, 18)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "PROPERTY ASSIGNED TO:"
        '
        'cboPropertyAss
        '
        Me.cboPropertyAss.BackColor = System.Drawing.Color.Transparent
        Me.cboPropertyAss.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboPropertyAss.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboPropertyAss.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPropertyAss.FocusedColor = System.Drawing.Color.Empty
        Me.cboPropertyAss.FocusedState.Parent = Me.cboPropertyAss
        Me.cboPropertyAss.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboPropertyAss.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboPropertyAss.FormattingEnabled = True
        Me.cboPropertyAss.HoverState.Parent = Me.cboPropertyAss
        Me.cboPropertyAss.ItemHeight = 30
        Me.cboPropertyAss.ItemsAppearance.Parent = Me.cboPropertyAss
        Me.cboPropertyAss.Location = New System.Drawing.Point(678, 18)
        Me.cboPropertyAss.Name = "cboPropertyAss"
        Me.cboPropertyAss.ShadowDecoration.Parent = Me.cboPropertyAss
        Me.cboPropertyAss.Size = New System.Drawing.Size(276, 36)
        Me.cboPropertyAss.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(33, 308)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(213, 18)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "PROPERTY DESCRIPTION"
        '
        'rtbPropertyDescription
        '
        Me.rtbPropertyDescription.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.rtbPropertyDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rtbPropertyDescription.Location = New System.Drawing.Point(33, 334)
        Me.rtbPropertyDescription.Name = "rtbPropertyDescription"
        Me.rtbPropertyDescription.Size = New System.Drawing.Size(617, 179)
        Me.rtbPropertyDescription.TabIndex = 18
        Me.rtbPropertyDescription.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(655, 173)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(191, 18)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "IMAGES OF PROPERTY"
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(656, 196)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(339, 275)
        Me.TableLayoutPanel1.TabIndex = 15
        '
        'pboPropertyImage3
        '
        Me.pboPropertyImage3.BackColor = System.Drawing.Color.Transparent
        Me.pboPropertyImage3.BaseColor = System.Drawing.Color.Black
        Me.pboPropertyImage3.BaseDepth = 2
        Me.pboPropertyImage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pboPropertyImage3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pboPropertyImage3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pboPropertyImage3.Location = New System.Drawing.Point(3, 140)
        Me.pboPropertyImage3.Name = "pboPropertyImage3"
        Me.pboPropertyImage3.Size = New System.Drawing.Size(163, 132)
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
        Me.pboPropertyImage2.Size = New System.Drawing.Size(164, 131)
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
        Me.pboPropertyImage4.Location = New System.Drawing.Point(172, 140)
        Me.pboPropertyImage4.Name = "pboPropertyImage4"
        Me.pboPropertyImage4.Size = New System.Drawing.Size(164, 132)
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
        Me.pboPropertyImage1.Size = New System.Drawing.Size(163, 131)
        Me.pboPropertyImage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboPropertyImage1.TabIndex = 14
        Me.pboPropertyImage1.TabStop = False
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
        Me.nudNumberBathroom.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.nudNumberBathroom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.nudNumberBathroom.FocusedState.Parent = Me.nudNumberBathroom
        Me.nudNumberBathroom.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudNumberBathroom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.nudNumberBathroom.Location = New System.Drawing.Point(331, 194)
        Me.nudNumberBathroom.Name = "nudNumberBathroom"
        Me.nudNumberBathroom.ShadowDecoration.Parent = Me.nudNumberBathroom
        Me.nudNumberBathroom.Size = New System.Drawing.Size(276, 32)
        Me.nudNumberBathroom.TabIndex = 13
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
        Me.nudNumberBedroom.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.nudNumberBedroom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.nudNumberBedroom.FocusedState.Parent = Me.nudNumberBedroom
        Me.nudNumberBedroom.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudNumberBedroom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.nudNumberBedroom.Location = New System.Drawing.Point(33, 196)
        Me.nudNumberBedroom.Name = "nudNumberBedroom"
        Me.nudNumberBedroom.ShadowDecoration.Parent = Me.nudNumberBedroom
        Me.nudNumberBedroom.Size = New System.Drawing.Size(276, 30)
        Me.nudNumberBedroom.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(328, 173)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(204, 18)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "NUMBER OF BATHROOM"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(30, 173)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(194, 18)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "NUMBER OF BEDROOM"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(623, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 18)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "PROPERTY TYPE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(328, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(185, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "PROPERTY LOCATION"
        '
        'txtPropertyLocaton
        '
        Me.txtPropertyLocaton.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtPropertyLocaton.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPropertyLocaton.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPropertyLocaton.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPropertyLocaton.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPropertyLocaton.LineColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtPropertyLocaton.Location = New System.Drawing.Point(331, 134)
        Me.txtPropertyLocaton.Name = "txtPropertyLocaton"
        Me.txtPropertyLocaton.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPropertyLocaton.SelectedText = ""
        Me.txtPropertyLocaton.Size = New System.Drawing.Size(276, 32)
        Me.txtPropertyLocaton.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 18)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "PROPERTY NAME"
        '
        'txtPropertyName
        '
        Me.txtPropertyName.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtPropertyName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPropertyName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPropertyName.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPropertyName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPropertyName.LineColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtPropertyName.Location = New System.Drawing.Point(33, 134)
        Me.txtPropertyName.Name = "txtPropertyName"
        Me.txtPropertyName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPropertyName.SelectedText = ""
        Me.txtPropertyName.Size = New System.Drawing.Size(276, 32)
        Me.txtPropertyName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(44, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(282, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ADD PROPERTIES"
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(44, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(328, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "DELETE PROPERTIES"
        '
        'tbpDelete
        '
        Me.tbpDelete.BackColor = System.Drawing.Color.Transparent
        Me.tbpDelete.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tbpDelete.Controls.Add(Me.Label13)
        Me.tbpDelete.Controls.Add(Me.cboDeletePropertyAss)
        Me.tbpDelete.Controls.Add(Me.dgvDelete)
        Me.tbpDelete.Controls.Add(Me.btnDeleteAll)
        Me.tbpDelete.Controls.Add(Me.btnDelete)
        Me.tbpDelete.Controls.Add(Me.Label2)
        Me.tbpDelete.Location = New System.Drawing.Point(4, 30)
        Me.tbpDelete.Name = "tbpDelete"
        Me.tbpDelete.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpDelete.Size = New System.Drawing.Size(1362, 715)
        Me.tbpDelete.TabIndex = 1
        Me.tbpDelete.Text = "DELETE"
        '
        'tpcPropertyManagement
        '
        Me.tpcPropertyManagement.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.tpcPropertyManagement.Controls.Add(Me.tbpAdd)
        Me.tpcPropertyManagement.Controls.Add(Me.tbpDelete)
        Me.tpcPropertyManagement.Controls.Add(Me.TabPage3)
        Me.tpcPropertyManagement.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tpcPropertyManagement.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tpcPropertyManagement.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tpcPropertyManagement.Location = New System.Drawing.Point(0, 0)
        Me.tpcPropertyManagement.Multiline = True
        Me.tpcPropertyManagement.Name = "tpcPropertyManagement"
        Me.tpcPropertyManagement.SelectedIndex = 0
        Me.tpcPropertyManagement.Size = New System.Drawing.Size(1370, 749)
        Me.tpcPropertyManagement.TabIndex = 3
        '
        'frmPropertyManagement
        '
        Me.AllowDrop = True
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.tpcPropertyManagement)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPropertyManagement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmInbox"
        Me.TransparencyKey = System.Drawing.Color.Transparent
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.dgvUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.pboProperty3Update, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboProperty1Update, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboProperty2Update, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboProperty4Update, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudNumberBathroomUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudNumberBedroomUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDelete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpAdd.ResumeLayout(False)
        Me.tbpAdd.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.pboPropertyImage3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboPropertyImage2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboPropertyImage4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboPropertyImage1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudNumberBathroom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudNumberBedroom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpDelete.ResumeLayout(False)
        Me.tbpDelete.PerformLayout()
        Me.tpcPropertyManagement.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cboDeletePropertyAss As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents txtPropertyPriceUpdate As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents cboPropertySaleRent As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label22 As Label
    Friend WithEvents cboVeiwUpdateAss As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btnUpdate As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents dgvUpdate As DataGridView
    Friend WithEvents Label14 As Label
    Friend WithEvents cboPropertyAssUpdate As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents rtbPropertyDescriptionUpdate As RichTextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents pboProperty3Update As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents pboProperty1Update As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents pboProperty2Update As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents pboProperty4Update As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents nudNumberBathroomUpdate As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents nudNumberBedroomUpdate As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents txtPropertyLocationUpdate As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txtPropertNameUpdate As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents dgvDelete As DataGridView
    Friend WithEvents tbpAdd As TabPage
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents txtPropertyPrice As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents cboPropertySaleOrRent As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btnClear As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnSave As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents cboPropertyAss As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents rtbPropertyDescription As RichTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents pboPropertyImage3 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents pboPropertyImage2 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents pboPropertyImage4 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents pboPropertyImage1 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents nudNumberBathroom As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents nudNumberBedroom As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPropertyLocaton As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPropertyName As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDeleteAll As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnDelete As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Label2 As Label
    Friend WithEvents tbpDelete As TabPage
    Friend WithEvents tpcPropertyManagement As TabControl
    Friend WithEvents cboPropertyType As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents openDialog1 As OpenFileDialog
    Friend WithEvents openDialog2 As OpenFileDialog
    Friend WithEvents openDialog3 As OpenFileDialog
    Friend WithEvents openDialog4 As OpenFileDialog
    Friend WithEvents openDialog1Update As OpenFileDialog
    Friend WithEvents openDialog2Update As OpenFileDialog
    Friend WithEvents openDialog3Update As OpenFileDialog
    Friend WithEvents openDialog4Update As OpenFileDialog
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents cboPropertyTypeUpdate As Guna.UI2.WinForms.Guna2ComboBox
End Class
