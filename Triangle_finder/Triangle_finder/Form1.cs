using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Triangle_finder
{
    public partial class Form1 : Form
    {
        private TextBox txtPoints;
        private Button btnGenerate;
        private Panel drawPanel;

        private readonly List<PointF> points = new();
        private readonly List<Triangle> triangles = new();
        private Triangle largestTriangle;

        public Form1()
        {
            InitializeComponent(); // Form1.Designer.cs дотор бий
            SetupUi();             // Доорх бидний UI
        }

        private void SetupUi()
        {
            this.Text = "Triangle Finder";
            this.Size = new Size(900, 700);
            this.StartPosition = FormStartPosition.CenterScreen;

            var lblPoints = new Label
            {
                Text = "Number of Points (N):",
                Location = new Point(20, 20),
                Size = new Size(150, 20)
            };

            txtPoints = new TextBox
            {
                Location = new Point(180, 18),
                Size = new Size(100, 20),
                Text = "12"
            };

            btnGenerate = new Button
            {
                Text = "Generate & Find Largest",
                Location = new Point(290, 16),
                Size = new Size(200, 26)
            };
            btnGenerate.Click += BtnGenerate_Click;

            drawPanel = new Panel
            {
                Location = new Point(20, 60),
                Size = new Size(840, 580),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.White
            };
            drawPanel.Paint += DrawPanel_Paint;

            this.Controls.AddRange(new Control[] { lblPoints, txtPoints, btnGenerate, drawPanel });
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtPoints.Text, out int n) || n < 3)
            {
                MessageBox.Show("Please enter a valid number (at least 3).", "Error");
                return;
            }

            GeneratePoints(n);
            CreateTriangles_AllCombinations(); // бүх боломжит гурвалжин
            FindLargestTriangle();
            drawPanel.Invalidate(); // дахин зур
        }

        private void GeneratePoints(int n)
        {
            points.Clear();
            var rand = new Random();
            int margin = 30;

            for (int i = 0; i < n; i++)
            {
                float x = rand.Next(margin, drawPanel.Width - margin);
                float y = rand.Next(margin, drawPanel.Height - margin);
                points.Add(new PointF(x, y));
            }
        }

        // БҮХ КОМБИНАЦААР гурвалжин үүсгэнэ (i<j<k)
        private void CreateTriangles_AllCombinations()
        {
            triangles.Clear();
            const double EPS = 1e-6;

            for (int i = 0; i < points.Count - 2; i++)
            {
                for (int j = i + 1; j < points.Count - 1; j++)
                {
                    for (int k = j + 1; k < points.Count; k++)
                    {
                        var t = new Triangle(points[i], points[j], points[k]);
                        if (t.Area > EPS) // шулуун дээр давхцсан бол хасна
                            triangles.Add(t);
                    }
                }
            }
        }

        private void FindLargestTriangle()
        {
            largestTriangle = null;
            double maxArea = 0;

            foreach (var t in triangles)
            {
                if (t.Area > maxArea)
                {
                    maxArea = t.Area;
                    largestTriangle = t;
                }
            }
        }

        private void DrawPanel_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // гурвалжингууд
            foreach (var t in triangles)
            {
                bool isLargest = t == largestTriangle;
                using var pen = new Pen(isLargest ? Color.Red : Color.Blue, isLargest ? 3 : 1);
                using var brush = new SolidBrush(Color.FromArgb(30, isLargest ? Color.Red : Color.Blue));
                PointF[] pts = { t.P1, t.P2, t.P3 };
                g.FillPolygon(brush, pts);
                g.DrawPolygon(pen, pts);
            }

            // цэгүүд
            foreach (var p in points)
                g.FillEllipse(Brushes.Black, p.X - 4, p.Y - 4, 8, 8);

            // мэдээлэл
            if (largestTriangle != null)
            {
                string info = $"Points: {points.Count}\n" +
                              $"Triangles: {triangles.Count}\n" +
                              $"Largest Area: {largestTriangle.Area:F2}";
                g.DrawString(info, new Font("Arial", 10, FontStyle.Bold),
                             Brushes.DarkRed, new PointF(10, 10));
            }
        }
    }

    // Дуртай бол тусдаа Triangle.cs болгож болно
    public class Triangle
    {
        public PointF P1 { get; }
        public PointF P2 { get; }
        public PointF P3 { get; }
        public double Area { get; private set; }

        public Triangle(PointF p1, PointF p2, PointF p3)
        {
            P1 = p1; P2 = p2; P3 = p3;
            CalculateArea();
        }

        private void CalculateArea()
        {
            double a = Distance(P1, P2);
            double b = Distance(P2, P3);
            double c = Distance(P3, P1);
            double s = (a + b + c) / 2;
            Area = Math.Sqrt(Math.Max(0, s * (s - a) * (s - b) * (s - c))); // numeric guard
        }

        private static double Distance(PointF p1, PointF p2)
        {
            double dx = p2.X - p1.X, dy = p2.Y - p1.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
}
