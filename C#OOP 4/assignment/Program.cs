using System;

namespace assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region @1

            //Calculater Calc = new Calculater();
            //Console.WriteLine(Calc.Add(10, 20));
            //Console.WriteLine(Calc.Add(10, 20 , 30));
            //Console.WriteLine(Calc.Add(10.3, 20.50));


            #endregion


            #region @2

            Rectangle R1 = new Rectangle();
            // width=0 , height = 0


            Rectangle R2 = new Rectangle(10,20);
            // width = 10 , height = 20


            Rectangle R3 = new Rectangle(10);
            // width = height = 10
            #endregion

            #region @3
            //Complex complex01 = new Complex() { Real = 10 ,  Img = 5};
            //Complex complex02 = new Complex() { Real = 7, Img = 3 };

            //Complex complex03 = new Complex();
            //complex03 = complex01 + complex02;

            //Console.WriteLine(complex03);


            //Console.WriteLine("---------------------");
            //complex03 = complex01 - complex02;


            //Console.WriteLine(complex03);

            #endregion

            #region @4

            //Employee Emp = new Employee();
            //Emp.Works();

            //Manager manager = new Manager();
            //manager.Works()

            #endregion

            #region @5

            //BaseClass baseClass = new BaseClass();
            //baseClass.DisplayMessage();

            //DerivedClass1 derivedClass1 = new DerivedClass1();
            //derivedClass1.DisplayMessage();

            //DerivedClass2 derivedClass2 = new DerivedClass2();
            //derivedClass2.DisplayMessage();

            #endregion

            // Part 2 

            // Duration D1 =new Duration (1,10,15);


            //Duration D1 = new Duration(1, 10, 15);
            //Console.WriteLine(D1);


            //Duration D2 = new Duration(7800);

            //Duration D1 = new Duration(3600);

            //Console.WriteLine(D1);
            //Console.WriteLine(D2);


            //Duration D3 = new Duration(666);
            //Console.WriteLine(D3);

            //Duration D4;
            //D4 = D1 + D2;
            //Console.WriteLine(D4);






        }
    }
}
