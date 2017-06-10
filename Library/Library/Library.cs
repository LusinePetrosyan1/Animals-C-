using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Library
{
    [DataContract]
    public class Library
    {
        public static List<Book> Books { get; set; }
        public static List<User> Users { get; set; }
        public static decimal Capital { get; set; }
        public static List<String> History { get; set; }

        public Library()
        {

        }

        public void PrintHistory()
        {
            for (int i = 0; i < History.Count; i++)
            {
                Console.WriteLine(History[i]);
            }

        }
    }

}
