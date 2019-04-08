using System;
using System.Collections.Generic;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> numbers = new List<int>() { 34, 53, 23, 10, 8, 305, 232 };
                Console.WriteLine("Please enter a number as a divisor.");
                int divisor = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < numbers.Count; i++)
                {
                    int quotient = numbers[i] / divisor;
                    Console.WriteLine(quotient);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a number.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Please enter a non-zero number.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }

        }
    }
}
