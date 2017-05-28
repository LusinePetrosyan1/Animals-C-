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
            
            string answer = express;
            while (express.Contains("×"))
            {
                int k = express.IndexOf("×");
                string[] values = getValues(express, k);
                string then =values[0]+"×"+values[1];
                answer = Double.Parse(values[0]) * Double.Parse(values[1])+"";
                express=express.Replace(then,answer);
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
                    answer = Double.Parse(values[0]) / Double.Parse(values[1])+"";
                    express=express.Replace(then,answer);
                }
            }
            while (express.Contains('√')) {
                int k = express.IndexOf('√');
                string then = express;
                double ans = 0;
                if (Double.Parse(express.Substring(1,express.Length-1)) < 0)
                {
                    throw new ArithmeticException();
                }
                    ans = Math.Sqrt(Double.Parse(express.Substring(1,express.Length-1)));
                answer = ans + "";
                express = express.Replace(then, answer);
            }
            while (express.Contains("%"))
            {
                int k = express.IndexOf("%");
                string[] values = getValues(express, k);
                string then =values[0]+"%"+values[1];
                answer = Double.Parse(values[0]) * Double.Parse(values[1])/100 +"";
               express= express.Replace(then,answer);
            }
            while (express.Contains('+'))
            {
                int k = express.IndexOf('+');
                string[] values = getValues(express, k);
                string then =values[0]+"+"+values[1];
                answer = Double.Parse(values[0]) + Double.Parse(values[1])+"";
                express=express.Replace(then,answer);
            }
            while (express.Substring(1,express.Length-1).Contains('-') )
            {
                int k = express.IndexOf('-',1);
                string[] values = getValues(express, k);
                string then = values[0] + "-" + values[1];
                answer =Double.Parse(values[0]) - Double.Parse(values[1])+"";
                express=express.Replace(then, answer);
            }
            return answer;
        }
        public static string[] getValues(string express, int index)
        {
            string[] output = new string[2];
            String leftvalue = "";
            String rightvalue = "";
            string nums = "0123456789.-";

            for (int i = index-1; i >=0 && nums.Contains(express[i]); i--)
            {
                leftvalue = express[i] + leftvalue;
                if (express[i] == '-')
            {
                    break;
                }
            }
            for (int i = index+1; i < express.Length && nums.Contains(express[i]); i++)
            {
                if (i != index + 1 && express[i] == '-')
            {
                    break;
                }
                rightvalue = rightvalue + express[i]; 
            }
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
                    b.Add(a.Substring(start+1, length-2));
                }
            }
            return b;
        }
        public static string Changes(string line){
           List<String> sep = Separate(line);
            for (int i = 0; i < sep.Count; i++)
            {
                string then = sep[i];
                string change = Solve(sep[i]);
                for (int j = 0; j < sep.Count; j++)
                {
                    if (sep[j].Contains('('+then+')'))
                    {
                        sep[j] = sep[j].Replace('(' + then + ')', change);
                    }
                    else if (sep[j].Contains(then))
                    {
                        sep[j] = sep[j].Replace(then, change);
                    }
                }
            }
            string b = sep[sep.Count - 1];
            return b;
        }

        
    }
}