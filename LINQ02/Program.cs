using static LINQ02.ListGenerators;
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

        }

    }


}
