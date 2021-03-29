using System;

namespace NumberOfTrailingZeros
{
    class Program
    {
        public static int CountZeros(int n)
        {
            int res = 0;

            for (int i = n; i > 0; i--)
            {
                if (i % 5 == 0)
                {
                    int count = i;
                    while (count % 5 == 0)
                    {
                        res++;
                        count /= 5;
                    }
                }
            }

            return res;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CountZeros(6));
        }
    }
}
