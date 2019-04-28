using System;
namespace Constructors
{
    public class Person
    {
        public Person(string name) : this(name, 1)
        {
        }
        public Person(string name, int number)
        {
            Name = name;
            PlaceNumber = number;
        }
        public string Name { get; set; }
        public int PlaceNumber { get; set; }
    }
}
