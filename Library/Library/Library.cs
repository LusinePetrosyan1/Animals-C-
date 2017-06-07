using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Library
{
    [DataContract]
    class Library
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public string Webpage { get; set; }
        [DataMember]
        public string PhoneNumber { get; set; }
        [DataMember]
        public List<User> Staff { get; set; }
        [DataMember]
        public static List<Book> Books { get; set; }
        [DataMember]
        public List<User> Users { get; set; }
        [DataMember]
        public List<Review> Reviews { get; set; }


        public Library(string name,string address,string webpage,string phoneNumber) {
            Name = name;
            Address = address;
            Webpage = webpage;
            PhoneNumber = phoneNumber;
            Staff = new List<User>();
            Books =new List<Book>();
            Users = new List<User>();
            Reviews =new List<Review>();


        }
    }
}
