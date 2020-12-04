using System;

namespace MyLibrary
{
    public static class ArrayManager
    {
        public static int FindMax(int[] arr)
        {
            int max = arr[0];
            for(int i=0; i< arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
            return max;
        }

        public static int CountEvenNumber(int[] arr)
        {
            if (arr == null)
                throw new NullReferenceException("array is not initialized");
            int count = 0;
            foreach (int a in arr)
            {
                if (a % 2 == 0)
                    count++;
            }
            return count;
        }

        public static double GetAverage(int[] arr)
        {
            double sum = 0;
            foreach (var a in arr)
            {
                sum += a;
            }
            return sum / arr.Length;
        }
    }
}
