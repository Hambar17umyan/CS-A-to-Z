using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    internal class Circle : IShape
    {
        public double R;

        public Circle(double r)
        {
            R = r;
        }
        public double CalculateArea()
        {
            return Math.PI * Math.Pow(R, 2);
        }
    }
}
