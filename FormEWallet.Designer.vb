<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEWallet
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
        Me.txtAccNum = New System.Windows.Forms.TextBox()
        Me.txtAccName = New System.Windows.Forms.TextBox()
        Me.lblAccNum = New System.Windows.Forms.Label()
        Me.lblAccountName = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblTotalPriceEW = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnPayEW = New System.Windows.Forms.Button()
        Me.btnBackEW = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
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
        Me.Label1.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(61, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "E-Wallet Payment"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Azure
        Me.Panel1.Controls.Add(Me.txtAccNum)
        Me.Panel1.Controls.Add(Me.txtAccName)
        Me.Panel1.Controls.Add(Me.lblAccNum)
        Me.Panel1.Controls.Add(Me.lblAccountName)
        Me.Panel1.Location = New System.Drawing.Point(65, 92)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(336, 163)
        Me.Panel1.TabIndex = 1
        '
        'txtAccNum
        '
        Me.txtAccNum.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccNum.Location = New System.Drawing.Point(26, 106)
        Me.txtAccNum.MaxLength = 15
        Me.txtAccNum.Name = "txtAccNum"
        Me.txtAccNum.Size = New System.Drawing.Size(270, 29)
        Me.txtAccNum.TabIndex = 3
        '
        'txtAccName
        '
        Me.txtAccName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccName.Location = New System.Drawing.Point(26, 42)
        Me.txtAccName.MaxLength = 100
        Me.txtAccName.Name = "txtAccName"
        Me.txtAccName.Size = New System.Drawing.Size(270, 29)
        Me.txtAccName.TabIndex = 2
        '
        'lblAccNum
        '
        Me.lblAccNum.AutoSize = True
        Me.lblAccNum.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccNum.Location = New System.Drawing.Point(22, 82)
        Me.lblAccNum.Name = "lblAccNum"
        Me.lblAccNum.Size = New System.Drawing.Size(70, 21)
        Me.lblAccNum.TabIndex = 1
        Me.lblAccNum.Text = "Number"
        '
        'lblAccountName
        '
        Me.lblAccountName.AutoSize = True
        Me.lblAccountName.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountName.Location = New System.Drawing.Point(22, 18)
        Me.lblAccountName.Name = "lblAccountName"
        Me.lblAccountName.Size = New System.Drawing.Size(118, 21)
        Me.lblAccountName.TabIndex = 0
        Me.lblAccountName.Text = "Account Name"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Azure
        Me.Panel2.Controls.Add(Me.lblTotalPriceEW)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(65, 270)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(336, 65)
        Me.Panel2.TabIndex = 2
        '
        'lblTotalPriceEW
        '
        Me.lblTotalPriceEW.AutoSize = True
        Me.lblTotalPriceEW.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPriceEW.Location = New System.Drawing.Point(77, 20)
        Me.lblTotalPriceEW.Name = "lblTotalPriceEW"
        Me.lblTotalPriceEW.Size = New System.Drawing.Size(17, 21)
        Me.lblTotalPriceEW.TabIndex = 5
        Me.lblTotalPriceEW.Text = "*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 21)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Total:"
        '
        'btnPayEW
        '
        Me.btnPayEW.BackColor = System.Drawing.Color.Orange
        Me.btnPayEW.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayEW.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnPayEW.Location = New System.Drawing.Point(156, 341)
        Me.btnPayEW.Name = "btnPayEW"
        Me.btnPayEW.Size = New System.Drawing.Size(130, 47)
        Me.btnPayEW.TabIndex = 3
        Me.btnPayEW.Text = "PAY"
        Me.btnPayEW.UseVisualStyleBackColor = False
        '
        'btnBackEW
        '
        Me.btnBackEW.BackColor = System.Drawing.Color.CadetBlue
        Me.btnBackEW.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackEW.ForeColor = System.Drawing.Color.Ivory
        Me.btnBackEW.Location = New System.Drawing.Point(156, 394)
        Me.btnBackEW.Name = "btnBackEW"
        Me.btnBackEW.Size = New System.Drawing.Size(130, 31)
        Me.btnBackEW.TabIndex = 4
        Me.btnBackEW.Text = "Back"
        Me.btnBackEW.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.FlightSystem.My.Resources.Resources.paypallogo
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(367, 55)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(34, 32)
        Me.PictureBox3.TabIndex = 7
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.FlightSystem.My.Resources.Resources.paymayalogo
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(316, 55)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(45, 32)
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.FlightSystem.My.Resources.Resources.gclogo
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(271, 55)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(39, 31)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'FormEWallet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PowderBlue
        Me.ClientSize = New System.Drawing.Size(472, 448)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnBackEW)
        Me.Controls.Add(Me.btnPayEW)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormEWallet"
        Me.Text = "FormEWallet"
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
    Friend WithEvents txtAccName As TextBox
    Friend WithEvents lblAccNum As Label
    Friend WithEvents lblAccountName As Label
    Friend WithEvents txtAccNum As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTotalPriceEW As Label
    Friend WithEvents btnPayEW As Button
    Friend WithEvents btnBackEW As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
