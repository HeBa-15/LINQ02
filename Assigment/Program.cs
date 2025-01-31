using System.Diagnostics;
using System.Security.Cryptography;
using static Assigment.ListGenerators;


namespace Assigment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Restriction Operators


            #region Q 1. Find all products that are out of stock.

            // var result = ProductList.Where(P => P.UnitsInStock == 0);

            //var result = from p in ProductList
            //             where p.UnitsInStock == 0
            //             select p;

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region Q 2. Find all products that are in stock and cost more than 3.00 per unit.

            //var result = ProductList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00m);

            //var result = from p in ProductList
            //             where p.UnitsInStock > 0
            //             && p.UnitPrice > 3.00m
            //             select p;

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion


            #region Q 3. Returns digits whose name is shorter than their value.



            // String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result = Arr
            //.Select((name, index) => new { Name = name, Value = index })
            //.Where(x => x.Name.Length < x.Value)
            //.Select(x => x.Name);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}



            #endregion

            #endregion


            #region  LINQ - Element Operators

            #region Q 1. Get first Product out of Stock 

            //var result = ProductList.First(product => product.UnitsInStock == 0);

            //Console.WriteLine(result);


            #endregion

            #region Q 2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.

            //var result = ProductList.FirstOrDefault(p => p.UnitPrice>1000m);
            //Console.WriteLine(result);

            #endregion


            #region Q 3. Retrieve the second number greater than 5


            // int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            // var result = Arr
            //.Where(n => n > 5)
            //.OrderBy(n => n)
            //.Skip(1)
            //.FirstOrDefault();

            // Console.WriteLine(result);

            #endregion


            #endregion


            #region LINQ - Aggregate Operators

            #region Q 1.Uses Count to get the number of odd numbers in the array

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //int result = Arr.Count(n => n % 2 != 0);

            //Console.WriteLine(result);

            #endregion

            #region Q 2. Return a list of customers and how many orders each has.

            //   var result = CustomerList
            //.Select(c => new { c.CustomerName, OrderCount = c.Orders.Count() })
            //.ToList();


            //   foreach (var item in result)
            //   {
            //       Console.WriteLine(item);
            //   }
            #endregion

            #region Q 3. Return a list of categories and how many products each has

            // var result = ProductList
            //.GroupBy(p => p.Category)
            //.Select(g => new { Category = g.Key, ProductCount = g.Count() })
            //.ToList();

            // foreach (var item in result)
            // {
            //     Console.WriteLine(item);
            // }

            #endregion

            #region Q 4. Get the total of the numbers in an array.

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Sum();

            //Console.WriteLine(result);


            #endregion

            #region Q 5. Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //int result = words.Sum(word => word.Length);

            //Console.WriteLine(result);

            #endregion

            #region Q 6. Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //int result = words.Min(word => word.Length);
            //Console.WriteLine(result);

            #endregion

            #region Q 7. Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //int result = words.Max(word => word.Length);
            //Console.WriteLine(result);

            #endregion

            #region Q 8. Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //double result = words.Average(word => word.Length);
            //Console.WriteLine(result);



            #endregion

            #region Q 9. Get the total units in stock for each product category.

            //    var result = ProductList
            //                 .GroupBy(p => p.Category)
            //                 .Select(g => new { Category = g.Key, TotalStock = g.Sum(p => p.UnitsInStock) })
            //                 .ToList();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q 10. Get the cheapest price among each category's products


            //var cheapestPrices = ProductList
            //                      .GroupBy(p => p.Category)
            //                      .Select(g => new { Category = g.Key, CheapestPrice = g.Min(p => p.UnitPrice) })
            //                      .ToList();

            //foreach (var item in cheapestPrices)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q 11. Get the products with the cheapest price in each category (Use Let)

            //var result = from p in ProductList
            //                       group p by p.Category into g
            //                       let minPrice = g.Min(p => p.UnitPrice)
            //                       select new { Category = g.Key, Product = g.First(p => p.UnitPrice == minPrice) };

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q 12. Get the most expensive price among each category's products.

            //var result = ProductList
            //                      .GroupBy(p => p.Category)
            //                      .Select(g => new { Category = g.Key,  ExpensivePrice= g.Max(p => p.UnitPrice) })
            //                      .ToList();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region Q 13. Get the products with the most expensive price in each category.

            //var result = from p in ProductList
            //             group p by p.Category into g
            //             let maxPrice = g.Max(p => p.UnitPrice)
            //             select new { Category = g.Key, Product = g.First(p => p.UnitPrice == maxPrice) };

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q 14. Get the average price of each category's products.

            //var result = ProductList
            //                      .GroupBy(p => p.Category)
            //                      .Select(g => new { Category = g.Key, ExpensivePrice = g.Average(p => p.UnitPrice) })
            //                      .ToList();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
           
            #endregion


        }
    }
}