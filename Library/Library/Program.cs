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
           

            Library.History = new List<string>();
            Library.Users = new List<User>();
            Library.Books = new List<Book>();
            Library.ReturnBooks = new List<Book>();
            Library.ReturnUsers = new List<User>();
            Library.Staff= new List<Staff>();
            Library.UsersAndStaffs= new List<User>();
            

            //DESERIALIZATION
            DataContractJsonSerializer jsonFormatter2 = new DataContractJsonSerializer(typeof(List<User>));
            FileStream str2 = new FileStream("Users.json", FileMode.Open);
            Library.Users = (List<User>)jsonFormatter2.ReadObject(str2);
            str2.Close();

            jsonFormatter2 = new DataContractJsonSerializer(typeof(List<Book>));
            str2 = new FileStream("Books.json", FileMode.Open);
            Library.Books = (List<Book>)jsonFormatter2.ReadObject(str2);
            str2.Close();

            jsonFormatter2 = new DataContractJsonSerializer(typeof(List<Staff>));
            str2 = new FileStream("Staff.json", FileMode.Open);
            Library.Staff = (List<Staff>)jsonFormatter2.ReadObject(str2);
            str2.Close();

            jsonFormatter2 = new DataContractJsonSerializer(typeof(List<String>));
            str2 = new FileStream("History.json", FileMode.Open);
            Library.History = (List<String>)jsonFormatter2.ReadObject(str2);
            str2.Close();

            jsonFormatter2 = new DataContractJsonSerializer(typeof(List<Book>));
            str2 = new FileStream("ReturnBooks.json", FileMode.Open);
            Library.ReturnBooks = (List<Book>)jsonFormatter2.ReadObject(str2);
            str2.Close();

            jsonFormatter2 = new DataContractJsonSerializer(typeof(List<User>));
            str2 = new FileStream("ReturnUsers.json", FileMode.Open);
            Library.ReturnUsers = (List<User>)jsonFormatter2.ReadObject(str2);
            str2.Close();

            
            foreach (Staff Staffs in Library.Staff)
            {
                Library.UsersAndStaffs.Add(Staffs);
            }
            foreach (User users in Library.Users)
            {
                Library.UsersAndStaffs.Add(users);
            }


            //Library.Users[0].BorrowedBooks=new List<BookSample>();
            //Library.Users[0].HistoryBooks = new List<BookSample>();
            //Library.Users[0].ReservedBooks = new List<BookSample>();
            //Library.ReturnBooks=new List<Book>();
            //Library.ReturnUsers = new List<User>();
            //Library.History = new List<string>();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Book>));
            using (FileStream str = new FileStream("Books.json", FileMode.OpenOrCreate))
            {
                str.SetLength(0);
                jsonFormatter.WriteObject(str, Library.Books);
            }
            jsonFormatter = new DataContractJsonSerializer(typeof(List<User>));
            using (FileStream str = new FileStream("Users.json", FileMode.OpenOrCreate))
            {
                str.SetLength(0);
                jsonFormatter.WriteObject(str, Library.Users);
            }
            jsonFormatter = new DataContractJsonSerializer(typeof(List<Staff>));
            using (FileStream str = new FileStream("Staff.json", FileMode.OpenOrCreate))
            {
                str.SetLength(0);
                jsonFormatter.WriteObject(str, Library.Staff);
            }
            jsonFormatter = new DataContractJsonSerializer(typeof(List<String>));
            using (FileStream str = new FileStream("History.json", FileMode.OpenOrCreate))
            {
                str.SetLength(0);
                jsonFormatter.WriteObject(str, Library.History);
            }
            jsonFormatter = new DataContractJsonSerializer(typeof(List<Book>));
            using (FileStream str = new FileStream("ReturnBooks.json", FileMode.OpenOrCreate))
            {
                str.SetLength(0);
                jsonFormatter.WriteObject(str, Library.ReturnBooks);
            }
            jsonFormatter = new DataContractJsonSerializer(typeof(List<User>));
            using (FileStream str = new FileStream("ReturnUsers.json", FileMode.OpenOrCreate))
            {
                str.SetLength(0);
                jsonFormatter.WriteObject(str, Library.ReturnUsers);
            }
        }
    }
}
