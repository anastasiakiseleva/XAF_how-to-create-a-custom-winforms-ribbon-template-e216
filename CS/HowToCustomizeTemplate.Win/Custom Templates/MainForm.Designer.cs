namespace DevExpress.ExpressApp.Win.CustomTemplates {
	partial class MainForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.mainBarManager = new DevExpress.XtraBars.BarManager(this.components);
			this._mainMenuBar = new DevExpress.XtraBars.Bar();
			this.barSubItemFile = new DevExpress.ExpressApp.Win.Templates.MainMenuItem();
			this.cObjectsCreation = new DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem();
			this.cViewsHistoryNavigation = new DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem();
			this.cFile = new DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem();
			this.cPrint = new DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem();
			this.cExport = new DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem();
			this.cExit = new DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem();
			this.barSubItemEdit = new DevExpress.ExpressApp.Win.Templates.MainMenuItem();
			this.cRecordEdit = new DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem();
			this.barSubItemView = new DevExpress.ExpressApp.Win.Templates.MainMenuItem();
			this.barCheckItemNavigationPanelVisibility = new DevExpress.XtraBars.BarCheckItem();
			this.cRecordsNavigation = new DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem();
			this.cView = new DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem();
			this.cDefault = new DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem();
			this.barSubItemTools = new DevExpress.ExpressApp.Win.Templates.MainMenuItem();
			this.cTools = new DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerMenuBarItem();
			this.cViewsNavigation = new DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerMenuBarItem();
			this.cDiagnostic = new DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerMenuBarItem();
			this.cOptions = new DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerMenuBarItem();
			this.barSubItemHelp = new DevExpress.ExpressApp.Win.Templates.MainMenuItem();
			this.cAbout = new DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerMenuBarItem();
			this.standardToolBar = new DevExpress.XtraBars.Bar();
			this.cFiltersSearch = new DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem();
			this.cFilters = new DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem();
			this.cMenu = new DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem();
			this._statusBar = new DevExpress.XtraBars.Bar();
			this.mainBarAndDockingController = new DevExpress.XtraBars.BarAndDockingController(this.components);
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.mainDockManager = new DevExpress.XtraBars.Docking.DockManager();
			this.dockPanelNavigation = new DevExpress.XtraBars.Docking.DockPanel();
			this.dockPanelNavigation_Container = new DevExpress.XtraBars.Docking.ControlContainer();
			this.navigation = new DevExpress.ExpressApp.Win.Templates.ActionContainers.NavigationActionContainer();
			this.viewSitePanel = new DevExpress.XtraEditors.PanelControl();
			((System.ComponentModel.ISupportInitialize)(this.mainBarManager)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mainBarAndDockingController)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mainDockManager)).BeginInit();
			this.dockPanelNavigation.SuspendLayout();
			this.dockPanelNavigation_Container.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.viewSitePanel)).BeginInit();
			this.SuspendLayout();
			// 
			// barManager
			// 
			this.mainBarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this._mainMenuBar,
            this.standardToolBar,
            this._statusBar});
			this.mainBarManager.Controller = this.mainBarAndDockingController;
			this.mainBarManager.DockControls.Add(this.barDockControlTop);
			this.mainBarManager.DockControls.Add(this.barDockControlBottom);
			this.mainBarManager.DockControls.Add(this.barDockControlLeft);
			this.mainBarManager.DockControls.Add(this.barDockControlRight);
			this.mainBarManager.DockManager = this.mainDockManager;
			this.mainBarManager.Form = this;
			this.mainBarManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barSubItemFile,
            this.barSubItemEdit,
            this.barSubItemView,
            this.barSubItemTools,
            this.barSubItemHelp,
            this.cFile,
            this.cObjectsCreation,
            this.cPrint,
            this.cExport,
            this.cExit,
            this.cRecordEdit,
            this.cRecordsNavigation,
            this.cViewsHistoryNavigation,
            this.cFiltersSearch,
            this.cFilters,
            this.cView,
			this.cDefault,
            this.cTools,
			this.cViewsNavigation,
            this.cDiagnostic,
            this.cOptions,
            this.cAbout,
			this.cMenu,
            this.barCheckItemNavigationPanelVisibility});
			this.mainBarManager.MainMenu = this._mainMenuBar;
			this.mainBarManager.MaxItemId = 34;
			this.mainBarManager.StatusBar = this._statusBar;
			// 
			// _mainMenuBar
			// 
			this._mainMenuBar.BarName = "Main Menu";
			this._mainMenuBar.DockCol = 0;
			this._mainMenuBar.DockRow = 0;
			this._mainMenuBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this._mainMenuBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItemFile),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItemEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItemView),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItemTools),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItemHelp) });
			this._mainMenuBar.OptionsBar.MultiLine = true;
			this._mainMenuBar.OptionsBar.UseWholeRow = true;
			this._mainMenuBar.Text = "Main Menu";
			// 
			// barSubItemFile
			// 
			this.barSubItemFile.Caption = "File";
			this.barSubItemFile.Id = 0;
			this.barSubItemFile.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.cObjectsCreation, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.cViewsHistoryNavigation, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.cFile, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.cPrint, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.cExport, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.cExit, true)});
			this.barSubItemFile.Name = "barSubItemFile";
			// 
			// cObjectsCreation
			// 
			this.cObjectsCreation.Caption = "Objects creation";
			this.cObjectsCreation.ContainerId = "ObjectsCreation";
			this.cObjectsCreation.Id = 18;
			this.cObjectsCreation.Name = "cObjectsCreation";
			// 
			// cViewsHistoryNavigation
			// 
			this.cViewsHistoryNavigation.Caption = "Views History Navigation";
			this.cViewsHistoryNavigation.ContainerId = "ViewsHistoryNavigation";
			this.cViewsHistoryNavigation.Id = 35;
			this.cViewsHistoryNavigation.Name = "cViewsHistoryNavigation";
			// 
			// cFile
			// 
			this.cFile.Caption = "File";
			this.cFile.ContainerId = "File";
			this.cFile.Id = 5;
			this.cFile.Name = "cFile";
			// 
			// cPrint
			// 
			this.cPrint.Caption = "Print";
			this.cPrint.ContainerId = "Print";
			this.cPrint.Id = 6;
			this.cPrint.Name = "cPrint";
			// 
			// cExport
			// 
			this.cExport.Caption = "Export";
			this.cExport.ContainerId = "Export";
			this.cExport.Id = 7;
			this.cExport.Name = "cExport";
			// 
			// cExit
			// 
			this.cExit.Caption = "Exit";
			this.cExit.ContainerId = "Exit";
			this.cExit.Id = 8;
			this.cExit.Name = "cExit";
			// 
			// barSubItemEdit
			// 
			this.barSubItemEdit.Caption = "Edit";
			this.barSubItemEdit.Id = 1;
			this.barSubItemEdit.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.cRecordEdit, true)});
			this.barSubItemEdit.Name = "barSubItemEdit";
			// 
			// cRecordEdit
			// 
			this.cRecordEdit.Caption = "Record Edit";
			this.cRecordEdit.ContainerId = "RecordEdit";
			this.cRecordEdit.Id = 9;
			this.cRecordEdit.Name = "cRecordEdit";
			// 
			// barSubItemView
			// 
			this.barSubItemView.Caption = "View";
			this.barSubItemView.Id = 2;
			this.barSubItemView.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItemNavigationPanelVisibility, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.cViewsNavigation),
            new DevExpress.XtraBars.LinkPersistInfo(this.cRecordsNavigation, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.cView, true),
			new DevExpress.XtraBars.LinkPersistInfo(this.cDefault, true)
			});
			this.barSubItemView.Name = "barSubItemView";
			// 
			// barCheckItemNavigationPaneVisibility
			// 
			this.barCheckItemNavigationPanelVisibility.Caption = "&Navigation Bar";
			this.barCheckItemNavigationPanelVisibility.Id = 33;
			this.barCheckItemNavigationPanelVisibility.Name = "barCheckItemNavigationPaneVisibility";
			this.barCheckItemNavigationPanelVisibility.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.barCheckItemNavigationPaneVisibility_CheckedChanged);
			// 
			// cRecordsNavigation
			// 
			this.cRecordsNavigation.Caption = "Records Navigation";
			this.cRecordsNavigation.ContainerId = "RecordsNavigation";
			this.cRecordsNavigation.Id = 10;
			this.cRecordsNavigation.Name = "cRecordsNavigation";
			// 
			// cView
			// 
			this.cView.Caption = "View";
			this.cView.ContainerId = "View";
			this.cView.Id = 12;
			this.cView.Name = "cView";
			// 
			// cDefault
			// 
			this.cDefault.Caption = "Default";
			this.cDefault.ContainerId = "Default";
			this.cDefault.Id = 50;
			this.cDefault.Name = "cDefault";
			// 
			// barSubItemTools
			// 
			this.barSubItemTools.Caption = "Tools";
			this.barSubItemTools.Id = 3;
			this.barSubItemTools.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.cTools, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.cDiagnostic, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.cOptions, true)});
			this.barSubItemTools.Name = "barSubItemTools";
			// 
			// cTools
			// 
			this.cTools.Caption = "Tools";
			this.cTools.ContainerId = "Tools";
			this.cTools.Id = 13;
			this.cTools.Name = "cTools";
			// 
			// cViewsNavigation
			// 
			this.cViewsNavigation.Caption = "Navigation";
			this.cViewsNavigation.ContainerId = "ViewsNavigation";
			this.cViewsNavigation.Id = 14;
			this.cViewsNavigation.Name = "cViewsNavigation";
			this.cViewsNavigation.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
			// 
			// cDiagnostic
			// 
			this.cDiagnostic.Caption = "Diagnostic";
			this.cDiagnostic.ContainerId = "Diagnostic";
			this.cDiagnostic.Id = 16;
			this.cDiagnostic.Name = "cDiagnostic";
			// 
			// cOptions
			// 
			this.cOptions.Caption = "Options";
			this.cOptions.ContainerId = "Options";
			this.cOptions.Id = 14;
			this.cOptions.Name = "cOptions";
			// 
			// barSubItemHelp
			// 
			this.barSubItemHelp.Caption = "Help";
			this.barSubItemHelp.Id = 4;
			this.barSubItemHelp.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.cAbout, true)});
			this.barSubItemHelp.Name = "barSubItemHelp";
			// 
			// cAbout
			// 
			this.cAbout.Caption = "About";
			this.cAbout.ContainerId = "About";
			this.cAbout.Id = 15;
			this.cAbout.Name = "cAbout";
			// 
			// StandardToolBar
			// 
			this.standardToolBar.BarName = "Main Toolbar";
			this.standardToolBar.DockCol = 0;
			this.standardToolBar.DockRow = 1;
			this.standardToolBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.standardToolBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.cViewsHistoryNavigation, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.cObjectsCreation, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.cView, true),
			new DevExpress.XtraBars.LinkPersistInfo(this.cDefault, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.cRecordEdit, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.cFiltersSearch, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.cFilters, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.cRecordsNavigation, true)});
			this.standardToolBar.Text = "Main Toolbar";
			// 
			// cFiltersSearch
			// 
			this.cFiltersSearch.Caption = "Search";
			this.cFiltersSearch.ContainerId = "Search";
			this.cFiltersSearch.Id = 11;
			this.cFiltersSearch.Name = "cFiltersSearch";
			// 
			// cFilters
			// 
			this.cFilters.Caption = "Filters";
			this.cFilters.ContainerId = "Filters";
			this.cFilters.Id = 26;
			this.cFilters.Name = "cFilters";
			// 
			// cMenu
			// 
			this.cMenu.Caption = "Menu";
			this.cMenu.Id = 7;
			this.cMenu.ContainerId = "Menu";
			this.cMenu.Name = "cMenu";
			// 
			// StatusBar
			// 
			this._statusBar.BarName = "StatusBar";
			this._statusBar.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
			this._statusBar.DockCol = 0;
			this._statusBar.DockRow = 0;
			this._statusBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
			this._statusBar.OptionsBar.AllowQuickCustomization = false;
			this._statusBar.OptionsBar.DisableClose = true;
			this._statusBar.OptionsBar.DisableCustomization = true;
			this._statusBar.OptionsBar.DrawDragBorder = false;
			this._statusBar.OptionsBar.DrawSizeGrip = true;
			this._statusBar.OptionsBar.UseWholeRow = true;
			this._statusBar.Text = "Status Bar";
			// 
			// barAndDockingController1
			// 
			this.mainBarAndDockingController.PropertiesBar.AllowLinkLighting = false;
			// 
			// dockManager1
			// 
			this.mainDockManager.Controller = this.mainBarAndDockingController;
			this.mainDockManager.Form = this;
			this.mainDockManager.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanelNavigation});
			this.mainDockManager.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "System.Windows.Forms.StatusBar"});
			// 
			// dockPanelNavigation
			// 
			this.dockPanelNavigation.Controls.Add(this.dockPanelNavigation_Container);
			this.dockPanelNavigation.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
			this.dockPanelNavigation.FloatSize = new System.Drawing.Size(146, 428);
			this.dockPanelNavigation.ID = new System.Guid("24977e30-0ea6-44aa-8fa4-9abaeb178b5e");
			this.dockPanelNavigation.Location = new System.Drawing.Point(0, 49);
			this.dockPanelNavigation.Name = "dockPanelNavigation";
			this.dockPanelNavigation.Options.AllowDockBottom = false;
			this.dockPanelNavigation.Options.AllowDockTop = false;
			this.dockPanelNavigation.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Left;
			this.dockPanelNavigation.SavedIndex = 2;
			this.dockPanelNavigation.Size = new System.Drawing.Size(146, 495);
			this.dockPanelNavigation.TabStop = false;
			this.dockPanelNavigation.Text = "Navigation";
			this.dockPanelNavigation.ClosingPanel += new DevExpress.XtraBars.Docking.DockPanelCancelEventHandler(dockPanelNavigation_ClosingPanel);
			// 
			// dockPanelNavigation_Container
			// 
			this.dockPanelNavigation_Container.Controls.Add(this.navigation);
			this.dockPanelNavigation_Container.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dockPanelNavigation_Container.Location = new System.Drawing.Point(3, 25);
			this.dockPanelNavigation_Container.Name = "dockPanelNavigation_Container";
			this.dockPanelNavigation_Container.Size = new System.Drawing.Size(140, 467);
			this.dockPanelNavigation_Container.TabIndex = 0;
			// 
			// Modules
			//
			this.navigation.Dock = System.Windows.Forms.DockStyle.Fill;
			this.navigation.Name = "Navigation";
			this.navigation.Location = new System.Drawing.Point(0, 0);
			this.navigation.Size = new System.Drawing.Size(140, 467);
			this.navigation.TabIndex = 0;
			// 
			// viewSitePanel
			// 
			this.viewSitePanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.viewSitePanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.viewSitePanel.Location = new System.Drawing.Point(0, 49);
			this.viewSitePanel.Name = "viewSitePanel";
			this.viewSitePanel.Size = new System.Drawing.Size(792, 495);
			this.viewSitePanel.TabIndex = 4;
			// 
			// NewMainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(792, 566);
			this.Controls.Add(this.dockPanelNavigation);
			this.Controls.Add(this.viewSitePanel);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.Name = "NewMainForm";
			this.Text = "MainForm";
			((System.ComponentModel.ISupportInitialize)(this.mainBarManager)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mainBarAndDockingController)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mainDockManager)).EndInit();
			this.dockPanelNavigation.ResumeLayout(false);
			this.dockPanelNavigation_Container.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.viewSitePanel)).EndInit();
			this.ResumeLayout(false);

		}		
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
		private DevExpress.XtraBars.Bar _mainMenuBar;
		private DevExpress.XtraBars.Bar standardToolBar;
		private DevExpress.XtraBars.Bar _statusBar;
		private DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem cFile;
		private DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem cObjectsCreation;
		private DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem cPrint;
		private DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem cExport;
		private DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem cExit;
		private DevExpress.ExpressApp.Win.Templates.MainMenuItem barSubItemFile;
		private DevExpress.ExpressApp.Win.Templates.MainMenuItem barSubItemEdit;
		private DevExpress.ExpressApp.Win.Templates.MainMenuItem barSubItemView;
		private DevExpress.ExpressApp.Win.Templates.MainMenuItem barSubItemTools;
		private DevExpress.ExpressApp.Win.Templates.MainMenuItem barSubItemHelp;
		private DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerMenuBarItem cViewsNavigation;
		private DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem cRecordEdit;
		private DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem cRecordsNavigation;
		private DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem cViewsHistoryNavigation;
		private DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem cFiltersSearch;
		private DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem cFilters;
		private DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem cView;
		private DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem cDefault;
		private DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerMenuBarItem cTools;
		private DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerMenuBarItem cDiagnostic;
		private DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerMenuBarItem cOptions;
		private DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerMenuBarItem cAbout;
		private DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem cMenu;
		#endregion
		protected DevExpress.XtraBars.BarAndDockingController mainBarAndDockingController;
		protected DevExpress.XtraBars.Docking.DockManager mainDockManager;
		protected DevExpress.XtraBars.BarManager mainBarManager;
		protected DevExpress.ExpressApp.Win.Templates.ActionContainers.NavigationActionContainer navigation;
		protected DevExpress.XtraBars.Docking.DockPanel dockPanelNavigation;
		protected DevExpress.XtraBars.Docking.ControlContainer dockPanelNavigation_Container;
		protected DevExpress.XtraEditors.PanelControl viewSitePanel;
		protected DevExpress.XtraBars.BarCheckItem barCheckItemNavigationPanelVisibility;

	}
}