using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Library
{
    [DataContract]
    class User
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Surname { get; set; }
        [DataMember]
        public string Login { get; set; }
        [DataMember]
        public string Password { get; set; }
        public List<BookSample> FavoriteBooks { get; set; }
        public List<BookSample> BorrowedBooks { get; set; }
        public List<BookSample> ReservedBooks { get; set; }
        public List<BookSample> HistoryBooks { get; set; }
        public decimal Money { get; set; }





        public User(string name, string surname, string login, string password, decimal money)
        {
            Name = name;
            Surname = surname;
            Login = login;
            Password = password;
            Money = money;
        }

      





    }
}
