using System;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter1
{
    //Using the Interlocked class
    public static class Listing_1_40
    {
        public static void Main()
        {
            int n = 0;

            var up = Task.Run(() =>
            {
                for (int i = 0; i < 1000000; i++)
                    Interlocked.Increment(ref n);
            });

            for (int i = 0; i < 1000000; i++)
                Interlocked.Decrement(ref n);

            up.Wait();
            Console.WriteLine(n);
        }
    }
}