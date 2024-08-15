<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTransactionSale
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnSale = New Guna.UI2.WinForms.Guna2Button()
        Me.btnTransaction = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnClear = New Guna.UI2.WinForms.Guna2Button()
        Me.btnUpdate = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDelete = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblSaleNote = New System.Windows.Forms.Label()
        Me.lblClosedDate = New System.Windows.Forms.Label()
        Me.lblTransactionType = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpClosedDate = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.cboTransactionType = New Guna.UI.WinForms.GunaComboBox()
        Me.cboStatus = New Guna.UI.WinForms.GunaComboBox()
        Me.dtpDate = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.txtAmountPaid = New Guna.UI.WinForms.GunaLineTextBox()
        Me.cboCustomerName = New Guna.UI.WinForms.GunaComboBox()
        Me.cboPaymentMode = New Guna.UI.WinForms.GunaComboBox()
        Me.txtSaleNote = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtPropertySaleRent = New Guna.UI.WinForms.GunaLineTextBox()
        Me.cboPropertyName = New Guna.UI.WinForms.GunaComboBox()
        Me.txtPaymentReference = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtPropertyPrice = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvTransactionSale = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvTransactionSale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Controls.Add(Me.btnSale)
        Me.Panel1.Controls.Add(Me.btnTransaction)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1132, 62)
        Me.Panel1.TabIndex = 0
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
        Me.txtSearch.Location = New System.Drawing.Point(770, 14)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.PlaceholderText = "Search..."
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.ShadowDecoration.Parent = Me.txtSearch
        Me.txtSearch.Size = New System.Drawing.Size(297, 34)
        Me.txtSearch.TabIndex = 19
        '
        'btnSale
        '
        Me.btnSale.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.btnSale.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSale.Animated = True
        Me.btnSale.BorderRadius = 7
        Me.btnSale.CheckedState.Parent = Me.btnSale
        Me.btnSale.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSale.CustomImages.Parent = Me.btnSale
        Me.btnSale.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSale.ForeColor = System.Drawing.Color.White
        Me.btnSale.HoverState.Parent = Me.btnSale
        Me.btnSale.Location = New System.Drawing.Point(235, 14)
        Me.btnSale.Name = "btnSale"
        Me.btnSale.ShadowDecoration.Parent = Me.btnSale
        Me.btnSale.Size = New System.Drawing.Size(115, 34)
        Me.btnSale.TabIndex = 20
        Me.btnSale.Text = "SALE"
        '
        'btnTransaction
        '
        Me.btnTransaction.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnTransaction.Animated = True
        Me.btnTransaction.BorderRadius = 7
        Me.btnTransaction.CheckedState.Parent = Me.btnTransaction
        Me.btnTransaction.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTransaction.CustomImages.Parent = Me.btnTransaction
        Me.btnTransaction.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransaction.ForeColor = System.Drawing.Color.White
        Me.btnTransaction.HoverState.Parent = Me.btnTransaction
        Me.btnTransaction.Location = New System.Drawing.Point(77, 14)
        Me.btnTransaction.Name = "btnTransaction"
        Me.btnTransaction.ShadowDecoration.Parent = Me.btnTransaction
        Me.btnTransaction.Size = New System.Drawing.Size(115, 34)
        Me.btnTransaction.TabIndex = 19
        Me.btnTransaction.Text = "TRANSACTION"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnClear)
        Me.Panel2.Controls.Add(Me.btnUpdate)
        Me.Panel2.Controls.Add(Me.btnDelete)
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.dgvTransactionSale)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 62)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1132, 541)
        Me.Panel2.TabIndex = 1
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
        Me.btnClear.Location = New System.Drawing.Point(904, 418)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.ShadowDecoration.Parent = Me.btnClear
        Me.btnClear.Size = New System.Drawing.Size(135, 34)
        Me.btnClear.TabIndex = 28
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
        Me.btnUpdate.Location = New System.Drawing.Point(904, 340)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.ShadowDecoration.Parent = Me.btnUpdate
        Me.btnUpdate.Size = New System.Drawing.Size(135, 34)
        Me.btnUpdate.TabIndex = 27
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
        Me.btnDelete.Location = New System.Drawing.Point(904, 379)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.ShadowDecoration.Parent = Me.btnDelete
        Me.btnDelete.Size = New System.Drawing.Size(135, 34)
        Me.btnDelete.TabIndex = 26
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
        Me.btnSave.Location = New System.Drawing.Point(904, 301)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.ShadowDecoration.Parent = Me.btnSave
        Me.btnSave.Size = New System.Drawing.Size(135, 34)
        Me.btnSave.TabIndex = 25
        Me.btnSave.Text = "SAVE"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.Controls.Add(Me.lblSaleNote)
        Me.GroupBox1.Controls.Add(Me.lblClosedDate)
        Me.GroupBox1.Controls.Add(Me.lblTransactionType)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtpClosedDate)
        Me.GroupBox1.Controls.Add(Me.cboTransactionType)
        Me.GroupBox1.Controls.Add(Me.cboStatus)
        Me.GroupBox1.Controls.Add(Me.dtpDate)
        Me.GroupBox1.Controls.Add(Me.txtAmountPaid)
        Me.GroupBox1.Controls.Add(Me.cboCustomerName)
        Me.GroupBox1.Controls.Add(Me.cboPaymentMode)
        Me.GroupBox1.Controls.Add(Me.txtSaleNote)
        Me.GroupBox1.Controls.Add(Me.txtPropertySaleRent)
        Me.GroupBox1.Controls.Add(Me.cboPropertyName)
        Me.GroupBox1.Controls.Add(Me.txtPaymentReference)
        Me.GroupBox1.Controls.Add(Me.txtPropertyPrice)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lblStatus)
        Me.GroupBox1.Controls.Add(Me.lblDate)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(89, 263)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(792, 230)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CUSTOMER'S DETAIL"
        '
        'lblSaleNote
        '
        Me.lblSaleNote.AutoSize = True
        Me.lblSaleNote.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblSaleNote.Location = New System.Drawing.Point(551, 165)
        Me.lblSaleNote.Name = "lblSaleNote"
        Me.lblSaleNote.Size = New System.Drawing.Size(65, 15)
        Me.lblSaleNote.TabIndex = 198
        Me.lblSaleNote.Text = "SALE NOTE"
        '
        'lblClosedDate
        '
        Me.lblClosedDate.AutoSize = True
        Me.lblClosedDate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblClosedDate.Location = New System.Drawing.Point(282, 164)
        Me.lblClosedDate.Name = "lblClosedDate"
        Me.lblClosedDate.Size = New System.Drawing.Size(80, 15)
        Me.lblClosedDate.TabIndex = 197
        Me.lblClosedDate.Text = "CLOSED DATE"
        '
        'lblTransactionType
        '
        Me.lblTransactionType.AutoSize = True
        Me.lblTransactionType.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTransactionType.Location = New System.Drawing.Point(21, 164)
        Me.lblTransactionType.Name = "lblTransactionType"
        Me.lblTransactionType.Size = New System.Drawing.Size(115, 15)
        Me.lblTransactionType.TabIndex = 196
        Me.lblTransactionType.Text = "TRANSACTION TYPE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(551, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 15)
        Me.Label3.TabIndex = 195
        Me.Label3.Text = "PAYMENT REFERENCE"
        '
        'dtpClosedDate
        '
        Me.dtpClosedDate.BaseColor = System.Drawing.Color.White
        Me.dtpClosedDate.BorderColor = System.Drawing.Color.Silver
        Me.dtpClosedDate.CustomFormat = Nothing
        Me.dtpClosedDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpClosedDate.Enabled = False
        Me.dtpClosedDate.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpClosedDate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpClosedDate.ForeColor = System.Drawing.Color.Black
        Me.dtpClosedDate.Location = New System.Drawing.Point(282, 179)
        Me.dtpClosedDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpClosedDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpClosedDate.Name = "dtpClosedDate"
        Me.dtpClosedDate.OnHoverBaseColor = System.Drawing.Color.White
        Me.dtpClosedDate.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpClosedDate.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpClosedDate.OnPressedColor = System.Drawing.Color.Black
        Me.dtpClosedDate.Size = New System.Drawing.Size(219, 26)
        Me.dtpClosedDate.TabIndex = 194
        Me.dtpClosedDate.Text = "14 August 2024"
        Me.dtpClosedDate.Value = New Date(2024, 8, 14, 0, 0, 0, 0)
        '
        'cboTransactionType
        '
        Me.cboTransactionType.BackColor = System.Drawing.Color.Transparent
        Me.cboTransactionType.BaseColor = System.Drawing.Color.White
        Me.cboTransactionType.BorderColor = System.Drawing.Color.Silver
        Me.cboTransactionType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboTransactionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTransactionType.FocusedColor = System.Drawing.Color.Empty
        Me.cboTransactionType.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cboTransactionType.ForeColor = System.Drawing.Color.Black
        Me.cboTransactionType.FormattingEnabled = True
        Me.cboTransactionType.Items.AddRange(New Object() {"REFUND", "ADJUSTMENT"})
        Me.cboTransactionType.Location = New System.Drawing.Point(21, 179)
        Me.cboTransactionType.Name = "cboTransactionType"
        Me.cboTransactionType.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboTransactionType.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cboTransactionType.Size = New System.Drawing.Size(219, 24)
        Me.cboTransactionType.TabIndex = 193
        '
        'cboStatus
        '
        Me.cboStatus.BackColor = System.Drawing.Color.Transparent
        Me.cboStatus.BaseColor = System.Drawing.Color.White
        Me.cboStatus.BorderColor = System.Drawing.Color.Silver
        Me.cboStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.FocusedColor = System.Drawing.Color.Empty
        Me.cboStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cboStatus.ForeColor = System.Drawing.Color.Black
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Location = New System.Drawing.Point(21, 134)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboStatus.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cboStatus.Size = New System.Drawing.Size(219, 24)
        Me.cboStatus.TabIndex = 192
        '
        'dtpDate
        '
        Me.dtpDate.BaseColor = System.Drawing.Color.White
        Me.dtpDate.BorderColor = System.Drawing.Color.Silver
        Me.dtpDate.CustomFormat = Nothing
        Me.dtpDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpDate.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpDate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpDate.ForeColor = System.Drawing.Color.Black
        Me.dtpDate.Location = New System.Drawing.Point(282, 133)
        Me.dtpDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.OnHoverBaseColor = System.Drawing.Color.White
        Me.dtpDate.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpDate.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpDate.OnPressedColor = System.Drawing.Color.Black
        Me.dtpDate.Size = New System.Drawing.Size(219, 26)
        Me.dtpDate.TabIndex = 31
        Me.dtpDate.Text = "14 August 2024"
        Me.dtpDate.Value = New Date(2024, 8, 14, 0, 0, 0, 0)
        '
        'txtAmountPaid
        '
        Me.txtAmountPaid.BackColor = System.Drawing.Color.White
        Me.txtAmountPaid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAmountPaid.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAmountPaid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtAmountPaid.LineColor = System.Drawing.Color.Gainsboro
        Me.txtAmountPaid.Location = New System.Drawing.Point(588, 86)
        Me.txtAmountPaid.Name = "txtAmountPaid"
        Me.txtAmountPaid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAmountPaid.SelectedText = ""
        Me.txtAmountPaid.Size = New System.Drawing.Size(177, 26)
        Me.txtAmountPaid.TabIndex = 191
        '
        'cboCustomerName
        '
        Me.cboCustomerName.BackColor = System.Drawing.Color.Transparent
        Me.cboCustomerName.BaseColor = System.Drawing.Color.White
        Me.cboCustomerName.BorderColor = System.Drawing.Color.Silver
        Me.cboCustomerName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboCustomerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCustomerName.FocusedColor = System.Drawing.Color.Empty
        Me.cboCustomerName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cboCustomerName.ForeColor = System.Drawing.Color.Black
        Me.cboCustomerName.FormattingEnabled = True
        Me.cboCustomerName.Location = New System.Drawing.Point(21, 87)
        Me.cboCustomerName.Name = "cboCustomerName"
        Me.cboCustomerName.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboCustomerName.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cboCustomerName.Size = New System.Drawing.Size(219, 24)
        Me.cboCustomerName.TabIndex = 190
        '
        'cboPaymentMode
        '
        Me.cboPaymentMode.BackColor = System.Drawing.Color.Transparent
        Me.cboPaymentMode.BaseColor = System.Drawing.Color.White
        Me.cboPaymentMode.BorderColor = System.Drawing.Color.Silver
        Me.cboPaymentMode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboPaymentMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPaymentMode.FocusedColor = System.Drawing.Color.Empty
        Me.cboPaymentMode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cboPaymentMode.ForeColor = System.Drawing.Color.Black
        Me.cboPaymentMode.FormattingEnabled = True
        Me.cboPaymentMode.Items.AddRange(New Object() {"CASH", "CREDIT CARD", "ONLINE PAYMENT"})
        Me.cboPaymentMode.Location = New System.Drawing.Point(282, 87)
        Me.cboPaymentMode.Name = "cboPaymentMode"
        Me.cboPaymentMode.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboPaymentMode.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cboPaymentMode.Size = New System.Drawing.Size(219, 24)
        Me.cboPaymentMode.TabIndex = 189
        '
        'txtSaleNote
        '
        Me.txtSaleNote.BackColor = System.Drawing.Color.White
        Me.txtSaleNote.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSaleNote.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSaleNote.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSaleNote.LineColor = System.Drawing.Color.Gainsboro
        Me.txtSaleNote.Location = New System.Drawing.Point(551, 179)
        Me.txtSaleNote.Name = "txtSaleNote"
        Me.txtSaleNote.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSaleNote.SelectedText = ""
        Me.txtSaleNote.Size = New System.Drawing.Size(219, 26)
        Me.txtSaleNote.TabIndex = 183
        '
        'txtPropertySaleRent
        '
        Me.txtPropertySaleRent.BackColor = System.Drawing.Color.White
        Me.txtPropertySaleRent.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPropertySaleRent.Enabled = False
        Me.txtPropertySaleRent.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPropertySaleRent.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPropertySaleRent.LineColor = System.Drawing.Color.Gainsboro
        Me.txtPropertySaleRent.Location = New System.Drawing.Point(282, 38)
        Me.txtPropertySaleRent.Name = "txtPropertySaleRent"
        Me.txtPropertySaleRent.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPropertySaleRent.SelectedText = ""
        Me.txtPropertySaleRent.Size = New System.Drawing.Size(219, 26)
        Me.txtPropertySaleRent.TabIndex = 188
        '
        'cboPropertyName
        '
        Me.cboPropertyName.BackColor = System.Drawing.Color.Transparent
        Me.cboPropertyName.BaseColor = System.Drawing.Color.White
        Me.cboPropertyName.BorderColor = System.Drawing.Color.Silver
        Me.cboPropertyName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboPropertyName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPropertyName.FocusedColor = System.Drawing.Color.Empty
        Me.cboPropertyName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cboPropertyName.ForeColor = System.Drawing.Color.Black
        Me.cboPropertyName.FormattingEnabled = True
        Me.cboPropertyName.Location = New System.Drawing.Point(21, 39)
        Me.cboPropertyName.Name = "cboPropertyName"
        Me.cboPropertyName.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboPropertyName.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cboPropertyName.Size = New System.Drawing.Size(219, 24)
        Me.cboPropertyName.TabIndex = 30
        '
        'txtPaymentReference
        '
        Me.txtPaymentReference.BackColor = System.Drawing.Color.White
        Me.txtPaymentReference.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPaymentReference.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPaymentReference.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPaymentReference.LineColor = System.Drawing.Color.Gainsboro
        Me.txtPaymentReference.Location = New System.Drawing.Point(551, 133)
        Me.txtPaymentReference.Name = "txtPaymentReference"
        Me.txtPaymentReference.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPaymentReference.SelectedText = ""
        Me.txtPaymentReference.Size = New System.Drawing.Size(219, 26)
        Me.txtPaymentReference.TabIndex = 185
        '
        'txtPropertyPrice
        '
        Me.txtPropertyPrice.BackColor = System.Drawing.Color.White
        Me.txtPropertyPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPropertyPrice.Enabled = False
        Me.txtPropertyPrice.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPropertyPrice.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPropertyPrice.LineColor = System.Drawing.Color.Gainsboro
        Me.txtPropertyPrice.Location = New System.Drawing.Point(588, 38)
        Me.txtPropertyPrice.Name = "txtPropertyPrice"
        Me.txtPropertyPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPropertyPrice.SelectedText = ""
        Me.txtPropertyPrice.Size = New System.Drawing.Size(177, 26)
        Me.txtPropertyPrice.TabIndex = 30
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label7.Location = New System.Drawing.Point(21, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 15)
        Me.Label7.TabIndex = 182
        Me.Label7.Text = "CUSTOMER'S NAME"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblStatus.Location = New System.Drawing.Point(21, 118)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(45, 15)
        Me.lblStatus.TabIndex = 180
        Me.lblStatus.Text = "STATUS"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblDate.Location = New System.Drawing.Point(282, 118)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(34, 15)
        Me.lblDate.TabIndex = 181
        Me.lblDate.Text = "DATE"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label26.Location = New System.Drawing.Point(282, 23)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(124, 15)
        Me.Label26.TabIndex = 174
        Me.Label26.Text = "PROPERTY SALE/RENT"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label21.Location = New System.Drawing.Point(21, 23)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(99, 15)
        Me.Label21.TabIndex = 172
        Me.Label21.Text = "PROPERTY NAME"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label25.Location = New System.Drawing.Point(551, 23)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(96, 15)
        Me.Label25.TabIndex = 175
        Me.Label25.Text = "PROPERTY PRICE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(551, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 15)
        Me.Label2.TabIndex = 179
        Me.Label2.Text = "Ghc"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(282, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 15)
        Me.Label1.TabIndex = 176
        Me.Label1.Text = "PAYMENT MODE"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label27.Location = New System.Drawing.Point(551, 92)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(28, 15)
        Me.Label27.TabIndex = 177
        Me.Label27.Text = "Ghc"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(551, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 15)
        Me.Label4.TabIndex = 178
        Me.Label4.Text = "AMOUNT PAID"
        '
        'dgvTransactionSale
        '
        Me.dgvTransactionSale.AllowUserToAddRows = False
        Me.dgvTransactionSale.AllowUserToDeleteRows = False
        Me.dgvTransactionSale.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvTransactionSale.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvTransactionSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTransactionSale.Location = New System.Drawing.Point(77, 14)
        Me.dgvTransactionSale.Name = "dgvTransactionSale"
        Me.dgvTransactionSale.ReadOnly = True
        Me.dgvTransactionSale.Size = New System.Drawing.Size(977, 228)
        Me.dgvTransactionSale.TabIndex = 29
        '
        'frmTransactionSale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1132, 603)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTransactionSale"
        Me.Text = "frmTransactionSale"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvTransactionSale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSale As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnTransaction As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dgvTransactionSale As DataGridView
    Friend WithEvents btnClear As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnUpdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents dtpDate As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents txtPropertySaleRent As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtPaymentReference As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtSaleNote As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents cboPropertyName As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents txtPropertyPrice As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents cboPaymentMode As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents cboStatus As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents txtAmountPaid As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents cboCustomerName As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents cboTransactionType As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents lblSaleNote As Label
    Friend WithEvents lblClosedDate As Label
    Friend WithEvents lblTransactionType As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpClosedDate As Guna.UI.WinForms.GunaDateTimePicker
End Class
