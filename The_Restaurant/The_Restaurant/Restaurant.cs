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
        List<Table> Tablelist = new List<Table>();       
        public void Welcome()
        {
            Console.WriteLine("Välkommen");
        }
        public void DrawRestaurant()
        {            
            List<Guest> empty = new List<Guest>();
            
            Tablelist.Add(new Table { Name = "Bord 1", IsDirty = false, IsOccupied = false, TableQuality = 5, TableSize = 4, SetX = 0, SetY = 7 });
            Tablelist.Add(new Table { Name = "Bord 2", IsDirty = false, IsOccupied = false, TableQuality = 5, TableSize = 4, SetX = 20, SetY = 7 });
            Tablelist.Add(new Table { Name = "Bord 3", IsDirty = false, IsOccupied = false, TableQuality = 5, TableSize = 4, SetX = 40, SetY = 7 });
            Tablelist.Add(new Table { Name = "Bord 4", IsDirty = false, IsOccupied = false, TableQuality = 5, TableSize = 4, SetX = 60, SetY = 7 });
            Tablelist.Add(new Table { Name = "Bord 5", IsDirty = false, IsOccupied = false, TableQuality = 5, TableSize = 4, SetX = 80, SetY = 7 });
            Tablelist.Add(new Table { Name = "Bord 6", IsDirty = false, IsOccupied = false, TableQuality = 5, TableSize = 2, SetX = 0, SetY = 17 });
            Tablelist.Add(new Table { Name = "Bord 7", IsDirty = false, IsOccupied = false, TableQuality = 5, TableSize = 2, SetX = 20, SetY = 17 });
            Tablelist.Add(new Table { Name = "Bord 8", IsDirty = false, IsOccupied = false, TableQuality = 5, TableSize = 2, SetX = 40, SetY = 17 });
            Tablelist.Add(new Table { Name = "Bord 9", IsDirty = false, IsOccupied = false, TableQuality = 5, TableSize = 2, SetX = 60, SetY = 17 });
            Tablelist.Add(new Table { Name = "Bord 10", IsDirty = false, IsOccupied = false, TableQuality = 5, TableSize = 2, SetX = 80, SetY = 17 });

            Draw("Kö", 98, 0, empty);
            Draw("Köket", 40, 0, empty);
            Draw("Diskbås", 53, 0, empty);

            foreach (Table table in Tablelist)
            {   
                Draw(table.Name, table.SetX, table.SetY, empty);
            }

        }

        public void CompaniesInQueue()
        {
            Company company = new Company();
            List<Guest> inQueueCompany = new List<Guest>();

            for (int i = 0; i < 3; i++) //Funkar sålänge i är mindre än 5, annars out of bounds
            {
                inQueueCompany = company.BuildingCompany();
                inQueueCompany.AddRange(company.BuildingCompany());
                //Console.WriteLine(inQueueCompany[i].Name);
                
            }
        }
        public static void Draw<T>(string header, int fromLeft, int fromTop, List<T> anyList)
        {
            string[] graphics = new string[anyList.Count];
            for (int i = 0; i < anyList.Count; i++)
            {
                graphics[i] = (anyList[i] as Guest).Name;
            }
            GUI.Window.Draw(header, fromLeft, fromTop, graphics);
        }
        

        
    }
}

