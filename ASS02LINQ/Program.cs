using Session01LinqG01.Helper;
using Session01LinqG01.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
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
            #region Q05
            // Check if the ID list contains 9 
            //int[] ids = { 3, 9, 13, 18 };
            //var result = ids.Contains(9);
            #endregion
            #region Q06
            //Group all products by Category and print each group  with its product count.
            //var result = ProductList.GroupBy(s => s.Category);
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"key = {item.Key} => count = {item.Count()}");
            //    foreach (var item1 in item)
            //    {
            //        Console.WriteLine(item1);
            //    }
            //}
            #endregion
            #region Q07
            //Group products by Category and project only product names  per group
            //var result = ProductList.GroupBy(s => s.Category);
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"key = {item.Key} => count = {item.Count()}");
            //    foreach (var item1 in item)
            //    {
            //        Console.WriteLine($"product name = { item1.ProductName}");
            //    }
            //}
            #endregion
            #region Q08
            //Find all categories that have MORE THAN 3 products
            //var result = ProductList.GroupBy(m=>m.Category).Where(n=>n.Count()>3);
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"key = {item.Key} => count = {item.Count()}");
            //}
            #endregion
            #region Q09
            // Using QUERY SYNTAX, group customers by Country, and for  each group select { Country, Count, TotalOrderValue }
            //var result = from c in CustomerList
            //             group c by c.Country
            //             into customarfilter
            //             select new {country = customarfilter.Key,count = customarfilter.Count()
            //             ,totalordervalue= customarfilter.Sum(s=>s.Orders.Sum(o=>o.Total)) };
            #endregion
            #region Q10
            //Calculate the total number of units in stock across all products
            //var result = ProductList.Sum(s=>s.UnitsInStock);
            #endregion
            #region Q11
            //Find the CHEAPEST and MOST EXPENSIVE product prices
            //var result = ProductList.Max(s => s.UnitPrice);
            //var result = ProductList.Min(s => s.UnitPrice);
            #endregion
            #region Q12
            //Get a distinct list of all product categories
            //var result = ProductList.Select(s=>s.Category).Distinct();
            #endregion
            #region Q13
            //find product IDs that are in setA but NOT in setB 
            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            //int[] setB = { 3, 6, 9, 12, 15, 13 };
            //var result = setA.Except(setB);
            #endregion
            #region Q14
            //Find countries that  appear in list1 but NOT in list2 (case -insensitive). 
            //string[] list1 = { "Germany", "France", "UK", "Spain" };
            //string[] list2 = { "france", "SPAIN", "Italy" };
            //var result = list1.Except(list2,StringComparer.OrdinalIgnoreCase);
            #endregion
            //Console.WriteLine(result);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"key = {item.Key} => count = {item.Count()}");
            //}

        }
    }
}
