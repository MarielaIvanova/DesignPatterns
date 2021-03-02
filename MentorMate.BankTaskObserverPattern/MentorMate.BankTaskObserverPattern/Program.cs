using System;
using System.Collections.Generic;

namespace MentorMate.BankTaskObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var newTax = new TypeOfTax(5);
            newTax.Attach(new Customer("Angel",newTax));
            newTax.Attach(new Customer("Petar", newTax));
            newTax.Attach(new Customer("Ivan", newTax));

            newTax.Tax = 0.7;

        }
    }
}
