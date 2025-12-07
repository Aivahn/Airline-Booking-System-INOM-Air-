<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormReciept
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblPaymentMethod = New System.Windows.Forms.Label()
        Me.btnBackReciept = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(60, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Receipt"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Azure
        Me.Panel1.Controls.Add(Me.lblPaymentMethod)
        Me.Panel1.Location = New System.Drawing.Point(100, 69)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(393, 446)
        Me.Panel1.TabIndex = 1
        '
        'lblPaymentMethod
        '
        Me.lblPaymentMethod.AutoSize = True
        Me.lblPaymentMethod.Location = New System.Drawing.Point(48, 28)
        Me.lblPaymentMethod.Name = "lblPaymentMethod"
        Me.lblPaymentMethod.Size = New System.Drawing.Size(11, 13)
        Me.lblPaymentMethod.TabIndex = 0
        Me.lblPaymentMethod.Text = "*"
        '
        'btnBackReciept
        '
        Me.btnBackReciept.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackReciept.Location = New System.Drawing.Point(244, 531)
        Me.btnBackReciept.Name = "btnBackReciept"
        Me.btnBackReciept.Size = New System.Drawing.Size(99, 42)
        Me.btnBackReciept.TabIndex = 2
        Me.btnBackReciept.Text = "Back"
        Me.btnBackReciept.UseVisualStyleBackColor = True
        '
        'FormReciept
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FlightSystem.My.Resources.Resources.photo_1593182440709_4b7b56482c55
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(630, 612)
        Me.Controls.Add(Me.btnBackReciept)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormReciept"
        Me.Text = "FormReciept"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblPaymentMethod As Label
    Friend WithEvents btnBackReciept As Button
End Class
