using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_5
{
    abstract class parents
    {
        public double a;

        public parents(double new_a)
        {
            a = new_a;
        }

        abstract public double S();

    }
}
