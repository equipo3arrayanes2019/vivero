Imports Persistence
Imports Entities
Public Class Controller
    Private dplant As New DPlant
    Private dperson As New PPerson
    Private dzone As New DZone
    Private dsensor As New DSensor
    Private dspecies As New DSpecies
    Private dplantpot As New DPlantPot

    '----------------------------------------PLANT-------------------------------------------
    'Public Sub AddPlant(unE As EPlant)
    '    dplant.Add(unE)
    'End Sub

    'Public Function ListPlants() As List(Of EPlant)
    '    Return (dplant.List)
    'End Function
    'Public Sub RemovePalnt(CI As String)
    '    dplant.Remove(CI)
    'End Sub

    Public Sub AddPlant(plant As EPlant)
        dplant.Add(plant)
    End Sub

    Public Sub ModifyPlant(plant As EPlant)
        dplant.Modify(plant)
    End Sub

    Public Sub RemovePlant(id As Integer)
        dplant.Remove(id)
    End Sub

    Public Function ListPlantsBySpecies(name As String) As List(Of EPlant)
        Return dplant.BySpecies(name)
    End Function

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

    Public Function ListSensorByZone(zone As EZone) As List(Of ESensor)
        Return dsensor.ByZone(zone)
    End Function

    Public Sub UpdateSensor(sensor As ESensor)
        dsensor.Update(sensor)
    End Sub

    '----------------------------------------Species-------------------------------------------

    Public Sub RemoveSpecies(name As String)
        dspecies.Remove(name)
    End Sub

    Public Sub AddSpecies(s As ESpecies)
        dspecies.Add(s)
    End Sub

    Public Sub UpdateSpecies(s As ESpecies)
        dspecies.Update(s)
    End Sub

    Public Function SpeciesByName(name As String) As List(Of ESpecies)
        Return dspecies.ByName(name)
    End Function

    Public Function SpeciesByType(type As String) As List(Of ESpecies)
        Return dspecies.ByType(type)
    End Function

    '----------------------------------------PlantPot-------------------------------------------
    Public Sub AddPlantPot(p As EPlantPot)
        dplantpot.Add(p)
    End Sub

    Public Sub RemovePlantPot(p As EPlantPot)
        dplantpot.Remove(p)
    End Sub

    Public Sub UpdatePlantPot(p As EPlantPot)
        dplantpot.Update(p)
    End Sub

    Public Function ListPlantPotByMaterial(m As String) As List(Of EPlantPot)
        Return dplantpot.ByMaterial(m)
    End Function

End Class