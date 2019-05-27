Public Class frmConnectPre

    Private Sub frmConnectPre_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.SelectedItem = Motor1.COMPort : ComboBox2.SelectedItem = Motor2.COMPort : ComboBox3.SelectedItem = Motor3.COMPort
        ComboBox4.SelectedItem = CStr(Motor1.BaudRate) : ComboBox5.SelectedItem = CStr(Motor2.BaudRate) : ComboBox6.SelectedItem = CStr(Motor3.BaudRate)
        ComboBox7.SelectedItem = CStr(Motor1.DataBit) : ComboBox8.SelectedItem = CStr(Motor2.DataBit) : ComboBox9.SelectedItem = CStr(Motor3.DataBit)
        ComboBox10.SelectedIndex = Motor1.StopBits : ComboBox11.SelectedIndex = Motor2.StopBits : ComboBox12.SelectedIndex = Motor3.StopBits
        ComboBox13.SelectedIndex = Motor1.Parity : ComboBox14.SelectedIndex = Motor2.Parity : ComboBox15.SelectedIndex = Motor3.Parity

        grpSensors.Enabled = False
    End Sub


    Private Sub cmdApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdApply.Click
        Motor1.COMPort = ComboBox1.SelectedItem : Motor2.COMPort = ComboBox2.SelectedItem : Motor3.COMPort = ComboBox3.SelectedItem
        Motor1.BaudRate = ComboBox4.SelectedItem : Motor2.BaudRate = ComboBox5.SelectedItem : Motor3.BaudRate = ComboBox6.SelectedItem
        Motor1.DataBit = ComboBox7.SelectedItem : Motor2.DataBit = ComboBox8.SelectedItem : Motor3.DataBit = ComboBox9.SelectedItem
        Motor1.StopBits = ComboBox10.SelectedIndex : Motor2.StopBits = ComboBox11.SelectedIndex : Motor3.StopBits = ComboBox12.SelectedIndex
        Motor1.Parity = ComboBox13.SelectedIndex : Motor2.Parity = ComboBox14.SelectedIndex : Motor3.Parity = ComboBox15.SelectedIndex
    End Sub

    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOK.Click
        cmdApply_Click(Me, New EventArgs())
        Me.Close()
    End Sub

    Private Sub CheckMotors(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckMotor1ToolStripMenuItem.Click, CheckMotor1ToolStripMenuItem2.Click, CheckMotor1ToolStripMenuItem1.Click, ToolStripSplitButton1.ButtonClick
        cmdApply_Click(Me, New EventArgs())
        Select Case LCase(sender.ToString)
            Case "check motor 1" : UpdateMotorStatus(Motor1, Label11)
            Case "check motor 2" : UpdateMotorStatus(Motor2, Label12)
            Case "check motor 3" : UpdateMotorStatus(Motor3, Label13)
            Case Else : UpdateMotorStatus(Motor1, Label11) : UpdateMotorStatus(Motor2, Label12) : UpdateMotorStatus(Motor3, Label13)
        End Select

    End Sub
    Private Sub UpdateMotorStatus(ByVal Motor As SerialMotor, ByVal lblStatus As Label)
        If Motor.TestConnection Then
            lblStatus.Text = "OK"
            lblStatus.ForeColor = Color.DarkGreen
        Else
            lblStatus.Text = "Error"
            lblStatus.ForeColor = Color.DarkRed
        End If
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub
End Class