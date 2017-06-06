using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int Quantity { get; set; }
        public int Date { get; set; }
        public int NumberOfPages { get; set; }
        public string Description { get; set; }
        public List<string> Genre { get; set; }
        public List<Review> ReviewsBook { get; set; }
        public Finance Finance { get; set; }
        public List<string> BookID;
        public string Language  { get; set; }

        public Book(string name,string author,int quantity,int date,int numberOfPages,string description,List<String> genre,List<Review> reviewsBook,string language){
            Name = name;
            Author = author;
            Quantity = quantity;
            Date = date;
            NumberOfPages = numberOfPages;
            Description = description;
            Genre = genre;
            ReviewsBook = reviewsBook;
            Language = language;
            BookID = new List<string>();
        }

        public void AddReview(Review review) {
            ReviewsBook.Add(review);
        }
    }
}
