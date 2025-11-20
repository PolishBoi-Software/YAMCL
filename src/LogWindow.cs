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
    public partial class LogWindow : Form
    {
        public LogWindow()
        {
            InitializeComponent();
        }

        public void Log(string message)
        {
            logBox.Invoke(new Action(() =>
            {
                var parsed = MCLogParser.Parse(message);

                string lvlTxt = $"[{parsed.level.ToString().ToUpper()}] ";
                logBox.AppendText(lvlTxt);
                int start = logBox.TextLength;
                logBox.Select(start, lvlTxt.Length);

                switch (parsed.level)
                {
                    case LogLevel.Error:
                        logBox.SelectionColor = Color.Red;
                        break;

                    case LogLevel.Warning:
                        logBox.SelectionColor = Color.Yellow;
                        break;

                    case LogLevel.Debug:
                        logBox.SelectionColor = Color.LightCyan;
                        break;

                    case LogLevel.Information:
                        logBox.SelectionColor = Color.Cyan;
                        break;

                    case LogLevel.Trace:
                        logBox.SelectionColor = Color.LightBlue;
                        break;

                    default:
                    case LogLevel.Other:
                        logBox.SelectionColor = Color.White;
                        break;
                }

                logBox.SelectionColor = logBox.ForeColor;

                logBox.Text += $"({parsed.time.ToShortTimeString()}) {parsed.message}\r\n";
                logBox.SelectionStart = logBox.Text.Length;
                logBox.ScrollToCaret();
            }));
        }

        private void LogWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                e.Cancel = true;
        }
    }
}
