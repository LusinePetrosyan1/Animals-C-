using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>()
            {
            new Person("John", DateTime.Today.AddYears(-15)),
            new Person("Alice",DateTime.Today.AddYears(-18)),
            new Person("Benjamin",DateTime.Today.AddYears(-21)),
            new Person("Benjamin",DateTime.Today.AddYears(-15))

        };
            persons.Sort();
            Console.Write(string.Join("\n ",persons));
        }
    }
}

