using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Численные_методы_Задание_2_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 16;
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 50;
            dataGridView1.Columns[2].Width = 50;
            dataGridView1.Columns[3].Width = 50;
            dataGridView1.Columns[4].Width = 50;
            dataGridView1.Columns[5].Width = 50;
            dataGridView1.Columns[6].Width = 50;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1[0, i].Value = Convert.ToDouble(i + 1);
            }
            dataGridView1[1, 0].Value = (1);
            dataGridView1[3, 0].Value = (2);
            dataGridView1[2, 0].Value = ((Convert.ToDouble(dataGridView1[1,0].Value) + Convert.ToDouble(dataGridView1[3, 0].Value)) / 2.0);
            dataGridView1[4, 0].Value = Math.Pow(Convert.ToDouble(dataGridView1[1, 0].Value), 3) - Convert.ToDouble(dataGridView1[1, 0].Value) - 1.0;
            dataGridView1[5, 0].Value = Math.Pow(Convert.ToDouble(dataGridView1[2, 0].Value), 3) - Convert.ToDouble(dataGridView1[2, 0].Value) - 1.0;
            dataGridView1[6, 0].Value = Math.Pow(Convert.ToDouble(dataGridView1[3, 0].Value), 3) - Convert.ToDouble(dataGridView1[3, 0].Value) - 1.0;

            for (int l = 0; l < 14; l++)
            {
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    if (Convert.ToDouble(dataGridView1[4, i].Value) * Convert.ToDouble(dataGridView1[5, i].Value) < 0)// Для нахождения A
                    {
                        dataGridView1[1, i + 1].Value = dataGridView1[1, i].Value;
                    }
                    else
                    {
                        dataGridView1[1, i + 1].Value = dataGridView1[2, i].Value;

                    }
                    if (Convert.ToDouble(dataGridView1[5, i].Value) * Convert.ToDouble(dataGridView1[6, i].Value) < 0)// Для нахождения B
                    {
                        dataGridView1[3, i + 1].Value = dataGridView1[3, i].Value;
                    }
                    else
                    {
                        dataGridView1[3, i + 1].Value = dataGridView1[2, i].Value;

                    }
                    dataGridView1[2, i].Value = ((Convert.ToDouble(dataGridView1[1, i].Value) + Convert.ToDouble(dataGridView1[3, i].Value)) / 2.0);
                    dataGridView1[4, i].Value = Math.Pow(Convert.ToDouble(dataGridView1[1, i].Value), 3) - Convert.ToDouble(dataGridView1[1, i].Value) - 1.0;
                    dataGridView1[5, i].Value = Math.Pow(Convert.ToDouble(dataGridView1[2, i].Value), 3) - Convert.ToDouble(dataGridView1[2, i].Value) - 1.0;
                    dataGridView1[6, i].Value = Math.Pow(Convert.ToDouble(dataGridView1[3, i].Value), 3) - Convert.ToDouble(dataGridView1[3, i].Value) - 1.0;
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Выйти? ", "Кнопка выходы ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }         
        }
    }
}
