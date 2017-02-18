using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstCity
{
    /// <summary>
    /// This class defines the account for a bank
    /// This is the blue print
    /// </summary>
    public class Account
    {
        #region Statics
        private static int lastAccountNumber = 0;
        private decimal amount;
        #endregion

        #region Properties
        /// <summary>
        /// The Acccount Number for a bank
        /// </summary>
        [Key]
        public int AccountNumber { get; private set; }

        public string AccountName { get; set; }
        /// <summary>
        /// email of the account
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// Balance of the account
        /// </summary>
        public decimal Balance { get; private set; }
        
        public virtual ICollection<Transaction> Transactions { get; set;  }
        #endregion
        #region Methods

        public Account() : this ("", 0.0M)
        {
            //this.AccountNumber = ++lastAccountNumber;
        }
        public Account(string emailAddress) : this (emailAddress, 0.0M)
        {
            //this.AccountNumber = ++lastAccountNumber;
            //this.EmailAddress = emailAddress;
           
        }

        public Account(string emailAddress, decimal amount) 
        {
            this.EmailAddress = emailAddress;
            this.Balance = amount;
        }

        public decimal Deposit(decimal amount)
        {
            Balance = Balance + amount;
            return Balance;
        }
        public void withdrawl(decimal amount)
        {
            Balance -= amount;
        }
        #endregion
    }
}
  