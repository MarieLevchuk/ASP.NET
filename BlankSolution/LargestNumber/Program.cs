using System;

namespace LargestNumber
{
    class Program
    {
        public static string ReturnGreatestNumber(int lenthOfSequence, string arr)
        {
            if (lenthOfSequence > arr.Length)
                return arr;

            int maxNum = Int32.Parse(arr.Substring(0, lenthOfSequence));
            for (int i = 1; i<= arr.Length - lenthOfSequence; i++)
            {
                int nextNum = Int32.Parse(arr.Substring(i, lenthOfSequence));
                if (maxNum < nextNum)
                    maxNum = nextNum;
            }
            return maxNum.ToString();
        }
        static void Main(string[] args)
        {
            string arr = "1234567890";
            int lenthOfSequence = 5;
            Console.WriteLine(arr);
            Console.WriteLine(ReturnGreatestNumber(lenthOfSequence, arr));
        }
    }
}
