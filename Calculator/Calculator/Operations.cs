using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Operations
    {
        public static string Solve(string express)
        {
            string answer = "";
            while (express.Contains("×"))
            {
                int k = express.IndexOf("×");
                string[] values = getValues(express, k);
                string then =values[0]+"×"+values[1];
                answer = "" + Double.Parse(values[0]) * Int32.Parse(values[1]);
                express.Replace(then,answer);
            }
            while (express.Contains("÷"))
            {
                int k = express.IndexOf("÷");
                string[] values = getValues(express, k);
                string then =values[0]+"÷"+values[1];

                if (values[1] == "0")
                {
                    throw new DivideByZeroException();
                }
                else
                {
                    answer = "" + Double.Parse(values[0]) / Int32.Parse(values[1]);
                    express.Replace(then,answer);
                }
            }
            while (express.Contains("%"))
            {
                int k = express.IndexOf("%");
                string[] values = getValues(express, k);
                string then =values[0]+"%"+values[1];
                answer = "" + Int32.Parse(values[0]) * Int32.Parse(values[1]);
                express.Replace(then,answer);
            }
            while (express.Contains('+'))
            {
                int k = express.IndexOf('+');
                string[] values = getValues(express, k);
                string then =values[0]+"+"+values[1];
                answer = "" + Double.Parse(values[0] + Double.Parse(values[1]));
                express.Replace(then,answer);
            }
            while (express.Contains('-'))
            {
                int k = express.IndexOf('-');
                string[] values = getValues(express, k);
                string then = values[0] + "-" + values[1];
                answer = "" + Double.Parse(values[0]) + Double.Parse(values[1]);
                express.Replace(then, answer);
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
            string nums = "0123456789.-";
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
            if (a[0] != '(' ) {
                a = '(' + a + ')';
            }
            else if (a[a.Length - 1] != ')') {
                a ='(' + a + ')';
            }
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
                    j++;
                    b[j] = a.Substring(start+1, length-1);
                }
            }
            return b;
        }
        public static void Changes(string line){
            List<String> sep = Separate(line);
            for (int i = 0; i < sep.Count; i++)
            {
                string then = sep[i];
                string change = Solve(sep[i]);
                for (int j = 0; j < sep.Count; j++)
                {
                    if (sep[j].Contains(then))
                    {
                        sep[j].Replace(then, change);
                    }
                }
            }
        }
    }
}