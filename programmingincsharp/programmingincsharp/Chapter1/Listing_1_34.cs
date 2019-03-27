using System;
using System.Collections.Concurrent;

namespace Chapter1
{
    //Using a ConcurrentDictionary
    public static class Listing_1_34
    {
        public static void Main()
        {
            var dict = new ConcurrentDictionary<string, int>();
            if(dict.TryAdd("k1", 42))
            {
                Console.WriteLine("Added");
            }

            if(dict.TryUpdate("k1", 21, 42))
            {
                Console.WriteLine("42 updated to 21");
            }

            dict["k1"] = 42;

            int r1 = dict.AddOrUpdate("k1", 3, (s, i) => i *= 2);
            // Example using valueFactory instead of value: dict.AddOrUpdate("k1", s => { return 3; }, (s, i) => i *= 2);
            int r2 = dict.GetOrAdd("k2", 3);
            // Example using valueFactory instead of value: dict.AddOrUpdate("k1", s => { return 3; });
        }
    }
}