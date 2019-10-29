Imports Persistencia
Imports Entidades
Public Class clsDPlant
    Dim unPP As New clsPPlant
    Public Sub altaPlanta(unE As clsPlanta)
        unPP.altaPlanta(unE)
    End Sub
    Dim consulta As New clsPPlant
    Public Function listar() As List(Of clsPlanta)
        Return (consulta.listar)
    End Function
    Public Sub bajaPlanta(cedula As String)
        unPP.bajaPlanta(cedula)
    End Sub
End Class
