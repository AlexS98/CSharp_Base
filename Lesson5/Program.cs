using System;

namespace Lesson5
{
    class Program
    {
        const char Player = '☻';
        static char[,] Map = new char[15, 15];
        static int xPos = 0;
        static int yPos = 0;
        static char currentPosBg = ' ';
        static bool isAlive = true;
        static int turnCount = 0;

        static void Main(string[] args)
        {
            GenerateMap();
            // set player to init position
            Map[1, 1] = Player;
            xPos = 1;
            yPos = 1;
            RenderMap();

            while (isAlive)
            {
                turnCount++;
                bool isInputSuccess;

                do
                {
                    ConsoleKey key = Console.ReadKey().Key;
                    isInputSuccess = true;

                    switch (key)
                    {
                        case ConsoleKey.A:
                            {
                                if (IsPositionAvailable(0, -1))
                                {
                                    SetPlayerToPosition(0, -1);
                                }
                                else
                                {
                                    Console.WriteLine("Position is unavailable");
                                    isInputSuccess = false;
                                }
                                break;
                            }
                        case ConsoleKey.W:
                            {

                                if (IsPositionAvailable(-1, 0))
                                {
                                    SetPlayerToPosition(-1, 0);
                                }
                                else
                                {
                                    Console.WriteLine("Position is unavailable");
                                    isInputSuccess = false;
                                }
                                break;
                            }
                        case ConsoleKey.D:
                            {

                                if (IsPositionAvailable(0, 1))
                                {
                                    SetPlayerToPosition(0, 1);
                                }
                                else
                                {
                                    Console.WriteLine("Position is unavailable");
                                    isInputSuccess = false;
                                }
                                break;
                            }
                        case ConsoleKey.S:
                            {

                                if (IsPositionAvailable(1, 0))
                                {
                                    SetPlayerToPosition(1, 0);
                                }
                                else
                                {
                                    Console.WriteLine("Position is unavailable");
                                    isInputSuccess = false;
                                }
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Wrong key, use \"W,A,S,D\"");
                                isInputSuccess = false;
                                break;
                            }
                    }
                }
                while (!isInputSuccess);

                RenderMap();
            }
        }

        static void GenerateMap()
        {
            for (int i = 0; i < Map.GetLength(0); i++)
            {
                for (int k = 0; k < Map.GetLength(1); k++)
                {
                    Map[i, k] = ' ';
                }
            }
        }

        static void RenderMap()
        {
            Console.Clear();
            Console.WriteLine($"Turn count: {turnCount}");
            for (int i = 0; i < Map.GetLength(0); i++)
            {
                Console.WriteLine(new string('-', Map.GetLength(1) * 4 + 1));
                Console.Write("|");
                for (int k = 0; k < Map.GetLength(1); k++)
                {
                    Console.Write(" {0} |", Map[i, k]);
                }
                Console.WriteLine();
            }
            Console.WriteLine(new string('-', Map.GetLength(1) * 4 + 1));
        }

        /// <summary>
        /// Use before calling SetPlayerToPosition
        /// </summary>
        /// <param name="mDelta"></param>
        /// <param name="nDelta"></param>
        /// <returns></returns>
        static bool IsPositionAvailable(int xDelta, int yDelta)
        {
            bool result = true;
            if (xPos + xDelta < 0 || xPos + xDelta >= Map.GetLength(0) ||
                yPos + yDelta < 0 || yPos + yDelta >= Map.GetLength(1))
            {
                result = false;
            }
            return result;
        }

        /// <summary>
        /// Only for move actions, Exception if !IsPositionAvailable
        /// </summary>
        /// <param name="mDelta"></param>
        /// <param name="nDelta"></param>
        static void SetPlayerToPosition(int xDelta, int yDelta)
        {
            int newPosX = xPos + xDelta;
            int newPosY = yPos + yDelta;

            Map[xPos, yPos] = currentPosBg;

            currentPosBg = Map[newPosX, newPosY];

            Map[newPosX, newPosY] = Player;

            xPos = newPosX;
            yPos = newPosY;
        }


        static void Task()
        {
            int size = 0;
            bool success = false;
            do
            {
                Console.Write("Enter size: ");
                string input = Console.ReadLine();
                if (!double.TryParse(input, out double number))
                {
                    Console.WriteLine("Not a number!");
                    continue;
                }

                if (number <= 0)
                {
                    Console.WriteLine("Size must be more than 0");
                    continue;
                }

                if (number - (int)number > 0)
                {
                    Console.WriteLine("Only integer!");
                    continue;
                }

                success = true;
                size = (int)number;
                Console.WriteLine();
            }
            while (!success);

            Console.WriteLine("Task 1\n");
            int[,] vs = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int k = 0; k < size; k++)
                {
                    vs[i, k] = i >= k ? i + 1 : 0;
                    Console.Write($"{vs[i, k]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Task 2\n");
            int[,] vs1 = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int k = 0; k < size; k++)
                {
                    vs[i, k] = i >= k ? (i + 1) * (k + 1) : 0;
                    Console.Write($"{vs[i, k]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
