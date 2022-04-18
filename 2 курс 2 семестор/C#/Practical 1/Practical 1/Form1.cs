using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            SolidBrush sb = new SolidBrush(Color.Blue);
            Pen p = new Pen(Color.Red);
            p.Width = 5;
            g.FillRectangle(sb, 5*Convert.ToInt32(numericUpDown2.Value), 5 * Convert.ToInt32(numericUpDown3.Value), Convert.ToInt32(numericUpDown1.Value) * 20,
                Convert.ToInt32(numericUpDown1.Value) * 20);
            g.DrawRectangle(p, 20, 20, Convert.ToInt32(numericUpDown1.Value) * 20, Convert.ToInt32(numericUpDown1.Value) * 20);
            Point p1 = new Point(20, 20);
            Point p2 = new Point(20+(Convert.ToInt32(numericUpDown1.Value) * 20), 20 + (Convert.ToInt32(numericUpDown1.Value) * 20));
            g.DrawLine(p, p1, p2);
            Point p3 = new Point(20 + (Convert.ToInt32(numericUpDown1.Value)) * 20, 20);
            Point p4 = new Point(20, 20 + (Convert.ToInt32(numericUpDown1.Value)) * 20);
            g.DrawLine(p, p3, p4);
            SolidBrush sb1 = new SolidBrush(Color.Green);
            g.FillEllipse(sb1, 20 + (Convert.ToInt32(numericUpDown1.Value) * 8), 20 + (Convert.ToInt32(numericUpDown1.Value) * 2),
                4*Convert.ToInt32(numericUpDown1.Value), 4*Convert.ToInt32(numericUpDown1.Value));
            g.FillEllipse(sb1, 20 + (Convert.ToInt32(numericUpDown1.Value) *8), 20 + (Convert.ToInt32(numericUpDown1.Value) * 14),
                4 * Convert.ToInt32(numericUpDown1.Value), 4 * Convert.ToInt32(numericUpDown1.Value));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = 5;
            numericUpDown2.Value = 5;
            numericUpDown3.Value = 5;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
