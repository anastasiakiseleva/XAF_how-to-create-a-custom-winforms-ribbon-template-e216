
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Templates
Imports DevExpress.XtraBars.Docking
Imports DevExpress.ExpressApp.Utils

Imports DevExpress.ExpressApp.Win.Templates
Partial Public Class MainForm
    Inherits XtraFormTemplateBase
    Private Const NavigationVisibilityAttributeName As String = "NavigationVisibility"
    Private Const NavigationWidthAttributeName As String = "NavigationWidth"
    Private Const NavigationDockAttributeName As String = "NavigationDock"
    Private Const FrameTemplatesMainFormLocalizationPath As String = "FrameTemplates\MainForm"
    Protected Overrides Sub SetFormIcon(ByVal view As DevExpress.ExpressApp.View)
    End Sub
#Region "IFrameTemplate Members"
    Public Overrides ReadOnly Property DefaultContainer() As IActionContainer
        Get
            Return cView
        End Get
    End Property
#End Region
    Private navigationPaneVisibility As DockVisibility = DockVisibility.Visible
    Private Sub dockPanelNavigation_ClosingPanel(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Docking.DockPanelCancelEventArgs) Handles dockPanelNavigation.ClosingPanel
        barCheckItemNavigationPaneVisibility.Down = False
    End Sub
    Private Sub barCheckItemNavigationPaneVisibility_CheckedChanged(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barCheckItemNavigationPaneVisibility.CheckedChanged
        If barCheckItemNavigationPaneVisibility.Down Then
            dockPanelNavigation.Visibility = navigationPaneVisibility
        Else
            navigationPaneVisibility = dockPanelNavigation.Visibility
            dockPanelNavigation.Visibility = DockVisibility.Hidden
        End If
    End Sub
    Protected Overrides Function GetFormStateNode() As DictionaryNode
        Return TemplateInfo.GetChildNode("FormState", "ID", "Default")
    End Function
    Public Overrides Sub ReloadSettings()
        MyBase.ReloadSettings()
        If Not TemplateInfo Is Nothing Then
            dockPanelNavigation.Width = TemplateInfo.GetAttributeIntValue(NavigationWidthAttributeName, dockPanelNavigation.Width)
            If (Not String.IsNullOrEmpty(TemplateInfo.GetAttributeValue(NavigationDockAttributeName))) Then
                dockPanelNavigation.Dock = CType([Enum].Parse(GetType(DockingStyle), TemplateInfo.GetAttributeValue(NavigationDockAttributeName)), DockingStyle)
            End If
            If (Not String.IsNullOrEmpty(TemplateInfo.GetAttributeValue(NavigationVisibilityAttributeName))) Then
                navigationPaneVisibility = CType([Enum].Parse(GetType(DockVisibility), TemplateInfo.GetAttributeValue(NavigationVisibilityAttributeName), True), DockVisibility)
            End If
            barCheckItemNavigationPaneVisibility.Down = (navigationPaneVisibility = DockVisibility.AutoHide OrElse navigationPaneVisibility = DockVisibility.Visible)
        End If
    End Sub
    Public Overrides Sub SaveSettings()
        MyBase.SaveSettings()
        If Not TemplateInfo Is Nothing Then
            TemplateInfo.SetAttribute(NavigationWidthAttributeName, dockPanelNavigation.Width)
            TemplateInfo.SetAttribute(NavigationDockAttributeName, dockPanelNavigation.Dock.ToString())
            TemplateInfo.SetAttribute(NavigationVisibilityAttributeName, dockPanelNavigation.Visibility.ToString())
        End If
    End Sub
    <Obsolete("Use the MainForm() constructor")> _
    Public Sub New(ByVal application As XafApplication, ByVal templateInfo As DictionaryNode)
        Me.New()
    End Sub
    <Obsolete("Use the MainForm() constructor")> _
    Public Sub New(ByVal application As XafApplication)
        Me.New()
    End Sub
    Public Sub New()
        InitializeComponent()

        MainMenuBar.Text = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "MainMenu")
        barSubItemFile.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "FileSubMenu")
        cObjectsCreation.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "ObjectsCreation")
        cViewsHistoryNavigation.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "ViewsHistoryNavigation")
        cFile.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "File")
        cPrint.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "Print")
        cExport.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "Export")
        cExit.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "Exit")
        barSubItemEdit.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "EditSubMenu")
        cRecordEdit.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "RecordEdit")
        barSubItemView.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "ViewSubMenu")
        barCheckItemNavigationPaneVisibility.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "NavigationBar")
        cRecordsNavigation.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "RecordsNavigation")
        cView.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "View")
        barSubItemTools.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "ToolsSubMenu")
        cTools.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "Tools")
        cDiagnostic.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "Diagnostic")
        cOptions.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "Options")
        barSubItemHelp.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "HelpSubMenu")
        cAbout.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "About")
        StandardToolBar.Text = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "MainToolbar")
        cFiltersSearch.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "Search")
        cFilters.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "Filters")
        StatusBar.Text = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "StatusBar")
        dockPanelNavigation.Text = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "NavigationPanel")

        Dim containers As List(Of IActionContainer) = New List(Of IActionContainer)()
        containers.AddRange(New IActionContainer() {cAbout, cTools, cFile, cObjectsCreation, cPrint, cExport, cExit, cRecordEdit, cRecordsNavigation, cViewsHistoryNavigation, cFiltersSearch, cFilters, cView, cOptions, navigation, cDiagnostic, cViewsNavigation})
        Initialize(mainBarManager, containers, New IActionContainer() {cObjectsCreation, cRecordEdit, cView, cPrint, cExport}, viewSitePanel, navigation)
	'Subcribe to the Load event
        AddHandler Load, AddressOf MainForm_Load

    End Sub

    Private Sub MainForm_Load(ByVal sender As Object, ByVal e As EventArgs)
        For i As Integer = 0 To cTools.Actions.Count - 1
            If cTools.Actions(i).Id = "EditModel" Then
		'Deactivate the Edit Model Action
                cTools.Actions(i).Active.SetItemValue("My Template", False)
                Exit For
            End If
        Next i
    End Sub

End Class
