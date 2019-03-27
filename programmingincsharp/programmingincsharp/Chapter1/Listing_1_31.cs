using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter1
{
    //Enumerating a ConcurrentBag
    public static class Listing_1_31
    {
        public static void Main()
        {
            ConcurrentBag<int> bag = new ConcurrentBag<int>();
            Task.Run(() =>
            {
                bag.Add(42);
                Thread.Sleep(1000);
                bag.Add(21);
            });
            Task.Run(() =>
            {
                foreach (int i in bag)
                    Console.WriteLine(i);
            }).Wait();
        }
    }
}