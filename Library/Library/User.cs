﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Library
{
    [DataContract]
    public class User
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
        public List<BookSample> FavoriteBooks { get; set; }
        [DataMember]
        public List<BookSample> BorrowedBooks { get; set; }
        [DataMember]
        public List<BookSample> ReservedBooks { get; set; }
        [DataMember]
        public List<BookSample> HistoryBooks { get; set; }
        [DataMember]
        public decimal Money { get; set; }

        public User(string name, string surname, string login, string password, decimal money)
        {
            Name = name;
            Surname = surname;
            Login = login;
            Password = password;
            Money = money;
            FavoriteBooks = new List<BookSample>();
            BorrowedBooks = new List<BookSample>();
            ReservedBooks = new List<BookSample>();
            HistoryBooks = new List<BookSample>();
        }

        public void BorrowBook(Book book, DateTime endingDate)
        {
            book.Quantity--;
            BookSample book1 = book.BookSample;
            DateTime a = DateTime.Now;
            DateTime b = endingDate;
            Calendar calendar = new Calendar(a, b);
            book1.Calendar = calendar;
            BorrowedBooks.Add(book1);
            decimal m = (decimal)(b - a).TotalDays;
            m=((decimal)(int)(100*m))/100;
            HistoryBooks.Add(book1);
            Money -= book1.Cost * m;
            Library.Capital += book1.Cost * m;
            string history = book1.Name + " - " +  book1.Author + " - " + Login + " - "+ book1.Calendar.DateOfBorrow.ToShortDateString() +" - "+ book1.Calendar.EndingDate.ToShortDateString();
            Library.History.Add(history);
        }
        public void Reserve(Book book, int duration)
        {
            book.ReservedUser.Enqueue(this);
            book.Durations.Enqueue(duration);
            Money -= duration * book.BookSample.Cost;
            Library.Capital += duration * book.BookSample.Cost;
            ReservedBooks.Add(book.BookSample);
        }
        public void AddFavoriteBooks(Book book)
        {
            BookSample book1 = book.BookSample;
            FavoriteBooks.Add(book1);
        }

        public void PrintFavoriteBooks()
        {
            BookSearchForm a = new BookSearchForm(FavoriteBooks, this);
            a.ShowDialog();
        }
        public void PrintBorrowedBooks()
        {
            BookSearchForm a = new BookSearchForm(BorrowedBooks, this);
            a.ShowDialog();
        }
        public void PrintHistoryOfBorrowedBooks()
        {
            BookSearchForm a = new BookSearchForm(HistoryBooks, this);
            a.ShowDialog();
        }
        public void PrintReservedBooks()
        {
            BookSearchForm a = new BookSearchForm(ReservedBooks, this);
            a.ShowDialog();
        }




    }
}
