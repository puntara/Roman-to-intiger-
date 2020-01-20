using System;
using System.Collections;
namespace RomanToIntiger
{
    class GFG
    {
        public virtual int value(char r)
        {
            if (r == 'I')
                return 1;
            if (r == 'V')
                return 5;
            if (r == 'X')
                return 10;
            if (r == 'L')
                return 50;
            if (r == 'C')
                return 100;
            if (r == 'D')
                return 500;
            if (r == 'M')
                return 1000;
            return -1;
        }
        public virtual int RomanToInt(string A)

        {
            int i;
            int n;
            int ans = 0;
            int p = 0;
            n = A.Length - 1;
            for (i = n; i >= 0; i--)
            {
                // p = value(A[i]);
                if (value(A[i]) >= p)
                {
                    ans = ans + value(A[i]);
                }
                else
                {
                    ans = ans - value(A[i]);
                }
                p = value(A[i]);
            }
            return ans;

        }



        class Program
        {
            public static void Main(string[] args)
            {
                GFG ob = new GFG();
                string str = "MCMX";//1910

                Console.WriteLine("Converted value of {0} is: " + ob.RomanToInt(str), str);

            }
        }
    }
}
