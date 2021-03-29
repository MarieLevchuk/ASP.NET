using System;
using System.Collections.Generic;

namespace JosephusPermutation
{
    class Program
    {
        //public static List<object> JosephusPermutation(List<object> items, int k)
        //{
        //    List<object> newSequence = new List<object>();
        //    int selected = 0;
        //    bool stop = false;
        //    int start = 0;

        //    if (!stop)
        //    {
        //        newSequence.Add(items[k]);
        //    }

        //    if (stop)
        //        return newSequence;
        //}

        public static int JosephusPermutation(int n, int k)
        {
            int res = 0;
            for (int i = 1; i <=n; ++i)
            {
                res = (res + k) % i;
            }
            return res + 1;
        }
        public static List<object> JosephusPermutation(List<object> items, int k)
        {
            List<object> newSequence = new List<object>();
            //int  = items.Count;
            int length = items.Count;
            int res = 0;
            while (items.Count != 0)
            {
                //res = (res + k) % i;
                
                if ((res + k) > items.Count)
                {
                    res = items.Count - res + 1;                    
                }
                else
                {
                    res += k;
                }                

                newSequence.Add(items[res - 1]);
                items.RemoveAt(res - 1);
                res--;
            }
            return newSequence;
        }
        static void Main(string[] args)
        {
            List<object> items = new List<object> { 1, 2, 3, 4, 5, 6, 7 };
            foreach (var item in items)
            {
                Console.Write(item + "  ");
            }
            Console.WriteLine("\n");

            int l = 3;
            List<object> newSequence = JosephusPermutation(items, l);

            foreach (var item in newSequence)
            {
                Console.Write(item + "  ");
            }

            int n = 14;
            int k = 2;
            //Console.WriteLine("the chosen place is" + JosephusPermutation(n,k));

        }
    }
}
