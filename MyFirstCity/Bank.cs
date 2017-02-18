using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstCity
{
    public static class Bank
    {

        private static List<Account> accounts = new List<Account>();
        public static string Name { get; set; }

        public static Account CreateAcount(string emailAdress, decimal amount)
        {
            var account = new Account(emailAdress, amount);
            accounts.Add(account);
            return account;
        }
        public static void PrintAllAccounts(string emailAddress)
        {
            foreach (var account in accounts.Where(a => a.EmailAddress == emailAddress))
            {
                Console.WriteLine($"Account number):{ account.AccountNumber}, Balance: { account.Balance:C}");

            }
        }
    }
}
