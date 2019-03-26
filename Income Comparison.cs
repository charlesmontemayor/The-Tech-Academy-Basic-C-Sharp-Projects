using System;

namespace IncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly rate?");
            string person1_input1 = Console.ReadLine();
            int person1_rate = Convert.ToInt32(person1_input1);
            Console.WriteLine("Hours worked per week?");
            string person1_input2 = Console.ReadLine();
            int person1_hoursWorked = Convert.ToInt32(person1_input2);
            int person1_total = (person1_rate * person1_hoursWorked) * 52;
            Console.WriteLine("Annual salary of Person 1: " + person1_total);
            Console.ReadLine();

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly rate?");
            string person2_input1 = Console.ReadLine();
            int person2_rate = Convert.ToInt32(person2_input1);
            Console.WriteLine("Hours worked per week?");
            string person2_input2 = Console.ReadLine();
            int person2_hoursWorked = Convert.ToInt32(person2_input2);
            int person2_total = (person2_rate * person2_hoursWorked) * 52;
            Console.WriteLine("Annual salary of Person 2: " + person2_total);
            Console.ReadLine();

            bool salary_comparison = person1_total > person2_total;
            string compare = Convert.ToString(salary_comparison);
            Console.WriteLine("Does Person 1 make more money than Person 2? " + compare);
            Console.ReadLine();
        }
    }
}
