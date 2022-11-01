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
        List<List<Guest>> group = new List<List<Guest>>();
        Graphics graphics = new Graphics();
        public void Welcome()
        {
            graphics.DrawRestaurant();
        }
       

        public void CompaniesInQueue()
        {
            Company company = new Company();
            List<Guest> inQueueCompany = new List<Guest>();

            for (int i = 0; i < 3; i++)
            {

                    inQueueCompany = company.BuildingCompany();
                    group.Add(inQueueCompany);
                
            }
            inQueueCompany.Clear();
        }

        

        
    }
}

