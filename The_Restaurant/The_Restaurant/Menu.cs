using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Restaurant
{

    public class Menu
    {
        public double Price { get; set; }
        public string Name { get; set; }
        public Menu(double price, string name)
        {
            Price = price;
            Name = name;
        }
        public Menu CourseFromMenu()
        {
            //SendMethodClass myMenu = new SendMethodClass();

            List<Menu> Course = new List<Menu>();
            Course.Add(new Flounder(125, "Flundra"));
            Course.Add(new Salmon(300, "Lax"));
            Course.Add(new Sirloin_Steak(210, "Ryggbiff"));
            Course.Add(new Cod(155, "Torsk"));
            Course.Add(new Bolognese(140, "Bolognese"));
            Course.Add(new Beef_Tender_Loin(380, "Oxfile"));
            Course.Add(new Halloumi(80, "Halloumi"));
            Course.Add(new Cauliflower_Mash(60, "Blomkålsröra"));
            Course.Add(new Vego_HappyMeal(85, "Vego Happy Meal"));

            Random rnd = new Random();
            int index = rnd.Next(0, Course.Count - 1);

            //myMenu.listCalc(MenuList);
            return Course[index];
        }
    }

    public class Flounder : Menu
    {
        public Flounder(double price, string name) : base(price, name)
        {


        }
    }
    public class Salmon : Menu
    {
        public Salmon(double price, string name) : base(price, name)
        {

        }
    }
    public class Cod : Menu
    {
        public Cod(double price, string name) : base(price, name)
        {

        }
    }
    public class Sirloin_Steak : Menu
    {
        public Sirloin_Steak(double price, string name) : base(price, name)
        {

        }
    }
    public class Bolognese : Menu
    {
        public Bolognese(double price, string name) : base(price, name)
        {

        }
    }
    public class Beef_Tender_Loin : Menu
    {
        public Beef_Tender_Loin(double price, string name) : base(price, name)
        {

        }
    }
    public class Halloumi : Menu
    {
        public Halloumi(double price, string name) : base(price, name)
        {

        }
    }
    public class Cauliflower_Mash : Menu
    {
        public Cauliflower_Mash(double price, string name) : base(price, name)
        {

        }
    }
    public class Vego_HappyMeal : Menu
    {
        public Vego_HappyMeal(double price, string name) : base(price, name)
        {

        }

    }
}


