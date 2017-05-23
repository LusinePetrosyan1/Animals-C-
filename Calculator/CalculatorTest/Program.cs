using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = Opera2.getValues("654157+324147", 6) ;
            List<String> b = Opera2.Separate("(21+4521)-(64+89)+45");
        }
    }
}
