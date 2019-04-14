using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public virtual void SayName()
        {
            string FullName = (firstName + " " + lastName);
            Console.WriteLine("Name: " + FullName);
        }
    }
}
