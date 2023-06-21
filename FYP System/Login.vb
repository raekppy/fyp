Imports System.Data.OleDb

Public Class Login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If (txtName.Text = "admin" And txtPw.Text = "admin") Then
            MsgBox("Login Success!", vbSystemModal + vbExclamation, "RFID")
            txtName.Text = ""
            txtPw.Text = ""
            Me.Hide()
            Main.Show()
        Else
            MsgBox("Login Failed!", vbSystemModal + vbExclamation, "RFID")
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If MsgBox("Are you sure you want to exit?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            Application.Exit()
        End If
    End Sub
End Class