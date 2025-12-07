<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Me.btnSelectSeat = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.chckPWD = New System.Windows.Forms.CheckBox()
        Me.chckSeniorCitizen = New System.Windows.Forms.CheckBox()
        Me.xtFlightNumber = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbBaggageAllowance = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtContactNumber = New System.Windows.Forms.TextBox()
        Me.cmbSex = New System.Windows.Forms.ComboBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtDateOfBirth = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSelectSeat
        '
        Me.btnSelectSeat.BackColor = System.Drawing.Color.Red
        Me.btnSelectSeat.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSelectSeat.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectSeat.ForeColor = System.Drawing.Color.White
        Me.btnSelectSeat.Location = New System.Drawing.Point(357, 466)
        Me.btnSelectSeat.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSelectSeat.Name = "btnSelectSeat"
        Me.btnSelectSeat.Size = New System.Drawing.Size(178, 43)
        Me.btnSelectSeat.TabIndex = 13
        Me.btnSelectSeat.Text = "Select a Seat"
        Me.btnSelectSeat.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Red
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(575, 466)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(178, 43)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label8.Location = New System.Drawing.Point(54, 38)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(231, 45)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Flight Booking"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.xtFlightNumber)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.cmbBaggageAllowance)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtAddress)
        Me.Panel1.Controls.Add(Me.txtContactNumber)
        Me.Panel1.Controls.Add(Me.cmbSex)
        Me.Panel1.Controls.Add(Me.txtAge)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.dtDateOfBirth)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtFullName)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(68, 85)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(685, 356)
        Me.Panel1.TabIndex = 9
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.chckPWD)
        Me.Panel3.Controls.Add(Me.chckSeniorCitizen)
        Me.Panel3.Location = New System.Drawing.Point(31, 268)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(192, 43)
        Me.Panel3.TabIndex = 26
        '
        'chckPWD
        '
        Me.chckPWD.AutoSize = True
        Me.chckPWD.BackColor = System.Drawing.Color.White
        Me.chckPWD.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chckPWD.Location = New System.Drawing.Point(7, 7)
        Me.chckPWD.Margin = New System.Windows.Forms.Padding(2)
        Me.chckPWD.Name = "chckPWD"
        Me.chckPWD.Size = New System.Drawing.Size(62, 24)
        Me.chckPWD.TabIndex = 24
        Me.chckPWD.Text = "PWD"
        Me.chckPWD.UseVisualStyleBackColor = False
        '
        'chckSeniorCitizen
        '
        Me.chckSeniorCitizen.AutoSize = True
        Me.chckSeniorCitizen.BackColor = System.Drawing.Color.White
        Me.chckSeniorCitizen.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chckSeniorCitizen.Location = New System.Drawing.Point(68, 7)
        Me.chckSeniorCitizen.Margin = New System.Windows.Forms.Padding(2)
        Me.chckSeniorCitizen.Name = "chckSeniorCitizen"
        Me.chckSeniorCitizen.Size = New System.Drawing.Size(122, 24)
        Me.chckSeniorCitizen.TabIndex = 25
        Me.chckSeniorCitizen.Text = "Senior Citizen"
        Me.chckSeniorCitizen.UseVisualStyleBackColor = False
        '
        'xtFlightNumber
        '
        Me.xtFlightNumber.BackColor = System.Drawing.Color.White
        Me.xtFlightNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xtFlightNumber.Location = New System.Drawing.Point(460, 275)
        Me.xtFlightNumber.Margin = New System.Windows.Forms.Padding(2)
        Me.xtFlightNumber.Name = "xtFlightNumber"
        Me.xtFlightNumber.Size = New System.Drawing.Size(179, 28)
        Me.xtFlightNumber.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(457, 246)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 15)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Flight Number"
        '
        'cmbBaggageAllowance
        '
        Me.cmbBaggageAllowance.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBaggageAllowance.FormattingEnabled = True
        Me.cmbBaggageAllowance.Items.AddRange(New Object() {"10kg", "20kg", "40kg"})
        Me.cmbBaggageAllowance.Location = New System.Drawing.Point(250, 274)
        Me.cmbBaggageAllowance.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbBaggageAllowance.Name = "cmbBaggageAllowance"
        Me.cmbBaggageAllowance.Size = New System.Drawing.Size(180, 30)
        Me.cmbBaggageAllowance.TabIndex = 19
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(33, 246)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(55, 15)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Discount"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(247, 246)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(111, 15)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Baggage Allowance"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(247, 65)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 15)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Contact Number"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(466, 158)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 15)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Address"
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.Color.White
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(469, 188)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(182, 28)
        Me.txtAddress.TabIndex = 15
        '
        'txtContactNumber
        '
        Me.txtContactNumber.BackColor = System.Drawing.Color.White
        Me.txtContactNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactNumber.Location = New System.Drawing.Point(250, 94)
        Me.txtContactNumber.Margin = New System.Windows.Forms.Padding(2)
        Me.txtContactNumber.Name = "txtContactNumber"
        Me.txtContactNumber.Size = New System.Drawing.Size(179, 28)
        Me.txtContactNumber.TabIndex = 14
        '
        'cmbSex
        '
        Me.cmbSex.BackColor = System.Drawing.Color.White
        Me.cmbSex.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSex.FormattingEnabled = True
        Me.cmbSex.Items.AddRange(New Object() {"Male", "Female", "Others"})
        Me.cmbSex.Location = New System.Drawing.Point(250, 185)
        Me.cmbSex.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbSex.Name = "cmbSex"
        Me.cmbSex.Size = New System.Drawing.Size(179, 30)
        Me.cmbSex.TabIndex = 12
        '
        'txtAge
        '
        Me.txtAge.BackColor = System.Drawing.Color.White
        Me.txtAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.Location = New System.Drawing.Point(36, 178)
        Me.txtAge.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(180, 28)
        Me.txtAge.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(33, 147)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 15)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Age"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(456, 65)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 15)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Date of Birth"
        '
        'dtDateOfBirth
        '
        Me.dtDateOfBirth.CalendarForeColor = System.Drawing.Color.White
        Me.dtDateOfBirth.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtDateOfBirth.CalendarTitleBackColor = System.Drawing.Color.White
        Me.dtDateOfBirth.CalendarTitleForeColor = System.Drawing.Color.White
        Me.dtDateOfBirth.CalendarTrailingForeColor = System.Drawing.Color.White
        Me.dtDateOfBirth.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDateOfBirth.Location = New System.Drawing.Point(460, 94)
        Me.dtDateOfBirth.Margin = New System.Windows.Forms.Padding(2)
        Me.dtDateOfBirth.Name = "dtDateOfBirth"
        Me.dtDateOfBirth.Size = New System.Drawing.Size(182, 28)
        Me.dtDateOfBirth.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(247, 158)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Sex"
        '
        'txtFullName
        '
        Me.txtFullName.BackColor = System.Drawing.Color.White
        Me.txtFullName.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullName.Location = New System.Drawing.Point(35, 94)
        Me.txtFullName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(182, 28)
        Me.txtFullName.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 65)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Full Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Your Details"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FlightSystem.My.Resources.Resources.photo_1593182440709_4b7b56482c55
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(820, 540)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnSelectSeat)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSelectSeat As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbBaggageAllowance As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtContactNumber As TextBox
    Friend WithEvents cmbSex As ComboBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents dtDateOfBirth As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents xtFlightNumber As TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label13 As Label
    Friend WithEvents chckSeniorCitizen As CheckBox
    Friend WithEvents chckPWD As CheckBox
    Friend WithEvents Panel3 As Panel
End Class
