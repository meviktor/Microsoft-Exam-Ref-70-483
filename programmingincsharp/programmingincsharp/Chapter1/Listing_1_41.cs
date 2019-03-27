using System;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter1
{
    //Compare and exchange as a nonatomic operation
    public static class Listing_1_41
    {
        static int value = 1;

        public static void Main()
        {
            Task t1 = Task.Run(() =>
            {
                if(value == 1)
                {
                    //Removing the following line will change the output
                    Thread.Sleep(1000);
                    value = 2;
                }
                //Replace the if statement above with this:
                //int newValue = 100, compareTo = 1;
                //Interlocked.CompareExchange(ref value, newValue, compareTo);
            });

            Task t2 = Task.Run(() =>
            {
                value = 3;
            });

            Task.WaitAll(t1, t2);
            Console.WriteLine(value);
        }
    }
}