Public Class Form3

    Private Sub btnSelectSeat_Click(sender As Object, e As EventArgs) Handles btnSelectSeat.Click
        Form4.Show()
    End Sub

    Private Sub chckSeniorCitizen_CheckedChanged(sender As Object, e As EventArgs) Handles chckSeniorCitizen.CheckedChanged

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
    End Sub
End Class