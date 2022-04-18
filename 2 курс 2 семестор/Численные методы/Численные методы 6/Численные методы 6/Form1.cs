using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Численные_методы_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double func(double x)
        {
            return Math.Exp(x) + x + 1;
        }
        public double fun2(double x)
        {
            return x*x;
        }



        public void button1_Click(object sender, EventArgs e)
        {
            dataGridView1[0, 0].Value = 0;
            dataGridView1[1, 0].Value = 0;
            dataGridView1[2, 0].Value = 2;
            dataGridView1[3, 0].Value = 2;
            dataGridView1[4, 0].Value = 0.4;

            for (int i = 1; i <= 5; i++)
            {
                dataGridView1[0, i].Value = i;
                dataGridView1[1, i].Value = i * 0.2;
                dataGridView1[2, i].Value = Convert.ToDouble(dataGridView1[2, i - 1].Value) + Convert.ToDouble(dataGridView1[4, i - 1].Value);
                dataGridView1[3, i].Value = Convert.ToDouble(dataGridView1[2, i].Value) - Convert.ToDouble(dataGridView1[1, i].Value);
                dataGridView1[4, i].Value = Convert.ToDouble(dataGridView1[3, i].Value) * 0.2;
                dataGridView1[5, i].Value = Math.Exp(Convert.ToDouble(dataGridView1[1, i].Value)) + Convert.ToDouble(dataGridView1[1, i].Value) + 1;
            }
            for (int i = 0; i <= 5; i++)
            {
                dataGridView1[5, i].Value = Math.Exp(Convert.ToDouble(dataGridView1[1, i].Value)) + Convert.ToDouble(dataGridView1[1, i].Value) + 1;
                dataGridView1[6, i].Value = Convert.ToDouble(dataGridView1[5, i].Value) - Convert.ToDouble(dataGridView1[2, i].Value);
            }
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].Width = 70;
            dataGridView1.Columns[1].Width = 70;
            dataGridView1.Columns[2].Width = 70;
            dataGridView1.Columns[3].Width = 70;
            dataGridView1.Columns[4].Width = 70;
            dataGridView1.Columns[5].Width = 70;
            dataGridView1.Columns[6].Width = 90;
            dataGridView1.RowCount = 6;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            double x = 0.001;
            const int N = 1000;
            for(int i = 1; i < N; i++)
            {
                double y = func(x);
                
                chart1.Series[0].Points.AddXY(x, y);
               
                x = x + 0.001;
            }
            for (int i = 1; i < 6; i++)
            {
                double y = fun2(x);

                chart1.Series[1].Points.AddXY( Convert.ToDouble(dataGridView1[1, i - 1].Value), Convert.ToDouble(dataGridView1[2, i - 1].Value));

                x = x + 0.001;
            }
        }
    }
}
