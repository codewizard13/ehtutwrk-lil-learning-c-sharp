// C# code​​​​​​‌‌‌‌‌‌​​​‌​​‌‌‌‌​‌​​​‌‌‌‌ below
using System;

// Write your answer here, and then test your code.

public class Answer {

    // Change these Boolean values to control whether you see 
    // the expected result and/or hints.
   public  static Boolean ShowExpectedResult = true;
   public  static Boolean ShowHints = true;

}

public class BankAccount {
    private string _firstName;
    private string _lastName;
    // private string _fullName;

    public BankAccount(string first_name, string last_name, decimal start_balance=0.0m) {
        _firstName = first_name;
        _lastName = last_name;
        Balance = start_balance;
    }

    public string FirstName {
        // return the name
        get { return _firstName; }

        // validate new property value with setter
        set {
            if ( value == "" ) {
                throw new ArgumentException("First Name cannot be blank");
            }
            _firstName = value;
        }

    }

    public string LastName {
        // return the name
        get { return _lastName; }

        // validate new property value with setter
        set {
            if ( value == "" ) {
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
        get {return $"{FirstName} {LastName}";}
    }

}



// Child Classes

public class CheckingAcct : BankAccount {
    // private string _firstName;
    // private string _lastName;
    public CheckingAcct(string first_name, string last_name, decimal start_balance=0.0m) 
        : base(first_name, last_name, start_balance) {
        
    }

}

// public class SavingsAcct : BankAccount {
    
// }
