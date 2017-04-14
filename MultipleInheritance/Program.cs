using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 cl = new Class1();
            Console.WriteLine(cl.GetA());
            Interface1 i1 = cl;
            Interface2 i2 = cl;
            Console.WriteLine(i1.GetA());
            Console.WriteLine(i2.GetA());
            Console.WriteLine(cl.GetB());
        }
    }
}
