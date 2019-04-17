using System;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What day of the week is it today?");
            string input = Console.ReadLine();
            try
            {
                foreach(string day in Enum.GetNames(typeof(DaysOfTheWeek)))
                {
                    if (day == input)
                    {
                        Console.WriteLine("Today is " + day);
                    }
                }
            }
            catch
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
        }

        public enum DaysOfTheWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
    }
}
