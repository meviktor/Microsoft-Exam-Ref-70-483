using System;
using System.Threading.Tasks;

namespace Chapter1
{
    //Adding a continuation
    public static class Listing110
    {
        public static void Main()
        {
            Task<int> t = Task.Run(() =>
            {
                return 42;
            }).ContinueWith((i) =>
            {
                return i.Result * 2;
            });

            Console.WriteLine(t.Result); //Displays 84
        }
    }
}