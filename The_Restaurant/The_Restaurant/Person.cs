using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Restaurant
{
    interface IPerson
    {
        public string Name { get; set; }

    }
    class Guest : IPerson
    {
        public string Name { get; set; }

        public Guest()
        {
            Name = The_Restaurant.Company.LastName();
        }
    }
    class Waitress : IPerson
    {
        public int NumberOfWaitresses { get; set; } = 3;

        public int SetX { get; set; }
        public int SetY { get; set; }
        public bool IsAvailable { get; set; }
        public string Name { get; set; }

        public Waitress(bool isAvailable, int setX, int setY)
        {
            Name = The_Restaurant.Company.LastName();
            SetX = setX;
            SetY = setY;
            isAvailable = true;
        }
    }
    class Chef : IPerson
    {
        public string Name { get; set; }

        public Chef()
        {
            Name = The_Restaurant.Company.LastName();
        }
    }
}
