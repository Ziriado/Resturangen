using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Restaurant
{
    internal class Table
    {
        public bool IsOccupied { get; set; }

        public bool IsDirty { get; set; }

        public int TableSize { get; set; }

        public int TableQuality { get; set; }

        public List<Table> TablesList { get; set; }

        public Table(bool IsOccupied, bool IsDirty, int tableSize, int tableQuality)
        {
            IsOccupied = false;
            IsDirty = false;
            TableSize = tableSize;
            TableQuality = tableQuality;
            //TablesList = new List<Table>();
            //TablesList.Add(new TableOne(IsOccupied, IsDirty, tableSize, tableQuality));
            //TablesList.Add(new TableTwo(IsOccupied, IsDirty, tableSize, tableQuality));
            //TablesList.Add(new TableSix(IsOccupied, IsDirty, tableSize, tableQuality));
            //TablesList.Add(new TableSeven(IsOccupied, IsDirty, tableSize, tableQuality));
        }
    }
}
