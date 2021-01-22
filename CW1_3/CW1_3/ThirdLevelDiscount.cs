using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW1_3
{
    class ThirdLevelDiscount : DiscountType
    {
        //protected const int rentDuration = 5;
        protected const double percentage = 0.10;

        public override double Cost(Suit suit, int rentDuration)
        {
            double cost=suit.SuitPrice;
            double dayCost = cost;
            for(int i=1;i<rentDuration;i++)
            {
                dayCost = dayCost * (1 - percentage);
                cost += dayCost;
            }
            Console.WriteLine("Suit {0} costs {1}", suit.SuitID, cost);
            return cost;
        }
    }
}
