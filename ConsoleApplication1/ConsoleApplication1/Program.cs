using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1,2,1,2 };

            Console.WriteLine(almostIncreasingSequence(a));
        } 
        static bool almostIncreasingSequence(int[] sequence)
        {
            List<int> a = new List<int>();
            for (int i = 0; i < sequence.Length; i++)
            {
                a.Add(sequence[i]);

            }
            int k = 0;
            for (int i = 1; i < a.Count; i++)
            {
                if (a[i - 1] >= a[i])
                {
                    k++;
                    a.RemoveAt(i-1);
                    i--;
                }
                if (k > 1)
                {
                    return false;
                }
            }
            return true;

        }

    }
}
