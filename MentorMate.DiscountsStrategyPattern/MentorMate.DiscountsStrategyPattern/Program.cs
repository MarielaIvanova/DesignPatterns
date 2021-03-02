using MentorMate.DiscountsStrategyPattern.DifferentDiscounts;
using System;

namespace MentorMate.DiscountsStrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Discount _dicount = new Discount();
            double price = 100;
            _dicount.setPrice(price);

            _dicount.SetBaseDicount(new ChristmasDiscuntStrategy());
            _dicount.Recalculate();
            _dicount.SetBaseDicount(new EasternDiscountStrategy());
            _dicount.Recalculate();
            _dicount.SetBaseDicount(new NewYearDiscountStrategy());
            _dicount.Recalculate();
            _dicount.SetBaseDicount(new RestDiscountStrategy());
            _dicount.Recalculate();
        }
    }
}
