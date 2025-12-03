using System;
using System.Drawing;
using System.Windows.Forms;
namespace biy_daalt_3
{
    public partial class Form1 : Form
    {
        private bool isDrawing = false;
        private Point startPoint;
        private Bitmap canvasBitmap;
        private Graphics g;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            canvasBitmap = new Bitmap(canvasPanel.Width, canvasPanel.Height);
            g = Graphics.FromImage(canvasBitmap);
            g.Clear(Color.White);

            canvasPanel.BackgroundImage = canvasBitmap;
            canvasPanel.BackgroundImageLayout = ImageLayout.None;

            rbLine.Checked = true;
        }

        private void canvasPanel_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            startPoint = e.Location;
        }

        private void canvasPanel_MouseUp(Object sender, MouseEventArgs e)
        {
            if (!isDrawing) return;
            isDrawing = false;

            Point endPoint = e.Location;

            Pen pen = new Pen(Color.Black, 2);
            if (rbLine.Checked)
            {
                g.DrawLine(pen, startPoint, endPoint);
            }
            else
            {
                Rectangle rect = new Rectangle(
                    Math.Min(startPoint.X, endPoint.X),
                    Math.Min(startPoint.Y, endPoint.Y),
                    Math.Abs(endPoint.X - startPoint.X),
                    Math.Abs(endPoint.Y - startPoint.Y));
                if (rbRect.Checked)
                    g.DrawRectangle(pen, rect);
                else if (rbEllipse.Checked)
                    g.DrawEllipse(pen, rect);
            }
            pen.Dispose();
            canvasPanel.Invalidate();
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbLine_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbEllipse_CheckedChanged(object sender, EventArgs e)
        {

        }




        private void btnClear_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            canvasPanel.Invalidate();
        }
    }
}
