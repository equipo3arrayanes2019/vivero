Imports Entities
Imports MySql.Data.MySqlClient
Public Class PAdditive
    Public Sub Add(unPP As EAdditive)
        Dim consulta1 As String
        consulta1 = "insert INTO aditivo values ('" & unPP.Id & "','" & unPP.Type & "','" & unPP.Description & "','" & unPP.ProductId & "');"
        SqlHandle.StaticSendCommand(consulta1)
    End Sub

    Public Sub Remove(id As String)
        Dim consulta As String
        consulta = "DELETE FROM aditivo WHERE id='" & id & "';"
        SqlHandle.StaticSendCommand(consulta)
    End Sub
    Private Function CreateAdditive(fila As MySqlDataReader) As EAdditive
        Dim unPla As New EAdditive
        unPla.Id = fila.GetInt32("id")
        unPla.Type = fila.GetString("tipo")
        unPla.Description = fila.GetString("descripcion")
        'unPla.Product = fila.GetInt32("producto")
        Return (unPla)
    End Function

    Public Function List() As List(Of EAdditive)
        Dim conn As New SqlHandle()
        Dim consulta As String
        Dim lo_que_devuelve As MySqlDataReader
        Dim listaAditivo As New List(Of EAdditive)

        consulta = "SELECT * FROM aditivo"
        lo_que_devuelve = conn.SendQuery(consulta)
        If lo_que_devuelve.HasRows Then
            While (lo_que_devuelve.Read)
                listaAditivo.Add(CreateAdditive(lo_que_devuelve))
            End While
        End If
        conn.Close()
        Return (listaAditivo)
    End Function
End Class