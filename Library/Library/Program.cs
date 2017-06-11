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
            //Library lib1 = new Library("YSU", "Yerevan", "ysu.am", "516544");
            //User us1 = new User("Aaa", "Vvv", "asd", "asdas", "user");
            //Book b1 = new Book("sad","asd",50,1998,550,"asd",new List<string> {"com"},"eng");
            //lib1.Users.Add(us1);
            //DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(Library));
            //using (FileStream str = new FileStream("Library.json", FileMode.OpenOrCreate))
            //{
            //    jsonFormatter.WriteObject(str, lib1);
            //}
            Library.Users = new List<User>();
            Library.Books = new List<Book>();
            Library.ReturnBooks = new List<Book>();
            Library.ReturnUsers = new List<User>();
            BookSample bs1 = new BookSample("Jane Eyre", "Charlotte Bronte", 1887, 544, new List<String> { "Novel" }, "eng", 5, 10);
            BookSample bs2 = new BookSample("Wuthering Heights", "Emily Bronte", 1910, 125, new List<String> { "Novel" }, "eng", 6, 11);
            BookSample bs3 = new BookSample("Cathcher in the Rye", "J.D. Salinger", 1987, 241, new List<String> { "Realistic fiction", "Coming-of-age fiction" }, "eng", 5, 15);
            BookSample bs4 = new BookSample("The Godfather", "Mario Puzo", 1914, 617, new List<String> { "Crime Novel" }, "eng", 10, 15);
            BookSample bs5 = new BookSample("The Gadfly", "Ethel Voynich", 1897, 154, new List<String> { "Novel" }, "eng", 5, 11);
            BookSample bs6 = new BookSample("Theatre", "Somerset Maugham", 1937, 741, new List<String> { "Novel" }, "eng", 6, 13);
            BookSample bs7 = new BookSample("Harry Potter and the Chamber of Secrets", "J.K.Rowling", 1875, 351, new List<String> { "Fantasy" }, "eng", 10, 13);
            BookSample bs8 = new BookSample("The Murder on the Links", "Agatha Christie", 1874, 150, new List<String> { "Crime novel" }, "eng", 11, 30);
            BookSample bs9 = new BookSample("The Lost World", "Conan Doyle", 1895, 110, new List<String> { "Fantasy novel", "Lost world" }, "eng", 9, 15);
            BookSample bs10 = new BookSample("Fight Club", "Chuck Palahniuk", 1947, 421, new List<String> { "Satirical novel" }, "eng", 10, 15);
            BookSample bs11 = new BookSample("Jonathan Livingston Seagull", "Richard Bach", 1987, 311, new List<String> { "Spiritual", "self-help", "novella" }, "eng", 10, 15);
            BookSample bs12 = new BookSample("The Moon and Sixpence", "Somerset Maugham", 1947, 574, new List<String> { "Biographical novel" }, "eng", 14, 17);
            BookSample bs13 = new BookSample("Teddy", "J.D. Salinger", 1981, 31, new List<String> { "Short story" }, "eng", 4, 7);
            BookSample bs14 = new BookSample("Just Before the War with the Eskimos", "J.D. Salinger", 1987, 24, new List<String> { "Short story" }, "eng", 4, 7);
            BookSample bs15 = new BookSample("The Da Vinci Code", "Dan Brown", 2001, 645, new List<String> { "Mystery", "Detective fiction", "Conspiracy fiction", "Thriller" }, "eng", 15, 30);
            Book book1 = new Book(bs1, 3);
            Book book2 = new Book(bs2, 3);
            Book book3 = new Book(bs3, 3);
            Book book4 = new Book(bs4, 3);
            Book book5 = new Book(bs5, 3);
            Book book6 = new Book(bs6, 3);
            Book book7 = new Book(bs7, 3);
            Book book8 = new Book(bs8, 3);
            Book book9 = new Book(bs9, 3);
            Book book10 = new Book(bs10, 3);
            Book book11 = new Book(bs11, 3);
            Book book12 = new Book(bs12, 3);
            Book book13 = new Book(bs13, 3);
            Book book14 = new Book(bs14, 3);
            Book book15 = new Book(bs15, 3);
            Library.Books = new List<Book> {book1,book2,book3,book4,book5,book6,book7,book8,book9,book10,book11,book12,book13,book14,book15};
            Library.ReturnBooks = new List<Book> { book12 };



            Library.Books.Add(new Book(bs1, 3));
            Library.Users.Add(new User("name", "surname", "login", "password", 100));
            Library.Users.Add(new Staff("Khacho", "Khechoyan", "khachatur98", "Sagatelovich", 0));
            Library.ReturnUsers.Add(Library.Users[0]);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
