using System;

namespace Chapter1
{
    //Using a delegate
    public static class Listing_1_75
    {
        public delegate int Calculate(int x, int y);

        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }
        public static void Main()
        {
            Calculate calc = Add;
            Console.Write(calc(3, 4));

            calc = Multiply;
            Console.WriteLine(calc(3, 4));
        }
    }
}