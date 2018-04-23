using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Templates;
using DevExpress.XtraBars.Docking;
using DevExpress.ExpressApp.Utils;

using DevExpress.ExpressApp.Win.Templates;

namespace DevExpress.ExpressApp.Win.CustomTemplates {
	public partial class MainForm : DevExpress.ExpressApp.Win.Templates.XtraFormTemplateBase {
		private const string NavigationVisibilityAttributeName = "NavigationVisibility";
		private const string NavigationWidthAttributeName = "NavigationWidth";
		private const string NavigationDockAttributeName = "NavigationDock";
		private const string FrameTemplatesMainFormLocalizationPath = @"FrameTemplates\MainForm";
		protected override void SetFormIcon(DevExpress.ExpressApp.View view) { }
		#region IFrameTemplate Members
		public override IActionContainer DefaultContainer {
			get { return cView; }
		}
		#endregion
		private DockVisibility navigationPaneVisibility = DockVisibility.Visible;
		private void dockPanelNavigation_ClosingPanel(object sender, DevExpress.XtraBars.Docking.DockPanelCancelEventArgs e) {
			barCheckItemNavigationPaneVisibility.Down = false;
		}
		private void barCheckItemNavigationPaneVisibility_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
			if(barCheckItemNavigationPaneVisibility.Down) {
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
				barCheckItemNavigationPaneVisibility.Down = (navigationPaneVisibility == DockVisibility.AutoHide || navigationPaneVisibility == DockVisibility.Visible);
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

			MainMenuBar.Text = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "MainMenu");
			barSubItemFile.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "FileSubMenu");
			cObjectsCreation.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "ObjectsCreation");
			cViewsHistoryNavigation.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "ViewsHistoryNavigation");
			cFile.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "File");
			cPrint.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "Print");
			cExport.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "Export");
			cExit.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "Exit");
			barSubItemEdit.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "EditSubMenu");
			cRecordEdit.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "RecordEdit");
			barSubItemView.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "ViewSubMenu");
			barCheckItemNavigationPaneVisibility.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "NavigationBar");
			cRecordsNavigation.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "RecordsNavigation");
			cView.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "View");
			barSubItemTools.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "ToolsSubMenu");
			cTools.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "Tools");
			cDiagnostic.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "Diagnostic");
			cOptions.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "Options");
			barSubItemHelp.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "HelpSubMenu");
			cAbout.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "About");
			StandardToolBar.Text = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "MainToolbar");
			cFiltersSearch.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "Search");
			cFilters.Caption = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "Filters");
			StatusBar.Text = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "StatusBar");
			dockPanelNavigation.Text = CaptionHelper.GetLocalizedText(FrameTemplatesMainFormLocalizationPath, "NavigationPanel");

			List<IActionContainer> containers = new List<IActionContainer>();
			containers.AddRange(new IActionContainer[] {
				cAbout, cTools, cFile, cObjectsCreation, cPrint, cExport, cExit, cRecordEdit, 
				cRecordsNavigation, cViewsHistoryNavigation, cFiltersSearch, cFilters,
				cView, cOptions, navigation, cDiagnostic, cViewsNavigation});
			Initialize(mainBarManager, containers,
				new IActionContainer[] { cObjectsCreation, cRecordEdit, cView, cPrint, cExport },
				viewSitePanel, navigation);
//Subscribe to the Load method
            this.Load += new System.EventHandler(this.MainForm_Load);

		}

        private void MainForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < cTools.Actions.Count; i++)
            {
                if (cTools.Actions[i].Id == "EditModel")
                {
//Deactivate the Edit Model Action
                    cTools.Actions[i].Active.SetItemValue("My Template", false);
                    break;
                }
            }
        }

	}
}