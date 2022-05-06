using System;
using CaikeBank.Entities;

namespace CaikeBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Caike", 1000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with ${account.Balance} initial balance");

            account.MakeWithdrawal(120, DateTime.Now, "Restaurant");
            Console.WriteLine($"Actual balance ${account.Balance}");

            //// Test that the initial balances must be positive.
            //BankAccount invalidAccount;
            //try
            //{
            //    invalidAccount = new BankAccount("invalid", -55);
            //}
            //catch (ArgumentOutOfRangeException e)
            //{
            //    Console.WriteLine("Exception caught creating account with negative balance");
            //    Console.WriteLine(e.ToString());
            //}

            account.MakeWithdrawal(50, DateTime.Now, "Playstation game");
            Console.WriteLine($"Actual balance ${account.Balance}");

            //// Test for a negative balance.
            //try
            //{
            //    account.MakeWithdrawal(750, DateTime.Now, "Attempt to overdraw");
            //}
            //catch (InvalidOperationException e)
            //{
            //    Console.WriteLine("Exception caught trying to overdraw");
            //    Console.WriteLine(e.ToString());
            //}

            Console.WriteLine();
            Console.WriteLine(account.GetAccountHistory());

            Console.ReadKey();
        }
            
    }
}
