using System;

namespace Math
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            string input1 = Console.ReadLine();
            int number1 = Convert.ToInt32(input1);
            int total1 = number1 * 50;
            Console.WriteLine(total1);
            

            Console.WriteLine("Please enter another number:");
            string input2 = Console.ReadLine();
            int number2 = Convert.ToInt32(input2);
            int total2 = number2 + 25;
            Console.WriteLine(total2);


            Console.WriteLine("Please enter another number:");
            string input3 = Console.ReadLine();
            double number3 = Convert.ToDouble(input3);
            double total3 = number2 / 12.5;
            Console.WriteLine(total3);


            Console.WriteLine("Please enter another number:");
            string input4 = Console.ReadLine();
            double number4 = Convert.ToDouble(input4);
            bool total4 = number4 > 50;
            Console.WriteLine(total4);

            Console.WriteLine("Please enter another number:");
            string input5 = Console.ReadLine();
            double number5 = Convert.ToDouble(input5);
            double total5 = number5 % 7;
            Console.WriteLine(total5);




        }
    }
}
