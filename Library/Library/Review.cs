using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Library
{
    [DataContract]
    public class Review
    {
        [DataMember]
        public User User { get; set; }
        [DataMember]
        public DateTime Date { get; set; }
        [DataMember]
        public string Opinion { get; set; }
        [DataMember]
        public int Rate { get; set; }


        public Review(User user, DateTime date, string opinion, int rate)
        {
            User = user;
            Date = date;
            Opinion = opinion;
            Rate = rate;

        }

        public override string ToString()
        {
            return (User + " " + '\n' + Date.ToShortDateString() + '\n' + Opinion + '\n' + Rate);
        }
    }
}
