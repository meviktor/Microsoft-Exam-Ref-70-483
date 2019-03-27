using System;

namespace Chapter1
{
    //goto in a switch statement
    public static class Listing_1_63
    {
        public static void Main()
        {
            int i = 1;
            switch (i)
            {
                case 1:
                    {
                        Console.WriteLine("Case 1");
                        goto case 2;
                    }
                case 2:
                    {
                        Console.WriteLine("Case 2");
                        break;
                    }
            }
        }
    }
}