Imports Persistencia
Imports Entidades
Public Class clsDSensor
    Dim Consulta As New clsPSensor
    Public Function listarSensor() As List(Of clsSensor)
        Return (Consulta.listarSensor)
    End Function
End Class
