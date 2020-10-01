using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    // klasa BillingAccount dziedziczy po klasie Account
    class BillingAccount : Account
    {

        // Używamy konstruktora bazowego
        public BillingAccount(string accountNumber, string firstName, string lastName, decimal balance, long pesel)
               : base(accountNumber, firstName, lastName, balance, pesel)
        { 
        }
        

    }
}
