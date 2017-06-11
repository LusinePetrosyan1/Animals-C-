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
        [DataMember]
        public BookSample BookSample { get; set; }
        [DataMember]
        public int Quantity { get; set; }
        [DataMember]
        public Queue<User> ReservedUser { get; set; }
        [DataMember]
        public Queue<int> Durations { get; set; }
        [DataMember]
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
            double d = a / ReviewList.Count;
            d *= 10;
            int bc= (int)d;
            double c =(double) bc / 10;
            if (ReviewList.Count == 0) {
                c = 0;
            }
            return c;
        }
    }
}
