using System;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Tekla.Structures.Model;
using Tekla.Structures.Model.Operations;
using Tekla.Structures.Model.UI;
using Tekla.Structures.Plugins;

namespace TeklaBasicPlugin
{
    [Plugin("MyPlugin")]
    [PluginUserInterface("MyPlugin.MainWindow")]
    public class PluginMain : PluginBase
    {
        public override List<InputDefinition> DefineInput()
        {
            return null;
        }

        public override bool Run(List<InputDefinition> Input)
        {

            MessageBox.Show("Hello Tekla");

            return true; 
        }
    }
}
