using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment.Shape
{
    interface IRectangle : IShape
    {
        public int Width { get; set; }
        public int Height { get; set; }


    }
}
