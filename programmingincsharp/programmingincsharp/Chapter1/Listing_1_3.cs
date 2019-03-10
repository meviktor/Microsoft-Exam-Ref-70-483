using System;
using System.Threading;

namespace Chapter1
{
    //Using the ParametrizedThreadStart
    public static class Listing13
    {
        public static void ThreadMethod(object o)
        {
            for (int i = 0; i < (int)o; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);

                Thread.Sleep(0);
            }
        }
        public static void Main()
        {
            Thread t = new Thread(new ParameterizedThreadStart(ThreadMethod));
            t.IsBackground = true;

            t.Start(5);
            t.Join();
        }
    }
}