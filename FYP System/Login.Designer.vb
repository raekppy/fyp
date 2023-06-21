<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtPw = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblPw = New System.Windows.Forms.Label()
        Me.lblname = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(277, 25)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "RFID Smart Shelf System"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(156, 170)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 43
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(54, 170)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnLogin.TabIndex = 42
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'txtPw
        '
        Me.txtPw.Location = New System.Drawing.Point(121, 129)
        Me.txtPw.Name = "txtPw"
        Me.txtPw.Size = New System.Drawing.Size(100, 20)
        Me.txtPw.TabIndex = 41
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(121, 90)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 40
        '
        'lblPw
        '
        Me.lblPw.AutoSize = True
        Me.lblPw.Location = New System.Drawing.Point(57, 129)
        Me.lblPw.Name = "lblPw"
        Me.lblPw.Size = New System.Drawing.Size(56, 13)
        Me.lblPw.TabIndex = 39
        Me.lblPw.Text = "Password:"
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Location = New System.Drawing.Point(57, 93)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(58, 13)
        Me.lblname.TabIndex = 38
        Me.lblname.Text = "Username:"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(308, 229)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPw)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblPw)
        Me.Controls.Add(Me.lblname)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtPw As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblPw As Label
    Friend WithEvents lblname As Label
End Class
