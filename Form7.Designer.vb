<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.btnContact = New FontAwesome.Sharp.IconButton()
        Me.btnDirectory = New FontAwesome.Sharp.IconButton()
        Me.btnBook = New FontAwesome.Sharp.IconButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LblFormTitle = New System.Windows.Forms.Label()
        Me.IconCurrentForm = New FontAwesome.Sharp.IconPictureBox()
        Me.PanelDesktop = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelMenu.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDesktop.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.MidnightBlue
        Me.PanelMenu.Controls.Add(Me.btnContact)
        Me.PanelMenu.Controls.Add(Me.btnDirectory)
        Me.PanelMenu.Controls.Add(Me.btnBook)
        Me.PanelMenu.Controls.Add(Me.Panel2)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(234, 919)
        Me.PanelMenu.TabIndex = 0
        '
        'btnContact
        '
        Me.btnContact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnContact.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnContact.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContact.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnContact.IconChar = FontAwesome.Sharp.IconChar.Phone
        Me.btnContact.IconColor = System.Drawing.Color.White
        Me.btnContact.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnContact.IconSize = 32
        Me.btnContact.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnContact.Location = New System.Drawing.Point(0, 235)
        Me.btnContact.Name = "btnContact"
        Me.btnContact.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnContact.Size = New System.Drawing.Size(234, 60)
        Me.btnContact.TabIndex = 4
        Me.btnContact.Text = "   CONTACT US"
        Me.btnContact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnContact.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnContact.UseVisualStyleBackColor = True
        '
        'btnDirectory
        '
        Me.btnDirectory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnDirectory.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDirectory.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDirectory.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDirectory.IconChar = FontAwesome.Sharp.IconChar.SquarePen
        Me.btnDirectory.IconColor = System.Drawing.Color.White
        Me.btnDirectory.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnDirectory.IconSize = 32
        Me.btnDirectory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDirectory.Location = New System.Drawing.Point(0, 175)
        Me.btnDirectory.Name = "btnDirectory"
        Me.btnDirectory.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnDirectory.Size = New System.Drawing.Size(234, 60)
        Me.btnDirectory.TabIndex = 3
        Me.btnDirectory.Text = "   FLIGHT DIRECTORY"
        Me.btnDirectory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDirectory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDirectory.UseVisualStyleBackColor = True
        '
        'btnBook
        '
        Me.btnBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnBook.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBook.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBook.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBook.IconChar = FontAwesome.Sharp.IconChar.Plane
        Me.btnBook.IconColor = System.Drawing.Color.White
        Me.btnBook.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnBook.IconSize = 32
        Me.btnBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBook.Location = New System.Drawing.Point(0, 115)
        Me.btnBook.Name = "btnBook"
        Me.btnBook.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnBook.Size = New System.Drawing.Size(234, 60)
        Me.btnBook.TabIndex = 2
        Me.btnBook.Text = "   FLIGHT BOOKING"
        Me.btnBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBook.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(234, 115)
        Me.Panel2.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FlightSystem.My.Resources.Resources.Screenshot_2024_11_26_211658
        Me.PictureBox1.Location = New System.Drawing.Point(32, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(167, 50)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel3.Controls.Add(Me.LblFormTitle)
        Me.Panel3.Controls.Add(Me.IconCurrentForm)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(234, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1016, 77)
        Me.Panel3.TabIndex = 1
        '
        'LblFormTitle
        '
        Me.LblFormTitle.AutoSize = True
        Me.LblFormTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFormTitle.ForeColor = System.Drawing.SystemColors.Control
        Me.LblFormTitle.Location = New System.Drawing.Point(73, 34)
        Me.LblFormTitle.Name = "LblFormTitle"
        Me.LblFormTitle.Size = New System.Drawing.Size(47, 17)
        Me.LblFormTitle.TabIndex = 1
        Me.LblFormTitle.Text = "HOME"
        '
        'IconCurrentForm
        '
        Me.IconCurrentForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.IconCurrentForm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.IconCurrentForm.IconChar = FontAwesome.Sharp.IconChar.House
        Me.IconCurrentForm.IconColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.IconCurrentForm.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconCurrentForm.Location = New System.Drawing.Point(32, 27)
        Me.IconCurrentForm.Name = "IconCurrentForm"
        Me.IconCurrentForm.Size = New System.Drawing.Size(32, 32)
        Me.IconCurrentForm.TabIndex = 0
        Me.IconCurrentForm.TabStop = False
        '
        'PanelDesktop
        '
        Me.PanelDesktop.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelDesktop.BackColor = System.Drawing.Color.Transparent
        Me.PanelDesktop.Controls.Add(Me.Label5)
        Me.PanelDesktop.Controls.Add(Me.Label4)
        Me.PanelDesktop.Controls.Add(Me.Label3)
        Me.PanelDesktop.Controls.Add(Me.Label2)
        Me.PanelDesktop.Location = New System.Drawing.Point(234, 83)
        Me.PanelDesktop.Name = "PanelDesktop"
        Me.PanelDesktop.Size = New System.Drawing.Size(1016, 836)
        Me.PanelDesktop.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Berlin Sans FB Demi", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Crimson
        Me.Label5.Location = New System.Drawing.Point(52, 276)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(180, 73)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Now!"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label4.Location = New System.Drawing.Point(61, 361)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(376, 23)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Off the ground. Around the world"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Berlin Sans FB Demi", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Crimson
        Me.Label3.Location = New System.Drawing.Point(52, 203)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(434, 73)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Dream Flights"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Berlin Sans FB Demi", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Crimson
        Me.Label2.Location = New System.Drawing.Point(52, 130)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(330, 73)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Book Your"
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FlightSystem.My.Resources.Resources.photo_1593182440709_4b7b56482c55
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1250, 919)
        Me.Controls.Add(Me.PanelDesktop)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PanelMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form7"
        Me.Text = "Form7"
        Me.PanelMenu.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDesktop.ResumeLayout(False)
        Me.PanelDesktop.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBook As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents LblFormTitle As Label
    Friend WithEvents IconCurrentForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnDirectory As FontAwesome.Sharp.IconButton
    Friend WithEvents btnContact As FontAwesome.Sharp.IconButton
End Class
