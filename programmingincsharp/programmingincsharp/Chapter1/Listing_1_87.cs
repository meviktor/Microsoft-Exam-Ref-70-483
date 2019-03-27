using System;
using System.Collections.Generic;
using System.Linq;

namespace Chapter1
{
    //Manually raising events with exception handling
    public class PubWithExceptionHandling
    {
        public event EventHandler OnChange = delegate { };
        public void Raise()
        {
            var exceptions = new List<Exception>();

            foreach(Delegate handler in OnChange.GetInvocationList())
            {
                try
                {
                    handler.DynamicInvoke(this, EventArgs.Empty);
                }
                catch(Exception e)
                {
                    exceptions.Add(e);
                }
            }

            if (exceptions.Any())
            {
                throw new AggregateException(exceptions);
            }
        }
    }
    public static class Listing_1_87
    {
        public static void Main()
        {
            CreateAndRaise();
        }

        private static void CreateAndRaise()
        {
            PubWithExceptionHandling p = new PubWithExceptionHandling();

            p.OnChange += (sender, e) => Console.WriteLine("Subscriber 1 called");
            p.OnChange += (sender, e) => throw new Exception();
            p.OnChange += (sender, e) => Console.WriteLine("Subscriber 3 called");

            try
            {
                p.Raise();
            }
            catch(AggregateException e)
            {
                Console.WriteLine(e.InnerExceptions.Count);
            }
        }
    }
}