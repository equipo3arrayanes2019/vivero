Imports Entidades
Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class clsPAditivo
    Inherits clsPersistencia
    Public Sub altaAditivo(unPP As clsAditivo)
        Dim consulta1 As String
        consulta1 = "insert INTO aditivo values ('" & unPP.id & "','" & unPP.tipo & "','" & unPP.descripcion & "','" & unPP.producto & "');"
        ejecutarSQL(consulta1)
    End Sub

    Public Sub bajaAditivo(id As String)
        Dim consulta As String
        consulta = "DELETE FROM aditivo WHERE id='" & id & "';"
        ejecutarSQL(consulta)
    End Sub
    Private Function recrearAditivo(fila As MySqlDataReader) As clsAditivo
        Dim unPla As New clsAditivo
        unPla.id = fila.GetInt32("id")
        unPla.tipo = fila.GetString("tipo")
        unPla.descripcion = fila.GetString("descripcion")
        unPla.producto = fila.GetInt32("producto")
        Return (unPla)
    End Function

    Public Function listar() As List(Of clsAditivo)
        Dim consulta As String
        Dim lo_que_devuelve As MySqlDataReader
        Dim listaAditivo As New List(Of clsAditivo)

        consulta = "SELECT * FROM aditivo"
        lo_que_devuelve = ejecutarYdevolver(consulta)
        If lo_que_devuelve.HasRows Then
            While (lo_que_devuelve.Read)
                listaAditivo.Add(recrearAditivo(lo_que_devuelve))
            End While
        End If
        Return (listaAditivo)
    End Function
End Class