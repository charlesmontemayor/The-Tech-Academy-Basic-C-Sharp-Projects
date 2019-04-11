using System;
namespace ClassMethods
{
    public class Math
    {
        public void Divide(int num1)
        {
            int result = num1 / 2;
            Console.WriteLine("{0} ÷ 2 = {1}", num1, result);
        }

        public int Remainder(int num1, out int num2)
        {
            num2 = 0;
            double result = num1 / 2;
            if (num1 % 2 == 1)
            {
                int remainder = num1 % 2;
                Console.WriteLine("{0} + 2 = {1} with as remainder of {2}", num1, Convert.ToInt32(result), remainder);
                num2 = remainder;
            }
            return num2;
        }

        public void Divide(double num1)
        {
            double result = num1 / 2;
            Console.WriteLine("{0} ÷ 2 = {1}", num1, result);
        }

        public static void Division(double num1)
        {
            double result = num1 / 2;
            Console.WriteLine("{0} divided by 2 is equal to {1}.", num1, result);
        }
    }
}
