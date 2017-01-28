using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstCity
{
    class Program

    {
        static void Main(string[] args)
        {
            ///create new object/instance
            var myAccount = new User();
            myAccount.EmailAddress = "test@test.com";
            myAccount.Deposit(200.50M);
            Console.WriteLine($"The balance in my account - {myAccount.AccountNumber} is {myAccount.Balance:C}");

         
        }
    }
}
