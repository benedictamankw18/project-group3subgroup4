<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAgentDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgentDashboard))
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.palMainFrame = New System.Windows.Forms.Panel()
        Me.palMain = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnlogOut = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.btnSetting = New Guna.UI.WinForms.GunaButton()
        Me.btnHome = New Guna.UI.WinForms.GunaButton()
        Me.btnProperty = New Guna.UI.WinForms.GunaButton()
        Me.btnCustomerDetail = New Guna.UI.WinForms.GunaButton()
        Me.btnTransactionSale = New Guna.UI.WinForms.GunaButton()
        Me.btnMaintenance = New Guna.UI.WinForms.GunaButton()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnMode = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblUsername = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnUserIcon = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.btnDropDown = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.palHeader = New System.Windows.Forms.Panel()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Guna2CirclePictureBox2 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GunaControlBox3 = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaControlBox2 = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaControlBox1 = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.palMainFrame.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.palHeader.SuspendLayout()
        CType(Me.Guna2CirclePictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.Image = Global.WindowsApp1.My.Resources.Resources.LOGOBLACKwHITE
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(22, 19)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.ShadowDecoration.Parent = Me.Guna2CirclePictureBox1
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(35, 30)
        Me.Guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2CirclePictureBox1.TabIndex = 2
        Me.Guna2CirclePictureBox1.TabStop = False
        '
        'palMainFrame
        '
        Me.palMainFrame.BackColor = System.Drawing.SystemColors.Control
        Me.palMainFrame.Controls.Add(Me.palMain)
        Me.palMainFrame.Controls.Add(Me.Panel10)
        Me.palMainFrame.Controls.Add(Me.Panel8)
        Me.palMainFrame.Controls.Add(Me.Panel1)
        Me.palMainFrame.Controls.Add(Me.Panel9)
        Me.palMainFrame.Dock = System.Windows.Forms.DockStyle.Fill
        Me.palMainFrame.Location = New System.Drawing.Point(0, 97)
        Me.palMainFrame.Name = "palMainFrame"
        Me.palMainFrame.Size = New System.Drawing.Size(1144, 652)
        Me.palMainFrame.TabIndex = 12
        '
        'palMain
        '
        Me.palMain.AutoScroll = True
        Me.palMain.AutoScrollMargin = New System.Drawing.Size(50, 50)
        Me.palMain.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.palMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.palMain.Location = New System.Drawing.Point(30, 52)
        Me.palMain.Name = "palMain"
        Me.palMain.Size = New System.Drawing.Size(1084, 568)
        Me.palMain.TabIndex = 1
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel10.Location = New System.Drawing.Point(1114, 52)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(30, 568)
        Me.Panel10.TabIndex = 7
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel8.Location = New System.Drawing.Point(0, 52)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(30, 568)
        Me.Panel8.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1144, 52)
        Me.Panel1.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.btnlogOut)
        Me.Panel4.Controls.Add(Me.btnSetting)
        Me.Panel4.Controls.Add(Me.btnHome)
        Me.Panel4.Controls.Add(Me.btnProperty)
        Me.Panel4.Controls.Add(Me.btnCustomerDetail)
        Me.Panel4.Controls.Add(Me.btnTransactionSale)
        Me.Panel4.Controls.Add(Me.btnMaintenance)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1144, 52)
        Me.Panel4.TabIndex = 1
        '
        'btnlogOut
        '
        Me.btnlogOut.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnlogOut.CheckedState.Parent = Me.btnlogOut
        Me.btnlogOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnlogOut.HoverState.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnlogOut.HoverState.Parent = Me.btnlogOut
        Me.btnlogOut.Image = Global.WindowsApp1.My.Resources.Resources.logOutnoBg
        Me.btnlogOut.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnlogOut.Location = New System.Drawing.Point(1069, 11)
        Me.btnlogOut.Name = "btnlogOut"
        Me.btnlogOut.PressedState.Parent = Me.btnlogOut
        Me.btnlogOut.Size = New System.Drawing.Size(30, 30)
        Me.btnlogOut.TabIndex = 8
        '
        'btnSetting
        '
        Me.btnSetting.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.btnSetting.AllowDrop = True
        Me.btnSetting.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSetting.Animated = True
        Me.btnSetting.AnimationHoverSpeed = 0.07!
        Me.btnSetting.AnimationSpeed = 0.03!
        Me.btnSetting.BackColor = System.Drawing.Color.Transparent
        Me.btnSetting.BaseColor = System.Drawing.Color.Transparent
        Me.btnSetting.BorderColor = System.Drawing.Color.Transparent
        Me.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSetting.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnSetting.FocusedColor = System.Drawing.Color.Empty
        Me.btnSetting.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetting.ForeColor = System.Drawing.Color.Black
        Me.btnSetting.Image = Global.WindowsApp1.My.Resources.Resources._034_system_update
        Me.btnSetting.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnSetting.Location = New System.Drawing.Point(895, 14)
        Me.btnSetting.Name = "btnSetting"
        Me.btnSetting.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnSetting.OnHoverBorderColor = System.Drawing.Color.White
        Me.btnSetting.OnHoverForeColor = System.Drawing.Color.White
        Me.btnSetting.OnHoverImage = Nothing
        Me.btnSetting.OnPressedColor = System.Drawing.Color.Black
        Me.btnSetting.Radius = 5
        Me.btnSetting.Size = New System.Drawing.Size(101, 25)
        Me.btnSetting.TabIndex = 5
        Me.btnSetting.Text = "Settings"
        '
        'btnHome
        '
        Me.btnHome.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.btnHome.AllowDrop = True
        Me.btnHome.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnHome.Animated = True
        Me.btnHome.AnimationHoverSpeed = 0.07!
        Me.btnHome.AnimationSpeed = 0.03!
        Me.btnHome.BackColor = System.Drawing.Color.Transparent
        Me.btnHome.BaseColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnHome.BorderColor = System.Drawing.Color.Transparent
        Me.btnHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHome.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnHome.FocusedColor = System.Drawing.Color.Empty
        Me.btnHome.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.ForeColor = System.Drawing.Color.Black
        Me.btnHome.Image = Global.WindowsApp1.My.Resources.Resources.home
        Me.btnHome.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnHome.Location = New System.Drawing.Point(136, 14)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnHome.OnHoverBorderColor = System.Drawing.Color.White
        Me.btnHome.OnHoverForeColor = System.Drawing.Color.White
        Me.btnHome.OnHoverImage = Nothing
        Me.btnHome.OnPressedColor = System.Drawing.Color.Black
        Me.btnHome.Radius = 5
        Me.btnHome.Size = New System.Drawing.Size(93, 25)
        Me.btnHome.TabIndex = 0
        Me.btnHome.Text = "HOME"
        '
        'btnProperty
        '
        Me.btnProperty.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.btnProperty.AllowDrop = True
        Me.btnProperty.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnProperty.Animated = True
        Me.btnProperty.AnimationHoverSpeed = 0.07!
        Me.btnProperty.AnimationSpeed = 0.03!
        Me.btnProperty.BackColor = System.Drawing.Color.Transparent
        Me.btnProperty.BaseColor = System.Drawing.Color.Transparent
        Me.btnProperty.BorderColor = System.Drawing.Color.Transparent
        Me.btnProperty.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProperty.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnProperty.FocusedColor = System.Drawing.Color.Empty
        Me.btnProperty.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProperty.ForeColor = System.Drawing.Color.Black
        Me.btnProperty.Image = Global.WindowsApp1.My.Resources.Resources._004_property
        Me.btnProperty.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnProperty.Location = New System.Drawing.Point(246, 14)
        Me.btnProperty.Name = "btnProperty"
        Me.btnProperty.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnProperty.OnHoverBorderColor = System.Drawing.Color.White
        Me.btnProperty.OnHoverForeColor = System.Drawing.Color.White
        Me.btnProperty.OnHoverImage = Nothing
        Me.btnProperty.OnPressedColor = System.Drawing.Color.Black
        Me.btnProperty.Radius = 5
        Me.btnProperty.Size = New System.Drawing.Size(110, 25)
        Me.btnProperty.TabIndex = 4
        Me.btnProperty.Text = "Property"
        '
        'btnCustomerDetail
        '
        Me.btnCustomerDetail.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.btnCustomerDetail.AllowDrop = True
        Me.btnCustomerDetail.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCustomerDetail.Animated = True
        Me.btnCustomerDetail.AnimationHoverSpeed = 0.07!
        Me.btnCustomerDetail.AnimationSpeed = 0.03!
        Me.btnCustomerDetail.BackColor = System.Drawing.Color.Transparent
        Me.btnCustomerDetail.BaseColor = System.Drawing.Color.Transparent
        Me.btnCustomerDetail.BorderColor = System.Drawing.Color.Transparent
        Me.btnCustomerDetail.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCustomerDetail.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCustomerDetail.FocusedColor = System.Drawing.Color.Empty
        Me.btnCustomerDetail.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomerDetail.ForeColor = System.Drawing.Color.Black
        Me.btnCustomerDetail.Image = Global.WindowsApp1.My.Resources.Resources._014_customer
        Me.btnCustomerDetail.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnCustomerDetail.Location = New System.Drawing.Point(373, 14)
        Me.btnCustomerDetail.Name = "btnCustomerDetail"
        Me.btnCustomerDetail.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnCustomerDetail.OnHoverBorderColor = System.Drawing.Color.White
        Me.btnCustomerDetail.OnHoverForeColor = System.Drawing.Color.White
        Me.btnCustomerDetail.OnHoverImage = Nothing
        Me.btnCustomerDetail.OnPressedColor = System.Drawing.Color.Black
        Me.btnCustomerDetail.Radius = 5
        Me.btnCustomerDetail.Size = New System.Drawing.Size(166, 25)
        Me.btnCustomerDetail.TabIndex = 3
        Me.btnCustomerDetail.Text = "Customer Details"
        '
        'btnTransactionSale
        '
        Me.btnTransactionSale.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.btnTransactionSale.AllowDrop = True
        Me.btnTransactionSale.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnTransactionSale.Animated = True
        Me.btnTransactionSale.AnimationHoverSpeed = 0.07!
        Me.btnTransactionSale.AnimationSpeed = 0.03!
        Me.btnTransactionSale.BackColor = System.Drawing.Color.Transparent
        Me.btnTransactionSale.BaseColor = System.Drawing.Color.Transparent
        Me.btnTransactionSale.BorderColor = System.Drawing.Color.Transparent
        Me.btnTransactionSale.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTransactionSale.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnTransactionSale.FocusedColor = System.Drawing.Color.Empty
        Me.btnTransactionSale.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransactionSale.ForeColor = System.Drawing.Color.Black
        Me.btnTransactionSale.Image = Global.WindowsApp1.My.Resources.Resources._003_financial
        Me.btnTransactionSale.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnTransactionSale.Location = New System.Drawing.Point(705, 14)
        Me.btnTransactionSale.Name = "btnTransactionSale"
        Me.btnTransactionSale.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnTransactionSale.OnHoverBorderColor = System.Drawing.Color.White
        Me.btnTransactionSale.OnHoverForeColor = System.Drawing.Color.White
        Me.btnTransactionSale.OnHoverImage = Nothing
        Me.btnTransactionSale.OnPressedColor = System.Drawing.Color.Black
        Me.btnTransactionSale.Radius = 5
        Me.btnTransactionSale.Size = New System.Drawing.Size(173, 25)
        Me.btnTransactionSale.TabIndex = 1
        Me.btnTransactionSale.Text = "Transaction & Sale"
        '
        'btnMaintenance
        '
        Me.btnMaintenance.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.btnMaintenance.AllowDrop = True
        Me.btnMaintenance.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnMaintenance.Animated = True
        Me.btnMaintenance.AnimationHoverSpeed = 0.07!
        Me.btnMaintenance.AnimationSpeed = 0.03!
        Me.btnMaintenance.BackColor = System.Drawing.Color.Transparent
        Me.btnMaintenance.BaseColor = System.Drawing.Color.Transparent
        Me.btnMaintenance.BorderColor = System.Drawing.Color.Transparent
        Me.btnMaintenance.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMaintenance.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnMaintenance.FocusedColor = System.Drawing.Color.Empty
        Me.btnMaintenance.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMaintenance.ForeColor = System.Drawing.Color.Black
        Me.btnMaintenance.Image = Global.WindowsApp1.My.Resources.Resources._001_management
        Me.btnMaintenance.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnMaintenance.Location = New System.Drawing.Point(556, 14)
        Me.btnMaintenance.Name = "btnMaintenance"
        Me.btnMaintenance.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnMaintenance.OnHoverBorderColor = System.Drawing.Color.White
        Me.btnMaintenance.OnHoverForeColor = System.Drawing.Color.White
        Me.btnMaintenance.OnHoverImage = Nothing
        Me.btnMaintenance.OnPressedColor = System.Drawing.Color.Black
        Me.btnMaintenance.Radius = 5
        Me.btnMaintenance.Size = New System.Drawing.Size(132, 25)
        Me.btnMaintenance.TabIndex = 2
        Me.btnMaintenance.Text = "Maintenance"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel9.Location = New System.Drawing.Point(0, 620)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1144, 32)
        Me.Panel9.TabIndex = 5
        '
        'Panel7
        '
        Me.Panel7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel7.BackColor = System.Drawing.Color.Transparent
        Me.Panel7.Controls.Add(Me.Panel6)
        Me.Panel7.Controls.Add(Me.Panel5)
        Me.Panel7.Location = New System.Drawing.Point(840, 7)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(272, 44)
        Me.Panel7.TabIndex = 10
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.btnMode)
        Me.Panel6.Location = New System.Drawing.Point(216, 5)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(43, 41)
        Me.Panel6.TabIndex = 11
        '
        'btnMode
        '
        Me.btnMode.CheckedState.Parent = Me.btnMode
        Me.btnMode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMode.HoverState.Image = Global.WindowsApp1.My.Resources.Resources.moon
        Me.btnMode.HoverState.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnMode.HoverState.Parent = Me.btnMode
        Me.btnMode.Image = Global.WindowsApp1.My.Resources.Resources.moon__1_
        Me.btnMode.Location = New System.Drawing.Point(7, 5)
        Me.btnMode.Name = "btnMode"
        Me.btnMode.PressedState.Parent = Me.btnMode
        Me.btnMode.Size = New System.Drawing.Size(30, 30)
        Me.btnMode.TabIndex = 7
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.lblUsername)
        Me.Panel5.Controls.Add(Me.btnUserIcon)
        Me.Panel5.Controls.Add(Me.btnDropDown)
        Me.Panel5.Location = New System.Drawing.Point(67, 5)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(139, 41)
        Me.Panel5.TabIndex = 11
        '
        'lblUsername
        '
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(31, 11)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(85, 20)
        Me.lblUsername.TabIndex = 4
        Me.lblUsername.Text = "Username"
        '
        'btnUserIcon
        '
        Me.btnUserIcon.CheckedState.Parent = Me.btnUserIcon
        Me.btnUserIcon.HoverState.ImageSize = New System.Drawing.Size(37, 37)
        Me.btnUserIcon.HoverState.Parent = Me.btnUserIcon
        Me.btnUserIcon.Image = Global.WindowsApp1.My.Resources.Resources.LOGOCOLOR2
        Me.btnUserIcon.ImageOffset = New System.Drawing.Point(0, -1)
        Me.btnUserIcon.ImageSize = New System.Drawing.Size(37, 37)
        Me.btnUserIcon.Location = New System.Drawing.Point(2, 6)
        Me.btnUserIcon.Name = "btnUserIcon"
        Me.btnUserIcon.PressedState.Parent = Me.btnUserIcon
        Me.btnUserIcon.Size = New System.Drawing.Size(30, 30)
        Me.btnUserIcon.TabIndex = 5
        '
        'btnDropDown
        '
        Me.btnDropDown.CheckedState.Parent = Me.btnDropDown
        Me.btnDropDown.HoverState.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnDropDown.HoverState.Parent = Me.btnDropDown
        Me.btnDropDown.Image = Global.WindowsApp1.My.Resources.Resources.down
        Me.btnDropDown.ImageSize = New System.Drawing.Size(10, 10)
        Me.btnDropDown.Location = New System.Drawing.Point(117, 17)
        Me.btnDropDown.Name = "btnDropDown"
        Me.btnDropDown.PressedState.Parent = Me.btnDropDown
        Me.btnDropDown.Size = New System.Drawing.Size(10, 10)
        Me.btnDropDown.TabIndex = 6
        '
        'palHeader
        '
        Me.palHeader.BackColor = System.Drawing.Color.Transparent
        Me.palHeader.Controls.Add(Me.Guna2Separator1)
        Me.palHeader.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.palHeader.Controls.Add(Me.Panel7)
        Me.palHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.palHeader.Location = New System.Drawing.Point(0, 35)
        Me.palHeader.Name = "palHeader"
        Me.palHeader.Size = New System.Drawing.Size(1144, 62)
        Me.palHeader.TabIndex = 13
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.FillColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.Guna2Separator1.Location = New System.Drawing.Point(-9, 55)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(1500, 10)
        Me.Guna2Separator1.TabIndex = 1
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Guna2CirclePictureBox2)
        Me.Panel2.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1144, 35)
        Me.Panel2.TabIndex = 14
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(Me.GunaControlBox3)
        Me.Panel3.Controls.Add(Me.GunaControlBox2)
        Me.Panel3.Controls.Add(Me.GunaControlBox1)
        Me.Panel3.Location = New System.Drawing.Point(1000, -1)
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
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Me.Panel2
        '
        'frmAgentDashboard
        '
        Me.AllowDrop = True
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1144, 749)
        Me.Controls.Add(Me.palMainFrame)
        Me.Controls.Add(Me.palHeader)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAgentDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.palMainFrame.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.palHeader.ResumeLayout(False)
        CType(Me.Guna2CirclePictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents palMainFrame As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnMode As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lblUsername As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnUserIcon As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents btnDropDown As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents palHeader As Panel
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2CirclePictureBox2 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GunaControlBox3 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaControlBox2 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaControlBox1 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnHome As Guna.UI.WinForms.GunaButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSetting As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnProperty As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnCustomerDetail As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnTransactionSale As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnMaintenance As Guna.UI.WinForms.GunaButton
    Friend WithEvents palMain As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents btnlogOut As Guna.UI2.WinForms.Guna2ImageButton
End Class
