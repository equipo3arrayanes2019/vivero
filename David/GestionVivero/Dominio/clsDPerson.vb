Imports Persistencia
Imports Entidades
Public Class clsDPerson

    Dim unPE As New clsPPerson
    Public Sub altaPersona(unE As clsPersona)
        unPE.altaPersona(unE)
    End Sub

    Dim consulta As New clsPPerson
    Public Function listar() As List(Of clsPersona)
        Return (consulta.listar)
    End Function
    Public Sub bajaPersona(cedula As String)
        unPE.bajaPersona(cedula)
    End Sub
End Class
