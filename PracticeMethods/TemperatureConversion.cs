using System;
namespace PracticeMethods
{
    public class TemperatureConversion
    {
        public int convert(int number)
        {
            int result = (number * 9 / 5) + 32;
            return result;
        }

        public decimal convert(decimal number)
        {
            decimal result = (number - 32) * 5/9;
            return result;
        }

        public int convert(string number)
        {
            int result = Int32.Parse(number);
            return result;
        }
    }
}
