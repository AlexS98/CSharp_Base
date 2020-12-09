using System;

namespace Lesson12
{
    class Program
    {
        static void TextRenderer(string[] lines)
        {
            for (int i = 0; i < lines.Length; i++)
            {
                Console.SetCursorPosition(Console.WindowHeight / 2, Console.WindowWidth * 0 + i);
                Console.WriteLine(lines[i]);
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                string[] lines = new string[5];
                lines[0] = "New game (1)";
                lines[1] = "Continue (2)";
                lines[2] = "Settings (3)";
                lines[3] = "Developers (4)";
                lines[4] = "Exit (5)";
                TextRenderer(lines);
                var key = Console.ReadKey();
                if (key.Key == ConsoleKey.D1)
                {
                    Console.Clear();
                    string[] linesNG = new string[4];
                    linesNG[0] = "Choose difficult level:";
                    linesNG[1] = "Easy (1)";
                    linesNG[2] = "Medium (2)";
                    linesNG[3] = "HELL (3)";
                    TextRenderer(linesNG);
                    var key2 = Console.ReadKey();
                    if (key2.Key == ConsoleKey.D1 ||
                       key2.Key == ConsoleKey.D2 ||
                       key2.Key == ConsoleKey.D3)
                    {
                        Console.Clear();
                        Console.WriteLine("Your SSD is so fast, so the game has already finished!!!");
                        Console.ReadKey();
                    }
                }
                else if (key.Key == ConsoleKey.D2)
                {
                    Console.Clear();
                    string[] linesC = new string[3];
                    linesC[0] = "Your saves:";
                    linesC[1] = "Autosave1 (1)";
                    linesC[2] = "Quicksave (2)";
                    TextRenderer(linesC);
                    var key2 = Console.ReadKey();
                    if (key2.Key == ConsoleKey.D1 ||
                       key2.Key == ConsoleKey.D2)
                    {
                        Console.Clear();
                        Console.WriteLine("Your SSD is so fast, so the game has already finished!!!");
                        Console.ReadKey();
                    }
                }
                else if (key.Key == ConsoleKey.D3)
                {
                    Console.Clear();
                    string[] lineSTGS = new string[3];
                    lineSTGS[0] = "Graphics (1)";
                    lineSTGS[1] = "Sound (2)";
                    lineSTGS[2] = "Language (3)";
                    TextRenderer(lineSTGS);
                    var key2 = Console.ReadKey();
                    if (key2.Key == ConsoleKey.D1 ||
                       key2.Key == ConsoleKey.D2)
                    {
                        Console.Clear();
                        Console.WriteLine("Graphics is awesome! Sounds are great and language is English!");
                        Console.ReadKey();
                    }
                }
                else if (key.Key == ConsoleKey.D4)
                {
                    Console.Clear();
                    string[] lineSTGS = new string[3];
                    lineSTGS[0] = "Hideo Kojima";
                    lineSTGS[1] = "Hideo Kojima";
                    lineSTGS[2] = "Hideo Kojima";
                    TextRenderer(lineSTGS);
                    Console.ReadKey();
                }
                else if (key.Key == ConsoleKey.D5)
                {
                    Console.Clear();
                    Console.ReadKey();
                    return;
                }
            }
        }
    }
}
