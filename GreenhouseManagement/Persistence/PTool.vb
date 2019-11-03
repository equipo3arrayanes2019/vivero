Imports Entities
Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class PTool
    Public Sub Add(unPP As ETool)
        Dim query1, query2, query3 As String
        Dim ultimoId As Integer
        Dim conn As New SqlHandle()

        query1 = "insert INTO producto values ('" & unPP.ProductId & "','" & unPP.ProductName & "' );" 'manda lo valores hacía la tabla producto
        conn.SendCommand(query1)
        query3 = "SELECT id from producto order by id DESC limit 1;" 'Toma el ultimo valor de la tabla 
        Dim dato = conn.SendQuery(query3)
        If dato.Read Then
            ultimoId = dato.GetInt32("id")
        End If
        query2 = "insert INTO herramienta values ('" & ultimoId & "','" & unPP.Type & "', '" & unPP.Use & "' );"
        conn.SendCommand(query2)
        conn.Close()
    End Sub

    Public Sub Remove(id As String)
        Dim consulta As String
        consulta = "DELETE FROM herramienta WHERE id='" & id & "';"
        SqlHandle.StaticSendCommand(consulta)
    End Sub
    Private Function CreateTool(fila As MySqlDataReader) As ETool 'Se genera un tipo listado en VB.Net para luego pedir los datos desde MySQL
        Dim unHerramienta As New ETool
        Dim unPZona As New PZone
        Dim unPPro As New PProduct
        unHerramienta.Use = fila.GetString("uso")
        unHerramienta.Type = fila.GetString("tipo")
        unHerramienta.ZoneName = unPZona.ById(fila.GetString("Zona_nombre"))
        Return (unHerramienta)
    End Function

    Public Function List() As List(Of ETool)
        Dim query As String
        Dim returned As MySqlDataReader
        Dim listaHerramienta As New List(Of ETool)
        Dim conn As New SqlHandle()

        query = "SELECT * FROM herramienta"
        returned = conn.SendQuery(query)
        If returned.HasRows Then
            While (returned.Read)
                listaHerramienta.Add(CreateTool(returned))
            End While
        End If
        conn.Close()
        Return (listaHerramienta)
    End Function

End Class
