using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Threading;
using static Demo.ListGenerator;
namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Restriction Operators
            #region 1. Find all products that are out of stock.
            // Fluent
            //var Result = ProductsList.Where(P => P.UnitsInStock == 0);
            ////Query
            //Result =from P in ProductsList
            //       where P.UnitsInStock == 0
            //       select P;
            //foreach (var unit in Result)
            //{
            //    Console.WriteLine(unit);
            //}
            #endregion
            #region 2. Find all products that are in stock and cost more than 3.00 per unit.
            //Fluent
            //var Result = ProductsList.Where(P => P.UnitsInStock == 0 && P.UnitPrice > 3.00M);

            ////Query
            //Result = from P in ProductsList
            //         where P.UnitsInStock == 0 && P.UnitPrice > 3.00M
            //         select P;
            //foreach (var unit in Result)
            //{
            //    Console.WriteLine(unit);
            //}

            #endregion
            #region 3. Returns digits whose name is shorter than their value.
            //String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            ////Fluent
            //var Result = Arr.Where((d, i) => d.Length < i);
            //foreach (var unit in Result)
            //{
            //    Console.WriteLine(unit);
            //}
            #endregion
            #endregion
            #region LINQ - Element Operators
            #region 1. Get first Product out of Stock 
            //Fluent
            //var Result = ProductsList.FirstOrDefault(P => P.UnitsInStock == 0);
            //Console.WriteLine(Result);

            #endregion
            #region 2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            //Fluent
            //var Result = ProductsList.FirstOrDefault(P => P.UnitPrice >1000);
            //Console.WriteLine(Result?.ProductName??"Not Found");
            #endregion
            #region 3. Retrieve the second number greater than 5 
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            ////Fluent
            //var Result = Arr.Where(n=> n > 5).ElementAt(1);
            //Console.WriteLine(Result);
            #endregion
            #endregion
            #region LINQ - Aggregate Operators
            #region 1. Uses Count to get the number of odd numbers in the array
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = Arr.Count(n => n % 2 == 1);
            //Console.WriteLine(Result);
            #endregion
            #region 2. Return a list of customers and how many orders each has.
            //var Result = CustomersList.Select(C=>new
            //{
            //    C.CustomerName,
            //    ordercount=C.Orders.Count()
            //});
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region 3. Return a list of categories and how many products each has
            //var Result = ProductsList.Select(P => new
            //{
            //   P.Category ,
            //    productcount = P.ProductName.Count()
            //});
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region 4. Get the total of the numbers in an array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = Arr.Sum();
            //Console.WriteLine(Result);

            #endregion
            #region 5. Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //var words =File.ReadAllLines("H:\\C# Projects\\Demo\\Demo\\dictionary_english.txt");
            //var Result = words.Sum(W => W.Length);
            //Console.WriteLine(Result);

            #endregion
            #region  Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //var words = File.ReadAllLines("H:\\C# Projects\\Demo\\Demo\\dictionary_english.txt");
            //var Result = words.Min(W => W.Length);
            //Console.WriteLine(Result);
            #endregion
            #region 7.Get the length of the longest word in dictionary_english.txt(Read dictionary_english.txt into Array of String First).
            //var words = File.ReadAllLines("H:\\C# Projects\\Demo\\Demo\\dictionary_english.txt");
            //var Result = words.Max(x => x.Length);
            //Console.WriteLine(Result);

            #endregion
            #region 8. Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //var words = File.ReadAllLines("H:\\C# Projects\\Demo\\Demo\\dictionary_english.txt");
            //var Result = words.Average(x => x.Length);
            //Console.WriteLine(Result);

            #endregion


            #endregion
            #region LINQ - Ordering Operators
            #region  Sort a list of products by name
            //var Result = ProductsList.OrderBy(P => P.ProductName);        
            ////Query
            //Result=from P in ProductsList
            //       orderby P.ProductName
            //       select P;
            //foreach (var item in Result)
            //    Console.WriteLine(item);
            #endregion
            #region 2. Uses a custom comparer to do a case-insensitive sort of the words in an array.
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var Result= Arr.OrderBy(A=>A.);

            #endregion
            #region 3. Sort a list of products by units in stock from highest to lowest.
            //var Result = ProductsList.OrderByDescending(P => P.UnitsInStock);
            //foreach (var item in Result)
            //  Console.WriteLine(item);

            #endregion
            #region 4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            //String[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            //var Result=Arr.OrderBy(A=>A.Length).ThenBy(A=>A);
            //foreach(var item in Result) 
            //    Console.WriteLine(item);

            #endregion
            #region 5. Sort first by-word length and then by a case-insensitive sort of the words in an array.
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var Result = Arr.OrderBy(A => A.Length).ThenBy(A => A);
            //foreach (var item in Result)
            //    Console.WriteLine(item);
            #endregion
            #region 6. Sort a list of products, first by category, and then by unit price, from highest to lowest.
            //var Result = ProductsList.OrderBy(P => P.Category).ThenByDescending(P=>P.UnitPrice);
            //foreach (var item in Result)
            //    Console.WriteLine(item);
            #endregion
            #region 7. Sort first by-word length and then by a case-insensitive descending sort of the words in an array.
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var Result = Arr.OrderBy(A => A.Length).ThenByDescending(A => A);
            //foreach (var item in Result)
            //    Console.WriteLine(item);

            #endregion
            #region 8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            //var Result = Arr.Where((A, I) => I == 1).Reversed();
            //foreach (var item in Result)
            //    Console.WriteLine(item);

            #endregion
            #endregion
            #region LINQ – Transformation Operators
            #region 1. Return a sequence of just the names of a list of products.
            //var Result = ProductsList.Select(P => P.ProductName);
            //foreach (var item in Result) {
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).
            //String[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var Result = words.Select(W => new
            //{
            //    uppercase = W.ToUpper(),
            //    lowercase = W.ToLower(),
            //});
            //foreach (var item in Result) {
            //    Console.WriteLine(item);
            //}       

            #region 3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.
            //var Result = ProductsList.Select(P => new
            //{
            //   P.ProductName,
            //   P.ProductID,
            //   P.UnitsInStock,
            //   Price=P.UnitPrice

            //});
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region  4.Determine if the value of int in an array matches their position in the array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = Arr.Select((N, i) => new
            //{
            //    Number = N,
            //    matchnumber = i == N ? "true":"false"
            //} );
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion
            #region 5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };


            #endregion
            #region 6. Select all orders where the order total is less than 500.00.
            //var Result = CustomersList.SelectMany(O => O.Orders).Where(O => O.Total < 500.00M);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region 7. Select all orders where the order was made in 1998 or later.

            var Result = CustomersList.SelectMany(O => O.Orders).Where(O => O.OrderDate.Year >=1998);
            foreach (var item in Result)
            {
                Console.WriteLine(item);
            }
            #endregion


            #endregion


            #endregion





        }
    }
}