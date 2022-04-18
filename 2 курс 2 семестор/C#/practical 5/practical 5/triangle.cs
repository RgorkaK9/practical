using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_5
{
    class triangle:parents
    {
        public double h;

        public triangle(double new_h, double new_a) : base(new_a)
        {
            h = new_h;
        }
        public override double S()
        {
            return h/2*a;
        }

        public override string ToString()
        {
            return "Треугольник h=" + h + "a=" + a;
        }
    }
}
