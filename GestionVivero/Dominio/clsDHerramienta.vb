Imports Entidades
Imports Persistencia
Public Class clsDHerramienta
    Dim Consulta As New clsPHerramienta
    Public Function listarHerramienta() As List(Of clsHerramienta)
        Return (Consulta.listarHerramineta)
    End Function
    Public Sub altaHerramienta(unE As clsHerramienta)
        Consulta.altaHerramienta(unE)
    End Sub
End Class
