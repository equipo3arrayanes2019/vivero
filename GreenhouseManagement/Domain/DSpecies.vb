Imports Persistence
Imports Entities

Public Class DSpecies

    Private pspecies As New PSpecies

    Public Sub Remove(name As String)
        pspecies.Remove(name)
    End Sub

    Public Sub Add(s As ESpecies)
        pspecies.Add(s)
    End Sub

    Public Sub Update(s As ESpecies)
        pspecies.Update(s)
    End Sub

    Public Function ByName(name As String) As List(Of ESpecies)
        Return pspecies.ByName(name)
    End Function
    Public Function ByType(type As String) As List(Of ESpecies)
        Return pspecies.ByType(type)
    End Function

End Class
