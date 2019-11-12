Imports Entities
Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class PPlant
    'Public Sub Add(unPP As EPlant)
    '    Dim consulta1 As String
    '    consulta1 = "insert INTO planta values ('" & unPP.Id & "','" & unPP.DatePlanted & "','" & unPP.Count & "','" & unPP.Species & "');"
    '    SqlHandle.StaticSendCommand(consulta1)
    'End Sub

    'Public Sub Remove(id As String)
    '    Dim consulta As String
    '    consulta = "DELETE FROM planta WHERE id='" & id & "';"
    '    SqlHandle.StaticSendCommand(consulta)
    'End Sub
    'Private Function CreatePlant(fila As MySqlDataReader) As EPlant
    '    Dim unPla As New EPlant
    '    unPla.Id = fila.GetString("id")
    '    unPla.DatePlanted = fila.GetString("fecha")
    '    unPla.Count = fila.GetInt32("cantidad")
    '    unPla.Species = fila.GetString("especie")
    '    Return (unPla)
    'End Function

    'Public Function List() As List(Of EPlant)
    '    Dim conn As New SqlHandle()
    '    Dim consulta As String
    '    Dim lo_que_devuelve As MySqlDataReader
    '    Dim listaPlanta As New List(Of EPlant)

    '    consulta = "SELECT * FROM planta"
    '    lo_que_devuelve = conn.SendQuery(consulta)
    '    If lo_que_devuelve.HasRows Then
    '        While (lo_que_devuelve.Read)
    '            listaPlanta.Add(CreatePlant(lo_que_devuelve))
    '        End While
    '    End If
    '    conn.Close()
    '    Return (listaPlanta)
    'End Function

    Public Sub Add(plant As EPlant)
        Dim conn As New SqlHandle()
        Dim query As String = "INSERT INTO Planta(precio, Especie_nombre, fecha) VALUES('" + plant.Price.ToString() + "', '" + plant.Species.Name + "', '" + SqlHandle.GetMySqlDateFormat(plant.DatePlanted) + "');"
        conn.SendCommand(query)
        Dim result As MySqlDataReader = conn.SendQuery("SELECT LAST_INSERT_ID();")
        Dim id As String = ""
        If result.Read() Then
            id = result.GetString(0)
        Else
            Throw New Exception("No se pudo obtener el id de la nueva planta")
        End If
        query = "INSERT INTO PlantaMaceta(Planta_id, Maceta_id, Zona_nombre) VALUES(" + id + ", " + plant.PlantPot.Id.ToString() + ", '" + plant.Zone.ZoneName + "');"
        result.Close()
        conn.SendCommand(query)
        conn.Close()
    End Sub

    Public Sub Modify(plant As EPlant)
        Dim querys As String() = {"UPDATE Planta SET precio = " + plant.Price.ToString().Replace(",", ".") + ", Especie_nombre = '" + plant.Species.Name + ", fecha ='" + SqlHandle.GetMySqlDateFormat(plant.DatePlanted) + ";", "UPDATE PlantaMaceta SET Maceta_id = " + plant.PlantPot.Id.ToString() + ", Zona_nombre = '" + plant.Zone.ZoneName + "';"}
        SqlHandle.StaticSendCommand(querys)
    End Sub

    Public Sub Remove(id As Integer)
        Dim id_ = id.ToString()
        Dim querys As String() = {"DELETE FROM PlantaMaceta WHERE Planta_id = " + id_ + ";", "DELETE FROM Planta WHERE id = " + id_ + ";"}
        SqlHandle.StaticSendCommand(querys)
    End Sub

    Public Function BySpecies(name As String) As List(Of EPlant)
        Dim query As String = "SELECT Planta.id, Planta.precio, Planta.fecha, Especie.nombre, Especie.tipo, Especie.familia, Especie.tipoZona, Especie.tiempoCultivo, Especie.faseLunar, Especie.humedad, Maceta.Material, Maceta.id, Maceta.tamaño, Producto.id, Producto.nombre, Zona.nombre, Zona.Tamaño, Zona.tipo  FROM Planta INNER JOIN PlantaMaceta ON PlantaMaceta.Planta_id = Planta.id INNER JOIN Especie ON Especie.nombre = Planta.Especie_nombre INNER JOIN Maceta ON Maceta.id = PlantaMaceta.Maceta_id INNER JOIN Producto ON Producto.id = Maceta.Producto_id INNER JOIN Zona ON PlantaMaceta.Zona_nombre = Zona.nombre WHERE Planta.Especie_nombre LIKE '%" + SqlHandle.Escape(name) + "%';"
        Dim conn As New SqlHandle()
        Dim result As MySqlDataReader = conn.SendQuery(query)
        Dim out As New List(Of EPlant)
        While result.Read()
            out.Add(New EPlant(result.GetInt32(0), result.GetDateTime(2), New ESpecies(result.GetString(3), result.GetString(4), result.GetString(5), result.GetString(6), result.GetInt32(7), result.GetString(8), result.GetDouble(9)), New EPlantPot(result.GetInt32(11), result.GetString(10), result.GetString(12), result.GetInt32(13), result.GetString(14)), New EZone(result.GetString(15), result.GetString(16), result.GetString(17)), result.GetDouble(1)))
        End While
        conn.Close()
        Return out
    End Function


End Class
