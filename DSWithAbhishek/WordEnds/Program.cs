using System;
using System.Text;

namespace WordEnds
{
    /*
     * PRG_0007

Given a string and a non-empty word string, return a string made of each char just before and just after every appearance of the word in the string. Ignore cases where there is no char before or after the word, and a char may be included twice if it is between two words.


wordEnds("abcXY123XYijk", "XY") → "c13i"
wordEnds("XY123XY", "XY") → "13"
wordEnds("XY1XY", "XY") → "11"
     * 
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(wordEnds("abcXY123XYijk", "XY"));
            Console.WriteLine(wordEnds("XY123XY", "XY"));
            Console.WriteLine(wordEnds("XY1XY", "XY"));
        }
        private static string wordEnds(string s1, string s2)
        {
            if(s1== null || s1.Length ==0 || s2 == null || s2.Length == 0)
            {
                return s1;
            }

            int start = 0;
            StringBuilder sb = new StringBuilder();

            while(start < s1.Length)
            {
                int foundIndex = s1.IndexOf(s2, start);
                if(foundIndex == -1)
                {
                    break;
                }

                int leftIndex = foundIndex - 1;
                int rightIndex = foundIndex + s2.Length;

                if(leftIndex >= 0)
                {
                    sb.Append(s1[leftIndex]);
                }

                if(rightIndex < s1.Length)
                {
                    sb.Append(s1[rightIndex]);
                }

                start = foundIndex + 1;
            }

            return sb.ToString();
        }
    }
}
