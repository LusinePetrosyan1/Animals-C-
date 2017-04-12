using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject
{
    public class Person
    {
        protected DateTime dateOfBirth;
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Passport { get; set; }

        public Person(string firstName, string lastName,DateTime dateOfBirth, string passport)
        {
            FirstName = firstName;
            LastName = lastName;
            this.dateOfBirth = dateOfBirth;
            Passport = passport;
        }
        public override string ToString()
        {
            String information = "";
            information = FirstName + " " + LastName + " " + dateOfBirth + " " + GetEmploymentStatus();
            return information;
        }
        public virtual string GetEmploymentStatus()
        {
            return "Unemployed";
        }
       
    }
}
