using System;
using System.Threading;

namespace Chapter1
{
    //Using ThreadLocal<T>
    public static class Listing16
    {
        public static ThreadLocal<int> _field =
            new ThreadLocal<int>(() =>
            {
                return Thread.CurrentThread.ManagedThreadId;
            });

        public static void Main()
        {
            new Thread(() =>
            {
                for (int x = 0; x < _field.Value; x++)
                {
                    Console.WriteLine("Thread A: {0}", x);
                }
            }).Start();

            new Thread(() =>
            {
                for (int x = 0; x < _field.Value; x++)
                {
                    Console.WriteLine("thread B: {0}", x);
                }
            }).Start();

            Console.ReadKey();
        }
    }
}