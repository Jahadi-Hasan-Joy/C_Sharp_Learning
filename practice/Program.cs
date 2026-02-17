using System;
using System.Globalization;

namespace Complete_CSharp_Guide
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Dictionary<int,string> info = new Dictionary<int, string>
            {
                { 3, "dada" },
                { 1, "Joy"  },
                { 2, "Rini" },
                { 4, "Dada" }
            };

            foreach (var item in info)
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();
        }
    }
}
 