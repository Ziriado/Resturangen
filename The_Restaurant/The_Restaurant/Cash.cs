using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Restaurant
{
    internal class Cash
    {
        public int CalcRemainingCash(int totalCash, int priceOnFood)
        {
            totalCash = totalCash - priceOnFood;

            return totalCash;
        }

        //Add one more int later for table quality
        public int TipCalc(int remaningCash, int waitressSkill, int chefSkill)
        {
            double total;
            double calc = waitressSkill + chefSkill;
            double divide = calc / 40;
            total = Convert.ToDouble(remaningCash) * divide;

            if (remaningCash < total)
            {
                total = 0;
                return Convert.ToInt32(total);
            }
            else
                return Convert.ToInt32(total);
        }
    }
}
