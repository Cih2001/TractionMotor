﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.235
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "My.Settings Auto-Save Functionality"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(ByVal sender As Global.System.Object, ByVal e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
        
        Public Shared ReadOnly Property [Default]() As MySettings
            Get
                
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
                Return defaultInstance
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0, 0")>  _
        Public Property ControlPosition() As Global.System.Drawing.Point
            Get
                Return CType(Me("ControlPosition"),Global.System.Drawing.Point)
            End Get
            Set
                Me("ControlPosition") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0, 0")>  _
        Public Property ChildMainLocation() As Global.System.Drawing.Point
            Get
                Return CType(Me("ChildMainLocation"),Global.System.Drawing.Point)
            End Get
            Set
                Me("ChildMainLocation") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("484, 523")>  _
        Public Property ChildMainSize() As Global.System.Drawing.Size
            Get
                Return CType(Me("ChildMainSize"),Global.System.Drawing.Size)
            End Get
            Set
                Me("ChildMainSize") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("COM4")>  _
        Public Property Motor1Port() As String
            Get
                Return CType(Me("Motor1Port"),String)
            End Get
            Set
                Me("Motor1Port") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("9600")>  _
        Public Property Motor1BaudRate() As Integer
            Get
                Return CType(Me("Motor1BaudRate"),Integer)
            End Get
            Set
                Me("Motor1BaudRate") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property Motor1Parity() As Integer
            Get
                Return CType(Me("Motor1Parity"),Integer)
            End Get
            Set
                Me("Motor1Parity") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("8")>  _
        Public Property Motor1DataBits() As Integer
            Get
                Return CType(Me("Motor1DataBits"),Integer)
            End Get
            Set
                Me("Motor1DataBits") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("1")>  _
        Public Property Motor1StopBits() As Integer
            Get
                Return CType(Me("Motor1StopBits"),Integer)
            End Get
            Set
                Me("Motor1StopBits") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("COM5")>  _
        Public Property Motor2Port() As String
            Get
                Return CType(Me("Motor2Port"),String)
            End Get
            Set
                Me("Motor2Port") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("9600")>  _
        Public Property Motor2BaudRate() As Integer
            Get
                Return CType(Me("Motor2BaudRate"),Integer)
            End Get
            Set
                Me("Motor2BaudRate") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property Motor2Parity() As Integer
            Get
                Return CType(Me("Motor2Parity"),Integer)
            End Get
            Set
                Me("Motor2Parity") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("8")>  _
        Public Property Motor2DataBits() As Integer
            Get
                Return CType(Me("Motor2DataBits"),Integer)
            End Get
            Set
                Me("Motor2DataBits") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("1")>  _
        Public Property Motor2StopBits() As Integer
            Get
                Return CType(Me("Motor2StopBits"),Integer)
            End Get
            Set
                Me("Motor2StopBits") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("COM6")>  _
        Public Property Motor3Port() As String
            Get
                Return CType(Me("Motor3Port"),String)
            End Get
            Set
                Me("Motor3Port") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("9600")>  _
        Public Property Motor3BaudRate() As Integer
            Get
                Return CType(Me("Motor3BaudRate"),Integer)
            End Get
            Set
                Me("Motor3BaudRate") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property Motor3Parity() As Integer
            Get
                Return CType(Me("Motor3Parity"),Integer)
            End Get
            Set
                Me("Motor3Parity") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("8")>  _
        Public Property Motor3DataBits() As Integer
            Get
                Return CType(Me("Motor3DataBits"),Integer)
            End Get
            Set
                Me("Motor3DataBits") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("1")>  _
        Public Property Motor3StopBits() As Integer
            Get
                Return CType(Me("Motor3StopBits"),Integer)
            End Get
            Set
                Me("Motor3StopBits") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("110")>  _
        Public Property Motor1Diameter() As Single
            Get
                Return CType(Me("Motor1Diameter"),Single)
            End Get
            Set
                Me("Motor1Diameter") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Wheel1")>  _
        Public Property Motor1Name() As String
            Get
                Return CType(Me("Motor1Name"),String)
            End Get
            Set
                Me("Motor1Name") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("110")>  _
        Public Property Motor2Diameter() As Single
            Get
                Return CType(Me("Motor2Diameter"),Single)
            End Get
            Set
                Me("Motor2Diameter") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Wheel2")>  _
        Public Property Motor2Name() As String
            Get
                Return CType(Me("Motor2Name"),String)
            End Get
            Set
                Me("Motor2Name") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("110")>  _
        Public Property Motor3Diameter() As Single
            Get
                Return CType(Me("Motor3Diameter"),Single)
            End Get
            Set
                Me("Motor3Diameter") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Wheel3")>  _
        Public Property Motor3Name() As String
            Get
                Return CType(Me("Motor3Name"),String)
            End Get
            Set
                Me("Motor3Name") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property Area1Serie1Motor() As Integer
            Get
                Return CType(Me("Area1Serie1Motor"),Integer)
            End Get
            Set
                Me("Area1Serie1Motor") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property Area1Serie2Motor() As Integer
            Get
                Return CType(Me("Area1Serie2Motor"),Integer)
            End Get
            Set
                Me("Area1Serie2Motor") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property Area1Serie3Motor() As Integer
            Get
                Return CType(Me("Area1Serie3Motor"),Integer)
            End Get
            Set
                Me("Area1Serie3Motor") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("1")>  _
        Public Property Area2Serie1Motor() As Integer
            Get
                Return CType(Me("Area2Serie1Motor"),Integer)
            End Get
            Set
                Me("Area2Serie1Motor") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("1")>  _
        Public Property Area2Serie2Motor() As Integer
            Get
                Return CType(Me("Area2Serie2Motor"),Integer)
            End Get
            Set
                Me("Area2Serie2Motor") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("1")>  _
        Public Property Area2Serie3Motor() As Integer
            Get
                Return CType(Me("Area2Serie3Motor"),Integer)
            End Get
            Set
                Me("Area2Serie3Motor") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("2")>  _
        Public Property Area3Serie1Motor() As Integer
            Get
                Return CType(Me("Area3Serie1Motor"),Integer)
            End Get
            Set
                Me("Area3Serie1Motor") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("2")>  _
        Public Property Area3Serie2Motor() As Integer
            Get
                Return CType(Me("Area3Serie2Motor"),Integer)
            End Get
            Set
                Me("Area3Serie2Motor") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("2")>  _
        Public Property Area3Serie3Motor() As Integer
            Get
                Return CType(Me("Area3Serie3Motor"),Integer)
            End Get
            Set
                Me("Area3Serie3Motor") = value
            End Set
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.TractionMotorCtrl.My.MySettings
            Get
                Return Global.TractionMotorCtrl.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
