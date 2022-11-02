using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Restaurant
{
    internal class Graphics
    {
        public List<Table> _tableList = new List<Table>();
        public Dictionary<string, Table> tableDictionary = new Dictionary<string, Table>();

        public void DrawRestaurant(List <Guest> guests)
        {
            List<Guest> empty = new List<Guest>();
            
            tableDictionary.Add("Bord 1", new Table { Name = "Bord 1", IsDirty = false, IsOccupied = false, TableQuality = 5, TableSize = 4, SetX = 0, SetY = 7 });
            tableDictionary.Add("Bord 2", new Table { Name = "Bord 2", IsDirty = false, IsOccupied = false, TableQuality = 5, TableSize = 4, SetX = 20, SetY = 7 });
            tableDictionary.Add("Bord 3", new Table { Name = "Bord 3", IsDirty = false, IsOccupied = false, TableQuality = 5, TableSize = 4, SetX = 40, SetY = 7 });
            tableDictionary.Add("Bord 4", new Table { Name = "Bord 4", IsDirty = false, IsOccupied = false, TableQuality = 5, TableSize = 4, SetX = 60, SetY = 7 });
            tableDictionary.Add("Bord 5", new Table { Name = "Bord 5", IsDirty = false, IsOccupied = false, TableQuality = 5, TableSize = 4, SetX = 80, SetY = 7 });
            tableDictionary.Add("Bord 6", new Table { Name = "Bord 6", IsDirty = false, IsOccupied = false, TableQuality = 5, TableSize = 2, SetX = 0, SetY = 17 });
            tableDictionary.Add("Bord 7", new Table { Name = "Bord 7", IsDirty = false, IsOccupied = false, TableQuality = 5, TableSize = 2, SetX = 20, SetY = 17 });
            tableDictionary.Add("Bord 8", new Table { Name = "Bord 8", IsDirty = false, IsOccupied = false, TableQuality = 5, TableSize = 2, SetX = 40, SetY = 17 });
            tableDictionary.Add("Bord 9", new Table { Name = "Bord 9", IsDirty = false, IsOccupied = false, TableQuality = 5, TableSize = 2, SetX = 60, SetY = 17 });
            tableDictionary.Add("Bord 10", new Table { Name = "Bord 10", IsDirty = false, IsOccupied = false, TableQuality = 5, TableSize = 2, SetX = 80, SetY = 17 });

            Draw("Kö", 98, 0, empty);
            Draw("Köket", 40, 0, empty);
            Draw("Diskbås", 53, 0, empty);

            foreach (KeyValuePair<string, Table> table in tableDictionary)
            {
                if (table.Value.IsDirty == false && table.Value.IsOccupied == false && guests is not null)
                {
                    Draw(table.Value.Name, table.Value.SetX, table.Value.SetY, guests);
                }
                else
                {
                    Draw(table.Value.Name, table.Value.SetX, table.Value.SetY, empty);
                }
                guests.Clear();
            }

        }
        public void Draw<T>(string header, int fromLeft, int fromTop, List<T> anyList)
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
