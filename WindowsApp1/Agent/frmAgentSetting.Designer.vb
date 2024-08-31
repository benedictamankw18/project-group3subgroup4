<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgentSetting
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgentSetting))
        Me.btnPassView = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.btnComPassView = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.txtCPass = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtPass = New Guna.UI.WinForms.GunaLineTextBox()
        Me.btnBrowse = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.pboProfile = New System.Windows.Forms.PictureBox()
        Me.btnChange = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.txtUsername = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtUserRole = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lilblHousing = New Guna.UI.WinForms.GunaLinkLabel()
        Me.lilblRent = New Guna.UI.WinForms.GunaLinkLabel()
        Me.lilblTransaction = New Guna.UI.WinForms.GunaLinkLabel()
        Me.lilblSale = New Guna.UI.WinForms.GunaLinkLabel()
        Me.lilblOwner = New Guna.UI.WinForms.GunaLinkLabel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.mtbBankAccount = New System.Windows.Forms.MaskedTextBox()
        Me.lilblHistroy = New Guna.UI.WinForms.GunaLinkLabel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.openDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.pboProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPassView
        '
        Me.btnPassView.BackColor = System.Drawing.SystemColors.Control
        Me.btnPassView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnPassView.CheckedState.Parent = Me.btnPassView
        Me.btnPassView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPassView.HoverState.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnPassView.HoverState.Parent = Me.btnPassView
        Me.btnPassView.Image = Global.WindowsApp1.My.Resources.Resources.eye30px
        Me.btnPassView.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnPassView.Location = New System.Drawing.Point(519, 172)
        Me.btnPassView.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPassView.Name = "btnPassView"
        Me.btnPassView.PressedState.Parent = Me.btnPassView
        Me.btnPassView.Size = New System.Drawing.Size(30, 30)
        Me.btnPassView.TabIndex = 146
        '
        'btnComPassView
        '
        Me.btnComPassView.BackColor = System.Drawing.SystemColors.Control
        Me.btnComPassView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnComPassView.CheckedState.Parent = Me.btnComPassView
        Me.btnComPassView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnComPassView.HoverState.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnComPassView.HoverState.Parent = Me.btnComPassView
        Me.btnComPassView.Image = Global.WindowsApp1.My.Resources.Resources.eye30px
        Me.btnComPassView.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnComPassView.Location = New System.Drawing.Point(519, 204)
        Me.btnComPassView.Margin = New System.Windows.Forms.Padding(2)
        Me.btnComPassView.Name = "btnComPassView"
        Me.btnComPassView.PressedState.Parent = Me.btnComPassView
        Me.btnComPassView.Size = New System.Drawing.Size(30, 30)
        Me.btnComPassView.TabIndex = 145
        '
        'txtCPass
        '
        Me.txtCPass.BackColor = System.Drawing.Color.White
        Me.txtCPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCPass.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCPass.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.txtCPass.LineColor = System.Drawing.Color.Gainsboro
        Me.txtCPass.Location = New System.Drawing.Point(323, 204)
        Me.txtCPass.Name = "txtCPass"
        Me.txtCPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtCPass.SelectedText = ""
        Me.txtCPass.Size = New System.Drawing.Size(197, 30)
        Me.txtCPass.TabIndex = 148
        Me.txtCPass.UseSystemPasswordChar = True
        '
        'txtPass
        '
        Me.txtPass.BackColor = System.Drawing.Color.White
        Me.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPass.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPass.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.txtPass.LineColor = System.Drawing.Color.Gainsboro
        Me.txtPass.Location = New System.Drawing.Point(323, 172)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPass.SelectedText = ""
        Me.txtPass.Size = New System.Drawing.Size(197, 30)
        Me.txtPass.TabIndex = 147
        Me.txtPass.UseSystemPasswordChar = True
        '
        'btnBrowse
        '
        Me.btnBrowse.AnimationHoverSpeed = 0.07!
        Me.btnBrowse.AnimationSpeed = 0.03!
        Me.btnBrowse.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBrowse.BorderColor = System.Drawing.Color.Black
        Me.btnBrowse.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnBrowse.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnBrowse.CheckedForeColor = System.Drawing.Color.White
        Me.btnBrowse.CheckedImage = CType(resources.GetObject("btnBrowse.CheckedImage"), System.Drawing.Image)
        Me.btnBrowse.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBrowse.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnBrowse.FocusedColor = System.Drawing.Color.Empty
        Me.btnBrowse.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnBrowse.ForeColor = System.Drawing.Color.White
        Me.btnBrowse.Image = Global.WindowsApp1.My.Resources.Resources._058_folder_2
        Me.btnBrowse.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnBrowse.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnBrowse.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnBrowse.Location = New System.Drawing.Point(933, 196)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBrowse.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnBrowse.OnHoverForeColor = System.Drawing.Color.White
        Me.btnBrowse.OnHoverImage = Nothing
        Me.btnBrowse.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnBrowse.OnPressedColor = System.Drawing.Color.Black
        Me.btnBrowse.Size = New System.Drawing.Size(122, 38)
        Me.btnBrowse.TabIndex = 144
        Me.btnBrowse.Text = "BROWSE"
        Me.btnBrowse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(758, 76)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(172, 18)
        Me.Label10.TabIndex = 143
        Me.Label10.Text = "PROFILE PICTURE"
        '
        'pboProfile
        '
        Me.pboProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pboProfile.Location = New System.Drawing.Point(761, 103)
        Me.pboProfile.Name = "pboProfile"
        Me.pboProfile.Size = New System.Drawing.Size(157, 131)
        Me.pboProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboProfile.TabIndex = 142
        Me.pboProfile.TabStop = False
        '
        'btnChange
        '
        Me.btnChange.AnimationHoverSpeed = 0.07!
        Me.btnChange.AnimationSpeed = 0.03!
        Me.btnChange.BackColor = System.Drawing.Color.White
        Me.btnChange.BaseColor = System.Drawing.Color.Gray
        Me.btnChange.BorderColor = System.Drawing.Color.Black
        Me.btnChange.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnChange.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnChange.CheckedForeColor = System.Drawing.Color.White
        Me.btnChange.CheckedImage = CType(resources.GetObject("btnChange.CheckedImage"), System.Drawing.Image)
        Me.btnChange.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnChange.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChange.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnChange.FocusedColor = System.Drawing.Color.Empty
        Me.btnChange.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnChange.ForeColor = System.Drawing.Color.White
        Me.btnChange.Image = Global.WindowsApp1.My.Resources.Resources._052_refresh_4
        Me.btnChange.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnChange.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnChange.LineColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnChange.Location = New System.Drawing.Point(565, 196)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnChange.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnChange.OnHoverForeColor = System.Drawing.Color.White
        Me.btnChange.OnHoverImage = Nothing
        Me.btnChange.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnChange.OnPressedColor = System.Drawing.Color.Black
        Me.btnChange.Size = New System.Drawing.Size(122, 38)
        Me.btnChange.TabIndex = 141
        Me.btnChange.Text = "CHANGE"
        Me.btnChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.White
        Me.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsername.Enabled = False
        Me.txtUsername.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsername.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.LineColor = System.Drawing.Color.Gainsboro
        Me.txtUsername.Location = New System.Drawing.Point(323, 136)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsername.ReadOnly = True
        Me.txtUsername.SelectedText = ""
        Me.txtUsername.Size = New System.Drawing.Size(226, 30)
        Me.txtUsername.TabIndex = 140
        Me.txtUsername.Text = "ADMINISTRATOR"
        '
        'txtUserRole
        '
        Me.txtUserRole.BackColor = System.Drawing.Color.White
        Me.txtUserRole.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUserRole.Enabled = False
        Me.txtUserRole.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUserRole.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserRole.LineColor = System.Drawing.Color.Gainsboro
        Me.txtUserRole.Location = New System.Drawing.Point(323, 76)
        Me.txtUserRole.Name = "txtUserRole"
        Me.txtUserRole.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUserRole.ReadOnly = True
        Me.txtUserRole.SelectedText = ""
        Me.txtUserRole.Size = New System.Drawing.Size(226, 30)
        Me.txtUserRole.TabIndex = 139
        Me.txtUserRole.Text = "ADMINISTRATOR"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(83, 210)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(191, 18)
        Me.Label5.TabIndex = 138
        Me.Label5.Text = "CHANGE PASSWORD"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(83, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 18)
        Me.Label4.TabIndex = 137
        Me.Label4.Text = "OLD PASSWORD"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(83, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 18)
        Me.Label2.TabIndex = 136
        Me.Label2.Text = "USERNAME"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(83, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 18)
        Me.Label1.TabIndex = 135
        Me.Label1.Text = "USER ROLE:"
        '
        'lilblHousing
        '
        Me.lilblHousing.AutoSize = True
        Me.lilblHousing.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lilblHousing.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lilblHousing.Location = New System.Drawing.Point(577, 292)
        Me.lilblHousing.Name = "lilblHousing"
        Me.lilblHousing.Size = New System.Drawing.Size(103, 15)
        Me.lilblHousing.TabIndex = 156
        Me.lilblHousing.TabStop = True
        Me.lilblHousing.Text = "HOUSING REPORT"
        '
        'lilblRent
        '
        Me.lilblRent.AutoSize = True
        Me.lilblRent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lilblRent.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lilblRent.Location = New System.Drawing.Point(884, 292)
        Me.lilblRent.Name = "lilblRent"
        Me.lilblRent.Size = New System.Drawing.Size(92, 15)
        Me.lilblRent.TabIndex = 155
        Me.lilblRent.TabStop = True
        Me.lilblRent.Text = "RENTAL REPORT"
        '
        'lilblTransaction
        '
        Me.lilblTransaction.AutoSize = True
        Me.lilblTransaction.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lilblTransaction.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lilblTransaction.Location = New System.Drawing.Point(717, 292)
        Me.lilblTransaction.Name = "lilblTransaction"
        Me.lilblTransaction.Size = New System.Drawing.Size(130, 15)
        Me.lilblTransaction.TabIndex = 153
        Me.lilblTransaction.TabStop = True
        Me.lilblTransaction.Text = "TRANSACTION REPORT"
        '
        'lilblSale
        '
        Me.lilblSale.AutoSize = True
        Me.lilblSale.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lilblSale.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lilblSale.Location = New System.Drawing.Point(463, 292)
        Me.lilblSale.Name = "lilblSale"
        Me.lilblSale.Size = New System.Drawing.Size(77, 15)
        Me.lilblSale.TabIndex = 152
        Me.lilblSale.TabStop = True
        Me.lilblSale.Text = "SALE REPORT"
        '
        'lilblOwner
        '
        Me.lilblOwner.AutoSize = True
        Me.lilblOwner.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lilblOwner.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lilblOwner.Location = New System.Drawing.Point(327, 292)
        Me.lilblOwner.Name = "lilblOwner"
        Me.lilblOwner.Size = New System.Drawing.Size(99, 15)
        Me.lilblOwner.TabIndex = 151
        Me.lilblOwner.TabStop = True
        Me.lilblOwner.Text = "OWNERS REPORT"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(83, 292)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(141, 18)
        Me.Label7.TabIndex = 149
        Me.Label7.Text = "REPORT (PDF)"
        '
        'mtbBankAccount
        '
        Me.mtbBankAccount.Enabled = False
        Me.mtbBankAccount.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbBankAccount.Location = New System.Drawing.Point(320, 415)
        Me.mtbBankAccount.Mask = "GHc 0000.00"
        Me.mtbBankAccount.Name = "mtbBankAccount"
        Me.mtbBankAccount.ReadOnly = True
        Me.mtbBankAccount.Size = New System.Drawing.Size(226, 26)
        Me.mtbBankAccount.TabIndex = 160
        Me.mtbBankAccount.Text = "222556"
        '
        'lilblHistroy
        '
        Me.lilblHistroy.AutoSize = True
        Me.lilblHistroy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lilblHistroy.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lilblHistroy.Location = New System.Drawing.Point(320, 354)
        Me.lilblHistroy.Name = "lilblHistroy"
        Me.lilblHistroy.Size = New System.Drawing.Size(113, 15)
        Me.lilblHistroy.TabIndex = 159
        Me.lilblHistroy.TabStop = True
        Me.lilblHistroy.Text = "OPEN HISTORY LOG"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(83, 419)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 18)
        Me.Label9.TabIndex = 158
        Me.Label9.Text = "SALARY"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(83, 352)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(151, 18)
        Me.Label8.TabIndex = 157
        Me.Label8.Text = "HISTORY (LOG)"
        '
        'frmAgentSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1132, 603)
        Me.Controls.Add(Me.mtbBankAccount)
        Me.Controls.Add(Me.lilblHistroy)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lilblHousing)
        Me.Controls.Add(Me.lilblRent)
        Me.Controls.Add(Me.lilblTransaction)
        Me.Controls.Add(Me.lilblSale)
        Me.Controls.Add(Me.lilblOwner)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnPassView)
        Me.Controls.Add(Me.btnComPassView)
        Me.Controls.Add(Me.txtCPass)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.pboProfile)
        Me.Controls.Add(Me.btnChange)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtUserRole)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAgentSetting"
        Me.Text = "frmAgentSetting"
        CType(Me.pboProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPassView As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents btnComPassView As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents txtCPass As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtPass As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents btnBrowse As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Label10 As Label
    Friend WithEvents pboProfile As PictureBox
    Friend WithEvents btnChange As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents txtUsername As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtUserRole As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lilblHousing As Guna.UI.WinForms.GunaLinkLabel
    Friend WithEvents lilblRent As Guna.UI.WinForms.GunaLinkLabel
    Friend WithEvents lilblTransaction As Guna.UI.WinForms.GunaLinkLabel
    Friend WithEvents lilblSale As Guna.UI.WinForms.GunaLinkLabel
    Friend WithEvents lilblOwner As Guna.UI.WinForms.GunaLinkLabel
    Friend WithEvents Label7 As Label
    Friend WithEvents mtbBankAccount As MaskedTextBox
    Friend WithEvents lilblHistroy As Guna.UI.WinForms.GunaLinkLabel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents openDialog1 As OpenFileDialog
End Class
