using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    interface IBookUser
    {
        string Name { get; set; }
        string Author { get; set; }
        int Date { get; set; }
        int NumberOfPages { get; set; }
        string Description { get; set; }
        List<string> Genre { get; set; }
        Finance Finance { get; set; }
        int index { get; set; }
    }
}
