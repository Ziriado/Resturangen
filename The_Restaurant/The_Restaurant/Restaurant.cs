using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Restaurant;

namespace The_Restaurant
{
    internal class Restaurant
    {
        public List<List<Guest>> GuestList { get; set; } = new List<List<Guest>>();
        public List<Guest> inQueueCompany { get; set; } = new List<Guest>();

        Graphics graphics = new Graphics();
        public void Welcome()
        {
            //graphics.DrawRestaurant();
           
        }
        

        public void CompaniesInQueue()
        {
            Company company = new Company();

                for (int i = 0; i < 20; i++)
                {
                    inQueueCompany = company.BuildingCompany();
                    GuestList.Add(inQueueCompany);
                }
                inQueueCompany.Clear();
        }        
    }
}

