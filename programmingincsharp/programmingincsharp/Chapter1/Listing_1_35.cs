using System;
using System.Threading.Tasks;

namespace Chapter1
{
    //Accessing shared data in a multithreaded application
    public static class Listing_1_35
    {
        public static void Main()
        {
            int n = 0;

            var up = Task.Run(() =>
            {
                for (int i = 0; i < 1000000; i++)
                    n++;
            });

            for (int i = 0; i < 1000000; i++)
                n--;

            up.Wait();
            Console.WriteLine(n);
        }
    }
}