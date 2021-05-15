using System;

namespace NumberOfPositionWithSameLength
{
    class Program
    {
        /*
         * Given 2 strings, a and b, return the number of the positions where they contain the 
         * same length 2 substring. So "xxcaazz" and "xxbaaz" yields 3, since the "xx", "aa", and "az" 
         * substrings appear in the same place in both strings.
stringMatch("xxcaazz", "xxbaaz") → 3
stringMatch("abc", "abc") → 2
stringMatch("abc", "axc") → 0
         * 
         * 
         */
        static void Main(string[] args)
        {
            Console.WriteLine(StringMatch("xxcaazz", "xxbaaz"));
            Console.WriteLine(StringMatch("abc", "abc"));
            Console.WriteLine(StringMatch("abc", "axc"));
        }

        private static int StringMatch(string a, string b)
        {
            int c = 0;
            for(int i=0; i< Math.Min(a.Length, b.Length)-1; i++)
            {
                if(a[i] == b[i] && a[i+1] == b[i + 1])
                {
                    c++;
                }
            }
            return c;
        }
    }
}
