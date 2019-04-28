using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            const string greetings = "Hello! ";

            var person = new Person("Charles");

            Console.WriteLine(greetings + person.Name);
        }
    }
}
