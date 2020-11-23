using System;
using System.Collections.Generic;
using System.Text;
using Lesson7.Monetization.Market;
using Lesson7.Monetization.PaymentProcess;

namespace Lesson7.Monetization
{
    public class Account
    {
        public User Owner { get; set; }

        public PaymentInfo PaymentInfo { get; set; }
        public Transaction[] PaymentHistory { get; set; }

        public Balance Balance { get; set; }

        public MarketItem[] PurchasedItems { get; }
    }
}
