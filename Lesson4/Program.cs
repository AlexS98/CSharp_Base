using System;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3 };

            int[,] array2dim = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "; ");
            }
            Console.WriteLine();

            for (int i = 0; i < array2dim.GetLength(0); i++)
            {
                for (int k = 0; k < array2dim.GetLength(1); k++)
                {
                    Console.Write(array2dim[i, k] + "; ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Random random = new Random();

            for (int m = 0; m < array.Length; m++)
            {
                array[m] = random.Next(1, 1_000_000);
            }

            foreach (var item in array2dim)
            {
                Console.WriteLine("{0}; ", item);
            }

            string[,] map = new string[10, 10]
            {
                {"", "", "", "", "", "", "", "", "", "" },
                {"", "", "", "", "", "", "", "", "", "" },
                {"", "", "x", "", "", "", "", "x", "x", "" },
                {"", "", "x", "", "", "", "", "", "", "" },
                {"", "", "x", "", "", "", "", "", "", "" },
                {"", "", "", "", "", "", "", "", "", "" },
                {"", "", "", "", "", "x", "x", "x", "", "" },
                {"", "", "", "", "", "", "", "", "", "" },
                {"", "", "", "", "", "", "", "", "", "" },
                {"", "", "", "", "", "", "", "", "", "" }
            };

            Console.WriteLine("Option 1:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(new string('-', 10 * 4 + 1));
                Console.Write("|");
                for (int k = 0; k < 10; k++)
                {
                    //string result;
                    //if (map[i, k] != "")
                    //{
                    //    result = map[i, k];
                    //}
                    //else
                    //{
                    //    result = " ";
                    //}
                    Console.Write(" {0} |", (map[i, k] != "" ? map[i, k] : " "));
                    //string res = map[i, k] != "" ? 1 == 0 ? "fvwfvdfvsdfv" : "sdfvsdfvsdfv" : " ";

                    //if (map[i, k] != "")
                    //{
                    //    if (1 == 0)
                    //    {
                    //        res = "fvwfvdfvsdfv";
                    //    }
                    //    else
                    //    {
                    //        res = "sdfvsdfvsdfv";
                    //    }
                    //}
                    //else
                    //{
                    //    res = " ";
                    //}
                }
                Console.WriteLine();
            }
            Console.WriteLine(new string('-', 10 * 4 + 1));

        }
    }
}
