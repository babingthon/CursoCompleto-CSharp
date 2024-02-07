
using Exercicio3.Entities;
using System.Collections.Generic;
using System.Globalization;

List<TaxPayer> list = new List<TaxPayer>();

Console.Write("Enter the number of tax payers: ");
int payers = int.Parse(Console.ReadLine());

for (int i = 1; i <= payers; i++)
{
    Console.WriteLine($"Taxpayer #{i} data:");
    Console.Write("Individual or company (i/c)? ");
    char choice = Char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Anual income: ");
    double anualincome = double.Parse(Console.ReadLine());
    
    if (choice == 'i')
    {
        Console.Write("Health expenditures: ");
        double health = double.Parse(Console.ReadLine());
        list.Add(new Individual(name, anualincome, health));
    }
    else
    {
        Console.Write("Numberofemployees: ");
        int employees = int.Parse(Console.ReadLine());
        list.Add(new Company(name, anualincome, employees));
    }

}

Console.WriteLine("");
Console.WriteLine("TAXES PAID:");

double totalTaxes = 0;

foreach (TaxPayer payer in list)
{
    double tax = payer.Tax();
    Console.WriteLine(payer.Name + ": $ " + payer.Tax().ToString("F2", CultureInfo.InvariantCulture));
    totalTaxes += tax;
}

Console.WriteLine("");
Console.WriteLine("TOTAL TAXES: $ " + totalTaxes.ToString("F2", CultureInfo.InvariantCulture));


