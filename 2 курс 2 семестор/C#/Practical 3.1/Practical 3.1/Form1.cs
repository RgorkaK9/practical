using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical_3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.BackColor = Color.White;
            button2.Enabled = false;
            button3.Enabled = false;
        }

        public void Button2_Click(object sender, EventArgs e)
        {
        }

        public void DrawAll()
        {
          //  pictureBox1.BackColor = Color.White;
            for(int i = 0; i < listBox1.Items.Count; i++)
            {
                Figure f = listBox1.Items[i] as Figure;
                f.Draw();
            }
        }


        public void button1_Click(object sender, EventArgs e)
        {
            Form2 f1 = new Form2();
            if (f1.ShowDialog() == DialogResult.OK)
            {
                int x = Convert.ToInt32(f1.numericUpDown1.Value);
                int y = Convert.ToInt32(f1.numericUpDown2.Value);
                int h = Convert.ToInt32(f1.numericUpDown3.Value);
                bool t1 = false;
                if (f1.radioButton1.Checked)
                {
                    t1 = true;
                }
                bool t2 = false;
                if (f1.radioButton2.Checked)
                {
                    t2 = true;
                }
                Color cl = f1.pictureBox1.BackColor;
                Figure f = new Figure(x, y, h, pictureBox1, t1, t2, cl);
                listBox1.Items.Add(f);
                //bool t = false;
                //if (f1.radioButton1.Checked)
                //{
                //    t = true;
                //}
                //bool t1 = false;
                //if (f1.radioButton2.Checked)
                //{
                //    t1= true;
                //}
                DrawAll();
                if(listBox1.Items.Count >= 1)
                {
                    button2.Enabled = true;
                    button3.Enabled = true;
                }
            }
        }

        public void button2_Click_1(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Вы не выбрали объект для удаления");
            }
            else
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);

                DrawAll();
                if (listBox1.Items.Count == 0)
                {
                    button2.Enabled = false;
                    button3.Enabled = false;
                }
            }
        }

        public void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Вы не выбрали объект для редоктиование");
            }
            else
            {
                Form2 f1 = new Form2();
                if (f1.ShowDialog() == DialogResult.OK)
                {
                    Point p1 = new Point(0, 0);
                    Point p2 = new Point(1000, 1000);
                    Point p3 = new Point(1000, 0);
                    Point p4 = new Point(0, 1000);
                    SolidBrush sb1 = new SolidBrush(Color.White);
                    Graphics g = Graphics.FromImage(pictureBox1.Image);
                    g.FillRectangle(sb1, 0, 0, 1000, 1000);
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                    int x = Convert.ToInt32(f1.numericUpDown1.Value);
                    int y = Convert.ToInt32(f1.numericUpDown2.Value);
                    int h = Convert.ToInt32(f1.numericUpDown3.Value);
                    bool t1 = false;
                    if (f1.radioButton1.Checked)
                    {
                        t1 = true;
                    }
                    bool t2 = false;
                    if (f1.radioButton2.Checked)
                    {
                        t2 = true;
                    }
                    Color cl = f1.pictureBox1.BackColor;
                    Figure f = new Figure(x, y, h, pictureBox1, t1, t2, cl);
                    listBox1.Items.Add(f);
                    
                    DrawAll();

                    
                }
            }
        }
        public void button4_Click(object sender, EventArgs e)
        {

        }

        public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i< listBox1.Items.Count; i++)
            {
                Figure f = listBox1.Items[i] as Figure;
                f.Move();
            }
        }
    }
}
