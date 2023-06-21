<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddNewProduct
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
        Me.comPort_ComboBox = New System.Windows.Forms.ComboBox()
        Me.COMport_LBL = New System.Windows.Forms.Label()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.rtbTag = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.clear_BTN = New System.Windows.Forms.Button()
        Me.connect_BTN = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_LBL = New System.Windows.Forms.Label()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtproduct = New System.Windows.Forms.TextBox()
        Me.lblrow = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'comPort_ComboBox
        '
        Me.comPort_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comPort_ComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comPort_ComboBox.FormattingEnabled = True
        Me.comPort_ComboBox.Location = New System.Drawing.Point(23, 43)
        Me.comPort_ComboBox.Name = "comPort_ComboBox"
        Me.comPort_ComboBox.Size = New System.Drawing.Size(121, 28)
        Me.comPort_ComboBox.TabIndex = 18
        '
        'COMport_LBL
        '
        Me.COMport_LBL.AutoSize = True
        Me.COMport_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.COMport_LBL.Location = New System.Drawing.Point(42, 20)
        Me.COMport_LBL.Name = "COMport_LBL"
        Me.COMport_LBL.Size = New System.Drawing.Size(78, 20)
        Me.COMport_LBL.TabIndex = 17
        Me.COMport_LBL.Text = "COM Port"
        '
        'rtbTag
        '
        Me.rtbTag.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbTag.Location = New System.Drawing.Point(296, 43)
        Me.rtbTag.Name = "rtbTag"
        Me.rtbTag.ReadOnly = True
        Me.rtbTag.Size = New System.Drawing.Size(140, 309)
        Me.rtbTag.TabIndex = 23
        Me.rtbTag.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(336, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 20)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "INPUT"
        '
        'clear_BTN
        '
        Me.clear_BTN.Location = New System.Drawing.Point(329, 358)
        Me.clear_BTN.Name = "clear_BTN"
        Me.clear_BTN.Size = New System.Drawing.Size(75, 23)
        Me.clear_BTN.TabIndex = 21
        Me.clear_BTN.Text = "CLEAR"
        Me.clear_BTN.UseVisualStyleBackColor = True
        '
        'connect_BTN
        '
        Me.connect_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.connect_BTN.Location = New System.Drawing.Point(150, 40)
        Me.connect_BTN.Name = "connect_BTN"
        Me.connect_BTN.Size = New System.Drawing.Size(120, 32)
        Me.connect_BTN.TabIndex = 19
        Me.connect_BTN.Text = "Connect"
        Me.connect_BTN.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'Timer_LBL
        '
        Me.Timer_LBL.AutoSize = True
        Me.Timer_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Timer_LBL.Location = New System.Drawing.Point(19, 99)
        Me.Timer_LBL.Name = "Timer_LBL"
        Me.Timer_LBL.Size = New System.Drawing.Size(109, 20)
        Me.Timer_LBL.TabIndex = 24
        Me.Timer_LBL.Text = "Scanner: OFF"
        '
        'btnadd
        '
        Me.btnadd.Enabled = False
        Me.btnadd.Location = New System.Drawing.Point(81, 157)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(75, 23)
        Me.btnadd.TabIndex = 26
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Please Enter Product Name :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpDate)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtproduct)
        Me.GroupBox1.Controls.Add(Me.btnadd)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(23, 133)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(247, 190)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add Product"
        '
        'dtpDate
        '
        Me.dtpDate.Location = New System.Drawing.Point(23, 125)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpDate.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Please Enter Expiry Date :"
        '
        'txtproduct
        '
        Me.txtproduct.Location = New System.Drawing.Point(23, 65)
        Me.txtproduct.Name = "txtproduct"
        Me.txtproduct.Size = New System.Drawing.Size(200, 20)
        Me.txtproduct.TabIndex = 1
        '
        'lblrow
        '
        Me.lblrow.AutoSize = True
        Me.lblrow.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrow.Location = New System.Drawing.Point(186, 99)
        Me.lblrow.Name = "lblrow"
        Me.lblrow.Size = New System.Drawing.Size(44, 20)
        Me.lblrow.TabIndex = 28
        Me.lblrow.Text = "-------"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(146, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 20)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Row:"
        '
        'btnMenu
        '
        Me.btnMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenu.Location = New System.Drawing.Point(23, 358)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(97, 31)
        Me.btnMenu.TabIndex = 30
        Me.btnMenu.Text = "Main Menu"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(211, 358)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(66, 31)
        Me.btnExit.TabIndex = 31
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(126, 358)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(79, 31)
        Me.btnLogout.TabIndex = 32
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'AddNewProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 402)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblrow)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Timer_LBL)
        Me.Controls.Add(Me.comPort_ComboBox)
        Me.Controls.Add(Me.COMport_LBL)
        Me.Controls.Add(Me.rtbTag)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.clear_BTN)
        Me.Controls.Add(Me.connect_BTN)
        Me.Name = "AddNewProduct"
        Me.Text = "Add Product"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents comPort_ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents COMport_LBL As System.Windows.Forms.Label
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents rtbTag As System.Windows.Forms.RichTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents clear_BTN As System.Windows.Forms.Button
    Friend WithEvents connect_BTN As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer_LBL As System.Windows.Forms.Label
    Friend WithEvents btnadd As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtproduct As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents lblrow As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnMenu As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnLogout As Button
End Class
