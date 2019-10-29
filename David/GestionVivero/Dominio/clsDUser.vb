Imports Persistencia
Imports Entidades
Public Class clsDUser
    Dim unPUser As New clsPUser
    Public Function loginUsuario(user As String, contra As String) As clsPersona
        Return unPUser.loginUsuario(user, contra)
    End Function
End Class
