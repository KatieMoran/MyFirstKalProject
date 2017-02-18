using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstCity
{
    public enum TransactionType
    {
        Credit,
        Debit
    }
    public class Transaction
    {
        [Key]
        public int TransactionNumber { get; set; } 

        public DateTime TransactionDate { get; set;  }

        public String Description { get; set; }

        public TransactionType TypeofTransaction { get; set;  }

        public decimal Amount { get; set; }

        [ForeignKey("Acount")]
        public int AccountNumber { get; set; }
        public virtual Account Account { get; set; }

    }
}
