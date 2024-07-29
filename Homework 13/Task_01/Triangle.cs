using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    internal class Triangle : IShape
    {
        public double Segment1;
        public double Segment2; 
        public double Segment3;

        private double _p;

        public Triangle(double segment1, double segment2, double segment3)
        {
            Segment1 = segment1;
            Segment2 = segment2;
            Segment3 = segment3;
            _p = (segment1 + segment2 + segment3) / 2;
        }
        public double CalculateArea()
        {
            return Math.Sqrt((_p - Segment1) * (_p - Segment2) * (_p - Segment3) * _p);
        }
    }
}
