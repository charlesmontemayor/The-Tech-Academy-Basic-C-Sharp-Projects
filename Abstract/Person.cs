using System;
namespace Abstract
{
    public abstract class Person
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
