Imports Persistence
Imports Entities
Public Class DTool
    Dim Consulta As New PTool
    Public Function listarHerramienta() As List(Of ETool)
        Return (Consulta.List)
    End Function
    Public Sub altaHerramienta(unE As ETool)
        Consulta.Add(unE)
    End Sub
End Class
