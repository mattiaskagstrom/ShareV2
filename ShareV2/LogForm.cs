using System;
using System.Windows.Forms;

namespace ShareV2
{
    public partial class LogForm : Form, ILogInterface
    {
        public LogForm()
        {
            InitializeComponent();
        }

        private void LogForm_Load(object sender, EventArgs e)
        {

        }

        public void Log(string message)
        {
            TxtLog.Text += DateTime.Now.ToString() + ": " + message + "\n";
        }

        private void LogForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
