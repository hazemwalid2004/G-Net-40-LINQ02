using Session01LinqG01.Helper;
using Session01LinqG01.Models;
using System;
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
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
