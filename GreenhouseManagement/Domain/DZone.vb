Imports Persistence
Imports Entities
Public Class DZone
    Dim pzone As New PZone
    Public Sub Add(unE As EZone)
        pzone.Add(unE)
    End Sub
    Public Function List() As List(Of EZone)
        Return (pzone.List)
    End Function

    Public Sub ById(idZ As String)
        pzone.ById(idZ)
    End Sub

    Public Function ListByType(type As String) As List(Of EZone)
        Return pzone.ListByType(type)
    End Function

    Public Sub Remvoe(name As String)
        pzone.Remove(name)
    End Sub

End Class
