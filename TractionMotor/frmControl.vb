Imports System.Threading

Public Class frmControl
    Private boolUpdate As Boolean = False
    Private CurrentMotor As SerialMotor = Motor1
    Private boolAllMotors As Boolean = True
    Private boolStartRotate As Boolean = False
    Private Sub frmControl_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Left
                If btnLeft.Enabled Then StartRotate(btnLeft)
            Case Keys.Right
                If btnRight.Enabled Then StartRotate(btnRight)
        End Select

        'e.Handled = True
    End Sub

    Private Sub frmControl_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode
            Case Keys.Left
                If btnLeft.Enabled Then StopRotate(btnLeft)
            Case Keys.Right
                If btnRight.Enabled Then StopRotate(btnRight)
        End Select

        'e.Handled = True
    End Sub

    
    Private Sub frmControl_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbSpeed.SelectedIndex = 0
    End Sub

    Protected Friend Sub UpdateControls()
        If boolAnyConnectedMotor Then
            For Each btn As Object In Me.Controls
                If btn.GetType = GetType(Button) Then CType(btn, Button).Enabled = True
            Next
        Else
            For Each btn As Object In Me.Controls
                If btn.GetType = GetType(Button) Then CType(btn, Button).Enabled = False
            Next
        End If

    End Sub
    Private Sub RadMotors_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radMotor3.Click, radMotor2.Click, radMotor1.Click
        Select Case CType(sender, RadioButton).Name
            Case "radMotor1" : CurrentMotor = Motor1
            Case "radMotor2" : CurrentMotor = Motor2
            Case "radMotor3" : CurrentMotor = Motor3
        End Select
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            boolAllMotors = True
            radMotor1.Enabled = False : radMotor2.Enabled = False : radMotor3.Enabled = False
        Else
            radMotor1.Enabled = True : radMotor2.Enabled = True : radMotor3.Enabled = True
            boolAllMotors = False
        End If
    End Sub

    Private Sub nudSpeed_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudSpeed.ValueChanged, cmbSpeed.SelectedIndexChanged
        Select Case cmbSpeed.SelectedIndex
            Case 0 'rpm
                psngSetSpeed = nudSpeed.Value
                penmSpeedUnit = UnitNames.rpm
            Case 1 'mps
                psngSetSpeed = nudSpeed.Value * 200 * 60 / (2 * Math.PI)
                penmSpeedUnit = UnitNames.mps
            Case 2 'kmh
                psngSetSpeed = nudSpeed.Value * 200 * 60 / (2 * Math.PI * 3.6)
                penmSpeedUnit = UnitNames.kmh
        End Select
    End Sub


    Private Sub Rotate_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnRight.MouseDown, btnLeft.MouseDown
        If Not boolStartRotate Then
            boolStartRotate = True
            StartRotate(sender)
        End If

    End Sub

    Private Sub Rotate_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnRight.MouseUp, btnLeft.MouseUp
        If boolStartRotate Then
            StopRotate(sender)
            boolStartRotate = False
        End If

    End Sub


    Private Sub UpdateRotate()
        Dim i As Integer = 0
        Dim datBeginTime As DateTime = DateTime.Now
        Do While boolUpdate
            i += 1
            frmMain.tlsMonitorUpdate()
            frmChild.UpdateMonitors()
            frmChild.UpdateCharts()
            If i Mod 3 = 0 Then Application.DoEvents()
        Loop
    End Sub


    Private Function ComputeSetSpeed(ByVal SetSpeed As Single, ByVal Unit As UnitNames, ByVal Motor As SerialMotor) As Single
        Select Case Unit
            Case UnitNames.rpm
                ComputeSetSpeed = SetSpeed
            Case Else
                ComputeSetSpeed = SetSpeed / Motor.Diameter
        End Select
    End Function

    Private Sub StartRotate(ByVal sender As Object)
        Select Case CType(sender, Button).Name
            Case "btnRight"
                Motor1.SetRotateDirection = SerialMotor.Direction.CW
                Motor2.SetRotateDirection = SerialMotor.Direction.CW
                Motor3.SetRotateDirection = SerialMotor.Direction.CW
                CurrentMotor.SetRotateDirection = SerialMotor.Direction.CW
                CType(sender, Button).ImageIndex = 7
            Case "btnLeft"
                Motor1.SetRotateDirection = SerialMotor.Direction.CCW
                Motor2.SetRotateDirection = SerialMotor.Direction.CCW
                Motor3.SetRotateDirection = SerialMotor.Direction.CCW
                CurrentMotor.SetRotateDirection = SerialMotor.Direction.CCW
                CType(sender, Button).ImageIndex = 3
        End Select
        Dim sngGainAndDiameterFactor As Single = 1

        If boolAllMotors Then
            Motor1.SetSpeed = ComputeSetSpeed(psngSetSpeed, penmSpeedUnit, Motor1)
            Motor2.SetSpeed = ComputeSetSpeed(psngSetSpeed, penmSpeedUnit, Motor2)
            Motor3.SetSpeed = ComputeSetSpeed(psngSetSpeed, penmSpeedUnit, Motor3)
        Else
            CurrentMotor.SetSpeed = ComputeSetSpeed(psngSetSpeed, penmSpeedUnit, CurrentMotor)
        End If


        boolUpdate = True
        Call UpdateRotate()
    End Sub
    Private Sub StopRotate(ByVal sender As Object)
        Select Case CType(sender, Button).Name
            Case "btnRight"
                CType(sender, Button).ImageIndex = 5
            Case "btnLeft"
                CType(sender, Button).ImageIndex = 1
        End Select
        If boolAllMotors Then
            Motor1.SetSpeed = 0 : Motor2.SetSpeed = 0 : Motor3.SetSpeed = 0
        Else
            CurrentMotor.SetSpeed = 0
        End If
        boolUpdate = False

        Application.DoEvents()
        Dim datNow As DateTime = DateTime.Now
        Do While CType(DateTime.Now - datNow, TimeSpan).TotalSeconds < 1
            frmMain.tlsMonitorUpdate()
            Application.DoEvents()
        Loop
    End Sub
    
 

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        Dim i As Integer
        If cmbSpeed.SelectedIndex <> 2 Then ' Km/h
            MsgBox("Please Select 'Km/h' to Start the Simulation", vbExclamation)
            Exit Sub
        End If

        pblnSimulating = True

        btnRight.Enabled = False : btnLeft.Enabled = False : btnStart.Enabled = False
        cmbSpeed.Enabled = False
        btnStop.Focus()


        While pblnSimulating
            Motor1.SetSpeed = ComputeSetSpeed(psngSetSpeed, penmSpeedUnit, Motor1)
            Motor2.SetSpeed = ComputeSetSpeed(psngSetSpeed, penmSpeedUnit, Motor2)
            Motor3.SetSpeed = ComputeSetSpeed(psngSetSpeed, penmSpeedUnit, Motor3)

            i += 1
            frmMain.tlsMonitorUpdate()
            frmChild.UpdateMonitors()
            frmChild.UpdateCharts()
            If i Mod 10 = 0 Then Application.DoEvents()
        End While
    End Sub

    
    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        If Not pblnSimulating Then Exit Sub
        pblnSimulating = False

        btnRight.Enabled = True : btnLeft.Enabled = True : btnStart.Enabled = True
        cmbSpeed.Enabled = True

        Motor1.SetSpeed = 0 : Motor2.SetSpeed = 0 : Motor3.SetSpeed = 0

    End Sub

    Private Sub btnRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRight.Click

    End Sub
End Class