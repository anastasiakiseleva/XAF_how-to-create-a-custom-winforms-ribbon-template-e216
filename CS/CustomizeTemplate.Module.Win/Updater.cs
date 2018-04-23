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

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Updating;
using DevExpress.Xpo;

namespace CustomizeTemplate.Module.Win {
    public class Updater : ModuleUpdater {
        public Updater(IObjectSpace objectSpace, Version currentDBVersion) : base(objectSpace, currentDBVersion) { }
        public override void UpdateDatabaseAfterUpdateSchema() {
            base.UpdateDatabaseAfterUpdateSchema();
        }
    }
}
