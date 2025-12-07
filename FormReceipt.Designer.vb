<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReceipt
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
        Me.lblReceipt = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.receiptPanel = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.receiptPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblReceipt
        '
        Me.lblReceipt.AutoSize = True
        Me.lblReceipt.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReceipt.Location = New System.Drawing.Point(40, 77)
        Me.lblReceipt.Name = "lblReceipt"
        Me.lblReceipt.Size = New System.Drawing.Size(55, 17)
        Me.lblReceipt.TabIndex = 0
        Me.lblReceipt.Text = "Receipt"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(128, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 1
        '
        'receiptPanel
        '
        Me.receiptPanel.BackColor = System.Drawing.Color.AliceBlue
        Me.receiptPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.receiptPanel.Controls.Add(Me.Label4)
        Me.receiptPanel.Controls.Add(Me.Label3)
        Me.receiptPanel.Controls.Add(Me.lblReceipt)
        Me.receiptPanel.Location = New System.Drawing.Point(86, 73)
        Me.receiptPanel.Name = "receiptPanel"
        Me.receiptPanel.Size = New System.Drawing.Size(518, 537)
        Me.receiptPanel.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(39, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(406, 21)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "===================================="
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 25)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "NOM Airlines"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Crimson
        Me.Label1.Location = New System.Drawing.Point(81, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 30)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "YOUR RECEIPT"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.PeachPuff
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnBack.Location = New System.Drawing.Point(361, 633)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(97, 38)
        Me.btnBack.TabIndex = 4
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.PeachPuff
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnSave.Location = New System.Drawing.Point(221, 633)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 38)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'FormReceipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FlightSystem.My.Resources.Resources.photo_1593182440709_4b7b56482c55
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(703, 699)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.receiptPanel)
        Me.Controls.Add(Me.Label2)
        Me.Name = "FormReceipt"
        Me.Text = "FormReceipt"
        Me.receiptPanel.ResumeLayout(False)
        Me.receiptPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblReceipt As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents receiptPanel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
