using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigureTester
{
    class Triangle : IShape
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public double Area
        {
            get { return GetArea(); }
        }

        public Triangle(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
        }
        public double GetArea()
        {
            return -1;
        }

        public double GetPerimiter()
        {
            return A + B + C;
        }
    }
}
