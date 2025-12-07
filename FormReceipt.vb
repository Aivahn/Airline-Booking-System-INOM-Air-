Public Class FormReceipt
    Public Property PaymentMethod As String
    Public Property AccountDetails As String
    Public Property TotalPrice As Double


    Private Sub FormReceipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()


        lblReceipt.Text =
                      $"Receipt" & vbCrLf &
                      $"-----------------------------------------------" & vbCrLf &
                      $"Payment Method: {PaymentMethod}" & vbCrLf &
                      $"Details: {AccountDetails}" & vbCrLf &
                      $"Total Price: {TotalPrice:C2}" & vbCrLf &
                      $"Date: {DateTime.Now:MM/dd/yyyy HH:mm:ss}" & vbCrLf &
                      $"-----------------------------------------------" & vbCrLf &
                      $"Thank you for booking with us!" & vbCrLf &
                      $"For inquiries, contact us at support@nomairlines.com" & vbCrLf &
                      $"-----------------------------------------------" & vbCrLf &
                      $"Terms & Conditions:" & vbCrLf &
                      $"- Non-refundable unless otherwise stated." & vbCrLf &
                      $"- Please arrive at the airport 2 hours before departure."
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim bmp As New Bitmap(receiptPanel.Width, receiptPanel.Height)
            receiptPanel.DrawToBitmap(bmp, New Rectangle(0, 0, receiptPanel.Width, receiptPanel.Height))

            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp"
            saveFileDialog.Title = "Save Receipt Screenshot"
            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                Dim format As Imaging.ImageFormat = Imaging.ImageFormat.Png
                Select Case saveFileDialog.FilterIndex
                    Case 1 : format = Imaging.ImageFormat.Png
                    Case 2 : format = Imaging.ImageFormat.Jpeg
                    Case 3 : format = Imaging.ImageFormat.Bmp
                End Select

                bmp.Save(saveFileDialog.FileName, format)
                MessageBox.Show("Receipt saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred while saving the receipt: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
End Class
