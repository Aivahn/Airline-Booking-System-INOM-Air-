Public Class Form1
    Private Sub btnBookNow_Click(sender As Object, e As EventArgs) Handles btnBookNow.Click
        Form7.Show()
        Me.Hide()
    End Sub

    Private Sub FormHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
    End Sub
End Class
