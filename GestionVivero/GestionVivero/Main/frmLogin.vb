Public Class frmLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim mainForm = New frmMain
        Me.Hide()
        mainForm.ShowDialog()
        If mainForm.CloseProgram Then
            Me.Close()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class