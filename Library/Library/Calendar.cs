using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Calendar
    {
        public DateTime DateOfBorrow { get; set; }
        public double Duration { get; set; }
        public DateTime EndingDate { get; set; }
        public Calendar(DateTime dateOfHire, double duration)
        {
            DateOfBorrow = dateOfHire;
            Duration = duration;
            EndingDate = DateOfBorrow.AddDays(Duration);
        }
    }
}
