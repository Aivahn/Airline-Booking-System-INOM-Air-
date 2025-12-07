Public Class Form1
    Private Sub btnBookNow_Click(sender As Object, e As EventArgs) Handles btnBookNow.Click
        Dim form2 As New Form2()

        form2.Show()

        Me.Hide()
    End Sub

    Private Sub Form1_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
    End Sub
End Class
