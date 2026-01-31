using System;

namespace C_Sharp_Basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // PROGRAM START
            Console.WriteLine("Alhamdulillah for everything.\n");


            // BASIC DATA TYPES
            int userAge = 25;
            bool isStudent = true;
            char gradeLetter = 'A';
            double cgpa = 3.80;
            string shortName = "JOY";

            Console.WriteLine(
                "My name is " + shortName +
                ", I am " + userAge +
                " years old. My CGPA is " + cgpa +
                ", and my grade is " + gradeLetter
            );
            Console.WriteLine("It's " + isStudent + "\n");


            // STRING CONCATENATION
            string firstName = "Md Jahadi";
            string lastName = " Hasan Joy";
            string fullName = firstName + lastName;

            Console.WriteLine("My full name is " + fullName + "\n");


            // CONSTANT VALUE
            const double PI = 3.1416;
            Console.WriteLine($"constant value is : {PI}");


            // TYPE CASTING
            double doubleNumber = 3.3434;
            int convertedInt = Convert.ToInt32(doubleNumber);
            Console.WriteLine("convert into int is : " + convertedInt);

            int integerNumber = 10;
            double convertedDouble = Convert.ToDouble(integerNumber) + 0.74;
            Console.WriteLine("convert into double is : " + convertedDouble);


            // DATA TYPE CHECK
            Console.WriteLine(doubleNumber.GetType());
            Console.WriteLine();


            // MATH FUNCTIONS
            Console.WriteLine("Math operation ");

            double baseNumber = 9;
            Console.WriteLine("power of m^2 is : " + Math.Pow(baseNumber, 2));
            Console.WriteLine("Sqrt of m is : " + Math.Sqrt(baseNumber));
            Console.WriteLine("Abs of m3 is : " + Math.Abs(-8));
            Console.WriteLine("Round of m5 is : " + Math.Round(4.49));
            Console.WriteLine("Ceiling of m5 is : " + Math.Ceiling(4.49));
            Console.WriteLine("Floor of m5 is : " + Math.Floor(4.49));
            Console.WriteLine("Max value is : " + Math.Max(10, 20));
            Console.WriteLine("Min value is : " + Math.Min(10, 20));
            Console.WriteLine();


            // RANDOM NUMBER
            Random randomGenerator = new Random();

            Console.WriteLine("Ludu dice value is " + randomGenerator.Next(1, 7));
            Console.WriteLine("double Ludu dice value is " +
                (randomGenerator.Next(1, 7) + randomGenerator.Next(1, 7))
            );
            Console.WriteLine("Double random num is " + randomGenerator.NextDouble());
            Console.WriteLine();


            // STRING OPERATIONS
            string userFullName = "Jahadi Hasan Joy";

            Console.WriteLine("Name in lower : " + userFullName.ToLower());
            Console.WriteLine("Name in upper : " + userFullName.ToUpper());

            string cleanPhoneNumber = "123-123-434343".Replace("-", "");
            Console.WriteLine("Phone number " + cleanPhoneNumber);
            Console.WriteLine();

            string formattedName = userFullName.ToUpper().Insert(0, "MD ");
            Console.WriteLine("My name is : " + formattedName);
            Console.WriteLine("names length is : " + formattedName.Length);

            Console.WriteLine(
                "firstName = " + formattedName.Substring(0, 9) +
                "\nlastName = " + formattedName.Substring(9)
            );


            // PROGRAM END
            Console.ReadKey();
        }
    }
}
