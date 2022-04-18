using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Численные_методы_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 50;
            dataGridView1.Columns[2].Width = 50;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.RowCount = Convert.ToInt32(numericUpDown1.Value);
            
            
            for (int l = 0; l < numericUpDown1.Value; l++)
            {
                dataGridView1[0, l].Value = Convert.ToDouble(l + 1);//1/(1+B9^3)
                dataGridView1[1, l].Value = Convert.ToDouble(1 / numericUpDown1.Value * (l+1));
                dataGridView1[2, l].Value = (1 / (1 + Math.Pow(Convert.ToDouble(dataGridView1[1, l].Value),3))); 
            }
            double k = 0;
            double k1 = 0;  
            for (int l = 0; l < numericUpDown1.Value-1; l++)
            {
                k = k + Convert.ToDouble(dataGridView1[2, l].Value);
            }
            for (int l = 0; l < numericUpDown1.Value; l++)
            {
                k1 = k1 + Convert.ToDouble(dataGridView1[2, l].Value);
            }
            double n = 1 / Convert.ToDouble(numericUpDown1.Value);
            textBox6.Text = Convert.ToString(n);
            textBox1.Text = Convert.ToString(k + 1);
            textBox2.Text = Convert.ToString(k1);
            double k11 = ((k + 1) * n);
            textBox3.Text = Convert.ToString(k11);
            double k12 = (k1 * n);
            textBox4.Text = Convert.ToString(k12);
            textBox5.Text = Convert.ToString((k11 + k12) / 2);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
