using System;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            bool parseResult;
            string input;

            do
            {
                Console.Write("Enter number 1 please: ");
                input = Console.ReadLine();
                parseResult = int.TryParse(input, out number1);
            }
            while (!parseResult);

            int number2;
            //do
            //{
            //    Console.Write("Enter number 2 please: ");
            //}
            //while (!int.TryParse(Console.ReadLine(), out number2));


            Console.Write("Enter number 2 please: ");
            while (!int.TryParse(Console.ReadLine(), out number2))
            {
                Console.Write("Enter number 2 please: ");
            }


            bool correctOperator;
            do
            {
                Console.Write("Enter operation: ");
                string userInput = Console.ReadLine();
                correctOperator = true;

                switch (userInput)
                {
                    case "+":
                        Console.WriteLine(number1 + number2);
                        break;
                    case "-":
                        Console.WriteLine(number1 - number2);
                        break;
                    case "/":
                        if (number2 == 0)
                        {
                            Console.WriteLine("Invalid operation - (number 2) == 0");
                            correctOperator = false;
                        }
                        else
                        {
                            Console.WriteLine(number1 / number2);
                        }
                        break;
                    case "*":
                        Console.WriteLine(number1 * number2);
                        break;
                    default:
                        Console.WriteLine("Invalid operation!");
                        correctOperator = false;
                        break;
                }

                if (userInput == "+")
                {
                    Console.WriteLine(number1 + number2);
                }
                else if (userInput == "-")
                {
                    Console.WriteLine(number1 - number2);
                }
                else if (userInput == "/" && number2 == 0)
                {
                    if (number2 == 0)
                    {
                        Console.WriteLine("Invalid operation - (number 2) == 0");
                        correctOperator = false;
                    }
                    else
                    {
                        Console.WriteLine(number1 / number2);
                    }
                }
                else if (userInput == "*")
                {
                    Console.WriteLine(number1 * number2);
                }
                else
                {
                    Console.WriteLine("Invalid operation!");
                    correctOperator = false;
                }
            }
            while (!correctOperator);


            for (int i = 0; i < 10; i++)
            {
                if (i == 0 || i == 3)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

            Console.WriteLine("Press any key to exit...");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Q)
            {

            }
        }


        static void UserData()
        {
            Console.Write("Enter your name: ");
            var name = Console.ReadLine();

            Console.Write("enter 1: ");

            if (int.TryParse(Console.ReadLine(), out int date) || (date < 1) || (date > 31))
            {

            }
        }
    }
}
