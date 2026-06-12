# Program Output

```ps
Restore complete (0.2s)
  _Code-Challenge net10.0 succeeded (0.3s) → bin\Debug\net10.0\_Code-Challenge.dll

Build succeeded in 0.8s

=== Testing CHECKING ACCOUNT ===================
Account Owner: John Doe
Checking Balance (starting): 2500.0
Checking Balance after depositing 200.0 = 2700.0
Checking Balance after withdrawing 50.0 = 2650.0
Checking Balance after withdrawing 3000.0 (+ $35 overdraft fee) = -385.0

=== Testing SAVINGS ACCOUNT ===================
Account Owner: Jane Doe
Saving Balance (starting): 1000.0
Savings Balance after depositing 150.0 = 1150.0
Savings Balance after withdrawing 125.0 = 1025.0
Savings Balance after applying interest = 1055.750
Savings Balance after exceeding 3 withdrawls (including $2 fee) = 993.750
Savings Balance after attempting to overdraw = 993.750

===============================================
```