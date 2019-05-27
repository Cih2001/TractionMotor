<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.mnuPopupMotor = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AngleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncoderPulseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.LinearSpeedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KMHToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualTorqueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AngularSpeedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripSeparator()
        Me.FeedbackDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TotalErrorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatusBar1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tlsMonitor = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConnectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisconnectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResultWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WheelPreviewWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TurnRightToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TurnLeftToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.SelectedMotorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripComboBox1 = New System.Windows.Forms.ToolStripComboBox()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConnctionPrefrencesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.imgList16 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.mnuPopupMotor.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.tlsMonitor.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'mnuPopupMotor
        '
        Me.mnuPopupMotor.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AngleToolStripMenuItem, Me.EncoderPulseToolStripMenuItem, Me.ToolStripMenuItem1, Me.LinearSpeedToolStripMenuItem, Me.ActualTorqueToolStripMenuItem, Me.AngularSpeedToolStripMenuItem, Me.ToolStripMenuItem6, Me.FeedbackDataToolStripMenuItem, Me.TotalErrorsToolStripMenuItem})
        Me.mnuPopupMotor.Name = "mnuPopupMotor"
        Me.mnuPopupMotor.Size = New System.Drawing.Size(188, 184)
        '
        'AngleToolStripMenuItem
        '
        Me.AngleToolStripMenuItem.Name = "AngleToolStripMenuItem"
        Me.AngleToolStripMenuItem.Size = New System.Drawing.Size(187, 24)
        Me.AngleToolStripMenuItem.Tag = "0"
        Me.AngleToolStripMenuItem.Text = "Angle"
        '
        'EncoderPulseToolStripMenuItem
        '
        Me.EncoderPulseToolStripMenuItem.Name = "EncoderPulseToolStripMenuItem"
        Me.EncoderPulseToolStripMenuItem.Size = New System.Drawing.Size(187, 24)
        Me.EncoderPulseToolStripMenuItem.Tag = "5"
        Me.EncoderPulseToolStripMenuItem.Text = "Encoder Pulse"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(184, 6)
        '
        'LinearSpeedToolStripMenuItem
        '
        Me.LinearSpeedToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MSToolStripMenuItem, Me.KMHToolStripMenuItem})
        Me.LinearSpeedToolStripMenuItem.Name = "LinearSpeedToolStripMenuItem"
        Me.LinearSpeedToolStripMenuItem.Size = New System.Drawing.Size(187, 24)
        Me.LinearSpeedToolStripMenuItem.Tag = ""
        Me.LinearSpeedToolStripMenuItem.Text = "Linear Speed"
        '
        'MSToolStripMenuItem
        '
        Me.MSToolStripMenuItem.Name = "MSToolStripMenuItem"
        Me.MSToolStripMenuItem.Size = New System.Drawing.Size(117, 24)
        Me.MSToolStripMenuItem.Tag = "1"
        Me.MSToolStripMenuItem.Text = "M/S"
        '
        'KMHToolStripMenuItem
        '
        Me.KMHToolStripMenuItem.Name = "KMHToolStripMenuItem"
        Me.KMHToolStripMenuItem.Size = New System.Drawing.Size(117, 24)
        Me.KMHToolStripMenuItem.Tag = "3"
        Me.KMHToolStripMenuItem.Text = "KM/H"
        '
        'ActualTorqueToolStripMenuItem
        '
        Me.ActualTorqueToolStripMenuItem.Name = "ActualTorqueToolStripMenuItem"
        Me.ActualTorqueToolStripMenuItem.Size = New System.Drawing.Size(187, 24)
        Me.ActualTorqueToolStripMenuItem.Tag = "4"
        Me.ActualTorqueToolStripMenuItem.Text = "Actual Torque"
        '
        'AngularSpeedToolStripMenuItem
        '
        Me.AngularSpeedToolStripMenuItem.Name = "AngularSpeedToolStripMenuItem"
        Me.AngularSpeedToolStripMenuItem.Size = New System.Drawing.Size(187, 24)
        Me.AngularSpeedToolStripMenuItem.Tag = "2"
        Me.AngularSpeedToolStripMenuItem.Text = "Angular Velocity"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(184, 6)
        '
        'FeedbackDataToolStripMenuItem
        '
        Me.FeedbackDataToolStripMenuItem.Name = "FeedbackDataToolStripMenuItem"
        Me.FeedbackDataToolStripMenuItem.Size = New System.Drawing.Size(187, 24)
        Me.FeedbackDataToolStripMenuItem.Tag = "6"
        Me.FeedbackDataToolStripMenuItem.Text = "Feedback Data"
        '
        'TotalErrorsToolStripMenuItem
        '
        Me.TotalErrorsToolStripMenuItem.Name = "TotalErrorsToolStripMenuItem"
        Me.TotalErrorsToolStripMenuItem.Size = New System.Drawing.Size(187, 24)
        Me.TotalErrorsToolStripMenuItem.Tag = "7"
        Me.TotalErrorsToolStripMenuItem.Text = "Total Errors"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatusBar1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 588)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1058, 29)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatusBar1
        '
        Me.lblStatusBar1.BorderSides = CType((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.lblStatusBar1.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.lblStatusBar1.Name = "lblStatusBar1"
        Me.lblStatusBar1.Size = New System.Drawing.Size(792, 24)
        Me.lblStatusBar1.Spring = True
        Me.lblStatusBar1.Text = "Not Connected"
        Me.lblStatusBar1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlsMonitor
        '
        Me.tlsMonitor.AutoSize = False
        Me.tlsMonitor.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tlsMonitor.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.ToolStripSeparator2, Me.ToolStripSeparator3, Me.ToolStripLabel1, Me.ToolStripLabel2})
        Me.tlsMonitor.Location = New System.Drawing.Point(0, 540)
        Me.tlsMonitor.Name = "tlsMonitor"
        Me.tlsMonitor.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.tlsMonitor.Size = New System.Drawing.Size(1058, 48)
        Me.tlsMonitor.TabIndex = 3
        Me.tlsMonitor.Text = "ToolStrip2"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 48)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 48)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 48)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(521, 45)
        Me.ToolStripLabel1.Text = "Designed and Coded by Hamidreza Ebtehaj (hamidreza.ebtehaj@gmail.com)"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.WindowToolStripMenuItem, Me.ControlToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1058, 28)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConnectToolStripMenuItem, Me.DisconnectToolStripMenuItem, Me.ToolStripMenuItem4, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ConnectToolStripMenuItem
        '
        Me.ConnectToolStripMenuItem.Name = "ConnectToolStripMenuItem"
        Me.ConnectToolStripMenuItem.Size = New System.Drawing.Size(151, 24)
        Me.ConnectToolStripMenuItem.Text = "Connect"
        '
        'DisconnectToolStripMenuItem
        '
        Me.DisconnectToolStripMenuItem.Name = "DisconnectToolStripMenuItem"
        Me.DisconnectToolStripMenuItem.Size = New System.Drawing.Size(151, 24)
        Me.DisconnectToolStripMenuItem.Text = "Disconnect"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(148, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(151, 24)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'WindowToolStripMenuItem
        '
        Me.WindowToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResultWindowToolStripMenuItem, Me.ControlWindowToolStripMenuItem, Me.WheelPreviewWindowToolStripMenuItem})
        Me.WindowToolStripMenuItem.Name = "WindowToolStripMenuItem"
        Me.WindowToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.WindowToolStripMenuItem.Text = "View"
        '
        'ResultWindowToolStripMenuItem
        '
        Me.ResultWindowToolStripMenuItem.Checked = True
        Me.ResultWindowToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ResultWindowToolStripMenuItem.Name = "ResultWindowToolStripMenuItem"
        Me.ResultWindowToolStripMenuItem.Size = New System.Drawing.Size(234, 24)
        Me.ResultWindowToolStripMenuItem.Text = "Result Window"
        '
        'ControlWindowToolStripMenuItem
        '
        Me.ControlWindowToolStripMenuItem.Checked = True
        Me.ControlWindowToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ControlWindowToolStripMenuItem.Name = "ControlWindowToolStripMenuItem"
        Me.ControlWindowToolStripMenuItem.Size = New System.Drawing.Size(234, 24)
        Me.ControlWindowToolStripMenuItem.Text = "Control Window"
        '
        'WheelPreviewWindowToolStripMenuItem
        '
        Me.WheelPreviewWindowToolStripMenuItem.Checked = True
        Me.WheelPreviewWindowToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.WheelPreviewWindowToolStripMenuItem.Name = "WheelPreviewWindowToolStripMenuItem"
        Me.WheelPreviewWindowToolStripMenuItem.Size = New System.Drawing.Size(234, 24)
        Me.WheelPreviewWindowToolStripMenuItem.Text = "Wheel Preview Window"
        '
        'ControlToolStripMenuItem
        '
        Me.ControlToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartToolStripMenuItem, Me.StopToolStripMenuItem, Me.ToolStripMenuItem2, Me.TurnRightToolStripMenuItem, Me.TurnLeftToolStripMenuItem, Me.ToolStripMenuItem3, Me.SelectedMotorToolStripMenuItem})
        Me.ControlToolStripMenuItem.Name = "ControlToolStripMenuItem"
        Me.ControlToolStripMenuItem.Size = New System.Drawing.Size(70, 24)
        Me.ControlToolStripMenuItem.Text = "Control"
        '
        'StartToolStripMenuItem
        '
        Me.StartToolStripMenuItem.Enabled = False
        Me.StartToolStripMenuItem.Name = "StartToolStripMenuItem"
        Me.StartToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.StartToolStripMenuItem.Text = "Start"
        '
        'StopToolStripMenuItem
        '
        Me.StopToolStripMenuItem.Enabled = False
        Me.StopToolStripMenuItem.Name = "StopToolStripMenuItem"
        Me.StopToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.StopToolStripMenuItem.Text = "Stop"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(177, 6)
        '
        'TurnRightToolStripMenuItem
        '
        Me.TurnRightToolStripMenuItem.Enabled = False
        Me.TurnRightToolStripMenuItem.Name = "TurnRightToolStripMenuItem"
        Me.TurnRightToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.TurnRightToolStripMenuItem.Text = "Turn Right"
        '
        'TurnLeftToolStripMenuItem
        '
        Me.TurnLeftToolStripMenuItem.Enabled = False
        Me.TurnLeftToolStripMenuItem.Name = "TurnLeftToolStripMenuItem"
        Me.TurnLeftToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.TurnLeftToolStripMenuItem.Text = "Turn Left"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(177, 6)
        '
        'SelectedMotorToolStripMenuItem
        '
        Me.SelectedMotorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AllToolStripMenuItem, Me.ToolStripComboBox1})
        Me.SelectedMotorToolStripMenuItem.Name = "SelectedMotorToolStripMenuItem"
        Me.SelectedMotorToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.SelectedMotorToolStripMenuItem.Text = "Selected Motor"
        '
        'AllToolStripMenuItem
        '
        Me.AllToolStripMenuItem.Checked = True
        Me.AllToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.AllToolStripMenuItem.Name = "AllToolStripMenuItem"
        Me.AllToolStripMenuItem.Size = New System.Drawing.Size(181, 24)
        Me.AllToolStripMenuItem.Text = "All"
        '
        'ToolStripComboBox1
        '
        Me.ToolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ToolStripComboBox1.Items.AddRange(New Object() {"Motor 1", "Motor 2", "Motor 3"})
        Me.ToolStripComboBox1.MergeAction = System.Windows.Forms.MergeAction.MatchOnly
        Me.ToolStripComboBox1.Name = "ToolStripComboBox1"
        Me.ToolStripComboBox1.Size = New System.Drawing.Size(121, 28)
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConnctionPrefrencesToolStripMenuItem, Me.OptionsToolStripMenuItem})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(74, 24)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'ConnctionPrefrencesToolStripMenuItem
        '
        Me.ConnctionPrefrencesToolStripMenuItem.Image = CType(resources.GetObject("ConnctionPrefrencesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ConnctionPrefrencesToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ConnctionPrefrencesToolStripMenuItem.Name = "ConnctionPrefrencesToolStripMenuItem"
        Me.ConnctionPrefrencesToolStripMenuItem.Size = New System.Drawing.Size(226, 24)
        Me.ConnctionPrefrencesToolStripMenuItem.Text = "Connction preferences"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Image = CType(resources.GetObject("OptionsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OptionsToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(226, 24)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(119, 24)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'imgList16
        '
        Me.imgList16.ImageStream = CType(resources.GetObject("imgList16.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgList16.TransparentColor = System.Drawing.Color.Transparent
        Me.imgList16.Images.SetKeyName(0, "batfile.ico")
        Me.imgList16.Images.SetKeyName(1, "cmd.ico")
        Me.imgList16.Images.SetKeyName(2, "help.ico")
        Me.imgList16.Images.SetKeyName(3, "Settings.ico")
        Me.imgList16.Images.SetKeyName(4, "WispRefresh.ico")
        Me.imgList16.Images.SetKeyName(5, "1380_wall_clockFINAL.ico")
        Me.imgList16.Images.SetKeyName(6, "Monitor.ico")
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(317, 45)
        Me.ToolStripLabel2.Text = "در میخانه ببستند خدا یا مپسند/که در خانه تزویر و ریا بگشایند"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1058, 617)
        Me.Controls.Add(Me.tlsMonitor)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMain"
        Me.Text = "TractionCtrl v.1.0"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mnuPopupMotor.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.tlsMonitor.ResumeLayout(False)
        Me.tlsMonitor.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents mnuPopupMotor As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AngleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LinearSpeedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AngularSpeedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tlsMonitor As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ControlToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StartToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StopToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TurnRightToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TurnLeftToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SelectedMotorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripComboBox1 As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConnectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisconnectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents imgList16 As System.Windows.Forms.ImageList
    Friend WithEvents WindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblStatusBar1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ResultWindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ControlWindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WheelPreviewWindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConnctionPrefrencesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KMHToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualTorqueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EncoderPulseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TotalErrorsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FeedbackDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel

End Class
