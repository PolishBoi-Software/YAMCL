using CmlLib.Core.VersionMetadata;
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
    public partial class InstanceDialog : Form
    {
        public string InstanceName { get; private set; }
        public string InstanceVersion { get; private set; }
        public VersionInstance InstanceObject { get; private set; }
        public bool Failed { get; private set; }

        public InstanceDialog()
        {
            InitializeComponent();
        }

        private string GetSelectedVersion()
        {
            if (versionList.SelectedItem == null)
            {
                throw new ArgumentNullException("Please select a version!");
            }

            var item = (IVersionMetadata)versionList.SelectedItem;
            return item.Name;
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult = DialogResult.OK;
                InstanceName = nameBox.Content;
                InstanceVersion = GetSelectedVersion();
                InstanceObject = new VersionInstance(InstanceName, InstanceVersion, Program.YAMCLFolder);
                Failed = false;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Failed = true;
            }
        }

        private async Task InitVersionList()
        {
            var versions = await Program.frm.launcher.GetAllVersionsAsync();

            foreach (var version in versions)
            {
                versionList.Items.Add(version);
            }

            versionList.DisplayMember = "Name";
        }

        private void InstanceDialog_Load(object sender, EventArgs e)
        {
            _ = InitVersionList();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            InstanceName = string.Empty;
            InstanceVersion = string.Empty;
            InstanceObject = null;
            Failed = false;
            Close();
        }
    }
}
