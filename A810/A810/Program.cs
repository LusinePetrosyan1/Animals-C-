using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A810
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = Console.ReadLine().Split();
            int n = int.Parse(a[0]);
            int k = int.Parse(a[1]);
            string[] b = Console.ReadLine().Split();
            int[] c = new int[n];
            for (int i = 0; i <n; i++)
            {
                c[i] = int.Parse(b[i]);
            }
            int j = n;
            double d = 0;
            for (int i = 0; i <n; i++)
            {
                d += c[i];
            }
            int m = 0;
            double l = 0;
            if (Math.Round(d / n) == k)
            {
                Console.WriteLine(0);
                return;
            }
            else {
                m = k;
            }
            double res =0;
            while (res != k) {
                d += m;
                j++;
                l = d / j;
                string al = l + "";
               
                if ((al.Length>2 && al[2] == '5')) {
                    res = Math.Round(l+0.5);
                }
                else
                res = Math.Round(l);
                
            }
            Console.WriteLine(j-n);


           
        }
    }
}
