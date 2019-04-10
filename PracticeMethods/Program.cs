using System;

namespace PracticeMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            TemperatureConversion temp = new TemperatureConversion();
            Console.WriteLine(temp.convert(12) + " F");
            Console.WriteLine(temp.convert(98.6m) + " C");

            Console.WriteLine("Enter a number.");
            string input = Console.ReadLine();
            Console.WriteLine(temp.convert(input));
        }
    }
}
