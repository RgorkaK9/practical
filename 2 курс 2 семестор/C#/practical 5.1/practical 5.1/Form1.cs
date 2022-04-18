using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practical_5._1
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
            }
            else if (radioButton2.Checked == true)
            {
                //Прямоугольник
                Form2 f2 = new Form2();
                if (f2.ShowDialog() == DialogResult.OK)
                {
                    double a = Convert.ToDouble(f2.textBox1.Text);
                    double b = Convert.ToDouble(f2.textBox2.Text);
                    rentangl r = new rentangl(a, b);
                    listBox1.Items.Add(r);
                }
            }
            else if (radioButton3.Checked == true)
            {
                //треугольник
            }
        }
    }
}
