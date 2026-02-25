using System;

namespace Complete_CSharp_Guide
{
    class Person
    {
        private string name;  // field
        public string Name    // property
        {
            get { return name; }
            set { name = value; }
        }
    }
    internal class Program
    {
        private static void Main(string[] args)
        {
            Person myObj = new Person();
            myObj.Name = "Liam";
            Console.WriteLine(myObj.Name);

        }
    }
    
}