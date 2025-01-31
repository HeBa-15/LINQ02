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
        }
    }
}