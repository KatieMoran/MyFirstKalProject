using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstCity
{
    class Program
    {
        private static object account;

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
                Console.WriteLine("5.Print all transactions");
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
                case"2":
                    try
                    {
                        PrintAllAccounts(emailaddress);
                        Console.Write("select an accountnumber: ");
                        var accountNum2 = Convert.ToInt32(Console.ReadLine());


                        Console.Write("Enter an amount to deposit:");
                        var amount2 = Convert.ToDecimal(Console.ReadLine());
                        Bank.Deposit(accountNum2, amount2);
                    }
                    catch(FormatException)
                    {
                        Console.WriteLine("Invalid vaue-try again!");
                    }
                    catch (ArgumentOutOfRangeException ox)
                    {
                        Console.WriteLine(ox.Message + "Please try again.");
                    }
                    catch (ArgumentException ax)
                    {
                        Console.WriteLine(ax.Message + "Please try again.");
                    }
                    
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error:" + ex.Message);
                    }
                    break;
                    
                    
                   case "3":
                        PrintAllAccounts(emailaddress);
                        Console.Write("select an accountnumber:");
                        var accountNum = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter an amount to deposit:");
                        var amount = Convert.ToDecimal(Console.ReadLine());

                        Bank.Withdrawl (accountNum, amount);
                       break;
                     case "4":
                        PrintAllAccounts(emailaddress);
                        break;
                    case "5":
                       PrintAllAccounts(emailaddress);
                       Console.Write("Select an accountnumber: ");
                       accountNum = Convert.ToInt32(Console.ReadLine());

                      var transactions = Bank. GetAllTransactions(accountNum);
                       foreach(var transaction in transactions)
                      {
                      Console.WriteLine($"ID: { transaction.TransactionNumber}, Description: {transaction.Desciption}, Type: {transaction.TypeofTransaction}, Amount:  {transaction.Amount}, Date: {transaction.TransactionDate}");
                       }
                       break;
                     {                                    
                      Console.WriteLine("Sorry, option not available");

                       break;
                      }
            }

        static void PrintAllAccount(string emailAddress)
        {
            var accounts = Bank.GetAllAccounts(emailAddress);
            foreach (var account in accounts) db.Accounts.Where(a=> account.EmailAddress ==emailAddress));
            {
                Console.WriteLine($"Account number):{account.AccountNumber}, Balance: {account.Balance:C}");

            }
        }
    {

  }

   