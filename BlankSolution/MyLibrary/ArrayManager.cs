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
    }
}
