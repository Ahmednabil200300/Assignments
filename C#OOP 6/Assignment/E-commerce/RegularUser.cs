using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.E_commerce
{
    class RegularUser : User
    {
        public RegularUser(string name):base(name)
        { 
        Name = name;
        }
        public override Discount GetDiscount()
        {
            return new PercentageDiscount(5);
        }
    }
}
