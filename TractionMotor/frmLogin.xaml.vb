Imports System.Windows.Media.Animation
Imports System.Windows.Input
Imports System.Threading
Imports System.Text
Imports System.Windows.Threading

Class frmLogin
    Dim blnLogin As Boolean = False
    Private Sub poisen_Button_Loaded(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles poisen_Button.Loaded

    End Sub

    Private Sub poisen_Button_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Input.MouseButtonEventArgs) Handles poisen_Button.MouseUp
        Call AttemptLogin()

    End Sub

    Private Sub Control_EndEvent(ByVal sender As System.Object, ByVal e As System.Windows.Input.MouseButtonEventArgs)
        End
    End Sub


    Private Sub txtPassword_Keydown(ByVal sender As System.Object, ByVal e As System.Windows.Input.KeyEventArgs)
        If e.Key = Key.Enter Then AttemptLogin()
    End Sub

    Private Sub AttemptLogin()
        Static i As Integer
        i += 1
        If i = 1 Then
            Dim SB As Storyboard = Me.FindResource("Storyboard1")
            SB.Begin()
        ElseIf Not blnLogin And i > 1 Then


            If txtUsername.Text = "Cih2001" And txtPassword.Password = "2442001" Then
                txtLoginResult.Text = "Login Approved" : blnLogin = True
                Me.usrRadioActive.Visibility = Windows.Visibility.Visible
                Me.usrRadioActive.InterActivity = True

                Dim strLoading As New StringBuilder

                Dim datNow As DateTime = DateTime.Now
                Do While CType(DateTime.Now - datNow, TimeSpan).TotalSeconds < 5
                    With strLoading
                        .AppendLine() : .AppendLine()
                        .AppendFormat("Initializing, Please Wait...")
                        If CType(DateTime.Now - datNow, TimeSpan).TotalSeconds > 1 Then
                            .AppendLine()
                            .AppendFormat("Initializing Main...")
                        End If
                        If CType(DateTime.Now - datNow, TimeSpan).TotalSeconds > 2 Then
                            .AppendLine()
                            .AppendFormat("Initializing Control...")
                        End If
                        If CType(DateTime.Now - datNow, TimeSpan).TotalSeconds > 3 Then
                            .AppendLine()
                            .AppendFormat("Initializing Reports...")
                        End If
                        If CType(DateTime.Now - datNow, TimeSpan).TotalSeconds > 4 Then
                            .AppendLine()
                            .AppendFormat("Initializing Core...")
                            .AppendLine()
                            .AppendFormat("Initializing Strips...")
                        End If
                        .AppendLine() : .Append(DateTime.Now.ToString("HH:mm:ss.ff"))
                        txtloading.Text = strLoading.ToString : txtloading.Visibility = Windows.Visibility.Visible
                    End With
                    strLoading.Clear()
                    Dispatcher.CurrentDispatcher.Invoke(
                    DispatcherPriority.Background,
                    New Action(Sub()

                               End Sub))
                Loop
                With strLoading
                    .AppendLine() : .AppendLine()
                    .AppendFormat("{0} : Initializing, Please Wait...", Date.Now.ToString("HH:mm:ss.ff"))
                    .AppendLine()
                    .AppendFormat("{0} : Initializing Main...", Date.Now.ToString("HH:mm:ss.ff"))
                    .AppendLine()
                    .AppendFormat("{0} : Initializing Control...", Date.Now.ToString("HH:mm:ss.ff"))
                    .AppendLine()
                    .AppendFormat("{0} : Initializing Reports...", Date.Now.ToString("HH:mm:ss.ff"))
                    .AppendLine()
                    .AppendFormat("{0} : Initializing Core...", Date.Now.ToString("HH:mm:ss.ff"))
                    .AppendLine()
                    .AppendFormat("{0} : Initializing Strips...", Date.Now.ToString("HH:mm:ss.ff"))
                    txtloading.Text = strLoading.ToString : txtloading.Visibility = Windows.Visibility.Visible
                End With
                pblnLoginPassed = True
            Else
                txtLoginResult.Text = "Access Denied"
            End If
            txtLoginResult.Visibility = Windows.Visibility.Visible
        End If
    End Sub


    Private Sub frmLogin_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Closing
        If Not pblnLoginPassed Then End
    End Sub
End Class