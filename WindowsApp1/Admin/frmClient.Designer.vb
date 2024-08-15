<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClient
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvClientManagement = New System.Windows.Forms.DataGridView()
        Me.txtClientAddress = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtClientContact = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtClientAgreement = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtClientName = New Guna.UI.WinForms.GunaLineTextBox()
        Me.btnUpdate = New Guna.UI.WinForms.GunaButton()
        Me.btnDelete = New Guna.UI.WinForms.GunaButton()
        Me.btnAdd = New Guna.UI.WinForms.GunaButton()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtClientType = New Guna.UI.WinForms.GunaLineTextBox()
        Me.btnClear = New Guna.UI.WinForms.GunaButton()
        Me.rtbClientNote = New System.Windows.Forms.RichTextBox()
        CType(Me.dgvClientManagement, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 29)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(351, 32)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "CLIENT MANAGEMENT"
        '
        'dgvClientManagement
        '
        Me.dgvClientManagement.AllowUserToAddRows = False
        Me.dgvClientManagement.AllowUserToDeleteRows = False
        Me.dgvClientManagement.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvClientManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientManagement.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvClientManagement.Location = New System.Drawing.Point(33, 75)
        Me.dgvClientManagement.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvClientManagement.Name = "dgvClientManagement"
        Me.dgvClientManagement.ReadOnly = True
        Me.dgvClientManagement.Size = New System.Drawing.Size(1013, 267)
        Me.dgvClientManagement.TabIndex = 126
        '
        'txtClientAddress
        '
        Me.txtClientAddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtClientAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtClientAddress.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtClientAddress.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClientAddress.LineColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtClientAddress.Location = New System.Drawing.Point(382, 456)
        Me.txtClientAddress.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtClientAddress.Name = "txtClientAddress"
        Me.txtClientAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtClientAddress.SelectedText = ""
        Me.txtClientAddress.Size = New System.Drawing.Size(297, 32)
        Me.txtClientAddress.TabIndex = 159
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(710, 361)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(164, 18)
        Me.Label7.TabIndex = 158
        Me.Label7.Text = "CLIENT'S CONTACT"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(382, 433)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(163, 18)
        Me.Label6.TabIndex = 157
        Me.Label6.Text = "CLIENT'S ADDRESS"
        '
        'txtClientContact
        '
        Me.txtClientContact.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtClientContact.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtClientContact.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtClientContact.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClientContact.LineColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtClientContact.Location = New System.Drawing.Point(710, 383)
        Me.txtClientContact.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtClientContact.MaxLength = 10
        Me.txtClientContact.Name = "txtClientContact"
        Me.txtClientContact.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtClientContact.SelectedText = ""
        Me.txtClientContact.Size = New System.Drawing.Size(297, 32)
        Me.txtClientContact.TabIndex = 156
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(54, 433)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 18)
        Me.Label1.TabIndex = 154
        Me.Label1.Text = "CLIENT'S AGREEMENT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(710, 433)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 18)
        Me.Label2.TabIndex = 153
        Me.Label2.Text = "CLIENT'S NOTES"
        '
        'txtClientAgreement
        '
        Me.txtClientAgreement.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtClientAgreement.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtClientAgreement.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtClientAgreement.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClientAgreement.LineColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtClientAgreement.Location = New System.Drawing.Point(54, 456)
        Me.txtClientAgreement.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtClientAgreement.Name = "txtClientAgreement"
        Me.txtClientAgreement.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtClientAgreement.SelectedText = ""
        Me.txtClientAgreement.Size = New System.Drawing.Size(297, 32)
        Me.txtClientAgreement.TabIndex = 152
        '
        'txtClientName
        '
        Me.txtClientName.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtClientName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtClientName.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtClientName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClientName.LineColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtClientName.Location = New System.Drawing.Point(54, 383)
        Me.txtClientName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtClientName.Name = "txtClientName"
        Me.txtClientName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtClientName.SelectedText = ""
        Me.txtClientName.Size = New System.Drawing.Size(297, 32)
        Me.txtClientName.TabIndex = 151
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
        Me.btnUpdate.Image = Global.WindowsApp1.My.Resources.Resources._030_changes
        Me.btnUpdate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnUpdate.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnUpdate.Location = New System.Drawing.Point(370, 542)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUpdate.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnUpdate.OnHoverForeColor = System.Drawing.Color.White
        Me.btnUpdate.OnHoverImage = Nothing
        Me.btnUpdate.OnPressedColor = System.Drawing.Color.Black
        Me.btnUpdate.Size = New System.Drawing.Size(124, 37)
        Me.btnUpdate.TabIndex = 150
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
        Me.btnDelete.Image = Global.WindowsApp1.My.Resources.Resources._007_bin
        Me.btnDelete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnDelete.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnDelete.Location = New System.Drawing.Point(228, 542)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDelete.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnDelete.OnHoverForeColor = System.Drawing.Color.White
        Me.btnDelete.OnHoverImage = Nothing
        Me.btnDelete.OnPressedColor = System.Drawing.Color.Black
        Me.btnDelete.Size = New System.Drawing.Size(124, 37)
        Me.btnDelete.TabIndex = 149
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
        Me.btnAdd.Location = New System.Drawing.Point(86, 542)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAdd.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnAdd.OnHoverForeColor = System.Drawing.Color.White
        Me.btnAdd.OnHoverImage = Nothing
        Me.btnAdd.OnPressedColor = System.Drawing.Color.Black
        Me.btnAdd.Size = New System.Drawing.Size(124, 37)
        Me.btnAdd.TabIndex = 148
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(382, 361)
        Me.Label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(128, 18)
        Me.Label25.TabIndex = 147
        Me.Label25.Text = "CLIENT'S TYPE"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(54, 361)
        Me.Label26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(133, 18)
        Me.Label26.TabIndex = 146
        Me.Label26.Text = "CLIENT'S NAME"
        '
        'txtClientType
        '
        Me.txtClientType.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtClientType.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtClientType.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtClientType.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClientType.LineColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtClientType.Location = New System.Drawing.Point(382, 383)
        Me.txtClientType.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtClientType.Name = "txtClientType"
        Me.txtClientType.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtClientType.SelectedText = ""
        Me.txtClientType.Size = New System.Drawing.Size(297, 32)
        Me.txtClientType.TabIndex = 145
        '
        'btnClear
        '
        Me.btnClear.AnimationHoverSpeed = 0.07!
        Me.btnClear.AnimationSpeed = 0.03!
        Me.btnClear.BaseColor = System.Drawing.Color.Silver
        Me.btnClear.BorderColor = System.Drawing.Color.Black
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnClear.FocusedColor = System.Drawing.Color.Empty
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Image = Global.WindowsApp1.My.Resources.Resources._006_clean
        Me.btnClear.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnClear.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnClear.Location = New System.Drawing.Point(512, 542)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnClear.OnHoverBorderColor = System.Drawing.Color.White
        Me.btnClear.OnHoverForeColor = System.Drawing.Color.White
        Me.btnClear.OnHoverImage = Nothing
        Me.btnClear.OnPressedColor = System.Drawing.Color.Black
        Me.btnClear.Size = New System.Drawing.Size(124, 37)
        Me.btnClear.TabIndex = 160
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'rtbClientNote
        '
        Me.rtbClientNote.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.rtbClientNote.Location = New System.Drawing.Point(710, 456)
        Me.rtbClientNote.Name = "rtbClientNote"
        Me.rtbClientNote.Size = New System.Drawing.Size(297, 123)
        Me.rtbClientNote.TabIndex = 161
        Me.rtbClientNote.Text = ""
        '
        'frmClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1088, 613)
        Me.Controls.Add(Me.rtbClientNote)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtClientAddress)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtClientContact)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtClientAgreement)
        Me.Controls.Add(Me.txtClientName)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.txtClientType)
        Me.Controls.Add(Me.dgvClientManagement)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmClient"
        Me.Text = "frmClient"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvClientManagement, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents dgvClientManagement As DataGridView
    Friend WithEvents txtClientAddress As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtClientContact As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtClientAgreement As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtClientName As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents btnUpdate As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnDelete As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnAdd As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents txtClientType As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents btnClear As Guna.UI.WinForms.GunaButton
    Friend WithEvents rtbClientNote As RichTextBox
End Class
