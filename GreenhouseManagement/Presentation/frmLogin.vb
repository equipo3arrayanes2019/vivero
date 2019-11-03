Imports Domain
Imports Entities
Public Class frmLogin
    Dim unEUser As New EPerson
    Dim unCUser As New Controller
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim err = False
        Try
            unEUser = unCUser.Login(txtUser.Text, txtPass.Text)
            err = False
        Catch ex As Exception
            CommonError.ShowError(ex)
            err = True
        End Try
        If Not err Then
            If (unEUser Is Nothing) Then
                erpLogin.Clear()
                erpLogin.SetError(txtUser, "Combinación de usuario y contraseña incorrecta")
                erpLogin.SetError(txtPass, "Combinación de usuario y contraseña incorrecta")
            Else
                Dim mainForm = New frmMain(unEUser)
                Me.Hide()
                mainForm.ShowDialog()
                If mainForm.CloseProgram Then
                    Me.Close()
                Else
                    Me.Show()
                End If
                txtPass.Text = ""
                txtUser.Text = ""
                erpLogin.Clear()
                txtUser.Select()
            End If
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPass.CheckedChanged
        If chkShowPass.Checked Then
            txtPass.PasswordChar = New Char

        Else
            txtPass.PasswordChar = "*"c

        End If

    End Sub

    Private Sub TxtUser_Enter(sender As Object, e As EventArgs) Handles txtUser.Enter, txtUser.Click
        txtUser.SelectAll()
    End Sub

    Private Sub TxtPass_Enter(sender As Object, e As EventArgs) Handles txtPass.Enter, txtPass.Click
        txtPass.SelectAll()
    End Sub
End Class