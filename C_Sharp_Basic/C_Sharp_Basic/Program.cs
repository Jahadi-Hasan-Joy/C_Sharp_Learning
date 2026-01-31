using System;
using System.Collections.Generic;
using System.Linq;

namespace Complete_CSharp_Guide
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== C# COMPLETE GUIDE START ===\n");

            // ===============================
            // 1. BASIC DATA TYPES
            // ===============================
            int age = 25;
            double cgpa = 3.80;
            bool isStudent = true;
            char grade = 'A';
            string name = "Jahadi Hasan Joy";

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"CGPA: {cgpa}");
            Console.WriteLine($"Student: {isStudent}");
            Console.WriteLine($"Grade: {grade}\n");

            // ===============================
            // 2. USER INPUT
            // ===============================
            Console.Write("Enter your university name: ");
            string university = Console.ReadLine();
            Console.WriteLine($"University: {university}\n");

            // ===============================
            // 3. TYPE CASTING
            // ===============================
            double rawScore = 89.75;
            int roundedScore = Convert.ToInt32(rawScore);
            Console.WriteLine($"Raw Score: {rawScore}");
            Console.WriteLine($"Rounded Score: {roundedScore}\n");

            // ===============================
            // 4. OPERATORS
            // ===============================
            int a = 10, b = 3;
            Console.WriteLine($"Add: {a + b}");
            Console.WriteLine($"Sub: {a - b}");
            Console.WriteLine($"Mul: {a * b}");
            Console.WriteLine($"Div: {a / b}");
            Console.WriteLine($"Mod: {a % b}\n");

            // ===============================
            // 5. IF ELSE
            // ===============================
            if (cgpa >= 3.5)
                Console.WriteLine("Result: Excellent");
            else if (cgpa >= 3.0)
                Console.WriteLine("Result: Good");
            else
                Console.WriteLine("Result: Needs Improvement");
            Console.WriteLine();

            // ===============================
            // 6. SWITCH
            // ===============================
            int dayNumber = 5;
            switch (dayNumber)
            {
                case 5:
                    Console.WriteLine("Today is Friday");
                    break;
                default:
                    Console.WriteLine("Regular Day");
                    break;
            }
            Console.WriteLine();

            // ===============================
            // 7. LOOPS
            // ===============================
            for (int i = 1; i <= 3; i++)
                Console.WriteLine($"For Loop: {i}");

            int counter = 1;
            while (counter <= 3)
            {
                Console.WriteLine($"While Loop: {counter}");
                counter++;
            }
            Console.WriteLine();

            // ===============================
            // 8. ARRAY
            // ===============================
            int[] marks = { 85, 90, 88 };
            Console.WriteLine($"First mark: {marks[0]}\n");

            // ===============================
            // 9. LIST
            // ===============================
            List<string> skills = new List<string>
            {
                "C++",
                "C#",
                "Problem Solving"
            };

            foreach (var skill in skills)
                Console.WriteLine($"Skill: {skill}");
            Console.WriteLine();

            // ===============================
            // 10. DICTIONARY
            // ===============================
            Dictionary<string, int> subjectMarks = new Dictionary<string, int>
            {
                { "Math", 90 },
                { "Physics", 85 }
            };
            Console.WriteLine($"Math Marks: {subjectMarks["Math"]}\n");

            // ===============================
            // 11. METHOD
            // ===============================
            PrintGreeting(name);
            Console.WriteLine();

            // ===============================
            // 12. ENUM
            // ===============================
            UserRole role = UserRole.Student;
            Console.WriteLine($"User Role: {role}\n");

            // ===============================
            // 13. TERNARY OPERATOR
            // ===============================
            string passStatus = (cgpa >= 3.0) ? "Pass" : "Fail";
            Console.WriteLine($"Status: {passStatus}\n");

            // ===============================
            // 14. DATETIME
            // ===============================
            DateTime currentTime = DateTime.Now;
            Console.WriteLine($"Current Time: {currentTime}\n");

            // ===============================
            // 15. TRY CATCH (CORRECT WAY)
            // ===============================
            int divisor = 0;
            try
            {
                if (divisor == 0)
                    throw new DivideByZeroException();

                int result = 10 / divisor;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Division by zero is not allowed");
            }
            Console.WriteLine();

            // ===============================
            // 16. CLASS & OBJECT (OOP)
            // ===============================
            Student student = new Student("Joy", 25, 3.80);
            student.DisplayInfo();
            Console.WriteLine();

            // ===============================
            // 17. LINQ (ADVANCED)
            // ===============================
            List<int> numbers = new List<int> { 5, 10, 15, 20 };
            var filteredNumbers = numbers.Where(n => n > 10).ToList();

            foreach (var num in filteredNumbers)
                Console.WriteLine($"LINQ Result: {num}");
            Console.WriteLine();

            Console.WriteLine("=== C# COMPLETE GUIDE END ===");
            Console.ReadKey();
        }

        static void PrintGreeting(string userName)
        {
            Console.WriteLine($"Hello, {userName}");
        }
    }

    // ===============================
    // ENUM
    // ===============================
    enum UserRole
    {
        Student,
        Admin,
        Guest
    }

    // ===============================
    // CLASS (OOP)
    // ===============================
    class Student
    {
        public string Name;
        public int Age;
        public double Cgpa;

        public Student(string name, int age, double cgpa)
        {
            Name = name;
            Age = age;
            Cgpa = cgpa;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Student Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"CGPA: {Cgpa}");
        }
    }
}
