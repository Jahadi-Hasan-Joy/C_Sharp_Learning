using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string interpolation
            
            string name = "Joy";
            Console.WriteLine("My name is "+name);
            Console.WriteLine($"My name is {name}");
        }
    }
}
