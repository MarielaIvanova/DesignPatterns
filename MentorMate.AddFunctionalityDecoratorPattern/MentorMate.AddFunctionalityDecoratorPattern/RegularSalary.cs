using System;
using System.Collections.Generic;
using System.Text;

namespace MentorMate.AddFunctionalityDecoratorPattern
{
    public class RegularSalary : BaseSalary
    {
        public RegularSalary(double baseSalary) : base(baseSalary)
        {

        }
        public override double CalculateTotalSalary()
        {
            Console.WriteLine($"You are receiving regular salary which is: ");
            return baseSalary;
        }
    }
}
