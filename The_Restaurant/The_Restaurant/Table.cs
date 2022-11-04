using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Restaurant
{
    internal class Table
    {
        public string Name { get; set; }
        public bool IsOccupied { get; set; }

        public bool IsDirty { get; set; }

        public int TableSize { get; set; }

        public int TableQuality { get; set; }
        public int SetY { get; set; }
        public int SetX { get; set; }

        public List<Table> CompanyList { get; set; }

        public Table(string name, bool IsOccupied, bool IsDirty, int tableSize, int tableQuality, int setY, int setX, List<Table> CompanyList)
        {
            Name = name;
            IsOccupied = false;
            IsDirty = false;
            TableSize = tableSize;
            TableQuality = tableQuality;
            SetY = setY;
            SetX = setX;
            CompanyList = new List<Table>();


        }
        public Table()
        {

        }
    }
}
