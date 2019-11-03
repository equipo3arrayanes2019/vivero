Imports Persistence
Imports Entities
Public Class DSensor
    Dim psensor As New PSensor
    Public Function List() As List(Of ESensor)
        Return (psensor.List)
    End Function

    Public Sub Add(sensor As ESensor)
        psensor.Add(sensor)
    End Sub

    Public Sub Remove(id As String)
        psensor.Remove(id)
    End Sub
End Class
