using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { firstName = "Sample", lastName = "Student" };

            employee.SayName();

            Person person = new Employee();
            person.firstName = "Next";
            person.lastName = "Student";

            person.SayName();
            employee.IQuit(employee);

        }
    }
}
