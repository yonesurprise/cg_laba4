using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace laba4
{
    public partial class Laba3 : Form
    {
        Bitmap pic;
        Graphics graph;
        List<Point> points = new List<Point>();
        List<(Point, Point)> lines = new List<(Point, Point)>();
        List<List<Point>> polygons = new List<List<Point>>();
        Pen pen = new Pen(Color.Black, 1), rpen = new Pen(Color.Red, 5);
        bool first = false;
        bool cur_pol = false;
        (int, int) first_coord;
        int point_count = 0;
        int polygon_count = 0;
        int lines_count = 0;
        string curpol = "";
        string curpoint = "";
        string curline1 = "";
        string curline2 = "";

        public Laba3()
        {
            InitializeComponent();
            pic = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = pic;
            graph = Graphics.FromImage(pictureBox1.Image);
            graph.Clear(Color.White);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            first = false;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (radioButton_point.Checked)
            {
                points.Add(new Point(e.X, e.Y));
            }
            else if (radioButton_otrezok.Checked)
            {
                if (!first)
                {
                    first_coord = (e.X, e.Y);
                    first = true;
                }
                else
                {
                    lines.Add((new Point(first_coord.Item1, first_coord.Item2), new Point(e.X, e.Y)));
                    first = false;
                }
            }
            else if (radioButton_polygon.Checked)
            {
                polygons[polygons.Count - 1].Add(new Point(e.X, e.Y));
                if (!cur_pol)
                {
                    cur_pol = true;
                }
            }
            DrawAll();
        }

        void DrawAll()
        {
            graph.Clear(Color.White);
            foreach (var x in points)
                pic.SetPixel(x.X, x.Y, Color.Black);
            pen.EndCap = LineCap.NoAnchor;
            foreach (var x in lines)
                graph.DrawLine(pen, x.Item1.X, x.Item1.Y, x.Item2.X, x.Item2.Y);
            pen.EndCap = LineCap.NoAnchor;
            foreach (var x in polygons)
            {
                graph.DrawLine(pen, x[0], x[x.Count - 1]);
                for (int i = 0; i < x.Count - 1; i++)
                    graph.DrawLine(pen, x[i], x[i + 1]);
            }

            pictureBox1.Invalidate();
        }

        private void radioButton_polygon_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_polygon.Checked)
                polygons.Add(new List<Point>());
            else
                if (polygons[polygons.Count - 1].Count == 0)
            {
                polygons.RemoveAt(polygons.Count - 1);
            }
            else
                cur_pol = false;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            graph.Clear(Color.White);
            radioButton_point.Checked = true;
            polygons.Clear();
            points.Clear();
            lines.Clear();
            polygon_count = 0; point_count = 0; lines_count = 0;
            pictureBox1.Invalidate();
            curpol = "";
            curpoint = "";
            curline1 = "";
            curline2 = "";
            
        }
    }
}
