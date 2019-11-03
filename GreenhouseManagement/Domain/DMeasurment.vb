Imports Persistence
Imports Entities
Public Class DMeasurment
    Dim Consulta As New PMeasurement
    Public Function List() As List(Of EMeasurement)
        Return (Consulta.ListMeasurement)
    End Function
End Class
