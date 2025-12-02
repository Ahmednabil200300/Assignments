using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.E_commerce
{
    class FlatDiscount : Discount
    {
        public int  Amount {  get; set; }

        public FlatDiscount(int amount):base("FlatDiscount")
        {
            Amount = amount;

        }
        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return Amount * Math.Min(quantity,1);
        }
    }
}
