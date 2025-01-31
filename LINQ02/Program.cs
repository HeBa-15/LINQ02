namespace LINQ02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Ordering Operators [Order by, Then By , Asc , Desc]

            //Order By

            //Select * from Products Order by Name asc, Price Desc


            // Fluent Syntax

            //var result = ProductList.OrderBy(p => p.UnitsInStock).ThenByDescending(p => p.UnitPrice);

            //Query Syntax

            //var result = from product in ProductList
            //             orderby product.UnitsInStock, product.UnitPrice descending
            //             select product;


            #endregion


        }
    }
}