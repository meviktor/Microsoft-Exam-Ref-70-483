using System;

namespace Chapter1
{
    //Exception when raising an event
    public class PubWithEventHandler
    {
        public event EventHandler OnChange = delegate { };

        public void Raise()
        {
            OnChange(this, EventArgs.Empty);
        }
    }
    
    public static class Listing_1_86
    {
        public static void CreateAndRise()
        {
            PubWithEventHandler p = new PubWithEventHandler();

            p.OnChange += (sender, e) => Console.WriteLine("Subscriber 1 called");
            p.OnChange += (sender, e) => throw new Exception();
            p.OnChange += (sender, e) => Console.WriteLine("Subscriber 3 called");

            p.Raise();
        }

        public static void Main()
        {
            CreateAndRise();
        }
    }
}