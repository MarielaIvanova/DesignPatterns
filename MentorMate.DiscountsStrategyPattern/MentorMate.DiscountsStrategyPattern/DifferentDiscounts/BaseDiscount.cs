using System;
using System.Collections.Generic;
using System.Text;

namespace MentorMate.DiscountsStrategyPattern.DifferentDiscounts
{
    public abstract class BaseDiscount
    {
        //protected double baseDiscount;
        //public BaseDiscount(double baseDiscount)
        //{
        //    this.baseDiscount = baseDiscount;
        //}
        public abstract double Recalculate(double price);
    }
}
