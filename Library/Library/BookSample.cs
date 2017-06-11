using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Library
{
    [DataContract]
    public class BookSample
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Author { get; set; }
        [DataMember]
        public int Year { get; set; }
        [DataMember]
        public int NumberOfPages { get; set; }
        [DataMember]
        public List<string> Genre { get; set; }
        [DataMember]
        public Calendar Calendar { get; set; }
        [DataMember]
        public string Language { get; set; }
        [DataMember]
        public decimal Cost { get; set; }
        [DataMember]
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
