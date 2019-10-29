Imports Persistencia
Imports Entidades
Public Class clsDAditivo
    Dim consulta As New clsPAditivo
    Public Sub altaAditivo(unE As clsAditivo)
        consulta.altaAditivo(unE)
    End Sub
    Public Function listar() As List(Of clsAditivo)
        Return (consulta.listar)
    End Function
    'Public Function bajaAditivo(id As Integer)
    '    consulta.bajaAditivo(id)
    'End Function
End Class
