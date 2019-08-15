Imports Entidades
Imports MySql
Imports MySql.Data.MySqlClient

Public Class clsPUsuario
    Inherits clsPersistencia

    Public Function loginUsuario(user As usuario) As Boolean
        Dim ret As Boolean
        Dim sql As String
        Dim devolucion As MySqlDataReader
        sql = "select * from usuario where iduser ='" & user.getID & "' and clave ='" & user.getClave & "' ;"
        devolucion = ejecutarYdevolver(sql)
        If (devolucion.HasRows()) Then
            ret = True
        Else
            ret = False
        End If
        Return ret
    End Function

End Class
