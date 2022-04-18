using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Численные_методы_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].Width = 70;
            dataGridView1.Columns[1].Width = 70;
            dataGridView1.Columns[2].Width = 70;
            dataGridView1.Columns[3].Width = 70;
            dataGridView1.RowCount = 6;
            double k = 0;
            for( int i = 0; i < 6; i++)
            {
                dataGridView1[0, i].Value = i +5;
                dataGridView1[1, i].Value = i +5;
                dataGridView1[2, i].Value = 1 / (Math.Log(Convert.ToDouble(dataGridView1[1, i].Value)) - 1);
                if(i==0 || i == 5)
                {
                    dataGridView1[3, i].Value = Convert.ToDouble(dataGridView1[2, i].Value)/2;
                }
                else
                {
                    dataGridView1[3, i].Value = Convert.ToDouble(dataGridView1[2, i].Value);
                }
                k = k + Convert.ToDouble(dataGridView1[3, i].Value);
            }
            textBox1.Text = Convert.ToString(k);
        }   

    }
}
