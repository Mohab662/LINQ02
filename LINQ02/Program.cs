using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using static LINQ02.ListGenerators;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace LINQ02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Element Operators

            //1. Get first Product out of Stock 
            //var result1 = ProductList.FirstOrDefault();
            //Console.WriteLine(result1);

            //2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            //var result2 = ProductList.FirstOrDefault(p => p.UnitPrice > 100000, null);

            //3. Retrieve the second number greater than 5 
            //int[] Arr01 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result3 = Arr01.Order().Where(p => p > 5).Skip(1).FirstOrDefault();
            // Console.WriteLine(result3);

            #endregion

            #region LINQ - Aggregate Operators

            //1.Uses Count to get the number of odd numbers in the array
            //int[] Arr02 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result04 = Arr02.Count(p => p % 2 == 1);
            //Console.WriteLine(result04);

            //2. Return a list of customers and how many orders each has.
            //var result05 = CustomerList.Select(c => new { c.CustomerName, OrdersCount = c.Orders.Count() });
            //foreach (var item in result05)
            //{
            //    Console.WriteLine(item);
            //}

            //3. Return a list of categories and how many products each has
            //var result06 = ProductList.GroupBy(p => p.Category).Select(g => new { Category = g.Key, ProductCount = g.Count() });
            //foreach (var item in result06)
            //{
            //    Console.WriteLine(item);
            //}

            //4. Get the total of the numbers in an array.
            //int[] Arr3 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result07 = Arr3.Sum();
            //Console.WriteLine(result07);


            //5. Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //int totalCharacters = words.Sum(w => w.Length);
            //Console.WriteLine(totalCharacters);

            //6. Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //int LengthOfTheShortestWord = words.Select(w => w.Length).Min();
            //Console.WriteLine(LengthOfTheShortestWord);

            //7. Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //int LengthOfTheLongestWord = words.Select(w => w.Length).Max();
            //Console.WriteLine(LengthOfTheLongestWord);

            //8. Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First)
            //var AverageLengthOfTheWord = words.Select(w => w.Length).Average();
            //Console.WriteLine(AverageLengthOfTheWord);

            //9. Get the total units in stock for each product category.
            //var result08 = ProductList.GroupBy(c => c.Category).Select(p => new {p.Key, TotalUnitsInStock = p.Sum(p => p.UnitsInStock)});
            //foreach (var item in result08)
            //{
            //    Console.WriteLine(item);
            //}

            //10. Get the cheapest price among each category's products
            //var result09= ProductList.GroupBy(c => c.Category).Select(p => new { p.Key, CheapestPrice = p.Min(p => p.UnitPrice) });
            //foreach (var item in result09)
            //{
            //    Console.WriteLine(item);
            //}

            //11. Get the products with the cheapest price in each category (Use Let)
            //var cheapest = ProductList.GroupBy(p => p.Category).Select(g => new
            //{
            //    Category = g.Key,
            //    CheapestPrice = g.Min(p => p.UnitPrice),
            //    Products = g.Where(p => p.UnitPrice == g.Min(p2 => p2.UnitPrice))
            //});

            //foreach (var category in cheapest)
            //{
            //    Console.WriteLine($"The cheapest products in {category.Category} are:");
            //    foreach (var product in category.Products)
            //    {
            //        Console.WriteLine(product);
            //    }
            }

            //12. Get the most expensive price among each category's products.
            //var result11 = from p in ProductList
            //               group p by p.Category into g
            //               select new
            //               {
            //                   Category = g.Key,
            //                   TotalUnitsInStock = g.Max(p => p.UnitPrice)
            //               };
            //foreach (var item in result11)
            //{
            //    Console.WriteLine(item);
            //}

            //13. Get the products with the most expensive price in each category.
            //var result12 = from p in ProductList
            //               group p by p.Category into g
            //               let maxPrice = g.Max(p => p.UnitPrice)
            //               select new
            //               {
            //                   Category = g.Key,
            //                   Products = g.Where(p => p.UnitPrice == maxPrice)
            //               };

            //14. Get the average price of each category's products.
            //var result13 = from p in ProductList
            //               group p by p.Category into g
            //               select new
            //               {
            //                   Category = g.Key,
            //                   Avg = g.Average(p => p.UnitPrice)
            //               };
            //foreach (var item in result13)
            //{
            //    Console.WriteLine(item);




            //}
            #endregion

            #region LINQ - Set Operators
            //1. Find the unique Category names from Product List
            //var result14 = ProductList.Select(c => c.Category).Distinct();
            //foreach (var item in result14)
            //{
            //    Console.WriteLine(item);
            //}

            //2. Produce a Sequence containing the unique first letter from both product and customer names.
            //var result15 = ProductList.Select(p => p.ProductName[0]).Union(CustomerList.Select(c => c.CustomerName[0])).Distinct();
            //foreach (var item in result15)
            //{
            //    Console.WriteLine(item);
            //}

            //3. Create one sequence that contains the common first letter from both product and customer names.
            //var result16= ProductList.Select(p => p.ProductName[0]).Intersect(CustomerList.Select(c => c.CustomerName[0]));
            //foreach (var item in result16)
            //{
            //    Console.WriteLine(item);
            //}

            //4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.
            //var result17 = ProductList.Select(p => p.ProductName[0]).Except(CustomerList.Select(c => c.CustomerName[0]));
            //foreach (var item in result17)
            //{
            //    Console.WriteLine(item);
            //}

            //5. Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates
            //var result17 = ProductList.Select(p => p.ProductName.TakeLast(3).ToArray()).Concat(CustomerList.Select(c => c.CustomerName.TakeLast(3).ToArray()));
            //foreach (var item in result17)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region LINQ - Partitioning Operators
            //1. Get the first 3 orders from customers in Washington
            //var result18 = CustomerList.Where(c => c.City == "Washington").SelectMany(o=>o.Orders).Skip(3);

            //2. Get all but the first 2 orders from customers in Washington.
            //var result19 = CustomerList.Where(c => c.City == "Washington").SelectMany(o => o.Orders).Skip(2);

            //3. Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result20 = numbers.TakeWhile((N, I) => N < I);

            //4.Get the elements of the array starting from the first element divisible by 3.
            //int[] numbers01 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result21 = numbers.SkipWhile(N=>N%3!=0);

            //5. Get the elements of the array starting from the first element less than its position.
            //int[] numbers02 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result22 = numbers.SkipWhile((N, I) => N > I);


            #endregion

            #region LINQ - Quantifiers
            //1. Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'.
            //string[] words05 = File.ReadAllLines("dictionary_english.txt");
            //bool words01 = words05.Any(w => w.Contains("ei"));

            //2. Return a grouped a list of products only for categories that have at least one product that is out of stock.
            //var result23 = ProductList.GroupBy(p => p.Category).Where(g => g.Any(p => p.UnitsInStock > 0)).Select(p => p);
            //foreach (var item in result23)
            //{
            //    foreach (var item1 in item)
            //    {
            //        Console.WriteLine(item1);
            //    }

            //}

            //3. Return a grouped a list of products only for categories that have all of their products in stock.
            //var result24 = ProductList.GroupBy(p => p.Category).Where(g => g.All(p => p.UnitsInStock > 0)).Select(p => p);
            //foreach (var item in result24)
            //{
            //    foreach (var item1 in item)
            //    {
            //        Console.WriteLine(item1);
            //    }
            //}
            #endregion

            #region LINQ – Grouping Operators
            //1-Use group by to partition a list of numbers by their remainder when divided by 5
            //List<int> numberss = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //var result25 = numberss.GroupBy(N => N % 5).Select(g => new
            //{
            //    Remainder = g.Key,
            //    Numbers = g.ToList()
            //});

            //foreach (var item in result25)
            //{
            //    Console.WriteLine($"Remainder {item.Remainder}\n{string.Join("\n", item.Numbers)}\n");
            //}

            //2-Uses group by to partition a list of words by their first letter.Use dictionary_english.txt for Input
            //string[] words06 = File.ReadAllLines("dictionary_english.txt");
            //var result26 = words06.GroupBy(w => w.ElementAt(0));
            //foreach (var item in result26)
            //{
            //    foreach (var item1 in item)
            //    {
            //        Console.WriteLine(item1);
            //    }

            //}


            //3-Consider this Array as an Input
            //string[] Arr08 = { "from", "salt", "earn", "last", "near", "form" };
            //var result27=Arr08.GroupBy(a=>a,new MyCustomCompare()).Select(x => x.Key);
            //foreach (var item in result27)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
        }
    }
}