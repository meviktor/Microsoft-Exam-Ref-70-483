using System;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter1
{
    //Using a CancellationToken
    public class Listing_1_42
    {
        public static void Main()
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            CancellationToken token = cancellationTokenSource.Token;

            Task task = Task.Run(() => 
            {
                while (!token.IsCancellationRequested/*true*/)
                {
                    Console.Write("*");
                    Thread.Sleep(1000);
                }
            },token); //token parameter is not necessary in this example
            Console.WriteLine("Press enter to stop the task");
            Console.ReadLine();
            cancellationTokenSource.Cancel();

            //Thread.Sleep(1000);
            Console.WriteLine("Press enter to end the application");
            //Console.WriteLine(task.Status);
            Console.ReadLine();
        }
    }
}