// Program.cs

using System;

class Program
{
    static void Main()
    {
        // Create an account with initial balance
        Account myAccount = new Account(12345, 1000.0);

        // Perform transactions
        Transaction.PerformTransaction(myAccount, 500.0);

        // Display the final account information
        Console.WriteLine("Final account information:");
        myAccount.Display();
    }
}
