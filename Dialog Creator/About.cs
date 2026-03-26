using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dialog_Creator
{
    public partial class About : Form
    {
        string dialogCreatorVersion = "";
        string netFrameworkVersion = "";

        public About()
        {
            InitializeComponent();

            dialogCreatorVersion = Application.ProductVersion.ToString();
            netFrameworkVersion = Assembly.GetEntryAssembly()?.GetCustomAttribute<TargetFrameworkAttribute>()?.FrameworkName;
        }

        private void About_Load(object sender, EventArgs e)
        {
            versionText.Text = "Dialog Creator Version " + dialogCreatorVersion;
            netFrameworkInfo.Text = netFrameworkVersion;
        }
    }
}
