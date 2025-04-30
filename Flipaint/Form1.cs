using System;
using System.Drawing;
using System.Windows.Forms;

namespace Flipaint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            g = pnl_Draw.CreateGraphics();
        }
        bool startPaint = false;
        Graphics g;

        //nullable int for storing NULL values
        int? initX = null;
        int? initY = null;

        //Event fired when mouse is moved over the panel
        private void pnl_Draw_MouseMove(object sender, MouseEventArgs e)
        {
            if (startPaint)
            {
                //Setting the pen back color and line width
                Pen p = new Pen(btnPenColor.BackColor, float.Parse(cmbPenSize.Text));

                //Drawing the line
                g.DrawLine(p, new Point(initX ?? e.X, initY ?? e.Y), new Point(e.X, e.Y));
            }
        }


    }
}
