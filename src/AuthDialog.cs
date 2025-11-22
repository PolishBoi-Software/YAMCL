using CmlLib.Core.Auth;
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
    public partial class AuthDialog : Form
    {
        public string Username { get; set; }
        public AuthDialog()
        {
            InitializeComponent();
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Username = unameBox.Content;
            Close();
        }
    }
}
