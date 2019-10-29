Imports Entidades
Imports Dominio
Public Class frmLogin
    Dim unEUser As New clsPersona
    Dim unCUser As New clsControlador
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        unEUser = unCUser.loginUsuario(txtUser.Text, txtPass.Text)
        If (unEUser Is Nothing) Then
            MessageBox.Show("Usuario o contraseña incorrectos")
        Else
            MessageBox.Show("Logueo exitoso")
            Dim mainForm = New frmMain
            Me.Hide()
            mainForm.ShowDialog()
            If mainForm.CloseProgram Then
                Me.Close()
            Else
                Me.Show()
            End If
        End If
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs)
        Me.Hide()
        frmAddPerson.Show()
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPass.CheckedChanged
        If chkShowPass.Checked Then
            txtPass.PasswordChar = New Char

        Else
            txtPass.PasswordChar = "*"c

        End If

    End Sub
End Class