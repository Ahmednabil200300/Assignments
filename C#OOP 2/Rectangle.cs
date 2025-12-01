using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    struct Rectangle
    {
        private double width;
        private double height;

        public double Width
        {
            get { return width; }
            set
            {
                if (width >= 0)
                { width = value; }
                else
                { Console.WriteLine("Width cannot be negative."); }



            }
        }
        public double Height
        {
            get { return height; }
            set
            {

                if (height >= 0)
                {
                    height = value;
                }
                else
                {
                    Console.WriteLine("height cannot be negative.");
                }

            }




        }



        public double Area()
        {
            return width * height;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Width: {Width}");
            Console.WriteLine($"Height: {Height}");
            Console.WriteLine($"Area: {Area()}");
        }



    }
}
