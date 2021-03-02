using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace MentorMate.AddFunctionalityDecoratorPattern
{
    public class AdditionlaSalaryFunctionality : SalaryDecorator
    {
        public AdditionlaSalaryFunctionality(BaseSalary _baseSalary, double baseSalary) : base(_baseSalary,baseSalary) 
        {
        }

        public override double CalculateTotalSalary()
        {
            Console.WriteLine($"Calculating the total salary in the {nameof(AdditionlaSalaryFunctionality)} class");

            var regularSalary = base.CalculateTotalSalary();
            var indexOfIncreasment = 1.1;

            return regularSalary*indexOfIncreasment;
        }


    }
}
