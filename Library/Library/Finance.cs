using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Finance:IBookFinance,IUserFinance
    {
        public decimal Money { get; set; }
        public decimal Penalty { get; set; }
        public decimal PenaltyCoast { get; set; }
        public Finance(decimal money, decimal penalCoast)
        {
            Money = money;
            PenaltyCoast = penalCoast;
        }
        public Finance(decimal money)
        {
            Money = money;
            Penalty = 0;
        }
        public void AddMoney(decimal money){
            Money+=money;
        }
        public void AddPenalty(double days)
        {
            Penalty = (int)days * PenaltyCoast;
        }
    }
}
