using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    // Dodaliśmy tutaj klasę, na której bazują wszystkie konta
    // ustawiamy klasę jako abstrakcyjną aby nie tworzyć obiektów
    // niemożliwe jest
    // Account Konto = new Account();
    // ale nadal możliwe jest 
    // Account Konto = new SavingsAccount();
    // Konto, jeżeli nie jest konkretnego typu, nie stanowi czegoś co powinno mieć rzeczywistą reprezentację w postaci gotowego obiektu.
    // Konto jest w tym przypadku czymś abstrakcyjnym. Czymś na czym chcemy oprzeć konkretne typy kont,
    // ale samo w sobie nie stanowi czegoś co nadaje się do wyprodukowania, utworzenia.


    abstract class Account
    {
        public string AccountNumber;
        public decimal Balance;
        public string FirstName;
        public string LastName;
        public long Pesel;

        public Account()
        {
        }

        
        public Account(string accountNumber, string firstName, string lastName, decimal balance, long pesel)
        {
            AccountNumber = accountNumber;
            FirstName = firstName;
            LastName = lastName;
            Balance = balance;
            Pesel = pesel;
        }

        public string GetBalance()
        {
            string balanceX = $"{Balance} zł";
            return balanceX;
        }

        public string GetFullName()
        {
            string fullName = string.Format("{0} {1}", FirstName, LastName);
            return fullName;
        }
    }
}
