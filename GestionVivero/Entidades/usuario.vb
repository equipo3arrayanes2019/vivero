Public Class usuario
    Private id As String
    Private clave As String
    Sub New()
        Me.id = ""
        Me.clave = ""
    End Sub
    Sub New(id As String, clave As String)
        Me.id = id
        Me.clave = clave
    End Sub

    Function getID() As String
        Return Me.id
    End Function
    Function getClave() As String
        Return Me.clave
    End Function

    Sub setId(id As String)
        Me.id = id
    End Sub
    Sub setClave(clave As String)
        Me.clave = clave
    End Sub
End Class
