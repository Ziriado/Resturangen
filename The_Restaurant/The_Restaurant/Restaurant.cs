using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using The_Restaurant;

namespace The_Restaurant
{
    internal class Restaurant
    {
        List<Table> tables { get; set; } = new List<Table>();
        List<Waitress> waitress { get; set; } = new List<Waitress>();
        List<Chef> chef { get; set; } = new List<Chef>();
        Queue<List<Guest>> queue { get; set; } = new Queue<List<Guest>>();

        Dictionary<int, Table> tableDictionary = new Dictionary<int, Table>();

        

        Company company = new Company();
        Table table = new Table();
        Graphics graphics = new Graphics();

        List<Guest> empty = new List<Guest>();

        public void Welcome()
        {
            for (int i = 0; i < 1; i++)
            {
                waitress.Add(new Waitress(true, 0, 0));
            }
            for (int i = 0; i < 5; i++)
            {
                chef.Add(new Chef());
            }
            CreateQueue();
            CreateTables();
            ShowQueue();
            DrawRestaurant();
            PerformRound(waitress, chef);
            PlaceCompanyAtTable();



        }
        public void PlaceCompanyAtTable()
        {
            for (int i = 0; i < tableDictionary.Count; i++)
            {
                {
                    if (tableDictionary[i].IsOccupied == false && tableDictionary[i].IsDirty == false)
                    {
                        tableDictionary[i].CompanyList.Add(queue.Dequeue());
                        if (tableDictionary[i].CompanyList[0] != null)
                        {
                            graphics.Draw(tableDictionary[i].Name, tableDictionary[i].SetX, tableDictionary[i].SetY, tableDictionary[i].CompanyList);

                        }
                    }
                }
            }
            //foreach (KeyValuePair<int, Table> kvp in tableDictionary)
            //{
            //    if (kvp.Value.CompanyList == null && kvp.Value.IsDirty == false && kvp.Value.IsOccupied == false)
            //    {
            //        var seatedCompany = queue.Dequeue();
            //        kvp.Value.CompanyList.Add(seatedCompany);
            //        graphics.Draw(kvp.Value.Name, kvp.Value.SetX, kvp.Value.SetY, kvp.Value.CompanyList);
            //        //var x = queue;
            //        //var y = kvp.Value.CompanyList.Add()
            //    }
            //}
        }
        public void PerformRound(List<Waitress> waitress, List<Chef> chef)
        {
            foreach (Waitress allWaitress in waitress)
            {
                if (allWaitress.IsAvailable == true && queue is not null)
                {
                    WaitressGoToEntrence(waitress);
                }
            }
        }
        public void WaitressGoToEntrence(List<Waitress> waitress)
        {
            foreach (Waitress w in waitress)
            {
                w.SetX = 100;
                w.SetY = 0;
                graphics.Draw("Servitör", w.SetX, w.SetY, waitress);
            }
        }
        public void DrawRestaurant()
        {
            foreach (KeyValuePair<int, Table> kvp in tableDictionary)
            {
                graphics.Draw(kvp.Value.Name, kvp.Value.SetX, kvp.Value.SetY, empty);
            }
        }
        public void CreateQueue()
        {
            List<Guest> list = new List<Guest>();

            for (int i = 0; i < company.NumberOfCompanies; i++)
            {
                queue.Enqueue(company.RandomizeCompany());
            }

        }
        public void ShowQueue()
        {
            graphics.Draw("Kö", 100, 5, queue.First());
        }

        public void CreateTables()
        {
            tableDictionary.Add(0, new Table { Name = "Bord 1", IsDirty = false, IsOccupied = false, TableQuality = 5, TableSize = 4, SetX = 0, SetY = 7, CompanyList = new List<List<Guest>>() });
            tableDictionary.Add(1, new Table { Name = "Bord 2", IsDirty = false, IsOccupied = false, TableQuality = 5, TableSize = 4, SetX = 20, SetY = 7, CompanyList = new List<List<Guest>>() });
            tableDictionary.Add(2, new Table { Name = "Bord 3", IsDirty = false, IsOccupied = false, TableQuality = 5, TableSize = 4, SetX = 40, SetY = 7, CompanyList = new List<List<Guest>>() });
            tableDictionary.Add(3, new Table { Name = "Bord 4", IsDirty = false, IsOccupied = false, TableQuality = 5, TableSize = 4, SetX = 60, SetY = 7, CompanyList = new List<List<Guest>>() });
            tableDictionary.Add(4, new Table { Name = "Bord 5", IsDirty = false, IsOccupied = false, TableQuality = 5, TableSize = 4, SetX = 80, SetY = 7, CompanyList = new List<List<Guest>>() });
            tableDictionary.Add(5, new Table { Name = "Bord 6", IsDirty = false, IsOccupied = false, TableQuality = 5, TableSize = 2, SetX = 0, SetY = 17, CompanyList = new List<List<Guest>>() });
            tableDictionary.Add(6, new Table { Name = "Bord 7", IsDirty = false, IsOccupied = false, TableQuality = 5, TableSize = 2, SetX = 20, SetY = 17, CompanyList = new List<List<Guest>>() });
            tableDictionary.Add(7, new Table { Name = "Bord 8", IsDirty = false, IsOccupied = false, TableQuality = 5, TableSize = 2, SetX = 40, SetY = 17, CompanyList = new List<List<Guest>>() });
            tableDictionary.Add(8, new Table { Name = "Bord 9", IsDirty = false, IsOccupied = false, TableQuality = 5, TableSize = 2, SetX = 60, SetY = 17, CompanyList = new List<List<Guest>>() });
            tableDictionary.Add(9, new Table { Name = "Bord 10", IsDirty = false, IsOccupied = false, TableQuality = 5, TableSize = 2, SetX = 80, SetY = 17, CompanyList = new List<List<Guest>>() });

        }

    }
}
