Imports Entities
Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class PPlant
    Public Sub Add(unPP As EPlant)
        Dim consulta1 As String
        consulta1 = "insert INTO planta values ('" & unPP.Id & "','" & unPP.DatePlanted & "','" & unPP.Count & "','" & unPP.Species & "');"
        SqlHandle.StaticSendCommand(consulta1)
    End Sub

    Public Sub Remove(id As String)
        Dim consulta As String
        consulta = "DELETE FROM planta WHERE id='" & id & "';"
        SqlHandle.StaticSendCommand(consulta)
    End Sub
    Private Function CreatePlant(fila As MySqlDataReader) As EPlant
        Dim unPla As New EPlant
        unPla.Id = fila.GetString("id")
        unPla.DatePlanted = fila.GetString("fecha")
        unPla.Count = fila.GetInt32("cantidad")
        unPla.Species = fila.GetString("especie")
        Return (unPla)
    End Function

    Public Function List() As List(Of EPlant)
        Dim conn As New SqlHandle()
        Dim consulta As String
        Dim lo_que_devuelve As MySqlDataReader
        Dim listaPlanta As New List(Of EPlant)

        consulta = "SELECT * FROM planta"
        lo_que_devuelve = conn.SendQuery(consulta)
        If lo_que_devuelve.HasRows Then
            While (lo_que_devuelve.Read)
                listaPlanta.Add(CreatePlant(lo_que_devuelve))
            End While
        End If
        conn.Close()
        Return (listaPlanta)
    End Function
End Class
