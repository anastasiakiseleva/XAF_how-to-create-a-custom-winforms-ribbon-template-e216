Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Templates
Imports DevExpress.XtraBars.Docking
Imports DevExpress.ExpressApp.Utils
Imports DevExpress.XtraBars

Imports DevExpress.ExpressApp.Win.Templates

Namespace DevExpress.ExpressApp.Win.CustomTemplates
    Partial Public Class MainForm
        Inherits DevExpress.ExpressApp.Win.Templates.XtraFormTemplateBase
        Private Const NavigationVisibilityAttributeName As String = "NavigationVisibility"
        Private Const NavigationWidthAttributeName As String = "NavigationWidth"
        Private Const NavigationDockAttributeName As String = "NavigationDock"
        Private Const FrameTemplatesMainFormLocalizationPath As String = "FrameTemplates\MainForm"
        Protected Overrides Sub SetFormIcon(ByVal view As DevExpress.ExpressApp.View)
        End Sub
        Private navigationPaneVisibility As DockVisibility = DockVisibility.Visible
        Private Sub dockPanelNavigation_ClosingPanel(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Docking.DockPanelCancelEventArgs) Handles dockPanelNavigation.ClosingPanel
            barCheckItemNavigationPanelVisibility.Down = False
        End Sub
        Private Sub barCheckItemNavigationPaneVisibility_CheckedChanged(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barCheckItemNavigationPanelVisibility.CheckedChanged
            If barCheckItemNavigationPanelVisibility.Down Then
                dockPanelNavigation.Visibility = navigationPaneVisibility
            Else
                navigationPaneVisibility = dockPanelNavigation.Visibility
                dockPanelNavigation.Visibility = DockVisibility.Hidden
            End If
        End Sub
        Protected Overrides Function GetFormStateNode() As DictionaryNode
            Return TemplateInfo.GetChildNode("FormState", "ID", "Default")
        End Function
        Protected Overrides Sub InitializeCaptions()
            MainMenuBar.Text = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "MainMenu", MainMenuBar.Text)
            barSubItemFile.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "FileSubMenu", barSubItemFile.Caption)
            cObjectsCreation.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "ObjectsCreation", cObjectsCreation.Caption)
            cViewsHistoryNavigation.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "ViewsHistoryNavigation", cViewsHistoryNavigation.Caption)
            cFile.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "File", cFile.Caption)
            cPrint.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "Print", cPrint.Caption)
            cExport.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "Export", cExport.Caption)
            cExit.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "Exit", cExit.Caption)
            barSubItemEdit.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "EditSubMenu", barSubItemEdit.Caption)
            cRecordEdit.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "RecordEdit", cRecordEdit.Caption)
            barSubItemView.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "ViewSubMenu", barSubItemView.Caption)
            barCheckItemNavigationPanelVisibility.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "NavigationBar", barCheckItemNavigationPanelVisibility.Caption)
            cRecordsNavigation.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "RecordsNavigation", cRecordsNavigation.Caption)
            cView.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "View", cView.Caption)
            cDefault.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "OtherActions", cDefault.Caption)
            barSubItemTools.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "ToolsSubMenu", barSubItemTools.Caption)
            cTools.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "Tools", cTools.Caption)
            cDiagnostic.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "Diagnostic", cDiagnostic.Caption)
            cOptions.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "Options", cOptions.Caption)
            barSubItemHelp.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "HelpSubMenu", barSubItemHelp.Caption)
            cAbout.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "About", cAbout.Caption)
            standardToolBar.Text = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "MainToolbar", standardToolBar.Text)
            cFiltersSearch.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "Search", cFiltersSearch.Caption)
            cFilters.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "Filters", cFilters.Caption)
            cMenu.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "Menu", cMenu.Caption)
            _statusBar.Text = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "StatusBar", _statusBar.Text)
            dockPanelNavigation.Text = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "NavigationPanel", dockPanelNavigation.Text)
        End Sub
        Public Overrides Sub ReloadSettings()
            MyBase.ReloadSettings()
            If TemplateInfo IsNot Nothing Then
                dockPanelNavigation.Width = TemplateInfo.GetAttributeIntValue(NavigationWidthAttributeName, dockPanelNavigation.Width)
                If (Not String.IsNullOrEmpty(TemplateInfo.GetAttributeValue(NavigationDockAttributeName))) Then
                    dockPanelNavigation.Dock = CType(System.Enum.Parse(GetType(DockingStyle), TemplateInfo.GetAttributeValue(NavigationDockAttributeName)), DockingStyle)
                End If
                If (Not String.IsNullOrEmpty(TemplateInfo.GetAttributeValue(NavigationVisibilityAttributeName))) Then
                    navigationPaneVisibility = CType(System.Enum.Parse(GetType(DockVisibility), TemplateInfo.GetAttributeValue(NavigationVisibilityAttributeName), True), DockVisibility)
                End If
                barCheckItemNavigationPanelVisibility.Down = (navigationPaneVisibility = DockVisibility.AutoHide OrElse navigationPaneVisibility = DockVisibility.Visible)
            End If
        End Sub
        Public Overrides Sub SaveSettings()
            MyBase.SaveSettings()
            If TemplateInfo IsNot Nothing Then
                TemplateInfo.SetAttribute(NavigationWidthAttributeName, dockPanelNavigation.Width)
                TemplateInfo.SetAttribute(NavigationDockAttributeName, dockPanelNavigation.Dock.ToString())
                TemplateInfo.SetAttribute(NavigationVisibilityAttributeName, dockPanelNavigation.Visibility.ToString())
            End If
        End Sub
        <Obsolete("Use the MainForm() constructor"), EditorBrowsable(EditorBrowsableState.Never)> _
        Public Sub New(ByVal application As XafApplication, ByVal templateInfo As DictionaryNode)
            Me.New()
        End Sub
        <Obsolete("Use the MainForm() constructor"), EditorBrowsable(EditorBrowsableState.Never)> _
        Public Sub New(ByVal application As XafApplication)
            Me.New()
        End Sub
        Public Sub New()
            InitializeComponent()
            InitializeCaptions()
            Dim containers As New List(Of IActionContainer)()
            containers.AddRange(New IActionContainer() { cAbout, cTools, cFile, cObjectsCreation, cPrint, cExport, cExit, cRecordEdit, cRecordsNavigation, cViewsHistoryNavigation, cFiltersSearch, cFilters, cView, cOptions, navigation, cDiagnostic, cViewsNavigation, cMenu})
            Initialize(mainBarManager, containers, New IActionContainer() { cObjectsCreation, cRecordEdit, cView, cPrint, cExport, cMenu }, viewSitePanel, navigation)
            AddHandler Load, AddressOf MainForm_Load
        End Sub
        Public ReadOnly Property MainMenuBar() As Bar
            Get
                Return _mainMenuBar
            End Get
        End Property
        Public ReadOnly Property ToolBar() As Bar
            Get
                Return standardToolBar
            End Get
        End Property
        Public ReadOnly Property StatusBar() As Bar
            Get
                Return _statusBar
            End Get
        End Property
        Public Overrides ReadOnly Property DefaultContainer() As IActionContainer
            Get
                Return cDefault
            End Get
        End Property
        Private Sub MainForm_Load(ByVal sender As Object, ByVal e As EventArgs)
            For i As Integer = 0 To cTools.Actions.Count - 1
                If cTools.Actions(i).Id = "EditModel" Then
                    cTools.Actions(i).Active.SetItemValue("My Template", False)
                    Exit For
                End If
            Next i
        End Sub
    End Class
End Namespace