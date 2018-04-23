using System;
using System.Configuration;
using System.Windows.Forms;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Security;
using DevExpress.ExpressApp.Win;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;

namespace HowToCustomizeTemplate.Win
{
    static class Program
    {
        static void application_CreateCustomTemplate(object sender, CreateCustomTemplateEventArgs e)
        {
            if (e.Context.Name == TemplateContext.ApplicationWindow.Name)
//Set the custom Template instead of the default one
                e.Template = new DevExpress.ExpressApp.Win.CustomTemplates.MainForm();
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            EditModelPermission.AlwaysGranted = System.Diagnostics.Debugger.IsAttached;
            HowToCustomizeTemplateWindowsFormsApplication application = new HowToCustomizeTemplateWindowsFormsApplication();
            //Subscribe to the CreateCustomTemplate event
            application.CreateCustomTemplate += new EventHandler<CreateCustomTemplateEventArgs>(application_CreateCustomTemplate);

            if (ConfigurationManager.ConnectionStrings["ConnectionString"] != null)
            {
                application.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            }
            try
            {
                application.Setup();
                application.Start();
            }
            catch (Exception e)
            {
                application.HandleException(e);
            }
        }
    }
}
