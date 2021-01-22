﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW1_3
{
    class FirstLevelDiscount : DiscountType
    {
        //protected const int rentDuration = 5;

        public override double Cost(Suit suit, int rentDuration)
        {
            double cost = (double)(rentDuration) * suit.SuitPrice;
            Console.WriteLine("Suit {0} costs {1}", suit.SuitID, cost);
            return cost;
        }

    }
}
