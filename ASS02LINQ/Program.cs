using Session01LinqG01.Helper;
using Session01LinqG01.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Numerics;
using static Session01LinqG01.DataSources.Source;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace ASS02LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World!");
            #region Q01
            //Get top 3 most expensive products
            //var result = ProductList.OrderByDescending(s => s.UnitPrice)
            //   .Take(3);
            #endregion
            #region Q02
            //show page 2 of products, with page size = 5
            //var result = ProductList.Skip((2 - 1) * 5).Take(5);
            #endregion
            #region Q03
            // Take products from the list as long as Their UnitPrice is less than $25(list is ordered by price).
            // var result = ProductList.OrderBy(s => s.UnitPrice).TakeWhile(s => s.UnitPrice < 25);
            #endregion
            #region Q04
            //Check if ALL products in the "Seafood" category are in stock
            //var result = ProductList.Where(s => s.Category == "Seafood").
            //    All(s => s.UnitsInStock > 0);
            #endregion
            Console.WriteLine(result);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

        }
    }
}
