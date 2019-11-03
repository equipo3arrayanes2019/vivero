Imports Entities
Imports MySql
Imports MySql.Data.MySqlClient
Public Class PSensor
    Private Function CreatSensor(fila As MySqlDataReader) As ESensor 'Se genera un tipo listado en VB.Net para luego pedir los datos desde MySQL
        Dim unSensor As New ESensor
        Dim unPZona As New PZone

        unSensor.SensorId = fila.GetString("id")
        unSensor.Type = fila.GetString("tipo")
        'unSensor.
        Return (unSensor)
    End Function
    Public Function ById(idS As String) As ESensor
        Dim query1 As String
        Dim data As MySqlDataReader
        Dim sensor As New ESensor
        Dim conn As New SqlHandle()

        query1 = "SELECT * FROM sensor where id =( '" & idS & "' );"
        data = conn.SendQuery(query1)
        While data.Read
            sensor = CreatSensor(data)
        End While
        Return sensor
    End Function

    Public Function ByZone(zone As EZone) As List(Of ESensor)
        Dim query As String = "SELECT * FROM Sensor WHERE Sensor.Zona_nombre = '" + zone.ZoneName + "';"
        Dim conn As New SqlHandle()
        Dim result = conn.SendQuery(query)
        Dim out As New List(Of ESensor)
        While result.Read
            out.Add(New ESensor(result.GetString("id"), result.GetString("tipo"), zone))
        End While
        conn.Close()
        Return out
    End Function

    Public Function List() As List(Of ESensor)
        Dim consulta As String
        Dim lo_que_devuelve As MySqlDataReader
        Dim listaSensor As New List(Of ESensor)
        Dim conn As New SqlHandle()

        consulta = "SELECT * FROM sensor"
        lo_que_devuelve = conn.SendQuery(consulta)
        If lo_que_devuelve.HasRows Then
            While (lo_que_devuelve.Read)
                listaSensor.Add(CreatSensor(lo_que_devuelve))
            End While
        End If
        conn.Close()
        Return (listaSensor)
    End Function

    Public Sub Add(sensor As ESensor)
        Dim query As String = "INSERT INTO Sensor(id, tipo, Zona_nombre) VALUES('" + SqlHandle.Escape(sensor.SensorId) + "', '" + sensor.Type + "', '" + sensor.Zone.ZoneName + "');"
        SqlHandle.StaticSendCommand(query)
    End Sub

    Public Sub Remove(id As String)
        Dim query As String = "DELETE FROM Sensor WHERE id = '" + SqlHandle.Escape(id) + "';"
        SqlHandle.StaticSendCommand(query)
    End Sub

    Public Sub Update(sensor As ESensor)
        Dim query As String = "UPDATE Sensor SET id = '" + SqlHandle.Escape(sensor.SensorId) + "', tipo = '" + sensor.Type + "', Zona_nombre = '" + sensor.Zone.ZoneName + "' WHERE id = '" + SqlHandle.Escape(sensor.SensorId) + "';"
        SqlHandle.StaticSendCommand(query)
    End Sub
End Class
