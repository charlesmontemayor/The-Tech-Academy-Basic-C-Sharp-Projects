using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeMoreMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number.");
            string input = Console.ReadLine();
            int num1 = Convert.ToInt32(input);

            Console.WriteLine("Enter a second number.");
            string input2 = Console.ReadLine();
            int num2 = Convert.ToInt32(input2);

            Add(num1, num2);

        }
        public static void Add(int num1, int num2)
        {
            int result = num1 + num2;
            Console.WriteLine("{0} + {1} = {2}", num1, num2, result);
        }
    }
}
