using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigureTester
{
    class Rectangle : IShape
    {
        private int Length { get; set; }
        private int Width { get; set; }

        public double Area
        {
            get
            {
                return GetArea();
            }
        }
        public double GetArea()
        {
            return Length * Width;
        }

        public double GetPerimiter()
        {
            return 2 * (Length + Width);
        }


    }
}
