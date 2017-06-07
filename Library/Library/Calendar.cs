using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Library
{
    [DataContract]
    class Calendar:IComparable<Calendar>
    {
        [DataMember]
        public DateTime DateOfBorrow { get; set; }
        [DataMember]
        public double Duration { get; set; }
        [DataMember]
        public DateTime EndingDate { get; set; }
        public Calendar(DateTime dateOfHire, double duration)
        {
            DateOfBorrow = dateOfHire;
            Duration = duration;
            EndingDate = DateOfBorrow.AddDays(Duration);
        }

        public int CompareTo (Calendar other)
        {
            if (EndingDate > other.EndingDate)
            {
                return 1;
            }
            else if (EndingDate < other.EndingDate)
            {
                return -1;
            }
            else
                return 0;
        }
    }
}
