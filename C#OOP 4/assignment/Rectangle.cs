using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    class Rectangle
    {
        #region Prorerties
        public double Height {  get; set; }
        public double Width { get; set; }
        #endregion

        #region Constructors

        public Rectangle(int width = 0, int height = 0) {
           
        }
        public Rectangle( )
        {
            Width = 0;
            Height = 0;
        }

        public Rectangle(int S)
        {
            Width = Height = S;
        }
        #endregion

    }
}
