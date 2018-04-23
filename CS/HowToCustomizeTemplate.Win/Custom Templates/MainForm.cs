using System;
using System.Collections.Generic;
using System.ComponentModel;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Templates;
using DevExpress.XtraBars.Docking;
using DevExpress.ExpressApp.Utils;
using DevExpress.XtraBars;

using DevExpress.ExpressApp.Win.Templates;

namespace DevExpress.ExpressApp.Win.CustomTemplates {
	public partial class MainForm : DevExpress.ExpressApp.Win.Templates.XtraFormTemplateBase {
		private const string NavigationVisibilityAttributeName = "NavigationVisibility";
		private const string NavigationWidthAttributeName = "NavigationWidth";
		private const string NavigationDockAttributeName = "NavigationDock";
		private const string FrameTemplatesMainFormLocalizationPath = @"FrameTemplates\MainForm";
		protected override void SetFormIcon(DevExpress.ExpressApp.View view) { }
		private DockVisibility navigationPaneVisibility = DockVisibility.Visible;
		private void dockPanelNavigation_ClosingPanel(object sender, DevExpress.XtraBars.Docking.DockPanelCancelEventArgs e) {
			barCheckItemNavigationPanelVisibility.Down = false;
		}
		private void barCheckItemNavigationPaneVisibility_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
			if(barCheckItemNavigationPanelVisibility.Down) {
				dockPanelNavigation.Visibility = navigationPaneVisibility;
			}
			else {
				navigationPaneVisibility = dockPanelNavigation.Visibility;
				dockPanelNavigation.Visibility = DockVisibility.Hidden;
			}
		}
		protected override DictionaryNode GetFormStateNode() {
			return TemplateInfo.GetChildNode("FormState", "ID", "Default");
		}
		protected override void InitializeCaptions() {
			MainMenuBar.Text = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "MainMenu", MainMenuBar.Text);
			barSubItemFile.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "FileSubMenu", barSubItemFile.Caption);
			cObjectsCreation.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "ObjectsCreation", cObjectsCreation.Caption);
			cViewsHistoryNavigation.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "ViewsHistoryNavigation", cViewsHistoryNavigation.Caption);
			cFile.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "File", cFile.Caption);
			cPrint.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "Print", cPrint.Caption);
			cExport.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "Export", cExport.Caption);
			cExit.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "Exit", cExit.Caption);
			barSubItemEdit.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "EditSubMenu", barSubItemEdit.Caption);
			cRecordEdit.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "RecordEdit", cRecordEdit.Caption);
			barSubItemView.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "ViewSubMenu", barSubItemView.Caption);
			barCheckItemNavigationPanelVisibility.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "NavigationBar", barCheckItemNavigationPanelVisibility.Caption);
			cRecordsNavigation.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "RecordsNavigation", cRecordsNavigation.Caption);
			cView.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "View", cView.Caption);
			cDefault.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "OtherActions", cDefault.Caption);
			barSubItemTools.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "ToolsSubMenu", barSubItemTools.Caption);
			cTools.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "Tools", cTools.Caption);
			cDiagnostic.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "Diagnostic", cDiagnostic.Caption);
			cOptions.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "Options", cOptions.Caption);
			barSubItemHelp.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "HelpSubMenu", barSubItemHelp.Caption);
			cAbout.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "About", cAbout.Caption);
			standardToolBar.Text = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "MainToolbar", standardToolBar.Text);
			cFiltersSearch.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "Search", cFiltersSearch.Caption);
			cFilters.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "Filters", cFilters.Caption);
			cMenu.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "Menu", cMenu.Caption);
			_statusBar.Text = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "StatusBar", _statusBar.Text);
			dockPanelNavigation.Text = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "NavigationPanel", dockPanelNavigation.Text);
		}
		public override void ReloadSettings() {
			base.ReloadSettings();
			if(TemplateInfo != null) {
				dockPanelNavigation.Width = TemplateInfo.GetAttributeIntValue(NavigationWidthAttributeName, dockPanelNavigation.Width);
				if(!string.IsNullOrEmpty(TemplateInfo.GetAttributeValue(NavigationDockAttributeName))) {
					dockPanelNavigation.Dock = (DockingStyle)Enum.Parse(typeof(DockingStyle), TemplateInfo.GetAttributeValue(NavigationDockAttributeName));
				}
				if(!string.IsNullOrEmpty(TemplateInfo.GetAttributeValue(NavigationVisibilityAttributeName))) {
					navigationPaneVisibility = (DockVisibility)Enum.Parse(typeof(DockVisibility), TemplateInfo.GetAttributeValue(NavigationVisibilityAttributeName), true);
				}
				barCheckItemNavigationPanelVisibility.Down = (navigationPaneVisibility == DockVisibility.AutoHide || navigationPaneVisibility == DockVisibility.Visible);
			}
		}
		public override void SaveSettings() {
			base.SaveSettings();
			if(TemplateInfo != null) {
				TemplateInfo.SetAttribute(NavigationWidthAttributeName, dockPanelNavigation.Width);
				TemplateInfo.SetAttribute(NavigationDockAttributeName, dockPanelNavigation.Dock.ToString());
				TemplateInfo.SetAttribute(NavigationVisibilityAttributeName, dockPanelNavigation.Visibility.ToString());
			}
		}
		[Obsolete("Use the MainForm() constructor"), EditorBrowsable(EditorBrowsableState.Never)]
		public MainForm(XafApplication application, DictionaryNode templateInfo) : this() { }
		[Obsolete("Use the MainForm() constructor"), EditorBrowsable(EditorBrowsableState.Never)]
		public MainForm(XafApplication application) : this() { }
		public MainForm() {
			InitializeComponent();
			InitializeCaptions();
			List<IActionContainer> containers = new List<IActionContainer>();
			containers.AddRange(new IActionContainer[] {
				cAbout, cTools, cFile, cObjectsCreation, cPrint, cExport, cExit, cRecordEdit, 
				cRecordsNavigation, cViewsHistoryNavigation, cFiltersSearch, cFilters,
				cView, cOptions, navigation, cDiagnostic, cViewsNavigation, cMenu});
			Initialize(mainBarManager, containers,
				new IActionContainer[] { cObjectsCreation, cRecordEdit, cView, cPrint, cExport, cMenu },
				viewSitePanel, navigation);
            this.Load += new System.EventHandler(this.MainForm_Load);
		}
		public Bar MainMenuBar {
			get { return _mainMenuBar; }
		}
		public Bar ToolBar {
			get { return standardToolBar; }
		}
		public Bar StatusBar {
			get { return _statusBar; }
		}
		public override IActionContainer DefaultContainer {
			get {				
				return cDefault;
			}
		}
        private void MainForm_Load(object sender, EventArgs e) {
            for (int i = 0; i < cTools.Actions.Count; i++) {
                if (cTools.Actions[i].Id == "EditModel") {
                    cTools.Actions[i].Active.SetItemValue("My Template", false);
                    break;
                }
            }
        }
	}
}