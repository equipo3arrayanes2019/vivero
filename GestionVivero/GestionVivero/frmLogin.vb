Imports Entidades
Imports Dominio

Public Class frmLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim user As usuario = New usuario(TextBox1.Text, TextBox2.Text)
        Dim clsDUsuario As New clsDUsuario
        Dim log As Boolean = clsDUsuario.loginUsuario(user)
        If (log = True) Then
            MessageBox.Show("Logueo exitoso")
        Else
            MessageBox.Show("Usuario o contraseña incorrectos")
        End If

        'Dim mainForm = New frmMain
        'Me.Hide()
        'mainForm.ShowDialog()
        'If mainForm.CloseProgram Then
        'Me.Close()
        'Else
        'Me.Show()
        'End If
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class