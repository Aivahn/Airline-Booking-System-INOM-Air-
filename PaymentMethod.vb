

Public Class PaymentMethod
    Inherits Form

    Private lblTitle As Label
    Private rbtnVisa As RadioButton
    Private rbtnPayPal As RadioButton
    Private btnSubmit As Button
    Private pnlPaymentOptions As Panel

    Public Sub New()
        ' Initialize components
        Me.Text = "Select Payment Method"
        Me.Size = New Size(400, 300)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.BackColor = Color.White

        lblTitle = New Label()
        lblTitle.Text = "Choose Your Payment Method"
        lblTitle.Font = New Font("Arial", 16, FontStyle.Bold)
        lblTitle.Location = New Point(50, 20)
        lblTitle.AutoSize = True

        rbtnVisa = New RadioButton()
        rbtnVisa.Text = "Visa"
        rbtnVisa.Location = New Point(50, 70)
        rbtnVisa.Font = New Font("Arial", 12)

        rbtnPayPal = New RadioButton()
        rbtnPayPal.Text = "PayPal"
        rbtnPayPal.Location = New Point(50, 110)
        rbtnPayPal.Font = New Font("Arial", 12)

        btnSubmit = New Button()
        btnSubmit.Text = "Submit"
        btnSubmit.Location = New Point(150, 200)
        btnSubmit.Size = New Size(100, 30)
        btnSubmit.BackColor = Color.LightBlue
        btnSubmit.Font = New Font("Arial", 12, FontStyle.Bold)

        pnlPaymentOptions = New Panel()
        pnlPaymentOptions.Location = New Point(30, 50)
        pnlPaymentOptions.Size = New Size(300, 150)
        pnlPaymentOptions.BorderStyle = BorderStyle.FixedSingle
        pnlPaymentOptions.Controls.Add(rbtnVisa)
        pnlPaymentOptions.Controls.Add(rbtnPayPal)

        Me.Controls.Add(lblTitle)
        Me.Controls.Add(pnlPaymentOptions)
        Me.Controls.Add(btnSubmit)
    End Sub
End Class
