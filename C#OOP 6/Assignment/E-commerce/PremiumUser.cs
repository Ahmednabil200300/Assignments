using Assignment.E_commerce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class PremiumUser : User
    {
        public PremiumUser(string name):base(name) { 
        Name = name;
                }

        public override Discount GetDiscount()
        {
            return new FlatDiscount(100);
        }
    }
}
