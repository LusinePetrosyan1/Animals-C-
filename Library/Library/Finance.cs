using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Library
{
    [DataContract]
    class Finance:IBookFinance,IUserFinance
    {
        [DataMember]
        public decimal Money { get; set; }
        [DataMember]
        public decimal Penalty { get; set; }
        [DataMember]
        public decimal PenaltyCost { get; set; }
        public Finance(decimal money, decimal penalCost)
        {
            Money = money;
            PenaltyCost = penalCost;
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
            Penalty = (int)days * PenaltyCost;
        }
    }
}
