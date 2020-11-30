using System;

namespace Lesson9
{
    class Program
    {
        static User[] usersDb = new User[100];

        static void Main(string[] args)
        {

        }

        static void GenerateUsers(int capacity = 10)
        {
            int usersCount = 0;
            while (usersDb[usersCount] != null)
            {
                usersCount++;
                if (usersCount >= usersDb.Length)
                {
                    Console.WriteLine("Db is full");
                    return;
                }
            }

            if (usersCount + capacity > usersDb.Length)
            {
                Console.WriteLine("No available space, try to decrease capacity");
                return;
            }

            for (int i = 0; i < capacity; i++)
            {
                usersDb[usersCount + i] = new User(usersCount + i + 1, "", "", 0, null);
            }
        }
    }
}
