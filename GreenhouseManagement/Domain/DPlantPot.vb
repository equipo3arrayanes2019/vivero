Imports Persistence
Imports Entities
Public Class DPlantPot

    Private pplantpot As New PPlantPot
    Public Sub Add(p As EPlantPot)
        pplantpot.Add(p)
    End Sub

    Public Sub Remove(p As EPlantPot)
        pplantpot.Remove(p)
    End Sub

    Public Sub Update(p As EPlantPot)
        pplantpot.Update(p)
    End Sub

    Public Function ByMaterial(m As String) As List(Of EPlantPot)
        Return pplantpot.ByMaterial(m)
    End Function

End Class
