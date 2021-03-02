using MentorMate.DiscountsStrategyPattern.DifferentDiscounts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MentorMate.DiscountsStrategyPattern
{
    class Discount
    {
        private double price;
        private BaseDiscount _baseDiscount;

        public void SetBaseDicount(BaseDiscount baseDiscount)
        {
            this._baseDiscount = baseDiscount;
        }

        public void setPrice(double price)
        {
            this.price = price;
        }

        public double Recalculate()
        {
            return _baseDiscount.Recalculate(price);
        }
    }
}
