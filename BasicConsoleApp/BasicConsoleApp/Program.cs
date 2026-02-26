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
            string snum = Console.ReadLine();
            int.TryParse(snum, out int num);
            Console.WriteLine(num);
        }
        
    }
}
