Imports Persistencia
Imports Entidades

Public Class clsDUsuario
    Public Function loginUsuario(user As usuario) As Boolean
        Dim ret As Boolean
        Dim puser As New clsPUsuario()
        ret = puser.loginUsuario(user)
        Return ret
    End Function
End Class
