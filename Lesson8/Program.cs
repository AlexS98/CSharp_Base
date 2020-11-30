using System;
using Lesson8.CardSystem;

namespace Lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank("qwe", 1_000_000);
            Customer customer = new Customer("qwe", "qwe", 123456789, new Address());

            CommonCard card = bank.EmitCard("sav", customer);
            customer.AddCards(new[] { card });
            card.Deposit(150);
            card.Withdraw(120);
            Console.ReadKey();
        }
    }
}
