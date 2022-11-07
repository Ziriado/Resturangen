using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Restaurant
{
    internal class Menu_Writing
    {
        SendMethodClass myMenu=new SendMethodClass();
        public List<Menu> Menu()
        {
            List<Menu> MenuList = new List<Menu>();
            MenuList.Add(new Flounder(125, "Flundra"));
            MenuList.Add(new Salmon(300, "Lax"));
            MenuList.Add(new Sirloin_Steak(210, "Ryggbiff"));
            MenuList.Add(new Cod(155, "Torsk"));
            MenuList.Add(new Bolognese(140, "Bolognese"));
            MenuList.Add(new Beef_Tender_Loin(380, "Oxfile"));
            MenuList.Add(new Halloumi(80, "Halloumi"));
            MenuList.Add(new Cauliflower_Mash(60, "Blomkålsröra"));
            MenuList.Add(new Vego_HappyMeal(85, "Vego Happy Meal"));

            myMenu.listCalc(MenuList);
            return MenuList;
           
        }
    }
}
