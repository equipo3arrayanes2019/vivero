Imports Entidades
Imports Persistencia
Public Class clsDZona
    Dim Consulta As New clsPZona
    Public Sub altaZona(unE As clsZona)
        Consulta.altaZona(unE)
    End Sub
    Public Function listarZona() As List(Of clsZona)
        Return (Consulta.listarZona)
    End Function

    Public Sub darZona(idZ As String)
        Consulta.darZona(idZ)
    End Sub
End Class
