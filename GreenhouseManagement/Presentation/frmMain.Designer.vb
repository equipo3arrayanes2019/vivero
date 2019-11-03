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
        Me.tsmiZones = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiZoneAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiZoneViewZone = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiStock = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiStockMaterials = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiStockMaterialsList = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiStockMaterialsAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiStockTools = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiStockToolsList = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiStockToolsAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiStockSeeds = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KAPPALEEELMANUALPIBEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.msMain = New System.Windows.Forms.MenuStrip()
        Me.SensoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TemperaturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GraficaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HumedadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GraficaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MedicionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiPersons = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiRegister = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiSensorsAddnew = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiViewSensor = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.tsmiPlants.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiSpeciesBook, Me.tsmiPlant})
        Me.tsmiPlants.Name = "tsmiPlants"
        Me.tsmiPlants.Size = New System.Drawing.Size(57, 20)
        Me.tsmiPlants.Text = "Plantas"
        '
        'tsmiSpeciesBook
        '
        Me.tsmiSpeciesBook.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiSpeciesBookBrowse, Me.tsmiSpeciesBookAdd})
        Me.tsmiSpeciesBook.Name = "tsmiSpeciesBook"
        Me.tsmiSpeciesBook.Size = New System.Drawing.Size(180, 22)
        Me.tsmiSpeciesBook.Text = "Libro de especies"
        '
        'tsmiSpeciesBookBrowse
        '
        Me.tsmiSpeciesBookBrowse.Name = "tsmiSpeciesBookBrowse"
        Me.tsmiSpeciesBookBrowse.Size = New System.Drawing.Size(116, 22)
        Me.tsmiSpeciesBookBrowse.Text = "Buscar"
        '
        'tsmiSpeciesBookAdd
        '
        Me.tsmiSpeciesBookAdd.Name = "tsmiSpeciesBookAdd"
        Me.tsmiSpeciesBookAdd.Size = New System.Drawing.Size(116, 22)
        Me.tsmiSpeciesBookAdd.Text = "Agregar"
        '
        'tsmiPlant
        '
        Me.tsmiPlant.Name = "tsmiPlant"
        Me.tsmiPlant.Size = New System.Drawing.Size(180, 22)
        Me.tsmiPlant.Text = "Plantar"
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
        Me.tsmiZoneAdd.Size = New System.Drawing.Size(180, 22)
        Me.tsmiZoneAdd.Text = "Agregar"
        '
        'tsmiZoneViewZone
        '
        Me.tsmiZoneViewZone.Name = "tsmiZoneViewZone"
        Me.tsmiZoneViewZone.Size = New System.Drawing.Size(180, 22)
        Me.tsmiZoneViewZone.Text = "Ver Zona"
        '
        'tsmiStock
        '
        Me.tsmiStock.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiStockMaterials, Me.tsmiStockTools, Me.tsmiStockSeeds})
        Me.tsmiStock.Name = "tsmiStock"
        Me.tsmiStock.Size = New System.Drawing.Size(48, 20)
        Me.tsmiStock.Text = "Stock"
        '
        'tsmiStockMaterials
        '
        Me.tsmiStockMaterials.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiStockMaterialsList, Me.tsmiStockMaterialsAdd})
        Me.tsmiStockMaterials.Name = "tsmiStockMaterials"
        Me.tsmiStockMaterials.Size = New System.Drawing.Size(145, 22)
        Me.tsmiStockMaterials.Text = "Insumos"
        '
        'tsmiStockMaterialsList
        '
        Me.tsmiStockMaterialsList.Name = "tsmiStockMaterialsList"
        Me.tsmiStockMaterialsList.Size = New System.Drawing.Size(116, 22)
        Me.tsmiStockMaterialsList.Text = "Listar"
        '
        'tsmiStockMaterialsAdd
        '
        Me.tsmiStockMaterialsAdd.Name = "tsmiStockMaterialsAdd"
        Me.tsmiStockMaterialsAdd.Size = New System.Drawing.Size(116, 22)
        Me.tsmiStockMaterialsAdd.Text = "Agregar"
        '
        'tsmiStockTools
        '
        Me.tsmiStockTools.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiStockToolsList, Me.tsmiStockToolsAdd})
        Me.tsmiStockTools.Name = "tsmiStockTools"
        Me.tsmiStockTools.Size = New System.Drawing.Size(145, 22)
        Me.tsmiStockTools.Text = "Herramientas"
        '
        'tsmiStockToolsList
        '
        Me.tsmiStockToolsList.Name = "tsmiStockToolsList"
        Me.tsmiStockToolsList.Size = New System.Drawing.Size(116, 22)
        Me.tsmiStockToolsList.Text = "Listar"
        '
        'tsmiStockToolsAdd
        '
        Me.tsmiStockToolsAdd.Name = "tsmiStockToolsAdd"
        Me.tsmiStockToolsAdd.Size = New System.Drawing.Size(116, 22)
        Me.tsmiStockToolsAdd.Text = "Agregar"
        '
        'tsmiStockSeeds
        '
        Me.tsmiStockSeeds.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListarToolStripMenuItem3})
        Me.tsmiStockSeeds.Name = "tsmiStockSeeds"
        Me.tsmiStockSeeds.Size = New System.Drawing.Size(145, 22)
        Me.tsmiStockSeeds.Text = "Semillas"
        '
        'ListarToolStripMenuItem3
        '
        Me.ListarToolStripMenuItem3.Name = "ListarToolStripMenuItem3"
        Me.ListarToolStripMenuItem3.Size = New System.Drawing.Size(102, 22)
        Me.ListarToolStripMenuItem3.Text = "Listar"
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
        Me.KAPPALEEELMANUALPIBEToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.KAPPALEEELMANUALPIBEToolStripMenuItem.Text = "Manual Usuario"
        '
        'ContactoToolStripMenuItem
        '
        Me.ContactoToolStripMenuItem.Name = "ContactoToolStripMenuItem"
        Me.ContactoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ContactoToolStripMenuItem.Text = "Contacto"
        '
        'msMain
        '
        Me.msMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiSession, Me.tsmiZones, Me.SensoresToolStripMenuItem, Me.tsmiPlants, Me.tsmiStock, Me.tsmiPersons, Me.AyudaToolStripMenuItem})
        Me.msMain.Location = New System.Drawing.Point(0, 0)
        Me.msMain.Name = "msMain"
        Me.msMain.Size = New System.Drawing.Size(666, 24)
        Me.msMain.TabIndex = 1
        Me.msMain.Text = "msMain"
        '
        'SensoresToolStripMenuItem
        '
        Me.SensoresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TemperaturaToolStripMenuItem, Me.HumedadToolStripMenuItem, Me.MedicionToolStripMenuItem, Me.tsmiSensorsAddnew, Me.tsmiViewSensor})
        Me.SensoresToolStripMenuItem.Name = "SensoresToolStripMenuItem"
        Me.SensoresToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.SensoresToolStripMenuItem.Text = "Sensores"
        '
        'TemperaturaToolStripMenuItem
        '
        Me.TemperaturaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListarToolStripMenuItem1, Me.GraficaToolStripMenuItem})
        Me.TemperaturaToolStripMenuItem.Name = "TemperaturaToolStripMenuItem"
        Me.TemperaturaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TemperaturaToolStripMenuItem.Text = "Temperatura"
        '
        'ListarToolStripMenuItem1
        '
        Me.ListarToolStripMenuItem1.Name = "ListarToolStripMenuItem1"
        Me.ListarToolStripMenuItem1.Size = New System.Drawing.Size(111, 22)
        Me.ListarToolStripMenuItem1.Text = "Listar"
        '
        'GraficaToolStripMenuItem
        '
        Me.GraficaToolStripMenuItem.Name = "GraficaToolStripMenuItem"
        Me.GraficaToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.GraficaToolStripMenuItem.Text = "Grafica"
        '
        'HumedadToolStripMenuItem
        '
        Me.HumedadToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListarToolStripMenuItem2, Me.GraficaToolStripMenuItem1})
        Me.HumedadToolStripMenuItem.Name = "HumedadToolStripMenuItem"
        Me.HumedadToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.HumedadToolStripMenuItem.Text = "Humedad"
        '
        'ListarToolStripMenuItem2
        '
        Me.ListarToolStripMenuItem2.Name = "ListarToolStripMenuItem2"
        Me.ListarToolStripMenuItem2.Size = New System.Drawing.Size(111, 22)
        Me.ListarToolStripMenuItem2.Text = "Listar"
        '
        'GraficaToolStripMenuItem1
        '
        Me.GraficaToolStripMenuItem1.Name = "GraficaToolStripMenuItem1"
        Me.GraficaToolStripMenuItem1.Size = New System.Drawing.Size(111, 22)
        Me.GraficaToolStripMenuItem1.Text = "Grafica"
        '
        'MedicionToolStripMenuItem
        '
        Me.MedicionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListarToolStripMenuItem4})
        Me.MedicionToolStripMenuItem.Name = "MedicionToolStripMenuItem"
        Me.MedicionToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MedicionToolStripMenuItem.Text = "Medicion"
        '
        'ListarToolStripMenuItem4
        '
        Me.ListarToolStripMenuItem4.Name = "ListarToolStripMenuItem4"
        Me.ListarToolStripMenuItem4.Size = New System.Drawing.Size(102, 22)
        Me.ListarToolStripMenuItem4.Text = "Listar"
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
        Me.tsmiRegister.Size = New System.Drawing.Size(116, 22)
        Me.tsmiRegister.Text = "Regisrar"
        '
        'ListarToolStripMenuItem
        '
        Me.ListarToolStripMenuItem.Name = "ListarToolStripMenuItem"
        Me.ListarToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.ListarToolStripMenuItem.Text = "Listar"
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
    Friend WithEvents tsmiStock As ToolStripMenuItem
    Friend WithEvents tsmiStockTools As ToolStripMenuItem
    Friend WithEvents tsmiStockToolsList As ToolStripMenuItem
    Friend WithEvents tsmiStockToolsAdd As ToolStripMenuItem
    Friend WithEvents tsmiStockMaterials As ToolStripMenuItem
    Friend WithEvents tsmiStockMaterialsList As ToolStripMenuItem
    Friend WithEvents tsmiStockMaterialsAdd As ToolStripMenuItem
    Friend WithEvents tsmiStockSeeds As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KAPPALEEELMANUALPIBEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents msMain As MenuStrip
    Friend WithEvents tsmiPersons As ToolStripMenuItem
    Friend WithEvents tsmiRegister As ToolStripMenuItem
    Friend WithEvents ListarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContactoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SensoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TemperaturaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GraficaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HumedadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents GraficaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ListarToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents MedicionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents tsmiZoneViewZone As ToolStripMenuItem
    Friend WithEvents tsmiSensorsAddnew As ToolStripMenuItem
    Friend WithEvents tsmiViewSensor As ToolStripMenuItem
End Class
