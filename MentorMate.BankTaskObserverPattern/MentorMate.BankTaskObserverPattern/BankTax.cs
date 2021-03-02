using System;
using System.Collections.Generic;
using System.Text;

namespace MentorMate.BankTaskObserverPattern
{
    abstract class BankTax
    {
        private double tax;
        private List<ICustomer> customers = new List<ICustomer>();

        public BankTax(double tax)
        {
            this.tax = tax;
        }

        public void Attach(ICustomer customer)
        {
            customers.Add(customer);
        }

        public void Dettach(ICustomer customer)
        {
            customers.Remove(customer);
        }
        public void Notify()
        {
            foreach (ICustomer customer in customers)
            {
                customer.Update(this);
            }

            Console.WriteLine("There is a new update in the taxes");
        }

        public double Tax
        {
            get { return tax; }
            set
            {
                if(tax != value)
                {
                    tax = value;
                    Notify();
                }
            }
        }
    }
}
