Imports System.Data.OleDb

Public Class FormPayment
    Public FlightNumber As String
    Public FlightFrom As String
    Public FlightTo As String
    Public PlaneTrip As String
    Public Departure As String
    Public Returning As String
    Public AdultCount As Integer
    Public ChildCount As Integer
    Public SeniorCount As Integer
    Public PWDCount As Integer
    Public BaggageAllowance As String
    Public SeatNumbers As String
    Public BookingID As String
    Public ReceiptPaymentMethod As String
    Public ReceiptAccountDetails As String
    Public ReceiptTotalPrice As Double

    Dim FlightPrices As New Dictionary(Of String, Double) From {
        {"Flight 101", 20000},
        {"Flight 102", 22000},
        {"Flight 103", 21000},
        {"Flight 104", 20000},
        {"Flight 105", 25000},
        {"Flight 106", 25000},
        {"Flight 107", 20000},
        {"Flight 108", 22000},
        {"Flight 109", 21000},
        {"Flight 110", 20000},
        {"Flight 111", 25000},
        {"Flight 112", 23000},
        {"Flight 113", 18000},
        {"Flight 114", 18500},
        {"Flight 115", 18000},
        {"Flight 116", 17500},
        {"Flight 117", 20000},
        {"Flight 118", 19000},
        {"Flight 201", 20000},
        {"Flight 202", 20000},
        {"Flight 203", 18000},
        {"Flight 204", 25000},
        {"Flight 205", 19000},
        {"Flight 206", 20000},
        {"Flight 207", 20000},
        {"Flight 208", 18000},
        {"Flight 209", 24000},
        {"Flight 210", 19000},
        {"Flight 211", 18000},
        {"Flight 212", 18500},
        {"Flight 213", 17500},
        {"Flight 214", 23000},
        {"Flight 215", 17500},
        {"Flight 301", 20000},
        {"Flight 302", 22000},
        {"Flight 303", 23000},
        {"Flight 304", 21000},
        {"Flight 305", 20000},
        {"Flight 306", 22000},
        {"Flight 307", 23000},
        {"Flight 308", 21000},
        {"Flight 309", 18000},
        {"Flight 310", 19000},
        {"Flight 311", 20000},
        {"Flight 312", 19500}
    }

    Dim ClassMultipliers As New Dictionary(Of String, Double) From {
        {"E", 0},
        {"B", 5000},
        {"P", 7000},
        {"F", 10000}
    }
    Public Property ParentForm7 As Form7

    Private Sub FormPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtBookingId.Text = BookingID
        txtSeatNumber.Text = SeatNumbers
        txtBaggageAllowance.Text = BaggageAllowance

        Dim basePrice As Double = FlightPrices(FlightNumber)
        Dim classMultiplier As Double = 0

        If Not String.IsNullOrEmpty(SeatNumbers) Then
            Dim classLetter As String = SeatNumbers.Substring(0, 1).ToUpper()

            If ClassMultipliers.ContainsKey(classLetter) Then
                classMultiplier = ClassMultipliers(classLetter)
            End If
        End If

        Dim tripDuration As Integer = CalculateTripDuration()
        Dim price As Double = basePrice

        If tripDuration >= 8 AndAlso tripDuration <= 13 Then
            price *= 1.05
        ElseIf tripDuration >= 14 Then
            price *= 1.1
        End If

        price += classMultiplier

        Dim totalAdults As Double = AdultCount * price
        Dim totalChildren As Double = ChildCount * (price * 0.5)
        Dim totalSeniors As Double = SeniorCount * (price * 0.8)
        Dim totalPWD As Double = PWDCount * (price * 0.8)

        Dim totalPrice As Double = totalAdults + totalChildren + totalSeniors + totalPWD

        Dim baggageSurcharge As Double = 0
        If Not String.IsNullOrEmpty(BaggageAllowance) Then
            Dim baggageWeight As Integer
            If Integer.TryParse(BaggageAllowance.ToUpper().Replace("KG", "").Trim(), baggageWeight) Then
                Select Case baggageWeight
                    Case <= 9
                        baggageSurcharge = 0
                    Case 10 To 19
                        baggageSurcharge = 1000
                    Case 20 To 29
                        baggageSurcharge = 1800
                    Case 30 To 39
                        baggageSurcharge = 2100
                    Case 40 To 49
                        baggageSurcharge = 3000
                    Case >= 50
                        baggageSurcharge = 4500
                End Select
            End If
        End If

        totalPrice += baggageSurcharge

        Dim discountAdults As Double = AdultCount * price * 0
        Dim discountChildren As Double = ChildCount * price * 0.5
        Dim discountSeniors As Double = SeniorCount * price * 0.2
        Dim discountPWD As Double = PWDCount * price * 0.2

        Dim totalDiscount As Double = discountChildren + discountSeniors + discountPWD

        txtTotalPrice.Text = $" {totalPrice:C2}"
        txtDiscount.Text = $" {totalDiscount:C2}"

        Panel1.Enabled = False
    End Sub

    Private Function CalculateTripDuration() As Integer
        Try
            Dim depDate As Date
            If Not DateTime.TryParse(Departure, depDate) Then
                Throw New Exception("Invalid Departure date format.")
            End If

            Dim returnDate As Date
            If String.IsNullOrEmpty(Returning) OrElse Not DateTime.TryParse(Returning, returnDate) Then
                Return 0
            End If

            Return (returnDate - depDate).Days
        Catch ex As Exception
            MessageBox.Show("Error calculating trip duration: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End Try
    End Function


    Private Sub btnCard_Click(sender As Object, e As EventArgs) Handles btnCard.Click
        Dim formCard As New FormCard()
        formCard.TotalPrice = Convert.ToDouble(txtTotalPrice.Text.Replace("₱", "").Trim())
        formCard.ShowDialog()
    End Sub

    Private Sub btnEWallet_Click(sender As Object, e As EventArgs) Handles btnEWallet.Click
        Dim eWalletForm As New FormEWallet
        eWalletForm.TotalPrice = Double.Parse(txtTotalPrice.Text, Globalization.NumberStyles.Currency)
        eWalletForm.ShowDialog()
    End Sub

    Private Sub btnReceipt_Click(sender As Object, e As EventArgs) Handles btnReceipt.Click
        If String.IsNullOrEmpty(ReceiptPaymentMethod) Then
            MessageBox.Show("No payment has been made yet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim paidAmount As Double = 0 ' Set this based on actual payment
        Dim remainingBalance As Double = ReceiptTotalPrice - paidAmount

        Dim receiptForm As New FormReceipt()
        receiptForm.PaymentMethod = ReceiptPaymentMethod
        receiptForm.AccountDetails = ReceiptAccountDetails
        receiptForm.TotalPrice = ReceiptTotalPrice
        receiptForm.ShowDialog()
    End Sub


    Private Function GetAmountPaid() As Double
        Return ReceiptTotalPrice
    End Function

    Private Sub btnFinishPayment_Click(sender As Object, e As EventArgs) Handles btnFinishPayment.Click
        Dim connectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\flightBooking.mdb"

        Dim insertQuery As String = "INSERT INTO Transactions (BookingID, TotalPrice, Status) VALUES (@BookingID, @TotalPrice, @Status)"

        Using connection As New OleDbConnection(connectionString)
            Using command As New OleDbCommand(insertQuery, connection)
                command.Parameters.AddWithValue("@BookingID", BookingID)
                command.Parameters.AddWithValue("@TotalPrice", ReceiptTotalPrice)
                command.Parameters.AddWithValue("@Status", "Paid")

                Try
                    connection.Open()

                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Payment successfully recorded!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Failed to record the payment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    MessageBox.Show("An error occurred while saving the transaction: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
        Me.Close()
    End Sub

    Private Sub btnCancel2_Click(sender As Object, e As EventArgs) Handles btnCancel2.Click
        Me.Close()
    End Sub
End Class
