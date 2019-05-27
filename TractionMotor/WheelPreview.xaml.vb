Imports System.Windows.Media.Media3D
Imports System.Text
Imports System.Windows

Class WheelPreviewWindow
#Region "Properties"
    Dim _Angle As Single = 10
    Public AngleProperty As DependencyProperty = DependencyProperty.Register(
         "Angle", GetType(Single), GetType(WheelPreviewWindow))
    Public Property Angle As Single
        Get
            Return _Angle
        End Get
        Set(ByVal value As Single)
            If Math.Abs(value) > 360 Then value = value Mod 360
            _Angle = value
            If Interactivity Then RotateAngle(value)
        End Set
    End Property

    Property Interactivity As Boolean = False
#End Region

    Private Sub RotateAngle(ByVal sngAngle As Single)
        Dim myRotateTransform As New RotateTransform3D(
            New AxisAngleRotation3D(New Vector3D(0, 1, 0), sngAngle))
        Dim strText As New StringBuilder

        LatheOR9GR10.Transform = myRotateTransform
        runProfileName3D.Text = "Tmp"
        runAngle3D.Text = String.Format("{0:000.00}", sngAngle)


    End Sub

    Private Sub WheelPreviewWindow_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated

    End Sub
End Class