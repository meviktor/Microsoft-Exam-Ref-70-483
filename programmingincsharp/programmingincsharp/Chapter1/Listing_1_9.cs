using System;
using System.Threading.Tasks;

namespace Chapter1
{
    //Using a task that returns a value.
    public static class Listing19
    {
        public static void Main()
        {
            Task<int> t = Task.Run(() =>
            {
                return 42;
            });
            Console.WriteLine(t.Result); //Displays 42
        }
    }
}