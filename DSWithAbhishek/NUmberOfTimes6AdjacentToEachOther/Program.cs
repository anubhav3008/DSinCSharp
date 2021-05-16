using System;

namespace NUmberOfTimes6AdjacentToEachOther
{
    /*
     * 
     * PRG_0004
Given an array of ints, return the number of times that two 6's are next to each other in the array. Also count instances where the second "6" is actually a 7.


array667([6, 6, 2]) → 1
array667([6, 6, 2, 6]) → 1
array667([6, 7, 2, 6]) → 1
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(array667(new int[] { 6, 6, 2 }));
            Console.WriteLine(array667(new int[] { 6, 6, 2, 6 }));
            Console.WriteLine(array667(new int[] { 6, 7, 2, 6 }));
        }

        private static int array667(int[] a)
        {
            int c = 0;
            for (int i = 0;i< a.Length -1; i++)
            {
                if(a[i]== 6 && (a[i+1]==6 || a[i + 1] == 7))
                {
                    c++;
                }
            }
            return c;
        }
    }
}
