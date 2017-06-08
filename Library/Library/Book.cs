using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Library
{
    [DataContract]
    class Book
    {
        public BookSample BookSample { get; set; }
        public int Quantity { get; set; }
        public Queue<User> ReservedUser { get; set; }
        public Queue<DateTime> EndingDates { get; set; }
        public List<Review> ReviewList { get; set; }

        public Book(BookSample bookSample, int quantity, List<Review> reviewList, Queue<User> reservedUser)
        {
            BookSample = bookSample;
            Quantity = quantity;
            ReviewList = reviewList;
            ReservedUser = reservedUser;
        }

        public void AddReview(Review rev)
        {
            ReviewList.Add(rev);
        }
    }
}
