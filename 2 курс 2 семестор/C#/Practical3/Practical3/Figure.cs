using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical3
{
    class Figure
    {
        int x, y, h;
        PictureBox myPb;

        public Figure(int n_x, int n_y, int n_h, PictureBox n_myPb)
        {
            x = n_x;
            y = n_y;
            h = n_h;
            myPb = n_myPb;
        } 

        public void Draw()
        {
            //myPb.Image = new Bitmap(myPb.Width, myPb.Height);
            Graphics g = Graphics.FromImage(myPb.Image);
            SolidBrush sb = new SolidBrush(Color.Blue);
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


        public override string ToString()
        {
            return "Фигура h="+ h.ToString();
        }






    }
}
