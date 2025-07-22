namespace Assignment_C_5
{
    internal class Program
    {

            //Question 1
            static void Swap(int x, int y)
            {
                int temp = x;
                x = y;
                y = temp;
            }
            static void SwapRef(ref int x, ref int y)
            {
                int temp = x;
                x = y;
                y = temp;
            }
            public static void Main()
           {
            int n1 = 20, n2 = 30;
            Swap(n1, n2);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
       
            int x = 20, y = 30;
            SwapRef(ref x, ref y);
            Console.WriteLine(x);
            Console.WriteLine(y);
           }
        //Question 2
        //Question 3
        static void Sum_Sub(int num1, int num2,  int sum,  int sub)
            {
                sum = num1 + num2;
                sub = num1 - num2;
            }
        public static void Main()
        {
            int num1 = 10;
            int num2 = 20;
          
            Console.WriteLine(sum);
            Console.WriteLine(sub);
        }
        //Question 4
        static int SumOfDigit(int n)
        {
            int sum = 0;
            while (n != 0)
            {
                sum += n % 10;
                n /= 10;

            }
            return sum;
        }
        public static void Main()
        {
            int n = 19070;

            Console.WriteLine(SumOfDigit(n));
        }
        //Question 5
        static bool IsPrime(int n)
            {
                if (n < 2)
                    return false;
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
            static void Main()
            {
                
                int number = 5;
                Console.WriteLine(IsPrime(n)); 
            }
        }



        //Question 6
       
        static void MinMaxArray(int[] arr, ref int max, ref int min)
        {
            if (arr is null)
                return;
            max = arr[0];
            min = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                    max = arr[i];
                else if (min > arr[i])
                    min = arr[i];
            }
        }
        static void Main() 
        { 
        
            int[] numbers = { 0, 30, 10, 60, 25, 5 };
            int max = 0, min = 0;
            MinMaxArray(numbers, ref max, ref min);
            Console.WriteLine(max);
            Console.WriteLine(min);
             }
        //Question 7
        static long factorial(int num)
        {
            int result = 1;
            for (int i = 1; i <= num; i++)
            {
                result *= i;
            }
            return result;
        }
        static void Main()
        {

            int fact = 0;
            Console.WriteLine(factorial(fact));
        }
        //Question 8
        static string ChangeChar(string text, int index, char ch)
        {
            text = text.Remove(index, 1);
            text = text.Insert(index, ch.ToString());
            return text;

        }
        static void Main()
        {
            Console.WriteLine("Enter a string: ");
            string word = Console.ReadLine();

            char letter;
            int index;
            string result;

            Console.WriteLine("Enter Index : ");
            index = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter letter : ");
            letter = char.Parse(Console.ReadLine());

            result = ChangeChar(word, index, letter);
            Console.WriteLine("result");
        }
    }
}
