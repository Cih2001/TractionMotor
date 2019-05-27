<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmControl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmControl))
        Me.imgList48 = New System.Windows.Forms.ImageList(Me.components)
        Me.imgList32 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radMotor3 = New System.Windows.Forms.RadioButton()
        Me.radMotor2 = New System.Windows.Forms.RadioButton()
        Me.radMotor1 = New System.Windows.Forms.RadioButton()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.cmbSpeed = New System.Windows.Forms.ComboBox()
        Me.nudSpeed = New System.Windows.Forms.NumericUpDown()
        Me.btnLeft = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnRight = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.nudSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgList48
        '
        Me.imgList48.ImageStream = CType(resources.GetObject("imgList48.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgList48.TransparentColor = System.Drawing.Color.Transparent
        Me.imgList48.Images.SetKeyName(0, "112_RefreshArrow_Blue_48x48_72.png")
        Me.imgList48.Images.SetKeyName(1, "112_RefreshArrow_Green_48x48_72.png")
        Me.imgList48.Images.SetKeyName(2, "305_Close_48x48_72.png")
        '
        'imgList32
        '
        Me.imgList32.ImageStream = CType(resources.GetObject("imgList32.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgList32.TransparentColor = System.Drawing.Color.Transparent
        Me.imgList32.Images.SetKeyName(0, "112_LeftArrowShort_Blue.ico")
        Me.imgList32.Images.SetKeyName(1, "112_LeftArrowShort_Green.ico")
        Me.imgList32.Images.SetKeyName(2, "112_LeftArrowShort_Grey.ico")
        Me.imgList32.Images.SetKeyName(3, "112_LeftArrowShort_Orange.ico")
        Me.imgList32.Images.SetKeyName(4, "112_RightArrowShort_Blue.ico")
        Me.imgList32.Images.SetKeyName(5, "112_RightArrowShort_Green.ico")
        Me.imgList32.Images.SetKeyName(6, "112_RightArrowShort_Grey.ico")
        Me.imgList32.Images.SetKeyName(7, "112_RightArrowShort_Orange.ico")
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radMotor3)
        Me.GroupBox1.Controls.Add(Me.radMotor2)
        Me.GroupBox1.Controls.Add(Me.radMotor1)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(479, 6)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(121, 105)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'radMotor3
        '
        Me.radMotor3.AutoSize = True
        Me.radMotor3.Enabled = False
        Me.radMotor3.Location = New System.Drawing.Point(16, 73)
        Me.radMotor3.Margin = New System.Windows.Forms.Padding(4)
        Me.radMotor3.Name = "radMotor3"
        Me.radMotor3.Size = New System.Drawing.Size(77, 21)
        Me.radMotor3.TabIndex = 1
        Me.radMotor3.Text = "Motor 3"
        Me.radMotor3.UseVisualStyleBackColor = True
        '
        'radMotor2
        '
        Me.radMotor2.AutoSize = True
        Me.radMotor2.Enabled = False
        Me.radMotor2.Location = New System.Drawing.Point(16, 47)
        Me.radMotor2.Margin = New System.Windows.Forms.Padding(4)
        Me.radMotor2.Name = "radMotor2"
        Me.radMotor2.Size = New System.Drawing.Size(77, 21)
        Me.radMotor2.TabIndex = 1
        Me.radMotor2.TabStop = True
        Me.radMotor2.Text = "Motor 2"
        Me.radMotor2.UseVisualStyleBackColor = True
        '
        'radMotor1
        '
        Me.radMotor1.AutoSize = True
        Me.radMotor1.Checked = True
        Me.radMotor1.Enabled = False
        Me.radMotor1.Location = New System.Drawing.Point(16, 23)
        Me.radMotor1.Margin = New System.Windows.Forms.Padding(4)
        Me.radMotor1.Name = "radMotor1"
        Me.radMotor1.Size = New System.Drawing.Size(77, 21)
        Me.radMotor1.TabIndex = 1
        Me.radMotor1.TabStop = True
        Me.radMotor1.Text = "Motor 1"
        Me.radMotor1.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(8, 1)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(92, 21)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "All Motors"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'cmbSpeed
        '
        Me.cmbSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSpeed.FormattingEnabled = True
        Me.cmbSpeed.Items.AddRange(New Object() {"rpm", "m/s", "km/h"})
        Me.cmbSpeed.Location = New System.Drawing.Point(169, 85)
        Me.cmbSpeed.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbSpeed.Name = "cmbSpeed"
        Me.cmbSpeed.Size = New System.Drawing.Size(145, 24)
        Me.cmbSpeed.TabIndex = 9
        '
        'nudSpeed
        '
        Me.nudSpeed.Location = New System.Drawing.Point(16, 86)
        Me.nudSpeed.Margin = New System.Windows.Forms.Padding(4)
        Me.nudSpeed.Maximum = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.nudSpeed.Name = "nudSpeed"
        Me.nudSpeed.Size = New System.Drawing.Size(145, 22)
        Me.nudSpeed.TabIndex = 8
        Me.nudSpeed.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'btnLeft
        '
        Me.btnLeft.Enabled = False
        Me.btnLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnLeft.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLeft.ImageIndex = 1
        Me.btnLeft.ImageList = Me.imgList32
        Me.btnLeft.Location = New System.Drawing.Point(324, 62)
        Me.btnLeft.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLeft.Name = "btnLeft"
        Me.btnLeft.Size = New System.Drawing.Size(147, 49)
        Me.btnLeft.TabIndex = 6
        Me.btnLeft.Text = "Rotate CCW"
        Me.btnLeft.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLeft.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Enabled = False
        Me.btnStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnStop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStop.ImageIndex = 2
        Me.btnStop.ImageList = Me.imgList48
        Me.btnStop.Location = New System.Drawing.Point(169, 7)
        Me.btnStop.Margin = New System.Windows.Forms.Padding(4)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnStop.Size = New System.Drawing.Size(147, 73)
        Me.btnStop.TabIndex = 3
        Me.btnStop.Text = "Stop  "
        Me.btnStop.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnRight
        '
        Me.btnRight.Enabled = False
        Me.btnRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnRight.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRight.ImageIndex = 5
        Me.btnRight.ImageList = Me.imgList32
        Me.btnRight.Location = New System.Drawing.Point(324, 7)
        Me.btnRight.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Size = New System.Drawing.Size(147, 49)
        Me.btnRight.TabIndex = 4
        Me.btnRight.Text = "Rotate CW"
        Me.btnRight.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRight.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Enabled = False
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStart.ImageIndex = 1
        Me.btnStart.ImageList = Me.imgList48
        Me.btnStart.Location = New System.Drawing.Point(15, 7)
        Me.btnStart.Margin = New System.Windows.Forms.Padding(4)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnStart.Size = New System.Drawing.Size(147, 73)
        Me.btnStart.TabIndex = 5
        Me.btnStart.Text = "Start  "
        Me.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'frmControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(607, 117)
        Me.Controls.Add(Me.cmbSpeed)
        Me.Controls.Add(Me.nudSpeed)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnLeft)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnRight)
        Me.Controls.Add(Me.btnStart)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Location", Global.TractionMotorCtrl.My.MySettings.Default, "ControlPosition", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Location = Global.TractionMotorCtrl.My.MySettings.Default.ControlPosition
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmControl"
        Me.Text = "Control"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.nudSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents imgList48 As System.Windows.Forms.ImageList
    Friend WithEvents imgList32 As System.Windows.Forms.ImageList
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radMotor3 As System.Windows.Forms.RadioButton
    Friend WithEvents radMotor2 As System.Windows.Forms.RadioButton
    Friend WithEvents radMotor1 As System.Windows.Forms.RadioButton
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents btnLeft As System.Windows.Forms.Button
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents btnRight As System.Windows.Forms.Button
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents cmbSpeed As System.Windows.Forms.ComboBox
    Friend WithEvents nudSpeed As System.Windows.Forms.NumericUpDown
End Class
