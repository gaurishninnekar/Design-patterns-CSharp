using System;
using System.Reflection.Metadata.Ecma335;





namespace DesignPatterns.Src.OOPPrinciples.Encapsulation;

public class BankAccount
{
    private decimal Balance;

    public BankAccount(decimal balance)
    {
        Deposit(balance);
    }

    public decimal GetBalance()
    {
        return this.Balance;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Deposit amount be positive");
        }

        this.Balance += amount;
    }

    public void Withdraw(decimal amount)
    {

        if (amount <= 0)
        {
            throw new ArgumentException("Enter a value greater than 0");
        }

        if (amount >= this.Balance)
        {
            throw new InvalidOperationException("Enter amount less than the balance");
        }
        this.Balance -= amount;


    }


}
