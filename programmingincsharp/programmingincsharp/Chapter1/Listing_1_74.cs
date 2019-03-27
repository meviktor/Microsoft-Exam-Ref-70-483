using System;

namespace Chapter1
{
    //goto statement with a label
    public static class Listing_1_74
    {
        public static void Main()
        {
            int x = 3;
            if (x == 3) goto customLabel;
            x++;

        customLabel:
            Console.WriteLine(x);

            /*try
            {
                goto laby;
            }
            finally
            {
                Console.WriteLine("finally block starts...");
                Console.WriteLine("finally block ends...");
            }
        laby:
            Console.WriteLine("after the finally block...");*/
        }
    }
}
