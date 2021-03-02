using System;
using System.Collections.Generic;
using System.Text;

namespace MentorMate.AddFunctionalityDecoratorPattern
{
    public class SalaryDecorator : BaseSalary
    {
        protected BaseSalary _baseSalary;
        public SalaryDecorator(BaseSalary _baseSalary, double baseSalary):base(baseSalary)
        {
            this._baseSalary = _baseSalary;
        }
        public override double CalculateTotalSalary()
        {
            Console.WriteLine($"The total salary in class decorator is:" );
            return _baseSalary.CalculateTotalSalary();
        }
    }
}
