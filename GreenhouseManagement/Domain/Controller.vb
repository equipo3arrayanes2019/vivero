﻿Imports Persistence
Imports Entities
Public Class Controller
    Private dplant As New DPlant
    Private dperson As New PPerson
    Private dzone As New DZone
    Private dsensor As New DSensor

    '----------------------------------------PLANT-------------------------------------------
    Public Sub AddPlant(unE As EPlant)
        dplant.Add(unE)
    End Sub

    Public Function ListPlants() As List(Of EPlant)
        Return (dplant.List)
    End Function
    Public Sub RemovePalnt(CI As String)
        dplant.Remove(CI)
    End Sub

    '----------------------------------------PERSON-------------------------------------------

    Public Function Login(user As String, contra As String) As EPerson
        Return dperson.Login(user, contra)
    End Function
    Public Sub AddPerson(unE As EPerson)
        dperson.AddPerson(unE)
    End Sub
    Public Function ListPerson() As List(Of EPerson)
        Return (dperson.ListPerson)
    End Function
    Public Sub RemovePerson(cedula As String)
        dperson.RemovePerson(cedula)
    End Sub
    Public Sub ModifyPerson(unE As EPerson)
        dperson.ModifyPerson(unE)
    End Sub

    '----------------------------------------ZONE-------------------------------------------
    Public Function ListZone() As List(Of EZone)
        Return dzone.List()
    End Function

    Public Function ListZonesByType(type As String) As List(Of EZone)
        Return dzone.ListByType(type)
    End Function

    Public Sub RemoveZone(name As String)
        dzone.Remvoe(name)
    End Sub

    '----------------------------------------Sensor-------------------------------------------

    Public Sub AddSensor(sensor As ESensor)
        dsensor.Add(sensor)
    End Sub

    Public Sub RemoveSensor(id As String)
        dsensor.Remove(id)
    End Sub

End Class