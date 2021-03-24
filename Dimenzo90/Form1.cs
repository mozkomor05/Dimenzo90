using Dimenzo90.Shapes;
using Dimenzo90.Vectors;

using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;

namespace Dimenzo90
{
    public partial class Form1 : Form
    {
        private readonly double[] speedOptions = new double[] { 0.5, 0.75, 1, 1.5, 2, 2.5, 3, 3.5, 4 };
        private readonly Dictionary<string, int> speedIndexes = new Dictionary<string, int>(6)
        {
            { "yz", -1 },
            { "xz", -1 },
            { "xy", -1 },
            { "xw", -1 },
            { "yw", -1 },
            { "zw", -1 }
        };

        private readonly Tesseract hypercube;

        private readonly Timer rotationTimer = new Timer();
        private readonly Pen linePen = new Pen(Brushes.Black, 2);
        private readonly Pen axePen = new Pen(Color.FromArgb(100, 0, 0, 0));

        public Form1()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);

            hypercube = new Tesseract();
            //hypercube.SetFaceBrush(0, 255, 0, 0);
            //hypercube.SetFaceBrush(1, 0, 255, 255);
            //hypercube.SetFaceBrush(2, 255, 255, 0);

            InitializeComponent();

            string[] options = speedOptions.Select(x => x.ToString() + "x").ToArray();

            yzspeed.DropDownStyle = xzspeed.DropDownStyle = xyspeed.DropDownStyle = xwspeed.DropDownStyle = ywspeed.DropDownStyle =
                zwspeed.DropDownStyle = ComboBoxStyle.DropDownList;

            yzspeed.Items.AddRange(options);
            xzspeed.Items.AddRange(options);
            xyspeed.Items.AddRange(options);
            xwspeed.Items.AddRange(options);
            ywspeed.Items.AddRange(options);
            zwspeed.Items.AddRange(options);

            yzspeed.SelectedIndex = xzspeed.SelectedIndex = xyspeed.SelectedIndex = xwspeed.SelectedIndex = ywspeed.SelectedIndex =
                zwspeed.SelectedIndex = 2;

            prtype.SelectedIndex = 0;
            prtype.DropDownStyle = ComboBoxStyle.DropDownList;

            rotationTimer.Tick += (a, b) =>
            {
                ChangeSliders(yzscroll, xzscroll, xyscroll, xwscroll, ywscroll, zwscroll);
                canvas.Refresh();
            };
            rotationTimer.Interval = 30;
            rotationTimer.Start();
        }

        private void ChangeSliders(params TrackBar[] bars)
        {
            foreach (TrackBar bar in bars)
            {
                string plane = bar.Name.Substring(0, 2);

                if (speedIndexes[plane] != -1)
                    bar.Value = Convert.ToInt32((((bar.Value / 100.0 + speedOptions[speedIndexes[plane]] + 180) % 360 + 360) % 360 - 180) * 100);
            }
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(Color.White);
            g.TranslateTransform(canvas.Width / 2, canvas.Height / 2);

            hypercube.SortFaces();

            foreach (int i in hypercube.FacesOrder)
            {
                Point[] points = new Point[hypercube.Faces.GetLength(1)];

                for (byte j = 0; j < hypercube.Faces.GetLength(1); j++)
                {
                    Vector projectedVector = hypercube.Points[hypercube.Faces[i, j]].Project(120, prtype.SelectedIndex);
                    points[j] = new Point(Convert.ToInt32(projectedVector.X), Convert.ToInt32(projectedVector.Y));
                }

                g.FillPolygon(hypercube.GetFaceBrush(i, opacity.Value), points);
                g.DrawLines(linePen, points);

                foreach (Point point in points)
                    g.FillEllipse(Brushes.Green, point.X - 4, point.Y - 4, 8, 8);
            }

            for (int i = 0; i < hypercube.Axes.GetLength(0); i++)
            {
                Vector[] projectedAxe = new Vector[] { hypercube.Axes[i, 0].Project(130, prtype.SelectedIndex), 
                    hypercube.Axes[i, 1].Project(120, prtype.SelectedIndex) };
                g.DrawLine(axePen, Convert.ToInt32(projectedAxe[0].X), Convert.ToInt32(projectedAxe[0].Y),
                    Convert.ToInt32(projectedAxe[1].X), Convert.ToInt32(projectedAxe[1].Y));
            }
        }

        private void RotationAxeChanged(object sender, EventArgs e)
        {
            double yz = yzscroll.Value / 100.0, xz = xzscroll.Value / 100.0, xy = xyscroll.Value / 100.0, xw = xwscroll.Value / 100.0,
                yw = ywscroll.Value / 100.0, zw = zwscroll.Value / 100.0;

            yzlabel.Text = yz.ToString("0.00") + "° - YZ plane";
            xzlabel.Text = xz.ToString("0.00") + "° - XZ plane";
            xylabel.Text = xy.ToString("0.00") + "° - XY plane";
            xwlabel.Text = xw.ToString("0.00") + "° - XW plane";
            ywlabel.Text = yw.ToString("0.00") + "° - YW plane";
            zwlabel.Text = zw.ToString("0.00") + "° - ZW plane";

            hypercube.Rotate(yz, xz, xy, xw, yw, zw);
            canvas.Refresh();
        }

        private void Opacity_Scroll(object sender, EventArgs e)
        {
            opacityLabel.Text = opacity.Value + " - Faces' opacity";
            canvas.Refresh();
        }

        private void AutoChanged(object sender, EventArgs e)
        {
            CheckBox auto = (CheckBox)sender;
            string plane = auto.Name.Substring(0, 2);
            ComboBox speed = (ComboBox)Controls.Find(plane + "speed", true).FirstOrDefault();

            speed.Enabled = auto.Checked;
            speedIndexes[plane] = auto.Checked ? speed.SelectedIndex : -1;
        }

        private void SpeedChanged(object sender, EventArgs e)
        {
            ComboBox speed = (ComboBox)sender;

            if (speed.Enabled)
                speedIndexes[speed.Name.Substring(0, 2)] = speed.SelectedIndex;
        }

        private void ResetClick(object sender, EventArgs e)
        {
            ((TrackBar)Controls.Find(((Button)sender).Name.Substring(0, 2) + "scroll", true).FirstOrDefault()).Value = 0;
        }
    }
}
