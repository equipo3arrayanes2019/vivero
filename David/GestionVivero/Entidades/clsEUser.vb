Public Class clsEUser
    Private mUser As String
    Private mContra As String
    Public Property user As String
        Get
            Return mUser
        End Get
        Set(value As String)
            mUser = value
        End Set
    End Property
    Public Property contra As String
        Get
            Return mContra
        End Get
        Set(value As String)
            mContra = value
        End Set
    End Property

    Public Sub New()

    End Sub
    Public Sub New(usr As String, cont As String)

        user = usr
        contra = cont

    End Sub


End Class
