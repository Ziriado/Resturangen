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
        Restaurant restaurant = new Restaurant();
        Company company = new Company();
        Table table = new Table();
        Graphics graphics = new Graphics();
        public Waiter(string Name) : base(Name)
        {

        }
        public void PickUpCompanyInLine(List<List<Guest>> guestsComp, List<Guest> moreGuests)
        {
            List<Waiter> waiters = new List<Waiter>();
            waiters = company.BuildWaiters();


            //if (restaurant.GuestList is not null)
            //{
            //    foreach (Table table in graphics._tableList)
            //    {
            //        if (table.IsOccupied == false && table.IsDirty == false)
            //        {
            moreGuests.AddRange(guestsComp[0]);
            guestsComp.RemoveAt(0);
            graphics.DrawRestaurant(moreGuests);
            //        }
            //    }
            //}


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
