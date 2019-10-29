Option Strict Off
Imports Entidades
Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class clsPMedicion
    Inherits clsPersistencia

    Private Function RecrearMedicion(fila As MySqlDataReader) As clsMedicion
        Dim unMedi As New clsMedicion
        Dim unPSensor As New clsPSensor
        Dim unPZona As New clsPZona
        unMedi.id = fila.GetInt32("id")
        unMedi.fecha = fila.GetDateTime("fecha")
        unMedi.valor = fila.GetString("valor")
        unMedi.Sensor_id = unPSensor.darSensorid(fila.GetString("Sensor_id"))
        unMedi.Zona_nombre = unPZona.darZona(fila.GetString("Zona_nombre"))
        Return (unMedi)
    End Function

    Public Function listarMedicion() As List(Of clsMedicion)
        Dim consulta As String
        Dim lo_que_devuelve As MySqlDataReader
        Dim listaMedicion As New List(Of clsMedicion)
        consulta = "SELECT * FROM medicion WHERE 1"
        lo_que_devuelve = ejecutarYdevolver(consulta)
        If lo_que_devuelve.HasRows Then
            While (lo_que_devuelve.Read)
                listaMedicion.Add(RecrearMedicion(lo_que_devuelve))
            End While
        End If
        Return (listaMedicion)
    End Function
End Class
