using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    internal class Rectangle : Shape
    {
        public readonly double Edge1;
        public readonly double Edge2;
        public readonly double Edge3;
        public readonly double Edge4;
        public Rectangle(double edge1, double edge2)
        { 
            Edge1 = edge1;
            Edge2 = edge2;
            Edge3 = edge1;
            Edge4 = edge2;
        }

        public override double CalculateArea()
        {
            double res = Edge1 * Edge2;
            return res;
        }
    }
}
