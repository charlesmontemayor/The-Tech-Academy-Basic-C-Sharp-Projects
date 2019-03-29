using System;
using System.Text;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Charles";
            string startGreet = "Hello!";
            string endGreet = "Have a good day.";

            Console.WriteLine(startGreet + " My name is " + name + ". " + endGreet);

            Console.WriteLine(endGreet.ToUpper());

            StringBuilder sb = new StringBuilder("Hello World! ");
            sb.Append("My name is " + name + ". ");
            sb.AppendLine("I am studying C#. ");
            sb.AppendLine("I love C#. ");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
