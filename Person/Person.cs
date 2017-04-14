using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparing
{
    class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Person(string name, DateTime dateOfBirth)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
        }
        public override string ToString()
        {
            return Name + " " + DateOfBirth;
        }

        public int CompareTo(Person other)
        {
            if (Name == other.Name)
                return DateOfBirth.CompareTo(other.DateOfBirth);
            return Name.CompareTo(other.Name);
        }
    }


}
