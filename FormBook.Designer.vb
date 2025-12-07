<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBook
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbPlaneTrip = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbFlightTo = New System.Windows.Forms.ComboBox()
        Me.cmbFlightFrom = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.dtpReturning = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtpDeparture = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lstAvailableFlights = New System.Windows.Forms.ListBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.cmbPlaneTrip)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.cmbFlightTo)
        Me.Panel2.Controls.Add(Me.cmbFlightFrom)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(40, 74)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(920, 101)
        Me.Panel2.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(22, 23)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 18)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Plane Trip"
        '
        'cmbPlaneTrip
        '
        Me.cmbPlaneTrip.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPlaneTrip.FormattingEnabled = True
        Me.cmbPlaneTrip.Location = New System.Drawing.Point(24, 54)
        Me.cmbPlaneTrip.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbPlaneTrip.Name = "cmbPlaneTrip"
        Me.cmbPlaneTrip.Size = New System.Drawing.Size(119, 26)
        Me.cmbPlaneTrip.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(154, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Flight From"
        '
        'cmbFlightTo
        '
        Me.cmbFlightTo.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFlightTo.FormattingEnabled = True
        Me.cmbFlightTo.Location = New System.Drawing.Point(514, 54)
        Me.cmbFlightTo.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbFlightTo.Name = "cmbFlightTo"
        Me.cmbFlightTo.Size = New System.Drawing.Size(377, 26)
        Me.cmbFlightTo.TabIndex = 8
        '
        'cmbFlightFrom
        '
        Me.cmbFlightFrom.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFlightFrom.FormattingEnabled = True
        Me.cmbFlightFrom.Location = New System.Drawing.Point(157, 54)
        Me.cmbFlightFrom.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbFlightFrom.Name = "cmbFlightFrom"
        Me.cmbFlightFrom.Size = New System.Drawing.Size(288, 26)
        Me.cmbFlightFrom.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(511, 23)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Flight To"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(467, 50)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 30)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "⇆"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.dtpReturning)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.dtpDeparture)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(40, 185)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(920, 178)
        Me.Panel1.TabIndex = 6
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.Red
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(341, 115)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnSearch.Size = New System.Drawing.Size(229, 48)
        Me.btnSearch.TabIndex = 11
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'dtpReturning
        '
        Me.dtpReturning.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpReturning.Location = New System.Drawing.Point(514, 57)
        Me.dtpReturning.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpReturning.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.dtpReturning.MinDate = New Date(2024, 11, 27, 0, 0, 0, 0)
        Me.dtpReturning.Name = "dtpReturning"
        Me.dtpReturning.Size = New System.Drawing.Size(308, 25)
        Me.dtpReturning.TabIndex = 10
        Me.dtpReturning.Value = New Date(2024, 12, 9, 0, 0, 0, 0)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(511, 25)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 18)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Returning"
        '
        'dtpDeparture
        '
        Me.dtpDeparture.CustomFormat = "MM/dd/yyyy hh:mm:ss"
        Me.dtpDeparture.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDeparture.Location = New System.Drawing.Point(25, 57)
        Me.dtpDeparture.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpDeparture.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.dtpDeparture.MinDate = New Date(2024, 11, 27, 0, 0, 0, 0)
        Me.dtpDeparture.Name = "dtpDeparture"
        Me.dtpDeparture.Size = New System.Drawing.Size(327, 25)
        Me.dtpDeparture.TabIndex = 6
        Me.dtpDeparture.Value = New Date(2024, 12, 7, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 25)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 18)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Departure"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Berlin Sans FB", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Crimson
        Me.Label8.Location = New System.Drawing.Point(33, 32)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(243, 40)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Flight Booking"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.lstAvailableFlights)
        Me.Panel3.Location = New System.Drawing.Point(40, 386)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(920, 236)
        Me.Panel3.TabIndex = 8
        '
        'lstAvailableFlights
        '
        Me.lstAvailableFlights.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstAvailableFlights.FormattingEnabled = True
        Me.lstAvailableFlights.ItemHeight = 22
        Me.lstAvailableFlights.Location = New System.Drawing.Point(24, 21)
        Me.lstAvailableFlights.Name = "lstAvailableFlights"
        Me.lstAvailableFlights.Size = New System.Drawing.Size(865, 180)
        Me.lstAvailableFlights.TabIndex = 0
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.Red
        Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnConfirm.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.ForeColor = System.Drawing.Color.White
        Me.btnConfirm.Location = New System.Drawing.Point(754, 642)
        Me.btnConfirm.Margin = New System.Windows.Forms.Padding(2)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnConfirm.Size = New System.Drawing.Size(206, 60)
        Me.btnConfirm.TabIndex = 12
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(166, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "*Enter your desired departure time"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(511, 84)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(149, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "*Enter your desired arrival time"
        '
        'FormBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FlightSystem.My.Resources.Resources.photo_1593182440709_4b7b56482c55
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1000, 797)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label8)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormBook"
        Me.Text = "FLIGHT BOOKING"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbPlaneTrip As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSearch As Button
    Friend WithEvents dtpReturning As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbFlightTo As ComboBox
    Friend WithEvents cmbFlightFrom As ComboBox
    Friend WithEvents dtpDeparture As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnConfirm As Button
    Friend WithEvents lstAvailableFlights As ListBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
End Class
