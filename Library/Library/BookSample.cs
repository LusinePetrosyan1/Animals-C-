using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{ public class BookSample
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public int NumberOfPages { get; set; }
        public List<string> Genre { get; set; }
        public Calendar Calendar { get; set; }
        public string Language { get; set; }
        public decimal Cost { get; set; }
        public decimal PenaltyCost { get; set; }


        public BookSample(string name, string author, int year, int numberOfPages, List<string> genre, string language, decimal cost, decimal penaltyCost)
        {
            Name = name;
            Author = author;
            Year = year;
            NumberOfPages = numberOfPages;
            Genre = genre;
            Language = language;
            Cost = cost;
            PenaltyCost = penaltyCost;
        }

        public override string ToString()
        {
            return Name + " - " + Author + " " + Year;
        }


    }
}
