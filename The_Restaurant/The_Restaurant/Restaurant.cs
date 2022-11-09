﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using The_Restaurant;

namespace The_Restaurant
{
    internal class Restaurant
    {
        List<Table> Tables { get; set; } = new List<Table>();
        List<Waitress> Waitress { get; set; } = new List<Waitress>();
        List<Chef> ListOfChef { get; set; } = new List<Chef>();
        Queue<List<Guest>> QueueCompany { get; set; } = new Queue<List<Guest>>();

        Dictionary<int, Table> tableDictionary = new Dictionary<int, Table>();
        Dictionary<int, List<Menu>> orderDictionary = new Dictionary<int, List<Menu>>();

        Company company = new Company();
        Table table = new Table();
        Graphics graphics = new Graphics();
        Menu menu = new Menu(0,"");
        Chef chef = new Chef();


        public void Welcome()
        {
            for (int i = 0; i < 1; i++)
            {
                Waitress.Add(new Waitress(true, 0, 0));
            }
            for (int i = 0; i < 1; i++)
            {
                ListOfChef.Add(new Chef());
            }
            CreateQueue();
            CreateTables();
            

        }

        public void PerformRound()
        {
            int tableNr;
            bool availableTable = false;

            availableTable = CheckAvailableTable(availableTable);

            if (availableTable == true)
            {
                for (int i = 0; i < Waitress.Count; i++)
                {
                    Waitress[i].IsAvailable = true;
                    //if(orderDictionary!= null)
                    //{
                    //    TakeCompanyOrderToChef();
                    //    chef.CookFood();
                    //}
                    if (Waitress[i].IsAvailable == true && QueueCompany is not null && Waitress[i].SetX != 100)
                    {
                        WaitressGoToEntrence(Waitress);
                    }
                    else if (Waitress[i].SetX == 100)
                    {
                        tableNr = PlaceCompanyAtTable();
                        OrderFood(tableNr);
                        Waitress[i].IsAvailable = false;
                    }
                }
            }
        }
        private int PlaceCompanyAtTable()
        {
            int tableNr;
            for (tableNr = 1; tableNr < tableDictionary.Count + 1; tableNr++)
            {
                if (tableDictionary[tableNr].IsOccupied == false && tableDictionary[tableNr].IsDirty == false && tableDictionary[tableNr].CompanyList.Count == 0)
                {
                    if (tableDictionary[tableNr].TableSize == 4 && QueueCompany.First().Count >= 3)
                    {
                        tableDictionary[tableNr].CompanyList.AddRange(QueueCompany.Dequeue());
                        tableDictionary[tableNr].IsOccupied = true;
                        foreach (Waitress w in Waitress)
                        {
                            w.SetY = tableDictionary[tableNr].SetY - 3;
                            w.SetX = tableDictionary[tableNr].SetX;
                        }
                        break;
                    }
                    else if (tableDictionary[tableNr].TableSize == 2 && QueueCompany.First().Count <= 2 && tableDictionary[tableNr].CompanyList.Count == 0)
                    {
                        tableDictionary[tableNr].CompanyList.AddRange(QueueCompany.Dequeue());
                        tableDictionary[tableNr].IsOccupied = true;

                        foreach (Waitress w in Waitress)
                        {
                            w.SetY = tableDictionary[tableNr].SetY - 3;
                            w.SetX = tableDictionary[tableNr].SetX;
                        }
                        break;
                    }
                }
            }
            return tableNr;
        }
        private void WaitressGoToEntrence(List<Waitress> waitresses)
        {
            foreach (Waitress w in waitresses)
            {
                    w.SetX = 100;
                    w.SetY = 3;
            }
        }

        private void TakeCompanyOrderToChef()
        {
            foreach (Waitress w in Waitress)
            {
                if (w.IsAvailable == true && w.SetX != 40)
                {
                    w.MoveToKitchen(Waitress);
                }
            }
        }
        private void OrderFood(int tableNumber)
        {            
            List<Menu> foods = new List<Menu>();
            foods.Clear();
            if (tableNumber <=10)
            {
                for (int j = 1; j < tableDictionary[tableNumber].CompanyList.Count + 1; j++)
                {   
                foods.Add(menu.CourseFromMenu());                  
                }      
                orderDictionary.Add(tableNumber, foods);
            }            
        }
        public void SendFoodToTable(Queue<List<Menu>> Orders)
        {
            foreach (Waitress w in Waitress)
            {
                if (w.IsAvailable == true)
                {

                }
            }
        }

        public void DrawRestaurant()
        {
            Console.Clear();
            foreach (Waitress w in Waitress)
            {
                graphics.Draw("Servitör", w.SetX, w.SetY, Waitress);
            }
            foreach (KeyValuePair<int, Table> kvp in tableDictionary)
            {
                graphics.Draw(kvp.Value.Name, kvp.Value.SetX, kvp.Value.SetY, kvp.Value.CompanyList);
            }
            graphics.Draw("Kö", 100, 5, QueueCompany.First());
            graphics.Draw("Köket", 40, 0, ListOfChef);
        }
        private void CreateQueue()
        {
            List<Guest> list = new List<Guest>();

            for (int i = 0; i < company.NumberOfCompanies; i++)
            {
                QueueCompany.Enqueue(company.RandomizeCompany());
            }
        }

        public void CreateTables()
        {
            tableDictionary.Add(1, new Table { Name = "Bord 1", IsDirty = false, IsOccupied = false, TableQuality = 5, TableSize = 4, SetX = 0, SetY = 10, CompanyList = new List<Guest>() });
            tableDictionary.Add(2, new Table { Name = "Bord 2", IsDirty = false, IsOccupied = false, TableQuality = 5, TableSize = 4, SetX = 20, SetY = 10, CompanyList = new List<Guest>() });
            tableDictionary.Add(3, new Table { Name = "Bord 3", IsDirty = false, IsOccupied = false, TableQuality = 5, TableSize = 4, SetX = 40, SetY = 10, CompanyList = new List<Guest>() });
            tableDictionary.Add(4, new Table { Name = "Bord 4", IsDirty = false, IsOccupied = false, TableQuality = 5, TableSize = 4, SetX = 60, SetY = 10, CompanyList = new List<Guest>() });
            tableDictionary.Add(5, new Table { Name = "Bord 5", IsDirty = false, IsOccupied = false, TableQuality = 5, TableSize = 4, SetX = 80, SetY = 10, CompanyList = new List<Guest>() });
            tableDictionary.Add(6, new Table { Name = "Bord 6", IsDirty = false, IsOccupied = false, TableQuality = 5, TableSize = 2, SetX = 0, SetY = 20, CompanyList = new List<Guest>() });
            tableDictionary.Add(7, new Table { Name = "Bord 7", IsDirty = false, IsOccupied = false, TableQuality = 5, TableSize = 2, SetX = 20, SetY = 20, CompanyList = new List<Guest>() });
            tableDictionary.Add(8, new Table { Name = "Bord 8", IsDirty = false, IsOccupied = false, TableQuality = 5, TableSize = 2, SetX = 40, SetY = 20, CompanyList = new List<Guest>() });
            tableDictionary.Add(9, new Table { Name = "Bord 9", IsDirty = false, IsOccupied = false, TableQuality = 5, TableSize = 2, SetX = 60, SetY = 20, CompanyList = new List<Guest>() });
            tableDictionary.Add(10, new Table { Name = "Bord 10", IsDirty = false, IsOccupied = false, TableQuality = 5, TableSize = 2, SetX = 80, SetY = 20, CompanyList = new List<Guest>() });

        }
        private bool CheckAvailableTable(bool availableTables)
        {
            for (int i = 1; i < tableDictionary.Count + 1; i++)
            {
                if (tableDictionary[i].IsOccupied == false)
                {
                    if (tableDictionary[i].TableSize == 4 && QueueCompany.First().Count >= 3 || tableDictionary[i].TableSize == 2 && QueueCompany.First().Count <= 2)
                        availableTables = true;
                }
            }
            return availableTables;
        }

    }
}
