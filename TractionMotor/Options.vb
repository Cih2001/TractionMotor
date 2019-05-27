Public Class frmOptions

    Private Sub frmOptions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtDiameter1.Text = Motor1.Diameter
        txtDiameter2.Text = Motor2.Diameter
        txtDiameter3.Text = Motor3.Diameter

        txtWheelName1.Text = Motor1.MotorName
        txtWheelName2.Text = Motor2.MotorName
        txtWheelName3.Text = Motor3.MotorName
    End Sub

    Private Sub btnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click, btnApply.Click
        Motor1.Diameter = CSng(txtDiameter1.Text)
        Motor2.Diameter = CSng(txtDiameter2.Text)
        Motor3.Diameter = CSng(txtDiameter3.Text)

        Motor1.MotorName = txtWheelName1.Text
        Motor2.MotorName = txtWheelName2.Text
        Motor3.MotorName = txtWheelName3.Text

        If CType(sender, Button).Name = "btnOk" Then Me.Close()

    End Sub
End Class