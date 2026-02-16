using System;
using System.Globalization;

namespace Complete_CSharp_Guide
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<int> num = new List<int>() { 1,2,3,4,5};
            num.Add(1);
            num.Add(2);
            num.Add(3);

            foreach(int i in num)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
 