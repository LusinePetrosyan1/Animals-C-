using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTest
{
    class Opera2
    {
        public string Solve(string express)
        {
            string answer="" ;
            if (express.Contains("×"))
            {
                int k = express.IndexOf("×");
                string[] values = getValues(express, k);
                 answer= ""+Int32.Parse(values[0])*Int32.Parse(values[1]);
            }
            else if (express.Contains("÷"))
            {
                int k = express.IndexOf("÷");
                string[] values = getValues(express, k);
                if (values[1] == "0")
                {
                    throw new DivideByZeroException();
                }
                else
                {
                    answer= "" + Int32.Parse(values[0]) / Int32.Parse(values[1]);
                }
            }
            else if (express.Contains("%"))
            {
                int k = express.IndexOf("%");
                string[] values = getValues(express, k);
                answer = "" + Int32.Parse(values[0]) * Int32.Parse(values[1]);
            }
            return answer;
        }
        public static string[] getValues(string express, int index)
        {
            string[] output = new string[2];
            char left = express[index - 1];
            char right = express[index + 1];
            String leftvalue = "";
            String rightvalue = "";
            string nums = "0123456789";
            int k = 2;
            while (nums.Contains("" + left) && index - k >= 0)
            {
                leftvalue = left + leftvalue;
                left = express[index - k];
                k++;
            }
            leftvalue = left + leftvalue;
            k = 2;
            while (nums.Contains("" + right) && index + k < express.Length)
            {
                rightvalue = rightvalue + right;
                right = express[index + k];
                k++;
            }
            rightvalue = rightvalue + right;
            output[0] = leftvalue;
            output[1] = rightvalue;
            return output;
        }
        public static List<String> Separate(string a)
        {
            List<String> b = new List<string>();
            int j = 0;
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == '(')
                {
                    stack.Push(i);
                }
                else if (a[i] == ')')
                {
                    int start = stack.Pop();
                    int length = -start + i + 1;
                    b.Add(a.Substring(start, length));
                    j++;

                }
            }
            return b;
        }
    }
}
