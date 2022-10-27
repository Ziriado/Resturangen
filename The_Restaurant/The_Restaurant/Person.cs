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
        internal void PickUpCompany(List<Guest> eachCompany)
        {
            Company company = new Company();
            Table table = new Table(false, false, 0, 0);



            Console.SetCursorPosition(5, 6);
            foreach (Guest guest in eachCompany)
            {
                Console.WriteLine(guest.Name);
            }
        }
    }

    class Guest : Person
    {
        public Guest (string Name) :base(Name)
        {

        }
     
    }
}
