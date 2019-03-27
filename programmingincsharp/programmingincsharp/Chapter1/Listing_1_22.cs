using System;
using System.Linq;

namespace Chapter1
{
    //Using AsParallel
    public static class Listing_1_22
    {
        public static void Main()
        {
            var numbers = Enumerable.Range(0, 100000000);
            var paralellResult = numbers.AsParallel()
                .Where(i => i % 2 == 0)
                .ToArray();

            /*foreach(var item in paralellResult)
            {
                Console.WriteLine(item);
            }*/
        }
    }
}