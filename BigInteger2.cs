using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigInteger
{
    class BigInteger2
    {
        private List<int> numbers = new List<int>();
        private int Sign { get; set; }

        public BigInteger2(string num)
        {
            int s = 0;
            if (num[0] == '-')
            {
                Sign = -1;
                s = 1;


            }
            else if (num[0] == 0)
            {
                Sign = 0;
            }
            else
            {
                Sign = 1;
            }

            for (int i = num.Length - 1; i >= s; i--)
            {
                numbers.Add(Convert.ToInt32(num[i] - 48));
            }

        }
        public static BigInteger2 operator +(BigInteger2 a, BigInteger2 b)
        {
            string number = "";
            ArrayList nums = new ArrayList();
            int rem = 0;
            int max = 0;
            int min = 0;
            int res = 0;
            if (a.numbers.Count > b.numbers.Count)
            {
                max = a.numbers.Count;
                min = b.numbers.Count;
            }
            else
            {
                max = b.numbers.Count;
                min = a.numbers.Count;
            }
            for (int i = min; i < max; i++)
            {
                if (a.numbers.Count > b.numbers.Count)
                {
                    b.numbers.Add(0);
                }
                if (b.numbers.Count > a.numbers.Count)
                {
                    a.numbers.Add(0);
                }
            }

            for (int i = 0; i < max; i++)
            {
                res = a.numbers[i] + b.numbers[i] + rem;
                if (res >= 10 && i != max - 1)
                {
                    rem = 1;
                    res -= 10;
                }
                else
                {
                    rem = 0;
                }
                nums.Add(res);
            }
            for (int i = nums.Count - 1; i >= 0; i--)
            {
                number += nums[i];
            }

            BigInteger2 c = new BigInteger2(number);

            return c;

        }
        public static BigInteger2 operator -(BigInteger2 a, BigInteger2 b)
        {
            ArrayList nums = new ArrayList();
            int max = 0;
            int min = 0;
            int res = 0;
            int rem = 0;
            if (a.numbers.Count > b.numbers.Count)
            {
                max = a.numbers.Count;
                min = b.numbers.Count;
            }
            else
            {
                max = b.numbers.Count;
                min = a.numbers.Count;
            }
            for (int i = min; i < max; i++)
            {
                if (a.numbers.Count > b.numbers.Count)
                {
                    b.numbers.Add(0);
                }
                if (b.numbers.Count > a.numbers.Count)
                {
                    a.numbers.Add(0);
                }

            }
            int r = 0;
            for (int i = 0; i < max; i++)
            {
                if (a.numbers[i] - rem < b.numbers[i])
                {
                    res = 10 + a.numbers[i] - b.numbers[i] - rem;
                }
                else
                    res = a.numbers[i] - b.numbers[i] - rem;
                if (a.numbers[i] - rem < b.numbers[i])
                {

                    rem = 1;
                }
                else
                {

                    rem = 0;
                }

                nums.Add(res);

            }
            string number = "";
            int z = 0;
            if (Convert.ToInt32(nums[nums.Count - 1]) == 0)
            {
                z = nums.Count - 2;
            }
            else
            {
                z = nums.Count - 1;
            }
            for (int i = z; i >= 0; i--)
            {
                number += nums[i];
            }
            BigInteger2 c = new BigInteger2(number);
            return c;

        }
        public override string ToString()
        {
            string res = "";
            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                res += numbers[i];
            }
            return res;
        }


    }
}
