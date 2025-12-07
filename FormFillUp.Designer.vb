<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormFillUp
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
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnSaveDetails = New System.Windows.Forms.Button()
        Me.txtBookingID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbBaggageAllowance = New System.Windows.Forms.ComboBox()
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
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.nudChild = New System.Windows.Forms.NumericUpDown()
        Me.lblChild = New System.Windows.Forms.Label()
        Me.lblAdult = New System.Windows.Forms.Label()
        Me.nudAdult = New System.Windows.Forms.NumericUpDown()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblPWD = New System.Windows.Forms.Label()
        Me.nudSenior = New System.Windows.Forms.NumericUpDown()
        Me.nudPWD = New System.Windows.Forms.NumericUpDown()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.nudChild, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudAdult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.nudSenior, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPWD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSelectSeat
        '
        Me.btnSelectSeat.BackColor = System.Drawing.Color.Red
        Me.btnSelectSeat.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSelectSeat.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectSeat.ForeColor = System.Drawing.Color.White
        Me.btnSelectSeat.Location = New System.Drawing.Point(293, 222)
        Me.btnSelectSeat.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSelectSeat.Name = "btnSelectSeat"
        Me.btnSelectSeat.Size = New System.Drawing.Size(124, 43)
        Me.btnSelectSeat.TabIndex = 18
        Me.btnSelectSeat.Text = "Select a Seat"
        Me.btnSelectSeat.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Red
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(421, 222)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(124, 43)
        Me.btnCancel.TabIndex = 19
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Berlin Sans FB", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Crimson
        Me.Label8.Location = New System.Drawing.Point(85, 22)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(243, 40)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Flight Booking"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PowderBlue
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.btnSaveDetails)
        Me.Panel1.Controls.Add(Me.txtBookingID)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.cmbBaggageAllowance)
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
        Me.Panel1.Controls.Add(Me.txtEmail)
        Me.Panel1.Controls.Add(Me.txtFullName)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(92, 64)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(825, 326)
        Me.Panel1.TabIndex = 9
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Gill Sans MT", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(542, 243)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(152, 16)
        Me.Label15.TabIndex = 23
        Me.Label15.Text = "Please take note of your BookingID"
        '
        'btnSaveDetails
        '
        Me.btnSaveDetails.BackColor = System.Drawing.Color.Red
        Me.btnSaveDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSaveDetails.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveDetails.ForeColor = System.Drawing.Color.LightYellow
        Me.btnSaveDetails.Location = New System.Drawing.Point(333, 261)
        Me.btnSaveDetails.Name = "btnSaveDetails"
        Me.btnSaveDetails.Size = New System.Drawing.Size(129, 46)
        Me.btnSaveDetails.TabIndex = 13
        Me.btnSaveDetails.Text = "Save"
        Me.btnSaveDetails.UseVisualStyleBackColor = False
        '
        'txtBookingID
        '
        Me.txtBookingID.BackColor = System.Drawing.Color.White
        Me.txtBookingID.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookingID.Location = New System.Drawing.Point(540, 213)
        Me.txtBookingID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBookingID.Name = "txtBookingID"
        Me.txtBookingID.ReadOnly = True
        Me.txtBookingID.Size = New System.Drawing.Size(234, 28)
        Me.txtBookingID.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(537, 198)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "BookingID"
        '
        'cmbBaggageAllowance
        '
        Me.cmbBaggageAllowance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBaggageAllowance.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBaggageAllowance.FormattingEnabled = True
        Me.cmbBaggageAllowance.Items.AddRange(New Object() {"10kg", "20kg", "40kg"})
        Me.cmbBaggageAllowance.Location = New System.Drawing.Point(288, 214)
        Me.cmbBaggageAllowance.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbBaggageAllowance.Name = "cmbBaggageAllowance"
        Me.cmbBaggageAllowance.Size = New System.Drawing.Size(234, 30)
        Me.cmbBaggageAllowance.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(285, 200)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(132, 13)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Baggage Allowance"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(537, 65)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(115, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Contact Number"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(36, 198)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Address"
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.Color.White
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(39, 214)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAddress.MaxLength = 200
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(231, 28)
        Me.txtAddress.TabIndex = 10
        '
        'txtContactNumber
        '
        Me.txtContactNumber.BackColor = System.Drawing.Color.White
        Me.txtContactNumber.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactNumber.Location = New System.Drawing.Point(540, 80)
        Me.txtContactNumber.Margin = New System.Windows.Forms.Padding(2)
        Me.txtContactNumber.MaxLength = 20
        Me.txtContactNumber.Name = "txtContactNumber"
        Me.txtContactNumber.Size = New System.Drawing.Size(234, 30)
        Me.txtContactNumber.TabIndex = 6
        '
        'cmbSex
        '
        Me.cmbSex.BackColor = System.Drawing.Color.White
        Me.cmbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSex.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSex.FormattingEnabled = True
        Me.cmbSex.Items.AddRange(New Object() {"Male", "Female", "Others"})
        Me.cmbSex.Location = New System.Drawing.Point(540, 145)
        Me.cmbSex.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbSex.Name = "cmbSex"
        Me.cmbSex.Size = New System.Drawing.Size(234, 31)
        Me.cmbSex.TabIndex = 9
        '
        'txtAge
        '
        Me.txtAge.BackColor = System.Drawing.Color.White
        Me.txtAge.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.Location = New System.Drawing.Point(288, 147)
        Me.txtAge.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.ReadOnly = True
        Me.txtAge.Size = New System.Drawing.Size(234, 30)
        Me.txtAge.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(285, 132)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Age"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(32, 130)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 13)
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
        Me.dtDateOfBirth.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDateOfBirth.Location = New System.Drawing.Point(36, 145)
        Me.dtDateOfBirth.Margin = New System.Windows.Forms.Padding(2)
        Me.dtDateOfBirth.MaxDate = New Date(2099, 12, 31, 0, 0, 0, 0)
        Me.dtDateOfBirth.MinDate = New Date(1940, 1, 1, 0, 0, 0, 0)
        Me.dtDateOfBirth.Name = "dtDateOfBirth"
        Me.dtDateOfBirth.Size = New System.Drawing.Size(234, 30)
        Me.dtDateOfBirth.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(537, 130)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Sex"
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.White
        Me.txtEmail.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(288, 82)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmail.MaxLength = 100
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(234, 30)
        Me.txtEmail.TabIndex = 5
        '
        'txtFullName
        '
        Me.txtFullName.BackColor = System.Drawing.Color.White
        Me.txtFullName.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullName.Location = New System.Drawing.Point(35, 80)
        Me.txtFullName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFullName.MaxLength = 50
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(234, 30)
        Me.txtFullName.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(285, 67)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Email"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 65)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Full Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Your Details"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(17, 26)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(102, 23)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Passengers"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.PowderBlue
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.btnCancel)
        Me.Panel2.Controls.Add(Me.btnSelectSeat)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Location = New System.Drawing.Point(92, 429)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(825, 294)
        Me.Panel2.TabIndex = 23
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.nudChild)
        Me.Panel4.Controls.Add(Me.lblChild)
        Me.Panel4.Controls.Add(Me.lblAdult)
        Me.Panel4.Controls.Add(Me.nudAdult)
        Me.Panel4.Location = New System.Drawing.Point(125, 60)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(292, 142)
        Me.Panel4.TabIndex = 27
        '
        'nudChild
        '
        Me.nudChild.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudChild.Location = New System.Drawing.Point(90, 85)
        Me.nudChild.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.nudChild.Name = "nudChild"
        Me.nudChild.Size = New System.Drawing.Size(120, 22)
        Me.nudChild.TabIndex = 15
        '
        'lblChild
        '
        Me.lblChild.AutoSize = True
        Me.lblChild.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChild.Location = New System.Drawing.Point(34, 89)
        Me.lblChild.Name = "lblChild"
        Me.lblChild.Size = New System.Drawing.Size(47, 18)
        Me.lblChild.TabIndex = 29
        Me.lblChild.Text = "Child"
        '
        'lblAdult
        '
        Me.lblAdult.AutoSize = True
        Me.lblAdult.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdult.Location = New System.Drawing.Point(31, 35)
        Me.lblAdult.Name = "lblAdult"
        Me.lblAdult.Size = New System.Drawing.Size(50, 18)
        Me.lblAdult.TabIndex = 28
        Me.lblAdult.Text = "Adult"
        '
        'nudAdult
        '
        Me.nudAdult.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudAdult.Location = New System.Drawing.Point(90, 31)
        Me.nudAdult.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.nudAdult.Name = "nudAdult"
        Me.nudAdult.Size = New System.Drawing.Size(120, 22)
        Me.nudAdult.TabIndex = 14
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.lblPWD)
        Me.Panel3.Controls.Add(Me.nudSenior)
        Me.Panel3.Controls.Add(Me.nudPWD)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Location = New System.Drawing.Point(421, 60)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(292, 142)
        Me.Panel3.TabIndex = 26
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(16, 89)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(120, 18)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "Senior Citizen"
        '
        'lblPWD
        '
        Me.lblPWD.AutoSize = True
        Me.lblPWD.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPWD.Location = New System.Drawing.Point(92, 40)
        Me.lblPWD.Name = "lblPWD"
        Me.lblPWD.Size = New System.Drawing.Size(44, 18)
        Me.lblPWD.TabIndex = 31
        Me.lblPWD.Text = "PWD"
        '
        'nudSenior
        '
        Me.nudSenior.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudSenior.Location = New System.Drawing.Point(142, 85)
        Me.nudSenior.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.nudSenior.Name = "nudSenior"
        Me.nudSenior.Size = New System.Drawing.Size(120, 22)
        Me.nudSenior.TabIndex = 17
        '
        'nudPWD
        '
        Me.nudPWD.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudPWD.Location = New System.Drawing.Point(142, 36)
        Me.nudPWD.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.nudPWD.Name = "nudPWD"
        Me.nudPWD.Size = New System.Drawing.Size(120, 22)
        Me.nudPWD.TabIndex = 16
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(16, 13)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(81, 15)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "with Discount"
        '
        'FormFillUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FlightSystem.My.Resources.Resources.photo_1593182440709_4b7b56482c55
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1000, 797)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormFillUp"
        Me.Text = "FILL-UP FORM"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.nudChild, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudAdult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.nudSenior, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPWD, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBookingID As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents nudPWD As NumericUpDown
    Friend WithEvents nudSenior As NumericUpDown
    Friend WithEvents Panel4 As Panel
    Friend WithEvents nudAdult As NumericUpDown
    Friend WithEvents lblAdult As Label
    Friend WithEvents lblChild As Label
    Friend WithEvents nudChild As NumericUpDown
    Friend WithEvents Label14 As Label
    Friend WithEvents lblPWD As Label
    Friend WithEvents btnSaveDetails As Button
    Friend WithEvents Label15 As Label
End Class
