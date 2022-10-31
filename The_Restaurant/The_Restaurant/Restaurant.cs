using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Restaurant;

namespace The_Restaurant
{
    internal class Restaurant
    {
        public void Welcome()
        {
            Console.WriteLine("Välkommen");
        }
        public void CompaniesInQueue()
        {
            Company company = new Company();
            List<Guest> inQueueCompany = new List<Guest>();
            

            for (int i = 0; i < 3; i++) //Funkar sålänge i är mindre än 5, annars out of bounds
            {
                inQueueCompany = company.BuildingCompany();
                inQueueCompany.AddRange(company.BuildingCompany());
                Console.WriteLine(inQueueCompany[i].Name);
            }
        }
    }
}

