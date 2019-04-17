using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employeeString = new Employee<string>();
            employeeString.Things = new List<string>() { "A", "B", "C", "D", "E" };

            Employee<int> employeeInt = new Employee<int>();
            employeeInt.Things = new List<int>() { 1, 2, 3, 4, 5 };

            foreach (string employee in employeeString.Things)
            {
                Console.WriteLine(employee);
            }

            foreach (int employee in employeeInt.Things)
            {
                Console.WriteLine(employee);
            }

        }
    }
}

