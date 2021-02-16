using System;

namespace Banking {
    class Program2 {
        static void Main(string[] args) {

            var acct2 = new Account();
            acct2.AccountNumber = "500.00";
            Console.WriteLine($"Account {acct2.AccountNumber} balance is {acct2.Balance}");

            acct2.Withdrawal(200);
            Console.WriteLine($"Account {acct2.AccountNumber} balance is {acct2.Balance}");

            acct2.Deposit(250);
            Console.WriteLine($"Account {acct2.AccountNumber} balance is {acct2.Balance}");

            acct2.Deposit(250);
            Console.WriteLine($"Account {acct2.AccountNumber} balance is {acct2.Balance}");

            acct2.Withdrawal(50);
            Console.WriteLine($"Account {acct2.AccountNumber} balance is {acct2.Balance}");

            acct2.Deposit(1000);
            Console.WriteLine($"Account {acct2.AccountNumber} balance is {acct2.Balance}");

            acct2.Withdrawal(500);
            Console.WriteLine($"Account {acct2.AccountNumber} balance is {acct2.Balance}");

            acct2.Deposit(550);
            Console.WriteLine($"Account {acct2.AccountNumber} balance is {acct2.Balance}");

            acct2.Withdrawal(50);
            Console.WriteLine($"Account {acct2.AccountNumber} balance is {acct2.Balance}");



        }

    }
}








