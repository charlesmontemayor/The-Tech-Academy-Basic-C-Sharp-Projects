using System;

namespace StudentDailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.ReadLine();

            Console.WriteLine("What course are you on? ");
            string course = Console.ReadLine();
            Console.WriteLine("What page number? ");
            string currentPage = Console.ReadLine();
            int pageNumber = Convert.ToInt32(currentPage);
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            Console.ReadLine();
            bool needHelp = true;
            string help = Convert.ToString(needHelp);
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string myExperience = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string myFeedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string studyHours = Console.ReadLine();
            int HoursOfStudy = Convert.ToInt32(studyHours);

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");

        }
    }
}
