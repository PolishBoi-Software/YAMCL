using CmlLib.Core.ProcessBuilder;
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
    public partial class LaunchOptionsDialog : Form
    {
        public MLaunchOption Options { get; private set; }
        public LaunchOptionsDialog(MinecraftInstance instance)
        {
            InitializeComponent();
            fullScreenCheck.Checked = instance.LaunchOptions.FullScreen;
            widthBox.Content = instance.LaunchOptions.ScreenWidth.ToString();
            heightBox.Content = instance.LaunchOptions.ScreenHeight.ToString();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult = DialogResult.OK;
                Options = new MLaunchOption()
                {
                    Session = AuthManager.Session,
                    ScreenWidth = (!string.IsNullOrEmpty(widthBox.Content) || widthBox.Content == "0") ? int.Parse(widthBox.Content) : 854,
                    ScreenHeight = (!string.IsNullOrEmpty(heightBox.Content) || heightBox.Content == "0") ? int.Parse(heightBox.Content) : 480,
                    FullScreen = fullScreenCheck.Checked
                };
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
