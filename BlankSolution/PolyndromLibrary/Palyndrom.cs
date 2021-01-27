using System;

namespace PalyndromLibrary
{
    public class Palyndrom
    {
        public static bool IsPalyndrom(string word)
        {
            char[] wordChar = word.ToCharArray();
            Array.Reverse(wordChar);

            return (word == wordChar.ToString()) ? true : false;
        }
    }
}
