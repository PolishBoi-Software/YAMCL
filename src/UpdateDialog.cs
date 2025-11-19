using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YAMCL
{
    public partial class UpdateDialog : Form
    {
        private string _changelogUrl;
        public UpdateDialog(Version installed, string latest, string changelogUrl)
        {
            InitializeComponent();
            installedVersion.Content = $"Installed version: {installed}";
            latestLbl.Content = $"Latest version: {latest}";
            _changelogUrl = changelogUrl;
        }

        private void yesBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            Close();
        }

        private void noBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }

        private void changeLogBtn_Click(object sender, EventArgs e)
        {
            Process.Start(_changelogUrl);
        }
    }
}
