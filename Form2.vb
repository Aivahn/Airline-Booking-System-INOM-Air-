Public Class Form2
    ' Sample list of planes
    Private planes As New List(Of Plane) From {
        New Plane("P001", "Airbus A350", 300),
        New Plane("P002", "Boeing 777", 400),
        New Plane("P003", "Boeing 737", 200)
    }

    ' Sample list of flights
    Private availableFlights As New List(Of Flight) From {
        New Flight("Flight 101", "NOM International Manila", "Tokyo Haneda Airport (HND)", "Airbus A350"),
        New Flight("Flight 102", "NOM International Manila", "Beijing Capital International Airport (PEK)", "Boeing 777"),
        New Flight("Flight 103", "NOM International Manila", "Incheon International Airport (ICN)", "Boeing 737"),
        New Flight("Flight 201", "NOM International Cebu", "Singapore Changi Airport (SIN)", "Boeing 777"),
        New Flight("Flight 202", "NOM International Cebu", "Suvarnabhumi Airport (BKK)", "Boeing 737"),
        New Flight("Flight 301", "NOM International Davao", "Kuala Lumpur International Airport (KUL)", "Boeing 777"),
        New Flight("Flight 302", "NOM International Davao", "Indira Gandhi International Airport (DEL)", "Boeing 737"),
        New Flight("Flight 303", "NOM International Davao", "Istanbul Airport (IST)", "Airbus A350"),
        New Flight("Flight 304", "NOM International Davao", "Hamad International Airport (DOH)", "Boeing 777")
    }

    ' Dictionary to map departure airports to destination airports
    Private departureDestinations As New Dictionary(Of String, List(Of String)) From {
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

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()

        ' Populate trip types
        cmbPlaneTrip.Items.Add("One Way")
        cmbPlaneTrip.Items.Add("Round Trip")

        ' Populate departure airports
        cmbFlightFrom.Items.Add("NOM International Manila")
        cmbFlightFrom.Items.Add("NOM International Cebu")
        cmbFlightFrom.Items.Add("NOM International Davao") ' Included Davao
    End Sub

    Private Sub cmbFlightFrom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFlightFrom.SelectedIndexChanged
        ' Clear the destination list
        cmbFlightTo.Items.Clear()

        ' Get the selected departure airport
        Dim selectedDeparture As String = cmbFlightFrom.SelectedItem?.ToString()

        ' Populate the destination airports based on the selected departure airport
        If departureDestinations.ContainsKey(selectedDeparture) Then
            cmbFlightTo.Items.AddRange(departureDestinations(selectedDeparture).ToArray())
        Else
            MessageBox.Show("No destinations available for the selected airport.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ' Clear the ListBox before populating
        lstAvailableFlights.Items.Clear()

        ' Get selected criteria
        Dim tripType As String = If(cmbPlaneTrip.SelectedItem IsNot Nothing, cmbPlaneTrip.SelectedItem.ToString(), "")
        Dim flightFrom As String = If(cmbFlightFrom.SelectedItem IsNot Nothing, cmbFlightFrom.SelectedItem.ToString(), "")
        Dim flightTo As String = If(cmbFlightTo.SelectedItem IsNot Nothing, cmbFlightTo.SelectedItem.ToString(), "")

        ' Validate selections
        If String.IsNullOrEmpty(tripType) OrElse String.IsNullOrEmpty(flightFrom) OrElse String.IsNullOrEmpty(flightTo) Then
            MessageBox.Show("Please select all options.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Filter available flights based on selected criteria
        For Each flight In availableFlights
            If flight.DepartureAirport = flightFrom AndAlso flight.DestinationAirport = flightTo Then
                ' Display flight details including plane model
                lstAvailableFlights.Items.Add($"Flight: {flight.FlightName} | Plane: {flight.PlaneModel} | Destination: {flight.DestinationAirport}")
            End If
        Next

        ' Display a message if no flights are found
        If lstAvailableFlights.Items.Count = 0 Then
            lstAvailableFlights.Items.Add("No flights found for the selected criteria.")
        End If
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim form3 As New Form3()

        form3.Show()

        Me.Hide()
    End Sub
End Class

' Flight class
Public Class Flight
    Public Property FlightName As String
    Public Property DepartureAirport As String
    Public Property DestinationAirport As String
    Public Property PlaneModel As String

    Public Sub New(flightName As String, departureAirport As String, destinationAirport As String, planeModel As String)
        Me.FlightName = flightName
        Me.DepartureAirport = departureAirport
        Me.DestinationAirport = destinationAirport
        Me.PlaneModel = planeModel
    End Sub
End Class

' Plane class
Public Class Plane
    Public Property PlaneNumber As String
    Public Property PlaneModel As String
    Public Property PlaneCapacity As Integer

    Public Sub New(planeNumber As String, planeModel As String, planeCapacity As Integer)
        Me.PlaneNumber = planeNumber
        Me.PlaneModel = planeModel
        Me.PlaneCapacity = planeCapacity
    End Sub
End Class
