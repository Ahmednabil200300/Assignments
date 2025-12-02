using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.PointProject
{
    class Point3D : IComparable<Point3D> , ICloneable
    {
        #region Properties
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        #endregion


        #region Constructors

      

        public Point3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public Point3D(int x, int y) : this(x, y, 0)
        {

        }

        public Point3D(int x) : this(x, 0, 0)
        {

        }

        public Point3D(Point3D point)
        {
            X = point.X; Y = point.Y; Z = point.Z;
        }

        #endregion


        #region Method
        public override string ToString()
        {
            return $"“Point Coordinates: ({X}, {Y}, {Z})”.";
        }

       public static bool operator == (Point3D left, Point3D right)
        {
            if (left.X == right.X && left.Y == right.Y && left.Z == right.Z)
           
                return true;
             else
            return false; 
        }

        public static bool operator != (Point3D left, Point3D right)
        {
            if (left.X != right.X || left.Y != right.Y || left.Z != right.Z)

                return true;
            else
                return false;




        }
        public static Point3D CreatePoint() {
            
            int x,y, z; 
            bool isParsed = false;
            do
            {
                Console.WriteLine("Enter Point X ");
                isParsed = int.TryParse(Console.ReadLine(), out x);

            } while (!isParsed);
            do
            {
                Console.WriteLine("Enter Point  Y ");
                isParsed = int.TryParse(Console.ReadLine(), out y);

            } while (!isParsed);
            do
            {
                Console.WriteLine("Enter Point Z");
                isParsed = int.TryParse(Console.ReadLine(), out z);

            } while (!isParsed);

            return new Point3D(x, y, z);

        }

    public static Point3D[] CreateArray(int size)
        {
            Point3D[] array = new Point3D[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = CreatePoint();
            }
            return array;
        }

        public static void PrintArray(Point3D[] points)
        {
            for (int i = 0; i < points.Length; i++) {
                Console.WriteLine(points[i]);
            }
        }

        public int CompareTo(Point3D? obj)
        {
            if (this.X > obj?.X)
                return 1;
            else if (this.X < obj?.X) return -1;
            else if(this.Y > obj?.Y)
                return 1;
            else return -1;
        }

        public object Clone()
        {
            return new Point3D(this);
        }




        #endregion

    }
}
