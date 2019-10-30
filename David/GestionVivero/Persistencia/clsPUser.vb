Imports Entidades
Imports MySql
Imports MySql.Data.MySqlClient
Public Class clsPUser
    Inherits clsPersistencia
    Public Function loginUsuario(user As String, pass As String) As clsEUser
        Dim sql As String
        Dim devolucion As MySqlDataReader
        Dim elUsuario As clsEUser
        sql = "SELECT * FROM registeruser WHERE userid='" & user & "' AND clave='" & pass & "'"
        devolucion = ejecutarYdevolver(sql)
        If devolucion.HasRows Then
            While devolucion.Read
                elUsuario = recrearusuario(devolucion)
            End While
        End If
        Return elUsuario
    End Function
    Private Function recrearusuario(fila As MySqlDataReader) As clsEUser
        Dim unUsuario As New clsEUser
        unUsuario.user = fila.GetString("userid")
        unUsuario.contra = fila.GetString("clave")
        Return unUsuario
    End Function
End Class
