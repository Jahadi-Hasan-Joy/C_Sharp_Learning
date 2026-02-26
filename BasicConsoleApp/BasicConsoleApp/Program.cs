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
            double a = 5.0 / 2.3;
            Console.WriteLine(a);
            Console.WriteLine(string.Format("{0:0.00}",a));
            Console.WriteLine(a.ToString("C"));
            Console.WriteLine(a.ToString("C",CultureInfo.CreateSpecificCulture("en-GB")));

        }
        
    }
}
