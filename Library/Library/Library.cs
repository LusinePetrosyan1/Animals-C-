using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Library
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Webpage { get; set; }
        public string PhoneNumber { get; set; }
        public string Mail { get; set; }
        public List<User> Staff { get; set; }
        public List<Book> Books { get; set; }
        public List<User> Users { get; set; }
        public List<Review> Reviews { get; set; }


        public Library(string name,string address,string webpage,string phoneNumber,string mail,List<User> staff,List<Book> books,List<User> users,List<Review> reviews) {
            Name = name;
            Address = address;
            Webpage = webpage;
            PhoneNumber = phoneNumber;
            Mail = mail;
            Staff = staff;
            Books = books;
            Users = users;
            Reviews = reviews;

        }
    }
}
