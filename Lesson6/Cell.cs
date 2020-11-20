using System;
using System.Collections.Generic;

namespace Lesson6
{
    public class Cell
    {
        private char initValue;
        private char cellValue;

        public char CellValue
        {
            get { return cellValue; }
            set { cellValue = value; }
        }

        public bool IsPlayerKeeper { get; set; }
        public bool CanMove { get; }

        public int InMapPositionX { get; }
        public int InMapPositionY { get; }

        public Cell(int x, int y)
        {
            InMapPositionX = x;
            InMapPositionY = y;

            char element = ' ';
            if (x == 1 && y == 1)
            {
                CanMove = true;
            }
            else
            {
                int randValue = new Random().Next(0, 3);
                element = randValue == 1 ? '#' : randValue == 2 ? '@' : ' ';
                CanMove = randValue != 1;
            }

            initValue = element;
            CellValue = element;
        }

        public void SetPlayer(char player)
        {
            if (CanMove)
            {
                IsPlayerKeeper = true;
                CellValue = player;
            }
            else
            {
                throw new Exception("CanMove = false");
            }
        }

        public void Reset()
        {
            IsPlayerKeeper = false;
            CellValue = initValue;
        }

        public override string ToString()
        {
            return $" {CellValue} ";
        }
    }
}
