using System;

namespace PackageQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight: ");
            int weight = Convert.ToInt32(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Environment.Exit(1);
            }

            Console.WriteLine("Please enter the package width: ");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package height: ");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package length: ");
            int length = Convert.ToInt32(Console.ReadLine());
             
            int dimensions = width + height + length;
            if (dimensions <= 50)
            {
                double quote = (dimensions * weight) / 100.00;
                Console.WriteLine("Your estimated total shipping this package is: $" + quote + "\nThank you.");
            }
            else
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Environment.Exit(1);
            }
        }
    }
}
