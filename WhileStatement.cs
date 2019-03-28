using System;

namespace WhileStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a letter: ");
            string letter = Console.ReadLine();
            bool isLetter = letter == "m";

            while (!isLetter)
            {
                switch (letter)
                {
                    case "m":
                        Console.WriteLine("You have guessed the letter M. You are correct!");
                        isLetter = true;
                        break;
                    default:
                        Console.WriteLine("That is incorrect. Try again.");
                        Console.WriteLine("Guess a letter: ");
                        letter = Console.ReadLine();
                        break;
                }
            }
            Console.Read();
        }
    }
}
