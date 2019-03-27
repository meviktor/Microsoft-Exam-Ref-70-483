using System;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter1
{
    //Setting timeout on a task
    public static class Listing_1_45
    {
        public static void Main()
        {
            Task longRunning = Task.Run(() =>
            {
                Thread.Sleep(10000);
            });

            int index = Task.WaitAny(new[] { longRunning }, 1000);

            if (index == -1)
                Console.WriteLine("Task timed out");
        }
    }
}
