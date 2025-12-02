using Assignment.Calculater;
using Assignment.E_commerce;
using Assignment.PointProject;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region First Project:
            /*
           
               Point3D P = new Point3D (10,10,10);
               Console. WriteLine (P. ToString( ));
                Output: “Point Coordinates: (10, 10, 10)”.
                Read from the User the Coordinates for 2 points P1, P2 (Check the input using try Pares, Parse, Convert).
                Try to use  ==
                If (P1 == P2)   Does it work properly? 
                Define an array of points and sort this array based on X & Y coordinates.
                Implement ICloneable interface to be able to clone the object.

             */

            // 2 
            //Point3D P = new Point3D(10, 10, 10);
            //Console.WriteLine(P.ToString());
            //Console.WriteLine(P);


            //3 

            //Point3D P1 = Point3D.CreatePoint();
            //Console.WriteLine("Enter Point2 (X And Y And Z)");
            //Point3D P2 = Point3D.CreatePoint();

            //Console.WriteLine(P1);
            //Console.WriteLine(P2);




            // 4 Try to use  ==
            //  If(P1 == P2)   Does it work properly? 


            //if(P1 == P2)
            //{
            //    Console.WriteLine("Equals");
            //}
            //else
            //{
            //    Console.WriteLine("Not Equals");
            //}




            // 5 
            //Console.WriteLine("Enter number Of Array");

            // int.TryParse(Console.ReadLine(), out int size);


            //Point3D[] points = Point3D.CreateArray(size);
            //Point3D.PrintArray(points);


            //Array.Sort(points);



            // 6  

            //Point3D point = new Point3D(10, 5, 7);

            //Point3D point2 = (Point3D)point.Clone();



            #endregion



            #region Second Project:

            //Maths maths = new Maths();
            //double result = maths.Add(5, 7);
            //Console.WriteLine(result);
            //result = maths.Subtract(5, 7);
            //Console.WriteLine(result);
            //result= maths.Multiply(5, 7);
            //Console.WriteLine(result);
            //result = maths.Divide(5, 7);
            //Console.WriteLine(result);



            #endregion


            #region Third Project:



            // Ask  the user to input their type (Regular, Premium, or Guest).

            //Console.WriteLine("Enter Type Of User (Regular Or Premium Or Guest)");
            //string? type = Console.ReadLine();
            //User user ;

            //Console.WriteLine("Enter Your Name");

            //string? name = Console.ReadLine();


            //if (type == "Regular")
            //{
            //    user = new RegularUser(name);
            //}
            //else if (type == "Premium")
            //{
            //    user = new PremiumUser(name);
            //}
            //else if (type == "Guest") {
            //    user = new GuestUser(name);
            //}
            //else Console.WriteLine("invaled Type");


            #endregion
        }
    }
}
