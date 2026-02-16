using System;
using System.Globalization;

namespace Complete_CSharp_Guide
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] num = new int[] {0, 1, 2, 3, 1 ,4, 5,6,7,8,9 };
            int pos = Array.IndexOf(num, 1);
            Console.WriteLine("poss = "+ pos);
            Console.ReadLine();
        }
    }
}
