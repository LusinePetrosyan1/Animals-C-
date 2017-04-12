using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    abstract class Animal
    {
        public string Name { get; set; }
        public abstract int Legs { get; }
        public abstract void Speak();

        public Animal(string name)
        {
            Name = name;

        }

    }
    class Cat : Animal
    {
        public Cat(string name) : base(name)
        {

        }
        public override int Legs
        {
            get { return 4; }
        }

        public override void Speak()
        {
            Console.WriteLine("Myau");
        }
    }
    class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
        }
        public override int Legs
        {
            get { return 4; }

        }

        public override void Speak()
        {
            Console.WriteLine("Gav");
        }
    }

    class Bird : Animal
    {
        public Bird(string name) : base(name)
        {

        }

        public override int Legs
        {
            get { return 2; }
        }

        public override void Speak()
        {
            Console.WriteLine("Uu");
        }
    }
    class Lion : Animal
    {
        public Lion(string name) : base(name)
        {

        }

        public override int Legs
        {
            get { return 4; }
        }

        public override void Speak()
        {
            Console.WriteLine("Rrr");
        }
    }


}

