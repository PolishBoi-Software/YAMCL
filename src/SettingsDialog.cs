using AutoUpdaterDotNET;
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
            discordRpcCheck.Checked = (bool)ConfigManager.Config["discordRpc"];
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            ConfigManager.Config["autoSignIn"] = autoSignInCheck.Checked;
            ConfigManager.Config["autoUpdate"] = autoUpdateCheck.Checked;
            ConfigManager.Config["discordRpc"] = discordRpcCheck.Checked;
            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void checkUpdateBtn_Click(object sender, EventArgs e)
        {
            Program.frm.checkForUpdateBtnClicked = true;
            AutoUpdater.Start("https://raw.githubusercontent.com/PolishBoi-Software/Yet-Another-Minecraft-Launcher/main/version.xml");
        }
    }
}
