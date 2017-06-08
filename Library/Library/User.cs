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
        [DataMember]
        public string Type { get; set; }
        [DataMember]
        public List<IBookUser> FavoriteBooks { get; set; }
        [DataMember]
        public List<IBookUser> BorrowedBooks { get; set; }
        [DataMember]
        public List<IBookUser> ReservedBooks { get; set; }
        [DataMember]
        public List<IBookUser> HistoryOfBooks { get; set; }
        [DataMember]
        public IUserFinance finance { get; set; }
        [DataMember]
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
            for (int i = 0;  i< HistoryOfBooks.Count;i ++)
            {
                Console.WriteLine(i + 1 + "." + " " + HistoryOfBooks[i].Name + " - " + HistoryOfBooks[i].Author);
            }
        }

        public void BorrowBook(Book book) {

                IBookUser book1 = book;
                BorrowedBooks.Add(book1);
                HistoryOfBooks.Add(book1);
                Guid guid = Guid.NewGuid();
                string uniqueID = guid.ToString();
                book.BookID.Add(uniqueID);
                book1.Index = book.BookID.Count - 1;
                book1.Calendar.DateOfBorrow = DateTime.Now;
                book1.Calendar.Duration = 0.008;
                book.Quantity--;
                book.BorrowedBooks.Add(book1);
        }

        public void ReturnBook(Book book,string key ) {
            decimal penalty = (DateTime.Now.Day - book.Calendar.EndingDate.Day)*book.Finance.PenaltyCost;
            finance.Money -= penalty;
           

        }
        public void ReserveBook(Book book) {
            for (int i = 0; i <book.Quantity ; i++)
            {

            }

        }





    }
}
