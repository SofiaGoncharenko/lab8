using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z3
{
    class Methods
    {
        public double Square(double r)
        {
            return Math.PI * Math.Pow(r, 2);
        }
        public double Perimetr(double r)
        {
            return 2 * Math.PI * r;
        }
        public double Volume(double r)
        {
            return (4 / 3) * Math.PI * Math.Pow(r, 3);
        }
    }
}
