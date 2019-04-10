using System;

namespace PracticeMethods2
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();

            Console.WriteLine("Enter a number.");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a second number (This can be optional).");
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("{0} + {1} = {2}", num1, input, math.Add(num1));
            }
            else
            {
                int num2 = Convert.ToInt32(input);
                Console.WriteLine("{0} + {1} = {2}", num1, num2, math.Add(num1, num2));
            }
        }
    }
}
