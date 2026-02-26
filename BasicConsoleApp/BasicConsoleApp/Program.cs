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
            // Verbatim string literal (@)
            string filePath = "C:\\Users\\Username\\Documents\\file.txt";
            string fileLocation = @"C:\Users\Username\Documents\\file.txt";
            Console.WriteLine("First method "+ filePath);
            Console.WriteLine("Second method " + fileLocation);

        }
    }
}
