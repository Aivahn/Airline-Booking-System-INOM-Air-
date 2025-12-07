Imports System.Data.OleDb

Public Class FormFillUp
    Public connStr As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\flightBooking.mdb"
    Private conn As OleDbConnection

    Public Property TotalSeats As Integer

    Private Sub UpdateTotalSeats()
        TotalSeats = CInt(nudAdult.Value + nudChild.Value + nudPWD.Value + nudSenior.Value)
    End Sub

    Private Sub FormFillUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        txtBookingID.Text = BookingID
    End Sub

    Public Property BookingID As String

    Private Sub btnSaveDetails_Click(sender As Object, e As EventArgs) Handles btnSaveDetails.Click
        conn = New OleDbConnection(connStr)

        Try
            conn.Open()

            Dim cmd As New OleDbCommand("UPDATE [FlightBooking] SET [FullName] = ?, [Email] = ?, [DateOfBirth] = ?, [Age] = ?, [Sex] = ?, [Address] = ?, [BaggageAllowance] = ? WHERE [BookingID] = ?", conn)
            cmd.Parameters.AddWithValue("?", txtFullName.Text)
            cmd.Parameters.AddWithValue("?", txtEmail.Text)
            cmd.Parameters.AddWithValue("?", dtDateOfBirth.Value)
            cmd.Parameters.AddWithValue("?", txtAge.Text)
            cmd.Parameters.AddWithValue("?", cmbSex.SelectedItem)
            cmd.Parameters.AddWithValue("?", txtAddress.Text)
            cmd.Parameters.AddWithValue("?", cmbBaggageAllowance.SelectedItem)
            cmd.Parameters.AddWithValue("?", BookingID)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Passenger details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error while updating booking: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub
    Public Property ParentForm7 As Form7
    Private Sub btnSelectSeat_Click(sender As Object, e As EventArgs) Handles btnSelectSeat.Click
        UpdateTotalSeats()

        If TotalSeats <= 0 Then
            MessageBox.Show("Please select at least one passenger.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            conn = New OleDbConnection(connStr)
            conn.Open()
            Dim cmd As New OleDbCommand("UPDATE [FlightBooking] SET [Adult] = ?, [Child] = ?, [PWD] = ?, [Senior] = ? WHERE [BookingID] = ?", conn)
            cmd.Parameters.AddWithValue("?", nudAdult.Value)
            cmd.Parameters.AddWithValue("?", nudChild.Value)
            cmd.Parameters.AddWithValue("?", nudPWD.Value)
            cmd.Parameters.AddWithValue("?", nudSenior.Value)
            cmd.Parameters.AddWithValue("?", BookingID)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Seat details saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error while saving seat details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn IsNot Nothing Then conn.Close()
        End Try


        If ParentForm7 IsNot Nothing Then
            Dim seatForm As New FormSeat()
            seatForm.BookingID = BookingID
            seatForm.TotalSeats = TotalSeats
            seatForm.ParentForm7 = Me.ParentForm7
            ParentForm7.OpenChildForm(seatForm)
        End If

    End Sub

    Private Sub dtDateOfBirth_ValueChanged(sender As Object, e As EventArgs) Handles dtDateOfBirth.ValueChanged
        Dim birthdate As DateTime = dtDateOfBirth.Value
        Dim today As DateTime = DateTime.Today
        Dim age As Integer = today.Year - birthdate.Year

        If (today.Month < birthdate.Month) OrElse (today.Month = birthdate.Month AndAlso today.Day < birthdate.Day) Then
            age -= 1
        End If

        txtAge.Text = age.ToString()
    End Sub


End Class
