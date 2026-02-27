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
            Dictionary<string, string> teachers = new Dictionary<string, string>()
            {
                { "CSE","Joy" },
                { "EEE","Tanvir" },
                { "Physics","Badhon" }
            };
            if (teachers.TryGetValue("CSE", out string teacher))
            {
                Console.WriteLine(teacher);
            }
            else
            {
                Console.WriteLine("Teacher not found");
            }
        }
    }
}
