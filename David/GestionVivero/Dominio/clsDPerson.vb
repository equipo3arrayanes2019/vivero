Imports Persistencia
Imports Entidades
Public Class clsDPerson
    Dim consulta As New clsPPerson
    Dim unPE As New clsPPerson
    Public Sub altaPersona(unE As clsPersona)
        unPE.altaPersona(unE)
    End Sub
    Public Function listar() As List(Of clsPersona)
        Return (consulta.listar)
    End Function
    Public Sub bajaPersona(cedula As String)
        unPE.bajaPersona(cedula)
    End Sub
    Public Sub modificarPersona(unE As clsPersona)
        unPE.modificarPersona(unE)
    End Sub
End Class
