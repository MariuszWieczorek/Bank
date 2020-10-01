using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class SavingsAccount:Account
    {
        public SavingsAccount() : base()
        {
        }

        public SavingsAccount(string accountNumber, string firstName, string lastName, decimal balance, long pesel)
               : base(accountNumber, firstName, lastName, balance, pesel)
        {
        }

    }
}
