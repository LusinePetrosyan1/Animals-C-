using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    public class Class1 : Interface1, Interface2
    {
        int Interface2.GetA()
        {
            return 2;
        }

        int Interface1.GetA()
        {
            return 1;
        }
        public int GetA() {

            return 3;
        }

        public int GetB()
        {
            return 4;
        }
    }
}
