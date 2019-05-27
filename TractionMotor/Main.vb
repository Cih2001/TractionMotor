Imports System.Threading

Module Main
    Enum MonitorItems
        Angle = 0 : LinearspeedMPS = 1 : Angularvelocity = 2 : LinearspeedKMPH = 3
        Torque = 4 : EncoderPulse = 5 : FeedbackData = 6 : TotalErrors = 7
    End Enum
    Enum UnitNames
        NoUnit = 0 : rpm = 1 : mps = 2 : kmh = 3
    End Enum

    Public Motor1 As New SerialMotor, thrMotor1 As New Thread(AddressOf Motor1.CtrlMotor)
    Public Motor2 As New SerialMotor, thrMotor2 As New Thread(AddressOf Motor2.CtrlMotor)
    Public Motor3 As New SerialMotor, thrMotor3 As New Thread(AddressOf Motor3.CtrlMotor)

    Public boolAnyConnectedMotor As Boolean = False
    Public pblnLoginPassed As Boolean = False
    ''' <summary>
    ''' Set Speed of the test for all modes in rpm
    ''' </summary>
    Public psngSetSpeed As Single = 100
    Public penmSpeedUnit As UnitNames = UnitNames.rpm

    Public pblnSimulating As Boolean = False
    Public Sub InitMotors()
        With Motor1
            .COMPort = My.Settings.Motor1Port
            .BaudRate = My.Settings.Motor1BaudRate
            .Parity = My.Settings.Motor1Parity
            .DataBit = My.Settings.Motor1DataBits
            .StopBits = My.Settings.Motor1StopBits
            .MotorName = My.Settings.Motor1Name
            .Diameter = My.Settings.Motor1Diameter
        End With

        With Motor2
            .COMPort = My.Settings.Motor2Port
            .BaudRate = My.Settings.Motor2BaudRate
            .Parity = My.Settings.Motor2Parity
            .DataBit = My.Settings.Motor2DataBits
            .StopBits = My.Settings.Motor2StopBits
            .MotorName = My.Settings.Motor2Name
            .Diameter = My.Settings.Motor2Diameter
        End With

        With Motor3
            .COMPort = My.Settings.Motor3Port
            .BaudRate = My.Settings.Motor3BaudRate
            .Parity = My.Settings.Motor3Parity
            .DataBit = My.Settings.Motor3DataBits
            .StopBits = My.Settings.Motor3StopBits
            .MotorName = My.Settings.Motor3Name
            .Diameter = My.Settings.Motor3Diameter
        End With
    End Sub
    Public Sub SaveSettings()
        With Motor1
            My.Settings.Motor1Port = .COMPort
            My.Settings.Motor1BaudRate = .BaudRate
            My.Settings.Motor1Parity = .Parity
            My.Settings.Motor1DataBits = .DataBit
            My.Settings.Motor1StopBits = .StopBits
            My.Settings.Motor1Diameter = .Diameter
            My.Settings.Motor1Name = .MotorName
        End With
        With Motor2
            My.Settings.Motor2Port = .COMPort
            My.Settings.Motor2BaudRate = .BaudRate
            My.Settings.Motor2Parity = .Parity
            My.Settings.Motor2DataBits = .DataBit
            My.Settings.Motor2StopBits = .StopBits
            My.Settings.Motor2Diameter = .Diameter
            My.Settings.Motor2Name = .MotorName
        End With
        With Motor3
            My.Settings.Motor3Port = .COMPort
            My.Settings.Motor3BaudRate = .BaudRate
            My.Settings.Motor3Parity = .Parity
            My.Settings.Motor3DataBits = .DataBit
            My.Settings.Motor3StopBits = .StopBits
            My.Settings.Motor3Diameter = .Diameter
            My.Settings.Motor3Name = .MotorName
        End With

        My.Settings.Save()

    End Sub
End Module
