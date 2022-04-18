using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.BackColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f1 = new Form2();
            if (f1.ShowDialog() == DialogResult.OK)
            {
            int x = Convert.ToInt32(f1.numericUpDown1.Value);
            int y = Convert.ToInt32(f1.numericUpDown2.Value);
            int h = Convert.ToInt32(f1.numericUpDown3.Value);
            Figure f = new Figure(x,y,h, pictureBox1);
            f.Draw();
            listBox1.Items.Add(f);
            }
                    
            

            

        }
    }
}
