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

using System;
using System.Configuration;
using System.Windows.Forms;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Security;
using DevExpress.ExpressApp.Win;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.ExpressApp.Xpo;

namespace CustomizeTemplate.Win {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            EditModelPermission.AlwaysGranted = System.Diagnostics.Debugger.IsAttached;
            CustomizeTemplateWindowsFormsApplication winApplication = new CustomizeTemplateWindowsFormsApplication();            
            winApplication.CreateCustomTemplate += winApplication_CreateCustomTemplate;

            InMemoryDataStoreProvider.Register();
            winApplication.ConnectionString = InMemoryDataStoreProvider.ConnectionString;


            try {
                winApplication.Setup();
                winApplication.Start();
            }
            catch(Exception e) {
                winApplication.HandleException(e);
            }
        }
        static void winApplication_CreateCustomTemplate(object sender, CreateCustomTemplateEventArgs e) {
            if(e.Context == TemplateContext.ApplicationWindow)
                e.Template = new CustomizeTemplate.Module.Win.Custom_Templates.MainForm();
        }
    }
}
