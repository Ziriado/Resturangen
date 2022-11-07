﻿using System;
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
        Menu menu = new Menu(0,"");


        public void Welcome()
        {
            for (int i = 0; i < 1; i++)
            {
                waitress.Add(new Waitress(true, 0, 0));
            }
            for (int i = 0; i < 1; i++)
            {
                chef.Add(new Chef());
            }
            CreateQueue();
            CreateTables();
            menu = menu.CourseFromMenu();
            
        }
        private void PlaceCompanyAtTable()
        {
            List<Guest> tempList = new List<Guest>();
            tempList.AddRange(queue.Dequeue());

            for (int i = 0; i < tableDictionary.Count; i++)
            {
                
                if (tableDictionary[i].IsOccupied == false && tableDictionary[i].IsDirty == false && tableDictionary[i].CompanyList.Count == 0)
                {
                    if (tableDictionary[i].TableSize == 4 && tempList.Count >= 3)
                    {
                        tableDictionary[i].CompanyList.AddRange(tempList);
                        tableDictionary[i].IsOccupied = true;
                        foreach (Waitress w in waitress)
                        {
                            w.SetY = tableDictionary[i].SetY - 3;
                            w.SetX = tableDictionary[i].SetX;

                        }
                        break;
                    }
                    else if (tableDictionary[i].TableSize == 2 && tempList.Count <= 2 && tableDictionary[i].CompanyList.Count == 0)
                    {
                        tableDictionary[i].CompanyList.AddRange(tempList);
                        tableDictionary[i].IsOccupied = true;
                        foreach (Waitress w in waitress)
                        {
                            w.SetY = tableDictionary[i].SetY - 3;
                            w.SetX = tableDictionary[i].SetX;

                        }
                        break;
                    }
                }
                
                
            }
        }
        public void PerformRound()
        {
            foreach (Waitress allWaitress in waitress)
            {
                foreach (KeyValuePair<int, Table> kvp in tableDictionary)
                {
                    if (kvp.Value.IsOccupied == true)
                    {
                        allWaitress.TakeCompanyOrderToChef();
                    }
                }
                allWaitress.IsAvailable = true;

                if (allWaitress.IsAvailable == true && queue is not null)
                {
                    WaitressGoToEntrence();
                    
                }
                PlaceCompanyAtTable();

            }
        }
        private void WaitressGoToEntrence()
        {
            foreach (Waitress w in waitress)
            {
                if (w.SetX == 100 && w.SetY == 0)
                {
                    continue;
                }
                else if (w.IsAvailable == true && queue is not null)
                {
                    w.SetX = 100;
                    w.SetY = 0;
                    w.IsAvailable = false;
                }
                
            }

        }
        public void DrawRestaurant()
        {
            Console.Clear();
            foreach (Waitress w in waitress)
            {
                graphics.Draw("Servitör", w.SetX, w.SetY, waitress);
            }
            foreach (KeyValuePair<int, Table> kvp in tableDictionary)
            {
                graphics.Draw(kvp.Value.Name, kvp.Value.SetX, kvp.Value.SetY, kvp.Value.CompanyList);
            }
            graphics.Draw("Kö", 100, 5, queue.First());
            graphics.Draw("Köket", 40, 0, chef);
        }
        private void CreateQueue()
        {
            List<Guest> list = new List<Guest>();

            for (int i = 0; i < company.NumberOfCompanies; i++)
            {
                queue.Enqueue(company.RandomizeCompany());
            }
        }

        public void CreateTables()
        {
            tableDictionary.Add(0, new Table { Name = "Bord 1", IsDirty = false, IsOccupied = false, TableQuality = 5, TableSize = 4, SetX = 0, SetY = 10, CompanyList = new List<Guest>() });
            tableDictionary.Add(1, new Table { Name = "Bord 2", IsDirty = false, IsOccupied = false, TableQuality = 5, TableSize = 4, SetX = 20, SetY = 10, CompanyList = new List<Guest>() });
            tableDictionary.Add(2, new Table { Name = "Bord 3", IsDirty = false, IsOccupied = false, TableQuality = 5, TableSize = 4, SetX = 40, SetY = 10, CompanyList = new List<Guest>() });
            tableDictionary.Add(3, new Table { Name = "Bord 4", IsDirty = false, IsOccupied = false, TableQuality = 5, TableSize = 4, SetX = 60, SetY = 10, CompanyList = new List<Guest>() });
            tableDictionary.Add(4, new Table { Name = "Bord 5", IsDirty = false, IsOccupied = false, TableQuality = 5, TableSize = 4, SetX = 80, SetY = 10, CompanyList = new List<Guest>() });
            tableDictionary.Add(5, new Table { Name = "Bord 6", IsDirty = false, IsOccupied = false, TableQuality = 5, TableSize = 2, SetX = 0, SetY = 20, CompanyList = new List<Guest>() });
            tableDictionary.Add(6, new Table { Name = "Bord 7", IsDirty = false, IsOccupied = false, TableQuality = 5, TableSize = 2, SetX = 20, SetY = 20, CompanyList = new List<Guest>() });
            tableDictionary.Add(7, new Table { Name = "Bord 8", IsDirty = false, IsOccupied = false, TableQuality = 5, TableSize = 2, SetX = 40, SetY = 20, CompanyList = new List<Guest>() });
            tableDictionary.Add(8, new Table { Name = "Bord 9", IsDirty = false, IsOccupied = false, TableQuality = 5, TableSize = 2, SetX = 60, SetY = 20, CompanyList = new List<Guest>() });
            tableDictionary.Add(9, new Table { Name = "Bord 10", IsDirty = false, IsOccupied = false, TableQuality = 5, TableSize = 2, SetX = 80, SetY = 20, CompanyList = new List<Guest>() });

        }

    }
}
