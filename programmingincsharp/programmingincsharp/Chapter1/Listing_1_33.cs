using System;
using System.Collections.Concurrent;

namespace Chapter1
{
    //Using a ConcurrentQueue
    public static class Listing_1_33
    {
        public static void Main()
        {
            ConcurrentQueue<int> queue = new ConcurrentQueue<int>();
            queue.Enqueue(42);

            int result;
            if (queue.TryDequeue(out result))
                Console.WriteLine("Dequeued: {0}", result);
        }
    }
}