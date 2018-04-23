using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

using DevExpress.ExpressApp;

namespace CustomizeTemplate.Module.Win {
    [ToolboxItemFilter("Xaf.Platform.Win")]
    public sealed partial class CustomizeTemplateWindowsFormsModule : ModuleBase {
        public CustomizeTemplateWindowsFormsModule() {
            InitializeComponent();
        }
    }
}
