using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfWeek
{
    class Program_DayOfWeek
    {
        static void Main(string[] args)
        {
            DayOfWeek day1 = DayOfWeek.Friday;
            DayOfWeek day2 = DayOfWeek.Saturday;
            int a = 2;
            PrintAllEnumValues();
        }
        static void Print(DayOfWeek day)
        {
            switch (day)
            {
                case DayOfWeek.Friday:
                    Console.WriteLine("youhou");
                    break;
                default:
                    Console.WriteLine("Oooo");
                    break;

            }
        }
        static void PrintAllEnumValues()
        {
            string[] enumNames=Enum.GetNames(typeof(DayOfWeek));
            for (int i = 0; i < enumNames.Length; i++)
            {
                DayOfWeek day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek),enumNames[i]);
                Console.WriteLine(enumNames[i]+" "+ day);
            }

    }
    }
}
