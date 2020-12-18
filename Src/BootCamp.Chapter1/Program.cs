using System.Collections.Generic;
using System;

namespace BootCamp.Chapter1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] gg = new int[] { 5, 3, 2, 6 };
            ArrayOperations.Reverse(gg);
            for (int i = 0; i < gg.Length; i++)
            {
                Console.WriteLine(gg[i]);
            }

        }
    }
}
