using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    interface IBookFinance
    {
        decimal Money { get; set; }
        decimal PenaltyCost { get; set; }
        decimal Penalty { get; set; }
        void AddPenalty(double days);
    }
}
