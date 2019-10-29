Imports Persistencia
Imports Entidades
Public Class clsDMedicion
    Dim Consulta As New clsPMedicion
    Public Function listarMedicion() As List(Of clsMedicion)
        Return (Consulta.listarMedicion)
    End Function
End Class
