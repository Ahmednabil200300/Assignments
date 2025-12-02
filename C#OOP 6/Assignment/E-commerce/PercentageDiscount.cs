using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.E_commerce
{
    class PercentageDiscount : Discount
    {

        public int Precentage {  get; set; }

        public PercentageDiscount(int precentage): base("PercentageDiscount")
        {
            Precentage = precentage;

        }
        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return price * quantity * (Precentage/100);
            
        }
    }
}
