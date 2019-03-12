using System;
using System.Threading.Tasks;

namespace Chapter1
{
    //Using Parallel.Break
    public static class Listing_1_17
    {
        public static void Main()
        {
            ParallelLoopResult result = Parallel.For(
                0, 1000, (int i, ParallelLoopState loopState) =>
                {
                    if(i == 500)
                    {
                        Console.WriteLine("Breaking loop");
                        loopState.Break();
                    }
                    return;
                });
        }
    }
}
