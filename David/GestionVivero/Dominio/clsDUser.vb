Imports Persistencia
Imports Entidades
Public Class clsDUser
    Dim unPUser As New clsPUser
    Public Function loginUsuario(user As String, pass As String) As clsEUser
        Return unPUser.loginUsuario(user, pass)
    End Function
End Class
