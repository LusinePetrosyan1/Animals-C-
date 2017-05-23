using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTest
{
    class Operations
    {
        //public string Solve(string express)
        //{
        //    if (express.Contains("×"))
        //    {
        //        int k = express.IndexOf("×");
        //        string[] values = getValues(express, k);
        //    }
        //}
        public static string[] getValues(string express, int index)
        {
            string[] output = new string[2];
            char left=express[index-1];
            char right = express[index + 1];
            String leftvalue = "";
            String rightvalue = "";
            string nums="0123456789";
            int k=2;
            while (nums.Contains("" + left) && index-k>=0)
            {
                leftvalue = left + leftvalue;
                left = express[index - k];
                k++;
            }
            leftvalue = left + leftvalue;
            k = 2;
            while (nums.Contains("" + right)&& index+k<express.Length)
            {
                rightvalue =rightvalue+right;
                right = express[index + k];
                k++;
            }
            rightvalue = rightvalue + right;
            output[0] = leftvalue;
            output[1] = rightvalue;
            return output;
        }
    }
}
