Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.ExpressApp.Win.CustomTemplates
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
            If disposing AndAlso (components IsNot Nothing) Then
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
            Me._mainMenuBar = New DevExpress.XtraBars.Bar()
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
            Me.barCheckItemNavigationPanelVisibility = New DevExpress.XtraBars.BarCheckItem()
            Me.cRecordsNavigation = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem()
            Me.cView = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem()
            Me.cDefault = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem()
            Me.barSubItemTools = New DevExpress.ExpressApp.Win.Templates.MainMenuItem()
            Me.cTools = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerMenuBarItem()
            Me.cViewsNavigation = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerMenuBarItem()
            Me.cDiagnostic = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerMenuBarItem()
            Me.cOptions = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerMenuBarItem()
            Me.barSubItemHelp = New DevExpress.ExpressApp.Win.Templates.MainMenuItem()
            Me.cAbout = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerMenuBarItem()
            Me.standardToolBar = New DevExpress.XtraBars.Bar()
            Me.cFiltersSearch = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem()
            Me.cFilters = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem()
            Me.cMenu = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem()
            Me._statusBar = New DevExpress.XtraBars.Bar()
            Me.mainBarAndDockingController = New DevExpress.XtraBars.BarAndDockingController(Me.components)
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.mainDockManager = New DevExpress.XtraBars.Docking.DockManager()
            Me.dockPanelNavigation = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanelNavigation_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.navigation = New DevExpress.ExpressApp.Win.Templates.ActionContainers.NavigationActionContainer()
            Me.viewSitePanel = New DevExpress.XtraEditors.PanelControl()
            CType(Me.mainBarManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.mainBarAndDockingController, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.mainDockManager, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockPanelNavigation.SuspendLayout()
            Me.dockPanelNavigation_Container.SuspendLayout()
            CType(Me.viewSitePanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' barManager
            ' 
            Me.mainBarManager.Bars.AddRange(New DevExpress.XtraBars.Bar() { Me._mainMenuBar, Me.standardToolBar, Me._statusBar})
            Me.mainBarManager.Controller = Me.mainBarAndDockingController
            Me.mainBarManager.DockControls.Add(Me.barDockControlTop)
            Me.mainBarManager.DockControls.Add(Me.barDockControlBottom)
            Me.mainBarManager.DockControls.Add(Me.barDockControlLeft)
            Me.mainBarManager.DockControls.Add(Me.barDockControlRight)
            Me.mainBarManager.DockManager = Me.mainDockManager
            Me.mainBarManager.Form = Me
            Me.mainBarManager.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.barSubItemFile, Me.barSubItemEdit, Me.barSubItemView, Me.barSubItemTools, Me.barSubItemHelp, Me.cFile, Me.cObjectsCreation, Me.cPrint, Me.cExport, Me.cExit, Me.cRecordEdit, Me.cRecordsNavigation, Me.cViewsHistoryNavigation, Me.cFiltersSearch, Me.cFilters, Me.cView, Me.cDefault, Me.cTools, Me.cViewsNavigation, Me.cDiagnostic, Me.cOptions, Me.cAbout, Me.cMenu, Me.barCheckItemNavigationPanelVisibility})
            Me.mainBarManager.MainMenu = Me._mainMenuBar
            Me.mainBarManager.MaxItemId = 34
            Me.mainBarManager.StatusBar = Me._statusBar
            ' 
            ' _mainMenuBar
            ' 
            Me._mainMenuBar.BarName = "Main Menu"
            Me._mainMenuBar.DockCol = 0
            Me._mainMenuBar.DockRow = 0
            Me._mainMenuBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me._mainMenuBar.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.barSubItemFile), New DevExpress.XtraBars.LinkPersistInfo(Me.barSubItemEdit), New DevExpress.XtraBars.LinkPersistInfo(Me.barSubItemView), New DevExpress.XtraBars.LinkPersistInfo(Me.barSubItemTools), New DevExpress.XtraBars.LinkPersistInfo(Me.barSubItemHelp) })
            Me._mainMenuBar.OptionsBar.MultiLine = True
            Me._mainMenuBar.OptionsBar.UseWholeRow = True
            Me._mainMenuBar.Text = "Main Menu"
            ' 
            ' barSubItemFile
            ' 
            Me.barSubItemFile.Caption = "File"
            Me.barSubItemFile.Id = 0
            Me.barSubItemFile.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.cObjectsCreation, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cViewsHistoryNavigation, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cFile, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cPrint, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cExport, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cExit, True)})
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
            Me.barSubItemEdit.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.cRecordEdit, True)})
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
            Me.barSubItemView.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.barCheckItemNavigationPanelVisibility, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cViewsNavigation), New DevExpress.XtraBars.LinkPersistInfo(Me.cRecordsNavigation, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cView, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cDefault, True) })
            Me.barSubItemView.Name = "barSubItemView"
            ' 
            ' barCheckItemNavigationPaneVisibility
            ' 
            Me.barCheckItemNavigationPanelVisibility.Caption = "&Navigation Bar"
            Me.barCheckItemNavigationPanelVisibility.Id = 33
            Me.barCheckItemNavigationPanelVisibility.Name = "barCheckItemNavigationPaneVisibility"
'            Me.barCheckItemNavigationPanelVisibility.CheckedChanged += New DevExpress.XtraBars.ItemClickEventHandler(Me.barCheckItemNavigationPaneVisibility_CheckedChanged);
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
            ' cDefault
            ' 
            Me.cDefault.Caption = "Default"
            Me.cDefault.ContainerId = "Default"
            Me.cDefault.Id = 50
            Me.cDefault.Name = "cDefault"
            ' 
            ' barSubItemTools
            ' 
            Me.barSubItemTools.Caption = "Tools"
            Me.barSubItemTools.Id = 3
            Me.barSubItemTools.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.cTools, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cDiagnostic, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cOptions, True)})
            Me.barSubItemTools.Name = "barSubItemTools"
            ' 
            ' cTools
            ' 
            Me.cTools.Caption = "Tools"
            Me.cTools.ContainerId = "Tools"
            Me.cTools.Id = 13
            Me.cTools.Name = "cTools"
            ' 
            ' cViewsNavigation
            ' 
            Me.cViewsNavigation.Caption = "Navigation"
            Me.cViewsNavigation.ContainerId = "ViewsNavigation"
            Me.cViewsNavigation.Id = 14
            Me.cViewsNavigation.Name = "cViewsNavigation"
            Me.cViewsNavigation.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
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
            Me.barSubItemHelp.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.cAbout, True)})
            Me.barSubItemHelp.Name = "barSubItemHelp"
            ' 
            ' cAbout
            ' 
            Me.cAbout.Caption = "About"
            Me.cAbout.ContainerId = "About"
            Me.cAbout.Id = 15
            Me.cAbout.Name = "cAbout"
            ' 
            ' StandardToolBar
            ' 
            Me.standardToolBar.BarName = "Main Toolbar"
            Me.standardToolBar.DockCol = 0
            Me.standardToolBar.DockRow = 1
            Me.standardToolBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.standardToolBar.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.cViewsHistoryNavigation, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cObjectsCreation, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cView, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cDefault, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cRecordEdit, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cFiltersSearch, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cFilters, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cRecordsNavigation, True)})
            Me.standardToolBar.Text = "Main Toolbar"
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
            ' cMenu
            ' 
            Me.cMenu.Caption = "Menu"
            Me.cMenu.Id = 7
            Me.cMenu.ContainerId = "Menu"
            Me.cMenu.Name = "cMenu"
            ' 
            ' StatusBar
            ' 
            Me._statusBar.BarName = "StatusBar"
            Me._statusBar.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
            Me._statusBar.DockCol = 0
            Me._statusBar.DockRow = 0
            Me._statusBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
            Me._statusBar.OptionsBar.AllowQuickCustomization = False
            Me._statusBar.OptionsBar.DisableClose = True
            Me._statusBar.OptionsBar.DisableCustomization = True
            Me._statusBar.OptionsBar.DrawDragBorder = False
            Me._statusBar.OptionsBar.DrawSizeGrip = True
            Me._statusBar.OptionsBar.UseWholeRow = True
            Me._statusBar.Text = "Status Bar"
            ' 
            ' barAndDockingController1
            ' 
            Me.mainBarAndDockingController.PropertiesBar.AllowLinkLighting = False
            ' 
            ' dockManager1
            ' 
            Me.mainDockManager.Controller = Me.mainBarAndDockingController
            Me.mainDockManager.Form = Me
            Me.mainDockManager.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() { Me.dockPanelNavigation})
            Me.mainDockManager.TopZIndexControls.AddRange(New String() { "DevExpress.XtraBars.BarDockControl", "System.Windows.Forms.StatusBar"})
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
'            Me.dockPanelNavigation.ClosingPanel += New DevExpress.XtraBars.Docking.DockPanelCancelEventHandler(dockPanelNavigation_ClosingPanel);
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
            Me.navigation.Dock = System.Windows.Forms.DockStyle.Fill
            Me.navigation.Name = "Navigation"
            Me.navigation.Location = New System.Drawing.Point(0, 0)
            Me.navigation.Size = New System.Drawing.Size(140, 467)
            Me.navigation.TabIndex = 0
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
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
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
            CType(Me.mainBarAndDockingController, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.mainDockManager, System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockPanelNavigation.ResumeLayout(False)
            Me.dockPanelNavigation_Container.ResumeLayout(False)
            CType(Me.viewSitePanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Private barDockControlTop As DevExpress.XtraBars.BarDockControl
        Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Private barDockControlRight As DevExpress.XtraBars.BarDockControl
        Private _mainMenuBar As DevExpress.XtraBars.Bar
        Private standardToolBar As DevExpress.XtraBars.Bar
        Private _statusBar As DevExpress.XtraBars.Bar
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
        Private cDefault As DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
        Private cTools As DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerMenuBarItem
        Private cDiagnostic As DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerMenuBarItem
        Private cOptions As DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerMenuBarItem
        Private cAbout As DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerMenuBarItem
        Private cMenu As DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
        #End Region
        Protected mainBarAndDockingController As DevExpress.XtraBars.BarAndDockingController
        Protected mainDockManager As DevExpress.XtraBars.Docking.DockManager
        Protected mainBarManager As DevExpress.XtraBars.BarManager
        Protected navigation As DevExpress.ExpressApp.Win.Templates.ActionContainers.NavigationActionContainer
        Protected WithEvents dockPanelNavigation As DevExpress.XtraBars.Docking.DockPanel
        Protected dockPanelNavigation_Container As DevExpress.XtraBars.Docking.ControlContainer
        Protected viewSitePanel As DevExpress.XtraEditors.PanelControl
        Protected WithEvents barCheckItemNavigationPanelVisibility As DevExpress.XtraBars.BarCheckItem

    End Class
End Namespace