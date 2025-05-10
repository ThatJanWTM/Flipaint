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
        bool drawSquare = false;
        bool drawRectangle = false;
        bool drawCircle = false;

        //Event fired when mouse is moved over the panel
        private void pnl_Draw_MouseMove(object sender, MouseEventArgs e)
        {
            if (startPaint)
            {
                //Setting the pen back color and line width
                Pen p = new Pen(btnPenColor.BackColor, float.Parse(cmbPenSize.Text));

                //Drawing the line
                g.DrawLine(p, new Point(initX ?? e.X, initY ?? e.Y), new Point(e.X, e.Y));
                initX = e.X;
                initY = e.Y;

            }
        }
        //Event Fired when the mouse pointer is over Panel and a mouse button is pressed
        private void pnl_Draw_MouseDown(object sender, MouseEventArgs e)
        {
            startPaint = true;
            if (drawSquare)
            {
                //Use Solid Brush for filling the graphic shapes
                SolidBrush sb = new SolidBrush(btnPenColor.BackColor);
                //setting the width and height same for creating square.
                //getting the width and height value from Textbox(txt_ShapeSize)
                g.FillRectangle(sb, e.X, e.Y, int.Parse(btnShapeSize.Text), int.Parse(btnShapeSize.Text));
                startPaint = false;
                drawSquare = false;
            }
            if (drawRectangle)
            {
                SolidBrush sb = new SolidBrush(btnPenColor.BackColor);
                g.FillRectangle(sb, e.X, e.Y, 2 * int.Parse(btnShapeSize.Text), int.Parse(btnShapeSize.Text));
                startPaint = false;
                drawRectangle = false;
            }
            if (drawCircle)
            {
                SolidBrush sb = new SolidBrush(btnPenColor.BackColor);
                g.FillRectangle(sb, e.X, e.Y, 2 * int.Parse(btnShapeSize.Text), int.Parse(btnShapeSize.Text));
                startPaint = false;
                drawCircle = false;
            }
        }
        //Fired when tge mouse pointer is over pnl_Draw and a mouse button is released
        private void pnl_DrawMouseUp(object sender, MouseEventArgs e)
        {
            startPaint = false;
            initX = null;
            initY = null;
        }
        //Button for setting pen color
        private void button1_Click(object sender, EventArgs e)
        {
            //Open Color Dialog and Set BackColor of btnPenColor if user clicks on OK
            ColorDialog c = new ColorDialog();
            if (c.ShowDialog() == DialogResult.OK)
            {
                btnPenColor.BackColor = c.Color;
            }

        }
    }
}
