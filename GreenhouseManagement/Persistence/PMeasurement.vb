
Imports Entities
Imports MySql.Data.MySqlClient
Public Class PMeasurement

    Private Function CreateMeasurement(fila As MySqlDataReader) As EMeasurement
        Dim unMedi As New EMeasurement
        Dim unPSensor As New PSensor
        Dim unPZona As New PZone

        unMedi.Id = fila.GetInt32("id")
        unMedi.DateTaken = fila.GetDateTime("fecha")
        unMedi.Value = fila.GetString("valor")
        unMedi.SensorId = unPSensor.ById(fila.GetString("Sensor_id"))
        unMedi.ZoneName = unPZona.ById(fila.GetString("Zona_nombre"))
        Return (unMedi)
    End Function

    Public Function ListMeasurement() As List(Of EMeasurement)
        Dim consulta As String
        Dim lo_que_devuelve As MySqlDataReader
        Dim listaMedicion As New List(Of EMeasurement)
        Dim conn As New SqlHandle()

        consulta = "SELECT * FROM medicion WHERE 1"
        lo_que_devuelve = conn.SendQuery(consulta)
        If lo_que_devuelve.HasRows Then
            While (lo_que_devuelve.Read)
                listaMedicion.Add(CreateMeasurement(lo_que_devuelve))
            End While
        End If
        conn.Close()
        Return (listaMedicion)
    End Function
End Class
