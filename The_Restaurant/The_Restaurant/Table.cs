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
        public bool HasOrderd { get; set; }

        public int TableSize { get; set; }

        public int TableQuality { get; set; }
        public int SetY { get; set; }
        public int SetX { get; set; }

        public List<Guest> CompanyList { get; set; }

        public Table(string name, bool isOccupied, bool isDirty,bool hasOrdered, int tableSize, int tableQuality, int setY, int setX, List<Guest> CompanyList)
        {
            Name = name;
            IsOccupied = isOccupied;
            IsDirty = isDirty;
            HasOrderd = hasOrdered;
            TableSize = tableSize;
            TableQuality = tableQuality;
            SetY = setY;
            SetX = setX;
            CompanyList = new List<Guest>();
        }
        public Table()
        {

        }
    }
}
