using System;

namespace MentorMate.AddFunctionalityDecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            double salary = 2500;
            var regularSalary = new RegularSalary(salary);
            Console.WriteLine(regularSalary.CalculateTotalSalary());
            Console.WriteLine();

            var additionalSalary = new AdditionlaSalaryFunctionality(regularSalary,salary);
            Console.WriteLine(additionalSalary.CalculateTotalSalary());
        }
    }
}
