<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCard
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtCVV = New System.Windows.Forms.TextBox()
        Me.txtExpiryYear = New System.Windows.Forms.TextBox()
        Me.txtExpiryMonth = New System.Windows.Forms.TextBox()
        Me.txtCardNumber = New System.Windows.Forms.TextBox()
        Me.txtCardHolder = New System.Windows.Forms.TextBox()
        Me.lblCVV = New System.Windows.Forms.Label()
        Me.lblExpiry = New System.Windows.Forms.Label()
        Me.lblCardNumber = New System.Windows.Forms.Label()
        Me.lblCardHolder = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblTotalPriceCard = New System.Windows.Forms.Label()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.btnBackCard = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(67, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Card Payment"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Azure
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtCVV)
        Me.Panel1.Controls.Add(Me.txtExpiryYear)
        Me.Panel1.Controls.Add(Me.txtExpiryMonth)
        Me.Panel1.Controls.Add(Me.txtCardNumber)
        Me.Panel1.Controls.Add(Me.txtCardHolder)
        Me.Panel1.Controls.Add(Me.lblCVV)
        Me.Panel1.Controls.Add(Me.lblExpiry)
        Me.Panel1.Controls.Add(Me.lblCardNumber)
        Me.Panel1.Controls.Add(Me.lblCardHolder)
        Me.Panel1.Location = New System.Drawing.Point(72, 88)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(393, 268)
        Me.Panel1.TabIndex = 1
        '
        'txtCVV
        '
        Me.txtCVV.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCVV.Location = New System.Drawing.Point(180, 202)
        Me.txtCVV.MaxLength = 4
        Me.txtCVV.Name = "txtCVV"
        Me.txtCVV.Size = New System.Drawing.Size(51, 29)
        Me.txtCVV.TabIndex = 8
        '
        'txtExpiryYear
        '
        Me.txtExpiryYear.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExpiryYear.Location = New System.Drawing.Point(90, 202)
        Me.txtExpiryYear.MaxLength = 4
        Me.txtExpiryYear.Name = "txtExpiryYear"
        Me.txtExpiryYear.Size = New System.Drawing.Size(51, 29)
        Me.txtExpiryYear.TabIndex = 7
        '
        'txtExpiryMonth
        '
        Me.txtExpiryMonth.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExpiryMonth.Location = New System.Drawing.Point(33, 202)
        Me.txtExpiryMonth.MaxLength = 2
        Me.txtExpiryMonth.Name = "txtExpiryMonth"
        Me.txtExpiryMonth.Size = New System.Drawing.Size(51, 29)
        Me.txtExpiryMonth.TabIndex = 6
        '
        'txtCardNumber
        '
        Me.txtCardNumber.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCardNumber.Location = New System.Drawing.Point(30, 125)
        Me.txtCardNumber.MaxLength = 19
        Me.txtCardNumber.Name = "txtCardNumber"
        Me.txtCardNumber.Size = New System.Drawing.Size(317, 29)
        Me.txtCardNumber.TabIndex = 5
        '
        'txtCardHolder
        '
        Me.txtCardHolder.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCardHolder.Location = New System.Drawing.Point(30, 40)
        Me.txtCardHolder.MaxLength = 100
        Me.txtCardHolder.Name = "txtCardHolder"
        Me.txtCardHolder.Size = New System.Drawing.Size(317, 29)
        Me.txtCardHolder.TabIndex = 4
        '
        'lblCVV
        '
        Me.lblCVV.AutoSize = True
        Me.lblCVV.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCVV.Location = New System.Drawing.Point(176, 178)
        Me.lblCVV.Name = "lblCVV"
        Me.lblCVV.Size = New System.Drawing.Size(40, 21)
        Me.lblCVV.TabIndex = 3
        Me.lblCVV.Text = "CVV"
        '
        'lblExpiry
        '
        Me.lblExpiry.AutoSize = True
        Me.lblExpiry.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExpiry.Location = New System.Drawing.Point(29, 178)
        Me.lblExpiry.Name = "lblExpiry"
        Me.lblExpiry.Size = New System.Drawing.Size(55, 21)
        Me.lblExpiry.TabIndex = 2
        Me.lblExpiry.Text = "Expiry"
        '
        'lblCardNumber
        '
        Me.lblCardNumber.AutoSize = True
        Me.lblCardNumber.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCardNumber.Location = New System.Drawing.Point(29, 101)
        Me.lblCardNumber.Name = "lblCardNumber"
        Me.lblCardNumber.Size = New System.Drawing.Size(108, 21)
        Me.lblCardNumber.TabIndex = 1
        Me.lblCardNumber.Text = "Card Number"
        '
        'lblCardHolder
        '
        Me.lblCardHolder.AutoSize = True
        Me.lblCardHolder.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCardHolder.Location = New System.Drawing.Point(26, 16)
        Me.lblCardHolder.Name = "lblCardHolder"
        Me.lblCardHolder.Size = New System.Drawing.Size(146, 21)
        Me.lblCardHolder.TabIndex = 0
        Me.lblCardHolder.Text = "Card Holder Name"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Azure
        Me.Panel2.Controls.Add(Me.lblTotalPriceCard)
        Me.Panel2.Location = New System.Drawing.Point(72, 362)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(389, 68)
        Me.Panel2.TabIndex = 2
        '
        'lblTotalPriceCard
        '
        Me.lblTotalPriceCard.AutoSize = True
        Me.lblTotalPriceCard.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPriceCard.Location = New System.Drawing.Point(35, 23)
        Me.lblTotalPriceCard.Name = "lblTotalPriceCard"
        Me.lblTotalPriceCard.Size = New System.Drawing.Size(17, 21)
        Me.lblTotalPriceCard.TabIndex = 5
        Me.lblTotalPriceCard.Text = "*"
        '
        'btnPay
        '
        Me.btnPay.BackColor = System.Drawing.Color.Orange
        Me.btnPay.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPay.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnPay.Location = New System.Drawing.Point(188, 436)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(144, 43)
        Me.btnPay.TabIndex = 3
        Me.btnPay.Text = "PAY"
        Me.btnPay.UseVisualStyleBackColor = False
        '
        'btnBackCard
        '
        Me.btnBackCard.BackColor = System.Drawing.Color.CadetBlue
        Me.btnBackCard.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackCard.ForeColor = System.Drawing.Color.Ivory
        Me.btnBackCard.Location = New System.Drawing.Point(188, 485)
        Me.btnBackCard.Name = "btnBackCard"
        Me.btnBackCard.Size = New System.Drawing.Size(144, 33)
        Me.btnBackCard.TabIndex = 4
        Me.btnBackCard.Text = "Back"
        Me.btnBackCard.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.FlightSystem.My.Resources.Resources.americanexpresslogo
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(368, 36)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(51, 25)
        Me.PictureBox3.TabIndex = 7
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.FlightSystem.My.Resources.Resources.mastercardlogo
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(309, 36)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(53, 25)
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.FlightSystem.My.Resources.Resources.visa_logo
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(250, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(53, 25)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 234)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Month"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(90, 234)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Year"
        '
        'FormCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(534, 546)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnBackCard)
        Me.Controls.Add(Me.btnPay)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormCard"
        Me.Text = "FormCard"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblCVV As Label
    Friend WithEvents lblExpiry As Label
    Friend WithEvents lblCardNumber As Label
    Friend WithEvents lblCardHolder As Label
    Friend WithEvents txtExpiryYear As TextBox
    Friend WithEvents txtExpiryMonth As TextBox
    Friend WithEvents txtCardNumber As TextBox
    Friend WithEvents txtCardHolder As TextBox
    Friend WithEvents txtCVV As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblTotalPriceCard As Label
    Friend WithEvents btnPay As Button
    Friend WithEvents btnBackCard As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
