Imports Persistencia
Imports Entidades

Public Class clsDUser
    Public Function loginUsuario(user As user) As Boolean
        Dim ret As Boolean
        Dim puser As New clsPUser()
        ret = puser.loginUsuario(user)
        Return ret
    End Function
End Class
