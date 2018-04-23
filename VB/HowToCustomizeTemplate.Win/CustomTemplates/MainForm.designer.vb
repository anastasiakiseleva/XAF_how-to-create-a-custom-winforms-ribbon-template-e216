Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.ExpressApp.Win.Templates

Partial Public Class MainForm
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (Not components Is Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.mainBarManager = New DevExpress.XtraBars.BarManager(Me.components)
        Me.MainMenuBar = New DevExpress.XtraBars.Bar()
        Me.barSubItemFile = New DevExpress.ExpressApp.Win.Templates.MainMenuItem()
        Me.cObjectsCreation = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem()
        Me.cViewsHistoryNavigation = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem()
        Me.cFile = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem()
        Me.cPrint = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem()
        Me.cExport = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem()
        Me.cExit = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem()
        Me.barSubItemEdit = New DevExpress.ExpressApp.Win.Templates.MainMenuItem()
        Me.cRecordEdit = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem()
        Me.barSubItemView = New DevExpress.ExpressApp.Win.Templates.MainMenuItem()
        Me.barCheckItemNavigationPaneVisibility = New DevExpress.XtraBars.BarCheckItem()
        Me.cRecordsNavigation = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem()
        Me.cView = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem()
        Me.barSubItemTools = New DevExpress.ExpressApp.Win.Templates.MainMenuItem()
        Me.cTools = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerMenuBarItem()
        Me.cDiagnostic = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerMenuBarItem()
        Me.cOptions = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerMenuBarItem()
        Me.barSubItemHelp = New DevExpress.ExpressApp.Win.Templates.MainMenuItem()
        Me.cAbout = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerMenuBarItem()
        Me.cViewsNavigation = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerMenuBarItem()
        Me.StandardToolBar = New DevExpress.XtraBars.Bar()
        Me.cFiltersSearch = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem()
        Me.cFilters = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem()
        Me.StatusBar = New DevExpress.XtraBars.Bar()
        Me.barAndDockingController1 = New DevExpress.XtraBars.BarAndDockingController(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.dockManager1 = New DevExpress.XtraBars.Docking.DockManager()
        Me.dockPanelNavigation = New DevExpress.XtraBars.Docking.DockPanel()
        Me.dockPanelNavigation_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.navigation = New DevExpress.ExpressApp.Win.Templates.ActionContainers.NavBarActionContainer()
        Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.viewSitePanel = New DevExpress.XtraEditors.PanelControl()
        CType(Me.mainBarManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barAndDockingController1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dockPanelNavigation.SuspendLayout()
        Me.dockPanelNavigation_Container.SuspendLayout()
        CType(Me.navigation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.viewSitePanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' barManager
        ' 
        Me.mainBarManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.MainMenuBar, Me.StandardToolBar, Me.StatusBar})
        Me.mainBarManager.Controller = Me.barAndDockingController1
        Me.mainBarManager.DockControls.Add(Me.barDockControlTop)
        Me.mainBarManager.DockControls.Add(Me.barDockControlBottom)
        Me.mainBarManager.DockControls.Add(Me.barDockControlLeft)
        Me.mainBarManager.DockControls.Add(Me.barDockControlRight)
        Me.mainBarManager.DockManager = Me.dockManager1
        Me.mainBarManager.Form = Me
        Me.mainBarManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barSubItemFile, Me.barSubItemEdit, Me.barSubItemView, Me.barSubItemTools, Me.barSubItemHelp, Me.cFile, Me.cObjectsCreation, Me.cPrint, Me.cExport, Me.cExit, Me.cRecordEdit, Me.cRecordsNavigation, Me.cViewsHistoryNavigation, Me.cFiltersSearch, Me.cFilters, Me.cView, Me.cTools, Me.cDiagnostic, Me.cOptions, Me.cAbout, Me.barButtonItem1, Me.barCheckItemNavigationPaneVisibility, Me.cViewsNavigation})
        Me.mainBarManager.MainMenu = Me.MainMenuBar
        Me.mainBarManager.MaxItemId = 34
        Me.mainBarManager.StatusBar = Me.StatusBar
        ' 
        ' MainMenuBar
        ' 
        Me.MainMenuBar.BarName = "Main Menu"
        Me.MainMenuBar.DockCol = 0
        Me.MainMenuBar.DockRow = 0
        Me.MainMenuBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.MainMenuBar.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barSubItemFile), New DevExpress.XtraBars.LinkPersistInfo(Me.barSubItemEdit), New DevExpress.XtraBars.LinkPersistInfo(Me.barSubItemView), New DevExpress.XtraBars.LinkPersistInfo(Me.barSubItemTools), New DevExpress.XtraBars.LinkPersistInfo(Me.barSubItemHelp), New DevExpress.XtraBars.LinkPersistInfo(Me.cViewsNavigation)})
        Me.MainMenuBar.OptionsBar.MultiLine = True
        Me.MainMenuBar.OptionsBar.UseWholeRow = True
        Me.MainMenuBar.Text = "Main Menu"
        ' 
        ' barSubItemFile
        ' 
        Me.barSubItemFile.Caption = "File"
        Me.barSubItemFile.Id = 0
        Me.barSubItemFile.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.cObjectsCreation, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cViewsHistoryNavigation, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cFile, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cPrint, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cExport, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cExit, True)})
        Me.barSubItemFile.Name = "barSubItemFile"
        ' 
        ' cObjectsCreation
        ' 
        Me.cObjectsCreation.Caption = "Objects creation"
        Me.cObjectsCreation.ContainerId = "ObjectsCreation"
        Me.cObjectsCreation.Id = 18
        Me.cObjectsCreation.Name = "cObjectsCreation"
        ' 
        ' cViewsHistoryNavigation
        ' 
        Me.cViewsHistoryNavigation.Caption = "Views History Navigation"
        Me.cViewsHistoryNavigation.ContainerId = "ViewsHistoryNavigation"
        Me.cViewsHistoryNavigation.Id = 35
        Me.cViewsHistoryNavigation.Name = "cViewsHistoryNavigation"
        ' 
        ' cFile
        ' 
        Me.cFile.Caption = "File"
        Me.cFile.ContainerId = "File"
        Me.cFile.Id = 5
        Me.cFile.Name = "cFile"
        ' 
        ' cPrint
        ' 
        Me.cPrint.Caption = "Print"
        Me.cPrint.ContainerId = "Print"
        Me.cPrint.Id = 6
        Me.cPrint.Name = "cPrint"
        ' 
        ' cExport
        ' 
        Me.cExport.Caption = "Export"
        Me.cExport.ContainerId = "Export"
        Me.cExport.Id = 7
        Me.cExport.Name = "cExport"
        ' 
        ' cExit
        ' 
        Me.cExit.Caption = "Exit"
        Me.cExit.ContainerId = "Exit"
        Me.cExit.Id = 8
        Me.cExit.Name = "cExit"
        ' 
        ' barSubItemEdit
        ' 
        Me.barSubItemEdit.Caption = "Edit"
        Me.barSubItemEdit.Id = 1
        Me.barSubItemEdit.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.cRecordEdit, True)})
        Me.barSubItemEdit.Name = "barSubItemEdit"
        ' 
        ' cRecordEdit
        ' 
        Me.cRecordEdit.Caption = "Record Edit"
        Me.cRecordEdit.ContainerId = "RecordEdit"
        Me.cRecordEdit.Id = 9
        Me.cRecordEdit.Name = "cRecordEdit"
        ' 
        ' barSubItemView
        ' 
        Me.barSubItemView.Caption = "View"
        Me.barSubItemView.Id = 2
        Me.barSubItemView.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barCheckItemNavigationPaneVisibility, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cRecordsNavigation, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cView, True)})
        Me.barSubItemView.Name = "barSubItemView"
        ' 
        ' barCheckItemNavigationPaneVisibility
        ' 
        Me.barCheckItemNavigationPaneVisibility.Caption = "&Navigation Bar"
        Me.barCheckItemNavigationPaneVisibility.Id = 33
        Me.barCheckItemNavigationPaneVisibility.Name = "barCheckItemNavigationPaneVisibility"
        '			Me.barCheckItemNavigationPaneVisibility.CheckedChanged += New DevExpress.XtraBars.ItemClickEventHandler(Me.barCheckItemNavigationPaneVisibility_CheckedChanged);
        ' 
        ' cRecordsNavigation
        ' 
        Me.cRecordsNavigation.Caption = "Records Navigation"
        Me.cRecordsNavigation.ContainerId = "RecordsNavigation"
        Me.cRecordsNavigation.Id = 10
        Me.cRecordsNavigation.Name = "cRecordsNavigation"
        ' 
        ' cView
        ' 
        Me.cView.Caption = "View"
        Me.cView.ContainerId = "View"
        Me.cView.Id = 12
        Me.cView.Name = "cView"
        ' 
        ' barSubItemTools
        ' 
        Me.barSubItemTools.Caption = "Tools"
        Me.barSubItemTools.Id = 3
        Me.barSubItemTools.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.cTools, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cDiagnostic, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cOptions, True)})
        Me.barSubItemTools.Name = "barSubItemTools"
        ' 
        ' cTools
        ' 
        Me.cTools.Caption = "Tools"
        Me.cTools.ContainerId = "Tools"
        Me.cTools.Id = 13
        Me.cTools.Name = "cTools"
        ' 
        ' cDiagnostic
        ' 
        Me.cDiagnostic.Caption = "Diagnostic"
        Me.cDiagnostic.ContainerId = "Diagnostic"
        Me.cDiagnostic.Id = 16
        Me.cDiagnostic.Name = "cDiagnostic"
        ' 
        ' cOptions
        ' 
        Me.cOptions.Caption = "Options"
        Me.cOptions.ContainerId = "Options"
        Me.cOptions.Id = 14
        Me.cOptions.Name = "cOptions"
        ' 
        ' barSubItemHelp
        ' 
        Me.barSubItemHelp.Caption = "Help"
        Me.barSubItemHelp.Id = 4
        Me.barSubItemHelp.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.cAbout, True)})
        Me.barSubItemHelp.Name = "barSubItemHelp"
        ' 
        ' cAbout
        ' 
        Me.cAbout.Caption = "About"
        Me.cAbout.ContainerId = "About"
        Me.cAbout.Id = 15
        Me.cAbout.Name = "cAbout"
        ' 
        ' cViewsNavigation
        '
        Me.cViewsNavigation.Caption = "Navigation"
        Me.cViewsNavigation.ContainerId = "ViewsNavigation"
        Me.cViewsNavigation.Id = 14
        Me.cViewsNavigation.Name = "cViewsNavigation"
        Me.cViewsNavigation.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        ' 
        ' StandardToolBar
        ' 
        Me.StandardToolBar.BarName = "Main Toolbar"
        Me.StandardToolBar.DockCol = 0
        Me.StandardToolBar.DockRow = 1
        Me.StandardToolBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.StandardToolBar.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.cViewsHistoryNavigation, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cObjectsCreation, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cView, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cRecordEdit, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cFiltersSearch, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cFilters, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cRecordsNavigation, True)})
        Me.StandardToolBar.Text = "Main Toolbar"
        ' 
        ' cFiltersSearch
        ' 
        Me.cFiltersSearch.Caption = "Search"
        Me.cFiltersSearch.ContainerId = "Search"
        Me.cFiltersSearch.Id = 11
        Me.cFiltersSearch.Name = "cFiltersSearch"
        ' 
        ' cFilters
        ' 
        Me.cFilters.Caption = "Filters"
        Me.cFilters.ContainerId = "Filters"
        Me.cFilters.Id = 26
        Me.cFilters.Name = "cFilters"
        ' 
        ' StatusBar
        ' 
        Me.StatusBar.BarName = "StatusBar"
        Me.StatusBar.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.StatusBar.DockCol = 0
        Me.StatusBar.DockRow = 0
        Me.StatusBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.StatusBar.OptionsBar.AllowQuickCustomization = False
        Me.StatusBar.OptionsBar.DisableClose = True
        Me.StatusBar.OptionsBar.DisableCustomization = True
        Me.StatusBar.OptionsBar.DrawDragBorder = False
        Me.StatusBar.OptionsBar.DrawSizeGrip = True
        Me.StatusBar.OptionsBar.UseWholeRow = True
        Me.StatusBar.Text = "Status Bar"
        ' 
        ' barAndDockingController1
        ' 
        Me.barAndDockingController1.PropertiesBar.AllowLinkLighting = False
        ' 
        ' dockManager1
        ' 
        Me.dockManager1.Controller = Me.barAndDockingController1
        Me.dockManager1.Form = Me
        Me.dockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.dockPanelNavigation})
        Me.dockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "System.Windows.Forms.StatusBar"})
        ' 
        ' dockPanelNavigation
        ' 
        Me.dockPanelNavigation.Controls.Add(Me.dockPanelNavigation_Container)
        Me.dockPanelNavigation.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
        Me.dockPanelNavigation.FloatSize = New System.Drawing.Size(146, 428)
        Me.dockPanelNavigation.ID = New System.Guid("24977e30-0ea6-44aa-8fa4-9abaeb178b5e")
        Me.dockPanelNavigation.Location = New System.Drawing.Point(0, 49)
        Me.dockPanelNavigation.Name = "dockPanelNavigation"
        Me.dockPanelNavigation.Options.AllowDockBottom = False
        Me.dockPanelNavigation.Options.AllowDockTop = False
        Me.dockPanelNavigation.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Left
        Me.dockPanelNavigation.SavedIndex = 2
        Me.dockPanelNavigation.Size = New System.Drawing.Size(146, 495)
        Me.dockPanelNavigation.TabStop = False
        Me.dockPanelNavigation.Text = "Navigation"
        '			Me.dockPanelNavigation.ClosingPanel += New DevExpress.XtraBars.Docking.DockPanelCancelEventHandler(dockPanelNavigation_ClosingPanel);
        ' 
        ' dockPanelNavigation_Container
        ' 
        Me.dockPanelNavigation_Container.Controls.Add(Me.navigation)
        Me.dockPanelNavigation_Container.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dockPanelNavigation_Container.Location = New System.Drawing.Point(3, 25)
        Me.dockPanelNavigation_Container.Name = "dockPanelNavigation_Container"
        Me.dockPanelNavigation_Container.Size = New System.Drawing.Size(140, 467)
        Me.dockPanelNavigation_Container.TabIndex = 0
        ' 
        ' Modules
        ' 
        Me.navigation.ActiveGroup = Nothing
        Me.navigation.AllowSelectedLink = True
        Me.navigation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.navigation.DragDropFlags = DevExpress.XtraNavBar.NavBarDragDrop.None
        Me.navigation.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane
        Me.navigation.StoreDefaultPaintStyleName = True
        Me.navigation.Name = "Navigation"
        Me.navigation.Location = New System.Drawing.Point(0, 0)
        Me.navigation.Size = New System.Drawing.Size(140, 467)
        Me.navigation.TabIndex = 0

        ' 
        ' barButtonItem1
        ' 
        Me.barButtonItem1.Caption = "barButtonItem1"
        Me.barButtonItem1.Id = 32
        Me.barButtonItem1.Name = "barButtonItem1"
        ' 
        ' viewSitePanel
        ' 
        Me.viewSitePanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.viewSitePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.viewSitePanel.Location = New System.Drawing.Point(0, 49)
        Me.viewSitePanel.Name = "viewSitePanel"
        Me.viewSitePanel.Size = New System.Drawing.Size(792, 495)
        Me.viewSitePanel.TabIndex = 4
        ' 
        ' NewMainForm
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.dockPanelNavigation)
        Me.Controls.Add(Me.viewSitePanel)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "NewMainForm"
        Me.Text = "MainForm"
        CType(Me.mainBarManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barAndDockingController1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dockPanelNavigation.ResumeLayout(False)
        Me.dockPanelNavigation_Container.ResumeLayout(False)
        CType(Me.navigation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.viewSitePanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private mainBarManager As DevExpress.XtraBars.BarManager
    Private barDockControlTop As DevExpress.XtraBars.BarDockControl
    Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Private barDockControlRight As DevExpress.XtraBars.BarDockControl
    Private MainMenuBar As DevExpress.XtraBars.Bar
    Private StandardToolBar As DevExpress.XtraBars.Bar
    Private StatusBar As DevExpress.XtraBars.Bar
    Private barAndDockingController1 As DevExpress.XtraBars.BarAndDockingController
    Private dockManager1 As DevExpress.XtraBars.Docking.DockManager
    Private cFile As DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
    Private cObjectsCreation As DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
    Private cPrint As DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
    Private cExport As DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
    Private cExit As DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
    Private barSubItemFile As DevExpress.ExpressApp.Win.Templates.MainMenuItem
    Private barSubItemEdit As DevExpress.ExpressApp.Win.Templates.MainMenuItem
    Private barSubItemView As DevExpress.ExpressApp.Win.Templates.MainMenuItem
    Private barSubItemTools As DevExpress.ExpressApp.Win.Templates.MainMenuItem
    Private barSubItemHelp As DevExpress.ExpressApp.Win.Templates.MainMenuItem
    Private cViewsNavigation As DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerMenuBarItem
    Private cRecordEdit As DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
    Private cRecordsNavigation As DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
    Private cViewsHistoryNavigation As DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
    Private cFiltersSearch As DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
    Private cFilters As DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
    Private cView As DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
    Private cTools As DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerMenuBarItem
    Private cDiagnostic As DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerMenuBarItem
    Private cOptions As DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerMenuBarItem
    Private cAbout As DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerMenuBarItem
    Private navigation As DevExpress.ExpressApp.Win.Templates.ActionContainers.NavBarActionContainer
    Private WithEvents dockPanelNavigation As DevExpress.XtraBars.Docking.DockPanel
    Private dockPanelNavigation_Container As DevExpress.XtraBars.Docking.ControlContainer
    Private viewSitePanel As DevExpress.XtraEditors.PanelControl
    Private WithEvents barCheckItemNavigationPaneVisibility As DevExpress.XtraBars.BarCheckItem
    Private barButtonItem1 As DevExpress.XtraBars.BarButtonItem

#End Region

End Class
