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
        public List<IBookUser> FavoriteBooks { get; set; }
        public List<IBookUser> BorrowedBooks { get; set; }
        public List<IBookUser> ReservedBooks { get; set; }
        public List<IBookUser> HistoryOfBooks { get; set; }
        public Finance finance { get; set; }
        public bool HasPenalty { get; set; }



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

        public void BorrowBook(Book book) {
           

                IBookUser book1 = (IBookUser)book;
                BorrowedBooks.Add(book1);
                HistoryOfBooks.Add(book1);
                Guid guid = Guid.NewGuid();
                string uniqueID = guid.ToString();
                book.BookID.Add(uniqueID);
                book1.Index = book.BookID.Count - 1;
                book1.Calendar.DateOfBorrow = DateTime.Now;
                book1.Calendar.Duration = 0.008;
          
            
        }

        public void ReturnBook(Book book) {

        }
        public void ReserveBook(Book book) {
        }





    }
}
