﻿using System;
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
            Console.WriteLine("****Welcome to my bank * ***");
            while (true)
            {
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. create an account");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("Please select one of the options from the above:");
                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "0":
                        return;
                    case "1":
                        Console.WriteLine("Plese provide your email address");
                        var emailAddress = Console.ReadLine();
                        var myAccount = new Account(emailAddress);
                        Console.WriteLine($"The balance in my account - {myAccount.AccountNumber} is {myAccount.Balance:C}");
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    default:
                        Console.WriteLine("Sorry, option not available");
                        break;

                }
            }
        }
    }
}