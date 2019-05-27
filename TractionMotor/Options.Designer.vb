<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOptions
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tbpSim = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDiameter3 = New System.Windows.Forms.TextBox()
        Me.txtWheelName3 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDiameter2 = New System.Windows.Forms.TextBox()
        Me.txtWheelName2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDiameter1 = New System.Windows.Forms.TextBox()
        Me.txtWheelName1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.tbpSim.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tbpSim)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(415, 410)
        Me.TabControl1.TabIndex = 0
        '
        'tbpSim
        '
        Me.tbpSim.Controls.Add(Me.GroupBox3)
        Me.tbpSim.Controls.Add(Me.GroupBox2)
        Me.tbpSim.Controls.Add(Me.GroupBox1)
        Me.tbpSim.Location = New System.Drawing.Point(4, 25)
        Me.tbpSim.Name = "tbpSim"
        Me.tbpSim.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpSim.Size = New System.Drawing.Size(407, 381)
        Me.tbpSim.TabIndex = 0
        Me.tbpSim.Text = "Simulation Options"
        Me.tbpSim.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtDiameter3)
        Me.GroupBox3.Controls.Add(Me.txtWheelName3)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 260)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(395, 100)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Wheel 3"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 17)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Diameter(Cm) :"
        '
        'txtDiameter3
        '
        Me.txtDiameter3.Location = New System.Drawing.Point(137, 51)
        Me.txtDiameter3.Name = "txtDiameter3"
        Me.txtDiameter3.Size = New System.Drawing.Size(252, 22)
        Me.txtDiameter3.TabIndex = 1
        Me.txtDiameter3.Text = "110"
        '
        'txtWheelName3
        '
        Me.txtWheelName3.Location = New System.Drawing.Point(137, 22)
        Me.txtWheelName3.Name = "txtWheelName3"
        Me.txtWheelName3.Size = New System.Drawing.Size(252, 22)
        Me.txtWheelName3.TabIndex = 1
        Me.txtWheelName3.Text = "Wheel 3"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Name :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtDiameter2)
        Me.GroupBox2.Controls.Add(Me.txtWheelName2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 141)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(395, 100)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Wheel 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Diameter(Cm) :"
        '
        'txtDiameter2
        '
        Me.txtDiameter2.Location = New System.Drawing.Point(137, 51)
        Me.txtDiameter2.Name = "txtDiameter2"
        Me.txtDiameter2.Size = New System.Drawing.Size(252, 22)
        Me.txtDiameter2.TabIndex = 1
        Me.txtDiameter2.Text = "110"
        '
        'txtWheelName2
        '
        Me.txtWheelName2.Location = New System.Drawing.Point(137, 22)
        Me.txtWheelName2.Name = "txtWheelName2"
        Me.txtWheelName2.Size = New System.Drawing.Size(252, 22)
        Me.txtWheelName2.TabIndex = 1
        Me.txtWheelName2.Text = "Wheel 2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Name :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtDiameter1)
        Me.GroupBox1.Controls.Add(Me.txtWheelName1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(395, 129)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Wheel 1"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.CheckBox1.Enabled = False
        Me.CheckBox1.Location = New System.Drawing.Point(19, 86)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(101, 21)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.Text = "3D Preview"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Diameter(Cm) :"
        '
        'txtDiameter1
        '
        Me.txtDiameter1.Location = New System.Drawing.Point(137, 51)
        Me.txtDiameter1.Name = "txtDiameter1"
        Me.txtDiameter1.Size = New System.Drawing.Size(252, 22)
        Me.txtDiameter1.TabIndex = 1
        Me.txtDiameter1.Text = "110"
        '
        'txtWheelName1
        '
        Me.txtWheelName1.Location = New System.Drawing.Point(137, 22)
        Me.txtWheelName1.Name = "txtWheelName1"
        Me.txtWheelName1.Size = New System.Drawing.Size(252, 22)
        Me.txtWheelName1.TabIndex = 1
        Me.txtWheelName1.Text = "Wheel 1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name :"
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(407, 381)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Charts"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(183, 428)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(119, 32)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnApply
        '
        Me.btnApply.Location = New System.Drawing.Point(308, 428)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(119, 32)
        Me.btnApply.TabIndex = 1
        Me.btnApply.Text = "Apply"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(58, 428)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(119, 32)
        Me.btnOk.TabIndex = 1
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'frmOptions
        '
        Me.AcceptButton = Me.btnOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(439, 467)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmOptions"
        Me.Text = "Options"
        Me.TabControl1.ResumeLayout(False)
        Me.tbpSim.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tbpSim As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDiameter1 As System.Windows.Forms.TextBox
    Friend WithEvents txtWheelName1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDiameter3 As System.Windows.Forms.TextBox
    Friend WithEvents txtWheelName3 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDiameter2 As System.Windows.Forms.TextBox
    Friend WithEvents txtWheelName2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnApply As System.Windows.Forms.Button
    Friend WithEvents btnOk As System.Windows.Forms.Button
End Class
