using System;
using System.Collections.Generic;
using System.Text;
using Lesson8.CardSystem.Interfaces;

namespace Lesson8
{
    public class Atm
    {
        public decimal Withdraw(ICashWihdrawal card)
        {
            return card.AtmWithdraw();
        }
    }
}
