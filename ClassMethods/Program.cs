using System;

namespace ClassMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number.");
            string input = Console.ReadLine();
            double num1 = Convert.ToDouble(input);

            Math math = new Math();

            math.Divide(num1);

            math.Remainder(Convert.ToInt32(num1), out int num2);

            Math.Division(num1);
        }
    }
}
