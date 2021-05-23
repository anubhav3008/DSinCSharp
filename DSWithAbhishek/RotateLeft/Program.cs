using System;

namespace RotateLeft
{
    class Program
    {
        static void Main(string[] args)
        {

            Test(new char[] { '1', '2', '3', '4', '5' }, 1);
            Test(new char[] { '1', '2', '3', '4', '5' }, 2);
            Test(new char[] { '1', '2', '3', '4', '5' }, 3);
            Test(new char[] { '1', '2', '3', '4', '5' }, 4);
            Test(new char[] { '1', '2', '3', '4', '5' }, 5);
            Test(new char[] { 'h', 'e', 'l', 'l', '0' }, 2);
            Test(new char[] { 'j', 'a', 'v', 'a' }, 2);
            Test(new char[] { 'h', 'i' }, 2);
        }

        private static void RotateLeft(char[] a, int d)
        {
            d = d % a.Length;
            reverse(a, 0, d-1);
            reverse(a, d, a.Length - 1);
            reverse(a, 0, a.Length - 1);
        }

        private static void reverse(char[] a, int i, int j)
        {
            while (i < j)
            {
                char temp = a[i];
                a[i] = a[j];
                a[j] = temp;
                i++;
                j--;
            }
        }


        // Utility functions 

        private static void Test(char[] a, int d)
        {
            printArry(a);
            RotateLeft(a, d);
            printArry(a);
            Console.WriteLine();
        }

        private static void printArry(char[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + "\t");
            }
            Console.WriteLine();
        }
    }
}
