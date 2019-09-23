Imports Persistencia
Imports Entidades
Public Class clsDPerson

    'Public Function addemploye(emp As clsemploye) As Boolean
    '    Dim ret As Boolean
    '    Dim pemp As New clsPEmploye()
    '    pemp = Nothing
    '    ret = pemp.altaEmpleado(emp)
    '    Return ret
    'End Function
    Dim unPE As New clsPPerson
    Public Sub altaPersona(unE As clsPersona)
        unPE.altaPersona(unE)

    End Sub
    Public Sub bajaPersona(ci As String)
        'unPE.bajaPersona(ci)
    End Sub
End Class
