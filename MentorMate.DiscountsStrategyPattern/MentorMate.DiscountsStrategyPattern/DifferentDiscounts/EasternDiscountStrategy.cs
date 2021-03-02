using System;
using System.Collections.Generic;
using System.Text;

namespace MentorMate.DiscountsStrategyPattern.DifferentDiscounts
{
    class EasternDiscountStrategy : BaseDiscount
    {
        public override double Recalculate(double price)
        {
            var easternDiscount = 0.97;
            Console.WriteLine($"The total price with eatern dicount is: {price * easternDiscount}");
            return price * easternDiscount;
        }
    }
}
