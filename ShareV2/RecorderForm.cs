using System;
using System.Drawing;
using System.Windows.Forms;

namespace ShareV2
{
    public partial class RecorderForm : Form
    {
        Recorder recorder;
        public RecorderForm()
        {
            InitializeComponent();
        }

        private void RecorderForm_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;
        }

        private void RecPauseBtn_Click(object sender, EventArgs e)
        {
            recorder = new Recorder(new RecorderParams() { 
                FileName = @"C:\xampp\htdocs\test\capture.webm",
                FramesPerSecond=60, 
                Quality = 100,
                Width = this.Width, 
                Height = this.Height,
                UpperLeft = this.Location,
                fileFormat = RecorderParams.FileFormat.WEBM
            });  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            recorder.Dispose();
        }
    }
}
