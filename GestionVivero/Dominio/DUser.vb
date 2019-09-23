Imports Persistencia
Imports Entidades

Public Class DUser
    Public Function loginUsuario(user As EUser) As Boolean
        Dim ret As Boolean
        Dim puser As New PUser()
        ret = puser.loginUsuario(user)
        Return ret
    End Function
End Class
