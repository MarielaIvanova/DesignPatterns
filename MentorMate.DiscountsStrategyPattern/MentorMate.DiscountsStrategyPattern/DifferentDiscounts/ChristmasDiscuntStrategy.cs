using System;
using System.Collections.Generic;
using System.Text;

namespace MentorMate.DiscountsStrategyPattern.DifferentDiscounts
{
    class ChristmasDiscuntStrategy : BaseDiscount
    {
        public override double Recalculate(double price)
        {
            var christmasDiscount = 0.95;
            Console.WriteLine($"The total price with christmas dicount is: {price * christmasDiscount}");
            return price * christmasDiscount;
        }
    }
}
