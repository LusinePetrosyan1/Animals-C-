using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Library
{
    [DataContract]
  public class Calendar : IComparable<Calendar>
    {
        [DataMember]
        public DateTime DateOfBorrow { get; set; }
        [DataMember]
        public DateTime EndingDate { get; set; }
        public Calendar(DateTime dateOfHire, DateTime endingDate)
        {
            DateOfBorrow = dateOfHire;
            EndingDate = endingDate;
        }

        public int CompareTo(Calendar other)
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
