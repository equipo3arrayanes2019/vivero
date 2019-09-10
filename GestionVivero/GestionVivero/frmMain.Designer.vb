<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tsmiSession = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiCloseProgram = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiPlants = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiSpeciesBook = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiSpeciesBookBrowse = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiSpeciesBookAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiPlant = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiTracking = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiZones = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiZoneHothouse = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiZoneHothouseList = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiZoneHothouseAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiZoneOutdoors = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiZoneOutdoorsList = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiZoneOutdoorsAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiZoneShadow = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiZoneShadowList = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiZoneShadowAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiStock = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiStockTools = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiStockToolsList = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiStockToolsAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiStockMaterials = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiStockMaterialsList = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiStockMaterialsAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiStockSeeds = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KAPPALEEELMANUALPIBEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.msMain = New System.Windows.Forms.MenuStrip()
        Me.tsmiPersons = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiRegister = New System.Windows.Forms.ToolStripMenuItem()
        Me.msMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'tsmiSession
        '
        Me.tsmiSession.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiCloseProgram, Me.tsmiExit})
        Me.tsmiSession.Name = "tsmiSession"
        Me.tsmiSession.Size = New System.Drawing.Size(53, 20)
        Me.tsmiSession.Text = "Sesión"
        '
        'tsmiCloseProgram
        '
        Me.tsmiCloseProgram.Name = "tsmiCloseProgram"
        Me.tsmiCloseProgram.Size = New System.Drawing.Size(161, 22)
        Me.tsmiCloseProgram.Text = "Cerrar programa"
        '
        'tsmiExit
        '
        Me.tsmiExit.Name = "tsmiExit"
        Me.tsmiExit.Size = New System.Drawing.Size(161, 22)
        Me.tsmiExit.Text = "Salir"
        '
        'tsmiPlants
        '
        Me.tsmiPlants.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiSpeciesBook, Me.tsmiPlant, Me.tsmiTracking})
        Me.tsmiPlants.Name = "tsmiPlants"
        Me.tsmiPlants.Size = New System.Drawing.Size(57, 20)
        Me.tsmiPlants.Text = "Plantas"
        '
        'tsmiSpeciesBook
        '
        Me.tsmiSpeciesBook.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiSpeciesBookBrowse, Me.tsmiSpeciesBookAdd})
        Me.tsmiSpeciesBook.Name = "tsmiSpeciesBook"
        Me.tsmiSpeciesBook.Size = New System.Drawing.Size(164, 22)
        Me.tsmiSpeciesBook.Text = "Libro de especies"
        '
        'tsmiSpeciesBookBrowse
        '
        Me.tsmiSpeciesBookBrowse.Name = "tsmiSpeciesBookBrowse"
        Me.tsmiSpeciesBookBrowse.Size = New System.Drawing.Size(152, 22)
        Me.tsmiSpeciesBookBrowse.Text = "Buscar"
        '
        'tsmiSpeciesBookAdd
        '
        Me.tsmiSpeciesBookAdd.Name = "tsmiSpeciesBookAdd"
        Me.tsmiSpeciesBookAdd.Size = New System.Drawing.Size(152, 22)
        Me.tsmiSpeciesBookAdd.Text = "Agregar"
        '
        'tsmiPlant
        '
        Me.tsmiPlant.Name = "tsmiPlant"
        Me.tsmiPlant.Size = New System.Drawing.Size(164, 22)
        Me.tsmiPlant.Text = "Plantar"
        '
        'tsmiTracking
        '
        Me.tsmiTracking.Name = "tsmiTracking"
        Me.tsmiTracking.Size = New System.Drawing.Size(164, 22)
        Me.tsmiTracking.Text = "Seguimiento"
        '
        'tsmiZones
        '
        Me.tsmiZones.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiZoneHothouse, Me.tsmiZoneOutdoors, Me.tsmiZoneShadow})
        Me.tsmiZones.Name = "tsmiZones"
        Me.tsmiZones.Size = New System.Drawing.Size(64, 20)
        Me.tsmiZones.Text = "Espacios"
        '
        'tsmiZoneHothouse
        '
        Me.tsmiZoneHothouse.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiZoneHothouseList, Me.tsmiZoneHothouseAdd})
        Me.tsmiZoneHothouse.Name = "tsmiZoneHothouse"
        Me.tsmiZoneHothouse.Size = New System.Drawing.Size(166, 22)
        Me.tsmiZoneHothouse.Text = "Invernáculos"
        '
        'tsmiZoneHothouseList
        '
        Me.tsmiZoneHothouseList.Name = "tsmiZoneHothouseList"
        Me.tsmiZoneHothouseList.Size = New System.Drawing.Size(152, 22)
        Me.tsmiZoneHothouseList.Text = "Listar"
        '
        'tsmiZoneHothouseAdd
        '
        Me.tsmiZoneHothouseAdd.Name = "tsmiZoneHothouseAdd"
        Me.tsmiZoneHothouseAdd.Size = New System.Drawing.Size(152, 22)
        Me.tsmiZoneHothouseAdd.Text = "Agregar"
        '
        'tsmiZoneOutdoors
        '
        Me.tsmiZoneOutdoors.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiZoneOutdoorsList, Me.tsmiZoneOutdoorsAdd})
        Me.tsmiZoneOutdoors.Name = "tsmiZoneOutdoors"
        Me.tsmiZoneOutdoors.Size = New System.Drawing.Size(166, 22)
        Me.tsmiZoneOutdoors.Text = "Zonas al aire libre"
        '
        'tsmiZoneOutdoorsList
        '
        Me.tsmiZoneOutdoorsList.Name = "tsmiZoneOutdoorsList"
        Me.tsmiZoneOutdoorsList.Size = New System.Drawing.Size(152, 22)
        Me.tsmiZoneOutdoorsList.Text = "Listar"
        '
        'tsmiZoneOutdoorsAdd
        '
        Me.tsmiZoneOutdoorsAdd.Name = "tsmiZoneOutdoorsAdd"
        Me.tsmiZoneOutdoorsAdd.Size = New System.Drawing.Size(152, 22)
        Me.tsmiZoneOutdoorsAdd.Text = "Agregar"
        '
        'tsmiZoneShadow
        '
        Me.tsmiZoneShadow.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiZoneShadowList, Me.tsmiZoneShadowAdd})
        Me.tsmiZoneShadow.Name = "tsmiZoneShadow"
        Me.tsmiZoneShadow.Size = New System.Drawing.Size(166, 22)
        Me.tsmiZoneShadow.Text = "Zonas de malla"
        '
        'tsmiZoneShadowList
        '
        Me.tsmiZoneShadowList.Name = "tsmiZoneShadowList"
        Me.tsmiZoneShadowList.Size = New System.Drawing.Size(152, 22)
        Me.tsmiZoneShadowList.Text = "Listar"
        '
        'tsmiZoneShadowAdd
        '
        Me.tsmiZoneShadowAdd.Name = "tsmiZoneShadowAdd"
        Me.tsmiZoneShadowAdd.Size = New System.Drawing.Size(152, 22)
        Me.tsmiZoneShadowAdd.Text = "Agregar"
        '
        'tsmiStock
        '
        Me.tsmiStock.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiStockTools, Me.tsmiStockMaterials, Me.tsmiStockSeeds})
        Me.tsmiStock.Name = "tsmiStock"
        Me.tsmiStock.Size = New System.Drawing.Size(48, 20)
        Me.tsmiStock.Text = "Stock"
        '
        'tsmiStockTools
        '
        Me.tsmiStockTools.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiStockToolsList, Me.tsmiStockToolsAdd})
        Me.tsmiStockTools.Name = "tsmiStockTools"
        Me.tsmiStockTools.Size = New System.Drawing.Size(152, 22)
        Me.tsmiStockTools.Text = "Herramientas"
        '
        'tsmiStockToolsList
        '
        Me.tsmiStockToolsList.Name = "tsmiStockToolsList"
        Me.tsmiStockToolsList.Size = New System.Drawing.Size(152, 22)
        Me.tsmiStockToolsList.Text = "Listar"
        '
        'tsmiStockToolsAdd
        '
        Me.tsmiStockToolsAdd.Name = "tsmiStockToolsAdd"
        Me.tsmiStockToolsAdd.Size = New System.Drawing.Size(152, 22)
        Me.tsmiStockToolsAdd.Text = "Agregar"
        '
        'tsmiStockMaterials
        '
        Me.tsmiStockMaterials.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiStockMaterialsList, Me.tsmiStockMaterialsAdd})
        Me.tsmiStockMaterials.Name = "tsmiStockMaterials"
        Me.tsmiStockMaterials.Size = New System.Drawing.Size(152, 22)
        Me.tsmiStockMaterials.Text = "Insumos"
        '
        'tsmiStockMaterialsList
        '
        Me.tsmiStockMaterialsList.Name = "tsmiStockMaterialsList"
        Me.tsmiStockMaterialsList.Size = New System.Drawing.Size(152, 22)
        Me.tsmiStockMaterialsList.Text = "Listar"
        '
        'tsmiStockMaterialsAdd
        '
        Me.tsmiStockMaterialsAdd.Name = "tsmiStockMaterialsAdd"
        Me.tsmiStockMaterialsAdd.Size = New System.Drawing.Size(152, 22)
        Me.tsmiStockMaterialsAdd.Text = "Agregar"
        '
        'tsmiStockSeeds
        '
        Me.tsmiStockSeeds.Name = "tsmiStockSeeds"
        Me.tsmiStockSeeds.Size = New System.Drawing.Size(152, 22)
        Me.tsmiStockSeeds.Text = "Semillas"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KAPPALEEELMANUALPIBEToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'KAPPALEEELMANUALPIBEToolStripMenuItem
        '
        Me.KAPPALEEELMANUALPIBEToolStripMenuItem.Name = "KAPPALEEELMANUALPIBEToolStripMenuItem"
        Me.KAPPALEEELMANUALPIBEToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.KAPPALEEELMANUALPIBEToolStripMenuItem.Text = "KAPPA LEE EL MANUAL PIBE"
        '
        'msMain
        '
        Me.msMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiSession, Me.tsmiPlants, Me.tsmiZones, Me.tsmiStock, Me.AyudaToolStripMenuItem, Me.tsmiPersons})
        Me.msMain.Location = New System.Drawing.Point(0, 0)
        Me.msMain.Name = "msMain"
        Me.msMain.Size = New System.Drawing.Size(722, 24)
        Me.msMain.TabIndex = 1
        Me.msMain.Text = "msMain"
        '
        'tsmiPersons
        '
        Me.tsmiPersons.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiRegister})
        Me.tsmiPersons.Name = "tsmiPersons"
        Me.tsmiPersons.Size = New System.Drawing.Size(66, 20)
        Me.tsmiPersons.Text = "Personas"
        '
        'tsmiRegister
        '
        Me.tsmiRegister.Name = "tsmiRegister"
        Me.tsmiRegister.Size = New System.Drawing.Size(152, 22)
        Me.tsmiRegister.Text = "Regisrar"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(722, 261)
        Me.Controls.Add(Me.msMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
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
    Friend WithEvents tsmiTracking As ToolStripMenuItem
    Friend WithEvents tsmiZones As ToolStripMenuItem
    Friend WithEvents tsmiZoneHothouse As ToolStripMenuItem
    Friend WithEvents tsmiZoneHothouseList As ToolStripMenuItem
    Friend WithEvents tsmiZoneHothouseAdd As ToolStripMenuItem
    Friend WithEvents tsmiZoneOutdoors As ToolStripMenuItem
    Friend WithEvents tsmiZoneOutdoorsList As ToolStripMenuItem
    Friend WithEvents tsmiZoneOutdoorsAdd As ToolStripMenuItem
    Friend WithEvents tsmiZoneShadow As ToolStripMenuItem
    Friend WithEvents tsmiZoneShadowList As ToolStripMenuItem
    Friend WithEvents tsmiZoneShadowAdd As ToolStripMenuItem
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
End Class
