using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using static Demoo.ListGenerator;
namespace Demoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Aggregate Operators

            #region 1. Get the total units in stock for each product category.
            //var Result=ProductsList.Sum();
         
            //var Result = ProductList.GroupBy(P => P.Category).Select(P => new
            //{
            //    P.Key,
            //    count = P.Sum(U => U.UnitsInStock)
            //});
            //foreach (var item in Result)
            //{
            //   Console.WriteLine(item);
            //}
            #endregion
            #region 2. Get the cheapest price among each category's products
            //var Result = ProductList.GroupBy(P => P.Category).Select(P => new
            //{
            //   P.Key,
            //   cheapest = P.Min(P=>P.UnitPrice)
            //});
            //foreach (var item in Result)
            //{
            // Console.WriteLine(item);
            //}


            #endregion
            #region 3. Get the products with the cheapest price in each category (Use Let)
            //var Result = from P in ProductsList
            //             group P by P.Category
            //             into C
            //             let cheapest = g.Where(p => p.UnitPrice == g.Min(a => a.UnitPrice))
            //             from c in cheapest
            //             select c;
            //foreach (var result in Result)
            //{
            //    Console.WriteLine(result);
            //}
            #endregion
            #region 4. Get the most expensive price among each category's products.
            //var Result = ProductsList.GroupBy(C => C.Category).Select(C => new
            //{
            //    C.Key,
            //    expensive = C.Max(C => C.UnitPrice)
            //});
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region 5. Get the products with the most expensive price in each category.

            //var Result =ProductsList.GroupBy(c => c.Category).SelectMany(p => p.Where(c => c.UnitPrice == p.Max(c => c.UnitPrice)));
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item.ProductName);
            //    Console.WriteLine(item.UnitPrice);
            //}


            #endregion
            #region 6. Get the average price of each category's products.
            //var Result = ProductsList.GroupBy(P => P.Category).Select(P => new
            //{
            //    P.Key,
            //    avg = P.Average(P => P.UnitPrice),
            //});

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);


            #endregion
            #endregion
            #region LINQ - Set Operators
            #region 1. Find the unique Category names from Product List
            //var Result = ProductsList.Select(P => P.Category).Distinct();
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 2. Produce a Sequence containing the unique first letter from both product and customer names
            //var Result = ProductsList.Select(P => P.ProductName[0]).Union(CustomersList.Select(C => C.CustomerName[0]));
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 3. Create one sequence that contains the common first letter from both product and customer names.
            //var Result = ProductsList.Select(P => P.ProductName[0]).Intersect(CustomersList.Select(C => C.CustomerName[0]));
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region 4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.
            //var Result = ProductsList.Select(P => P.ProductName[0]).Except(CustomersList.Select(C => C.CustomerName[0]));
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region 5. Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates
            //var Result = ProductsList.Select(P => P.ProductName[^3..]).Concat(CustomersList.Select(C => C.CustomerName[^3..]));
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #endregion
            #region LINQ - Partitioning Operators

            #region 1. Get the first 3 orders from customers in Washington
            //var Result = CustomersList.Where(C=>C.Region== "WA").SelectMany(O=>O.Orders).Take(3);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);   
            //}
            #endregion
            #region 2. Get all but the first 2 orders from customers in Washington.
            //var Result = CustomersList.Where(C => C.Region == "WA").SelectMany(O => O.Orders).Skip(2);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 3. Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = numbers.TakeWhile((n, i) => n > i);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 4.Get the elements of the array starting from the first element divisible by 3.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = numbers.SkipWhile(n => n % 3 != 0);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 5. Get the elements of the array starting from the first element less than its position.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = numbers.SkipWhile((n, i) => n > i);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion
            #region LINQ - Quantifiers

            #region 1. Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'.
            //var Words = File.ReadAllLines("H:\\C# Projects\\Demoo\\Demoo\\dictionary_english.txt");
            //var Result = Words.Any(W=> W.Contains('ei');
            //Console.WriteLine(Result);


            #endregion
            #region 2. Return a grouped a list of products only for categories that have at least one product that is out of stock.
            //var Result = ProductsList.GroupBy(C => C.Category).Where(C => C.Any(P => P.UnitsInStock == 0)).Select(p=>p);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item.Key);
            //    foreach (var P in item)
            //    {
            //        Console.WriteLine(P);
            //    }
            //}

            #endregion
            #region 3. Return a grouped a list of products only for categories that have all of their products in stock.
            //var Result = ProductsList.GroupBy(C => C.Category).Where(C => C.All(P => P.UnitsInStock > 0)).Select(p => p); ;
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item.Key);
            //    foreach (var P in item)
            //    {
            //        Console.WriteLine(P);
            //    }
            //}

            #endregion

            #endregion
            #region LINQ – Grouping Operators
            #region 1.Use group by to partition a list of numbers by their remainder when divided by 5
            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //var Result = numbers.GroupBy(n => n % 5 ==0);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"numbers with remainder of {item.key} when divided by 5 :");
            //    foreach (var item1 in item)
            //    {
            //        Console.WriteLine(item1);
            //    }
            //}



            #endregion
            #region 2.Uses group by to partition a list of words by their first letter.
            //Use dictionary_english.txt for Input
            //var Words = File.ReadAllLines("H:\\C# Projects\\Demoo\\Demoo\\dictionary_english.txt");
            //var Result = Words.GroupBy(W => W[0]);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //    foreach (var item1 in item)
            //    {
            //        Console.WriteLine(item1);
            //    }
            //}


            #endregion
            #region  3.Consider this Array as an Input
            //String[] Arr = { "from", "salt", "earn", " last", "near", "form" };
            ////Use Group By with a custom comparer that matches words that are consists of the same Characters Together
            //var Result=Arr.GroupBy(A=>A,new EqualityComparer());
            //foreach (var item in Arr)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion

        }
    }
}
