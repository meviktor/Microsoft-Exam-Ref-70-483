using System;
using System.Threading.Tasks;

namespace Chapter1
{
    //Adding a continuation
    public static class Listing_1_10
    {
        public static void Main()
        {
            Task<int> t = Task.Run(() =>
            {
                //throw new Exception();
                return 42;
            }).ContinueWith((i) =>
            {
                //Console.WriteLine("Continuing t...");
                return i.Result * 2;
            });

            Console.WriteLine(t.Result); //Displays 84
        }
    }
}