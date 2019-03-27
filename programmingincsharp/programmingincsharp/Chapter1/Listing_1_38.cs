using System.Threading;

namespace Chapter1
{
    //Generated code from a lock statement
    public static class Listing_1_38
    {
        public static void Main()
        {
            object gate = new object();
            bool __lockTaken = false;
            try
            {
                Monitor.Enter(gate, ref __lockTaken);
            }
            finally
            {
                if (__lockTaken)
                    Monitor.Exit(gate);
            }
        }
    }
}