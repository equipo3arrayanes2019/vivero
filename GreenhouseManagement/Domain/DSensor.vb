Imports Persistence
Imports Entities
Public Class DSensor
    Dim psensor As New PSensor
    Public Function List() As List(Of ESensor)
        Return (psensor.List)
    End Function

    Public Function ByZone(zone As EZone) As List(Of ESensor)
        Return psensor.ByZone(zone)
    End Function

    Public Sub Add(sensor As ESensor)
        psensor.Add(sensor)
    End Sub

    Public Sub Remove(id As String)
        psensor.Remove(id)
    End Sub

    Public Sub Update(sensor As ESensor)
        psensor.Update(sensor)
    End Sub
End Class
