using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Json;

namespace Library
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Library lib1 = new Library("YSU", "Yerevan", "ysu.am", "516544");
            User us1 = new User("Aaa", "Vvv", "asd", "asdas", "user");
            Book b1 = new Book("sad","asd",50,1998,550,"asd",new List<string> {"com"},"eng");
            lib1.Users.Add(us1);
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(Library));
            using (FileStream str = new FileStream("Library.json", FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(str, lib1);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
