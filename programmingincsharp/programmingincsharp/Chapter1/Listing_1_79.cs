using System;

namespace Chapter1
{
    //Lambda expression to create a delegate
    public static class Listing_1_79
    {
        public delegate int Calculate(int x, int y);

        public static void Main()
        {
            Calculate calc = (x, y) => x + y;
            Console.WriteLine(calc(3, 4));
            calc = (x, y) => x * y;
            Console.WriteLine(calc(3, 4));
        }
    }
}