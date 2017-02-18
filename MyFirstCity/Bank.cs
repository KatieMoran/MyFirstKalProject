using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstCity
{
    public static class Bank
    {

        public static string Name { get; set; }

        public static Account CreateAcount(string emailAdress, decimal amount)
        {
            var db = new BankModel();
            var account = new Account(emailAdress, amount);
            db.Accounts.Add(account);
            db.SaveChanges();
            return account;
        }
        public static void PrintAllAccounts(string emailAddress)
        {
            var db = new BankModel();
            foreach (var account in db.Accounts.Where(a => a.EmailAddress == emailAddress))
            {
                Console.WriteLine($"Account number):{ account.AccountNumber}, Balance: { account.Balance:C}");

            }
        }
    }
}
