<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPictureView
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
        Me.components = New System.ComponentModel.Container()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GunaControlBox3 = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaControlBox2 = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaControlBox1 = New Guna.UI.WinForms.GunaControlBox()
        Me.Guna2CirclePictureBox2 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblPropertyName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.pboView = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.pboImage4 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.pboImage3 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.pboImage2 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.pboImage1 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.Guna2CirclePictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.pboView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        CType(Me.pboImage4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboImage3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboImage2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboImage1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Me.Panel2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Guna2CirclePictureBox2)
        Me.Panel2.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(902, 35)
        Me.Panel2.TabIndex = 15
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(Me.GunaControlBox3)
        Me.Panel3.Controls.Add(Me.GunaControlBox2)
        Me.Panel3.Controls.Add(Me.GunaControlBox1)
        Me.Panel3.Location = New System.Drawing.Point(758, -1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(143, 36)
        Me.Panel3.TabIndex = 12
        '
        'GunaControlBox3
        '
        Me.GunaControlBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox3.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox3.AnimationSpeed = 0.03!
        Me.GunaControlBox3.BackColor = System.Drawing.Color.Transparent
        Me.GunaControlBox3.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox
        Me.GunaControlBox3.IconColor = System.Drawing.Color.White
        Me.GunaControlBox3.IconSize = 15.0!
        Me.GunaControlBox3.Location = New System.Drawing.Point(6, 1)
        Me.GunaControlBox3.Name = "GunaControlBox3"
        Me.GunaControlBox3.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.GunaControlBox3.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox3.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox3.Size = New System.Drawing.Size(45, 35)
        Me.GunaControlBox3.TabIndex = 20
        '
        'GunaControlBox2
        '
        Me.GunaControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox2.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox2.AnimationSpeed = 0.03!
        Me.GunaControlBox2.BackColor = System.Drawing.Color.Transparent
        Me.GunaControlBox2.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MaximizeBox
        Me.GunaControlBox2.IconColor = System.Drawing.Color.White
        Me.GunaControlBox2.IconSize = 15.0!
        Me.GunaControlBox2.Location = New System.Drawing.Point(54, 1)
        Me.GunaControlBox2.Name = "GunaControlBox2"
        Me.GunaControlBox2.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.GunaControlBox2.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox2.Size = New System.Drawing.Size(45, 35)
        Me.GunaControlBox2.TabIndex = 19
        '
        'GunaControlBox1
        '
        Me.GunaControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox1.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox1.AnimationSpeed = 0.03!
        Me.GunaControlBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaControlBox1.IconColor = System.Drawing.Color.White
        Me.GunaControlBox1.IconSize = 15.0!
        Me.GunaControlBox1.Location = New System.Drawing.Point(98, 1)
        Me.GunaControlBox1.Name = "GunaControlBox1"
        Me.GunaControlBox1.OnHoverBackColor = System.Drawing.Color.Red
        Me.GunaControlBox1.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox1.Size = New System.Drawing.Size(45, 35)
        Me.GunaControlBox1.TabIndex = 18
        '
        'Guna2CirclePictureBox2
        '
        Me.Guna2CirclePictureBox2.Image = Global.WindowsApp1.My.Resources.Resources.LOGOCOLOR
        Me.Guna2CirclePictureBox2.Location = New System.Drawing.Point(4, 3)
        Me.Guna2CirclePictureBox2.Name = "Guna2CirclePictureBox2"
        Me.Guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox2.ShadowDecoration.Parent = Me.Guna2CirclePictureBox2
        Me.Guna2CirclePictureBox2.Size = New System.Drawing.Size(35, 29)
        Me.Guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2CirclePictureBox2.TabIndex = 9
        Me.Guna2CirclePictureBox2.TabStop = False
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(43, 7)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(114, 22)
        Me.Guna2HtmlLabel1.TabIndex = 11
        Me.Guna2HtmlLabel1.Text = "LEGACY HOME"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblPropertyName)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 35)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(902, 55)
        Me.Panel1.TabIndex = 16
        '
        'lblPropertyName
        '
        Me.lblPropertyName.BackColor = System.Drawing.Color.Transparent
        Me.lblPropertyName.Font = New System.Drawing.Font("Showcard Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPropertyName.Location = New System.Drawing.Point(12, 12)
        Me.lblPropertyName.Name = "lblPropertyName"
        Me.lblPropertyName.Size = New System.Drawing.Size(166, 32)
        Me.lblPropertyName.TabIndex = 12
        Me.lblPropertyName.Text = "LEGACY HOME"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.pboView)
        Me.Panel4.Controls.Add(Me.Panel7)
        Me.Panel4.Controls.Add(Me.Panel6)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 90)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(902, 470)
        Me.Panel4.TabIndex = 17
        '
        'pboView
        '
        Me.pboView.BackColor = System.Drawing.Color.Transparent
        Me.pboView.BaseColor = System.Drawing.Color.Black
        Me.pboView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pboView.Location = New System.Drawing.Point(70, 0)
        Me.pboView.Name = "pboView"
        Me.pboView.Size = New System.Drawing.Size(762, 383)
        Me.pboView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboView.TabIndex = 6
        Me.pboView.TabStop = False
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.pboImage4)
        Me.Panel7.Controls.Add(Me.pboImage3)
        Me.Panel7.Controls.Add(Me.pboImage2)
        Me.Panel7.Controls.Add(Me.pboImage1)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Location = New System.Drawing.Point(70, 383)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(762, 87)
        Me.Panel7.TabIndex = 2
        '
        'pboImage4
        '
        Me.pboImage4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pboImage4.BackColor = System.Drawing.Color.Transparent
        Me.pboImage4.BaseColor = System.Drawing.Color.Black
        Me.pboImage4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pboImage4.Location = New System.Drawing.Point(511, 17)
        Me.pboImage4.Name = "pboImage4"
        Me.pboImage4.Size = New System.Drawing.Size(102, 60)
        Me.pboImage4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboImage4.TabIndex = 6
        Me.pboImage4.TabStop = False
        '
        'pboImage3
        '
        Me.pboImage3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pboImage3.BackColor = System.Drawing.Color.Transparent
        Me.pboImage3.BaseColor = System.Drawing.Color.Black
        Me.pboImage3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pboImage3.Location = New System.Drawing.Point(386, 17)
        Me.pboImage3.Name = "pboImage3"
        Me.pboImage3.Size = New System.Drawing.Size(102, 60)
        Me.pboImage3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboImage3.TabIndex = 5
        Me.pboImage3.TabStop = False
        '
        'pboImage2
        '
        Me.pboImage2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pboImage2.BackColor = System.Drawing.Color.Transparent
        Me.pboImage2.BaseColor = System.Drawing.Color.Black
        Me.pboImage2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pboImage2.Location = New System.Drawing.Point(261, 17)
        Me.pboImage2.Name = "pboImage2"
        Me.pboImage2.Size = New System.Drawing.Size(102, 60)
        Me.pboImage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboImage2.TabIndex = 4
        Me.pboImage2.TabStop = False
        '
        'pboImage1
        '
        Me.pboImage1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pboImage1.BackColor = System.Drawing.Color.Transparent
        Me.pboImage1.BaseColor = System.Drawing.Color.Black
        Me.pboImage1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pboImage1.Location = New System.Drawing.Point(136, 17)
        Me.pboImage1.Name = "pboImage1"
        Me.pboImage1.Size = New System.Drawing.Size(102, 60)
        Me.pboImage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboImage1.TabIndex = 3
        Me.pboImage1.TabStop = False
        '
        'Panel6
        '
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(832, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(70, 470)
        Me.Panel6.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(70, 470)
        Me.Panel5.TabIndex = 0
        '
        'frmPictureView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(902, 560)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPictureView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmPictureView"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.Guna2CirclePictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        CType(Me.pboView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        CType(Me.pboImage4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboImage3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboImage2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboImage1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents Panel4 As Panel
    Friend WithEvents pboView As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents pboImage3 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents pboImage2 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents pboImage1 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblPropertyName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GunaControlBox3 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaControlBox2 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaControlBox1 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents Guna2CirclePictureBox2 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents pboImage4 As Guna.UI.WinForms.GunaTransfarantPictureBox
End Class
