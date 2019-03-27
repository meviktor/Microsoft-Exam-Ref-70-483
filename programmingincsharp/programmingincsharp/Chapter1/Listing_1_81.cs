using System;

namespace Chapter1
{
    //Using the Action delegate
    public static class Listing_1_81
    {
        public static void Main()
        {
            Action<int, int> calc = (x, y) =>
            {
                Console.WriteLine(x + y);
            };

            calc(3, 4);
        }
    }
}