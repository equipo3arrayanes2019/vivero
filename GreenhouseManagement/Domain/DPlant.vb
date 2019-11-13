Imports Persistence
Imports Entities
Public Class DPlant
    'Dim unPP As New PPlant
    'Public Sub Add(unE As EPlant)
    '    unPP.Add(unE)
    'End Sub
    'Dim consulta As New PPlant
    'Public Function List() As List(Of EPlant)
    '    Return (consulta.List)
    'End Function
    'Public Sub Remove(CI As String)
    '    unPP.Remove(CI)
    'End Sub

    Private pplant As New PPlant()

    Public Sub Add(plant As EPlant)
        pplant.Add(plant)
    End Sub

    Public Sub Modify(plant As EPlant)
        pplant.Modify(plant)
    End Sub

    Public Sub Remove(id As Integer)
        pplant.Remove(id)
    End Sub

    Public Function BySpecies(name As String) As List(Of EPlant)
        Return pplant.BySpecies(name)
    End Function
End Class
