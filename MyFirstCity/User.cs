using System;
using System.Collections.Generic;
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
      
        public int AccountNumber { get; private set; }

        /// <summary>
        /// email of the account
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// Balance of the account
        /// </summary>
        public decimal Balance { get; private set; }
        #endregion
        #region Methods

        public Account()
        {
            this.AccountNumber = ++lastAccountNumber;
        }
        public Account(string emailAddress)
        {
            this.AccountNumber = ++lastAccountNumber;
            this.EmailAddress = emailAddress;
        }

        public Account(string emailAddress, decimal amount) : this(emailAddress)
        {
            this.amount = amount;
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
  