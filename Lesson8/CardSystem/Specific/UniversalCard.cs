using System;
using Lesson8.CardSystem.Interfaces;

namespace Lesson8.CardSystem.Specific
{
    public class UniversalCard : CommonCard, ICashWihdrawal
    {
        public UniversalCard(string number, CardSecurity security, DateTime expirationDate, Customer owner, Bank emittent)
            : base(number, security, expirationDate, owner, emittent)
        {
        }

        public decimal AtmWithdraw()
        {
            throw new NotImplementedException();
        }

        public override decimal DepositCommission(decimal amount)
        {
            return base.DepositCommission(amount);
        }

        public override decimal WithdrawCommission(decimal amount)
        {
            return amount * 0.005m;
        }
    }
}
