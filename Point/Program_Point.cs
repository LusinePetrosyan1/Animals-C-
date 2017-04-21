using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    class Program_Point
    {
        static void Main(string[] args)
        {
            Point point = new Point(1, 2);
            ChangeX(point);
            Console.WriteLine(point.X+" "+ point.Y);

            PointStruct pointstruct = new PointStruct(1,2);
            ChangeX(pointstruct);
            Console.WriteLine(pointstruct.X );

        }
        static void ChangeX(Point p)
        {
            p.X = 5;
        }
        static void ChangeX(PointStruct p)
        {
            p.X = 5;
        }
    }
}
