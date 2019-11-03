Imports Persistence
Imports Entities
Public Class DPlant
    Dim unPP As New PPlant
    Public Sub Add(unE As EPlant)
        unPP.Add(unE)
    End Sub
    Dim consulta As New PPlant
    Public Function List() As List(Of EPlant)
        Return (consulta.List)
    End Function
    Public Sub Remove(CI As String)
        unPP.Remove(CI)
    End Sub
End Class
