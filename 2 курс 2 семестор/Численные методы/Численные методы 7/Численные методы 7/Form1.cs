using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Численные_методы_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            double[,] mas = new double[10, Convert.ToInt32(numericUpDown1.Value)];
            dataGridView1.RowCount = Convert.ToInt32(numericUpDown1.Value);
            double k = 0.2;
            mas[1, 0] = 0;
            mas[2, 0] = 2;
            mas[3, 0] = 2;
            mas[4, 0] = k * (mas[2, 0] - mas[1, 0]);
            mas[5, 0] = k * ((mas[2, 0] + mas[4, 0] / 2) - (mas[1, 0] + k / 2));
            mas[6, 0] = k * ((mas[2, 0] + mas[5, 0] / 2) - (mas[1, 0] + k / 2));
            mas[7, 0] = k * ((mas[2, 0] + mas[6, 0]) - (mas[1, 0] + k));
            mas[8, 0] = Math.Exp(mas[1, 0]) + mas[1, 0] + 1;
            mas[9, 0] = Math.Abs(mas[8, 0] - mas[2, 0]);
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                mas[0, i] = i;
                mas[1, i] = i * 0.2;
            }   
            for (int i = 1; i < dataGridView1.RowCount ; i++)
            {
                mas[2, i] = mas[2,i-1] +(mas[4, i - 1]+ 2 * mas[5, i - 1] + 2 * mas[6, i - 1] + mas[7, i - 1])/6;
                mas[3, i] = mas[2, i] - mas[1, i];
                mas[4, i] = k*(mas[2, i] - mas[1, i]);
                mas[5, i] = k * ((mas[2, i] + mas[4, i] / 2) - (mas[1, i] + k / 2));
                mas[6, i] = k * ((mas[2, i] + mas[5, i] / 2) - (mas[1, i] + k / 2));
                mas[7, i] = k * ((mas[2, i] + mas[6, i]) - (mas[1, i] + k));
                mas[8, i] = Math.Exp(mas[1, i]) + mas[1, i] + 1;
                mas[9, i] = Math.Abs(mas[8, i] - mas[2, i]);

            }
            for (int i = 0; i < dataGridView1.RowCount; i++)
            { 
                for(int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1[j,i].Value = mas[j, i];
                }
            }
                
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 2;
            dataGridView1.Columns[0].Width = 60;
            dataGridView1.Columns[1].Width = 60;
            dataGridView1.Columns[2].Width = 60;
            dataGridView1.Columns[3].Width = 60;
            dataGridView1.Columns[4].Width = 60;
            dataGridView1.Columns[5].Width = 60;
            dataGridView1.Columns[6].Width = 60;
            dataGridView1.Columns[7].Width = 60;
            dataGridView1.Columns[8].Width = 60;
            dataGridView1.Columns[9].Width = 60;
            ;
        }
    }
}
