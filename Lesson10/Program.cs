using System;

namespace Lesson10
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 a = 5;
            Point2D point = new Point2D();
            point.GetType();
            Console.ReadKey();
            Gender g = (Gender)1;
            int i = 3;
            Gender m = Enum.Parse<Gender>("Male");
            if (g == Gender.Female)
            {

            }
            else if (i == (int)Gender.Male)
            {

            }
        }

        public struct Point2D
        {
            public float X { get; set; }

            public float Y { get; set; }

            public Point2D(float x, float y)
            {
                X = x;
                Y = y;
            }

            public override string ToString()
            {
                return $"{X}; {Y}";
            }

            public void PrintInfo()
            {
                Console.WriteLine(ToString());
            }
        }

        public enum Gender
        {
            Other,
            Female = 1,
            Male = 2
        }

        public enum Day
        {
            Monday = 1,
            Tuesday = 2
        }
    }
}
