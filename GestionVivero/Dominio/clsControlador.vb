Imports Persistencia
Imports Entidades
Imports Dominio
Public Class clsControlador
    Dim unDUser As New clsDUser
    Dim consulta As New clsPPlant
    Dim unDP As New clsPPlant
    Dim consulta1 As New clsPPerson
    Dim unPE As New clsPPerson
    Dim unZo As New clsPZona
    Public Function loginUsuario(user As String, contra As String) As clsPersona
        Return unDUser.loginUsuario(user, contra)
    End Function
    Public Sub altaPlanta(unE As clsPlanta)
        unDP.altaPlanta(unE)
    End Sub

    Public Function listar() As List(Of clsPlanta)
        Return (consulta.listar)
    End Function
    Public Sub bajaPlanta(cedula As String)
        unDP.bajaPlanta(cedula)
    End Sub


    Public Sub altaPersona(unE As clsPersona)
        unPE.altaPersona(unE)
    End Sub
    Public Function listarPer() As List(Of clsPersona)
        Return (consulta1.listarPer)
    End Function
    Public Sub bajaPersona(cedula As String)
        unPE.bajaPersona(cedula)
    End Sub
    Public Sub modificarPersona(unE As clsPersona)
        unPE.modificarPersona(unE)
    End Sub
    Public Sub darZona(unZ As clsZona)
        'unZo.darZona(unZ)
    End Sub

End Class