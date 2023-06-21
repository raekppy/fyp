Public Class Main
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnNewprd.Click
        AddNewProduct.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPrdStat.Click
        ProductStatus.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If MsgBox("Are you sure you want to exit?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        If MsgBox("Are you sure you want to logout?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            Me.Hide()
            Login.Show()
        End If
    End Sub
End Class