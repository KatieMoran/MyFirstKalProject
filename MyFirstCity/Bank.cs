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
        /// <summary>
        /// Deposit money into your account.
        /// </summary>
        /// <param name="accountNumber"></param>
        /// <param name="amount"></param>
        /// <exception cref="ArgumentException"></exception>
        public static void Deposit(int accountNumber, decimal amount)
        {

            if (accountNumber <= 0)
            {
                throw new ArgumentException("Account Number is invalid");
            }

            if (amount <= 0)

            {
                throw new ArgumentException("Amount is invalid");
            }

            var db = new BankModel();
            var account = db.Accounts.Where(a => a.AccountNumber == accountNumber).FirstOrDefault();
            if (account == null)
            {
                throw new ArgumentOutOfRangeException("Invalid Account Number");
            }

            account.Deposit(amount);
            db.Entry(account).State = System.Data.Entity.EntityState.Modified;

            var transaction = new Transaction();
            transaction.TransactionDate = DateTime.Now;
            transaction.Amount = amount;
            transaction.TypeofTransaction = TransactionType.Credit;
            transaction.Description = "Depostit to the account";
            transaction.AccountNumber = accountNumber;

            db.Transactions.Add(transaction);
            db.SaveChanges();

        }

              public static void Withdrawl(int accountNumber, decimal amount)
        {

            if (accountNumber <= 0)
            {
                throw new ArgumentException("Account Number is invalid");
            }

            if (amount <= 0)

            {
                throw new ArgumentException("Amount is invalid");
            }

            var db = new BankModel();
            var account = db.Accounts.Where(a => a.AccountNumber == accountNumber).FirstOrDefault();
            if (account == null)
            {
                account.withdrawl(amount);
                db.Entry(account).State = System.Data.Entity.EntityState.Modified;

                var transaction = new Transaction();
                transaction.TransactionDate = DateTime.Now;
                transaction.Amount = amount;
                transaction.TypeofTransaction = TransactionType.Debit;
                transaction.Description = "Withdraw to the account";
                transaction.AccountNumber = accountNumber;

                db.Transactions.Add(transaction);
                db.SaveChanges();

            }
        }

        internal static object GetAllAccounts(string emailAddress)
        {
            throw new NotImplementedException();
        }

        internal static void GetAllTransactions(int accountNum)
        {
            throw new NotImplementedException();
        }
    }
        public static IQueryable<Account> GetAllAccounts(string emailAddress)
        {
            var db = new BankModel();
            return db.Accounts.Where(a => a.EmailAddress == emailAddress);
        }
        public static IQueryable<Transaction> GetAllTransactions(int accountNumber)
        {
            var db = new BankModel();
            return db.Transactions.Where(t => t.AccountNumber == accountNumber).OrderByDescending(t => t.TransactionDate);
        }
    }
}
