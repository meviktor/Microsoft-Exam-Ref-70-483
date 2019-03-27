using System;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter1
{
    //Adding a continuation for canceled tasks
    public static class Listing_1_44
    {
        public static void Main()
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            CancellationToken token = cancellationTokenSource.Token;

            Task task = Task.Run(() =>
            {
                while (!token.IsCancellationRequested)
                {
                    Console.Write("*");
                    Thread.Sleep(1000);
                }
                //token.ThrowIfCancellationRequested();
            }, token).ContinueWith((t) =>
            {
                Console.WriteLine("Status of t task is: {0}", t.Status);
                t.Exception.Handle((e) => true); //t.Exception is null!!!!!
                Console.WriteLine("You have canceled the task."); //...so this line won't be seen on the console.
            }, TaskContinuationOptions.OnlyOnCanceled);

            Console.WriteLine("Press enter to stop the task");
            Console.ReadLine();
            cancellationTokenSource.Cancel();

            Console.WriteLine("Press enter to end the application");
            Console.ReadLine();
        }
    }
}