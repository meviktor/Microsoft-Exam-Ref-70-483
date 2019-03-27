using System;
using System.Collections.Concurrent;

namespace Chapter1
{
    //Using a ConcurrentBag
    public static class Listing_1_30
    {
        public static void Main()
        {
            ConcurrentBag<int> bag = new ConcurrentBag<int>();

            bag.Add(42);
            //bag.Add(31);
            //bag.Add(42);
            bag.Add(21);

            int result;
            if (bag.TryTake(out result))
                Console.WriteLine(result);

            if (bag.TryPeek(out result))
                Console.WriteLine("There is a next item: {0}", result);
        }
    }
}