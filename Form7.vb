Imports FontAwesome.Sharp
Public Class Form7
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel
    Private currentChildForm As Form

    Public Sub New()
        InitializeComponent()
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 60)
        PanelMenu.Controls.Add(leftBorderBtn)

        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
    End Sub

    Private Sub ActivateButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()

            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(37, 36, 81)
            currentBtn.ForeColor = customColor
            currentBtn.IconColor = customColor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage

            leftBorderBtn.BackColor = customColor
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()

            IconCurrentForm.IconChar = currentBtn.IconChar
            IconCurrentForm.IconColor = customColor
        End If
    End Sub

    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(31, 30, 68)
            currentBtn.ForeColor = Color.Gainsboro
            currentBtn.IconColor = Color.Gainsboro
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub

    Public Sub OpenChildForm(childForm As Form)
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelDesktop.Controls.Add(childForm)
        PanelDesktop.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        LblFormTitle.Text = childForm.Text
    End Sub

    Public Property ParentForm7 As Form7
    Private Sub btnBook_Click(sender As Object, e As EventArgs) Handles btnBook.Click
        ActivateButton(sender, Color.FromArgb(192, 0, 0))
        Dim formBook As New FormBook()
        formBook.ParentForm7 = Me
        OpenChildForm(formBook)
    End Sub

    Private Sub btnDirectory_Click(sender As Object, e As EventArgs) Handles btnDirectory.Click
        ActivateButton(sender, Color.FromArgb(192, 0, 0))
        btnDirectory.FlatStyle = FlatStyle.Flat
        btnDirectory.FlatAppearance.BorderSize = 0
        Dim formDirectory As New FormFlightDirectory()
        formDirectory.ParentForm7 = Me
        OpenChildForm(formDirectory)
    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
    End Sub

    Private Sub btnContact_Click(sender As Object, e As EventArgs) Handles btnContact.Click
        ActivateButton(sender, Color.FromArgb(192, 0, 0))
        btnDirectory.FlatStyle = FlatStyle.Flat
        btnDirectory.FlatAppearance.BorderSize = 0
        Dim formContacts As New FormContact()
        formContacts.ParentForm7 = Me
        OpenChildForm(formContacts)
    End Sub
End Class