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
        internal bool PickUpCompany(List<Guest> eachCompany)
        {
            Company company = new Company();
            Table table = new Table(false, false, 0, 0);
            TableOne tableOne = new TableOne(false, false, 0, 0);
            TableTwo tableTwo = new TableTwo(false, false, 0, 0);
            TableSix tableSix = new TableSix(false, false, 0, 0);
            TableSeven tableSeven = new TableSeven(false, false, 0, 0);


            if (tableOne.IsDirty == false && tableOne.IsOccupied == false && eachCompany.Count >= 3)
            {
                Console.SetCursorPosition(5, 6);
                foreach (Guest guest in eachCompany)
                {
                    Console.Write(guest.Name);
                }
                tableOne.IsOccupied = true;
            }
            else if (tableTwo.IsDirty == false && tableTwo.IsOccupied == false && eachCompany.Count >= 3)
            {
                Console.SetCursorPosition(30, 6);
                foreach (Guest guest in eachCompany)
                {
                    Console.Write(guest.Name + " ");
                }
                tableTwo.IsOccupied = true;
            }
            else if (tableSix.IsDirty == false && tableSix.IsOccupied == false && eachCompany.Count <= 2)
            {
                Console.SetCursorPosition(55, 6);
                foreach (Guest guest in eachCompany)
                {
                    Console.Write(guest.Name + " ");
                }
                tableSix.IsOccupied = true;
            }
            else if (tableSeven.IsDirty == false && tableSeven.IsOccupied == false && eachCompany.Count <= 2)
            {
                Console.SetCursorPosition(80, 6);
                foreach (Guest guest in eachCompany)
                {
                    Console.Write(guest.Name + " ");
                }
                tableSeven.IsOccupied = true;
            }
            return table.IsOccupied;
        }
    }

    class Guest : Person
    {
        public Guest (string Name) :base(Name)
        {

        }
     
    }
}
