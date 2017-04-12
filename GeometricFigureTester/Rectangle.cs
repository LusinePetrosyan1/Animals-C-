using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigureTester
{
    class Rectangle : GeometricFigure
    {
        private int Length { get; set; }
        private int Width { get; set; }
        public Rectangle()
        {

        }
        public override int GetArea()
        {
            return Length * Width;
        }

        public override int GetPerimiter()
        {
            return 2 * (Length + Width);
        }
    }
}
