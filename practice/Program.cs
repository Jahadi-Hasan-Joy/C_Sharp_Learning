using System;

namespace Complete_CSharp_Guide
{
    class Car
    {
        public string model = "Mustang";
    }
    internal class Program
    {
        private static void Main(string[] args)
        {
            Car myObj = new Car();
            Console.WriteLine(myObj.model);

        }
    }
    
}