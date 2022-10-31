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
            Name = The_Restaurant.Company.LastName();
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
        public double Cash { get; set; }
        public Guest (string Name) :base(Name)
        {
            Random rnd = new Random();
            Cash = rnd.Next(100, 300);
        }
     
    }
}
