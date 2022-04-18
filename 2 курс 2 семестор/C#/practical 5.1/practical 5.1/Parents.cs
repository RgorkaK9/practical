using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_5._1
{
     abstract class Parents
    {
        public double a;
        public Parents(double new_a)
        {
            a = new_a;
        }
        abstract public  double S();
    }
}
