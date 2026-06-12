using System;

class Program
{
    static void Main()
    {
        bool IsSuccessful = true;
        // Create the Checking Account with initial balance.
        CheckingAcct checking = new CheckingAcct("John", "Doe", 2500.0m);
        IsSuccessful &= (checking.Balance == 2500.0m);
        IsSuccessful &= (checking.AccountOwner == "John Doe");

        Console.WriteLine(checking.AccountOwner);
        Console.WriteLine(checking.Balance);

        // // Create the Savings Account with interest and initial balance.
        // SavingsAcct saving = new SavingsAcct("Jane", "Doe", 0.03m, 1000.0m);
        // IsSuccessful &= (saving.Balance == 1000.0m);
        // IsSuccessful &= (saving.AccountOwner == "Jane Doe");

        // // Deposit some money in each account.
        decimal deposit_amount = 200.0m;
        checking.Deposit(deposit_amount);
        // saving.Deposit(150.0m);
        IsSuccessful &= (checking.Balance == 2700.0m);
        // IsSuccessful &= (saving.Balance == 1150.0m);

        Console.WriteLine($"Checking Balance after depositing {deposit_amount} = {checking.Balance}");

        // // Make some withdrawals from each account.
        decimal withdrawl_amount = 50.0m;
        checking.Withdraw(withdrawl_amount);
        // saving.Withdraw(125.0m);
        IsSuccessful &= (checking.Balance == 2650.0m);
        // IsSuccessful &= (saving.Balance == 1025.0m);

        Console.WriteLine($"Checking Balance after withdrawing {withdrawl_amount} = {checking.Balance}");


        // // Apply the Savings interest.
        // saving.ApplyInterest();
        // IsSuccessful &= (saving.Balance == 1055.75m);

        // // More than three Savings withdrawals should result in $2 charge.
        // saving.Withdraw(10.0m);
        // saving.Withdraw(20.0m);
        // saving.Withdraw(30.0m);
        // IsSuccessful &= (saving.Balance == 993.75m);

        // // try to overdraw savings - this should be denied
        // saving.Withdraw(2000.0m);
        // // try to overdraw checking - should be allowed and result in extra charge
        withdrawl_amount = 3000.0m;
        checking.Withdraw(withdrawl_amount);
        // IsSuccessful &= (saving.Balance == 993.75m);
        IsSuccessful &= (checking.Balance == -385.00m);

        Console.WriteLine($"Checking Balance after withdrawing {withdrawl_amount} (+ $35 overdraft fee) = {checking.Balance}");

    }
}