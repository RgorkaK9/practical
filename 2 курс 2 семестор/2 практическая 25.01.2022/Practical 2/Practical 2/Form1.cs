using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical_2
{
    public partial class Form1 : Form
    {
        Graphics g;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(pictureBox1.Image);
            SolidBrush sb = new SolidBrush(Color.Black);
            Point p1 = new Point(0, 200);
            Point p2 = new Point(400, 200);
            Pen w = new Pen(Color.Red);
            g.DrawLine(w, p1, p2);
            Point p3 = new Point(200, 0);
            Point p4 = new Point(200, 400);
            g.DrawLine(w, p3, p4);
            for (int i = 0; i <= 180; i++)
            {
                g.DrawEllipse(w, 200 + i, 199 - Convert.ToInt32(Math.Sqrt(i)), 2, 2);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown3.Value = 100;   
        }

        private void button2_Click(object sender, EventArgs e)
        {

            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(pictureBox1.Image);
            SolidBrush sb = new SolidBrush(Color.Black);
            Point p1 = new Point(0, 200);
            Point p2 = new Point(400, 200);
            Pen w = new Pen(Color.Red);
            g.DrawLine(w, p1, p2);
            Point p3 = new Point(200, 0);
            Point p4 = new Point(200, 400);
            g.DrawLine(w, p3, p4);
            int k = Convert.ToInt32(numericUpDown3.Value);
            for (int i = 1; i <= 180; i++)
            {
                g.DrawEllipse(w, 210 + i, 190-(k/i), 2, 2);
                g.DrawEllipse(w, 210 + (k / i), 190 - i, 2, 2);
                g.DrawEllipse(w, 190 - (k / i), 210 + i, 2, 2);
                g.DrawEllipse(w, 190 - i, 210 + (k / i), 2, 2);
            }
        }
    }
}
