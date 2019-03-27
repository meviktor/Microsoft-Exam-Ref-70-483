using System;
using System.Linq;

namespace Chapter1
{
    //Making a parallel query sequential
    public static class Listing_1_25
    {
        public static void Main()
        {
            var numbers = Enumerable.Range(0, 10);
            var paralellResult = numbers.AsParallel().AsOrdered()
                .Where(i => i % 2 == 0).AsSequential();

            foreach(var item in paralellResult.Take(5))
                Console.WriteLine(item);
        }
    }
}