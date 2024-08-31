<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProperty
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
        Me.palMain = New Guna.UI.WinForms.GunaElipsePanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnRent = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAll = New Guna.UI2.WinForms.Guna2Button()
        Me.btnHousing = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.palMain)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1132, 603)
        Me.Panel1.TabIndex = 0
        '
        'palMain
        '
        Me.palMain.AllowDrop = True
        Me.palMain.AutoScroll = True
        Me.palMain.AutoScrollMargin = New System.Drawing.Size(0, 30)
        Me.palMain.BackColor = System.Drawing.Color.Transparent
        Me.palMain.BaseColor = System.Drawing.Color.Transparent
        Me.palMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.palMain.Location = New System.Drawing.Point(0, 70)
        Me.palMain.Name = "palMain"
        Me.palMain.Size = New System.Drawing.Size(1132, 533)
        Me.palMain.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.txtSearch)
        Me.Panel2.Controls.Add(Me.btnRent)
        Me.Panel2.Controls.Add(Me.btnAll)
        Me.Panel2.Controls.Add(Me.btnHousing)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1132, 70)
        Me.Panel2.TabIndex = 0
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
        Me.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.HoverState.Parent = Me.txtSearch
        Me.txtSearch.IconLeft = Global.WindowsApp1.My.Resources.Resources.magnifier
        Me.txtSearch.Location = New System.Drawing.Point(774, 23)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.PlaceholderText = "Search..."
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.ShadowDecoration.Parent = Me.txtSearch
        Me.txtSearch.Size = New System.Drawing.Size(297, 34)
        Me.txtSearch.TabIndex = 18
        '
        'btnRent
        '
        Me.btnRent.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnRent.Animated = True
        Me.btnRent.BorderRadius = 7
        Me.btnRent.CheckedState.Parent = Me.btnRent
        Me.btnRent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRent.CustomImages.Parent = Me.btnRent
        Me.btnRent.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRent.ForeColor = System.Drawing.Color.White
        Me.btnRent.HoverState.Parent = Me.btnRent
        Me.btnRent.Location = New System.Drawing.Point(437, 23)
        Me.btnRent.Name = "btnRent"
        Me.btnRent.ShadowDecoration.Parent = Me.btnRent
        Me.btnRent.Size = New System.Drawing.Size(115, 34)
        Me.btnRent.TabIndex = 17
        Me.btnRent.Text = "RENTAL"
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
        Me.btnAll.Location = New System.Drawing.Point(121, 23)
        Me.btnAll.Name = "btnAll"
        Me.btnAll.ShadowDecoration.Parent = Me.btnAll
        Me.btnAll.Size = New System.Drawing.Size(115, 34)
        Me.btnAll.TabIndex = 15
        Me.btnAll.Text = "ALL"
        '
        'btnHousing
        '
        Me.btnHousing.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnHousing.Animated = True
        Me.btnHousing.BorderRadius = 7
        Me.btnHousing.CheckedState.Parent = Me.btnHousing
        Me.btnHousing.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHousing.CustomImages.Parent = Me.btnHousing
        Me.btnHousing.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHousing.ForeColor = System.Drawing.Color.White
        Me.btnHousing.HoverState.Parent = Me.btnHousing
        Me.btnHousing.Location = New System.Drawing.Point(279, 23)
        Me.btnHousing.Name = "btnHousing"
        Me.btnHousing.ShadowDecoration.Parent = Me.btnHousing
        Me.btnHousing.Size = New System.Drawing.Size(115, 34)
        Me.btnHousing.TabIndex = 16
        Me.btnHousing.Text = "HOUSING"
        '
        'frmProperty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1132, 603)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmProperty"
        Me.Text = "frmProperty"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnRent As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAll As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnHousing As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents palMain As Guna.UI.WinForms.GunaElipsePanel
End Class
