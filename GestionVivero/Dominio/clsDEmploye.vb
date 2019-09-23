Imports Persistencia
Imports Entidades
Public Class clsDEmploye

    'Public Function addemploye(emp As clsemploye) As Boolean
    '    Dim ret As Boolean
    '    Dim pemp As New clsPEmploye()
    '    pemp = Nothing
    '    ret = pemp.altaEmpleado(emp)
    '    Return ret
    'End Function
    Dim unPE As New clsPEmploye
    Public Sub altaEmpleado(unE As clsemploye)
        unPE.altaEmpleado(unE)

    End Sub
    Public Sub bajaEmpleado(ci As String)
        'unPE.bajaEmpleado(ci)
    End Sub
End Class
