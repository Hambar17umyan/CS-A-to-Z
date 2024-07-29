using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    internal class Rectangle : IShape
    {
        public double Width;
        public double Length;

        public Rectangle(double width, double length)
        {
            Width = width;
            Length = length;
        }
        public double CalculateArea()
        {
            return Width * Length;
        }
    }
}
