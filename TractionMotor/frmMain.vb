Imports System.Text
Imports System.Threading

Public Class frmMain
    Dim LABEL_MONITOR_CONNECT_COLOR As Color = Color.PaleGreen
    Dim LABEL_MONITOR_NOTCONNECT_COLOR As Color = Color.LightGray

    Dim frmWheelPreview As New WheelPreviewWindow
    Dim frmLogin As New frmLogin
    Dim lblMonitor1 As ToolStripItem, lblMonitor2 As ToolStripItem, lblMonitor3 As ToolStripItem
    Dim enmMonitor1 As MonitorItems, enmMonitor2 As MonitorItems, enmMonitor3 As MonitorItems
    Dim enmActiveMonitor As Integer = 1

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Motor1.SetCtrlOff = True : Motor2.SetCtrlOff = True : Motor3.SetCtrlOff = True

        If thrMotor1.IsAlive Then thrMotor1.Join() : If thrMotor2.IsAlive Then thrMotor2.Join() : If thrMotor3.IsAlive Then thrMotor3.Join()

        SaveSettings()
        End
    End Sub
    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Visible = False
        Windows.Forms.Integration.ElementHost.EnableModelessKeyboardInterop(frmLogin)
#If Debug Then
        frmLogin.Show()

        Do While Not pblnLoginPassed
            Application.DoEvents()
        Loop
#End If
        frmLogin.Show()
        frmLogin.Hide()

        Me.Show()


        frmChild.MdiParent = Me
        frmChild.Show()

        frmControl.MdiParent = Me
        frmControl.Show()

        InitToolStrip()
        InitMotors()

        frmWheelPreview.Width = frmControl.Width
        frmWheelPreview.Left = frmControl.Left - 220
        frmWheelPreview.Show()

        frmLogin.Hide()

    End Sub
    Private Sub InitToolStrip()

        For i As Integer = 1 To 3
            Dim lbl As New Label
            With lbl
                .AutoSize = False
                .Text = "(Not Connected)"
                .TextAlign = ContentAlignment.MiddleCenter
                .Padding = New Padding(5)
                .Size = New Size(250, tlsMonitor.Size.Height)
                .Font = New Font("Tahoma", 12, FontStyle.Regular)
                .BackColor = Color.LightGray
                .BorderStyle = BorderStyle.Fixed3D
                .ContextMenuStrip = mnuPopupMotor
            End With
            Dim tschost As New ToolStripControlHost(lbl)
            tschost.AutoSize = False
            tschost.Name = "hstInfo" & i
            'tschost.Enabled = False
            tlsMonitor.Items.Insert((i - 1) * 2, tschost)
            AddHandler tschost.MouseDown, AddressOf lblMonitor_MouseDown
            For Each obj As ToolStripItem In tlsMonitor.Items
                If obj.Name = "hstInfo1" Then lblMonitor1 = obj
                If obj.Name = "hstInfo2" Then lblMonitor2 = obj
                If obj.Name = "hstInfo3" Then lblMonitor3 = obj
            Next
        Next
    End Sub
    Private Sub MnuClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConnctionPrefrencesToolStripMenuItem.Click
        Select Case LCase(CType(sender, ToolStripMenuItem).Text)
            Case "exit" : Me.Close()
            Case "connction preferences"
                frmConnectPre.ShowDialog(Me)
            Case Else : MsgBox(LCase(CType(sender, ToolStripMenuItem).Text))
        End Select
    End Sub
    Protected Friend Sub tlsMonitorUpdate()
        SetLblMonitorText(lblMonitor1, Motor1, enmMonitor1)
        SetLblMonitorText(lblMonitor2, Motor2, enmMonitor2)
        SetLblMonitorText(lblMonitor3, Motor3, enmMonitor3)

        If Not frmWheelPreview.Interactivity Then frmWheelPreview.Interactivity = True
        frmWheelPreview.Angle = Motor1.feedbackAngle
    End Sub
    Private Sub ConnectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConnectToolStripMenuItem.Click
        Dim strTmp As String = vbNullString
        'Connecting To Traction Motor 1
        If Not Motor1.IsConnected And Motor1.TestConnection Then
            thrMotor1.Start() : boolAnyConnectedMotor = True
            strTmp &= "Motor 1, "
            lblMonitor1.BackColor = LABEL_MONITOR_CONNECT_COLOR : lblMonitor1.Text = "Connected"
        ElseIf Motor1.IsConnected Then : strTmp &= "Motor 1, "
        End If

        'Connecting To Traction Motor 2
        If Not Motor2.IsConnected And Motor2.TestConnection Then
            thrMotor2.Start() : boolAnyConnectedMotor = True
            strTmp &= "Motor 2, "
            lblMonitor2.BackColor = LABEL_MONITOR_CONNECT_COLOR : lblMonitor2.Text = "Connected"
        ElseIf Motor2.IsConnected Then : strTmp &= "Motor 2, "
        End If

        'Connecting To Traction Motor 3
        If Not Motor3.IsConnected And Motor3.TestConnection Then
            strTmp &= "Motor 3, "
            thrMotor3.Start() : boolAnyConnectedMotor = True
            lblMonitor3.BackColor = LABEL_MONITOR_CONNECT_COLOR : lblMonitor3.Text = "Connected"
        ElseIf Motor3.IsConnected Then : strTmp &= "Motor 3, "
        End If

        'Updating FrmMain's Status Bar
        If boolAnyConnectedMotor Then
            Dim strStatus As New StringBuilder
            strStatus.Append("Connected To : " & strTmp)
            strStatus.Remove(strStatus.Length - 2, 2)
            lblStatusBar1.Text = strStatus.ToString
            lblStatusBar1.ForeColor = Color.Black
        Else
            MsgBox("Could not Connect to Any Motors, Please check the connection settings", vbCritical)
            lblStatusBar1.Text = "Could not Connect to Any Motors, Please check the connection settings"
            lblStatusBar1.ForeColor = Color.DarkRed
        End If

        'Updating Other Forms Controls
        frmControl.UpdateControls()
        frmChild.EnableOrDisableControls()
    End Sub
    Private Sub DisconnectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisconnectToolStripMenuItem.Click
        'Diconnecting From Motor1 And Aborting the thread and generating a new thread for another connection
        If Motor1.IsConnected Then
            Motor1.SetCtrlOff = True
            thrMotor1.Join()
            Thread.Sleep(50)
            thrMotor1 = New Thread(AddressOf Motor1.CtrlMotor)
            Motor1.IsConnected = False
            lblMonitor1.Text = "(Not Connected)" : lblMonitor1.BackColor = LABEL_MONITOR_NOTCONNECT_COLOR
        End If
        'Diconnecting From Motor2 And Aborting the thread and generating a new thread for another connection
        If Motor2.IsConnected Then
            Motor2.SetCtrlOff = True
            thrMotor2.Join()
            Thread.Sleep(50)
            thrMotor2 = New Thread(AddressOf Motor2.CtrlMotor)
            Motor2.IsConnected = False
            lblMonitor2.Text = "(Not Connected)" : lblMonitor2.BackColor = LABEL_MONITOR_NOTCONNECT_COLOR
        End If
        'Diconnecting From Motor3 And Aborting the thread and generating a new thread for another connection
        If Motor3.IsConnected Then
            Motor3.SetCtrlOff = True
            thrMotor3.Join()
            Thread.Sleep(50)
            thrMotor3 = New Thread(AddressOf Motor3.CtrlMotor)
            Motor3.IsConnected = False
            lblMonitor3.Text = "(Not Connected)" : lblMonitor3.BackColor = LABEL_MONITOR_NOTCONNECT_COLOR
        End If

        boolAnyConnectedMotor = False

        lblStatusBar1.Text = "Disconnected from all"
        lblStatusBar1.ForeColor = Color.Black


        frmControl.UpdateControls()
        frmChild.EnableOrDisableControls()
    End Sub
    Private Sub lblMonitor_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
        Select Case CType(sender, ToolStripItem).Name
            Case "hstInfo1" : enmActiveMonitor = 1
            Case "hstInfo2" : enmActiveMonitor = 2
            Case "hstInfo3" : enmActiveMonitor = 3
        End Select
    End Sub
    Private Sub SetLblMonitorText(ByVal lblMonitor As ToolStripItem,
                                  ByVal Motor As SerialMotor,
                                  ByVal enmMonitor As MonitorItems)
        If Motor.IsConnected Then


            Select Case enmMonitor
                Case MonitorItems.Angle
                    lblMonitor.Text = String.Format("Angle : {0:#000.00}", Motor.feedbackAngle)
                Case MonitorItems.Angularvelocity
                    lblMonitor.Text = String.Format("Velocity : {0:#000.00} rpm", Motor.feedbackAccurateSpeed)
                Case MonitorItems.LinearspeedMPS
                    lblMonitor.Text = String.Format("Speed : {0:#000.00} m/s", Motor.feedbackAccurateSpeedMS)
                Case MonitorItems.LinearspeedKMPH
                    lblMonitor.Text = String.Format("Speed : {0:#000.00} km/h", Motor.feedbackAccurateSpeedKMH)
                Case MonitorItems.Torque
                    lblMonitor.Text = String.Format("Torque : {0:#00.00}", Motor.feedbackTorque)
                Case MonitorItems.EncoderPulse
                    lblMonitor.Text = String.Format("Pulse : {0}", Motor.feedbackAbsoluteRotatingPulse)
                Case MonitorItems.FeedbackData
                    lblMonitor.Text = String.Format("Data : {0}", Motor.feedbackData)
                Case MonitorItems.TotalErrors
                    lblMonitor.Text = String.Format("Total Erros : {0}", Motor.TotalErrors)
            End Select
        Else
            lblMonitor.Text = "(Not Connected)"
        End If
    End Sub
    Private Sub MnuPopupClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MSToolStripMenuItem.Click, KMHToolStripMenuItem.Click, AngularSpeedToolStripMenuItem.Click, AngleToolStripMenuItem.Click, TotalErrorsToolStripMenuItem.Click, FeedbackDataToolStripMenuItem.Click, EncoderPulseToolStripMenuItem.Click, ActualTorqueToolStripMenuItem.Click
        Select Case enmActiveMonitor
            Case 1
                enmMonitor1 = CInt(CType(sender, ToolStripMenuItem).Tag)
                SetLblMonitorText(lblMonitor1, Motor1, enmMonitor1)
            Case 2
                enmMonitor2 = CInt(CType(sender, ToolStripMenuItem).Tag)
                SetLblMonitorText(lblMonitor2, Motor2, enmMonitor2)
            Case 3
                enmMonitor3 = CInt(CType(sender, ToolStripMenuItem).Tag)
                SetLblMonitorText(lblMonitor3, Motor3, enmMonitor3)
        End Select

    End Sub

    Private Sub OptionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionsToolStripMenuItem.Click
        frmOptions.ShowDialog(Me)

    End Sub
End Class
