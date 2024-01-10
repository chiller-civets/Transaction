// Account.cs

public class Account
{
    private int accountNumber;
    private double balance;

    public Account(int accNumber, double initialBalance)
    {
        accountNumber = accNumber;
        balance = initialBalance;
    }

    public void Deposit(double amount)
    {
        balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (balance >= amount)
        {
            balance -= amount;
        }
        else
        {
            Console.WriteLine("Insufficient funds!");
        }
    }

    public void Display()
    {
        Console.WriteLine($"Account Number: {accountNumber}, Balance: ${balance}");
    }
}
