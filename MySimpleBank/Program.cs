using MySimpleBank;
using System.Security.Principal;

BankAccount bankAccount = new BankAccount("Tafton", 50000);

Console.WriteLine($"Account {bankAccount.Number} was created for {bankAccount.Owner} with {bankAccount.Balance}.");

bankAccount.MakeWithdrawal(250, DateTime.Now, "Hammock");
bankAccount.MakeWithdrawal(50, DateTime.Now, "Xbox Game");

Console.WriteLine(bankAccount.GetAccountHistory());

// Test for a negative balance.
//try
//{
//    bankAccount.MakeWithdrawal(75000, DateTime.Now, "Attempt to overdraw");
//}
//catch (InvalidOperationException e)
//{
//    Console.WriteLine("Exception caught trying to overdraw");
//    Console.WriteLine(e.ToString());
//}


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
//    return;
//}