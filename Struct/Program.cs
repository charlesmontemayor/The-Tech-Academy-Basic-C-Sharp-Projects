using System;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number();
            number.Amount = 100.100m;

            Console.WriteLine(number.Amount);
        }

        public struct Number
        {
            public decimal Amount { get; set; }
        }
    }
}
