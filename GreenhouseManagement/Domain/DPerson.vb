Imports Persistence
Imports Entities
Public Class DPerson
    Dim unPE As New PPerson
    Public Sub Add(unE As EPerson)
        unPE.AddPerson(unE)
    End Sub
    Public Function List() As List(Of EPerson)
        Return (unPE.ListPerson)
    End Function
    Public Sub Remove(cedula As String)
        unPE.RemovePerson(cedula)
    End Sub
    Public Sub Modify(unE As EPerson)
        unPE.ModifyPerson(unE)
    End Sub
    Public Function Login(user As String, contra As String) As EPerson
        Return unPE.Login(user, contra)
    End Function

End Class
