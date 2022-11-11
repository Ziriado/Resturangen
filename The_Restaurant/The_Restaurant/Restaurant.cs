using System;
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
        List<Waitress> ListOfWaitress { get; set; } = new List<Waitress>();
        List<Chef> ListOfChef { get; set; } = new List<Chef>();
        Queue<List<Guest>> QueueCompany { get; set; } = new Queue<List<Guest>>();
        List <string> NewsFeed { get; set; } = new List<string>();

        List <Guest> ListOfDishers { get; set;} = new List<Guest>();

        Dictionary<int, Table> tableDictionary = new Dictionary<int, Table>();
        Dictionary<int, List<Menu>> orderDictionary = new Dictionary<int, List<Menu>>();

        Company company = new Company();
        Graphics graphics = new Graphics();
        Menu menu = new Menu(0,"");
        Chef chef = new Chef();
        Waitress waitress = new Waitress();


        public void Welcome()
        {
            for (int i = 0; i < waitress.NumberOfWaitresses; i++)
            {
                ListOfWaitress.Add(new Waitress(true, 0, 0));
            }
            for (int i = 0; i < chef.NumberOfChefs; i++)
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
                for (int i = 0; i < ListOfWaitress.Count; i++)
                {
                    ListOfWaitress[i].IsAvailable = true;
                    //if (orderDictionary != null)
                    //{
                    //    TakeCompanyOrderToChef();
                    //    chef.CookFood();
                    //}
                    if (ListOfWaitress[i].IsAvailable == true && QueueCompany is not null && ListOfWaitress[i].SetX != 100)
                    {
                        WaitressGoToEntrence(ListOfWaitress);
                    }
                    else if (ListOfWaitress[i].SetX == 100)
                    {
                        tableNr = PlaceCompanyAtTable();
                        OrderFood(tableNr);
                        ListOfWaitress[i].IsAvailable = false;
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
                        foreach (Waitress w in ListOfWaitress)
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

                        foreach (Waitress w in ListOfWaitress)
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
                NewsFeed.Add("Servitören " + w.Name + " går till entren.");
            }
        }

        private void TakeCompanyOrderToChef()
        {
            foreach (Waitress w in ListOfWaitress)
            {
                if (w.IsAvailable == true && w.SetX != 40)
                {
                    w.MoveToKitchen(ListOfWaitress);
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
                for (int i = 0; i < foods.Count; i++)
                {
                    //Placerar den som inte har råd i diskbåset
                    if (tableDictionary[tableNumber].CompanyList[i].Cash < foods[i].Price)
                    {
                        
                        ListOfDishers.Add(tableDictionary[tableNumber].CompanyList[i]);
                     
                        
                    }

                    string result = tableDictionary[tableNumber].CompanyList[i].Cash >= foods[i].Price ? "har råd." : "har inte råd och får diska.";
                    NewsFeed.Add("Vid bord " + tableNumber + " sitter " + tableDictionary[tableNumber].CompanyList[i].Name + " och beställer " + foods[i].Name + " som kostar " + foods[i].Price + " kr. "
                    + tableDictionary[tableNumber].CompanyList[i].Name + " har " + tableDictionary[tableNumber].CompanyList[i].Cash + " kr och " + result);                     
                }
            }        
        }
        public void SendFoodToTable(Queue<List<Menu>> Orders)
        {
            foreach (Waitress w in ListOfWaitress)
            {
                if (w.IsAvailable == true)
                {

                }
            }
        }

        public void DrawRestaurant()
        {
            List<Guest> empty = new List<Guest>();
            
            //empty.Add(new Guest());

            Console.Clear();
            foreach (Waitress w in ListOfWaitress)
            {
                graphics.Draw("Servitör", w.SetX, w.SetY, ListOfWaitress);
            }
            foreach (KeyValuePair<int, Table> kvp in tableDictionary)
            {
                graphics.Draw(kvp.Value.Name, kvp.Value.SetX, kvp.Value.SetY, kvp.Value.CompanyList);
            }
            graphics.Draw("Kö", 100, 5, QueueCompany.First());
            graphics.Draw("Köket", 40, 0, ListOfChef);
            graphics.Draw("Diskbåset", 70, 0, ListOfDishers);
            graphics.Draw("WC", 100, 15, empty);

            Console.SetCursorPosition(0, 25);
            for (int i = NewsFeed.Count - 1; i >= 0; i--)
            {
                if (NewsFeed.Count - i <= 15)
                {
                    Console.WriteLine(i + ": " + NewsFeed[i] + "                                                      ");
                }
            }
        }
        private void CreateQueue()
        {
            for (int i = 0; i < company.NumberOfCompanies; i++)
            {
                QueueCompany.Enqueue(company.RandomizeCompany());
            }
        }

        public void CreateTables()
        {
            tableDictionary.Add(1, new Table { Name = "Bord 1", TableQuality = 5, TableSize = 4, SetX = 0, SetY = 10, CompanyList = new List<Guest>() });
            tableDictionary.Add(2, new Table { Name = "Bord 2", TableQuality = 5, TableSize = 4, SetX = 20, SetY = 10, CompanyList = new List<Guest>() });
            tableDictionary.Add(3, new Table { Name = "Bord 3", TableQuality = 5, TableSize = 4, SetX = 40, SetY = 10, CompanyList = new List<Guest>() });
            tableDictionary.Add(4, new Table { Name = "Bord 4", TableQuality = 4, TableSize = 4, SetX = 60, SetY = 10, CompanyList = new List<Guest>() });
            tableDictionary.Add(5, new Table { Name = "Bord 5", TableQuality = 3, TableSize = 4, SetX = 80, SetY = 10, CompanyList = new List<Guest>() });
            tableDictionary.Add(6, new Table { Name = "Bord 6", TableQuality = 5, TableSize = 2, SetX = 0, SetY = 20, CompanyList = new List<Guest>() });
            tableDictionary.Add(7, new Table { Name = "Bord 7", TableQuality = 5, TableSize = 2, SetX = 20, SetY = 20, CompanyList = new List<Guest>() });
            tableDictionary.Add(8, new Table { Name = "Bord 8", TableQuality = 5, TableSize = 2, SetX = 40, SetY = 20, CompanyList = new List<Guest>() });
            tableDictionary.Add(9, new Table { Name = "Bord 9", TableQuality = 4, TableSize = 2, SetX = 60, SetY = 20, CompanyList = new List<Guest>() });
            tableDictionary.Add(10, new Table { Name = "Bord 10", TableQuality = 3, TableSize = 2, SetX = 80, SetY = 20, CompanyList = new List<Guest>() });
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
