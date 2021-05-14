using System;

/*
Given a string, return the count of the number of times that a substring length
2 appears in the string and also as the last 2 chars of the string, so "hixxxhi"
yields 1 (we won't count the end substring).
last2("hixxhi") → 1
last2("xaxxaxaxx") → 1
last2("axxxaaxx") → 2
 */
namespace SubstringTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetCountSubsting("hixxhi")); // 1
            Console.WriteLine(GetCountSubsting("xaxxaxaxx")); // 1
            Console.WriteLine(GetCountSubsting("axxxaaxx")); // 2
            Console.WriteLine(GetCountSubsting("xxx")); // 0
            Console.WriteLine(GetCountSubsting("a")); // 0
            Console.WriteLine(GetCountSubsting("aa")); // 0
            Console.WriteLine(GetCountSubsting("abab")); // 1          
            Console.WriteLine(GetCountSubsting("abcd")); // 0
        }

        /// <summary>
        /// Iterates over the items to find the match.
        /// Time complexity :  0(n), Space complexity 0(1)
        /// </summary>
        /// <param name="s">input string</param>
        /// <returns>answer result</returns>

        private static int GetCountSubsting(string s)
        {
            if (s == null || s.Length <= 2)
            {
                return 0;
            }
            
            int count = 0;
            for (int i = 0; i <= s.Length - 4; i++)
            {
                if (s[i] == s[s.Length - 2] && s[i + 1] == s[s.Length - 1])
                {
                    count++;
                }
            }

            return count;
        }
    }
}
