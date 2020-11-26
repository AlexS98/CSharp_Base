using System;

namespace Lesson_Additional
{
    class Program
    {
        static string[] restrictedWords = { "qweqwe", "sdasdasd" };

        static void Main(string[] args)
        {
            string[] someStringArray = new string[5];

            for (int i = 0; i < someStringArray.Length; i++)
            {
                Console.Write($"Element {i}: ");
                someStringArray[i] = Console.ReadLine();
            }

            for (int i = 0; i < someStringArray.Length; i++)
            {
                if (IsRestricted(someStringArray[i]))
                {
                    someStringArray[i] = new string('*', someStringArray[i].Length);
                }
            }

            foreach (var item in someStringArray)
            {
                if (item[0] == '*' && item == new string('*', item.Length))
                {
                    ToConsole(item, ConsoleColor.Red);
                }
                else
                {
                    Console.WriteLine(item);
                }
            }

            int[,] array = new int[10, 10];

            for (int i = 0; i < 10; i++)
            {
                int counter = 0;
                for (int j = 0; j < 10; j++)
                {
                    array[i, j] = j <= i && i + j >= 9 || j >= i && i + j <= 9 ? ++counter : 0;
                    Console.Write(array[i, j] + "; ");
                }
                Console.WriteLine();
            }

            Bot bot = new Bot("Bot");

            bot.Name = "newBot";

            bool isActive = true;
            do
            {
                Console.Write("Enter: ");
                string mes = Console.ReadLine();
                if (string.IsNullOrEmpty(mes))
                {
                    isActive = false;
                }
                else
                {
                    Console.WriteLine($"{bot.Name}: {bot.ResponseToUser(mes)}");
                }
            }
            while (isActive);

        }

        static bool IsRestricted(string val)
        {
            foreach (var word in restrictedWords)
            {
                if (val == word)
                {
                    return true;
                }
            }

            return false;
        }

        public static void ToConsole(string str, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(str);
            Console.ResetColor();
        }
    }
}
