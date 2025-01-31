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
        }
    }
}