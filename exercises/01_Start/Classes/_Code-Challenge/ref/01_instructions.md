### **Create a class hierarchy to represent bank accounts**

Implement a class hierarchy that represents basic banking operations for a checking and savings account.

You should have a **base class** that implements basic operations:

*   A constructor that accepts the first and last name of the account holder as strings along with a decimal value for the starting balance, with a default value of 0.0m
*   `Balance`: A decimal read and write property that contains the account balance
*   `AccountOwner`: A get-only string that returns the full name of the account owner, for example, "John Doe"
*   `Deposit`: A function that accepts a decimal argument, the amount to deposit
*   `Withdraw`: A function that accepts a decimal argument, the amount to withdraw

There should be two subclasses of your base class: **CheckingAcct** and **SavingsAcct**.

CheckingAcct should have:

*   A constructor that accepts the same arguments as the base account class
*   An override of `Withdraw`, which checks to see if the amount being withdrawn exceeds the current balance; if so, the account is charged a $35 fee and the withdrawal is allowed

SavingsAcct should have:

*   A constructor that accepts the same arguments as the base account class
*   `InterestRate`: A read and write decimal property that contains the interest rate
*   `ApplyInterest`: A function that applies the interest rate to the current balance
*   `Withdraw`: An override of the Withdraw function that checks to see if the withdrawal amount exceeds the balance and prevents the withdrawal; if there are more than three withdrawals, then the account is charged a withdrawal charge of $2

Your code will be called with the test code you see to the right.

### Want a hint?

Consider creating a base class that contains the items that are common to both CheckingAcct and SavingsAcct.