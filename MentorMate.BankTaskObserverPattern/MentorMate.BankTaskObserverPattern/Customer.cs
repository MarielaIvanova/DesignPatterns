using System;
using System.Collections.Generic;
using System.Text;

namespace MentorMate.BankTaskObserverPattern
{
    class Customer : ICustomer
    {
        private string name;
        private BankTax bankTax;

        public Customer(string name,BankTax bankTax)
        {
            this.name = name;
            this.bankTax = bankTax;
        }
        public void Update(BankTax _bankTax)
        {
            Console.WriteLine($"Notified {this.name} of the tax's change to {bankTax.Tax}");
        }

        public BankTax BankTax 
        {
            get { return bankTax; }
            set { bankTax = value; }
        }
    }
}
