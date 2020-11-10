using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ShareV2
{
    public partial class DrawingFormOverlay : Form
    {
        public event EventHandler<AreaSelectedEventArgs> AreaSelected;
        System.Drawing.Graphics formGraphics;
        bool isDown = false;
        int initialX;
        int initialY;
        Rectangle rect;
        public DrawingFormOverlay()
        {
            InitializeComponent();
        }

        

        private void DrawingFormOverlay_MouseDown(object sender, MouseEventArgs e)
        {
            isDown = true;
            initialX = e.X;
            initialY = e.Y;
        }

        private void DrawingFormOverlay_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDown == true)
            {
                this.Refresh();
                Pen drwaPen = new Pen(Color.Red, 3);
               
                rect = new Rectangle(Math.Min(e.X, initialX),
                               Math.Min(e.Y, initialY),
                               Math.Abs(e.X - initialX),
                               Math.Abs(e.Y - initialY));

                formGraphics = this.CreateGraphics();
                formGraphics.DrawRectangle(drwaPen, rect);
            }
        }

        private void DrawingFormOverlay_MouseUp(object sender, MouseEventArgs e)
        {
            isDown = false;
            AreaSelected?.Invoke(this, new AreaSelectedEventArgs ( Screen.FromControl(this), rect ));
        }

        /// <summary>
        /// Event Args for the event that is fired after the hot key has been pressed.
        /// </summary>
        public class AreaSelectedEventArgs : EventArgs
        {
            private readonly Screen _screen;
            private readonly Rectangle _selectedArea;

            internal AreaSelectedEventArgs(Screen screen, Rectangle selectedArea)
            {
                _screen = screen;
                _selectedArea = selectedArea;
            }

            public Screen Screen
            {
                get { return _screen; }
            }

            public Rectangle SelectedArea
            {
                get { return _selectedArea; }
            }
        }

    }
}
