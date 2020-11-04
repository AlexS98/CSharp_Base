using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Types
            var b = false; // 0000 0001 = true

            var byt = 123; // 1111 1111 (256 = 1 0000 0000)
            var sbyt = -64;

            var i = 150000; // -2147483648 до 2147483647
            var ui = 15000; // 0 до 4294967295 

            long l = 516515616;
            ulong ul = 516515616;

            short s = 16556;
            ushort us = 16556;

            double d = 165.2;
            float f = 125.2f;

            decimal dec = 156.8m;

            string str = "sdsfsdf";

            char c = 's';
            #endregion

            // FirstPart();

            Console.WriteLine("Welcome to Calculator");

            Console.WriteLine("Enter first argument: ");

            bool success1 = int.TryParse(Console.ReadLine(), out int firstInt);

            Console.WriteLine("Enter second argument: ");

            bool success2 = int.TryParse(Console.ReadLine(), out int secondInt);

            if (success1 && success2)
            {
                Console.WriteLine("Sum: " + (firstInt + secondInt));
            }
            else
            {
                Console.WriteLine("Error! Incorrect input.");
            }
        }

        private static void FirstPart()
        {
            Console.WriteLine("Enter your name:");

            string name = Console.ReadLine();

            Console.WriteLine("Hello" + " " + name); // StringBuilder

            Console.WriteLine("Enter your age:");

            string age = Console.ReadLine();

            int userAge;

            bool success = int.TryParse(age, out userAge);


            if (success)
            {
                Console.WriteLine("Your age: " + userAge);
            }
            else
            {
                Console.WriteLine("Error! Incorrect input.");
            }
        }
    }
}
