Public Class frmChild

    Dim SelectedMenuItem(0 To 8) As String

    Private Sub frmChild_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        InitToolStrips(True)
    End Sub

    Private Sub ChildMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        InitToolStrips()

    End Sub

    Private Sub chkMonitor3_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMonitor3.CheckStateChanged, chkMonitor2.CheckStateChanged, chkMonitor1.CheckStateChanged
        Select Case CType(sender, CheckBox).Name
            Case "chkMonitor1"
                tlpMonitor1.Enabled = Not tlpMonitor1.Enabled
            Case "chkMonitor2"
                tlpMonitor2.Enabled = Not tlpMonitor2.Enabled
            Case "chkMonitor3"
                tlpMonitor3.Enabled = Not tlpMonitor3.Enabled
        End Select
    End Sub

    Protected Friend Sub EnableOrDisableControls()
        If boolAnyConnectedMotor Then

            'Enabling Monitor Groups
            If Motor1.IsConnected Then grpMonitor1.Enabled = True
            If Motor2.IsConnected Then grpMonitor2.Enabled = True
            If Motor3.IsConnected Then grpMonitor3.Enabled = True
        Else

            'Disabling Monitor Groups
            grpMonitor1.Enabled = False
            grpMonitor2.Enabled = False
            grpMonitor3.Enabled = False
        End If
    End Sub
    Protected Friend Sub UpdateMonitors()
        If chkMonitor1.Checked Then
            txtMonAngle1.Text = String.Format("{0:#000.00}", Motor1.feedbackAngle)
            txtMonVelocity1.Text = String.Format("{0:#000.00}", Motor1.feedbackAccurateSpeed)
            txtMonSpdMS1.Text = String.Format("{0:#000.00}", Motor1.feedbackAccurateSpeedMS)
            txtMonSpdKH1.Text = String.Format("{0:#000.00}", Motor1.feedbackAccurateSpeedKMH)
            txtMonTorque1.Text = String.Format("{0:#00.00}", Motor1.feedbackTorque)
            txtMonPulse1.Text = String.Format("{0}", Motor1.feedbackAbsoluteRotatingPulse)
            txtMonData1.Text = String.Format("{0}", Motor1.feedbackData)
            txtMonError1.Text = String.Format("{0}", Motor1.TotalErrors)
        End If
        If chkMonitor2.Checked Then
            txtMonAngle2.Text = String.Format("{0:#000.00}", Motor2.feedbackAngle)
            txtMonVelocity2.Text = String.Format("{0:#000.00}", Motor2.feedbackAccurateSpeed)
            txtMonSpdMS2.Text = String.Format("{0:#000.00}", Motor2.feedbackAccurateSpeedMS)
            txtMonSpdKH2.Text = String.Format("{0:#000.00}", Motor2.feedbackAccurateSpeedKMH)
            txtMonTorque2.Text = String.Format("{0:#00.00}", Motor2.feedbackTorque)
            txtMonPulse2.Text = String.Format("{0}", Motor2.feedbackAbsoluteRotatingPulse)
            txtMonData2.Text = String.Format("{0}", Motor2.feedbackData)
            txtMonError2.Text = String.Format("{0}", Motor2.TotalErrors)
        End If
        If chkMonitor3.Checked Then
            txtMonAngle3.Text = String.Format("{0:#000.00}", Motor3.feedbackAngle)
            txtMonVelocity3.Text = String.Format("{0:#000.00}", Motor3.feedbackAccurateSpeed)
            txtMonSpdMS3.Text = String.Format("{0:#000.00}", Motor3.feedbackAccurateSpeedMS)
            txtMonSpdKH3.Text = String.Format("{0:#000.00}", Motor3.feedbackAccurateSpeedKMH)
            txtMonTorque3.Text = String.Format("{0:#00.00}", Motor3.feedbackTorque)
            txtMonPulse3.Text = String.Format("{0}", Motor3.feedbackAbsoluteRotatingPulse)
            txtMonData3.Text = String.Format("{0}", Motor3.feedbackData)
            txtMonError3.Text = String.Format("{0}", Motor3.TotalErrors)
        End If
    End Sub

    Protected Friend Sub UpdateCharts()
        Dim Motor As SerialMotor
        '8888888888888888888888888888888888888888888
        If Serie1Area1.Checked Then
            Motor = GetMotor(Area1Serie1Motor)
            UpdateSeries(Chart1, 0, Motor)
        End If
        If Serie2Area1.Checked Then
            Motor = GetMotor(Area1Serie2Motor)
            UpdateSeries(Chart1, 1, Motor)
        End If
        If Serie3Area1.Checked Then
            Motor = GetMotor(Area1Serie3Motor)
            UpdateSeries(Chart1, 2, Motor)
        End If
        '88888888888888888888888888888888888888888888
        If Serie1Area2.Checked Then
            Motor = GetMotor(Area2Serie1Motor)
            UpdateSeries(Chart1, 3, Motor)
        End If
        If Serie2Area2.Checked Then
            Motor = GetMotor(Area2Serie2Motor)
            UpdateSeries(Chart1, 4, Motor)
        End If
        If Serie3Area2.Checked Then
            Motor = GetMotor(Area2Serie3Motor)
            UpdateSeries(Chart1, 5, Motor)
        End If
        '888888888888888888888888888888888888888888888888888
        If Serie1Area3.Checked Then
            Motor = GetMotor(Area3Serie1Motor)
            UpdateSeries(Chart1, 6, Motor)
        End If
        If Serie2Area3.Checked Then
            Motor = GetMotor(Area3Serie2Motor)
            UpdateSeries(Chart1, 7, Motor)
        End If
        If Serie3Area3.Checked Then
            Motor = GetMotor(Area3Serie3Motor)
            UpdateSeries(Chart1, 8, Motor)
        End If
    End Sub
    Private Function GetMotor(ByVal cmb As ToolStripComboBox) As SerialMotor
        If cmb.SelectedIndex = 0 Then
            GetMotor = Motor1
        ElseIf cmb.SelectedIndex = 1 Then
            GetMotor = Motor2
        Else
            GetMotor = Motor3
        End If
    End Function
    Private Sub UpdateSeries(ByVal Cht As DataVisualization.Charting.Chart, ByVal i As Integer, ByVal Motor As SerialMotor)
        Dim Y As Single
        Static TableTitle(0 To 2) As String
        Select Case SelectedMenuItem(i)
            Case "None"
            Case "Angle"
                Y = Motor.feedbackAngle
                If TableTitle(0) <> "Angle (deg)" And i < 3 Then TableTitle(0) = "Angle (deg)"
                If TableTitle(1) <> "Angle (deg)" And i >= 3 And i < 6 Then TableTitle(1) = "Angle (deg)"
                If TableTitle(2) <> "Angle (deg)" And i >= 6 Then TableTitle(2) = "Angle (deg)"
            Case "Angular Velocity"
                Y = Motor.feedbackSpeed
                If TableTitle(0) <> "Velocity (rpm)" And i < 3 Then TableTitle(0) = "Velocity (rpm)"
                If TableTitle(1) <> "Velocity (rpm)" And i >= 3 And i < 6 Then TableTitle(1) = "Velocity (rpm)"
                If TableTitle(2) <> "Velocity (rpm)" And i >= 6 Then TableTitle(2) = "Velocity (rpm)"
            Case "Accurate Angular Velocity"
                Y = Motor.feedbackAccurateSpeed
                If TableTitle(0) <> "Velocity (rpm)" And i < 3 Then TableTitle(0) = "Velocity (rpm)"
                If TableTitle(1) <> "Velocity (rpm)" And i >= 3 And i < 6 Then TableTitle(1) = "Velocity (rpm)"
                If TableTitle(2) <> "Velocity (rpm)" And i >= 6 Then TableTitle(2) = "Velocity (rpm)"
            Case "Speed (m/s)"
                Y = Motor.feedbackAccurateSpeedMS
                If TableTitle(0) <> "Speed (m/s)" And i < 3 Then TableTitle(0) = "Speed (m/s)"
                If TableTitle(1) <> "Speed (m/s)" And i >= 3 And i < 6 Then TableTitle(1) = "Speed (m/s)"
                If TableTitle(2) <> "Speed (m/s)" And i >= 6 Then TableTitle(2) = "Speed (m/s)"
            Case "Speed (Km/h)"
                Y = Motor.feedbackAccurateSpeedKMH
                If TableTitle(0) <> "Speed (km/h)" And i < 3 Then TableTitle(0) = "Speed (km/h)"
                If TableTitle(1) <> "Speed (km/h)" And i >= 3 And i < 6 Then TableTitle(1) = "Speed (km/h)"
                If TableTitle(2) <> "Speed (km/h)" And i >= 6 Then TableTitle(2) = "Speed (km/h)"
            Case "Torque (%)"
                Y = Motor.feedbackTorque
                If TableTitle(0) <> "Torque (%)" And i < 3 Then TableTitle(0) = "Torque (%)"
                If TableTitle(1) <> "Torque (%)" And i >= 3 And i < 6 Then TableTitle(1) = "Torque (%)"
                If TableTitle(2) <> "Torque (%)" And i >= 6 Then TableTitle(2) = "Torque (%)"
            Case "Total Errors"
                Y = Motor.TotalErrors
                If TableTitle(0) <> "Total Errors" And i < 3 Then TableTitle(0) = "Total Errors"
                If TableTitle(1) <> "Total Errors" And i >= 3 And i < 6 Then TableTitle(1) = "Total Errors"
                If TableTitle(2) <> "Total Errors" And i >= 6 Then TableTitle(2) = "Total Errors"
            Case "Slip"
                Y = Motor.feedbackSlip
                If TableTitle(0) <> "Slip" And i < 3 Then TableTitle(0) = "Slip"
                If TableTitle(1) <> "Slip" And i >= 3 And i < 6 Then TableTitle(1) = "Slip"
                If TableTitle(2) <> "Slip" And i >= 6 Then TableTitle(2) = "Slip"
        End Select

        If i < 3 And Cht.ChartAreas(0).AxisY.Title <> TableTitle(0) Then Cht.ChartAreas(0).AxisY.Title = TableTitle(0)
        If i >= 3 And i < 6 And Cht.ChartAreas(1).AxisY.Title <> TableTitle(1) Then Cht.ChartAreas(1).AxisY.Title = TableTitle(1)
        If i >= 6 And Cht.ChartAreas(2).AxisY.Title <> TableTitle(2) Then Cht.ChartAreas(2).AxisY.Title = TableTitle(2)
        Cht.Series(i).Points.AddXY(DateTime.Now.ToString("mm:ss.ff"),
                                      Y)
        'Chart1.Series(0).Points.AddXY(DateTime.Now.ToString("mm:ss.ff"),
        '                              Motor1.feedbackSpeed)
        'Chart1.Series(1).Points.AddXY(DateTime.Now.ToString("mm:ss.ff"),
        '                              Motor1.feedbackAccurateSpeed)
        Cht.Invalidate()
    End Sub
    Private Sub ToolStripLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSLDown.Click, TSLUp.Click
        Select Case CType(sender, ToolStripLabel).Name
            Case "TSLDown"
                Panel1.Height += 100
                Chart1.Height += 100
                Panel2.Top += 100
                Chart1.Dock = DockStyle.Top
                Chart1.Invalidate()
            Case "TSLUp"
                Panel1.Height -= 100
                Chart1.Height -= 100
                Panel2.Top -= 100
                Chart1.Dock = DockStyle.Top
                Chart1.Invalidate()
        End Select


    End Sub



    Private Sub AreaVisible_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Area1Visible.Click, Area2Visible.Click, Area3Visible.Click
        Dim MenuItem As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
        Select Case UCase(MenuItem.Name)
            Case "AREA1VISIBLE"
                If MenuItem.Checked Then
                    MenuItem.Checked = False
                    Chart1.ChartAreas(0).Visible = False
                Else
                    MenuItem.Checked = True
                    Chart1.ChartAreas(0).Visible = True
                End If
            Case "AREA2VISIBLE"
                If MenuItem.Checked Then
                    MenuItem.Checked = False
                    Chart1.ChartAreas(1).Visible = False
                Else
                    MenuItem.Checked = True
                    Chart1.ChartAreas(1).Visible = True
                End If
            Case "AREA3VISIBLE"
                If MenuItem.Checked Then
                    MenuItem.Checked = False
                    Chart1.ChartAreas(2).Visible = False
                Else
                    MenuItem.Checked = True
                    Chart1.ChartAreas(2).Visible = True
                End If
        End Select
    End Sub

    Private Sub InitToolStrips(Optional ByVal Closing As Boolean = False)
        If Not Closing Then
            Area1Serie1Motor.SelectedIndex = My.Settings.Area1Serie1Motor
            Area1Serie2Motor.SelectedIndex = My.Settings.Area1Serie2Motor
            Area1Serie3Motor.SelectedIndex = My.Settings.Area1Serie3Motor

            Area2Serie1Motor.SelectedIndex = My.Settings.Area2Serie1Motor
            Area2Serie2Motor.SelectedIndex = My.Settings.Area2Serie2Motor
            Area2Serie3Motor.SelectedIndex = My.Settings.Area2Serie3Motor

            Area3Serie1Motor.SelectedIndex = My.Settings.Area3Serie1Motor
            Area3Serie2Motor.SelectedIndex = My.Settings.Area3Serie2Motor
            Area3Serie3Motor.SelectedIndex = My.Settings.Area3Serie3Motor
        Else
            My.Settings.Area1Serie1Motor = Area1Serie1Motor.SelectedIndex
            My.Settings.Area1Serie2Motor = Area1Serie2Motor.SelectedIndex
            My.Settings.Area1Serie3Motor = Area1Serie3Motor.SelectedIndex

            My.Settings.Area2Serie1Motor = Area2Serie1Motor.SelectedIndex
            My.Settings.Area2Serie2Motor = Area2Serie2Motor.SelectedIndex
            My.Settings.Area2Serie3Motor = Area2Serie3Motor.SelectedIndex

            My.Settings.Area3Serie1Motor = Area3Serie1Motor.SelectedIndex
            My.Settings.Area3Serie2Motor = Area3Serie2Motor.SelectedIndex
            My.Settings.Area3Serie3Motor = Area3Serie3Motor.SelectedIndex
        End If

    End Sub


    Private Sub Area1SerieItems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles Area1Serie1Torque.Click, Area1Serie1SpeedMS.Click, Area1Serie1SpeedKMH.Click, Area1Serie1None.Click, Area1Serie1Errors.Click, Area1Serie1AV.Click, Area1Serie1Angle.Click, Area1Serie1AAV.Click, Area1Serie2Torque.Click,
        Area1Serie2SpeedMS.Click, Area1Serie2SpeedKMH.Click, Area1Serie2None.Click, Area1Serie2Errors.Click, Area1Serie2AV.Click, Area1Serie2Angle.Click, Area1Serie2AAV.Click, Serie3Area1.Click, Area3Serie3Torque.Click, Area3Serie3SpeedMS.Click, Area3Serie3SpeedKMH.Click, Area3Serie3None.Click, Area3Serie3Errors.Click, Area3Serie3AV.Click, Area3Serie3Angle.Click, Area3Serie3AAV.Click, Area3Serie1Torque.Click, Area3Serie1SpeedMS.Click, Area3Serie1SpeedKMH.Click, Area3Serie1None.Click, Area3Serie1Errors.Click, Area3Serie1AV.Click, Area3Serie1Angle.Click, Area3Serie1AAV.Click, Area2Serie3Torque.Click, Area2Serie3SpeedMS.Click, Area2Serie3SpeedKMH.Click, Area2Serie3None.Click, Area2Serie3Errors.Click, Area2Serie3AV.Click, Area2Serie3Angle.Click, Area2Serie3AAV.Click, Area2Serie2Torque.Click, Area2Serie2SpeedMS.Click, Area2Serie2SpeedKMH.Click, Area2Serie2None.Click, Area2Serie2Errors.Click, Area2Serie2AV.Click, Area2Serie2Angle.Click, Area2Serie2AAV.Click, Area2Serie1Torque.Click, Area2Serie1SpeedMS.Click, Area2Serie1SpeedKMH.Click, Area2Serie1None.Click, Area2Serie1Errors.Click, Area2Serie1AV.Click, Area2Serie1Angle.Click, Area2Serie1AAV.Click, Area1Serie3Torque.Click, Area1Serie3SpeedMS.Click, Area1Serie3SpeedKMH.Click, Area1Serie3None.Click, Area1Serie3Errors.Click, Area1Serie3AV.Click, Area1Serie3Angle.Click, Area1Serie3AAV.Click, ToolStripMenuItem12.Click, Area3Serie2Torque.Click, Area3Serie2SpeedMS.Click, Area3Serie2SpeedKMH.Click, Area3Serie2None.Click, Area3Serie2AV.Click, Area3Serie2Angle.Click, Area3Serie2AAV.Click,
        Area1Serie1Slip.Click, Area1Serie2Slip.Click, Area1Serie3Slip.Click, Area2Serie1Slip.Click, Area2Serie2Slip.Click, Area2Serie3Slip.Click,
        Area3Serie1Slip.Click, Area3Serie2Slip.Click, Area3Serie3Slip.Click




        Dim MenuItem As ToolStripMenuItem = CType(sender, ToolStripMenuItem)

        For Each a As Object In ToolStrip1.Items
            If a.GetType = GetType(ToolStripDropDownButton) Then
                For Each b As Object In a.DropDownItems
                    If b.GetType = GetType(ToolStripMenuItem) Then
                        For Each c As Object In b.DropDownItems
                            If c.GetType = GetType(ToolStripMenuItem) And c.Tag = MenuItem.Tag Then
                                c.Checked = False
                                If MenuItem.Text <> "None" Then b.Checked = True Else b.Checked = False
                            End If


                        Next

                    End If
                Next
            End If
        Next
        MenuItem.Checked = True
        Select Case MenuItem.Tag
            Case "Area1Serie1"
                SelectedMenuItem(0) = MenuItem.Text
            Case "Area1Serie2"
                SelectedMenuItem(1) = MenuItem.Text
            Case "Area1Serie3"
                SelectedMenuItem(2) = MenuItem.Text
            Case "Area2Serie1"
                SelectedMenuItem(3) = MenuItem.Text
            Case "Area2Serie2"
                SelectedMenuItem(4) = MenuItem.Text
            Case "Area2Serie3"
                SelectedMenuItem(5) = MenuItem.Text
            Case "Area3Serie1"
                SelectedMenuItem(6) = MenuItem.Text
            Case "Area3Serie2"
                SelectedMenuItem(7) = MenuItem.Text
            Case "Area3Serie3"
                SelectedMenuItem(8) = MenuItem.Text
        End Select
    End Sub

    Private Sub TSBChart1Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSBChart1Clear.Click
        For i = 0 To 8
            Chart1.Series(i).Points.Clear()
        Next

    End Sub


End Class