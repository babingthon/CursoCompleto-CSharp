
using Exercio_Exceptions.Entities;
using Exercio_Exceptions.Entities.Exceptions;

try
{
    Console.WriteLine("Enter account data: ");
    Console.Write("Number: ");
    int number = int.Parse(Console.ReadLine());
    Console.Write("Holder: ");
    string holder = Console.ReadLine();
    Console.Write("Initial balance: ");
    double initialBalance = double.Parse(Console.ReadLine());
    Console.Write("Withdraw limit: ");
    double withdrawLimit = double.Parse(Console.ReadLine());

    var account = new Account(number, holder, initialBalance, withdrawLimit);

    Console.Write("Enter amount for withdraw: ");
    double amount = double.Parse(Console.ReadLine());
    account.Withdraw(amount);

    Console.Write($"New balance: {account.Balance}");
}
catch (DomainException e)
{
    Console.BackgroundColor = ConsoleColor.Red;
    Console.Write("Withdraw error: " + e.Message);
}



