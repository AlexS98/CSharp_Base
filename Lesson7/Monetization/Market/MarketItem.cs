using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson7.Monetization.Market
{
    public class MarketItem
    {
        public int Price { get; set; }
        public bool IsDiscount { get; } = true;
        public int ItemType { get; }
    }
}
