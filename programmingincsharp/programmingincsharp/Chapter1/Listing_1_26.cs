using System;
using System.Linq;

namespace Chapter1
{
    //Using ForAll
    public static class Listing_1_26
    {
        public static void Main()
        {
            var numbers = Enumerable.Range(0, 20);

            var parallelResult = numbers.AsParallel().
                Where(i => i % 2 == 0);

            parallelResult.ForAll(e => Console.WriteLine(e));
        }
    }
}