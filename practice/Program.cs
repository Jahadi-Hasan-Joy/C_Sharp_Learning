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
                { 1, "Joy" },
                { 2, "rini" }
            };

            foreach (var item in info)
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();
        }
    }
}
 