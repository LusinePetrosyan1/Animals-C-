using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Library
{
    [DataContract]
    public class Book
    {
        public BookSample BookSample { get; set; }
        public int Quantity { get; set; }
        public Queue<User> ReservedUser { get; set; }
        public Queue<int> Durations { get; set; }
        public List<Review> ReviewList { get; set; }

        public Book(BookSample bookSample, int quantity)
        {
            BookSample = bookSample;
            Quantity = quantity;
            ReviewList = new List<Review>();
            ReservedUser = new Queue<User>();
            Durations = new Queue<int>();
        }

        public void AddReview(Review rev)
        {
            ReviewList.Add(rev);
        }

        public double AverageRate()
        {
            double a = 0;
            for (int i = 0; i < ReviewList.Count; i++)
            {
                a += ReviewList[i].Rate;
            }
            return a / ReviewList.Count;
        }
    }
}
