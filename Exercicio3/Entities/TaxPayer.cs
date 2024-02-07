using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3.Entities;
public abstract class TaxPayer   
{
    public string Name { get; set; } = string.Empty;
    public double AnualIncome { get; set; }

    public TaxPayer() { }

    public TaxPayer(string name, double anualIncome)
    {
        Name = name;
        AnualIncome = anualIncome;
    }

    public abstract double Tax();
}
