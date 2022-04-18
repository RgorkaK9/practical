using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practical_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {

                //круг
                Form2 f2 = new Form2();
                if (f2.ShowDialog() == DialogResult.OK)
                {
                    double a = Convert.ToDouble(f2.textBox2.Text);
                    circle r = new circle(a);
                    listBox1.Items.Add(r);
                }
            }
            else if (radioButton2.Checked == true)
            {
                //Прямоугольник
                Form3 f3 = new Form3();
                if (f3.ShowDialog() == DialogResult.OK)
                {
                    double a = Convert.ToDouble(f3.textBox1.Text);
                    double b = Convert.ToDouble(f3.textBox2.Text);
                    rentangl r = new rentangl(a, b);
                    listBox1.Items.Add(r);
                }
            }
            else if (radioButton3.Checked == true)
            {
                //треугольник
                Form4 f4 = new Form4();
                if (f4.ShowDialog() == DialogResult.OK)
                {
                    double a = Convert.ToDouble(f4.textBox1.Text);
                    double b = Convert.ToDouble(f4.textBox2.Text);
                    triangle r = new triangle(a, b);
                    listBox1.Items.Add(r);
                }
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex <= 1)
            {
                
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex != -1)
            {
                parents p = listBox1.Items[listBox1.SelectedIndex] as parents;
                textBox1.Text = p.S().ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex ==-1)
            {
                MessageBox.Show("Вы не выбрали объект для удаления");
            }
            else
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Вы не выбрали объект для редоктирования");
            }
            else
            {
                if (listBox1.Items[listBox1.SelectedIndex] is circle)
                {
                    Form2 f2 = new Form2();
                    if (f2.ShowDialog() == DialogResult.OK)
                    {
                        double a = Convert.ToDouble(f2.textBox2.Text);
                        circle r = new circle(a);
                        listBox1.Items.Add(r);
                        listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                    }
                }
                else if (listBox1.Items[listBox1.SelectedIndex] is rentangl)
                {
                    Form3 f3 = new Form3();
                    if (f3.ShowDialog() == DialogResult.OK)
                    {
                        double a = Convert.ToDouble(f3.textBox1.Text);
                        double b = Convert.ToDouble(f3.textBox2.Text);
                        rentangl r = new rentangl(a, b);
                        listBox1.Items.Add(r);
                        listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                    }
                }
                else if (listBox1.Items[listBox1.SelectedIndex] is triangle)
                {
                    Form4 f4 = new Form4();
                    if (f4.ShowDialog() == DialogResult.OK)
                    {
                        double a = Convert.ToDouble(f4.textBox1.Text);
                        double b = Convert.ToDouble(f4.textBox2.Text);
                        triangle r = new triangle(a, b);
                        listBox1.Items.Add(r);
                        listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                    }
                }
            }
        }
    }
}
