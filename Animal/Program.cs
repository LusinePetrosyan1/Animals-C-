using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = new Cat("Murzik");
            animal1.Speak();
            Console.WriteLine(animal1.Name);
            Console.WriteLine(animal1.Legs);

            Animal animal2 = new Dog("Sharik");
            animal2.Speak();


            Animal animal3 = new Bird("Tutak");
            animal3.Speak();

            Animal animal4 = new Lion("Simba");
            animal4.Speak();

        }
    }
}
