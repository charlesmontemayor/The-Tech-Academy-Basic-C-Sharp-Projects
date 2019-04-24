using System;
using System.IO;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your phone number?");
            string number = Console.ReadLine();
            File.WriteAllText(@"/Users/charlesm/Projects/FileIO/Log/log.txt", number);
            Console.WriteLine(File.ReadAllText(@"/Users/charlesm/Projects/FileIO/Log/log.txt"));

        }
    }
}
