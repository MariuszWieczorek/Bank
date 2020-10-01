using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Nazwa: Bank";
            string author = "Autor: Mariusz Wieczorek";
            Console.WriteLine(name);
            Console.WriteLine(author);
            Console.WriteLine();

            SavingsAccount savingsAccount = new SavingsAccount(1, "Jan", "Kowalski", 72080408887);
            Account savingsAccount2 = new SavingsAccount(2, "Marek", "Nowak",  72080409998);
            Account savingsAccount3 = new SavingsAccount(3, "Marek", "Nowak",  72080409998);
            


            Account billingAccount = new BillingAccount(4, savingsAccount.FirstName, savingsAccount.LastName, savingsAccount.Pesel);

            // Nie przejmując się, która klasa tak naprawdę tym drukowaniem się zajmie.
            // Możemy więc jako typ zmiennej podawać od teraz IPrinter:
            IPrinter printer = new Printer();
            
            string fullName = savingsAccount.GetFullName();
            Console.WriteLine("Pierwsze konto w systemie dostał(-a): {0}", fullName);
            printer.Print(savingsAccount);
            printer.Print(savingsAccount2);
            
            printer.Print(billingAccount);

            
            //Console.WriteLine(savingsAccount.GenerateAccountNumber(1));



            Console.ReadKey();
        }
    }
}
