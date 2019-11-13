<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.tsmiSession = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiCloseProgram = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiPlants = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiSpeciesBook = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiSpeciesBookBrowse = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiSpeciesBookAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiPlant = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiPlantsView = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiZones = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiZoneAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiZoneViewZone = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KAPPALEEELMANUALPIBEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.msMain = New System.Windows.Forms.MenuStrip()
        Me.SensoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiSensorsAddnew = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiViewSensor = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiPersons = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiRegister = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiPlantPots = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiPlantPotAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiPlantPotList = New System.Windows.Forms.ToolStripMenuItem()
        Me.msMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'tsmiSession
        '
        Me.tsmiSession.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiExit, Me.tsmiCloseProgram})
        Me.tsmiSession.Name = "tsmiSession"
        Me.tsmiSession.Size = New System.Drawing.Size(53, 20)
        Me.tsmiSession.Text = "Sesión"
        '
        'tsmiExit
        '
        Me.tsmiExit.Name = "tsmiExit"
        Me.tsmiExit.Size = New System.Drawing.Size(161, 22)
        Me.tsmiExit.Text = "Salir"
        '
        'tsmiCloseProgram
        '
        Me.tsmiCloseProgram.Name = "tsmiCloseProgram"
        Me.tsmiCloseProgram.Size = New System.Drawing.Size(161, 22)
        Me.tsmiCloseProgram.Text = "Cerrar programa"
        '
        'tsmiPlants
        '
        Me.tsmiPlants.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiSpeciesBook, Me.tsmiPlant, Me.tsmiPlantsView})
        Me.tsmiPlants.Name = "tsmiPlants"
        Me.tsmiPlants.Size = New System.Drawing.Size(57, 20)
        Me.tsmiPlants.Text = "Plantas"
        '
        'tsmiSpeciesBook
        '
        Me.tsmiSpeciesBook.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiSpeciesBookBrowse, Me.tsmiSpeciesBookAdd})
        Me.tsmiSpeciesBook.Name = "tsmiSpeciesBook"
        Me.tsmiSpeciesBook.Size = New System.Drawing.Size(120, 22)
        Me.tsmiSpeciesBook.Text = "Especies"
        '
        'tsmiSpeciesBookBrowse
        '
        Me.tsmiSpeciesBookBrowse.Name = "tsmiSpeciesBookBrowse"
        Me.tsmiSpeciesBookBrowse.Size = New System.Drawing.Size(186, 22)
        Me.tsmiSpeciesBookBrowse.Text = "Buscar"
        '
        'tsmiSpeciesBookAdd
        '
        Me.tsmiSpeciesBookAdd.Name = "tsmiSpeciesBookAdd"
        Me.tsmiSpeciesBookAdd.Size = New System.Drawing.Size(186, 22)
        Me.tsmiSpeciesBookAdd.Text = "Añadir nueva especie"
        '
        'tsmiPlant
        '
        Me.tsmiPlant.Name = "tsmiPlant"
        Me.tsmiPlant.Size = New System.Drawing.Size(120, 22)
        Me.tsmiPlant.Text = "Registrar"
        '
        'tsmiPlantsView
        '
        Me.tsmiPlantsView.Name = "tsmiPlantsView"
        Me.tsmiPlantsView.Size = New System.Drawing.Size(120, 22)
        Me.tsmiPlantsView.Text = "Ver"
        '
        'tsmiZones
        '
        Me.tsmiZones.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiZoneAdd, Me.tsmiZoneViewZone})
        Me.tsmiZones.Name = "tsmiZones"
        Me.tsmiZones.Size = New System.Drawing.Size(46, 20)
        Me.tsmiZones.Text = "Zona"
        '
        'tsmiZoneAdd
        '
        Me.tsmiZoneAdd.Name = "tsmiZoneAdd"
        Me.tsmiZoneAdd.Size = New System.Drawing.Size(121, 22)
        Me.tsmiZoneAdd.Text = "Agregar"
        '
        'tsmiZoneViewZone
        '
        Me.tsmiZoneViewZone.Name = "tsmiZoneViewZone"
        Me.tsmiZoneViewZone.Size = New System.Drawing.Size(121, 22)
        Me.tsmiZoneViewZone.Text = "Ver Zona"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KAPPALEEELMANUALPIBEToolStripMenuItem, Me.ContactoToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'KAPPALEEELMANUALPIBEToolStripMenuItem
        '
        Me.KAPPALEEELMANUALPIBEToolStripMenuItem.Name = "KAPPALEEELMANUALPIBEToolStripMenuItem"
        Me.KAPPALEEELMANUALPIBEToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.KAPPALEEELMANUALPIBEToolStripMenuItem.Text = "Manual Usuario"
        '
        'ContactoToolStripMenuItem
        '
        Me.ContactoToolStripMenuItem.Name = "ContactoToolStripMenuItem"
        Me.ContactoToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.ContactoToolStripMenuItem.Text = "Contacto"
        '
        'msMain
        '
        Me.msMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiSession, Me.tsmiZones, Me.SensoresToolStripMenuItem, Me.tsmiPlants, Me.tsmiPersons, Me.tsmiPlantPots, Me.AyudaToolStripMenuItem})
        Me.msMain.Location = New System.Drawing.Point(0, 0)
        Me.msMain.Name = "msMain"
        Me.msMain.Size = New System.Drawing.Size(666, 24)
        Me.msMain.TabIndex = 1
        Me.msMain.Text = "msMain"
        '
        'SensoresToolStripMenuItem
        '
        Me.SensoresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiSensorsAddnew, Me.tsmiViewSensor})
        Me.SensoresToolStripMenuItem.Name = "SensoresToolStripMenuItem"
        Me.SensoresToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.SensoresToolStripMenuItem.Text = "Sensores"
        '
        'tsmiSensorsAddnew
        '
        Me.tsmiSensorsAddnew.Name = "tsmiSensorsAddnew"
        Me.tsmiSensorsAddnew.Size = New System.Drawing.Size(180, 22)
        Me.tsmiSensorsAddnew.Text = "Agregar Nuevo"
        '
        'tsmiViewSensor
        '
        Me.tsmiViewSensor.Name = "tsmiViewSensor"
        Me.tsmiViewSensor.Size = New System.Drawing.Size(180, 22)
        Me.tsmiViewSensor.Text = "Ver Sensor"
        '
        'tsmiPersons
        '
        Me.tsmiPersons.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiRegister, Me.ListarToolStripMenuItem})
        Me.tsmiPersons.Name = "tsmiPersons"
        Me.tsmiPersons.Size = New System.Drawing.Size(77, 20)
        Me.tsmiPersons.Text = "Empleados"
        '
        'tsmiRegister
        '
        Me.tsmiRegister.Name = "tsmiRegister"
        Me.tsmiRegister.Size = New System.Drawing.Size(180, 22)
        Me.tsmiRegister.Text = "Regisrar"
        '
        'ListarToolStripMenuItem
        '
        Me.ListarToolStripMenuItem.Name = "ListarToolStripMenuItem"
        Me.ListarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ListarToolStripMenuItem.Text = "Listar"
        '
        'tsmiPlantPots
        '
        Me.tsmiPlantPots.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiPlantPotAdd, Me.tsmiPlantPotList})
        Me.tsmiPlantPots.Name = "tsmiPlantPots"
        Me.tsmiPlantPots.Size = New System.Drawing.Size(63, 20)
        Me.tsmiPlantPots.Text = "Macetas"
        '
        'tsmiPlantPotAdd
        '
        Me.tsmiPlantPotAdd.Name = "tsmiPlantPotAdd"
        Me.tsmiPlantPotAdd.Size = New System.Drawing.Size(180, 22)
        Me.tsmiPlantPotAdd.Text = "Añadir"
        '
        'tsmiPlantPotList
        '
        Me.tsmiPlantPotList.Name = "tsmiPlantPotList"
        Me.tsmiPlantPotList.Size = New System.Drawing.Size(180, 22)
        Me.tsmiPlantPotList.Text = "Listar"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 266)
        Me.Controls.Add(Me.msMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.msMain
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vivero Me Gusta"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.msMain.ResumeLayout(False)
        Me.msMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tsmiSession As ToolStripMenuItem
    Friend WithEvents tsmiCloseProgram As ToolStripMenuItem
    Friend WithEvents tsmiExit As ToolStripMenuItem
    Friend WithEvents tsmiPlants As ToolStripMenuItem
    Friend WithEvents tsmiSpeciesBook As ToolStripMenuItem
    Friend WithEvents tsmiSpeciesBookBrowse As ToolStripMenuItem
    Friend WithEvents tsmiSpeciesBookAdd As ToolStripMenuItem
    Friend WithEvents tsmiPlant As ToolStripMenuItem
    Friend WithEvents tsmiZones As ToolStripMenuItem
    Friend WithEvents tsmiZoneAdd As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KAPPALEEELMANUALPIBEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents msMain As MenuStrip
    Friend WithEvents tsmiPersons As ToolStripMenuItem
    Friend WithEvents tsmiRegister As ToolStripMenuItem
    Friend WithEvents ListarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContactoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SensoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsmiZoneViewZone As ToolStripMenuItem
    Friend WithEvents tsmiSensorsAddnew As ToolStripMenuItem
    Friend WithEvents tsmiViewSensor As ToolStripMenuItem
    Friend WithEvents tsmiPlantPots As ToolStripMenuItem
    Friend WithEvents tsmiPlantPotAdd As ToolStripMenuItem
    Friend WithEvents tsmiPlantPotList As ToolStripMenuItem
    Friend WithEvents tsmiPlantsView As ToolStripMenuItem
End Class
