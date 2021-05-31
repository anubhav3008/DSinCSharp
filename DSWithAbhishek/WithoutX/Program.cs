using System;
using System.Text;

namespace WithoutX
{
    /*
     * 
     * PRG_0008
Given a string, if one or both of the first 2 chars is 'x', return the string without those 'x' chars, and otherwise return the string unchanged. This is a little harder than it looks.

     * 
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(withoutX2("xHi"));
            Console.WriteLine(withoutX2("Hxi"));
            Console.WriteLine(withoutX2("Hi"));
            Console.WriteLine(withoutX2("Hellox"));
        }

        private static string withoutX2(string x)
        {
            if (x.Length < 2)
            {
                return x;

            }
            if (x[0] != 'x' && x[1] != 'x')
            {
                return x;
            }

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < x.Length; i++)
            {
                if (i == 0 || i == 1)
                {
                    if (x[i] == 'x')
                    {
                        continue;
                    }
                }
                sb.Append(x[i]);
            }

            return sb.ToString();
        }
    }
}
