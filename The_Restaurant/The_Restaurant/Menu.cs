using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Restaurant
{

    //    public class Menu
    //    {
    //        public double Price { get; set; }
    //        public string Name { get; set; }
    //        public Menu(double price, string name)
    //        {
    //            Price = price;
    //            Name = name;
    //        }
    //    }

    //    public class Flounder : Menu
    //    {
    //        public Flounder(double price, string name) : base(price, name)
    //        {


    //        }
    //    }
    //    public class Salmon : Menu
    //    {
    //        public Salmon(double price, string name) : base(price, name)
    //        {

    //        }
    //    }
    //    public class Cod : Menu
    //    {
    //        public Cod(double price, string name) : base(price, name)
    //        {

    //        }
    //    }
    //    public class Sirloin_Steak : Menu
    //    {
    //        public Sirloin_Steak(double price, string name) : base(price, name)
    //        {

    //        }
    //    }
    //    public class Bolognese : Menu
    //    {
    //        public Bolognese(double price, string name) : base(price, name)
    //        {

    //        }
    //    }
    //    public class Beef_Tender_Loin : Menu
    //    {
    //        public Beef_Tender_Loin(double price, string name) : base(price, name)
    //        {

    //        }
    //    }
    //    public class Halloumi : Menu
    //    {
    //        public Halloumi(double price, string name) : base(price, name)
    //        {

    //        }
    //    }
    //    public class Cauliflower_Mash : Menu
    //    {
    //        public Cauliflower_Mash(double price, string name) : base(price, name)
    //        {

    //        }
    //    }
    //    public class Vego_HappyMeal : Menu
    //    {
    //        public Vego_HappyMeal(double price, string name) : base(price, name)
    //        {

    //        }

    //    }
    //}
    internal class Menu
    {
        public int Price { get; set; }

        public List<Menu> Dishes { get; set; }

        public Menu(int price)
        {
            Price = price;
            Dishes = new List<Menu>();


        }
        public void getDishes()
        {

        }
    }
}

