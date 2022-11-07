using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Restaurant
{
    internal class SendMethodClass
    {
        public int calc(int a, int b)
        {
            a = a - b;

            return a;
        }

        public int listCalc(List<Menu> s)
        {
            Random random = new Random();
            int listLength = s.Count;
            int rnd;
            rnd = random.Next(0, listLength);
            return rnd;
        }
        //Add one more int later for table quality
        public int tipCalc(int remaningcash, int b, int c)
        {
            double total;
            double calc = b + c;
            double divide = calc / 40;
            total = Convert.ToDouble(remaningcash) * divide;

            if (remaningcash < total)
            {
                total = 0;
                return Convert.ToInt32(total);
            }
            else
                return Convert.ToInt32(total);

        }
    }
}
