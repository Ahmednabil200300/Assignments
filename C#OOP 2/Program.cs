using System.ComponentModel;
using System.Xml.Linq;

namespace assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1

            //Person[] Persons = new Person[] 
            //{ 
            //new Person { Name = "Ola" , Age = 30},
            //new Person {Name = "Nour" , Age=25},
            //new Person {Name = "Mohammed" , Age=30},
            //};

            //foreach (Person person in Persons) {
            //    Console.WriteLine($"Name: {person.Name} , Age: {person.Age}\n");
            //}
            #endregion



            #region Q2
            //Console.WriteLine("Enter The First Point X1: ");
            //double.TryParse(Console.ReadLine(), out double x1);


            //Console.WriteLine("Enter The First Point y1: ");
            //double.TryParse(Console.ReadLine(), out double y1);


            //Console.WriteLine("Enter The First Point x2: ");
            //double.TryParse(Console.ReadLine(), out double x2);


            //Console.WriteLine("Enter The First Point y2: ");
            //double.TryParse(Console.ReadLine(), out double y2);

            //Point p1 = new Point(x1, y1);
            //Point p2 = new Point(x2, y2);

            //double dis = Distance(p1, p2);
            //Console.WriteLine($"The Distance Is: {dis}");


            //static double Distance(Point p1, Point p2) {

            //    double dx = p2.x - p1.x;
            //    double dy = p2.y - p1.y;
            //    return Math.Sqrt(dx * dx + dy * dy); 
            //}


            #endregion


            #region Q3

            //Console.WriteLine("Please Enter Name The First Person: ");
            //string? name1 = Console.ReadLine();
            //Console.WriteLine("Please Enter Age The First Person: ");
            //int.TryParse(Console.ReadLine(), out int age1);



            //Console.WriteLine("Please Enter Name The second Person: ");
            //string? name2 = Console.ReadLine();
            //Console.WriteLine("Please Enter Age The second Person: ");
            //int.TryParse(Console.ReadLine(), out int age2);


            //Console.WriteLine("Please Enter Name The three Person: ");
            //string? name3 = Console.ReadLine();
            //Console.WriteLine("Please Enter Age The three Person: ");
            //int.TryParse(Console.ReadLine(), out int age3);



            //Person[] person = new Person[]
            //{
            //    new Person {Name = name1 , Age = age1},
            //    new Person {Name = name2 , Age = age2},
            //    new Person {Name = name3 , Age = age3}
            //};
            //Person oldestPerson = new Person();

            //for (int i = 0; i < person.Length; i++) {



            //    if (person[i].Age > oldestPerson.Age)
            //    {
            //        oldestPerson = person[i];
            //    }
            //}

            //Console.WriteLine($"Name: {oldestPerson.Name}, Age: {oldestPerson.Age}");

            #endregion



            #region Q4
       

            Rectangle R1 = new Rectangle();
            R1.Width = 100;
            R1.Height = 150;

            double AreaR1 = R1.Area();
            Console.WriteLine(AreaR1);
            R1.DisplayInfo();
       

        #endregion
    }
    }
}
