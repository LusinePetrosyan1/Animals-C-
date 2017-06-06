using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Type { get; set; }
        public List<Book> FavoriteBooks { get; set; }
        public List<Book> BorrowedBooks { get; set; }
        public List<Book> ReservedBooks { get; set; }
        public List<Book> HistoryOfBooks { get; set; }
        public Finance finance { get; set; }


        public User(string name, string surname, string login, string password, string type)
        {
            Name = name;
            Surname = surname;
            Login = login;
            Password = password;
            Type = type;
        }

        public void PrintBorrowedBooks()
        {
            for (int i = 0; i < BorrowedBooks.Count; i++)
            {
                Console.WriteLine(i + 1 + "." + " " + BorrowedBooks[i].Name+" - "+BorrowedBooks[i].Author);
            }
        }

        public void PrintReservedBooks()
        {
            for (int i = 0; i < ReservedBooks.Count; i++)
            {
                Console.WriteLine(i + 1 + "." + " " + ReservedBooks[i].Name+" - "+ReservedBooks[i].Author);
            }
        }

        public void PrintFavoriteBooks()
        {
            for (int i = 0; i < FavoriteBooks.Count; i++)
            {
                Console.WriteLine(i + 1 + "." + " " + FavoriteBooks[i].Name +" - "+ FavoriteBooks[i].Author);
            }
        }

        public void AddFavoriteBook(Book book)
        {
            FavoriteBooks.Add(book);
        }
        public void PrintHistory() {
            for (int i = 0;  i<HistoryOfBooks.Count;i ++)
            {
                Console.WriteLine(i + 1 + "." + " " + HistoryOfBooks[i].Name + " - " + HistoryOfBooks[i].Author);
            }
        }
        public void AddReview(Review review) {

        }






    }
}
