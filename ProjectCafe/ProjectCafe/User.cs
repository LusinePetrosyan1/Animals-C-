using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCafe
{
    class User
    {
        public String Name { get; set; }
        public String Surname { get; set; }
        public int Age { get; set; }
        public string Mail { get; set; }
        public List<Cafe> favoriteCafes;

        public User(String name, String surname, int age, string mail)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Mail = mail;
            favoriteCafes = new List<Cafe>();
        }
        public override string ToString()
        {
            return (Name + " " + Surname);
        }
        public void SaveCafe(Cafe cafe)
        {
            favoriteCafes.Add(cafe);
        }

        public void PrintFavoriteCafes()
        {
            for (int i = 0; i < favoriteCafes.Count; i++)
            {
                Console.WriteLine(favoriteCafes[i]);
                Console.WriteLine();
            }
            Console.WriteLine("_________________________________________________________________");
        }


    }
}