Imports System.Data.OleDb

Public Class FormFlightDetails
    Dim connStr As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\flightBooking.mdb"
    Dim conn As OleDbConnection = Nothing
    Dim random As New Random()

    Private Sub btnShowFlight_Click(sender As Object, e As EventArgs) Handles btnShowFlight.Click
        Dim bookingID As String = txtBookingID.Text.Trim()

        If String.IsNullOrEmpty(bookingID) Then
            MessageBox.Show("Please enter a valid BookingID to search.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            conn = New OleDbConnection(connStr)
            conn.Open()

            Dim query As String = "SELECT FullName, Email, DateOfBirth, Age, Sex, Address, BaggageAllowance, FlightFrom, FlightTo, PlaneTrip, Departure, Returning, SeatNumbers, Adult, Child, Senior, PWD, Status, FlightNumber, TravelTime FROM FlightBooking WHERE BookingID = ?"
            Dim cmd As New OleDbCommand(query, conn)
            cmd.Parameters.AddWithValue("?", bookingID)

            Dim reader As OleDbDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                Dim departureDate As DateTime = Convert.ToDateTime(reader("Departure"))
                Dim randomDays As Integer = random.Next(6, 14)

                Dim newDepartureDate As DateTime = departureDate.AddDays(randomDays)

                Dim departureHour As Integer = random.Next(6, 22)
                newDepartureDate = New DateTime(newDepartureDate.Year, newDepartureDate.Month, newDepartureDate.Day, departureHour, departureDate.Minute, 0)

                Dim returningDate As String = "N/A"
                If reader("PlaneTrip").ToString() <> "One Way" Then
                    Dim returnDate As DateTime = Convert.ToDateTime(reader("Returning"))

                    Dim newReturningDate As DateTime = returnDate.AddDays(randomDays)

                    If newReturningDate <= newDepartureDate Then
                        newReturningDate = newDepartureDate.AddDays(1)
                    End If

                    Dim returnHour As Integer = random.Next(6, 22)
                    newReturningDate = New DateTime(newReturningDate.Year, newReturningDate.Month, newReturningDate.Day, returnHour, returnDate.Minute, 0)

                    returningDate = newReturningDate.ToString("dddd, d MMMM yyyy HH:mm:ss")
                End If

                Dim details As String = $"Full Name: {reader("FullName")}" & Environment.NewLine &
                    $"Email: {reader("Email")}" & Environment.NewLine &
                    $"Date of Birth: {reader("DateOfBirth")}" & Environment.NewLine &
                    $"Age: {reader("Age")}" & Environment.NewLine &
                    $"Sex: {reader("Sex")}" & Environment.NewLine &
                    $"Address: {reader("Address")}" & Environment.NewLine &
                    $"Baggage Allowance: {reader("BaggageAllowance")}" & Environment.NewLine &
                    $"Flight From: {reader("FlightFrom")}" & Environment.NewLine &
                    $"Flight To: {reader("FlightTo")}" & Environment.NewLine &
                    $"Plane Trip: {reader("PlaneTrip")}" & Environment.NewLine &
                    $"Departure: {newDepartureDate.ToString("dddd, d MMMM yyyy HH:mm:ss")}" & Environment.NewLine

                details &= $"Note: This is your very specific departure date." & Environment.NewLine

                If returningDate <> "N/A" Then
                    details &= $"Returning: {returningDate}" & Environment.NewLine &
                               $"Note: This is your very specific returning date." & Environment.NewLine
                Else
                    details &= $"Returning: {returningDate}" & Environment.NewLine
                End If

                details &= $"Travel Time: {reader("TravelTime")}" & Environment.NewLine &
                           $"Seat Numbers: {reader("SeatNumbers")}" & Environment.NewLine &
                           $"Number of Adults: {reader("Adult")}" & Environment.NewLine &
                           $"Number of Children: {reader("Child")}" & Environment.NewLine &
                           $"Number of Seniors: {reader("Senior")}" & Environment.NewLine &
                           $"Number of PWD: {reader("PWD")}" & Environment.NewLine &
                           $"Status: {reader("Status")}" & Environment.NewLine &
                           $"Flight Number: {reader("FlightNumber")}"

                lblDetailDisplay.Text = details

                FormPayment.FlightNumber = reader("FlightNumber").ToString()
                FormPayment.FlightFrom = reader("FlightFrom").ToString()
                FormPayment.FlightTo = reader("FlightTo").ToString()
                FormPayment.PlaneTrip = reader("PlaneTrip").ToString()
                FormPayment.Departure = newDepartureDate.ToString("dddd, d MMMM yyyy HH:mm:ss")
                FormPayment.Returning = returningDate
                FormPayment.AdultCount = CInt(reader("Adult"))
                FormPayment.ChildCount = CInt(reader("Child"))
                FormPayment.SeniorCount = CInt(reader("Senior"))
                FormPayment.PWDCount = CInt(reader("PWD"))
                FormPayment.BaggageAllowance = reader("BaggageAllowance").ToString()
                FormPayment.SeatNumbers = reader("SeatNumbers").ToString()
                FormPayment.BookingID = bookingID
            Else
                MessageBox.Show("No booking found with the provided BookingID.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
                lblDetailDisplay.Text = "No details available."
            End If

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error while retrieving booking details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn IsNot Nothing Then conn.Close()
        End Try
    End Sub

    Public Property BookingID As String

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        If Not String.IsNullOrEmpty(Me.BookingID) Then
            txtBookingID.Text = Me.BookingID
        End If
    End Sub

    Public Property ParentForm7 As Form7
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        ParentForm7.OpenChildForm(FormPayment)
    End Sub

    Private Sub btnSaveDetails_Click(sender As Object, e As EventArgs) Handles btnSaveDetails.Click
        Try
            Dim bmp As New Bitmap(panelDetails.Width, panelDetails.Height)
            panelDetails.DrawToBitmap(bmp, New Rectangle(0, 0, panelDetails.Width, panelDetails.Height))

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
End Class
