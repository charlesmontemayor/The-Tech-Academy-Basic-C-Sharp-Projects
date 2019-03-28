using System;

namespace DoWhileStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a letter: ");
            string input = Console.ReadLine();
            string letter = input.ToLower();
            bool isLetter = letter == "m";

            do
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
            while (!isLetter);
            Console.Read();
        }
    }
}
