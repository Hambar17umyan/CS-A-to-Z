using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    internal class Circle : Shape
    {
        public double R;
        public Circle(double radius) 
        { 
            R = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(R, 2);
        }
    }
}
