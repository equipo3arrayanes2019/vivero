Imports Entities

Public Class frmPlant

    Public Sub New(p As EPerson)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Person = p
    End Sub

    Private mPerson As EPerson
    Public Property Person() As EPerson
        Get
            Return mPerson
        End Get
        Private Set(ByVal value As EPerson)
            mPerson = value
        End Set
    End Property
    Private Sub FrmPlant_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpDatePlanted.Value = DateTime.Today()
    End Sub
End Class