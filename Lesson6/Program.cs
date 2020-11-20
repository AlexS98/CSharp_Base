using System;

namespace Lesson6
{
    class Program
    {
        const char Player = '☻';
        static Cell[,] Map = new Cell[15, 15];
        static int xPos = 0;
        static int yPos = 0;
        static bool isAlive = true;
        static int turnCount = 0;

        static void Main(string[] args)
        {
            GenerateMap();
            // set player to init position
            Map[1, 1].SetPlayer(Player);
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
                    Map[i, k] = new Cell(i, k);
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
                    if (Map[i, k].IsPlayerKeeper)
                    {
                        ToConsole(Map[i, k].ToString(), ConsoleColor.Yellow);
                        Console.Write("|");
                    }
                    else
                    {
                        Console.Write($"{Map[i, k]}|");
                    }
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
            bool isInBounds = true;

            int newPosX = xPos + xDelta;
            int newPosY = yPos + yDelta;

            if (xPos + xDelta < 0 || xPos + xDelta >= Map.GetLength(0) ||
                yPos + yDelta < 0 || yPos + yDelta >= Map.GetLength(1))
            {
                isInBounds = false;
            }
            return isInBounds && Map[newPosX, newPosY].CanMove;
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

            Map[xPos, yPos].Reset();
            Map[newPosX, newPosY].SetPlayer(Player);

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

        public static void ToConsole(string str, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.Write(str);
            Console.ResetColor();
        }

        static void Recursion(params int[] array)
        {
            if (array.Length > 1)
            {
                int[] newLine = new int[array.Length - 1];
                for (int i = 0; i < newLine.Length; i++)
                {
                    newLine[i] = array[i] + array[i + 1];
                }
                Recursion(newLine);
                foreach (int item in array)
                {
                    Console.Write($"{item}\t");
                }
                Console.WriteLine();
            }
            else if (array.Length == 1)
            {
                Console.WriteLine($"{array[0]}");
            }
            else
            {
                Console.WriteLine("Empty array");
            }
        }
    }
}
