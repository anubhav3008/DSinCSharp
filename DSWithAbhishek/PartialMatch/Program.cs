using System;

namespace PartialMatch
{
    /*
     * 
     * PRG_0009
Given a string and a second "word" string, we'll say that the word matches the string if it appears at the front of the string, except its first char does not need to match exactly. On a match, return the front of the string, or otherwise return the empty string. So, with the string "hippo" the word "hi" returns "hi" and "xip" returns "hip". The word will be at least length 1.

startWord("hippo", "hi") → "hi"
startWord("hippo", "xip") → "hip"
startWord("hippo", "i") → "h"
     * 
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StartWord("hippo", "hi"));
            Console.WriteLine(StartWord("hippo", "xip"));
            Console.WriteLine(StartWord("hippo", "i"));
        }

        private static string StartWord(string s1, string s2)
        {
            if(s2 == null || s2.Length == 0 || s2.Length >  s1.Length)
            {
                return string.Empty;
            }

            for(int i = 1; i < s2.Length; i++)
            {
                if(s1[i] != s2[i])
                {
                    return string.Empty;
                }
            }

            return s1.Substring(0, s2.Length);
        }
    }
}
