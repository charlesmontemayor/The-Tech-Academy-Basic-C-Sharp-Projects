using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    public class CurrentExchangeRates
    {
        public static double toBitcoin(double amount)
        {
            double result = amount * 0.0019;
            return result;
        }
        public static double toEuro(double amount)
        {
            double result = amount * 0.77;
            return result;
        }
        public static double toPound(double amount)
        {
            double result = amount * 0.89;
            return result;
        }
    }
}
