using System;

using Lesson8;

namespace Lesson9
{
    public class User : Customer, ICommonObject
    {
        public User(int id, string firstName, string lastName, long code, Address customerAddress) 
            : base(firstName, lastName, code, customerAddress)
        {
            Id = id;
        }

        public int Id { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset UpdateDate { get; set; }


        public override string ToString()
        {
            return $"Username: {FirstName} {LastName}, code: {Code}";
        }

        public void PrintInfo()
        {
            Console.WriteLine(this);
        }
    }
}
