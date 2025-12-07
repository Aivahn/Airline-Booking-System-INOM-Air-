Public Class FormReciept
    Private Sub btnBackReciept_Click(sender As Object, e As EventArgs) Handles btnBackReciept.Click
        Me.Close()
        FormPayment.Show()
    End Sub
End Class