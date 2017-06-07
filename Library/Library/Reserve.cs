using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Reserve
    {
        public bool IsReserved { get; set; }
        public User UserReserve { get; set; }

        public Reserve(bool isReserved,User userReserve) {
            IsReserved = isReserved;
            userReserve = UserReserve;
        }

    }
}
