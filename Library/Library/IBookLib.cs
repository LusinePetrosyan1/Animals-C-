using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    interface IBookLib
    {
        string Name { get; set; }
        string Author { get; set; }
        int Quantity { get; set; }
        int Date { get; set; }
        int NumberOfPages { get; set; }
        string Description { get; set; }
        List<string> Genre { get; set; }
        string Language { get; set; }
        List<Review> ReviewsBook { get; set; }
        Finance Finance { get; set; }
        List<string> BookID { get; set; }
    }
}
