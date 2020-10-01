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

            SavingsAccount savingsAccount = new SavingsAccount("940000001", "Jan", "Kowalski", 12.5M, 72080408887);
            SavingsAccount savingsAccount2 = new SavingsAccount("940000002", "Marek", "Nowak", 12.5M, 72080409998);
            Account savingsAccount3 = new SavingsAccount("940000003", "Marek", "Nowak", 12.5M, 72080409998);
            Account savingsAccount4 = new Account("940000003", "Marek", "Nowak", 12.5M, 72080409998);


            BillingAccount billingAccount = new BillingAccount("940000000003", savingsAccount.FirstName, savingsAccount.LastName, 0.0M, savingsAccount.Pesel);
                        
            Printer printer = new Printer();
            string fullName = savingsAccount.GetFullName();
            Console.WriteLine("Pierwsze konto w systemie dostał(-a): {0}", fullName);
            printer.Print(savingsAccount);
            printer.Print(savingsAccount2);
            
            printer.Print(billingAccount);





            Console.ReadKey();
        }
    }
}
