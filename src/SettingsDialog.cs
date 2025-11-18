using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YAMCL
{
    public partial class SettingsDialog : Form
    {
        public SettingsDialog()
        {
            InitializeComponent();
            autoSignInCheck.Checked = (bool)ConfigManager.Config["autoSignIn"];
            autoUpdateCheck.Checked = (bool)ConfigManager.Config["autoUpdate"];
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            ConfigManager.Config["autoSignIn"] = autoSignInCheck.Checked;
            ConfigManager.Config["autoUpdate"] = autoUpdateCheck.Checked;
            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
