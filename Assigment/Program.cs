using System.Diagnostics;
using System.Security.Cryptography;
using System.Threading;
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


            #region LINQ - Ordering Operators


            #region Q 1. Sort a list of products by name

            //var result = ProductList.OrderBy(p => p.ProductName).ToList();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q2. Uses a custom comparer to do a case-insensitive sort of the words in an array.


            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var sortedArr = Arr
            //                  .OrderBy(word => word, StringComparer.OrdinalIgnoreCase)
            //                  .ToArray();

            //foreach (var item in sortedArr)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q 3. Sort a list of products by units in stock from highest to lowest.

            //var result = ProductList
            //                    .OrderByDescending(p => p.UnitsInStock)
            //                    .ToList();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q 4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.

            // string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

            //var result = Arr
            //            .OrderBy(word => word.Length)
            //            .ThenBy(word => word)
            //            .ToArray();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region Q5. Sort first by-word length and then by a case-insensitive sort of the words in an array.


            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result = Arr
            //                .OrderBy(word => word.Length)
            //                .ThenBy(word => word, StringComparer.OrdinalIgnoreCase)
            //                .ToArray();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q 6. Sort a list of products, first by category, and then by unit price, from highest to lowest.

            //var result = ProductList.OrderBy(p => p.Category).ThenByDescending(p=>p.UnitPrice);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);

            //}

            #endregion

            #region Q 7. Sort first by-word length and then by a case-insensitive descending sort of the words in an array.

            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result= Arr
            //            .OrderBy(x=>x.Length)
            //            .ThenByDescending(x => x, StringComparer.OrdinalIgnoreCase)
            //           .ToArray();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q 8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.


            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

            //var result = Arr
            //            .Where(word => word.Length > 1 && word[1] == 'i')
            //            .Reverse()
            //            .ToList();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);

            //}

            #endregion



            #endregion

            #region LINQ – Transformation Operators

            #region  Q 1. Return a sequence of just the names of a list of products

            //var result = ProductList.Select(p => p.ProductName);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q 2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).


            //String[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //var result = words
            //                .Select(word => new { Upper = word.ToUpper(), Lower = word.ToLower() })
            //                .ToList();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q 3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.

            //var result = ProductList
            //                       .Select(p => new { p.ProductName, Price = p.UnitPrice, p.UnitsInStock })
            //                       .ToList();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q 4. Determine if the value of int in an array matches their position in the array.

            // int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = Arr
            //           .Select((value, index) => new { Value = value, Index = index })
            //           .ToList();

            //Console.WriteLine("Number : In-Place ?");
            //foreach (var item in result)
            //{

            //    Console.WriteLine($" {item.Value} : {item.Value == item.Index}");
            //}

            #endregion

            #region Q 5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.

            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var result = from a in numbersA
            //            from b in numbersB
            //            where a < b
            //            select new { A = a, B = b };

            //Console.WriteLine("Pairs where a < b:");
            //foreach (var item in result)
            //{
            //    Console.WriteLine($" {item.A} is less than {item.B}");
            //}

            #endregion

            #region Q 6. Select all orders where the order total is less than 500.00

            //var result = CustomerList
            //           .SelectMany(c => c.Orders)
            //           .Where(o => o.Total < 500.00m)
            //           .ToList();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region Q 7. Select all orders where the order was made in 1998 or later

            //var result = CustomerList
            //           .SelectMany(c => c.Orders)
            //           .Where(o => o.OrderDate.Year >= 1998)
            //           .ToList();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion




            #endregion
        }
    }
}