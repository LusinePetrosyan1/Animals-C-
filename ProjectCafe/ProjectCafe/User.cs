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
        public string Type { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public User(String name, String surname, int age, string mail, string type,string username, string password)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Mail = mail;
            favoriteCafes = new List<Cafe>();
            Type = type;
            Username = username;
            Password = password;
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