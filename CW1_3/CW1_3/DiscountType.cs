using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW1_3
{
    public abstract class DiscountType
    {
        public abstract double Cost(Suit suit, int rentDuration);

    }
}
