using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment.Shape
{
    class Circle : ICircle
    {
        public double Radius { get ; set ; }

        public double Area
        {
            get
            {
                return Radius * Radius * 3.14;
            }
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Circle with Radius = {Radius} \nArea: {Area} ");
        }
    }
}
