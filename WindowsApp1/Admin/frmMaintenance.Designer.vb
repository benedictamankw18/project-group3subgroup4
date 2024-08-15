<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAgentMaintenance
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
        Me.dgvMaintenanceManagement = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPropertyLocation = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.rtbProblemDescription = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboProblemStatus = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btnUpdate = New Guna.UI.WinForms.GunaButton()
        Me.btnDelete = New Guna.UI.WinForms.GunaButton()
        Me.btnAdd = New Guna.UI.WinForms.GunaButton()
        Me.txtPropertyType = New Guna.UI.WinForms.GunaLineTextBox()
        Me.cboPropertyName = New Guna.UI2.WinForms.Guna2ComboBox()
        CType(Me.dgvMaintenanceManagement, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvMaintenanceManagement
        '
        Me.dgvMaintenanceManagement.AllowUserToAddRows = False
        Me.dgvMaintenanceManagement.AllowUserToDeleteRows = False
        Me.dgvMaintenanceManagement.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvMaintenanceManagement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMaintenanceManagement.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvMaintenanceManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMaintenanceManagement.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvMaintenanceManagement.Location = New System.Drawing.Point(39, 65)
        Me.dgvMaintenanceManagement.Name = "dgvMaintenanceManagement"
        Me.dgvMaintenanceManagement.ReadOnly = True
        Me.dgvMaintenanceManagement.Size = New System.Drawing.Size(1269, 187)
        Me.dgvMaintenanceManagement.TabIndex = 63
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(466, 32)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "MAINTENANCE MANAGEMENT"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(635, 269)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 18)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "PROPERTY TYPE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(340, 269)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(185, 18)
        Me.Label5.TabIndex = 67
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
        Me.txtPropertyLocation.Location = New System.Drawing.Point(343, 292)
        Me.txtPropertyLocation.Name = "txtPropertyLocation"
        Me.txtPropertyLocation.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPropertyLocation.SelectedText = ""
        Me.txtPropertyLocation.Size = New System.Drawing.Size(276, 32)
        Me.txtPropertyLocation.TabIndex = 66
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(42, 269)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 18)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "PROPERTY NAME"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(42, 340)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(204, 18)
        Me.Label10.TabIndex = 71
        Me.Label10.Text = "PROBLEM DESCRIPTION"
        '
        'rtbProblemDescription
        '
        Me.rtbProblemDescription.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.rtbProblemDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rtbProblemDescription.Location = New System.Drawing.Point(39, 359)
        Me.rtbProblemDescription.Name = "rtbProblemDescription"
        Me.rtbProblemDescription.Size = New System.Drawing.Size(617, 179)
        Me.rtbProblemDescription.TabIndex = 70
        Me.rtbProblemDescription.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(676, 340)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 18)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "PROBLEM STATUS"
        '
        'cboProblemStatus
        '
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
        Me.cboProblemStatus.Location = New System.Drawing.Point(679, 359)
        Me.cboProblemStatus.Name = "cboProblemStatus"
        Me.cboProblemStatus.ShadowDecoration.Parent = Me.cboProblemStatus
        Me.cboProblemStatus.Size = New System.Drawing.Size(235, 36)
        Me.cboProblemStatus.TabIndex = 73
        '
        'btnUpdate
        '
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
        Me.btnUpdate.Location = New System.Drawing.Point(397, 566)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUpdate.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnUpdate.OnHoverForeColor = System.Drawing.Color.White
        Me.btnUpdate.OnHoverImage = Nothing
        Me.btnUpdate.OnPressedColor = System.Drawing.Color.Black
        Me.btnUpdate.Size = New System.Drawing.Size(122, 42)
        Me.btnUpdate.TabIndex = 138
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnDelete
        '
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
        Me.btnDelete.Location = New System.Drawing.Point(224, 566)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDelete.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnDelete.OnHoverForeColor = System.Drawing.Color.White
        Me.btnDelete.OnHoverImage = Nothing
        Me.btnDelete.OnPressedColor = System.Drawing.Color.Black
        Me.btnDelete.Size = New System.Drawing.Size(122, 42)
        Me.btnDelete.TabIndex = 137
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnAdd
        '
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
        Me.btnAdd.Location = New System.Drawing.Point(49, 566)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAdd.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnAdd.OnHoverForeColor = System.Drawing.Color.White
        Me.btnAdd.OnHoverImage = Nothing
        Me.btnAdd.OnPressedColor = System.Drawing.Color.Black
        Me.btnAdd.Size = New System.Drawing.Size(122, 42)
        Me.btnAdd.TabIndex = 136
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPropertyType
        '
        Me.txtPropertyType.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtPropertyType.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPropertyType.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPropertyType.Enabled = False
        Me.txtPropertyType.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPropertyType.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPropertyType.LineColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtPropertyType.Location = New System.Drawing.Point(638, 292)
        Me.txtPropertyType.Name = "txtPropertyType"
        Me.txtPropertyType.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPropertyType.SelectedText = ""
        Me.txtPropertyType.Size = New System.Drawing.Size(276, 32)
        Me.txtPropertyType.TabIndex = 139
        '
        'cboPropertyName
        '
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
        Me.cboPropertyName.Location = New System.Drawing.Point(39, 288)
        Me.cboPropertyName.Name = "cboPropertyName"
        Me.cboPropertyName.ShadowDecoration.Parent = Me.cboPropertyName
        Me.cboPropertyName.Size = New System.Drawing.Size(289, 36)
        Me.cboPropertyName.TabIndex = 140
        '
        'frmAgentMaintenance
        '
        Me.AllowDrop = True
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.cboPropertyName)
        Me.Controls.Add(Me.txtPropertyType)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.cboProblemStatus)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.rtbProblemDescription)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPropertyLocation)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgvMaintenanceManagement)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAgentMaintenance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLand"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvMaintenanceManagement, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvMaintenanceManagement As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPropertyLocation As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents rtbProblemDescription As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cboProblemStatus As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btnUpdate As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnDelete As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnAdd As Guna.UI.WinForms.GunaButton
    Friend WithEvents txtPropertyType As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents cboPropertyName As Guna.UI2.WinForms.Guna2ComboBox
End Class
