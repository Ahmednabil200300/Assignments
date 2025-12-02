using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    class Manager : Employee
    {
        public override void Works()
        {
            base.Works();
            Console.WriteLine("Manager is managing");
        }

    }
}
