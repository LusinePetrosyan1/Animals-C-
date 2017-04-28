using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCafe
{
    class Review
    {
        public User User { get; set; }
        public DateTime Date { get; set; }
        public string Opinion { get; set; }
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
            return (User + " " + '\n' + Date + '\n' + Opinion + '\n' + Rate +'\n');
        }
    }

}
