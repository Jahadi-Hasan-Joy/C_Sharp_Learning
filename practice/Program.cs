using System;
using System.Globalization;

namespace Complete_CSharp_Guide
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] num = new int[5] { 1, 2, 3, 4, 5 };
            Array.Reverse(num);
            foreach (int i in num)
            {
                Console.Write($"{i} ");
            }

            Console.ReadLine();
        }
    }
}
