using System;

namespace SampleDatetime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Right now, it is {0}.", DateTime.Now);
            Console.WriteLine("Enter a number of hours.");
            int inputHours = Convert.ToInt32(Console.ReadLine());
            DateTime currentTime = DateTime.Now;
            DateTime hoursLater = currentTime.AddHours(inputHours);
            Console.WriteLine("In {0} hours, it will be at {1}.", inputHours, hoursLater);
        }
    }
}
