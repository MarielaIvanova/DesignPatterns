using System;
using System.Collections.Generic;
using System.Text;

namespace MentorMate.DiscountsStrategyPattern.DifferentDiscounts
{
    class NewYearDiscountStrategy : BaseDiscount
    {
        public override double Recalculate(double price)
        {
            var newYearDiscount = 0.99;
            Console.WriteLine($"The total price with new year dicount is:{price * newYearDiscount}");
            return price * newYearDiscount;
        }
    }
}
