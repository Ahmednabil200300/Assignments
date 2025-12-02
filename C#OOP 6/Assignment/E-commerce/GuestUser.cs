using Assignment.E_commerce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class GuestUser : User
    {
        public GuestUser(string? name) : base(name)
        {
            Name = name;
        }

        public override Discount GetDiscount()
        {
            return new PercentageDiscount(0);
    }
}
