using System;

namespace CheckElementPresentInArray
{
    /*
     * Given an array of elements of length N, ranging from 0 to N – 1. 
     * All elements may not be present in the array. If the element is 
     * not present then there will be -1 present in the array. 
     * Rearrange the array such that A[i] = i and if i is not present, display -1 at that place.
     * Input : arr = {-1, -1, 6, 1, 9, 3, 2, -1, 4, -1}
Output : [-1, 1, 2, 3, 4, -1, 6, -1, -1, 9]

Input : arr = {19, 7, 0, 3, 18, 15, 12, 6, 1, 8,
              11, 10, 9, 5, 13, 16, 2, 14, 17, 4}
Output : [0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 
         11, 12, 13, 14, 15, 16, 17, 18, 19]
     */
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { -1, -1, 6, 1, 9, 3, 2, -1, 4, -1 }; PrintArray(a);  ReArrangeArray(a); PrintArray(a);
            Console.WriteLine();

            int[] b = {19, 7, 0, 3, 18, 15, 12, 6, 1, 8,
              11, 10, 9, 5, 13, 16, 2, 14, 17, 4}; PrintArray(b); ReArrangeArray(b); PrintArray(b);
            Console.WriteLine();
        }

        private static void ReArrangeArray(int[] a)
        {
            for(int i =0;i < a.Length; i++)
            {
                if (a[i] == -1 || a[i]==-2)
                {
                    continue;
                }

                if(a[a[i]%a.Length] == -1)
                {
                    a[a[i]] = -2;
                }

                else
                {
                    a[a[i]%a.Length] = a[a[i]%a.Length] + a.Length;
                }
            }

            for (int i=0; i< a.Length; i++)
            {
                if(a[i]== -2 || a[i]>= a.Length )
                {
                    a[i] = i;
                }
                else
                {
                    a[i] = -1;
                }
            }
        }

        private static void PrintArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
