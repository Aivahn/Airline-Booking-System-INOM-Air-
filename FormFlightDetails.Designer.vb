<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFlightDetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBookingID = New System.Windows.Forms.TextBox()
        Me.panelDetails = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDetailDisplay = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnShowFlight = New System.Windows.Forms.Button()
        Me.btnSaveDetails = New System.Windows.Forms.Button()
        Me.panelDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Berlin Sans FB", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Crimson
        Me.Label8.Location = New System.Drawing.Point(56, 43)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(220, 40)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Flight Details"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(115, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 22)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Booking ID:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtBookingID
        '
        Me.txtBookingID.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookingID.Location = New System.Drawing.Point(247, 116)
        Me.txtBookingID.Name = "txtBookingID"
        Me.txtBookingID.ReadOnly = True
        Me.txtBookingID.Size = New System.Drawing.Size(324, 30)
        Me.txtBookingID.TabIndex = 14
        '
        'panelDetails
        '
        Me.panelDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panelDetails.Controls.Add(Me.Label1)
        Me.panelDetails.Controls.Add(Me.lblDetailDisplay)
        Me.panelDetails.Location = New System.Drawing.Point(116, 169)
        Me.panelDetails.Name = "panelDetails"
        Me.panelDetails.Size = New System.Drawing.Size(777, 453)
        Me.panelDetails.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(261, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(285, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "NOM Airlines Flight Details"
        '
        'lblDetailDisplay
        '
        Me.lblDetailDisplay.AutoSize = True
        Me.lblDetailDisplay.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetailDisplay.Location = New System.Drawing.Point(33, 48)
        Me.lblDetailDisplay.Name = "lblDetailDisplay"
        Me.lblDetailDisplay.Size = New System.Drawing.Size(15, 18)
        Me.lblDetailDisplay.TabIndex = 0
        Me.lblDetailDisplay.Text = "*"
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.Red
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNext.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.White
        Me.btnNext.Location = New System.Drawing.Point(696, 648)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(197, 53)
        Me.btnNext.TabIndex = 41
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnShowFlight
        '
        Me.btnShowFlight.BackColor = System.Drawing.Color.Red
        Me.btnShowFlight.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnShowFlight.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowFlight.ForeColor = System.Drawing.Color.White
        Me.btnShowFlight.Location = New System.Drawing.Point(631, 116)
        Me.btnShowFlight.Name = "btnShowFlight"
        Me.btnShowFlight.Size = New System.Drawing.Size(262, 34)
        Me.btnShowFlight.TabIndex = 42
        Me.btnShowFlight.Text = "Show Flight"
        Me.btnShowFlight.UseVisualStyleBackColor = False
        '
        'btnSaveDetails
        '
        Me.btnSaveDetails.BackColor = System.Drawing.Color.Red
        Me.btnSaveDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSaveDetails.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveDetails.ForeColor = System.Drawing.Color.White
        Me.btnSaveDetails.Location = New System.Drawing.Point(540, 648)
        Me.btnSaveDetails.Name = "btnSaveDetails"
        Me.btnSaveDetails.Size = New System.Drawing.Size(150, 53)
        Me.btnSaveDetails.TabIndex = 43
        Me.btnSaveDetails.Text = "Save Details"
        Me.btnSaveDetails.UseVisualStyleBackColor = False
        '
        'FormFlightDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FlightSystem.My.Resources.Resources.photo_1593182440709_4b7b56482c55
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1000, 797)
        Me.Controls.Add(Me.btnSaveDetails)
        Me.Controls.Add(Me.btnShowFlight)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.panelDetails)
        Me.Controls.Add(Me.txtBookingID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label8)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FormFlightDetails"
        Me.Text = "FLIGHT DETAILS"
        Me.panelDetails.ResumeLayout(False)
        Me.panelDetails.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBookingID As TextBox
    Friend WithEvents panelDetails As Panel
    Friend WithEvents lblDetailDisplay As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents btnShowFlight As Button
    Friend WithEvents btnSaveDetails As Button
    Friend WithEvents Label1 As Label
End Class
