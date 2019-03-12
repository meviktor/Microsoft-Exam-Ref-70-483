using System;
using System.Threading.Tasks;

namespace Chapter1
{
    //Starting a new task
    public static class Listing_1_8
    {
        public static void Main()
        {
            Task t = Task.Run(() =>
            {
                for(int x = 0; x < 100; x++)
                {
                    Console.WriteLine('*');
                }
            });

            t.Wait();
        }
    }
}