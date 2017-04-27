using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCafe
{
    class Open_Close
    {
        
        public string[] Open { get; set; }
        public string[] Close { get; set; }

        public Open_Close(string[] open, string[] close)
        {
            for (int i = 0; i < 7; i++)
            {
                Open[i] = open[i];
                Close[i] = close[i];
            }
        }
        enum DaysOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday,
        }
    }

}
