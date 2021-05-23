using System;
using System.Collections.Generic;
using System.Text;

namespace GroupAnangrams
{
    /*
     * PRG_0006

given an array of strings, group the anagrams together

Input: strs=["eat", "tea", "tan", "ate", "nat", "bat" ]

Output: [["bat"],["nat", "tan"], ["ate", "eat", "tea"]]

Answer can be in any order
     * 
     */
    class Program
    {
        static void Main(string[] args)
        {
            Print(GroupAnangramsSolution(new string[] { "eat", "tea", "tan", "ate", "nat", "bat" }));
        }

        private static List<List<string>> GroupAnangramsSolution(string[] s)
        {
            Dictionary<String, List<String>> mp =  new Dictionary<string, List<string>>();

            for(int i = 0; i < s.Length; i++)
            {
                string charCounts = getCountOfEachChars(s[i]);
                if (mp.ContainsKey(charCounts))
                {
                    mp[charCounts].Add(s[i]);
                }
                else
                {
                    mp.Add(charCounts, new List<string>() { s[i] });
                }
            }

            List<List<string>> ans = new List<List<string>>();

            foreach (KeyValuePair<string, List<String>> entry in mp)
            {
                ans.Add(entry.Value);                
            }

            return ans;
        }

        private static string getCountOfEachChars( string s)
        {
            int[] count = new int[26];
            for(int i = 0; i < s.Length; i++)
            {
                count[(int)s[i] - 97]++;
            }
            StringBuilder stringBuilder = new StringBuilder(26);

            for (int i = 0; i < count.Length; i++)
            {
                stringBuilder.Append(count[i]);
            }
           
            return stringBuilder.ToString();
        }


        private static void Print(List<List<string>> s)
        {
            for(int i = 0; i < s.Count; i++)
            {
                for(int j = 0; j < s[i].Count; j++)
                {
                    Console.Write(s[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

       
    }
}
