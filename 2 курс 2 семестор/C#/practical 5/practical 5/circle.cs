using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_5
{
    class circle : parents
    {
        public circle(double new_a) : base(new_a)
        {

        }
        public override double S()
        {
            return Math.PI * Math.Pow(a, 2);
        }
        public override string ToString()
        {
            return "Окружность R=" + a;
        }
    }
}
