using System;
using System.Text;

namespace Lesson11
{
    public class ChessRenderer
    {
        public static void Render()
        {
            Console.OutputEncoding = Encoding.Unicode;
            string c = "♖♘♗♔♕♗♘♖♜♞♝♚♛♝♞♜";
            char[,] chessDesk = new char[8, 8];
            for (int i = 0; i < 8; i++)
            {
                for (int k = 0; k < 8; k++)
                {
                    if (i == 0)
                    {
                        chessDesk[i, k] = c[k];
                    }
                    else if (i == 1)
                    {
                        chessDesk[i, k] = '♙';
                    }
                    else if (i == 6)
                    {
                        chessDesk[i, k] = '♟';
                    }
                    else if (i == 7)
                    {
                        chessDesk[i, k] = c[k + 8];
                    }
                    else
                    {
                        chessDesk[i, k] = (i + k) % 2 == 1 ? '⬛' : '⬜';
                    }
                }
            }

            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine(new string('-', 8 * 3 + 1));
                for (int k = 0; k < 8; k++)
                {
                    Console.Write($"|{chessDesk[i, k].ToChessFormat()}");
                }
                Console.WriteLine('|');
            }
            Console.WriteLine(new string('-', 8 * 3 + 1));
            Console.WriteLine(c);
        }
    }
}
