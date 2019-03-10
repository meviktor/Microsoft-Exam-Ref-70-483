using System;
using System.Threading;

namespace Chapter1
{
    //Queuing some work to the thread pool
    public static class Listing17
    {
        public static void Main()
        {
            ThreadPool.QueueUserWorkItem((s) =>
            {
                Console.WriteLine("Working on a thread from threadpool.");
            });

            Console.ReadKey();
        }
    }
}
