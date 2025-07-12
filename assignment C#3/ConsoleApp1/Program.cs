namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
         //Question 1

             Console.Write("Enter a number: ");
             string input = Console.ReadLine();
             int number = int.Parse(input);
             Console.WriteLine("Your number: " + number);
        

        //Question 2


        string input = "ahmednabil";
        int number = int.Parse(input); 
        Console.WriteLine("Number: " + number);



        //Question 3


          double num1 = 2.3;
          double num2 = 3.2;
          double result = num1 + num2;
          Console.WriteLine("Result: " + result);




            //Question 4


            string s = "ahmed";
            string sub = s.Substring(6, 5);
            Console.WriteLine("Substring: " + sub);


            //Question 5


            int x = 10;
            int y = 15;  
            y=x
            y = 20;     
            Console.WriteLine( y);


            //Question 6


            int[] arr1 = { 1, 2, 3 };
            int[] arr2 = { 4, 5, 6 };
            arr1= arr2
            arr2[0] = 10; 
            Console.WriteLine( arr1[0]);



            //Question 7 


            string s1 = "Ahmed";
            string s2 = "Nabil";
            string s3 = s1 + " " + s2;
            Console.WriteLine(s3);



            //Question 8

            double principal = 50 , rate = 30, time = 15;
            double interest = (double)(principal * rate * time) / 100.0;
            Console.WriteLine(interest);



            //Question 9 
            double weight = 20, height =40 ;
            double BMI = (weight) / (height * height);
            Console.WriteLine(BMI);


            //Question 10

            double temperature = 25;
            string result;

            if (temperature < 10)
            {
                result = "Just Cold";
            }
            else if (temperature > 30)
            {
                result = "Just Hot";
            }
            else
            {
                result = "Just Good";
            }

            Console.WriteLine(result);

            //Question 11

            Console.Write("Enter day: ");
            int day = int.Parse(Console.ReadLine());

            Console.Write(" Enter month: ");
            int month = int.Parse(Console.ReadLine());

            Console.Write("Enter year: ");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine($"Today's date : {day} , {month} , {year}");
            Console.WriteLine($"Today's date : {day} / {month} / {year}");
            Console.WriteLine($"Today's date : {day} – {month} – {year}");


            //Question 12


            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 3 == 0 && number % 4 == 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }


        //Question 13 


        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        if (number< 0)
        {
            Console.WriteLine("negative");
        }
        else
        {
            Console.WriteLine("positive");
        }
    }


        //Question 14 
          

        Console.Write("Enter the first number: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.Write("Enter the third number: ");
        int num3 = int.Parse(Console.ReadLine());
        int max;
        if (num1 >= num2 && num1 >= num3)
        {
            max = num1;
         }
         else if (num2 >= num1 && num2 >= num3)
        {
             max = num2;
         }
          else
         { 
             max = num3;
              }

         int min;
          if (num1 <= num2 && num1 <= num3)
          {
              min = num1;
           }
          else if (num2 <= num1 && num2 <= num3)
          {
              min = num2;
           }
             else
              {
              min = num3;
               } 
              Console.WriteLine($"Max Number is => {max}");
              Console.WriteLine($"Min Number is => {min}");
        

        //Question 15 
   

        Console.Write("Enter an integer number: ");
        int number = int.Parse(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine("Even");
        }
        else
        {
            Console.WriteLine("Odd");
        }
    }



        //Question 16 



            Console.Write("Enter a character: ");
            char ch = char.Parse(Console.ReadLine().ToLower());

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
               Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("consonant");
            }
            }


        //Question 17
        

        Console.Write("Enter month number (1–12): ");
        int month = int.Parse(Console.ReadLine());

        int days;

        switch (month)
        { 
         case 1:
         case 3:
         case 5:
         case 7:
         case 8:
         case 10:
         case 12:
              days = 31;
               break;

         case 4:
         case 6:
         case 9:
         case 11:
              days = 30;
               break;

         case 2:
           days = 28; 
             break;

         default:
            Console.WriteLine("Invalid month number");
          return;
        }

        Console.WriteLine("Days in Month: " + days);
        }
}
}
