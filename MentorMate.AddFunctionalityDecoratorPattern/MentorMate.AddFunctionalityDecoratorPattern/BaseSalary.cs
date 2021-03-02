using System;
using System.Collections.Generic;
using System.Text;

namespace MentorMate.AddFunctionalityDecoratorPattern
{
    public abstract class BaseSalary 
    {
        protected double baseSalary { get; }
        public BaseSalary(double baseSalary)
        {
            this.baseSalary = baseSalary;
        }

        public abstract double CalculateTotalSalary();
    }
}
