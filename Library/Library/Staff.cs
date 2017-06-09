using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Staff:User
    {
        public Staff(string name, string surname, string login, string password, decimal money) : base(name, surname, login, password, money)
        {
        }

        public void ReturnBook(User user, Book Book)
        {
            foreach (BookSample bookS in user.BorrowedBooks)
            {
                if (bookS == Book.BookSample)
                {
                    Book.Quantity++;
                    user.BorrowedBooks.Remove(bookS);
                    if (bookS.Calendar.EndingDate < DateTime.Now)
                    {
                        int day = (int)(bookS.Calendar.DateOfBorrow - bookS.Calendar.EndingDate).TotalDays;
                        decimal Penalty = day * bookS.PenaltyCost;
                        user.Money -= Penalty;
                        Library.Capital += Penalty;
                    }
                }
            }
            if (Book.ReservedUser.Count != 0)
            {
                BookSample book = Book.BookSample;
                book.Calendar.DateOfBorrow = DateTime.Now;
                book.Calendar.EndingDate = DateTime.Now.AddDays(Book.Durations.Dequeue());
                Book.ReservedUser.Dequeue().BorrowedBooks.Add(book);
                Book.Quantity--;
            }
        }
    }
}
