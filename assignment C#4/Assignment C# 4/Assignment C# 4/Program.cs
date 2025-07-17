namespace Assignment_C__4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            Console.Write("Enter  number: ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine(i);
            }
            //Question 2

            Console.Write("Enter  number: ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 12; i++)
            {
                Console.Write(num * i );
            }

            //Question 3
            Console.WriteLine(value: "Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }
            //Question 4
            Console.Write("Enter num1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter num2: ");
            int num2 = int.Parse(Console.ReadLine());
            int result = 1;
            for (int i = 1; i <= num2; i++)
            {
                result *= num1;
            }

            Console.WriteLine(result);

            //Question 5
            double sum = 0;
            for (int i = 0; i < 5; i++)
            {
                int mark = int.Parse(Console.ReadLine());
                sum += mark;
            }

    
            double avg = sum / 5.0;
            double percentage = (sum * 100) / 500;
            Console.WriteLine("sum");
            Console.WriteLine("avg");
            Console.WriteLine("percentage");
        }
}
            //Question 6
            //Question 7
            //Question 8
            //Question 9

            //Question 10
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());

         
            double slope1 = (y2 - y1) / (x2 - x1);
            double slope2 = (y3 - y2) / (x3 - x2);
            if (slope1 == slope2)
            {
                Console.WriteLine("the points lie on a single straight line ");
            }
            else
            {
                Console.WriteLine( "the points don't lie on a single straight line ");
            }
        }
        //Question 11
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i<n; i++)
        {
            for (int j = 0; j<n; j++)
            {             
                if (i == j)
                {
                    Console.Write(value: 1);
                }
                else
                {
                    Console.Write(value: 0);
                }
            }
            
            Console.WriteLine();
        }
    }
    }
    }
}
