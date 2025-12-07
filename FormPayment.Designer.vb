<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPayment
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBookingId = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSeatNumber = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTotalPrice = New System.Windows.Forms.TextBox()
        Me.btnCancel2 = New System.Windows.Forms.Button()
        Me.btnReceipt = New System.Windows.Forms.Button()
        Me.btnFinishPayment = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtBaggageAllowance = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnEWallet = New System.Windows.Forms.Button()
        Me.btnCard = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Berlin Sans FB", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Crimson
        Me.Label8.Location = New System.Drawing.Point(362, 69)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(264, 40)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Billing Payment"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 18)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Booking ID:"
        '
        'txtBookingId
        '
        Me.txtBookingId.Font = New System.Drawing.Font("Lucida Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookingId.Location = New System.Drawing.Point(207, 23)
        Me.txtBookingId.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBookingId.Name = "txtBookingId"
        Me.txtBookingId.ReadOnly = True
        Me.txtBookingId.Size = New System.Drawing.Size(266, 32)
        Me.txtBookingId.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 81)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 18)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Seat Number:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtSeatNumber
        '
        Me.txtSeatNumber.Font = New System.Drawing.Font("Lucida Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSeatNumber.Location = New System.Drawing.Point(207, 74)
        Me.txtSeatNumber.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSeatNumber.Name = "txtSeatNumber"
        Me.txtSeatNumber.ReadOnly = True
        Me.txtSeatNumber.Size = New System.Drawing.Size(266, 32)
        Me.txtSeatNumber.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 128)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(170, 18)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Baggage Allowance:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label5.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 175)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 18)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Discount:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtDiscount
        '
        Me.txtDiscount.Font = New System.Drawing.Font("Lucida Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscount.Location = New System.Drawing.Point(207, 168)
        Me.txtDiscount.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.ReadOnly = True
        Me.txtDiscount.Size = New System.Drawing.Size(266, 32)
        Me.txtDiscount.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label6.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 222)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 18)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Total Price:"
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.Font = New System.Drawing.Font("Lucida Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPrice.Location = New System.Drawing.Point(207, 215)
        Me.txtTotalPrice.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.ReadOnly = True
        Me.txtTotalPrice.Size = New System.Drawing.Size(266, 32)
        Me.txtTotalPrice.TabIndex = 25
        '
        'btnCancel2
        '
        Me.btnCancel2.BackColor = System.Drawing.Color.Red
        Me.btnCancel2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel2.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel2.ForeColor = System.Drawing.Color.White
        Me.btnCancel2.Location = New System.Drawing.Point(340, 19)
        Me.btnCancel2.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancel2.Name = "btnCancel2"
        Me.btnCancel2.Size = New System.Drawing.Size(145, 43)
        Me.btnCancel2.TabIndex = 42
        Me.btnCancel2.Text = "Cancel"
        Me.btnCancel2.UseVisualStyleBackColor = False
        '
        'btnReceipt
        '
        Me.btnReceipt.BackColor = System.Drawing.Color.Red
        Me.btnReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReceipt.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReceipt.ForeColor = System.Drawing.Color.White
        Me.btnReceipt.Location = New System.Drawing.Point(23, 17)
        Me.btnReceipt.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReceipt.Name = "btnReceipt"
        Me.btnReceipt.Size = New System.Drawing.Size(138, 43)
        Me.btnReceipt.TabIndex = 43
        Me.btnReceipt.Text = "Receipt"
        Me.btnReceipt.UseVisualStyleBackColor = False
        '
        'btnFinishPayment
        '
        Me.btnFinishPayment.BackColor = System.Drawing.Color.Red
        Me.btnFinishPayment.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFinishPayment.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinishPayment.ForeColor = System.Drawing.Color.White
        Me.btnFinishPayment.Location = New System.Drawing.Point(180, 17)
        Me.btnFinishPayment.Margin = New System.Windows.Forms.Padding(2)
        Me.btnFinishPayment.Name = "btnFinishPayment"
        Me.btnFinishPayment.Size = New System.Drawing.Size(143, 45)
        Me.btnFinishPayment.TabIndex = 44
        Me.btnFinishPayment.Text = "Finish Payment"
        Me.btnFinishPayment.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.txtBaggageAllowance)
        Me.Panel1.Controls.Add(Me.txtTotalPrice)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtBookingId)
        Me.Panel1.Controls.Add(Me.txtSeatNumber)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtDiscount)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(243, 123)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(502, 275)
        Me.Panel1.TabIndex = 45
        '
        'txtBaggageAllowance
        '
        Me.txtBaggageAllowance.Font = New System.Drawing.Font("Lucida Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBaggageAllowance.Location = New System.Drawing.Point(207, 121)
        Me.txtBaggageAllowance.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBaggageAllowance.Name = "txtBaggageAllowance"
        Me.txtBaggageAllowance.ReadOnly = True
        Me.txtBaggageAllowance.Size = New System.Drawing.Size(266, 32)
        Me.txtBaggageAllowance.TabIndex = 25
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.btnFinishPayment)
        Me.Panel2.Controls.Add(Me.btnCancel2)
        Me.Panel2.Controls.Add(Me.btnReceipt)
        Me.Panel2.Location = New System.Drawing.Point(243, 542)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(502, 81)
        Me.Panel2.TabIndex = 46
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnEWallet)
        Me.GroupBox1.Controls.Add(Me.btnCard)
        Me.GroupBox1.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(243, 414)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(502, 113)
        Me.GroupBox1.TabIndex = 47
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mode of Payment"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(303, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(133, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "*GCash, Paymaya, Paypal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(67, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "*Visa, MasterCard, AmEx"
        '
        'btnEWallet
        '
        Me.btnEWallet.BackColor = System.Drawing.Color.LightBlue
        Me.btnEWallet.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEWallet.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEWallet.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnEWallet.Location = New System.Drawing.Point(306, 34)
        Me.btnEWallet.Name = "btnEWallet"
        Me.btnEWallet.Size = New System.Drawing.Size(107, 37)
        Me.btnEWallet.TabIndex = 1
        Me.btnEWallet.Text = "E-Wallet"
        Me.btnEWallet.UseVisualStyleBackColor = False
        '
        'btnCard
        '
        Me.btnCard.BackColor = System.Drawing.Color.LightBlue
        Me.btnCard.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCard.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCard.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnCard.Location = New System.Drawing.Point(70, 34)
        Me.btnCard.Name = "btnCard"
        Me.btnCard.Size = New System.Drawing.Size(108, 37)
        Me.btnCard.TabIndex = 0
        Me.btnCard.Text = "Card"
        Me.btnCard.UseVisualStyleBackColor = False
        '
        'FormPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FlightSystem.My.Resources.Resources.photo_1593182440709_4b7b56482c55
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1000, 797)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "FormPayment"
        Me.Text = "BILLING PAYMENT"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBookingId As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSeatNumber As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDiscount As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTotalPrice As TextBox
    Friend WithEvents btnCancel2 As Button
    Friend WithEvents btnReceipt As Button
    Friend WithEvents btnFinishPayment As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtBaggageAllowance As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnEWallet As Button
    Friend WithEvents btnCard As Button
    Friend WithEvents Label7 As Label
End Class
