Imports Entidades
Imports MySql
Imports MySql.Data.MySqlClient
Public Class clsPSensor
    Inherits clsPersistencia
    Private Function RecrearSensor(fila As MySqlDataReader) As clsSensor 'Se genera un tipo listado en VB.Net para luego pedir los datos desde MySQL
        Dim unSensor As New clsSensor
        Dim unPZona As New clsPZona
        unSensor.Sensor_id = fila.GetString("id")
        unSensor.tipo = fila.GetString("tipo")
        'unSensor.
        Return (unSensor)
    End Function
    Public Function darSensorid(idS As String) As clsSensor
        Dim consulta As String
        Dim datos As MySqlDataReader
        Dim unSensor As New clsSensor
        consulta = "SELECT * FROM sensor where id =( '" & idS & "' );"
        datos = ejecutarYdevolver(consulta)
        While datos.Read
            unSensor = RecrearSensor(datos)
        End While
        Return unSensor
    End Function
    Public Function listarSensor() As List(Of clsSensor)
        Dim consulta As String
        Dim lo_que_devuelve As MySqlDataReader
        Dim listaSensor As New List(Of clsSensor)
        consulta = "SELECT * FROM sensor"
        lo_que_devuelve = ejecutarYdevolver(consulta)
        If lo_que_devuelve.HasRows Then
            While (lo_que_devuelve.Read)
                listaSensor.Add(RecrearSensor(lo_que_devuelve))
            End While
        End If
        Return (listaSensor)
    End Function
End Class
