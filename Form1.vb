

Imports System.IO
Imports Microsoft.Win32
Imports System.Drawing.Imaging

Public Class Form1
    Inherits System.Windows.Forms.Form


#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButtonEllipse As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents PrintToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents CopyToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButtonCapture As System.Windows.Forms.ToolStripButton
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents ToolStripButtonArrow As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonRectangle As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonHand As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonErase As System.Windows.Forms.ToolStripButton
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolStripButtonLine As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripComboBoxPenSize As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripButtonColorSelect As System.Windows.Forms.ToolStripButton
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents ToolStripButtonRectangleFill As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonEllipseFill As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonHighlighter As System.Windows.Forms.ToolStripButton
    Friend WithEvents RunAtStartupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButtonPen As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonUndo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonPaste As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonCrop As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonText As System.Windows.Forms.ToolStripButton
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripButtonSetFont As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents RegionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Tray_RegionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Tray_WindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CaptureToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripDropDownButtonDelay As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents SecondsToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SecondsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SecondsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SecondsToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemDelay_Tray As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SecondsToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SecondsToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SecondsToolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SecondsToolStripMenuItem7 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButtonBlur As System.Windows.Forms.ToolStripButton

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tray_RegionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tray_WindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemDelay_Tray = New System.Windows.Forms.ToolStripMenuItem()
        Me.SecondsToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SecondsToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SecondsToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SecondsToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RunAtStartupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CaptureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButtonCapture = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.RegionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripDropDownButtonDelay = New System.Windows.Forms.ToolStripDropDownButton()
        Me.SecondsToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SecondsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SecondsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SecondsToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PrintToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CopyToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonPaste = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonHand = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonCrop = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonErase = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonUndo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonPen = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonLine = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonArrow = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonEllipse = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonEllipseFill = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonRectangle = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonRectangleFill = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonBlur = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonText = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripComboBoxPenSize = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripButtonHighlighter = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonColorSelect = New System.Windows.Forms.ToolStripButton()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButtonSetFont = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Desktop Capture"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModeToolStripMenuItem, Me.ToolStripMenuItemDelay_Tray, Me.RunAtStartupToolStripMenuItem, Me.AboutToolStripMenuItem, Me.ExitToolStripMenuItem, Me.CaptureToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.ShowCheckMargin = True
        Me.ContextMenuStrip1.ShowImageMargin = False
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(152, 136)
        '
        'ModeToolStripMenuItem
        '
        Me.ModeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tray_RegionToolStripMenuItem, Me.Tray_WindowToolStripMenuItem})
        Me.ModeToolStripMenuItem.Name = "ModeToolStripMenuItem"
        Me.ModeToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.ModeToolStripMenuItem.Text = "&Mode"
        '
        'Tray_RegionToolStripMenuItem
        '
        Me.Tray_RegionToolStripMenuItem.Checked = True
        Me.Tray_RegionToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Tray_RegionToolStripMenuItem.Name = "Tray_RegionToolStripMenuItem"
        Me.Tray_RegionToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.Tray_RegionToolStripMenuItem.Text = "Re&gion"
        '
        'Tray_WindowToolStripMenuItem
        '
        Me.Tray_WindowToolStripMenuItem.Name = "Tray_WindowToolStripMenuItem"
        Me.Tray_WindowToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.Tray_WindowToolStripMenuItem.Text = "&Window"
        '
        'ToolStripMenuItemDelay_Tray
        '
        Me.ToolStripMenuItemDelay_Tray.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SecondsToolStripMenuItem4, Me.SecondsToolStripMenuItem5, Me.SecondsToolStripMenuItem6, Me.SecondsToolStripMenuItem7})
        Me.ToolStripMenuItemDelay_Tray.Name = "ToolStripMenuItemDelay_Tray"
        Me.ToolStripMenuItemDelay_Tray.Size = New System.Drawing.Size(151, 22)
        Me.ToolStripMenuItemDelay_Tray.Text = "&Delay"
        '
        'SecondsToolStripMenuItem4
        '
        Me.SecondsToolStripMenuItem4.Checked = True
        Me.SecondsToolStripMenuItem4.CheckState = System.Windows.Forms.CheckState.Checked
        Me.SecondsToolStripMenuItem4.Name = "SecondsToolStripMenuItem4"
        Me.SecondsToolStripMenuItem4.Size = New System.Drawing.Size(132, 22)
        Me.SecondsToolStripMenuItem4.Text = "0 seconds"
        '
        'SecondsToolStripMenuItem5
        '
        Me.SecondsToolStripMenuItem5.Name = "SecondsToolStripMenuItem5"
        Me.SecondsToolStripMenuItem5.Size = New System.Drawing.Size(132, 22)
        Me.SecondsToolStripMenuItem5.Text = "5 seconds"
        '
        'SecondsToolStripMenuItem6
        '
        Me.SecondsToolStripMenuItem6.Name = "SecondsToolStripMenuItem6"
        Me.SecondsToolStripMenuItem6.Size = New System.Drawing.Size(132, 22)
        Me.SecondsToolStripMenuItem6.Text = "10 seconds"
        '
        'SecondsToolStripMenuItem7
        '
        Me.SecondsToolStripMenuItem7.Name = "SecondsToolStripMenuItem7"
        Me.SecondsToolStripMenuItem7.Size = New System.Drawing.Size(132, 22)
        Me.SecondsToolStripMenuItem7.Text = "30 seconds"
        '
        'RunAtStartupToolStripMenuItem
        '
        Me.RunAtStartupToolStripMenuItem.CheckOnClick = True
        Me.RunAtStartupToolStripMenuItem.Name = "RunAtStartupToolStripMenuItem"
        Me.RunAtStartupToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.RunAtStartupToolStripMenuItem.Text = "&Run At Startup"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'CaptureToolStripMenuItem
        '
        Me.CaptureToolStripMenuItem.Name = "CaptureToolStripMenuItem"
        Me.CaptureToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.CaptureToolStripMenuItem.Text = "&Capture"
        Me.CaptureToolStripMenuItem.ToolTipText = "Capture (Ctrl+Shift+P)"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(692, 516)
        Me.Panel1.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Maroon
        Me.PictureBox1.Location = New System.Drawing.Point(3, 53)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(208, 155)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.DimGray
        Me.PictureBox2.Location = New System.Drawing.Point(268, 53)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(214, 155)
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonCapture, Me.ToolStripDropDownButton1, Me.ToolStripDropDownButtonDelay, Me.ToolStripSeparator2, Me.SaveToolStripButton, Me.PrintToolStripButton, Me.CopyToolStripButton, Me.ToolStripButtonPaste, Me.toolStripSeparator1, Me.ToolStripButtonHand, Me.ToolStripButtonCrop, Me.ToolStripButtonErase, Me.ToolStripButtonUndo, Me.ToolStripButtonPen, Me.ToolStripButtonLine, Me.ToolStripButtonArrow, Me.ToolStripButtonEllipse, Me.ToolStripButtonEllipseFill, Me.ToolStripButtonRectangle, Me.ToolStripButtonRectangleFill, Me.ToolStripButtonBlur, Me.ToolStripButtonText, Me.ToolStripComboBoxPenSize, Me.ToolStripButtonHighlighter, Me.ToolStripButtonColorSelect})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(692, 25)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButtonCapture
        '
        Me.ToolStripButtonCapture.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonCapture.Image = Global.DesktopCapture.My.Resources.Resources.red_circle
        Me.ToolStripButtonCapture.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonCapture.Name = "ToolStripButtonCapture"
        Me.ToolStripButtonCapture.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButtonCapture.Text = "Capture (Ctrl+Shift+P)"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegionToolStripMenuItem, Me.WindowToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(51, 22)
        Me.ToolStripDropDownButton1.Text = "Mode"
        '
        'RegionToolStripMenuItem
        '
        Me.RegionToolStripMenuItem.Checked = True
        Me.RegionToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.RegionToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.RegionToolStripMenuItem.Name = "RegionToolStripMenuItem"
        Me.RegionToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.RegionToolStripMenuItem.Text = "Region"
        '
        'WindowToolStripMenuItem
        '
        Me.WindowToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.WindowToolStripMenuItem.Name = "WindowToolStripMenuItem"
        Me.WindowToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.WindowToolStripMenuItem.Text = "Window"
        '
        'ToolStripDropDownButtonDelay
        '
        Me.ToolStripDropDownButtonDelay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButtonDelay.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SecondsToolStripMenuItem3, Me.SecondsToolStripMenuItem, Me.SecondsToolStripMenuItem1, Me.SecondsToolStripMenuItem2})
        Me.ToolStripDropDownButtonDelay.Image = CType(resources.GetObject("ToolStripDropDownButtonDelay.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButtonDelay.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButtonDelay.Name = "ToolStripDropDownButtonDelay"
        Me.ToolStripDropDownButtonDelay.Size = New System.Drawing.Size(49, 22)
        Me.ToolStripDropDownButtonDelay.Text = "Delay"
        Me.ToolStripDropDownButtonDelay.ToolTipText = "Timeout before taking snapshot"
        '
        'SecondsToolStripMenuItem3
        '
        Me.SecondsToolStripMenuItem3.Checked = True
        Me.SecondsToolStripMenuItem3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.SecondsToolStripMenuItem3.Name = "SecondsToolStripMenuItem3"
        Me.SecondsToolStripMenuItem3.Size = New System.Drawing.Size(132, 22)
        Me.SecondsToolStripMenuItem3.Text = "0 seconds"
        '
        'SecondsToolStripMenuItem
        '
        Me.SecondsToolStripMenuItem.Name = "SecondsToolStripMenuItem"
        Me.SecondsToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.SecondsToolStripMenuItem.Text = "5 seconds"
        '
        'SecondsToolStripMenuItem1
        '
        Me.SecondsToolStripMenuItem1.Name = "SecondsToolStripMenuItem1"
        Me.SecondsToolStripMenuItem1.Size = New System.Drawing.Size(132, 22)
        Me.SecondsToolStripMenuItem1.Text = "10 seconds"
        '
        'SecondsToolStripMenuItem2
        '
        Me.SecondsToolStripMenuItem2.Name = "SecondsToolStripMenuItem2"
        Me.SecondsToolStripMenuItem2.Size = New System.Drawing.Size(132, 22)
        Me.SecondsToolStripMenuItem2.Text = "30 seconds"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.SaveToolStripButton.Text = "&Save  (Ctrl+S)"
        '
        'PrintToolStripButton
        '
        Me.PrintToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PrintToolStripButton.Image = CType(resources.GetObject("PrintToolStripButton.Image"), System.Drawing.Image)
        Me.PrintToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintToolStripButton.Name = "PrintToolStripButton"
        Me.PrintToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.PrintToolStripButton.Text = "&Print  (Ctrl+P)"
        '
        'CopyToolStripButton
        '
        Me.CopyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CopyToolStripButton.Image = CType(resources.GetObject("CopyToolStripButton.Image"), System.Drawing.Image)
        Me.CopyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopyToolStripButton.Name = "CopyToolStripButton"
        Me.CopyToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.CopyToolStripButton.Text = "&Copy (Ctrl+C)"
        '
        'ToolStripButtonPaste
        '
        Me.ToolStripButtonPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonPaste.Image = Global.DesktopCapture.My.Resources.Resources.paste
        Me.ToolStripButtonPaste.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonPaste.Name = "ToolStripButtonPaste"
        Me.ToolStripButtonPaste.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButtonPaste.Text = "Paste (Ctrl+V)"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButtonHand
        '
        Me.ToolStripButtonHand.Checked = True
        Me.ToolStripButtonHand.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolStripButtonHand.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonHand.Image = Global.DesktopCapture.My.Resources.Resources.grab
        Me.ToolStripButtonHand.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonHand.Name = "ToolStripButtonHand"
        Me.ToolStripButtonHand.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButtonHand.Text = "Move"
        '
        'ToolStripButtonCrop
        '
        Me.ToolStripButtonCrop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonCrop.Image = Global.DesktopCapture.My.Resources.Resources.crop
        Me.ToolStripButtonCrop.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonCrop.Name = "ToolStripButtonCrop"
        Me.ToolStripButtonCrop.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButtonCrop.Text = "Crop"
        '
        'ToolStripButtonErase
        '
        Me.ToolStripButtonErase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonErase.Image = Global.DesktopCapture.My.Resources.Resources.eraser
        Me.ToolStripButtonErase.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonErase.Name = "ToolStripButtonErase"
        Me.ToolStripButtonErase.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButtonErase.Text = "Erase All (Ctrl+E)"
        '
        'ToolStripButtonUndo
        '
        Me.ToolStripButtonUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonUndo.Enabled = False
        Me.ToolStripButtonUndo.Image = Global.DesktopCapture.My.Resources.Resources.undo
        Me.ToolStripButtonUndo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonUndo.Name = "ToolStripButtonUndo"
        Me.ToolStripButtonUndo.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButtonUndo.Text = "Undo (Ctrl+Z)"
        '
        'ToolStripButtonPen
        '
        Me.ToolStripButtonPen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonPen.Image = Global.DesktopCapture.My.Resources.Resources.pen
        Me.ToolStripButtonPen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonPen.Name = "ToolStripButtonPen"
        Me.ToolStripButtonPen.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButtonPen.Text = "Draw Freehand"
        '
        'ToolStripButtonLine
        '
        Me.ToolStripButtonLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonLine.Image = Global.DesktopCapture.My.Resources.Resources.line
        Me.ToolStripButtonLine.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonLine.Name = "ToolStripButtonLine"
        Me.ToolStripButtonLine.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButtonLine.Text = "Draw Line"
        '
        'ToolStripButtonArrow
        '
        Me.ToolStripButtonArrow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonArrow.Image = Global.DesktopCapture.My.Resources.Resources.arrow
        Me.ToolStripButtonArrow.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonArrow.Name = "ToolStripButtonArrow"
        Me.ToolStripButtonArrow.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButtonArrow.Text = "Draw Arrow"
        '
        'ToolStripButtonEllipse
        '
        Me.ToolStripButtonEllipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonEllipse.Image = CType(resources.GetObject("ToolStripButtonEllipse.Image"), System.Drawing.Image)
        Me.ToolStripButtonEllipse.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonEllipse.Name = "ToolStripButtonEllipse"
        Me.ToolStripButtonEllipse.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButtonEllipse.Text = "Draw Ellipse"
        '
        'ToolStripButtonEllipseFill
        '
        Me.ToolStripButtonEllipseFill.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonEllipseFill.Image = CType(resources.GetObject("ToolStripButtonEllipseFill.Image"), System.Drawing.Image)
        Me.ToolStripButtonEllipseFill.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonEllipseFill.Name = "ToolStripButtonEllipseFill"
        Me.ToolStripButtonEllipseFill.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButtonEllipseFill.Text = "Draw Ellipse Filled"
        '
        'ToolStripButtonRectangle
        '
        Me.ToolStripButtonRectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonRectangle.Image = Global.DesktopCapture.My.Resources.Resources.rectangle
        Me.ToolStripButtonRectangle.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonRectangle.Name = "ToolStripButtonRectangle"
        Me.ToolStripButtonRectangle.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButtonRectangle.Text = "Draw Rectangle"
        '
        'ToolStripButtonRectangleFill
        '
        Me.ToolStripButtonRectangleFill.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonRectangleFill.Image = Global.DesktopCapture.My.Resources.Resources.rectangle_filled
        Me.ToolStripButtonRectangleFill.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonRectangleFill.Name = "ToolStripButtonRectangleFill"
        Me.ToolStripButtonRectangleFill.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButtonRectangleFill.Text = "Draw Rectangle Filled"
        '
        'ToolStripButtonBlur
        '
        Me.ToolStripButtonBlur.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonBlur.Image = Global.DesktopCapture.My.Resources.Resources.blur
        Me.ToolStripButtonBlur.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonBlur.Name = "ToolStripButtonBlur"
        Me.ToolStripButtonBlur.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButtonBlur.Text = "Blur"
        '
        'ToolStripButtonText
        '
        Me.ToolStripButtonText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonText.Image = Global.DesktopCapture.My.Resources.Resources.DrawText
        Me.ToolStripButtonText.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonText.Name = "ToolStripButtonText"
        Me.ToolStripButtonText.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButtonText.Text = "Draw Text"
        '
        'ToolStripComboBoxPenSize
        '
        Me.ToolStripComboBoxPenSize.AutoSize = False
        Me.ToolStripComboBoxPenSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ToolStripComboBoxPenSize.DropDownWidth = 15
        Me.ToolStripComboBoxPenSize.Items.AddRange(New Object() {"5", "4", "3", "2", "1"})
        Me.ToolStripComboBoxPenSize.Name = "ToolStripComboBoxPenSize"
        Me.ToolStripComboBoxPenSize.Size = New System.Drawing.Size(40, 23)
        Me.ToolStripComboBoxPenSize.ToolTipText = "Line Width"
        '
        'ToolStripButtonHighlighter
        '
        Me.ToolStripButtonHighlighter.CheckOnClick = True
        Me.ToolStripButtonHighlighter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonHighlighter.Image = Global.DesktopCapture.My.Resources.Resources.highlighter
        Me.ToolStripButtonHighlighter.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonHighlighter.Name = "ToolStripButtonHighlighter"
        Me.ToolStripButtonHighlighter.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButtonHighlighter.Text = "Highlight Mode"
        '
        'ToolStripButtonColorSelect
        '
        Me.ToolStripButtonColorSelect.BackColor = System.Drawing.Color.Red
        Me.ToolStripButtonColorSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonColorSelect.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonColorSelect.Name = "ToolStripButtonColorSelect"
        Me.ToolStripButtonColorSelect.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButtonColorSelect.Text = "Color Select"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(300, 25)
        Me.ToolStripTextBox1.Text = "Set text..."
        '
        'ToolStripButtonSetFont
        '
        Me.ToolStripButtonSetFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButtonSetFont.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonSetFont.Name = "ToolStripButtonSetFont"
        Me.ToolStripButtonSetFont.Size = New System.Drawing.Size(54, 22)
        Me.ToolStripButtonSetFont.Text = "Set Font"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Enabled = False
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripTextBox1, Me.ToolStripButtonSetFont})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 25)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip2.Size = New System.Drawing.Size(692, 25)
        Me.ToolStrip2.TabIndex = 5
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(61, 22)
        Me.ToolStripLabel1.Text = "Enter Text:"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(692, 516)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(700, 550)
        Me.Name = "Form1"
        Me.Text = "Desktop Capture"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private mousePath As Drawing2D.GraphicsPath

    Private Const MOD_CONTROL As Integer = &H2 'Control key
    Private Const MOD_SHIFT As Integer = &H4 'Shift key
    Private Const WM_HOTKEY As Integer = &H312

    Private boolStartup As Boolean = False
    Private boolDrawing As Boolean
    Private rect As Rectangle

    Private StartPoint As New Point
    Private LastPoint As New PointF

    Private triangleCap As New Drawing2D.AdjustableArrowCap(3, 2, True)
    Private penCustom As Pen = New Pen(Color.Red)
    Private brushCustom As SolidBrush = New SolidBrush(Color.Red)

    Private cropPen As Pen = New Pen(Color.Black, 1)

    Private ms As New System.IO.MemoryStream(My.Resources.grab_cur)
    Private CursorGrab As Cursor = New Cursor(ms)
    Private ms2 As New System.IO.MemoryStream(My.Resources.grabbing_cur)
    Private CursorGrabbing As Cursor = New Cursor(ms2)

    Private CurrentColor As Color = Color.Red

    Private LastBitmap As Bitmap
    Private UndoBitmaps(0) As Bitmap

    Private m_BufferBitmap As Bitmap
    Private m_BufferGraphics As Graphics

    Private boolTrayExit As Boolean = False


    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        If m.Msg = WM_HOTKEY Then TakeSnapshot()
        MyBase.WndProc(m) 'Never Forget This
    End Sub


    Private Declare Function RegisterHotKey Lib "user32" (ByVal hwnd As IntPtr, ByVal id As Integer, ByVal fsModifiers As Integer, ByVal vk As Integer) As Integer

    Private Declare Function UnregisterHotKey Lib "user32" (ByVal hwnd As IntPtr, ByVal id As Integer) As Integer

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Dim ret As Integer = MsgBox("Are you sure you want to exit?" & vbCrLf & vbCrLf & _
        '                            "(Click No to minimize to the Notification area)", _
        '                            MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Exit " & Application.ProductName & "?")
        If boolTrayExit = False Then
            'If ret <> vbYes Then
            e.Cancel = True
            Me.WindowState = FormWindowState.Minimized
        End If
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.Modifiers = Keys.Control Then
            Select Case e.KeyCode
                Case Keys.Z
                    Undo()
                Case Keys.S
                    SaveImage()
                Case Keys.P
                    PrintImage()
                Case Keys.C
                    CopyImage()
                Case Keys.R
                    TakeSnapshot()
                Case Keys.E
                    EraseMarkups()
                Case Keys.V
                    PasteImage()
            End Select
        End If
    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim intX As Integer = 0
        Dim intY As Integer = 0

        For Each scrn As Screen In Screen.AllScreens
            If scrn.Bounds.X < intX Then intX = scrn.Bounds.X
            If scrn.Bounds.Y < intY Then intY = scrn.Bounds.Y
        Next

        If intX < 0 Or intY < 0 Then
            If intY < 0 Then
                MsgBox("Vertical monitor orientation not supported.", MsgBoxStyle.Exclamation, Application.ProductName)
            Else
                MsgBox("Monitor orientation mode not supported." & vbCrLf & vbCrLf & "Left monitor must be set to Primary for this application to function.", MsgBoxStyle.Exclamation, Application.ProductName)
            End If

            boolTrayExit = True
            Application.Exit()
        End If



        cropPen.DashStyle = Drawing2D.DashStyle.Dash
        ToolStripComboBoxPenSize.SelectedIndex = 3
        RegisterHotKey(Me.Handle, 9, MOD_CONTROL + MOD_SHIFT, Keys.P) 'Ctrl + Shift + P
        CheckForStartup()
        ToolStripButtonSetFont.Text = FontDialog1.Font.FontFamily.Name & " " & FontDialog1.Font.SizeInPoints & "PT " & FontDialog1.Font.Style.ToString
    End Sub

    Private Sub CheckForStartup()
        On Error Resume Next

        Dim regKey As RegistryKey
        regKey = Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Run", True)

        Dim appRegKey As RegistryKey
        appRegKey = Registry.CurrentUser.OpenSubKey("Software\" & Application.ProductName, True)

        If IsNothing(appRegKey) Then
            'Create the key
            Registry.CurrentUser.CreateSubKey("Software\" & Application.ProductName)
            appRegKey = Registry.CurrentUser.OpenSubKey("Software\" & Application.ProductName, True)
            If IsNothing(appRegKey) Then
                regKey.Close()
                Exit Sub
            End If

            'Ask user if they want it to launch auto...
            If MsgBox("Launch " & Application.ProductName & " at Startup?",
                            MsgBoxStyle.Question + MsgBoxStyle.YesNo,
                            Application.ProductName) = MsgBoxResult.Yes Then
                boolStartup = True
            Else
                boolStartup = False
            End If

        Else
            'Get Current Value and set it in the interface
            boolStartup = appRegKey.GetValue("RunAtStartup", False)
        End If

        regKey.Close()
        appRegKey.Close()

        SaveRegistrySettings()

    End Sub

    Private Sub SaveRegistrySettings()
        On Error Resume Next

        Dim regKey As RegistryKey
        regKey = Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Run", True)

        Dim appRegKey As RegistryKey
        appRegKey = Registry.CurrentUser.OpenSubKey("Software\" & Application.ProductName, True)

        'Save the response
        appRegKey.SetValue("RunAtStartup", boolStartup, RegistryValueKind.DWord)

        'If boolStartup=true, set to run at startup
        If boolStartup = True Then
            regKey.SetValue(Application.ProductName, Application.ExecutablePath)
        Else
            regKey.DeleteValue(Application.ProductName)
        End If

        RunAtStartupToolStripMenuItem.Checked = boolStartup

        regKey.Close()
        appRegKey.Close()

    End Sub



    Private Sub TakeSnapshot()
        If Me.Visible Then Me.Hide()
        If WindowToolStripMenuItem.CheckState = CheckState.Checked Then
            FormWindowGrab.Show()
            FormWindowGrab.Activate()
        Else
            FormRegionGrab.Show()
            FormRegionGrab.Activate()
        End If

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TakeSnapshot()
    End Sub

    Private Sub NotifyIcon1_BalloonTipClicked(ByVal sender As Object, ByVal e As System.EventArgs) Handles NotifyIcon1.BalloonTipClicked
        ShowMe()
    End Sub

    Private Sub ShowMe()
        Me.Show()
        Me.WindowState = FormWindowState.Normal
        Me.Activate()
    End Sub

    Private Sub NotifyIcon1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseClick
        If e.Button = MouseButtons.Right Then
            'NotifyIcon1.ContextMenu = ContextMenuIcon
        End If
        If e.Button = MouseButtons.Left Then
            ShowMe()
        End If

    End Sub

    Private Sub Form1_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Move

        If Me.WindowState = FormWindowState.Minimized Then
            NotifyIcon1.ShowBalloonTip(600, Application.ProductName, """Ctrl+Shift+P"" to activate", ToolTipIcon.Info)
            Me.Hide()
        Else
            Me.Show()
        End If
    End Sub


    Private Sub Form1_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        If Me.WindowState = FormWindowState.Minimized Then Me.Hide()
    End Sub




    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        boolTrayExit = True
        Application.Exit()
    End Sub



    Private Sub CloneBitmap()
        Try
            LastBitmap = PictureBox1.Image.Clone
            ReDim Preserve UndoBitmaps(UBound(UndoBitmaps) + 1)
            UndoBitmaps(UBound(UndoBitmaps)) = PictureBox1.Image.Clone
            ToolStripButtonUndo.Enabled = True
        Catch ex As Exception
            'Do Nothing
        End Try

    End Sub


    Private Sub SaveSnapshot()

        Dim new_bitmap As Bitmap

        ' Make a new bitmap that fits the PictureBox1.
        new_bitmap = New Bitmap(PictureBox1.Image.Width, PictureBox1.Image.Height,
            PictureBox1.CreateGraphics())

        m_BufferGraphics = Graphics.FromImage(new_bitmap)

        ' Clear the new bitmap.
        m_BufferGraphics.Clear(Me.BackColor)

        ' Copy the existing bitmap's contents into
        ' the new bitmap.
        If Not (m_BufferBitmap Is Nothing) Then
            m_BufferGraphics.DrawImage(m_BufferBitmap, 0, 0)
        End If

        ' Save the new bitmap and graphics objects.
        m_BufferBitmap = PictureBox1.Image
    End Sub

    Private Sub PictureBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        On Error Resume Next

        If e.Button <> Windows.Forms.MouseButtons.Left Then Exit Sub

        'Capture the initial point 
        StartPoint = New Point(e.Location)
        LastPoint = New Point(e.Location)
        mousePath = New Drawing2D.GraphicsPath
        mousePath.AddLine(e.Location, e.Location)

        'Save snapshot
        SaveSnapshot()

        If ToolStripButtonHand.Checked = False Then
            SetColors()

            If IsNothing(PictureBox1.Image) Then Exit Sub
            boolDrawing = True

            CloneBitmap()

            'Set pen width
            penCustom.Width = ToolStripComboBoxPenSize.SelectedItem * 3


            If ToolStripButtonPen.Checked Then
                penCustom.EndCap = Drawing2D.LineCap.Round
                penCustom.StartCap = Drawing2D.LineCap.Round
            ElseIf ToolStripButtonArrow.Checked Then
                penCustom.CustomEndCap = triangleCap
                penCustom.StartCap = Drawing2D.LineCap.NoAnchor
            Else
                penCustom.StartCap = Drawing2D.LineCap.NoAnchor
                penCustom.EndCap = Drawing2D.LineCap.NoAnchor
            End If

        Else
            Cursor = CursorGrabbing
        End If

    End Sub

    Private Sub PictureBox1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseEnter
        If ToolStripButtonHand.Checked Then
            Cursor = CursorGrab
        Else
            Cursor = Cursors.Cross
        End If

        If ToolStripButtonText.Checked Then
            SaveSnapshot()
        End If

    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        Cursor = Cursors.Arrow
    End Sub

    ' Redraw the saved buffer.
    Private Sub DrawForm(ByVal gr As Graphics)
        If Not (m_BufferBitmap Is Nothing) Then _
            gr.DrawImage(m_BufferBitmap, 0, 0)
    End Sub
    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As _
    System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        DrawForm(e.Graphics)
    End Sub
    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove

        Dim DeltaX As Integer = (StartPoint.X - e.X)
        Dim DeltaY As Integer = (StartPoint.Y - e.Y)


        Dim X_Pos As Integer
        If e.X < StartPoint.X Then
            X_Pos = e.X
        Else
            X_Pos = StartPoint.X
        End If
        Dim Y_Pos As Integer
        If e.Y < StartPoint.Y Then
            Y_Pos = e.Y
        Else
            Y_Pos = StartPoint.Y
        End If

        rect = New Rectangle(X_Pos, Y_Pos, Math.Abs(DeltaX), Math.Abs(DeltaY))

        'If boolDrawing = True Or ToolStripButtonText.Checked Then
        If boolDrawing = True Then

            'Erase previous
            DrawForm(PictureBox1.CreateGraphics)

            'If IsNothing(PictureBox1.Image) Then Exit Sub
            'If IsNothing(LastBitmap) Then CloneBitmap()

            'Dim img As Image = PictureBox1.Image
            Dim img As Image = m_BufferBitmap.Clone
            Dim g As Graphics = Graphics.FromImage(img)
            g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias


            'g.DrawImage(LastBitmap, 0, 0)


            If ToolStripButtonPen.Checked Then
                mousePath.AddLine(LastPoint, e.Location)

                If IsNothing(mousePath.GetLastPoint) Then
                    LastPoint = e.Location
                Else
                    LastPoint = mousePath.GetLastPoint
                End If

                g.DrawPath(penCustom, mousePath)
                'PictureBox1.CreateGraphics.DrawPath(penCustom, mousePath)

            ElseIf ToolStripButtonArrow.Checked Then
                g.DrawLine(penCustom, StartPoint.X, StartPoint.Y, e.X, e.Y)
                'PictureBox1.CreateGraphics.DrawLine(penCustom, StartPoint.X, StartPoint.Y, e.X, e.Y)
            ElseIf ToolStripButtonLine.Checked Then
                penCustom.EndCap = Drawing2D.LineCap.NoAnchor
                g.DrawLine(penCustom, StartPoint.X, StartPoint.Y, e.X, e.Y)
                'PictureBox1.CreateGraphics.DrawLine(penCustom, StartPoint.X, StartPoint.Y, e.X, e.Y)
            ElseIf ToolStripButtonEllipse.Checked Or ToolStripButtonEllipseFill.Checked Then
                If ToolStripButtonEllipseFill.Checked Then
                    g.FillEllipse(brushCustom, rect)
                    'PictureBox1.CreateGraphics.FillEllipse(brushCustom, rect)
                Else
                    g.DrawEllipse(penCustom, rect)
                    'PictureBox1.CreateGraphics.DrawEllipse(penCustom, rect)
                End If
            ElseIf ToolStripButtonRectangle.Checked Or ToolStripButtonRectangleFill.Checked Or ToolStripButtonBlur.Checked Then
                If ToolStripButtonRectangleFill.Checked Then
                    g.FillRectangle(brushCustom, rect)
                    'PictureBox1.CreateGraphics.FillRectangle(brushCustom, rect)
                ElseIf ToolStripButtonBlur.Checked Then
                    'Testing BLUR
                    Dim BlurForce As Integer = 2
                    'declare an ImageAttributes to use it when drawing
                    Dim att As New ImageAttributes
                    'declare a ColorMatrix
                    Dim m As New ColorMatrix
                    ' set Matrix33 to 0.5, which represents the opacity. so the drawing will be semi-trasparent.
                    m.Matrix33 = 0.5F
                    'Setting this ColorMatrix to the ImageAttributes.
                    att.SetColorMatrix(m)
                    'drawing the image on it self, but not in the same coordinates, in a way that every pixel will be drawn on the pixels arround it.
                    For x As Integer = -BlurForce To BlurForce
                        For y As Integer = -BlurForce To BlurForce
                            'Drawing image on it self using out ImageAttributes to draw it semi-transparent.
                            g.DrawImage(img, New Rectangle(x + rect.Left, y + rect.Top, rect.Width, rect.Height), rect.Left, rect.Top, rect.Width, rect.Height, GraphicsUnit.Pixel, att)
                        Next
                    Next
                    'disposing ImageAttributes and Graphics. the effect is then applied. 
                    att.Dispose()
                Else
                    g.DrawRectangle(penCustom, rect)
                    'PictureBox1.CreateGraphics.DrawRectangle(penCustom, rect)
                End If
            ElseIf ToolStripButtonText.Checked Then
                Dim strText As String = ToolStripTextBox1.Text
                If strText = "" Then
                    ToolStripTextBox1.Text = "Set text..."
                    ToolStripTextBox1.Focus()
                End If
                If e.Button = Windows.Forms.MouseButtons.Left Then
                    g.DrawString(strText, FontDialog1.Font, brushCustom, e.X, e.Y)
                    'PictureBox1.CreateGraphics.DrawString(strText, FontDialog1.Font, brushCustom, e.X, e.Y)
                    'boolDrawing = False
                End If

            ElseIf ToolStripButtonCrop.Checked Then
                g.DrawRectangle(cropPen, rect)
                'PictureBox1.CreateGraphics.DrawRectangle(cropPen, rect)
            End If

            PictureBox1.Image = img



            g.Dispose()
        Else
            If e.Button = Windows.Forms.MouseButtons.Left Then
                Panel1.AutoScrollPosition =
                    New Drawing.Point((DeltaX - Panel1.AutoScrollPosition.X),
                    (DeltaY - Panel1.AutoScrollPosition.Y))
            End If
        End If
    End Sub



    Private Sub PictureBox1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseUp
        If boolDrawing = True Then

            mousePath.Dispose()

            boolDrawing = False

            If ToolStripButtonCrop.Checked Then
                PictureBox1.Image = CropBitmap(PictureBox1.Image, rect.X + 1, rect.Y + 1, rect.Width - 1, rect.Height - 1)
                PictureBox1.Width = PictureBox1.Image.Width
                PictureBox1.Height = PictureBox1.Image.Height
            End If
        Else
            Cursor = CursorGrab
        End If
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonCapture.Click
        TakeSnapshot()
    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        SaveImage()
    End Sub

    Private Sub CopyToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripButton.Click
        CopyImage()
    End Sub


    Private Sub PrintToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripButton.Click
        PrintImage()
    End Sub

    Private Sub SaveImage()
        Try
            If IsNothing(PictureBox1.Image) Then Exit Sub

            Dim arrFilters() As String = {"JPEG (*.jpg)|*.jpg",
                                "PNG (*.png)|*.png",
                                "GIF (*.gif)|*.gif",
                                "TIFF (*.tiff)|*.tiff",
                                "Bitmap (*.bmp)|*.bmp"}

            Dim strFilters As String = Join(arrFilters, "|")

            Dim arrFormats As Imaging.ImageFormat() = {Imaging.ImageFormat.Jpeg,
                                                        Imaging.ImageFormat.Png,
                                                        Imaging.ImageFormat.Gif,
                                                        Imaging.ImageFormat.Tiff,
                                                        Imaging.ImageFormat.Bmp}

            SaveFileDialog1.Filter = strFilters

            SaveFileDialog1.ShowDialog()
            Dim strFilename As String = SaveFileDialog1.FileName
            If strFilename = "" Then Exit Sub

            Dim imgFormat As Imaging.ImageFormat = arrFormats(SaveFileDialog1.FilterIndex - 1)

            PictureBox1.Image.Save(strFilename, imgFormat)
        Catch ex As Exception
            'Do nothing
        End Try
    End Sub

    Private Sub CopyImage()
        Try
            If IsNothing(PictureBox1.Image) Then Exit Sub

            System.Windows.Forms.Clipboard.Clear()
            Clipboard.SetImage(PictureBox1.Image)

            If Clipboard.ContainsImage Then
                NotifyIcon1.ShowBalloonTip(5000, "Image copied to clipboard.",
                "Width:" & vbTab & PictureBox1.Image.Width & vbCrLf & "Height:" & vbTab & PictureBox1.Image.Height, ToolTipIcon.Info)
            End If
        Catch ex As Exception
            'Do Nothing
        End Try

    End Sub



    Private Sub PrintImage()
        Try
            If IsNothing(PictureBox1.Image) Then Exit Sub
            If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
                PrintDocument1.Print()
            End If
        Catch ex As Exception
            'Do nothing
        End Try

    End Sub


    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(PictureBox1.Image, 0, 0)
    End Sub

    Private Sub HelpToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AboutBox1.Show()
    End Sub



    Private Sub ToolStripButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripButtonArrow.Click, ToolStripButtonEllipse.Click, ToolStripButtonEllipseFill.Click, ToolStripButtonRectangle.Click, ToolStripButtonRectangleFill.Click, ToolStripButtonLine.Click, ToolStripButtonHand.Click, ToolStripButtonPen.Click, ToolStripButtonCrop.Click, ToolStripButtonText.Click, ToolStripButtonBlur.Click
        For Each item As ToolStripItem In Me.ToolStrip1.Items
            If TypeOf item Is ToolStripButton Then
                If InStr(item.Name, "Highlight") = False Then
                    'Check the sender and uncheck every other button.
                    DirectCast(item, ToolStripButton).Checked = (item Is sender)
                End If
            End If
        Next
        If ToolStripButtonText.Checked Then

            boolDrawing = True
            ToolStrip2.Enabled = True
            ToolStripTextBox1.Focus()
        Else
            ToolStrip2.Enabled = False
        End If

    End Sub

    Private Sub ToolStripButtonReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonErase.Click
        EraseMarkups()
    End Sub

    Private Sub EraseMarkups()
        Try
            If IsNothing(PictureBox1.Image) Then Exit Sub
            If MsgBox("Erase all markups?" & vbCrLf & vbCrLf & "This action cannot be undone.", MsgBoxStyle.YesNo + MsgBoxStyle.Question, Application.ProductName) = MsgBoxResult.Yes Then
                PictureBox1.Image = PictureBox2.Image.Clone
                PictureBox1.Width = PictureBox2.Image.Width
                PictureBox1.Height = PictureBox2.Image.Height

                ReDim UndoBitmaps(0)
                ToolStripButtonUndo.Enabled = False
            End If
        Catch ex As Exception
            'Do nothing
        End Try

    End Sub


    Private Sub ToolStripButtonColorSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonColorSelect.Click
        If ColorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            CurrentColor = ColorDialog1.Color
            ToolStripButtonColorSelect.BackColor = CurrentColor
            SetColors()
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub

    Private Sub SetColors()
        Dim tmpColor As Color
        If ToolStripButtonHighlighter.Checked Then
            tmpColor = Color.FromArgb(127, CurrentColor)
        Else
            tmpColor = CurrentColor
        End If

        penCustom.Color = tmpColor
        brushCustom.Color = tmpColor
    End Sub

    Private Sub RunAtStartupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RunAtStartupToolStripMenuItem.Click
        boolStartup = RunAtStartupToolStripMenuItem.Checked
        SaveRegistrySettings()
    End Sub



    Private Sub ToolStripButtonUndo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonUndo.Click
        Undo()
    End Sub

    Private Sub Undo()
        Try
            If UBound(UndoBitmaps) >= 1 Then
                PictureBox1.Image = UndoBitmaps(UBound(UndoBitmaps))
                PictureBox1.Width = UndoBitmaps(UBound(UndoBitmaps)).Width
                PictureBox1.Height = UndoBitmaps(UBound(UndoBitmaps)).Height
                ReDim Preserve UndoBitmaps(UBound(UndoBitmaps) - 1)
                LastBitmap = UndoBitmaps(UBound(UndoBitmaps))
            End If

        Catch ex As Exception
            'Do Nothing
        End Try

        If UBound(UndoBitmaps) < 1 Then ToolStripButtonUndo.Enabled = False
    End Sub

    Private Sub ToolStripButtonPaste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonPaste.Click
        PasteImage()
    End Sub
    Private Sub PasteImage()
        If Clipboard.ContainsImage Then
            If MsgBox("Paste image from clipboard?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Application.ProductName) = MsgBoxResult.Yes Then
                Try
                    Dim clipbmp As Image = Clipboard.GetImage
                    PictureBox1.Width = clipbmp.Width
                    PictureBox1.Height = clipbmp.Height
                    PictureBox1.Visible = True
                    PictureBox1.Image = clipbmp

                    PictureBox2.Width = clipbmp.Width
                    PictureBox2.Height = clipbmp.Height
                    PictureBox2.Image = clipbmp

                    ReDim UndoBitmaps(0)
                    ToolStripButtonUndo.Enabled = False
                Catch ex As Exception
                    MsgBox("Unable to get clipboard image.", MsgBoxStyle.Exclamation, Application.ProductName)
                End Try
            End If
        Else
            MsgBox("There is no image on the clipboard.", MsgBoxStyle.Information, Application.ProductName)
        End If
    End Sub


    Private Function CropBitmap(ByRef bmp As Bitmap, ByVal cropX As Integer, ByVal cropY As Integer, ByVal cropWidth As Integer, ByVal cropHeight As Integer) As Bitmap
        If cropX < 0 Then
            cropWidth = cropWidth + cropX
            cropX = 0
        End If
        If cropX + cropWidth > PictureBox1.Width Then
            cropWidth = PictureBox1.Width - cropX
        End If

        If cropY < 0 Then
            cropHeight = cropHeight + cropY
            cropY = 0
        End If
        If cropY + cropHeight > PictureBox1.Height Then
            cropHeight = PictureBox1.Height - cropY
        End If

        Dim rectCropped As New Rectangle(cropX, cropY, cropWidth, cropHeight)
        Dim cropped As Bitmap = bmp.Clone(rectCropped, bmp.PixelFormat)
        Return cropped
    End Function




    Private Sub ToolStripButtonSetFont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonSetFont.Click
        If FontDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            ToolStripButtonSetFont.Text = FontDialog1.Font.FontFamily.Name & " " & FontDialog1.Font.SizeInPoints & "PT " & FontDialog1.Font.Style.ToString
        End If
    End Sub

    Private Sub PictureBox1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PictureBox1.Paint

    End Sub



    Private Sub ToolStripDropDownButton1_DropDownItemClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStripDropDownButton1.DropDownItemClicked
        If e.ClickedItem.Name.ToLower.Contains("region") Then
            RegionToolStripMenuItem.CheckState = CheckState.Checked
            Tray_RegionToolStripMenuItem.CheckState = CheckState.Checked

            WindowToolStripMenuItem.CheckState = CheckState.Unchecked
            Tray_WindowToolStripMenuItem.CheckState = CheckState.Unchecked
        Else
            RegionToolStripMenuItem.CheckState = CheckState.Unchecked
            Tray_RegionToolStripMenuItem.CheckState = CheckState.Unchecked

            WindowToolStripMenuItem.CheckState = CheckState.Checked
            Tray_WindowToolStripMenuItem.CheckState = CheckState.Checked
        End If
    End Sub

    Private Sub ModeToolStripMenuItem_DropDownItemClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ModeToolStripMenuItem.DropDownItemClicked
        If e.ClickedItem.Name.ToLower.Contains("region") Then
            RegionToolStripMenuItem.CheckState = CheckState.Checked
            Tray_RegionToolStripMenuItem.CheckState = CheckState.Checked

            WindowToolStripMenuItem.CheckState = CheckState.Unchecked
            Tray_WindowToolStripMenuItem.CheckState = CheckState.Unchecked
        Else
            RegionToolStripMenuItem.CheckState = CheckState.Unchecked
            Tray_RegionToolStripMenuItem.CheckState = CheckState.Unchecked

            WindowToolStripMenuItem.CheckState = CheckState.Checked
            Tray_WindowToolStripMenuItem.CheckState = CheckState.Checked
        End If
    End Sub

    Private Sub CaptureToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CaptureToolStripMenuItem.Click
        TakeSnapshot()
    End Sub

    Private Sub Delay_DropDownItemClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStripDropDownButtonDelay.DropDownItemClicked, ToolStripMenuItemDelay_Tray.DropDownItemClicked
        'form menu
        For Each itm As ToolStripMenuItem In ToolStripDropDownButtonDelay.DropDownItems
            If itm.Text = e.ClickedItem.Text Then
                itm.CheckState = CheckState.Checked
            Else
                itm.CheckState = CheckState.Unchecked
            End If
        Next

        'Tray menu
        For Each itm As ToolStripMenuItem In ToolStripMenuItemDelay_Tray.DropDownItems
            If itm.Text = e.ClickedItem.Text Then
                itm.CheckState = CheckState.Checked
            Else
                itm.CheckState = CheckState.Unchecked
            End If
        Next
    End Sub


    Public Sub DoDelay()
        Dim intDelay As Integer = 0
        For Each itm As ToolStripMenuItem In ToolStripDropDownButtonDelay.DropDownItems
            If itm.CheckState = CheckState.Checked Then
                intDelay = Integer.Parse(itm.Text.Replace(" seconds", ""))
            End If
        Next

        If intDelay > 0 Then
            System.Threading.Thread.Sleep(intDelay * 1000)
        End If
    End Sub


End Class
