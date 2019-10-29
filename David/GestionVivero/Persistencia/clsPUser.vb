Imports Entidades
Imports MySql
Imports MySql.Data.MySqlClient
Public Class clsPUser
    Inherits clsPersistencia
    Public Function loginUsuario(user As String, contra As String) As clsPersona
        Dim sql As String
        Dim devolucion As MySqlDataReader
        Dim elUsuario As clsPersona
        sql = "SELECT * FROM empleado WHERE usuario='" & user & "' AND contraseña='" & contra & "';"
        devolucion = ejecutarYdevolver(sql)
        If devolucion.HasRows Then
            While devolucion.Read
                elUsuario = recrearusuario(devolucion)
            End While
        End If
        Return elUsuario
    End Function
    Private Function recrearusuario(fila As MySqlDataReader) As clsPersona
        Dim unUsuario As New clsPersona
        unUsuario.user = fila.GetString("usuario")
        'unUsuario.contra = fila.GetString("contraseña")
        Return unUsuario
    End Function
End Class
