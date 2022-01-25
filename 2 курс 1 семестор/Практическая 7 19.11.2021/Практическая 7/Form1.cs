using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Практическая_7
{
    public partial class Form1 : Form
    {
        public struct person
        {
            public string FIO;
            public string ul;
            public int dom;
            public int kv;

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.RowCount = Convert.ToInt32(numericUpDown1.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                int n = Convert.ToInt32(numericUpDown1.Value);
                person[] mas = new person[n];
                for (int i = 0; i < n; i++)
                {
                    mas[i].FIO = dataGridView1[0, i].Value.ToString();
                    mas[i].ul = dataGridView1[1, i].Value.ToString();
                    mas[i].dom = Convert.ToInt32(dataGridView1[2, i].Value);
                    mas[i].kv = Convert.ToInt32(dataGridView1[3, i].Value);
                }
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName, true, System.Text.Encoding.Default);
                for (int i = 0; i < n; i++)
                {
                    sw.WriteLine(mas[i].FIO);
                    sw.WriteLine(mas[i].ul);
                    sw.WriteLine(mas[i].dom);
                    sw.WriteLine(mas[i].kv);
                }
                sw.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(numericUpDown1.Value);
            person[] mas = new person[n];
            for (int i = 0; i < n; i++)
            {
                mas[i].FIO = dataGridView1[0, i].Value.ToString();
                mas[i].ul = dataGridView1[1, i].Value.ToString();
                mas[i].dom = Convert.ToInt32(dataGridView1[2, i].Value);
                mas[i].kv = Convert.ToInt32(dataGridView1[3, i].Value);
            }
            if (checkBox1.Checked == true && checkBox2.Checked==true)
            {
                int max = 0;
                for(int i = 0;i<n;i++)
                {
                    if (max < mas[i].dom)
                    {
                        max = mas[i].dom;
                    }
                }
                int max2 = 0;
                for (int i = 0; i < n ; i++)
                {
                    if (max2 < mas[i].kv)
                    {
                        max2 = mas[i].kv;
                    }
                }
                MessageBox.Show("Дом с саммый большим номером:"+max+ "\r\n"+
                                "Квартира с самым большим номером"+max2);    
            }
            else if(checkBox1.Checked == true)
            {
                int max = 0;
                for (int i = 0; i < n; i++)
                {
                    if (max < mas[i].dom)
                    {
                        max = mas[i].dom;
                    }
                }
                MessageBox.Show("Дом с саммый большим номером:" + max);
            }
            else if(checkBox2.Checked == true)
            {
                int max = 0;
                for (int i = 0; i < n; i++)
                {
                    if (max < mas[i].kv)
                    {
                        max = mas[i].kv;
                    }
                }
                MessageBox.Show("Квартира с саммый большим номером:" + max);
            }

            

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                int n = Convert.ToInt32(numericUpDown1.Value);
                person[] mas = new person[n];
                for (int i = 0; i < n; i++)
                {
                    mas[i].FIO = dataGridView1[0, i].Value.ToString();
                    mas[i].ul = dataGridView1[1, i].Value.ToString();
                    mas[i].dom = Convert.ToInt32(dataGridView1[2, i].Value);
                    mas[i].kv = Convert.ToInt32(dataGridView1[3, i].Value);
                }
                StreamReader sr = new StreamReader(openFileDialog1.FileName,System.Text.Encoding.Default);
                int k = 0;
                while (!sr.EndOfStream)
                {
                    k++;
                    Array.Resize(ref mas, k);
                    mas[k - 1].FIO = sr.ReadLine();
                    mas[k - 1].ul = sr.ReadLine();
                    mas[k - 1].dom = Convert.ToInt32(sr.ReadLine());
                    mas[k - 1].kv = Convert.ToInt32(sr.ReadLine());
                }
                dataGridView1.RowCount = k;
                numericUpDown1.Value = k;
                sr.Close();
                for(int i = 0; i < k; i++)
                {
                    dataGridView1[0, i].Value = mas[i].FIO;
                    dataGridView1[1, i].Value = mas[i].ul;
                    dataGridView1[2, i].Value = mas[i].dom;
                    dataGridView1[3, i].Value = mas[i].kv;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(numericUpDown1.Value);
            person[] mas = new person[n];
            for (int i = 0; i < n; i++)
            {
                mas[i].FIO = dataGridView1[0, i].Value.ToString();
                mas[i].ul = dataGridView1[1, i].Value.ToString();
                mas[i].dom = Convert.ToInt32(dataGridView1[2, i].Value);
                mas[i].kv = Convert.ToInt32(dataGridView1[3, i].Value);
            }
            if(checkBox1.Checked == true && checkBox2.Checked == true)
            {
                int min = 11111110;
                for (int i = 0; i < n; i++)
                {
                    if (min> mas[i].dom)
                    {
                        min = mas[i].dom;
                    }
                    
                }
                int min2 = 1111110;
                for (int i = 0; i < n ; i++)
                {
                    if (min2 > mas[i].kv)
                    {
                        min2 = mas[i].kv;
                    }
                    
                }

                MessageBox.Show("Дом с минимальным номером:" + min + "\r\n" +
                                 "Квартира с мнимальным номером" + min2);
            }
            else if(checkBox1.Checked == true)
            {
                int min = 1111110;
                for (int i = 0; i < n; i++)
                {
                    if (min > mas[i].dom)
                    {
                        min = mas[i].dom;
                    }
                    
                }
                MessageBox.Show("Дом с минимальным номером:" + min);
            }
            else if(checkBox2.Checked == true)
            {
                int min2 = 100000;
                for (int i = 0; i < n; i++)
                {
                    if (min2 > mas[i].kv)
                    {
                        min2 = mas[i].kv;
                    }
                    
                }
                MessageBox.Show("Квартира  с минимальным номером:" + min2);
                

            }
        }
    }
}
