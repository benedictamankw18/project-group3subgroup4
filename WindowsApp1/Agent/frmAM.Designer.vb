<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAM
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
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cboPropertyType = New Guna.UI.WinForms.GunaComboBox()
        Me.cboSProblemStatus = New Guna.UI.WinForms.GunaComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cboPropertyName = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtPropertyType = New Guna.UI.WinForms.GunaLineTextBox()
        Me.btnUpdate = New Guna.UI.WinForms.GunaButton()
        Me.btnDelete = New Guna.UI.WinForms.GunaButton()
        Me.btnAdd = New Guna.UI.WinForms.GunaButton()
        Me.cboProblemStatus = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.rtbProblemDescription = New System.Windows.Forms.RichTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPropertyLocation = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvMat = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvMat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Controls.Add(Me.cboPropertyType)
        Me.Panel1.Controls.Add(Me.cboSProblemStatus)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1116, 74)
        Me.Panel1.TabIndex = 0
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtSearch.BorderRadius = 5
        Me.txtSearch.BorderThickness = 2
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearch.DefaultText = ""
        Me.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.DisabledState.Parent = Me.txtSearch
        Me.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.FocusedState.Parent = Me.txtSearch
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.HoverState.Parent = Me.txtSearch
        Me.txtSearch.IconLeft = Global.WindowsApp1.My.Resources.Resources.magnifier
        Me.txtSearch.IconLeftOffset = New System.Drawing.Point(2, 0)
        Me.txtSearch.Location = New System.Drawing.Point(780, 30)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.PlaceholderText = "Search..."
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.ShadowDecoration.Parent = Me.txtSearch
        Me.txtSearch.Size = New System.Drawing.Size(276, 30)
        Me.txtSearch.TabIndex = 0
        '
        'cboPropertyType
        '
        Me.cboPropertyType.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboPropertyType.BackColor = System.Drawing.Color.Transparent
        Me.cboPropertyType.BaseColor = System.Drawing.Color.White
        Me.cboPropertyType.BorderColor = System.Drawing.Color.Silver
        Me.cboPropertyType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboPropertyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPropertyType.FocusedColor = System.Drawing.Color.Empty
        Me.cboPropertyType.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPropertyType.ForeColor = System.Drawing.Color.Black
        Me.cboPropertyType.FormattingEnabled = True
        Me.cboPropertyType.Items.AddRange(New Object() {"--PROPERTY TYPE--"})
        Me.cboPropertyType.Location = New System.Drawing.Point(261, 30)
        Me.cboPropertyType.Name = "cboPropertyType"
        Me.cboPropertyType.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboPropertyType.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cboPropertyType.Size = New System.Drawing.Size(276, 30)
        Me.cboPropertyType.StartIndex = 0
        Me.cboPropertyType.TabIndex = 1
        '
        'cboSProblemStatus
        '
        Me.cboSProblemStatus.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboSProblemStatus.BackColor = System.Drawing.Color.Transparent
        Me.cboSProblemStatus.BaseColor = System.Drawing.Color.White
        Me.cboSProblemStatus.BorderColor = System.Drawing.Color.Silver
        Me.cboSProblemStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboSProblemStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSProblemStatus.FocusedColor = System.Drawing.Color.Empty
        Me.cboSProblemStatus.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSProblemStatus.ForeColor = System.Drawing.Color.Black
        Me.cboSProblemStatus.FormattingEnabled = True
        Me.cboSProblemStatus.Items.AddRange(New Object() {"--PROBLEM STATUS--", "PENDING", "IN PROGRESS", "CANCELLED", "COMPLETED"})
        Me.cboSProblemStatus.Location = New System.Drawing.Point(45, 30)
        Me.cboSProblemStatus.Name = "cboSProblemStatus"
        Me.cboSProblemStatus.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboSProblemStatus.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cboSProblemStatus.Size = New System.Drawing.Size(200, 30)
        Me.cboSProblemStatus.StartIndex = 0
        Me.cboSProblemStatus.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.cboPropertyName)
        Me.Panel2.Controls.Add(Me.txtPropertyType)
        Me.Panel2.Controls.Add(Me.btnUpdate)
        Me.Panel2.Controls.Add(Me.btnDelete)
        Me.Panel2.Controls.Add(Me.btnAdd)
        Me.Panel2.Controls.Add(Me.cboProblemStatus)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.rtbProblemDescription)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.txtPropertyLocation)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.dgvMat)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 74)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1116, 490)
        Me.Panel2.TabIndex = 1
        '
        'cboPropertyName
        '
        Me.cboPropertyName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboPropertyName.AutoRoundedCorners = True
        Me.cboPropertyName.BackColor = System.Drawing.Color.Transparent
        Me.cboPropertyName.BorderRadius = 17
        Me.cboPropertyName.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboPropertyName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboPropertyName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPropertyName.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cboPropertyName.FocusedColor = System.Drawing.Color.Empty
        Me.cboPropertyName.FocusedState.Parent = Me.cboPropertyName
        Me.cboPropertyName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboPropertyName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboPropertyName.FormattingEnabled = True
        Me.cboPropertyName.HoverState.Parent = Me.cboPropertyName
        Me.cboPropertyName.ItemHeight = 30
        Me.cboPropertyName.ItemsAppearance.Parent = Me.cboPropertyName
        Me.cboPropertyName.Location = New System.Drawing.Point(77, 307)
        Me.cboPropertyName.Name = "cboPropertyName"
        Me.cboPropertyName.ShadowDecoration.Parent = Me.cboPropertyName
        Me.cboPropertyName.Size = New System.Drawing.Size(289, 36)
        Me.cboPropertyName.TabIndex = 153
        '
        'txtPropertyType
        '
        Me.txtPropertyType.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPropertyType.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtPropertyType.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPropertyType.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPropertyType.Enabled = False
        Me.txtPropertyType.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPropertyType.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPropertyType.LineColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtPropertyType.Location = New System.Drawing.Point(676, 311)
        Me.txtPropertyType.Name = "txtPropertyType"
        Me.txtPropertyType.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPropertyType.SelectedText = ""
        Me.txtPropertyType.Size = New System.Drawing.Size(276, 32)
        Me.txtPropertyType.TabIndex = 152
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnUpdate.AnimationHoverSpeed = 0.07!
        Me.btnUpdate.AnimationSpeed = 0.03!
        Me.btnUpdate.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUpdate.BorderColor = System.Drawing.Color.Black
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnUpdate.FocusedColor = System.Drawing.Color.Empty
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Image = Global.WindowsApp1.My.Resources.Resources._047_exchange
        Me.btnUpdate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnUpdate.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnUpdate.Location = New System.Drawing.Point(908, 436)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUpdate.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnUpdate.OnHoverForeColor = System.Drawing.Color.White
        Me.btnUpdate.OnHoverImage = Nothing
        Me.btnUpdate.OnPressedColor = System.Drawing.Color.Black
        Me.btnUpdate.Size = New System.Drawing.Size(104, 42)
        Me.btnUpdate.TabIndex = 151
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDelete.AnimationHoverSpeed = 0.07!
        Me.btnDelete.AnimationSpeed = 0.03!
        Me.btnDelete.BaseColor = System.Drawing.Color.Red
        Me.btnDelete.BorderColor = System.Drawing.Color.Black
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnDelete.FocusedColor = System.Drawing.Color.Empty
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Image = Global.WindowsApp1.My.Resources.Resources._010_rubber
        Me.btnDelete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnDelete.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnDelete.Location = New System.Drawing.Point(792, 436)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDelete.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnDelete.OnHoverForeColor = System.Drawing.Color.White
        Me.btnDelete.OnHoverImage = Nothing
        Me.btnDelete.OnPressedColor = System.Drawing.Color.Black
        Me.btnDelete.Size = New System.Drawing.Size(104, 42)
        Me.btnDelete.TabIndex = 150
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAdd.AnimationHoverSpeed = 0.07!
        Me.btnAdd.AnimationSpeed = 0.03!
        Me.btnAdd.BaseColor = System.Drawing.Color.Lime
        Me.btnAdd.BorderColor = System.Drawing.Color.Black
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAdd.FocusedColor = System.Drawing.Color.Empty
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Image = Global.WindowsApp1.My.Resources.Resources._002_download
        Me.btnAdd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnAdd.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnAdd.Location = New System.Drawing.Point(676, 436)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAdd.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnAdd.OnHoverForeColor = System.Drawing.Color.White
        Me.btnAdd.OnHoverImage = Nothing
        Me.btnAdd.OnPressedColor = System.Drawing.Color.Black
        Me.btnAdd.Size = New System.Drawing.Size(104, 42)
        Me.btnAdd.TabIndex = 149
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cboProblemStatus
        '
        Me.cboProblemStatus.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboProblemStatus.AutoRoundedCorners = True
        Me.cboProblemStatus.BackColor = System.Drawing.Color.Transparent
        Me.cboProblemStatus.BorderRadius = 17
        Me.cboProblemStatus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboProblemStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboProblemStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProblemStatus.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cboProblemStatus.FocusedColor = System.Drawing.Color.Empty
        Me.cboProblemStatus.FocusedState.Parent = Me.cboProblemStatus
        Me.cboProblemStatus.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboProblemStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboProblemStatus.FormattingEnabled = True
        Me.cboProblemStatus.HoverState.Parent = Me.cboProblemStatus
        Me.cboProblemStatus.ItemHeight = 30
        Me.cboProblemStatus.Items.AddRange(New Object() {"COMPLETED", "PENDING", "IN PROGRESS", "CANCELLED"})
        Me.cboProblemStatus.ItemsAppearance.Parent = Me.cboProblemStatus
        Me.cboProblemStatus.Location = New System.Drawing.Point(676, 373)
        Me.cboProblemStatus.Name = "cboProblemStatus"
        Me.cboProblemStatus.ShadowDecoration.Parent = Me.cboProblemStatus
        Me.cboProblemStatus.Size = New System.Drawing.Size(276, 36)
        Me.cboProblemStatus.TabIndex = 148
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(673, 354)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 18)
        Me.Label1.TabIndex = 147
        Me.Label1.Text = "PROBLEM STATUS"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(80, 353)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(204, 18)
        Me.Label10.TabIndex = 146
        Me.Label10.Text = "PROBLEM DESCRIPTION"
        '
        'rtbProblemDescription
        '
        Me.rtbProblemDescription.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.rtbProblemDescription.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.rtbProblemDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rtbProblemDescription.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.rtbProblemDescription.Location = New System.Drawing.Point(77, 373)
        Me.rtbProblemDescription.Name = "rtbProblemDescription"
        Me.rtbProblemDescription.Size = New System.Drawing.Size(580, 105)
        Me.rtbProblemDescription.TabIndex = 145
        Me.rtbProblemDescription.Text = ""
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(673, 288)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 18)
        Me.Label6.TabIndex = 144
        Me.Label6.Text = "PROPERTY TYPE"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(378, 288)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(185, 18)
        Me.Label5.TabIndex = 143
        Me.Label5.Text = "PROPERTY LOCATION"
        '
        'txtPropertyLocation
        '
        Me.txtPropertyLocation.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPropertyLocation.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtPropertyLocation.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPropertyLocation.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPropertyLocation.Enabled = False
        Me.txtPropertyLocation.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPropertyLocation.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPropertyLocation.LineColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtPropertyLocation.Location = New System.Drawing.Point(381, 311)
        Me.txtPropertyLocation.Name = "txtPropertyLocation"
        Me.txtPropertyLocation.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPropertyLocation.SelectedText = ""
        Me.txtPropertyLocation.Size = New System.Drawing.Size(276, 32)
        Me.txtPropertyLocation.TabIndex = 142
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(80, 288)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 18)
        Me.Label4.TabIndex = 141
        Me.Label4.Text = "PROPERTY NAME"
        '
        'dgvMat
        '
        Me.dgvMat.AllowUserToAddRows = False
        Me.dgvMat.AllowUserToDeleteRows = False
        Me.dgvMat.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvMat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMat.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.dgvMat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMat.Location = New System.Drawing.Point(45, 19)
        Me.dgvMat.Name = "dgvMat"
        Me.dgvMat.ReadOnly = True
        Me.dgvMat.Size = New System.Drawing.Size(1011, 254)
        Me.dgvMat.TabIndex = 0
        '
        'frmAM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1116, 564)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAM"
        Me.Text = "frmAM"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvMat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents cboPropertyType As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents cboSProblemStatus As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dgvMat As DataGridView
    Friend WithEvents cboPropertyName As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtPropertyType As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents btnUpdate As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnDelete As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnAdd As Guna.UI.WinForms.GunaButton
    Friend WithEvents cboProblemStatus As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents rtbProblemDescription As RichTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPropertyLocation As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents Label4 As Label
End Class
