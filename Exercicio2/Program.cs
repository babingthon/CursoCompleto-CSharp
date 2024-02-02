
using Exercicio2.Entities;
using System.Globalization;

List<Product> list = new List<Product>();

Console.Write("Enter number of products: ");
int products = int.Parse(Console.ReadLine());

for (int i = 1; i <= products; i++)
{
    Console.WriteLine($"Product #{i} data:");
    Console.Write("Common, used or imported (c/u/i)? ");
    char option = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine(); ;
    Console.Write("Price: ");
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    switch (option)
    {
        case 'i':
            {
                Console.Write("Customs fee: ");
                double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new ImportedProduct(name, price, customsFee));
                break;
            }
        case 'u':
            {
                Console.Write("Manufacture date (DD/MM/YYYY): ");
                DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                list.Add(new UsedProduct(name, price, manufactureDate));
                break;
            }
        case 'c':
            {
                list.Add(new Product(name, price));
                break;
            }
            
    }

}

Console.WriteLine();
Console.WriteLine("PRICE TAGS:");
foreach (Product prod in list)
{
    Console.WriteLine(prod.PriceTag());
}
