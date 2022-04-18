using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_5
{
    class rentangl:parents
    {
        public double b;
        public rentangl(double new_a, double new_b) : base(new_a)
        {
            b = new_b;
        }

        public override double S()
        {
            return a * b;
        }
        public override string ToString()
        {
            return "Прямоугольник a=" + a + "b=" + b;
        }
    }
}
