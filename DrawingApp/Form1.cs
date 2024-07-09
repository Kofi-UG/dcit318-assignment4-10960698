using System;
using System.Drawing;
using System.Windows.Forms;

namespace DrawingApp
{
    public partial class Form1 : Form
    {
        private bool isDrawing = false;
        private Point lastPoint;

        public Form1()
        {
            InitializeComponent();
        }

        private void canvasPanel_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            lastPoint = e.Location;
        }

        private void canvasPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                using (Graphics g = canvasPanel.CreateGraphics())
                {
                    g.DrawLine(Pens.Black, lastPoint, e.Location);
                    lastPoint = e.Location;
                }
            }
        }

        private void canvasPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }
    }
}
