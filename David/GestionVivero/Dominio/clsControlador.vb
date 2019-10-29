Imports Persistencia
Imports Entidades
Public Class clsControlador
    Dim unDUser As New clsDUser
    Public Function loginUsuario(user As String, contra As String) As clsPersona
        Return unDUser.loginUsuario(user, contra)
    End Function
End Class