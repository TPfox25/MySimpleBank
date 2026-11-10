using MySimpleBank;

BankAccount bankAccount = new BankAccount("Tafton", 50000);

Console.WriteLine($"Account {bankAccount.Number} was created for {bankAccount.Owner} with {bankAccount.Balance}.");