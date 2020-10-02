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


            List<Account> accounts = new List<Account>();
            accounts.Add(new SavingsAccount(1, "Jan", "Kowalski", 72080408887));
            accounts.Add(new SavingsAccount(2, "Jan", "Kowalski", 72080408887));
            accounts.Add(new SavingsAccount(3, "Marek", "Nowak", 72080409998));
            accounts.Add(new BillingAccount(4, "Marek", "Nowak", 72080409998));
            accounts.Add(new BillingAccount(5, "Marek", "Nowak", 72080409998));

            // Nie przejmując się, która klasa tak naprawdę tym drukowaniem się zajmie.
            // Możemy więc jako typ zmiennej podawać od teraz IPrinter:
            IPrinter printer = new Printer();
            


            foreach(Account x in accounts)
            {
                printer.Print(x);
            }

            

            Console.ReadKey();
        }
    }
}
