using System;

namespace Chapter1
{
    //A multicast delegate
    public static class Listing_1_76
    {
        public static void MethodOne()
        {
            Console.WriteLine("MethodOne");
        }

        public static void MethodTwo()
        {
            Console.WriteLine("MethodTwo");
        }

        public delegate void Del();

        public static void Multicast()
        {
            Del d = MethodOne;
            d += MethodTwo;

            d();
        }

        public static void Main()
        {
            Multicast();
        }
    }
}
