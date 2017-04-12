using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigureTester
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallelogram a = new Parallelogram(2,2, Math.PI);
            Console.WriteLine(a.Area());
            Console.WriteLine(a.Height());
            Console.WriteLine(a.Perimeter());
             
        }
    }
}
