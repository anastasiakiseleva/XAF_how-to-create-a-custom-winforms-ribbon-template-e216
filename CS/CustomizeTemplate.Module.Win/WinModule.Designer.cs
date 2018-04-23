// Developer Express Code Central Example:
// How to Customize a Template
// 
// This example demonstrates how to customize Windows Forms Templates. The Edit
// Model item is removed from the Tools menu in the MainForm Template. See code at
// the bottom of the MainFrom.cs (MainForm.vb) file and in the Program.cs
// (Program.vb) file. For details, refer to the How to: Customize a Template
// (ms-help://DevExpress.Xaf/CustomDocument2618.htm) topic in XAF documentation.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E216

namespace CustomizeTemplate.Module.Win {
    partial class CustomizeTemplateWindowsFormsModule {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            // 
            // CustomizeTemplateWindowsFormsModule
            // 
            this.AdditionalExportedTypes.Add(typeof(DevExpress.Persistent.BaseImpl.Person));
            this.RequiredModuleTypes.Add(typeof(DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule));

        }

        #endregion
    }
}
