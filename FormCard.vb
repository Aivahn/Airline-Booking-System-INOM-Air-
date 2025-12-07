Public Class FormCard
    Dim sampleCards As New List(Of Dictionary(Of String, Object)) From {
        New Dictionary(Of String, Object) From {
            {"CardHolderName", "Juan Dela Cruz"},
            {"CardNumber", "4111111111111111"},
            {"ExpiryMonth", "12"},
            {"ExpiryYear", "25"},
            {"CVV", "123"},
            {"Balance", 500000.0}
        },
        New Dictionary(Of String, Object) From {
            {"CardHolderName", "Maria Santos"},
            {"CardNumber", "5500000000000004"},
            {"ExpiryMonth", "11"},
            {"ExpiryYear", "25"},
            {"CVV", "456"},
            {"Balance", 750000.0}
        },
        New Dictionary(Of String, Object) From {
            {"CardHolderName", "Pedro Gutierrez"},
            {"CardNumber", "340000000000009"},
            {"ExpiryMonth", "10"},
            {"ExpiryYear", "26"},
            {"CVV", "789"},
            {"Balance", 300000.0}
        }
    }

    Public TotalPrice As Double

    Private Sub FormCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        lblTotalPriceCard.Text = $"Total Amount: {TotalPrice:C2}"
    End Sub

    Private Sub btnBackCard_Click(sender As Object, e As EventArgs) Handles btnBackCard.Click
        Me.Close()
    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        Dim enteredCardNumber As String = txtCardNumber.Text
        Dim enteredCVV As String = txtCVV.Text
        Dim enteredMonth As String = txtExpiryMonth.Text
        Dim enteredYear As String = txtExpiryYear.Text
        Dim cardFound As Boolean = False

        For Each card In sampleCards
            If card("CardNumber").ToString() = enteredCardNumber AndAlso
               card("CVV").ToString() = enteredCVV AndAlso
               card("ExpiryMonth").ToString() = enteredMonth AndAlso
               card("ExpiryYear").ToString() = enteredYear Then

                cardFound = True

                If card("Balance") >= TotalPrice Then
                    Dim result As DialogResult = MessageBox.Show(
                        $"Confirm payment of {TotalPrice:C2}?", "Confirm Payment", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                    If result = DialogResult.Yes Then
                        card("Balance") -= TotalPrice

                        MessageBox.Show($"Payment successful! Remaining Balance: {card("Balance"):C2}", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        FormPayment.ReceiptPaymentMethod = "Card"
                        FormPayment.ReceiptAccountDetails = $"Card Ending in {enteredCardNumber.Substring(enteredCardNumber.Length - 4)}"
                        FormPayment.ReceiptTotalPrice = TotalPrice

                        Me.Close()
                    Else
                        MessageBox.Show("Payment canceled.", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    MessageBox.Show("Insufficient balance. Please try another card.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                Exit For
            End If
        Next

        If Not cardFound Then
            MessageBox.Show("Card not found or incorrect details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

End Class
