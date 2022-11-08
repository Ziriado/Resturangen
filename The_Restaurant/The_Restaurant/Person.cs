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

        public int Cash { get; set; }

        public Guest()
        {
            Name = The_Restaurant.Company.LastName();
            Random rnd = new Random();
            Cash = rnd.Next(180, 500);
        }
    }
    class Waitress : IPerson
    {
        Chef Chef { get; set; }
        Restaurant restaurant = new Restaurant();
        public int NumberOfWaitresses { get; set; } = 3;

        public int SetX { get; set; }
        public int SetY { get; set; }
        public bool IsAvailable { get; set; }
        public string Name { get; set; }
        public int Skill { get; set; }
        public Waitress(bool isAvailable, int setX, int setY)
        {
            Name = The_Restaurant.Company.LastName();
            SetX = setX;
            SetY = setY;
            IsAvailable = isAvailable;
            Random rnd = new Random();
            Skill = rnd.Next(1, 6);
        }
        public void SendFoodToTable()
        {

        }
        public void TakeCompanyOrderToChef()
        {
            
        }
        public void MoveToKitchen(List<Waitress> waitresses)
        {
            foreach (Waitress waitress in waitresses)
            {
                waitress.SetX = 40;
                waitress.SetY = 3;
            }
        }
        public void MoveToTables()
        {

        }
    }
    class Chef : IPerson
    {
        Waitress Waitress { get; set; }
        public string Name { get; set; }
        public int Skill { get; set; }

        public int CookingTime { get; set; }

        public Chef()
        {
            Name = The_Restaurant.Company.LastName();
            Random rnd = new Random();
            Skill = rnd.Next(1, 6);
            CookingTime = 10;
        }
        public void CookFood()
        {
            CookingTime--;

            if (CookingTime == 0)
            {
                Waitress.SendFoodToTable();
            }
        }


    }
}
