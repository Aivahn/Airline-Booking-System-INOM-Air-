Imports System.Data.OleDb

Public Class FormSeat
    Public connStr As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\flightBooking.mdb"
    Private conn As OleDbConnection
    Dim seatStates As New Dictionary(Of Button, String)
    Public TotalSeats As Integer
    Public TotalCapacity As Integer
    Public Property BookingID As String

    Private Sub FormSeat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()

        lblPlaneCapacity.Text = "Capacity: " & TotalCapacity.ToString()

        panelFirstClass.Enabled = False
        panelBusinessClass.Enabled = False
        panelPremClass.Enabled = False
        panelEconomyClass.Enabled = False

        SetPlaneCapacityFromDatabase()

        For Each ctrl As Control In panelFirstClass.Controls
            If TypeOf ctrl Is Button AndAlso (ctrl.Name.StartsWith("btnFA") OrElse ctrl.Name.StartsWith("btnFB") OrElse ctrl.Name.StartsWith("btnFC")) Then
                Dim btnSeat As Button = DirectCast(ctrl, Button)
                seatStates(btnSeat) = "Available"
                btnSeat.BackColor = Color.Yellow
                AddHandler btnSeat.Click, AddressOf SeatButton_Click
            End If
        Next

        For Each ctrl As Control In panelBusinessClass.Controls
            If TypeOf ctrl Is Button AndAlso (ctrl.Name.StartsWith("btnBA") OrElse ctrl.Name.StartsWith("btnBB") OrElse ctrl.Name.StartsWith("btnBC")) Then
                Dim btnSeat As Button = DirectCast(ctrl, Button)
                seatStates(btnSeat) = "Available"
                btnSeat.BackColor = Color.Green
                AddHandler btnSeat.Click, AddressOf SeatButton_Click
            End If
        Next

        For Each ctrl As Control In panelPremClass.Controls
            If TypeOf ctrl Is Button AndAlso (ctrl.Name.StartsWith("btnPA") OrElse ctrl.Name.StartsWith("btnPB") OrElse ctrl.Name.StartsWith("btnPC")) Then
                Dim btnSeat As Button = DirectCast(ctrl, Button)
                seatStates(btnSeat) = "Available"
                btnSeat.BackColor = Color.Blue
                AddHandler btnSeat.Click, AddressOf SeatButton_Click
            End If
        Next

        For Each ctrl As Control In panelEconomyClass.Controls
            If TypeOf ctrl Is Button AndAlso (ctrl.Name.StartsWith("btnEA") OrElse ctrl.Name.StartsWith("btnEB") OrElse ctrl.Name.StartsWith("btnEC")) Then
                Dim btnSeat As Button = DirectCast(ctrl, Button)
                seatStates(btnSeat) = "Available"
                btnSeat.BackColor = Color.Red
                AddHandler btnSeat.Click, AddressOf SeatButton_Click
            End If
        Next
    End Sub

    Private Sub SetPlaneCapacityFromDatabase()
        Try
            conn = New OleDbConnection(connStr)
            conn.Open()

            Dim cmd As New OleDbCommand("SELECT PlaneModel FROM FlightBooking WHERE BookingID = ?", conn)
            cmd.Parameters.AddWithValue("?", BookingID)

            Dim planeModel As String = cmd.ExecuteScalar()?.ToString()

            If planeModel IsNot Nothing Then
                Select Case planeModel
                    Case "Airbus A350"
                        TotalCapacity = 295
                    Case "Boeing 777"
                        TotalCapacity = 393
                    Case "Boeing 737"
                        TotalCapacity = 215
                    Case Else
                        TotalCapacity = 50
                End Select
            End If

            lblPlaneCapacity.Text = "Capacity: " & TotalCapacity.ToString()

        Catch ex As Exception
            MessageBox.Show("Error while fetching plane capacity: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn IsNot Nothing Then conn.Close()
        End Try
    End Sub

    Private Sub SeatButton_Click(sender As Object, e As EventArgs)
        Dim btnSeat As Button = DirectCast(sender, Button)

        If seatStates(btnSeat) = "Available" AndAlso GetSelectedSeatsCount() < TotalSeats Then
            seatStates(btnSeat) = "Selected"

            TotalCapacity -= 1
            lblPlaneCapacity.Text = "Capacity: " & TotalCapacity.ToString()

            If btnSeat.Name.StartsWith("btnB") Then
                btnSeat.BackColor = Color.LightGreen
            ElseIf btnSeat.Name.StartsWith("btnP") Then
                btnSeat.BackColor = Color.LightBlue
            ElseIf btnSeat.Name.StartsWith("btnE") Then
                btnSeat.BackColor = Color.LightCoral
            Else
                btnSeat.BackColor = Color.LightYellow
            End If

        ElseIf seatStates(btnSeat) = "Selected" Then
            seatStates(btnSeat) = "Available"

            TotalCapacity += 1
            lblPlaneCapacity.Text = "Capacity: " & TotalCapacity.ToString()

            If btnSeat.Name.StartsWith("btnB") Then
                btnSeat.BackColor = Color.Green
            ElseIf btnSeat.Name.StartsWith("btnP") Then
                btnSeat.BackColor = Color.Blue
            ElseIf btnSeat.Name.StartsWith("btnE") Then
                btnSeat.BackColor = Color.Red
            Else
                btnSeat.BackColor = Color.Yellow
            End If

        Else
            MessageBox.Show("You have already selected the maximum number of seats.", "Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Function GetSelectedSeatsCount() As Integer
        Return seatStates.Values.Where(Function(state) state = "Selected").Count()
    End Function

    Private Sub cmbChooseYourSeat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbChooseYourSeat.SelectedIndexChanged
        panelFirstClass.Enabled = False
        panelBusinessClass.Enabled = False
        panelPremClass.Enabled = False
        panelEconomyClass.Enabled = False

        Select Case cmbChooseYourSeat.SelectedItem.ToString()
            Case "First Class"
                panelFirstClass.Enabled = True
            Case "Business Class"
                panelBusinessClass.Enabled = True
            Case "Premium Economy Class"
                panelPremClass.Enabled = True
            Case "Economy Class"
                panelEconomyClass.Enabled = True
        End Select
    End Sub

    Public Property ParentForm7 As Form7
    Private Sub btnBookAFlight_Click(sender As Object, e As EventArgs) Handles btnBookAFlight.Click
        Dim bookedSeats As New List(Of String)
        Dim selectedSeats As New List(Of Button)

        For Each kvp As KeyValuePair(Of Button, String) In seatStates
            If kvp.Value = "Selected" Then
                selectedSeats.Add(kvp.Key)
                bookedSeats.Add(kvp.Key.Name.Replace("btn", ""))
            End If
        Next

        If bookedSeats.Count <> TotalSeats Then
            MessageBox.Show("Please select the correct number of seats.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            conn = New OleDbConnection(connStr)
            conn.Open()

            Dim cmd As New OleDbCommand("UPDATE [FlightBooking] SET [SeatNumbers] = ?, [Status] = ? WHERE [BookingID] = ?", conn)

            cmd.Parameters.AddWithValue("?", String.Join(", ", bookedSeats))
            cmd.Parameters.AddWithValue("?", "Booked")
            cmd.Parameters.AddWithValue("?", BookingID)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Seats booked successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error while booking seats: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn IsNot Nothing Then conn.Close()
        End Try

        If ParentForm7 IsNot Nothing Then
            Dim flightDetailsForm As New FormFlightDetails()
            flightDetailsForm.BookingID = Me.BookingID
            flightDetailsForm.ParentForm7 = Me.ParentForm7
            ParentForm7.OpenChildForm(flightDetailsForm)
        End If
    End Sub
End Class