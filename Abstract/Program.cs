using System;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee() { firstName = "Sample", lastName = "Student" };

            e.SayName();

        }
    }
}
