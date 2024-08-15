<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransaction
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
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cboViewPropertyAss = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.dgvTransaction = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCustomerName = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtTransactionDate = New Guna.UI.WinForms.GunaLineTextBox()
        Me.cboPropertyAssTo = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTransactionStatus = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtSaleRent = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTransactionAmount = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPaymentMode = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtPropertyPrice = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtPropertyName = New Guna.UI.WinForms.GunaLineTextBox()
        CType(Me.dgvTransaction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(510, 45)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(271, 18)
        Me.Label13.TabIndex = 154
        Me.Label13.Text = "VIEW PROPERTY ASSIGNED TO:"
        '
        'cboViewPropertyAss
        '
        Me.cboViewPropertyAss.BackColor = System.Drawing.Color.Transparent
        Me.cboViewPropertyAss.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboViewPropertyAss.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboViewPropertyAss.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboViewPropertyAss.FocusedColor = System.Drawing.Color.Empty
        Me.cboViewPropertyAss.FocusedState.Parent = Me.cboViewPropertyAss
        Me.cboViewPropertyAss.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboViewPropertyAss.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboViewPropertyAss.FormattingEnabled = True
        Me.cboViewPropertyAss.HoverState.Parent = Me.cboViewPropertyAss
        Me.cboViewPropertyAss.ItemHeight = 30
        Me.cboViewPropertyAss.ItemsAppearance.Parent = Me.cboViewPropertyAss
        Me.cboViewPropertyAss.Location = New System.Drawing.Point(787, 35)
        Me.cboViewPropertyAss.Name = "cboViewPropertyAss"
        Me.cboViewPropertyAss.ShadowDecoration.Parent = Me.cboViewPropertyAss
        Me.cboViewPropertyAss.Size = New System.Drawing.Size(276, 36)
        Me.cboViewPropertyAss.TabIndex = 153
        '
        'dgvTransaction
        '
        Me.dgvTransaction.AllowUserToAddRows = False
        Me.dgvTransaction.AllowUserToDeleteRows = False
        Me.dgvTransaction.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTransaction.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvTransaction.Location = New System.Drawing.Point(57, 103)
        Me.dgvTransaction.Name = "dgvTransaction"
        Me.dgvTransaction.ReadOnly = True
        Me.dgvTransaction.Size = New System.Drawing.Size(1006, 251)
        Me.dgvTransaction.TabIndex = 148
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(462, 32)
        Me.Label3.TabIndex = 136
        Me.Label3.Text = "TRANSACTION MANAGEMENT"
        '
        'txtCustomerName
        '
        Me.txtCustomerName.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtCustomerName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCustomerName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCustomerName.Enabled = False
        Me.txtCustomerName.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCustomerName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerName.LineColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtCustomerName.Location = New System.Drawing.Point(695, 540)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCustomerName.SelectedText = ""
        Me.txtCustomerName.Size = New System.Drawing.Size(269, 32)
        Me.txtCustomerName.TabIndex = 174
        '
        'txtTransactionDate
        '
        Me.txtTransactionDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtTransactionDate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTransactionDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTransactionDate.Enabled = False
        Me.txtTransactionDate.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTransactionDate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransactionDate.LineColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtTransactionDate.Location = New System.Drawing.Point(397, 540)
        Me.txtTransactionDate.Name = "txtTransactionDate"
        Me.txtTransactionDate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTransactionDate.SelectedText = ""
        Me.txtTransactionDate.Size = New System.Drawing.Size(276, 32)
        Me.txtTransactionDate.TabIndex = 173
        '
        'cboPropertyAssTo
        '
        Me.cboPropertyAssTo.BackColor = System.Drawing.Color.Transparent
        Me.cboPropertyAssTo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboPropertyAssTo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboPropertyAssTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPropertyAssTo.Enabled = False
        Me.cboPropertyAssTo.FocusedColor = System.Drawing.Color.Empty
        Me.cboPropertyAssTo.FocusedState.Parent = Me.cboPropertyAssTo
        Me.cboPropertyAssTo.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cboPropertyAssTo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboPropertyAssTo.FormattingEnabled = True
        Me.cboPropertyAssTo.HoverState.Parent = Me.cboPropertyAssTo
        Me.cboPropertyAssTo.ItemHeight = 25
        Me.cboPropertyAssTo.ItemsAppearance.Parent = Me.cboPropertyAssTo
        Me.cboPropertyAssTo.Location = New System.Drawing.Point(695, 405)
        Me.cboPropertyAssTo.Name = "cboPropertyAssTo"
        Me.cboPropertyAssTo.ShadowDecoration.Parent = Me.cboPropertyAssTo
        Me.cboPropertyAssTo.Size = New System.Drawing.Size(269, 31)
        Me.cboPropertyAssTo.TabIndex = 172
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(692, 518)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(152, 18)
        Me.Label7.TabIndex = 171
        Me.Label7.Text = "Customer's Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(397, 518)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(146, 18)
        Me.Label6.TabIndex = 170
        Me.Label6.Text = "Transaction Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(98, 518)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(160, 18)
        Me.Label5.TabIndex = 169
        Me.Label5.Text = "Transaction Status"
        '
        'txtTransactionStatus
        '
        Me.txtTransactionStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtTransactionStatus.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTransactionStatus.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTransactionStatus.Enabled = False
        Me.txtTransactionStatus.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTransactionStatus.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransactionStatus.LineColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtTransactionStatus.Location = New System.Drawing.Point(98, 540)
        Me.txtTransactionStatus.Name = "txtTransactionStatus"
        Me.txtTransactionStatus.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTransactionStatus.SelectedText = ""
        Me.txtTransactionStatus.Size = New System.Drawing.Size(276, 32)
        Me.txtTransactionStatus.TabIndex = 168
        '
        'txtSaleRent
        '
        Me.txtSaleRent.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtSaleRent.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSaleRent.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSaleRent.Enabled = False
        Me.txtSaleRent.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSaleRent.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaleRent.LineColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtSaleRent.Location = New System.Drawing.Point(98, 405)
        Me.txtSaleRent.Name = "txtSaleRent"
        Me.txtSaleRent.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSaleRent.SelectedText = ""
        Me.txtSaleRent.Size = New System.Drawing.Size(276, 32)
        Me.txtSaleRent.TabIndex = 167
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(699, 480)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 18)
        Me.Label2.TabIndex = 166
        Me.Label2.Text = "Ghc"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(692, 452)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 18)
        Me.Label4.TabIndex = 165
        Me.Label4.Text = "Amount Paid"
        '
        'txtTransactionAmount
        '
        Me.txtTransactionAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtTransactionAmount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTransactionAmount.Enabled = False
        Me.txtTransactionAmount.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTransactionAmount.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransactionAmount.LineColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtTransactionAmount.Location = New System.Drawing.Point(743, 473)
        Me.txtTransactionAmount.Name = "txtTransactionAmount"
        Me.txtTransactionAmount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTransactionAmount.SelectedText = ""
        Me.txtTransactionAmount.Size = New System.Drawing.Size(221, 32)
        Me.txtTransactionAmount.TabIndex = 164
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.Label27.Location = New System.Drawing.Point(404, 412)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(38, 18)
        Me.Label27.TabIndex = 163
        Me.Label27.Text = "Ghc"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(397, 453)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 18)
        Me.Label1.TabIndex = 162
        Me.Label1.Text = "PAYMENT MODE"
        '
        'txtPaymentMode
        '
        Me.txtPaymentMode.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtPaymentMode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPaymentMode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPaymentMode.Enabled = False
        Me.txtPaymentMode.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPaymentMode.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaymentMode.LineColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtPaymentMode.Location = New System.Drawing.Point(397, 473)
        Me.txtPaymentMode.Name = "txtPaymentMode"
        Me.txtPaymentMode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPaymentMode.SelectedText = ""
        Me.txtPaymentMode.Size = New System.Drawing.Size(276, 32)
        Me.txtPaymentMode.TabIndex = 161
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(397, 384)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(149, 18)
        Me.Label25.TabIndex = 160
        Me.Label25.Text = "PROPERTY PRICE"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(98, 384)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(190, 18)
        Me.Label26.TabIndex = 159
        Me.Label26.Text = "PROPERTY SALE/RENT"
        '
        'txtPropertyPrice
        '
        Me.txtPropertyPrice.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtPropertyPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPropertyPrice.Enabled = False
        Me.txtPropertyPrice.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPropertyPrice.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPropertyPrice.LineColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtPropertyPrice.Location = New System.Drawing.Point(448, 405)
        Me.txtPropertyPrice.Name = "txtPropertyPrice"
        Me.txtPropertyPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPropertyPrice.SelectedText = ""
        Me.txtPropertyPrice.Size = New System.Drawing.Size(224, 32)
        Me.txtPropertyPrice.TabIndex = 158
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(692, 384)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(220, 18)
        Me.Label14.TabIndex = 157
        Me.Label14.Text = "PROPERTY ASSIGNED TO:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(98, 450)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(146, 18)
        Me.Label21.TabIndex = 156
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
        Me.txtPropertyName.Location = New System.Drawing.Point(98, 473)
        Me.txtPropertyName.Name = "txtPropertyName"
        Me.txtPropertyName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPropertyName.SelectedText = ""
        Me.txtPropertyName.Size = New System.Drawing.Size(276, 32)
        Me.txtPropertyName.TabIndex = 155
        '
        'frmTransaction
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1088, 613)
        Me.Controls.Add(Me.txtCustomerName)
        Me.Controls.Add(Me.txtTransactionDate)
        Me.Controls.Add(Me.cboPropertyAssTo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTransactionStatus)
        Me.Controls.Add(Me.txtSaleRent)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTransactionAmount)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPaymentMode)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.txtPropertyPrice)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.txtPropertyName)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cboViewPropertyAss)
        Me.Controls.Add(Me.dgvTransaction)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTransaction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmTransaction"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvTransaction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label13 As Label
    Friend WithEvents cboViewPropertyAss As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents dgvTransaction As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCustomerName As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtTransactionDate As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents cboPropertyAssTo As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTransactionStatus As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtSaleRent As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTransactionAmount As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPaymentMode As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents txtPropertyPrice As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents txtPropertyName As Guna.UI.WinForms.GunaLineTextBox
End Class
