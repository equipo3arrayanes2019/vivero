Imports Entities
Imports MySql
Imports MySql.Data.MySqlClient
Public Class PZone
    Public Sub Add(unP As EZone) 'Se declara el alta persona la cual nos ineterviene entre VB.net y MySQL.
        Dim consulta1 As String
        consulta1 = "INSERT INTO Zona(nombre, tamaño, tipo) VALUES ('" & SqlHandle.Escape(unP.ZoneName) & "', '" & SqlHandle.Escape(unP.Size) & "', '" & SqlHandle.Escape(unP.Type) & "');"
        SqlHandle.StaticSendCommand(consulta1)
    End Sub
    Private Function CreateZone(fila As MySqlDataReader) As EZone
        Dim unZona As New EZone
        unZona.ZoneName = fila.GetString("nombre")
        unZona.Size = fila.GetString("tamaño")
        unZona.Type = fila.GetString("tipo")
        Return (unZona)
    End Function

    Public Function ById(idZ As String) As EZone
        Dim consulta As String
        Dim datos As MySqlDataReader
        Dim unZona As New EZone
        Dim conn As New SqlHandle()

        consulta = "SELECT * FROM Zona where nombre =( '" & idZ & "' );"
        datos = conn.SendQuery(consulta)
        While datos.Read
            unZona = CreateZone(datos)
        End While
        conn.Close()
        Return unZona
    End Function
    Public Function List() As List(Of EZone)
        Dim consulta As String
        Dim lo_que_devuelve As MySqlDataReader
        Dim listaZona As New List(Of EZone)
        Dim conn As New SqlHandle()

        consulta = "SELECT * FROM Zona"
        lo_que_devuelve = conn.SendQuery(consulta)
        If lo_que_devuelve.HasRows Then
            While (lo_que_devuelve.Read)
                listaZona.Add(CreateZone(lo_que_devuelve))
            End While
        End If
        conn.Close()
        Return (listaZona)
    End Function

    Public Function ListByType(type As String) As List(Of EZone)
        Dim query As String = "SELECT * FROM Zona WHERE tipo = '" + SqlHandle.Escape(type) + "';"
        Dim conn As New SqlHandle()
        Dim result = conn.SendQuery(query)
        Dim out As New List(Of EZone)
        While result.HasRows And result.Read()
            out.Add(CreateZone(result))
        End While
        conn.Close()
        Return out
    End Function

    Public Sub Remove(name As String)
        Dim query As String = "DELETE FROM Zona WHERE nombre = '" + SqlHandle.Escape(name) + "';"
        SqlHandle.StaticSendCommand(query)
    End Sub

End Class
