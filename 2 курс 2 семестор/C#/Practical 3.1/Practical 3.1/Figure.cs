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
    class Figure
    {
        public int x, y, h, dx, dy;
        public PictureBox myPb;
  
        public bool t;
        public bool t0;
        public Color cl;



        public Figure(int n_x, int n_y, int n_h, PictureBox n_myPb, bool t1, bool t2, Color n_cl)
        {
            x = n_x;
            y = n_y;
            h = n_h;
            myPb = n_myPb;
            dx = 2;
            dy = 2;
            t = t1;
            t0 = t2;
            cl = n_cl;
        }

        public void Draw()
        {
            Graphics g = Graphics.FromImage(myPb.Image);
            SolidBrush sb = new SolidBrush(cl);
            Pen p = new Pen(Color.Red);
            p.Width = 5;
            g.FillRectangle(sb, 5 * x, 5 * y, h * 20,
                h * 20);
            g.DrawRectangle(p, 5 * x, 5 * y, h * 20, h * 20);
            Point p1 = new Point(5 * x, 5 * y);
            Point p2 = new Point(5 * x + (h) * 20, 5 * y + (h * 20));
            g.DrawLine(p, p1, p2);
            Point p3 = new Point(5 * x + (h) * 20, 5 * y);
            Point p4 = new Point(5 * x, 5 * y + (h) * 20);
            g.DrawLine(p, p3, p4);
            SolidBrush sb1 = new SolidBrush(Color.Green);
            g.FillEllipse(sb1, 5 * x + (h * 8), 5 * y + (h * 2), 4 * h, 4 * h);
            g.FillEllipse(sb1, 5 * x + (h * 8), 5 * y + (h * 14), 4 * h, 4 * h);
            myPb.Refresh();
        }

        public void Clear()
        {
            SolidBrush sb1 = new SolidBrush(Color.White);
            Graphics g = Graphics.FromImage(myPb.Image);
            g.FillRectangle(sb1, 0, 0, 1000, 1000);
        }
        public void Clear1()
        {
            SolidBrush sb1 = new SolidBrush(Color.White);
            Graphics g = Graphics.FromImage(myPb.Image);
            g.FillRectangle(sb1, x*5-3 , y*5-3 , h * 20+10, h * 20 + 6);
        }

        public void Move()
        {
            Clear1();
            Form2 f1 = new Form2();
            if (t == true)
            {
                x = x + dx;
                if (x > 75 || x < 0)
                {
                    dx = -dx;
                }
                x = x + dx;
            }
            else if (t0 == true)
            {
                y = y + dy;
                if (y > 85 || y < 0)
                {
                    dy = -dy;
                }
                y = y + dy;
            }
            else if (t0 == false && t == false)
            {

            }
            Draw();

        }
        public override string ToString()
        {
            return "Фигура h=" + h.ToString();
        }
    }
}
