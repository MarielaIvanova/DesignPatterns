using System;
using System.Collections.Generic;
using System.Text;

namespace MentorMate.DiscountsStrategyPattern.DifferentDiscounts
{
    class RestDiscountStrategy: BaseDiscount
    {
        public override double Recalculate(double price)
        {
            var restDiscount = 1;
            Console.WriteLine($"The total price with rest dicount is: {price * restDiscount}");
            return price * restDiscount;
        }
    }
}
