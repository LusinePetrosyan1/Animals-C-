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
        public List<Cafe> favoriteCafes;
        public User(String name, String surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
            favoriteCafes = new List<Cafe>();
        }
        public override string ToString()
        {
            return (Name + " " + Surname + " " + Age);
        }
        public void SaveCafe(Cafe cafe)
        {
            favoriteCafes.Add(cafe);
        }
        public void AddNewReview(Review rev, Cafe cafe)
        {
            cafe.Reviews.Add(rev);

        }

    }
}