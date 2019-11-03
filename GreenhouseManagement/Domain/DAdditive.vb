Imports Entities
Imports Persistence
Public Class DAdditive
    Dim consulta As New PAdditive
    Public Sub Add(unE As EAdditive)
        consulta.Add(unE)
    End Sub
    Public Function List() As List(Of EAdditive)
        Return (consulta.List)
    End Function
    'Public Function bajaAditivo(id As Integer)
    '    consulta.bajaAditivo(id)
    'End Function
End Class
