using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Library
{
    [DataContract]
    class Book : IBookUser, IBookLib
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Author { get; set; }
        [DataMember]
        public int Quantity { get; set; }
        [DataMember]
        public int Date { get; set; }
        [DataMember]
        public int NumberOfPages { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public List<string> Genre { get; set; }
        [DataMember]
        public List<Review> ReviewsBook { get; set; }
        [DataMember]
        public Finance Finance { get; set; }
        [DataMember]
        public List<string> BookID { get; set; }
        [DataMember]
        public int Index { get; set; }
        [DataMember]
        public string Language { get; set; }
        [DataMember]
        public Calendar Calendar { get; set; }
        public Reserve Reserve { get; set; }

        public Book(string name, string author, int quantity, int date, int numberOfPages, string description, List<String> genre, string language)
        {
            Name = name;
            Author = author;
            Quantity = quantity;
            Date = date;
            NumberOfPages = numberOfPages;
            Description = description;
            Genre = genre;
            Language = language;
            BookID = new List<string>();
        }

        public void AddReview(Review review)
        {
            ReviewsBook.Add(review);
        }
    }
}
