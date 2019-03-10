using System;
using System.Threading;

namespace Chapter1
{
    //Using a backgroud thread
    public static class Listing12
    {
        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(1000);
            }
        }
        public static void Main()
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            t.IsBackground = true;
            t.Start();
            /*for(int i = 1; i < 5000; i++)
            {
                Console.WriteLine(i);
            }*/
        }
    }
}