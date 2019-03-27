using System;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter1
{
    //Creating a deadlock
    public static class Listing_1_37
    {
        public static void Main()
        {
            object lockA = new object();
            object lockB = new object();

            var up = Task.Run(() =>
            {
                lock (lockA)
                {
                    Thread.Sleep(1000);
                    lock (lockB)
                    {
                        Console.WriteLine("Locked A and B");
                    }
                }
            });

            lock (lockB)
            {
                lock (lockA)
                {
                    Console.WriteLine("Locked A and B");
                }
            }

            up.Wait();
        }
        //Never ran longer than a few seconds
    }
}