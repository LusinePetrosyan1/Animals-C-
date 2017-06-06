using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Calendar
    {
        public DateTime DateOfHire { get; set; }
        public double Duration { get; set; }
        public DateTime EndingDate { get; set; }
        public Calendar(DateTime dateOfHire, double duration)
        {
            DateOfHire = dateOfHire;
            Duration = duration;
            EndingDate = DateOfHire.AddDays(Duration);
        }
    }
}
