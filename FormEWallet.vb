Public Class FormEWallet
    Dim sampleEWallets As New List(Of Dictionary(Of String, Object)) From {
        New Dictionary(Of String, Object) From {
            {"AccountName", "Juan Dela Cruz"},
            {"AccountNumber", "09171234567"},
            {"Balance", 150000.0}
        },
        New Dictionary(Of String, Object) From {
            {"AccountName", "Maria Santos"},
            {"AccountNumber", "09281234568"},
            {"Balance", 250000.0}
        },
        New Dictionary(Of String, Object) From {
            {"AccountName", "Pedro Gutierrez"},
            {"AccountNumber", "09391234569"},
            {"Balance", 300000.0}
        },
        New Dictionary(Of String, Object) From {
            {"AccountName", "Anna Rivera"},
            {"AccountNumber", "09491234560"},
            {"Balance", 50000.0}
        }
    }

    Public TotalPrice As Double

    Private Sub FormEWallet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()

        lblTotalPriceEW.Text = $"Total Price: {TotalPrice:C2}"
    End Sub

    Private Sub btnPayEW_Click(sender As Object, e As EventArgs) Handles btnPayEW.Click
        Dim enteredAccName As String = txtAccName.Text
        Dim enteredAccNum As String = txtAccNum.Text
        Dim eWalletFound As Boolean = False

        For Each eWallet In sampleEWallets
            If eWallet("AccountName").ToString().ToLower() = enteredAccName.ToLower() AndAlso
           eWallet("AccountNumber").ToString() = enteredAccNum Then

                eWalletFound = True

                If eWallet("Balance") >= TotalPrice Then
                    Dim result As DialogResult = MessageBox.Show(
                    $"Confirm payment of {TotalPrice:C2}?", "Confirm Payment", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                    If result = DialogResult.Yes Then
                        eWallet("Balance") -= TotalPrice
                        MessageBox.Show($"Payment Successful! Remaining Balance: {eWallet("Balance"):C2}", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        FormPayment.ReceiptPaymentMethod = "E-Wallet"
                        FormPayment.ReceiptAccountDetails = $"{enteredAccName} ({enteredAccNum})"
                        FormPayment.ReceiptTotalPrice = TotalPrice

                        Me.Close()
                    Else
                        MessageBox.Show("Payment canceled.", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    MessageBox.Show("Insufficient balance in the e-wallet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

                Exit For
            End If
        Next

        If Not eWalletFound Then
            MessageBox.Show("E-wallet account not found or incorrect details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub



    Private Sub btnBackEW_Click(sender As Object, e As EventArgs) Handles btnBackEW.Click
        Me.Close()
    End Sub
End Class
