using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Operations
    {
        public List<String> Separate(string a) {
            List<String> b = new List<string>();
            int j = 0;
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i <a.Length; i++)
            {
                if (a[i] == '(')
                {
                    stack.Push(i);
                }
                else if (a[i] == ')') {
                    int start = stack.Pop();
                    int length= -start + i + 1;
                    j++;
                    b[j] = a.Substring(start, length);
                }
            }
            return b;
        } 
    }
}
