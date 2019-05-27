Imports System.IO.Ports
Imports System.Threading
Imports System.Text

Class SerialMotor
    Protected Friend Enum Direction
        CW = 0 : CCW = 1
    End Enum
#Region "Properties"
    Property strRtnText As String
    ''' <summary>
    ''' Speed command in rpm
    ''' </summary>
    Property SetSpeed As Single = 0
    ''' <summary>
    ''' Set True for Turning off the Ctrl
    ''' </summary>
    Property SetCtrlOff As Boolean = False
    ''' <summary>
    ''' For Changing The Direction of Rotation
    ''' </summary>
    Property SetRotateDirection As Direction = Direction.CW
    Property MotorName As String
    Property feedbackData As String
    Property feedbackSpeed As Single
    Property feedbackAbsoluteRotatingPulse As Int64
    Property LastAbsoluteRotatingPulse As Int64
    Property FirstAbsoluteRotatingPulse As Int64 = 0
    Property TimeAbsoluteRotatingPulse As DateTime
    Property TimeLastAbsoluteRotatingPulse As DateTime
    Property TimeFirstAbsoluteRotatingPulse As DateTime
    Property TotalErrors As Integer = 0
    Property feedbackExternalVoltage As Single
    Property feedbackMainLoopVoltage As Single
    Property feedbackTorque As Single
    Property COMPort As String = "COM4"
    Property BaudRate As Integer = 9600
    Property Parity As Parity = Parity.None
    Property DataBit As Integer = 8
    Property StopBits As StopBits = StopBits.One
    Property IsConnected As Boolean = False
    Property feedbackAnswer As String = vbNullString
    Property GearBoxRatio As Single = 1
    ''' <summary>
    ''' Wheel Diameter in Centimeter
    ''' </summary>
    Property Diameter As Single = 110
    ''' <summary>
    ''' Speed in rpm Computed from counting pulse numbers
    ''' </summary>
    ReadOnly Property feedbackAccurateSpeed As Single
        Get
            Dim Pulse As Int64 = feedbackAbsoluteRotatingPulse
            Dim LastPulse As Int64 = LastAbsoluteRotatingPulse
            Dim PulseTime As DateTime = TimeAbsoluteRotatingPulse
            Dim LastPulseTime As DateTime = TimeLastAbsoluteRotatingPulse

            If CType((PulseTime - LastPulseTime), TimeSpan).TotalMilliseconds > 100 Then
                TmpSpeed = (Pulse - LastPulse) * 6 /
                    CType((PulseTime - LastPulseTime), TimeSpan).TotalMilliseconds
            End If
            Return -TmpSpeed * GearBoxRatio
        End Get
    End Property
    ReadOnly Property feedbackAccurateSpeedMS As Single
        Get
            Return (feedbackAccurateSpeed * 2 * Math.PI / 60) * (Diameter / 200)
        End Get
    End Property
    ReadOnly Property feedbackAccurateSpeedKMH As Single
        Get
            Return (feedbackAccurateSpeed * 2 * Math.PI / 60) * 3.6 * (Diameter / 200)
        End Get
    End Property

    ReadOnly Property feedbackAngle As Double
        Get
            Return (-feedbackAbsoluteRotatingPulse + FirstAbsoluteRotatingPulse) * 360 * GearBoxRatio / 10000
        End Get
    End Property
    ReadOnly Property SpeedCommand As String
        Get
            Return LastSpeedCmd
        End Get
    End Property
    ReadOnly Property feedbackSlip As Single
        Get
            Dim TrainSpeed As Single = frmControl.nudSpeed.Value * Math.Sign(feedbackAccurateSpeed)
            Select Case frmControl.cmbSpeed.SelectedIndex
                Case 0
                    Return (feedbackAccurateSpeed - TrainSpeed) / TrainSpeed
                Case 1
                    Return (feedbackAccurateSpeedMS - TrainSpeed) / TrainSpeed
                Case Else
                    Return (feedbackAccurateSpeedKMH - TrainSpeed) / TrainSpeed
            End Select

        End Get
    End Property
#End Region

    Dim SpeedCmd As New StringBuilder, LastSpeedCmd As String = vbNullString
    Dim i As Int64 = 0
    Dim Data As String = vbNullString
    Dim WithEvents SerialPort1 As New SerialPort()
    Dim LastRotationCommand As Direction
    Dim TmpSpeed As Double
    Dim strManualCommand As String = vbNullString
    ''' <summary>
    ''' This Method Will send a manual command to drive'
    ''' To Read the Answer use feedbackAnswer Property'
    ''' It Works Only when your mainLoop is started.
    ''' </summary>
    ''' <param name="cmd">Your Command to send</param>
    ''' <param name="AutoChecksum">Turn off if you dont want checksum Automaticlly</param>
    Protected Friend Sub SendCommand(ByVal cmd As String, Optional ByVal AutoChecksum As Boolean = True)
        If AutoChecksum Then
            strManualCommand = AddCheckSum(UCase(cmd))
        Else
            strManualCommand = UCase(cmd)
        End If
    End Sub
    Protected Friend Function TestConnection() As Boolean
        Dim IsOk As Boolean = False, OpendPort = False
        Dim strTmp As String = vbNullString
        Try
            If Not SerialPort1.IsOpen Then
                With SerialPort1
                    .PortName = COMPort
                    .BaudRate = BaudRate
                    .Parity = Parity
                    .StopBits = StopBits
                    .DataBits = DataBit
                End With
                SerialPort1.Open()
                OpendPort = True
            End If
            Thread.Sleep(20)
            SerialPort1.WriteLine(AddCheckSum("R6E4")) : Thread.Sleep(20)
            strTmp = SerialPort1.ReadExisting()
            If strTmp <> vbNullString Then IsOk = True
        Catch ex As Exception
            IsOk = False
        End Try
        Return IsOk
    End Function
    Protected Friend Sub CtrlMotor()
        'On Error Resume Next
        Dim tmp As String = vbNullString
        Dim i As Integer = 0

        If Not SerialPort1.IsOpen Then
            With SerialPort1
                .PortName = COMPort
                .BaudRate = BaudRate
                .Parity = Parity
                .StopBits = StopBits
                .DataBits = DataBit
            End With
            SerialPort1.Open()
        End If

        IsConnected = True : SetCtrlOff = False
        LastRotationCommand = SetRotateDirection
        SerialPort1.WriteLine(AddCheckSum("W60A0001")) : SerialPort1.ReadExisting()
        SerialPort1.WriteLine(AddCheckSum("W63E0001")) : SerialPort1.ReadExisting()
        SerialPort1.WriteLine(AddCheckSum("W5120000")) : Thread.Sleep(20) : SerialPort1.ReadExisting()
        Do
            i += 1
            'Sending Rotation Command
            If SetRotateDirection <> LastRotationCommand Then
                LastRotationCommand = SetRotateDirection
                If SetRotateDirection = Direction.CCW Then
                    SerialPort1.WriteLine(AddCheckSum("W5120001")) : Thread.Sleep(20) : SerialPort1.ReadExisting()
                Else
                    SerialPort1.WriteLine(AddCheckSum("W5120000")) : Thread.Sleep(20) : SerialPort1.ReadExisting()
                End If
            End If
            'Sending Speed Command
            SpeedCmd.Append("W536")
            SpeedCmd.Append(Conversion.Hex(SetSpeed * 5.47))
            SpeedCmd.Insert(4, "0", 4 - Conversion.Hex(SetSpeed * 5.47).Length)
            If SpeedCmd.ToString <> LastSpeedCmd Then SerialPort1.WriteLine(AddCheckSum(SpeedCmd.ToString)) : Thread.Sleep(20) : SerialPort1.ReadExisting()
            LastSpeedCmd = SpeedCmd.ToString
            SpeedCmd.Clear()

            'Reading Actual Speed
            SerialPort1.WriteLine(AddCheckSum("R6E4")) ': Thread.Sleep(20)
            Data = ReadSerial(7) 'SerialPort1.ReadExisting()
            feedbackData = Data
            If CheckCheckSum(Data) Then _
                feedbackSpeed = -GearBoxRatio * Convert.ToInt16(Mid(Data, 2, 4), 16) / 5.5 _
                Else TotalErrors += 1

            'Reading Rotation Pulse
            If i > 5 Then
                LastAbsoluteRotatingPulse = feedbackAbsoluteRotatingPulse
                TimeLastAbsoluteRotatingPulse = TimeAbsoluteRotatingPulse
                i = 0
            End If
            SerialPort1.WriteLine(AddCheckSum("L688")) ': Thread.Sleep(20)
            Data = ReadSerial(11) 'SerialPort1.ReadExisting()
            feedbackData = Data
            If CheckCheckSum(Data) Then
                tmp = Mid(Data, 6, 4) & Mid(Data, 2, 4)
                feedbackAbsoluteRotatingPulse = Convert.ToInt64(tmp, 16)
                TimeAbsoluteRotatingPulse = DateTime.Now

                If FirstAbsoluteRotatingPulse = 0 Then
                    FirstAbsoluteRotatingPulse = feedbackAbsoluteRotatingPulse
                    TimeFirstAbsoluteRotatingPulse = DateTime.Now
                End If
            Else : TotalErrors += 1
            End If

            'Readind Torque Commands
            SerialPort1.WriteLine(AddCheckSum("R9B6")) ': Thread.Sleep(20)
            Data = ReadSerial(7) 'SerialPort1.ReadExisting()
            feedbackData = Data
            If CheckCheckSum(Data) Then _
                feedbackTorque = Convert.ToInt16(Mid(Data, 2, 4), 16) / 50 _
                Else TotalErrors += 1

            'Sending and reading ManualCommand
            If strManualCommand <> vbNullString Then
                SerialPort1.WriteLine(strManualCommand)
                Select Case Left(strManualCommand, 1)
                    Case "W" : Data = ReadSerial(1)
                    Case "M" : Data = ReadSerial(1)
                    Case "R" : Data = ReadSerial(7)
                    Case "L" : Data = ReadSerial(11)
                End Select
                feedbackAnswer = Data
                strManualCommand = vbNullString
            End If
            If SetCtrlOff = True Then GoTo AbortThread

        Loop

AbortThread:
        SerialPort1.WriteLine(AddCheckSum("W5360000")) : feedbackData = SerialPort1.ReadExisting()
        SerialPort1.WriteLine(AddCheckSum("W63E0000")) : feedbackData = SerialPort1.ReadExisting()
        SerialPort1.WriteLine(AddCheckSum("W60A0000")) : feedbackData = SerialPort1.ReadExisting()
        SerialPort1.Close()
        SetCtrlOff = False
        IsConnected = False
        Thread.CurrentThread.Abort()
    End Sub





    Private Function ReadSerial(ByVal CharCount As Integer) As String
        Dim str As String = vbNullString, a As Char
        Try
            For i As Integer = 0 To CharCount - 1
                a = Chr(SerialPort1.ReadChar)
                str &= a
            Next
        Catch ex As Exception
            str = vbNullString
        End Try
        ReadSerial = str
    End Function
    Private Function AddCheckSum(ByVal str As String) As String
        Dim Sum As Long = 0
        If str <> vbNullString Then
            For i As Integer = 1 To Len(str)
                Sum += Asc(Mid(str, i, 1))
            Next
        End If

        AddCheckSum = str & Strings.Right(Conversion.Hex(Sum), 2)

    End Function
    Private Function CheckCheckSum(ByVal str As String) As Boolean
        Dim CS As String
        If Len(str) > 2 Then
            CS = Right(str, 2)
            str = Left(str, Len(str) - 2)

            Dim Sum As Long = 0

            For i As Integer = 1 To Len(str)
                Sum += Asc(Mid(str, i, 1))
            Next

            If Right$(UCase(CStr(Conversion.Hex(Sum))), 2) Like CS Then CheckCheckSum = True Else CheckCheckSum = False


        Else : CheckCheckSum = False : End If

    End Function
End Class
