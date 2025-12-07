<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.txtFlightNumber2 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblDetailDisplay = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label8.Location = New System.Drawing.Point(70, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(257, 54)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Flight Details"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(83, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 28)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Flight Number:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtFlightNumber2
        '
        Me.txtFlightNumber2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFlightNumber2.Location = New System.Drawing.Point(249, 123)
        Me.txtFlightNumber2.Name = "txtFlightNumber2"
        Me.txtFlightNumber2.Size = New System.Drawing.Size(324, 34)
        Me.txtFlightNumber2.TabIndex = 14
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblDetailDisplay)
        Me.Panel1.Location = New System.Drawing.Point(79, 180)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(777, 420)
        Me.Panel1.TabIndex = 15
        '
        'lblDetailDisplay
        '
        Me.lblDetailDisplay.AutoSize = True
        Me.lblDetailDisplay.Location = New System.Drawing.Point(64, 37)
        Me.lblDetailDisplay.Name = "lblDetailDisplay"
        Me.lblDetailDisplay.Size = New System.Drawing.Size(51, 18)
        Me.lblDetailDisplay.TabIndex = 0
        Me.lblDetailDisplay.Text = "Label1"
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.Red
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNext.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.White
        Me.btnNext.Location = New System.Drawing.Point(659, 620)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(197, 53)
        Me.btnNext.TabIndex = 41
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnEnter
        '
        Me.btnEnter.BackColor = System.Drawing.Color.Red
        Me.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEnter.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.ForeColor = System.Drawing.Color.White
        Me.btnEnter.Location = New System.Drawing.Point(594, 123)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(262, 34)
        Me.btnEnter.TabIndex = 42
        Me.btnEnter.Text = "Enter"
        Me.btnEnter.UseVisualStyleBackColor = False
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FlightSystem.My.Resources.Resources.photo_1593182440709_4b7b56482c55
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(933, 702)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtFlightNumber2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label8)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form5"
        Me.Text = "Form5"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFlightNumber2 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblDetailDisplay As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents btnEnter As Button
End Class
