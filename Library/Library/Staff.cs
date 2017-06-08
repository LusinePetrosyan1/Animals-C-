using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Staff:User
    {
        public Staff(string name, string surname, string login, string password, decimal money) : base(name, surname, login, password, money)
        {
        }
    }
}
