Imports System.Data.OleDb
Public Class FormBook
    Public connStr As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\flightBooking.mdb"
    Private conn As OleDbConnection


    Private planes As New List(Of Plane) From {
        New Plane("P001", "Airbus A350", 295),
        New Plane("P002", "Boeing 777", 393),
        New Plane("P003", "Boeing 737", 215)
    }

    Private availableFlights As New List(Of Flight) From {
    New Flight("Flight 101", "NOM International Manila", "Tokyo Haneda Airport (HND)", "Airbus A350", "A001", "4 hrs 30 mins"),
    New Flight("Flight 102", "NOM International Manila", "Beijing Capital International Airport (PEK)", "Airbus A350", "A002", "4 hrs 10 mins"),
    New Flight("Flight 103", "NOM International Manila", "Incheon International Airport (ICN)", "Airbus A350", "A003", "4 hrs 20 mins"),
    New Flight("Flight 104", "NOM International Manila", "Taiwan Taoyuan International Airport (TPE)", "Airbus A350", "A004", "2 hrs 30 mins"),
    New Flight("Flight 105", "NOM International Manila", "John F. Kennedy International Airport (JFK)", "Airbus A350", "A005", "16 hrs"),
    New Flight("Flight 106", "NOM International Manila", "Los Angeles International Airport (LAX)", "Airbus A350", "A006", "13 hrs 15 mins"),
    New Flight("Flight 107", "NOM International Manila", "Tokyo Haneda Airport (HND)", "Boeing 777", "B001", "4 hrs 30 mins"),
    New Flight("Flight 108", "NOM International Manila", "Beijing Capital International Airport (PEK)", "Boeing 777", "B002", "4 hrs 10 mins"),
    New Flight("Flight 109", "NOM International Manila", "Incheon International Airport (ICN)", "Boeing 777", "B003", "4 hrs 20 mins"),
    New Flight("Flight 110", "NOM International Manila", "Taiwan Taoyuan International Airport (TPE)", "Boeing 777", "B004", "2 hrs 30 mins"),
    New Flight("Flight 111", "NOM International Manila", "John F. Kennedy International Airport (JFK)", "Boeing 777", "B005", "16 hrs"),
    New Flight("Flight 112", "NOM International Manila", "Dubai International Airport (DXB)", "Boeing 777", "B006", "8 hrs 30 mins"),
    New Flight("Flight 113", "NOM International Manila", "Tokyo Haneda Airport (HND)", "Boeing 737", "BB001", "4 hrs 30 mins"),
    New Flight("Flight 114", "NOM International Manila", "Beijing Capital International Airport (PEK)", "Boeing 737", "BB002", "4 hrs 10 mins"),
    New Flight("Flight 115", "NOM International Manila", "Incheon International Airport (ICN)", "Boeing 737", "BB003", "4 hrs 20 mins"),
    New Flight("Flight 116", "NOM International Manila", "Taiwan Taoyuan International Airport (TPE)", "Boeing 737", "BB004", "2 hrs 30 mins"),
    New Flight("Flight 117", "NOM International Manila", "John F. Kennedy International Airport (JFK)", "Boeing 737", "BB005", "16 hrs"),
    New Flight("Flight 118", "NOM International Manila", "Dubai International Airport (DXB)", "Boeing 737", "BB006", "8 hrs 30 mins"),
    New Flight("Flight 201", "NOM International Cebu", "Singapore Changi Airport (SIN)", "Airbus A350", "C001", "4 hrs 30 mins"),
    New Flight("Flight 202", "NOM International Cebu", "Suvarnabhumi Airport (BKK)", "Airbus A350", "C002", "3 hrs 30 mins"),
    New Flight("Flight 203", "NOM International Cebu", "Wattay International Airport (VTE)", "Airbus A350", "C003", "3 hrs 10 mins"),
    New Flight("Flight 204", "NOM International Cebu", "Charles de Gaulle Airport (CDG)", "Airbus A350", "C004", "13 hrs 30 mins"),
    New Flight("Flight 205", "NOM International Cebu", "Hong Kong International Airport (HKG)", "Airbus A350", "C005", "2 hrs 30 mins"),
    New Flight("Flight 206", "NOM International Cebu", "Singapore Changi Airport (SIN)", "Boeing 777", "C001", "4 hrs 30 mins"),
    New Flight("Flight 207", "NOM International Cebu", "Suvarnabhumi Airport (BKK)", "Boeing 777", "C002", "3 hrs 30 mins"),
    New Flight("Flight 208", "NOM International Cebu", "Wattay International Airport (VTE)", "Boeing 777", "C003", "3 hrs 10 mins"),
    New Flight("Flight 209", "NOM International Cebu", "Charles de Gaulle Airport (CDG)", "Boeing 777", "C004", "13 hrs 30 mins"),
    New Flight("Flight 210", "NOM International Cebu", "Hong Kong International Airport (HKG)", "Boeing 777", "C005", "2 hrs 30 mins"),
    New Flight("Flight 211", "NOM International Cebu", "Singapore Changi Airport (SIN)", "Boeing 737", "CB001", "4 hrs 30 mins"),
    New Flight("Flight 212", "NOM International Cebu", "Suvarnabhumi Airport (BKK)", "Boeing 737", "CB002", "3 hrs 30 mins"),
    New Flight("Flight 213", "NOM International Cebu", "Wattay International Airport (VTE)", "Boeing 737", "CB003", "3 hrs 10 mins"),
    New Flight("Flight 214", "NOM International Cebu", "Charles de Gaulle Airport (CDG)", "Boeing 737", "CB004", "13 hrs 30 mins"),
    New Flight("Flight 215", "NOM International Cebu", "Hong Kong International Airport (HKG)", "Boeing 737", "CB005", "2 hrs 30 mins"),
    New Flight("Flight 301", "NOM International Davao", "Kuala Lumpur International Airport (KUL)", "Airbus A350", "D001", "4 hrs 10 mins"),
    New Flight("Flight 302", "NOM International Davao", "Indira Gandhi International Airport (DEL)", "Airbus A350", "D002", "7 hrs 50 mins"),
    New Flight("Flight 303", "NOM International Davao", "Istanbul Airport (IST)", "Airbus A350", "D003", "9 hrs"),
    New Flight("Flight 304", "NOM International Davao", "Hamad International Airport (DOH)", "Airbus A350", "D004", "8 hrs 30 mins"),
    New Flight("Flight 305", "NOM International Davao", "Kuala Lumpur International Airport (KUL)", "Boeing 777", "D001", "4 hrs 10 mins"),
    New Flight("Flight 306", "NOM International Davao", "Indira Gandhi International Airport (DEL)", "Boeing 777", "D002", "7 hrs 50 mins"),
    New Flight("Flight 307", "NOM International Davao", "Istanbul Airport (IST)", "Boeing 777", "D003", "9 hrs"),
    New Flight("Flight 308", "NOM International Davao", "Hamad International Airport (DOH)", "Boeing 777", "D004", "8 hrs 30 mins"),
    New Flight("Flight 309", "NOM International Davao", "Kuala Lumpur International Airport (KUL)", "Boeing 737", "DB001", "4 hrs 10 mins"),
    New Flight("Flight 310", "NOM International Davao", "Indira Gandhi International Airport (DEL)", "Boeing 737", "DB002", "7 hrs 50 mins"),
    New Flight("Flight 311", "NOM International Davao", "Istanbul Airport (IST)", "Boeing 737", "DB003", "9 hrs"),
    New Flight("Flight 312", "NOM International Davao", "Hamad International Airport (DOH)", "Boeing 737", "DB004", "8 hrs 30 mins")
}

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()

        lstAvailableFlights.DrawMode = DrawMode.OwnerDrawVariable
        AddHandler lstAvailableFlights.MeasureItem, AddressOf lstAvailableFlights_MeasureItem
        AddHandler lstAvailableFlights.DrawItem, AddressOf lstAvailableFlights_DrawItem

        conn = New OleDbConnection(connStr)

        cmbPlaneTrip.Items.Add("One Way")
        cmbPlaneTrip.Items.Add("Round Trip")

        cmbFlightFrom.Items.Add("NOM International Manila")
        cmbFlightFrom.Items.Add("NOM International Cebu")
        cmbFlightFrom.Items.Add("NOM International Davao")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If dtpDeparture.Value.Date <> DateTime.Today Then
            dtpDeparture.Value = DateTime.Today
        End If

    End Sub

    Private Sub cmbFlightFrom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFlightFrom.SelectedIndexChanged

        cmbFlightTo.Items.Clear()

        Dim selectedDeparture As String = cmbFlightFrom.SelectedItem?.ToString()

        Dim departureDestinations As New Dictionary(Of String, List(Of String)) From {
            {"NOM International Manila", New List(Of String) From {
                "Tokyo Haneda Airport (HND)",
                "Beijing Capital International Airport (PEK)",
                "Incheon International Airport (ICN)",
                "Taiwan Taoyuan International Airport (TPE)",
                "John F. Kennedy International Airport (JFK)",
                "Los Angeles International Airport (LAX)",
                "Dubai International Airport (DXB)"
            }},
            {"NOM International Cebu", New List(Of String) From {
                "Singapore Changi Airport (SIN)",
                "Suvarnabhumi Airport (BKK)",
                "Wattay International Airport (VTE)",
                "Charles de Gaulle Airport (CDG)",
                "Hong Kong International Airport (HKG)"
            }},
            {"NOM International Davao", New List(Of String) From {
                "Kuala Lumpur International Airport (KUL)",
                "Indira Gandhi International Airport (DEL)",
                "Istanbul Airport (IST)",
                "Hamad International Airport (DOH)"
            }}
        }

        If departureDestinations.ContainsKey(selectedDeparture) Then
            cmbFlightTo.Items.AddRange(departureDestinations(selectedDeparture).ToArray())
        Else
            MessageBox.Show("No destinations available for the selected airport.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        lstAvailableFlights.Items.Clear()

        Dim tripType As String = If(cmbPlaneTrip.SelectedItem IsNot Nothing, cmbPlaneTrip.SelectedItem.ToString(), "")
        Dim flightFrom As String = If(cmbFlightFrom.SelectedItem IsNot Nothing, cmbFlightFrom.SelectedItem.ToString(), "")
        Dim flightTo As String = If(cmbFlightTo.SelectedItem IsNot Nothing, cmbFlightTo.SelectedItem.ToString(), "")

        If String.IsNullOrEmpty(tripType) OrElse String.IsNullOrEmpty(flightFrom) OrElse String.IsNullOrEmpty(flightTo) Then
            MessageBox.Show("Please select all options.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If tripType = "Round Trip" Then
            If dtpReturning.Value <= dtpDeparture.Value Then
                MessageBox.Show("Please pick a returning date that is at least one day after the departure date.", "Invalid Return Date", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        End If

        Dim matchingFlights = availableFlights.Where(Function(f) f.DepartureAirport = flightFrom AndAlso f.DestinationAirport = flightTo).ToList()

        If matchingFlights.Count > 0 Then
            For Each flight In matchingFlights
                lstAvailableFlights.Items.Add($"Flight Number: {flight.FlightName} | Plane Model: {flight.PlaneModel} | Plane Number: {flight.PlaneNumber} | Destination: {flight.DestinationAirport} | Travel Time: {flight.EstimatedTravelTime}")
            Next
            lstAvailableFlights.SelectedIndex = 0
        Else
            lstAvailableFlights.Items.Add("No flights found for the selected criteria.")
        End If
    End Sub

    Public Property ParentForm7 As Form7
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If lstAvailableFlights.SelectedItem Is Nothing Then
            MessageBox.Show("No flight selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim selectedFlight As String = lstAvailableFlights.SelectedItem.ToString()

        Dim flightDetails = selectedFlight.Split("|")
        Dim flightNumber = flightDetails(0).Split(":")(1).Trim()
        Dim planeModel = flightDetails(1).Split(":")(1).Trim()
        Dim planeNumber = flightDetails(2).Split(":")(1).Trim()

        Dim randomNumber As String = New Random().Next(1000, 9999).ToString()
        Dim bookingID As String = $"BKG-{randomNumber}"

        Try
            conn.Open()
            Dim cmd As New OleDbCommand("INSERT INTO [FlightBooking] ([BookingID], [PlaneTrip], [FlightFrom], [FlightTo], [Departure], [Returning], [FlightNumber], [PlaneModel], [PlaneNumber], [TravelTime]) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?)", conn)
            cmd.Parameters.AddWithValue("?", bookingID)
            cmd.Parameters.AddWithValue("?", cmbPlaneTrip.SelectedItem)
            cmd.Parameters.AddWithValue("?", cmbFlightFrom.SelectedItem)
            cmd.Parameters.AddWithValue("?", cmbFlightTo.SelectedItem)
            cmd.Parameters.AddWithValue("?", dtpDeparture.Value)
            cmd.Parameters.AddWithValue("?", dtpReturning.Value)
            cmd.Parameters.AddWithValue("?", flightNumber)
            cmd.Parameters.AddWithValue("?", planeModel)
            cmd.Parameters.AddWithValue("?", planeNumber)

            Dim travelTime As String = flightDetails(4).Split(":")(1).Trim()
            cmd.Parameters.AddWithValue("?", travelTime)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Flight details saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error while saving booking: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try

        If ParentForm7 IsNot Nothing Then
            Dim fillUpForm As New FormFillUp()
            fillUpForm.ParentForm7 = Me.ParentForm7
            fillUpForm.BookingID = bookingID
            ParentForm7.OpenChildForm(fillUpForm)
        Else
            MessageBox.Show("ParentForm7 is not set.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
    Private Sub lstAvailableFlights_MeasureItem(sender As Object, e As MeasureItemEventArgs)

        If e.Index >= 0 Then
            Dim g As Graphics = e.Graphics
            Dim itemText As String = lstAvailableFlights.Items(e.Index).ToString()
            Dim textSize As SizeF = g.MeasureString(itemText, lstAvailableFlights.Font, lstAvailableFlights.Width)
            e.ItemHeight = CInt(Math.Ceiling(textSize.Height)) + 4
        End If
    End Sub

    Private Sub lstAvailableFlights_DrawItem(sender As Object, e As DrawItemEventArgs)

        If e.Index >= 0 Then
            e.DrawBackground()
            Dim g As Graphics = e.Graphics
            Dim itemText As String = lstAvailableFlights.Items(e.Index).ToString()
            Dim textRect As Rectangle = e.Bounds
            textRect.Inflate(-2, -2)
            g.DrawString(itemText, lstAvailableFlights.Font, Brushes.Black, textRect)
            e.DrawFocusRectangle()
        End If
    End Sub

    Private Sub cmbPlaneTrip_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPlaneTrip.SelectedIndexChanged
        If cmbPlaneTrip.SelectedItem.ToString() = "One Way" Then
            dtpReturning.Enabled = False
            dtpReturning.Value = dtpDeparture.Value
        Else
            dtpReturning.Enabled = True
            dtpReturning.Format = dtpDeparture.Format
            dtpReturning.CustomFormat = dtpDeparture.CustomFormat
        End If
    End Sub


    Private Sub dtpReturning_ValueChanged(sender As Object, e As EventArgs) Handles dtpReturning.ValueChanged
        dtpReturning.Format = dtpDeparture.Format
        dtpReturning.CustomFormat = dtpDeparture.CustomFormat

        If dtpReturning.Enabled Then
            If dtpReturning.Value <= dtpDeparture.Value Then
                MessageBox.Show("Please pick a returning date that is at least one day after the departure date.", "Invalid Return Date", MessageBoxButtons.OK, MessageBoxIcon.Error)
                dtpReturning.Value = dtpDeparture.Value.AddDays(1)
            End If
        End If
    End Sub


End Class

Public Class Plane
    Public Property PlaneID As String
    Public Property PlaneModel As String
    Public Property Capacity As Integer

    Public Sub New(planeID As String, planeModel As String, capacity As Integer)
        Me.PlaneID = planeID
        Me.PlaneModel = planeModel
        Me.Capacity = capacity
    End Sub
End Class


Public Class Flight
    Public Property FlightName As String
    Public Property DepartureAirport As String
    Public Property DestinationAirport As String
    Public Property PlaneModel As String
    Public Property PlaneNumber As String
    Public Property EstimatedTravelTime As String

    Public Sub New(flightName As String, departureAirport As String, destinationAirport As String, planeModel As String, planeNumber As String, estimatedTravelTime As String)
        Me.FlightName = flightName
        Me.DepartureAirport = departureAirport
        Me.DestinationAirport = destinationAirport
        Me.PlaneModel = planeModel
        Me.PlaneNumber = planeNumber
        Me.EstimatedTravelTime = estimatedTravelTime
    End Sub
End Class
