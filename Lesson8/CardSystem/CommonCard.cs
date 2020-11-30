using System;

using Lesson8.CardSystem;

namespace Lesson8
{
    public abstract class CommonCard
    {
        public string Number { get; set; }
        protected CardSecurity Security { get; set; }
        public DateTime ExpirationDate { get; set; }
        public Customer Owner { get; set; }
        public Bank Emittent { get; set; }

        public decimal Balance { get; set; }

        public decimal DepositCommissionPercent { get; set; }
        public decimal WithdrawCommissionPercent { get; set; }

        public CommonCard(string number, CardSecurity security, DateTime expirationDate, Customer owner, Bank emittent)
        {
            Number = number;
            Security = security;
            ExpirationDate = expirationDate;
            Owner = owner;
            Emittent = emittent;
            Balance = 0;
            DepositCommissionPercent = 0.05m;
            WithdrawCommissionPercent = 0.05m;
        }

        public void Deposit(decimal amount)
        {
            decimal commission = DepositCommission(amount);
            decimal totalAmount = amount - commission;

            if (amount <= 0 || amount < commission)
            {
                Console.WriteLine("Required: amount > 0");
            }

            Emittent.ReceiveFunds(commission);

            Balance += totalAmount;
        }

        public decimal Withdraw(decimal amount)
        {
            decimal commission = WithdrawCommission(amount);

            if (amount <= 0)
            {
                Console.WriteLine("Required: amount > 0");
            }

            if (Balance < amount + commission)
            {
                Console.WriteLine("Not enough money");
            }

            Balance -= amount + commission;

            Emittent.ReceiveFunds(commission);

            return amount;
        }

        public virtual decimal DepositCommission(decimal amount)
        {
            return amount * DepositCommissionPercent;
        }

        public abstract decimal WithdrawCommission(decimal amount);
    }
}
