using System;

namespace Chapter1
{
    //Creating a lamba expression with multiplie statements
    public static class Listing_1_80
    {
        public delegate int Calculate(int x, int y);

        public static void Main()
        {
            Calculate calc = (x, y) =>
            {
                Console.WriteLine("Adding numbers");
                return x + y;
            };

            int result = calc(3, 4);
        }
    }
}