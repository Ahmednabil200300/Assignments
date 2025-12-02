using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.E_commerce
{
    class BuyOneGetOneDiscount : Discount
    {
        public BuyOneGetOneDiscount():base("BuyOneGetOneDiscount")
        {

        }

        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            if (quantity < 1)
                return 0;
            else
            {
                return (price / 2) * (quantity / 2);

            }
        }
    }
}
