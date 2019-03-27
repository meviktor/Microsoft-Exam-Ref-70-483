using System;
using System.Linq;

namespace Chapter1
{
    public static class Listing_1_23
    {
        //Unordered parallel query
        public static void Main()
        {
            var numbers = Enumerable.Range(0, 10);
            var paralellResult = numbers.AsParallel()
                .Where(i => i % 2 == 0)
                .ToArray();

            foreach(var i in paralellResult)
                Console.WriteLine(i);
        }
    }
}