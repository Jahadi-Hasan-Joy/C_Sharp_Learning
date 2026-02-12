using System;
using System.Globalization;

namespace Complete_CSharp_Guide
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string name = "Md jahadi hasan joy";

            for(int i = 0; i < name.Length; i++)
            {
                Console.Write(name[i]);
                Thread.Sleep(100);
            }
                       
        }
    }
}
