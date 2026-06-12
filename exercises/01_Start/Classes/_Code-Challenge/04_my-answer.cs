// C# code​​​​​​‌‌‌‌‌‌​​​‌​​‌‌‌‌​‌​​​‌‌‌‌ below
using System;

// Write your answer here, and then test your code.

public class Answer
{

    // Change these Boolean values to control whether you see 
    // the expected result and/or hints.
    public static Boolean ShowExpectedResult = true;
    public static Boolean ShowHints = true;

}

public class BankAccount
{
    private string _firstName;
    private string _lastName;
    // private string _fullName;

    public BankAccount(string first_name, string last_name, decimal start_balance = 0.0m)
    {
        _firstName = first_name;
        _lastName = last_name;
        Balance = start_balance;
    }

    public string FirstName
    {
        // return the name
        get { return _firstName; }

        // validate new property value with setter
        set
        {
            if (value == "")
            {
                throw new ArgumentException("First Name cannot be blank");
            }
            _firstName = value;
        }

    }

    public string LastName
    {
        // return the name
        get { return _lastName; }

        // validate new property value with setter
        set
        {
            if (value == "")
            {
                throw new ArgumentException("Last Name cannot be blank");
            }
            _lastName = value;
        }

    }

    public decimal Balance
    {
        get; set;
    }

    public string AccountOwner
    {
        get { return $"{FirstName} {LastName}"; }
    }

    public virtual decimal Deposit(decimal amount)
    {
        Balance += amount;
        return Balance;
    }

    public virtual decimal Withdraw(decimal amount)
    {
        Balance -= amount;
        return Balance;
    }

}



// Child Classes

public class CheckingAcct : BankAccount
{

    public CheckingAcct(string first_name, string last_name, decimal start_balance = 0.0m)
        : base(first_name, last_name, start_balance)
    {

    }

    public override decimal Withdraw(decimal amount)
    {
        // Update the balance
        Balance -= amount;

        if (amount > Balance)
        {
            // Charge $35 fee
            Balance -= 35;
        }

        return Balance;
    }

}

public class SavingsAcct : BankAccount
{
    private int _withdrawl_count = 0;

    public SavingsAcct(string first_name, string last_name, decimal interest_rate, decimal start_balance = 0.0m)
        : base(first_name, last_name, start_balance)
    {
        InterestRate = interest_rate;
    
    }

    public decimal InterestRate
    {
        get; set;
    }

    public decimal ApplyInterest()
    {
        Balance *= (1 + InterestRate);
        return Balance;
    }

    public override decimal Withdraw(decimal amount)
    {
        // Prevent withdrawl if it would overdraft
        // if ( amount > Balance ) { return "\n\n------ Withdrawl not allowed - Insufficient funds ------\n\n"; }
        if ( amount > Balance ) { return Balance; }

        Balance -= amount;
        _withdrawl_count++;

        // Charge $2 if withdrawls greater than 3
        if (_withdrawl_count > 3) {
            Balance -= 2;
        }

        return Balance;

    }



}
