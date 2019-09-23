Imports Entidades
Imports Dominio

Public Class frmLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim user As EUser = New EUser(txtUser.Text, txtPass.Text)
        Dim clsDUsuario As New DUser
        Dim log As Boolean = clsDUsuario.loginUsuario(user)
        If (log = True) Then
            MessageBox.Show("Logueo exitoso")
        Else
            MessageBox.Show("Usuario o contraseña incorrectos")
        End If

        Dim mainForm = New frmMain
        Me.Hide()
        mainForm.ShowDialog()
        If mainForm.CloseProgram Then
            Me.Close()
        Else
            Me.Show()
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
            txtPass.PasswordChar = "-"c

        End If

    End Sub
End Class