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
        }
    }
}
