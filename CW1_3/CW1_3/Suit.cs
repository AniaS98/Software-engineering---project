using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW1_3
{
    public class Suit
    {
        // id
        private string _suitID;
        public string SuitID
        {
            get { return this._suitID; }
            set { this._suitID = value; }   // docelowo należy "opakować" lub użyć "Proxy"
        }

        // cena
        private double _suitPrice;
        public double SuitPrice
        {
            get { return this._suitPrice; }
            set { this._suitPrice = value; }   // docelowo należy "opakować" lub użyć "Proxy"
        }

        // "Stan" - reprezentuje rodzaj konta (Junior, Standard, VIP).
        private DiscountType _discountType;
        public DiscountType DiscountType
        {
            get { return this._discountType; }
            set { this._discountType = value; }
        }

        public Suit(string _suitID, DiscountType discountType)
        {
            this._suitID = _suitID;
            this.DiscountType = discountType;
        }

        // operacja wypłaty
        public double Cost(int rentDuration)
        {
            // Deleguje wykonanie operacji do obiektu typu AccountType,
            // wywołując na nim polimorficzną metodę Withdraw().
            return this._discountType.Cost(this, rentDuration);
        }


    }
}
