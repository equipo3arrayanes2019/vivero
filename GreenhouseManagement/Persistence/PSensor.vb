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
        Dim consulta As String
        Dim datos As MySqlDataReader
        Dim unSensor As New ESensor
        Dim conn As New SqlHandle()

        consulta = "SELECT * FROM sensor where id =( '" & idS & "' );"
        datos = conn.SendQuery(consulta)
        While datos.Read
            unSensor = CreatSensor(datos)
        End While
        Return unSensor
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
End Class
