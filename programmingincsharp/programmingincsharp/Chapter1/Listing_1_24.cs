using System;
using System.Linq;

namespace Chapter1
{
    //Ordered parallel query
    public static class Listing_1_24
    {
        public static void Main()
        {
            var numbers = Enumerable.Range(0, 10);
            var paralellResult = numbers.AsParallel().AsOrdered()
                .Where(i => i % 2 == 0)
                .ToArray();

            foreach (var i in paralellResult)
                Console.WriteLine(i);
        }
    }
}
