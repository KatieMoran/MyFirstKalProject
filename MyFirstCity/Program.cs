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
                Console.WriteLine("****Welcome to my bank!******");
                Console.WriteLine("Please provide your email adress:");
                var emailaddress = Console.ReadLine();
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. create an account");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Print all accounts");
                Console.WriteLine("Please select one of the options from the above:");
                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "0":
                        return;
                    case "1":
                        var myAccount = Bank.CreateAcount(emailaddress, 100M);
                        Console.WriteLine($"The balance in my account - {myAccount.AccountNumber} is {myAccount.Balance:C}");

                        break;
                    case "2":
                        Bank.PrintAllAccounts(emailaddress);
                        Console.Write("Select an accountnumber: ");
                        var accountNum = Convert.ToInt32 (Console.ReadLine());

                        Console.Write("Enter an amount to deposit:");
                        var amount= Convert.ToDecimal(Console.ReadLine());

                        Bank.Deposit(accountNum, amount);
                        break;
                    case "3":
                        break;
                    case "4":
                        Bank.PrintAllAccounts(emailaddress);
                        break;
                    default:
                        Console.WriteLine("Sorry, option not available");
                        break;

                }
            }
        }
    }