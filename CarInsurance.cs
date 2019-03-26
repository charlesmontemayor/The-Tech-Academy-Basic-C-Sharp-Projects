using System;

namespace CarInsurance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int yearsold = Convert.ToInt32(age);
            bool currentage = yearsold > 15;

            Console.WriteLine("Have you ever had DUI?");
            string DUI = Console.ReadLine();
            bool currentDUI = DUI == "no";

            Console.WriteLine("How many speeding tickets do you have?");
            string tickets = Console.ReadLine();
            int numberTickets = Convert.ToInt32(tickets);
            bool currentTickets = numberTickets <= 3;

            bool qualified = currentage && currentDUI && currentTickets;
            if (qualified)
            {
                Console.WriteLine("You are qualified.");
            }
            else {
                Console.WriteLine("You are not qualified.");
            }
        }
    }
}
