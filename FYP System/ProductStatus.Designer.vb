<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProductStatus
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
        Me.components = New System.ComponentModel.Container()
        Me.rtbTag = New System.Windows.Forms.RichTextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.SerialPort2 = New System.IO.Ports.SerialPort(Me.components)
        Me.connect_BTN = New System.Windows.Forms.Button()
        Me.Timer_LBL = New System.Windows.Forms.Label()
        Me.rtbSS = New System.Windows.Forms.RichTextBox()
        Me.rtbEPN = New System.Windows.Forms.RichTextBox()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.lblexp = New System.Windows.Forms.Label()
        Me.lblstk = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.rtbstock = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'rtbTag
        '
        Me.rtbTag.Location = New System.Drawing.Point(12, 48)
        Me.rtbTag.Name = "rtbTag"
        Me.rtbTag.ReadOnly = True
        Me.rtbTag.Size = New System.Drawing.Size(214, 501)
        Me.rtbTag.TabIndex = 0
        Me.rtbTag.Text = ""
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'connect_BTN
        '
        Me.connect_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.connect_BTN.Location = New System.Drawing.Point(278, 63)
        Me.connect_BTN.Name = "connect_BTN"
        Me.connect_BTN.Size = New System.Drawing.Size(120, 32)
        Me.connect_BTN.TabIndex = 20
        Me.connect_BTN.Text = "Connect"
        Me.connect_BTN.UseVisualStyleBackColor = True
        '
        'Timer_LBL
        '
        Me.Timer_LBL.AutoSize = True
        Me.Timer_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Timer_LBL.Location = New System.Drawing.Point(283, 111)
        Me.Timer_LBL.Name = "Timer_LBL"
        Me.Timer_LBL.Size = New System.Drawing.Size(109, 20)
        Me.Timer_LBL.TabIndex = 25
        Me.Timer_LBL.Text = "Scanner: OFF"
        '
        'rtbSS
        '
        Me.rtbSS.Location = New System.Drawing.Point(446, 48)
        Me.rtbSS.Name = "rtbSS"
        Me.rtbSS.ReadOnly = True
        Me.rtbSS.Size = New System.Drawing.Size(309, 133)
        Me.rtbSS.TabIndex = 26
        Me.rtbSS.Text = ""
        '
        'rtbEPN
        '
        Me.rtbEPN.Location = New System.Drawing.Point(446, 230)
        Me.rtbEPN.Name = "rtbEPN"
        Me.rtbEPN.ReadOnly = True
        Me.rtbEPN.Size = New System.Drawing.Size(309, 133)
        Me.rtbEPN.TabIndex = 27
        Me.rtbEPN.Text = ""
        '
        'btnMenu
        '
        Me.btnMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenu.Location = New System.Drawing.Point(261, 199)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(154, 42)
        Me.btnMenu.TabIndex = 31
        Me.btnMenu.Text = "Main Menu"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'lblexp
        '
        Me.lblexp.AutoSize = True
        Me.lblexp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblexp.Location = New System.Drawing.Point(457, 207)
        Me.lblexp.Name = "lblexp"
        Me.lblexp.Size = New System.Drawing.Size(284, 20)
        Me.lblexp.TabIndex = 32
        Me.lblexp.Text = "EXPIRING PRODUCT NOTIFICATION"
        '
        'lblstk
        '
        Me.lblstk.AutoSize = True
        Me.lblstk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstk.Location = New System.Drawing.Point(542, 25)
        Me.lblstk.Name = "lblstk"
        Me.lblstk.Size = New System.Drawing.Size(129, 20)
        Me.lblstk.TabIndex = 33
        Me.lblstk.Text = "STOCK STATUS"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(261, 321)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(154, 42)
        Me.btnExit.TabIndex = 35
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(81, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 20)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "INPUT"
        '
        'btnLogout
        '
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(261, 262)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(154, 42)
        Me.btnLogout.TabIndex = 37
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'rtbstock
        '
        Me.rtbstock.Location = New System.Drawing.Point(446, 409)
        Me.rtbstock.Name = "rtbstock"
        Me.rtbstock.ReadOnly = True
        Me.rtbstock.Size = New System.Drawing.Size(309, 133)
        Me.rtbstock.TabIndex = 38
        Me.rtbstock.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(482, 386)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(232, 20)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "STOCK LEVEL NOTIFICATION"
        '
        'ProductStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 575)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.rtbstock)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblstk)
        Me.Controls.Add(Me.lblexp)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.rtbEPN)
        Me.Controls.Add(Me.rtbSS)
        Me.Controls.Add(Me.Timer_LBL)
        Me.Controls.Add(Me.connect_BTN)
        Me.Controls.Add(Me.rtbTag)
        Me.Name = "ProductStatus"
        Me.Text = "Deduct"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rtbTag As RichTextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents SerialPort2 As IO.Ports.SerialPort
    Friend WithEvents connect_BTN As Button
    Friend WithEvents Timer_LBL As Label
    Friend WithEvents rtbSS As RichTextBox
    Friend WithEvents rtbEPN As RichTextBox
    Friend WithEvents btnMenu As Button
    Friend WithEvents lblexp As Label
    Friend WithEvents lblstk As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents rtbstock As RichTextBox
    Friend WithEvents Label2 As Label
End Class
