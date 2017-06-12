using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Library
{
    public class Library
    {
        public static List<Book> Books { get; set; }
        public static List<User> Users { get; set; }
        public static List<Staff> Staff { get; set; }
        public static List<User> UsersAndStaffs { get; set; }
        public static decimal Capital { get; set; }
        public static List<String> History { get; set; }
        public static List<Book> ReturnBooks { get; set; }
        public static List<User> ReturnUsers { get; set; }
       
        public Library()
        {
            
        }

       
    }

}
