using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This will convert dollar to euro, pound and bitcoin. \nEnter the desired amount.");
            string input = Console.ReadLine();
            double amount = Convert.ToDouble(input);

            double euro = CurrentExchangeRates.toEuro(amount);
            Console.WriteLine("€ " + euro);

            double pound = CurrentExchangeRates.toPound(amount);
            Console.WriteLine("£ " + pound);

            double bitcoin = CurrentExchangeRates.toBitcoin(amount);
            Console.WriteLine("Bitcoin " + bitcoin);
        }

    }
}
