using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Restaurant
{
    internal class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }
    }
    class Chef :Person
    {
        public Chef(string Name) : base(Name)
        {

        }
    }
    class Waiter : Person
    {
        public Waiter(string Name) : base(Name)
        {

        }
    }

    class Guest : Person
    {
        public Guest (string Name) :base(Name)
        {

        }
    }
}
